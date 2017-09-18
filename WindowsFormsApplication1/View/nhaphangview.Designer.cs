namespace WindowsFormsApplication1.View
{
    partial class nhaphangview
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl4 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage14 = new MetroFramework.Controls.MetroTabPage();
            this.quanlynhaptab1 = new System.Windows.Forms.Panel();
            this.cbb_trangthai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_laydulieu = new MetroFramework.Controls.MetroButton();
            this.btn_hoantat = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.nhapkhogv = new System.Windows.Forms.DataGridView();
            this.label22 = new System.Windows.Forms.Label();
            this.donnhapgv = new System.Windows.Forms.DataGridView();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btn_inphieu = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ngtra = new System.Windows.Forms.TextBox();
            this.txt_ncc = new System.Windows.Forms.TextBox();
            this.date_trahang = new System.Windows.Forms.DateTimePicker();
            this.date_dh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctddhgv = new System.Windows.Forms.DataGridView();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button34 = new MetroFramework.Controls.MetroButton();
            this.cbb_dondh = new System.Windows.Forms.ComboBox();
            this.label61 = new System.Windows.Forms.Label();
            this.tabControl4.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.quanlynhaptab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhapkhogv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donnhapgv)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctddhgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage14);
            this.tabControl4.Controls.Add(this.metroTabPage1);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Location = new System.Drawing.Point(0, 0);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 1;
            this.tabControl4.Size = new System.Drawing.Size(904, 589);
            this.tabControl4.TabIndex = 13;
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.quanlynhaptab1);
            this.tabPage14.HorizontalScrollbarBarColor = true;
            this.tabPage14.Location = new System.Drawing.Point(4, 35);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Size = new System.Drawing.Size(896, 550);
            this.tabPage14.TabIndex = 0;
            this.tabPage14.Text = "Nhập hàng";
            this.tabPage14.VerticalScrollbarBarColor = true;
            // 
            // quanlynhaptab1
            // 
            this.quanlynhaptab1.BackColor = System.Drawing.Color.Transparent;
            this.quanlynhaptab1.Controls.Add(this.cbb_trangthai);
            this.quanlynhaptab1.Controls.Add(this.label5);
            this.quanlynhaptab1.Controls.Add(this.btn_laydulieu);
            this.quanlynhaptab1.Controls.Add(this.btn_hoantat);
            this.quanlynhaptab1.Controls.Add(this.label1);
            this.quanlynhaptab1.Controls.Add(this.label42);
            this.quanlynhaptab1.Controls.Add(this.nhapkhogv);
            this.quanlynhaptab1.Controls.Add(this.label22);
            this.quanlynhaptab1.Controls.Add(this.donnhapgv);
            this.quanlynhaptab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanlynhaptab1.Location = new System.Drawing.Point(0, 0);
            this.quanlynhaptab1.Name = "quanlynhaptab1";
            this.quanlynhaptab1.Size = new System.Drawing.Size(896, 550);
            this.quanlynhaptab1.TabIndex = 9;
            // 
            // cbb_trangthai
            // 
            this.cbb_trangthai.AutoCompleteCustomSource.AddRange(new string[] {
            "Chưa Xử Lý",
            "Đã Xử Lý",
            "Tất Cả"});
            this.cbb_trangthai.FormattingEnabled = true;
            this.cbb_trangthai.Items.AddRange(new object[] {
            "Chưa Xử Lý",
            "Đã Xử Lý",
            "Tất Cả"});
            this.cbb_trangthai.Location = new System.Drawing.Point(78, 67);
            this.cbb_trangthai.Name = "cbb_trangthai";
            this.cbb_trangthai.Size = new System.Drawing.Size(199, 21);
            this.cbb_trangthai.TabIndex = 35;
            this.cbb_trangthai.SelectionChangeCommitted += new System.EventHandler(this.cbb_trangthai_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Trạng thái";
            // 
            // btn_laydulieu
            // 
            this.btn_laydulieu.Location = new System.Drawing.Point(324, 70);
            this.btn_laydulieu.Name = "btn_laydulieu";
            this.btn_laydulieu.Size = new System.Drawing.Size(99, 23);
            this.btn_laydulieu.TabIndex = 33;
            this.btn_laydulieu.Text = "Lấy dữ liệu";
            this.btn_laydulieu.Click += new System.EventHandler(this.btn_laydulieu_Click);
            // 
            // btn_hoantat
            // 
            this.btn_hoantat.Location = new System.Drawing.Point(771, 466);
            this.btn_hoantat.Name = "btn_hoantat";
            this.btn_hoantat.Size = new System.Drawing.Size(99, 23);
            this.btn_hoantat.TabIndex = 32;
            this.btn_hoantat.Text = "Hoàn tất";
            this.btn_hoantat.Click += new System.EventHandler(this.btn_hoantat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(577, 53);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(206, 13);
            this.label42.TabIndex = 6;
            this.label42.Text = "Danh sách sản phẩm thuộc đơn đặt hàng";
            // 
            // nhapkhogv
            // 
            this.nhapkhogv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nhapkhogv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.nhapkhogv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nhapkhogv.DefaultCellStyle = dataGridViewCellStyle1;
            this.nhapkhogv.Location = new System.Drawing.Point(441, 70);
            this.nhapkhogv.Name = "nhapkhogv";
            this.nhapkhogv.RowHeadersVisible = false;
            this.nhapkhogv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nhapkhogv.Size = new System.Drawing.Size(429, 390);
            this.nhapkhogv.TabIndex = 5;
            this.nhapkhogv.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.nhapkhogv_CellValidating);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(13, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(176, 37);
            this.label22.TabIndex = 3;
            this.label22.Text = "Nhập hàng";
            // 
            // donnhapgv
            // 
            this.donnhapgv.AllowUserToAddRows = false;
            this.donnhapgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.donnhapgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donnhapgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.D,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.donnhapgv.Location = new System.Drawing.Point(10, 105);
            this.donnhapgv.Name = "donnhapgv";
            this.donnhapgv.ReadOnly = true;
            this.donnhapgv.RowHeadersVisible = false;
            this.donnhapgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.donnhapgv.Size = new System.Drawing.Size(413, 355);
            this.donnhapgv.TabIndex = 1;
            this.donnhapgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.donnhapgv_CellClick);
            this.donnhapgv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.donnhapgv_MouseClick);
            // 
            // D
            // 
            this.D.HeaderText = "ID";
            this.D.Name = "D";
            this.D.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ngày đặt";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nhà CC";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID Người đặt";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tổng cộng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Trạng Thái";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btn_inphieu);
            this.metroTabPage1.Controls.Add(this.groupBox1);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.ctddhgv);
            this.metroTabPage1.Controls.Add(this.button34);
            this.metroTabPage1.Controls.Add(this.cbb_dondh);
            this.metroTabPage1.Controls.Add(this.label61);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(896, 550);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Trả Hàng";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // btn_inphieu
            // 
            this.btn_inphieu.Location = new System.Drawing.Point(685, 476);
            this.btn_inphieu.Name = "btn_inphieu";
            this.btn_inphieu.Size = new System.Drawing.Size(125, 23);
            this.btn_inphieu.TabIndex = 29;
            this.btn_inphieu.Text = "In Phiếu";
            this.btn_inphieu.Click += new System.EventHandler(this.btn_inphieu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.txt_ngtra);
            this.groupBox1.Controls.Add(this.txt_ncc);
            this.groupBox1.Controls.Add(this.date_trahang);
            this.groupBox1.Controls.Add(this.date_dh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(208, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 99);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            // 
            // txt_ngtra
            // 
            this.txt_ngtra.Enabled = false;
            this.txt_ngtra.Location = new System.Drawing.Point(350, 53);
            this.txt_ngtra.Name = "txt_ngtra";
            this.txt_ngtra.Size = new System.Drawing.Size(146, 20);
            this.txt_ngtra.TabIndex = 7;
            // 
            // txt_ncc
            // 
            this.txt_ncc.Enabled = false;
            this.txt_ncc.Location = new System.Drawing.Point(103, 56);
            this.txt_ncc.Name = "txt_ncc";
            this.txt_ncc.Size = new System.Drawing.Size(146, 20);
            this.txt_ncc.TabIndex = 6;
            // 
            // date_trahang
            // 
            this.date_trahang.Enabled = false;
            this.date_trahang.Location = new System.Drawing.Point(350, 19);
            this.date_trahang.Name = "date_trahang";
            this.date_trahang.Size = new System.Drawing.Size(146, 20);
            this.date_trahang.TabIndex = 5;
            this.date_trahang.Value = new System.DateTime(2017, 4, 25, 11, 35, 12, 0);
            // 
            // date_dh
            // 
            this.date_dh.Enabled = false;
            this.date_dh.Location = new System.Drawing.Point(103, 19);
            this.date_dh.Name = "date_dh";
            this.date_dh.Size = new System.Drawing.Size(146, 20);
            this.date_dh.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Người trả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày trả hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhà Cung Cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày đặt hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Chọn Đơn ĐH";
            // 
            // ctddhgv
            // 
            this.ctddhgv.AllowUserToAddRows = false;
            this.ctddhgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctddhgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctddhgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSP,
            this.Column6,
            this.Column7,
            this.Column8});
            this.ctddhgv.Location = new System.Drawing.Point(36, 165);
            this.ctddhgv.Name = "ctddhgv";
            this.ctddhgv.RowHeadersVisible = false;
            this.ctddhgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctddhgv.Size = new System.Drawing.Size(774, 305);
            this.ctddhgv.TabIndex = 26;
            this.ctddhgv.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ctddhgv_CellValidating);
            this.ctddhgv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ctddhgv_MouseClick);
            // 
            // TenSP
            // 
            this.TenSP.FillWeight = 122.6989F;
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 40.60914F;
            this.Column6.HeaderText = "SL Đặt";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 38.74751F;
            this.Column7.HeaderText = "SL Trả";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.FillWeight = 197.9444F;
            this.Column8.HeaderText = "Nguyên nhân trả";
            this.Column8.Name = "Column8";
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(668, 438);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(99, 23);
            this.button34.TabIndex = 25;
            this.button34.Text = "Hoàn tất";
            // 
            // cbb_dondh
            // 
            this.cbb_dondh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_dondh.FormattingEnabled = true;
            this.cbb_dondh.Location = new System.Drawing.Point(36, 77);
            this.cbb_dondh.Name = "cbb_dondh";
            this.cbb_dondh.Size = new System.Drawing.Size(144, 21);
            this.cbb_dondh.TabIndex = 24;
            this.cbb_dondh.SelectionChangeCommitted += new System.EventHandler(this.cbb_dondh_SelectionChangeCommitted);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.SystemColors.Window;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(13, 11);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(307, 37);
            this.label61.TabIndex = 4;
            this.label61.Text = "Tạo Phiếu Trả Hàng";
            // 
            // nhaphangview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tabControl4);
            this.Name = "nhaphangview";
            this.Size = new System.Drawing.Size(904, 589);
            this.tabControl4.ResumeLayout(false);
            this.tabPage14.ResumeLayout(false);
            this.quanlynhaptab1.ResumeLayout(false);
            this.quanlynhaptab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhapkhogv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donnhapgv)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctddhgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroTabControl tabControl4;
        private MetroFramework.Controls.MetroTabPage tabPage14;
        private System.Windows.Forms.Panel quanlynhaptab1;
        private MetroFramework.Controls.MetroButton btn_hoantat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.DataGridView nhapkhogv;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView donnhapgv;
        private MetroFramework.Controls.MetroButton btn_laydulieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cbb_trangthai;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ctddhgv;
        private MetroFramework.Controls.MetroButton button34;
        private System.Windows.Forms.ComboBox cbb_dondh;
        private System.Windows.Forms.TextBox txt_ngtra;
        private System.Windows.Forms.TextBox txt_ncc;
        private System.Windows.Forms.DateTimePicker date_trahang;
        private System.Windows.Forms.DateTimePicker date_dh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private MetroFramework.Controls.MetroButton btn_inphieu;

    }
}
