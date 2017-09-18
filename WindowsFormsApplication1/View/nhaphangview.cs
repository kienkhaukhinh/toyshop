using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using Model.BUS;
using Model.ENTITY;
using System.Text;
using Model.DAO;
using Model.VIEWMODEL;
using System.Windows.Forms;

namespace WindowsFormsApplication1.View
{
    public partial class nhaphangview : UserControl
    {

        public nhaphangview()
        {
            InitializeComponent();
            Visible = false;
            cbb_trangthai.SelectedText = "Chưa Xử Lý";
            LoadDonDatHang();
            date_trahang.Value = DateTime.Now;
        }

        private void btn_laydulieu_Click(object sender, EventArgs e)
        {
        
            if (donnhapgv.Rows.Count > 0)
            {
                donnhapgv.Rows.Clear();
            }

            DONDATHANGBUS bus = new DONDATHANGBUS();
            List<DONDATHANG> lst_ddh = new List<DONDATHANG>();
            if (cbb_trangthai.Text == "Tất Cả")
            {
                lst_ddh = bus.GetList();
            }
            else if (cbb_trangthai.Text == "Chưa Xử Lý")
            {
                lst_ddh = bus.Search(false);
            }
            else if (cbb_trangthai.Text == "Đã Xử Lý")
            {
               lst_ddh = bus.Search(true);
            }
            LoadDDH(lst_ddh);
            
        }

        public void LoadDDH(List<DONDATHANG> lst_ddh)
        {
            foreach (DONDATHANG dh in lst_ddh)
            {
                if (dh.TRANGTHAI == false)
                {
                    donnhapgv.Rows.Add(dh.ID, dh.NGAYDAT, dh.IDNCC, dh.IDNGUOIDAT, dh.TONGCONG, "Chưa Xử Lý");
                    donnhapgv[5, donnhapgv.Rows.Count - 1].Style.BackColor = Color.IndianRed;
                }
                else
                {
                    donnhapgv.Rows.Add(dh.ID, dh.NGAYDAT, dh.IDNCC, dh.IDNGUOIDAT, dh.TONGCONG, "Đã Xử Lý");
                    donnhapgv[5, donnhapgv.Rows.Count - 1].Style.BackColor = Color.Green;
                }
            }
        }

        private void cbb_trangthai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (donnhapgv.Rows.Count > 0)
            {
                donnhapgv.Rows.Clear();
            }
            DONDATHANGBUS bus = new DONDATHANGBUS();
            List<DONDATHANG> lst_ddh = new List<DONDATHANG>();
            string tt = cbb_trangthai.GetItemText(cbb_trangthai.SelectedItem);
            if (tt == "Chưa Xử Lý")
            {
                lst_ddh = bus.Search(false);
                LoadDDH(lst_ddh);

            }
            else if (tt == "Đã Xử Lý")
            {
                lst_ddh = bus.Search(true);
                LoadDDH(lst_ddh);
            }
     
            else
            {
                lst_ddh = bus.GetList();
                LoadDDH(lst_ddh);
            }

        }

        private void donnhapgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ma = int.Parse(donnhapgv[0, e.RowIndex].Value.ToString());
            DONDATHANGBUS bus = new DONDATHANGBUS();
            List<ViewCTDDH> ct = bus.GetList(ma);

            nhapkhogv.DataSource = ct;
            nhapkhogv.Columns["TENSP"].HeaderText = "Tên SP";
            nhapkhogv.Columns["SL_Nhap"].HeaderText = "SL Nhập";
            nhapkhogv.Columns["SL"].HeaderText = "SL Đặt";
            nhapkhogv.Columns["DonGia"].HeaderText = "Đơn giá";
            nhapkhogv.Columns["TongTien"].HeaderText = "Tổng";
            nhapkhogv.Columns["MASP"].Visible = false;

            foreach (DataGridViewRow row in nhapkhogv.Rows)
            {
                row.Tag = row.Cells[1].Value;
                if (row.Cells[1].Value.ToString() == row.Cells[2].Value.ToString())
                {
                    row.ReadOnly = true;
                    //tag nay de lay so luong duoc nhap hien tai
                }
            }


