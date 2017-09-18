using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using Model.ENTITY;
using Model.BUS;
using System.Windows.Forms;
using Model.DAO;

namespace WindowsFormsApplication1.View
{
    public partial class nhacungcapview : UserControl
    {
        public nhacungcapview()
        {
            InitializeComponent();
            Visible = false;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_ten.Text != "")
            {
                error_ncc.Clear();
                NHACC ncc = new NHACC();
                ncc.TENNCC = txt_ten.Text;
                ncc.SDT = txt_dienthoai.Text;
                ncc.DIACHI = txt_dchi.Text;
                ncc.EMAIL = txt_email.Text;
                NHACCBUS nccbus = new NHACCBUS();
                if (nccbus.Add(ncc))
                {
                    MessageBox.Show("Thành công!");
                }
                else
                {
                    MessageBox.Show("Lỗi:" + Database<NHACC>.error_message);
                }
            }
            else
            {
                error_ncc.SetError(txt_ten, "Tên NCC không được rỗng");
            }
        }

        private void btn_laydulieu_ncc_Click(object sender, EventArgs e)
        {
            NHACCBUS nccbus = new NHACCBUS();
            List<NHACC> list_ncc = nccbus.GetList();
            nhacungcapdgv.DataSource = list_ncc;
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            int index = nhacungcapdgv.CurrentCell.RowIndex;
            if (txt_ten.Text != "" && index!=-1)
            {
                error_ncc.Clear();
                NHACCBUS nccbus = new NHACCBUS();
                NHACC ncc = new NHACC();
                ncc.ID = int.Parse(txt_mancc.Text);
                ncc.TENNCC = txt_tenncc_ds.Text;
                ncc.SDT = txt_dienthoai_ds.Text;
                ncc.DIACHI = txt_diachi_ds.Text;
                ncc.EMAIL = txt_email_ds.Text;
                if (nccbus.Update(ncc))
                {
                    MessageBox.Show("Thành công!");
                }
                else
                {
                    MessageBox.Show("Lỗi:" + Database<NHACC>.error_message);
                }
            }
            else
            {
                error_ncc.SetError(txt_tenncc_ds, "Tên NCC k dc rỗng");
            }
        }

        private void nhacungcapdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           int index = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                txt_mancc.Text = nhacungcapdgv[0, index].Value.ToString();
                txt_tenncc_ds.Text = nhacungcapdgv[1, index].Value.ToString();
                txt_dienthoai_ds.Text = nhacungcapdgv[2, index].Value.ToString();
                txt_diachi_ds.Text = nhacungcapdgv[3, index].Value.ToString();
                txt_email_ds.Text= nhacungcapdgv[4, index].Value.ToString();
               

            }
        }

        private void nhacungcapdgv_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip context_menu_lsp = new ContextMenuStrip();
                context_menu_lsp.Items.Add("Xóa", null, new EventHandler(xoancc));
                context_menu_lsp.Show(nhacungcapdgv, e.X, e.Y);
            }
        }

        private void xoancc(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xóa Sản Phẩm" + "\n" + "Bạn chắc chắn chứ", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int row = nhacungcapdgv.CurrentRow.Index;
                int mancc = int.Parse(nhacungcapdgv[0, row].Value.ToString());
                NHACC ncc = new NHACC();
                NHACCBUS bus = new NHACCBUS();
                ncc.ID = mancc;
                if (bus.Delete(ncc))
                {
                    MessageBox.Show("Xóa Thành công!");
                    common.ClearOnlyTextBoxes(dsnccpanel);
                    btn_laydulieu_ncc.PerformClick();
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            NHACCBUS bus = new NHACCBUS();
            nhacungcapdgv.DataSource = bus.Search(txt_search.Text);
        }




    }
}