            if (donnhapgv[5, e.RowIndex].Value.ToString() == "Đã Xử Lý")
            {
                btn_hoantat.Enabled = false;
            }
            else
            {
                btn_hoantat.Enabled = true;
            }
        }


        private void nhapkhogv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {

                int index = e.RowIndex;
                int sl_dat = int.Parse(nhapkhogv[2,index].Value.ToString());
                int new_sl = common.ktint(e.FormattedValue.ToString());
                
                if (new_sl<0 || new_sl>sl_dat ||new_sl<(int)nhapkhogv.CurrentRow.Tag)  // IsNumeric will be your method where you will check for numebrs 
                {
                    MessageBox.Show("SL đầu vào không hợp lệ");
                    nhapkhogv.CancelEdit();
                }
            }
        }

        private void btn_hoantat_Click(object sender, EventArgs e)
        {
            int index = donnhapgv.CurrentCell.RowIndex;
            int madh = int.Parse(donnhapgv[0,index].Value.ToString());
            int index_ct = nhapkhogv.CurrentCell.RowIndex;
            List<CT_DONDATHANG> ctddh = new List<CT_DONDATHANG>();
            foreach (DataGridViewRow row in nhapkhogv.Rows)
            {
                CT_DONDATHANG ct = new CT_DONDATHANG();
                ct.IDDONDAT = madh;
                ct.IDSANPHAM = int.Parse(nhapkhogv[5,row.Index].Value.ToString());
                ct.SL_NHAP = int.Parse(nhapkhogv[1, row.Index].Value.ToString());
                ctddh.Add(ct);
            }
            DONDATHANGBUS bus = new DONDATHANGBUS();
            if (bus.Update(madh, ctddh))
           {
               MessageBox.Show("Cập nhật thành công!");
               btn_laydulieu.PerformClick();
               nhapkhogv.DataSource = null;
           }
        }

        private void donnhapgv_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip context_menu_sp = new ContextMenuStrip();
                context_menu_sp.Items.Add("Xóa", null, new EventHandler(xoadonnhap));
                context_menu_sp.Show(donnhapgv, e.X, e.Y);
            }
        }

        private void xoadonnhap(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Xóa Đơn Đặt Hàng" + "\n" + "Bạn chắc chắn chứ", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int row = donnhapgv.CurrentRow.Index;
                DONDATHANG dh = new DONDATHANG();
                DONDATHANGBUS bus = new DONDATHANGBUS();
                dh.ID = int.Parse(donnhapgv[0, row].Value.ToString());
                if (bus.Delete(dh))
                {
                    MessageBox.Show("Xóa Thành công!");
                    btn_laydulieu.PerformClick();
                    nhapkhogv.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show(Database<DONDATHANG>.error_message);
            }
        }

     
     //================================TRA HANG===//


        private void LoadDonDatHang()
        {
            DONDATHANGBUS bus = new DONDATHANGBUS();
            cbb_dondh.DataSource = bus.Search(false);
            cbb_dondh.ValueMember = "ID";
            cbb_dondh.DisplayMember = "ID";

        }

        private void cbb_dondh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DONDATHANGBUS ddhbus = new DONDATHANGBUS();
            DONDATHANG ddh = new DONDATHANG();
            NGDUNG ngdung = new NGDUNG();
            NGUOIDUNGBUS ngdungbus = new NGUOIDUNGBUS();

            NHACC ncc = new NHACC();
            NHACCBUS nccbus = new NHACCBUS();
          
            ddh = ddhbus.Search(int.Parse(cbb_dondh.Text));
            date_dh.Value = (DateTime)ddh.NGAYDAT;
            ngdung = ngdungbus.SearchName(ddh.IDNGUOIDAT);
            txt_ngtra.Text = ngdung.TENNGDUNG;
            ncc = nccbus.Search((int)ddh.IDNCC);
            txt_ncc.Text = ncc.TENNCC;

            List<ViewCTDDH> lst_ctddh = ddhbus.GetList(ddh.ID);
            foreach (ViewCTDDH ct in lst_ctddh)
            {
                ctddhgv.Rows.Add(ct.TenSP, ct.SL, 0, "");
                ctddhgv.Rows[ctddhgv.Rows.Count - 1].Tag = ct.MaSP;
            }
            

            
        }

        private void ctddhgv_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip context_menu = new ContextMenuStrip();
                context_menu.Items.Add("Xóa");
                context_menu.ItemClicked += context_menu_ItemClicked;
                context_menu.Show(ctddhgv, e.X, e.Y);
            }
        }

        void context_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Xóa")
            {
                int index = ctddhgv.CurrentCell.RowIndex;
               ctddhgv.Rows.RemoveAt(index);
            }
        }

        private void ctddhgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int new_sl = common.ktint(e.FormattedValue.ToString());
                int index = ctddhgv.CurrentRow.Index;

                if (new_sl<0 || new_sl > (int)ctddhgv[1,index].Value)  // IsNumeric will be your method where you will check for numebrs 
                {
                    
                    MessageBox.Show("SL đầu vào không hợp lệ");
                    ctddhgv.CancelEdit();
                }
            
            }
        }

        private void btn_inphieu_Click(object sender, EventArgs e)
        {

        }



 
    }
}
