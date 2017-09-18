namespace WindowsFormsApplication1.View
{
    partial class thongkeview
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl5 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage16 = new MetroFramework.Controls.MetroTabPage();
            this.pnnhanvienthem = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.denngayhd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnthongkedoanhthu = new MetroFramework.Controls.MetroButton();
            this.tungayhd = new System.Windows.Forms.DateTimePicker();
            this.lbngaysinh = new System.Windows.Forms.Label();
            this.lbrematkhau = new System.Windows.Forms.Label();
            this.tabPage17 = new MetroFramework.Controls.MetroTabPage();
            this.pndanhsachnv = new System.Windows.Forms.Panel();
            this.dtgridspbanchay = new System.Windows.Forms.DataGridView();
            this.ngayktsp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthongkespbanchay = new MetroFramework.Controls.MetroButton();
            this.ngaybdsp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl5.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.pnnhanvienthem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage17.SuspendLayout();
            this.pndanhsachnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridspbanchay)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage16);
            this.tabControl5.Controls.Add(this.tabPage17);
            this.tabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl5.Location = new System.Drawing.Point(0, 0);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(883, 512);
            this.tabControl5.TabIndex = 16;
            // 
            // tabPage16
            // 
            this.tabPage16.BackColor = System.Drawing.Color.Transparent;
            this.tabPage16.Controls.Add(this.pnnhanvienthem);
            this.tabPage16.HorizontalScrollbarBarColor = true;
            this.tabPage16.Location = new System.Drawing.Point(4, 35);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Size = new System.Drawing.Size(875, 473);
            this.tabPage16.TabIndex = 0;
            this.tabPage16.Text = "Thống kê Doanh thu";
            this.tabPage16.VerticalScrollbarBarColor = true;
            // 
            // pnnhanvienthem
            // 
            this.pnnhanvienthem.Controls.Add(this.chart1);
            this.pnnhanvienthem.Controls.Add(this.denngayhd);
            this.pnnhanvienthem.Controls.Add(this.label8);
            this.pnnhanvienthem.Controls.Add(this.btnthongkedoanhthu);
            this.pnnhanvienthem.Controls.Add(this.tungayhd);
            this.pnnhanvienthem.Controls.Add(this.lbngaysinh);
            this.pnnhanvienthem.Controls.Add(this.lbrematkhau);
            this.pnnhanvienthem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnnhanvienthem.Location = new System.Drawing.Point(0, 0);
            this.pnnhanvienthem.Name = "pnnhanvienthem";
            this.pnnhanvienthem.Size = new System.Drawing.Size(875, 473);
            this.pnnhanvienthem.TabIndex = 15;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 42);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(862, 428);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart2";
            // 
            // denngayhd
            // 
            this.denngayhd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.denngayhd.Location = new System.Drawing.Point(350, 19);
            this.denngayhd.Name = "denngayhd";
            this.denngayhd.Size = new System.Drawing.Size(252, 20);
            this.denngayhd.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ngày kết thúc";
            // 
            // btnthongkedoanhthu
            // 
            this.btnthongkedoanhthu.Location = new System.Drawing.Point(625, 16);
            this.btnthongkedoanhthu.Name = "btnthongkedoanhthu";
            this.btnthongkedoanhthu.Size = new System.Drawing.Size(125, 23);
            this.btnthongkedoanhthu.TabIndex = 15;
            this.btnthongkedoanhthu.Text = "Thống kê";
            this.btnthongkedoanhthu.Click += new System.EventHandler(this.btnthongkedoanhthu_Click);
            // 
            // tungayhd
            // 
            this.tungayhd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tungayhd.Location = new System.Drawing.Point(54, 16);
            this.tungayhd.Name = "tungayhd";
            this.tungayhd.Size = new System.Drawing.Size(252, 20);
            this.tungayhd.TabIndex = 7;
            // 
            // lbngaysinh
            // 
            this.lbngaysinh.AutoSize = true;
            this.lbngaysinh.Location = new System.Drawing.Point(51, 3);
            this.lbngaysinh.Name = "lbngaysinh";
            this.lbngaysinh.Size = new System.Drawing.Size(72, 13);
            this.lbngaysinh.TabIndex = 12;
            this.lbngaysinh.Text = "Ngày bắt đầu";
            // 
            // lbrematkhau
            // 
            this.lbrematkhau.AutoSize = true;
            this.lbrematkhau.Location = new System.Drawing.Point(86, 188);
            this.lbrematkhau.Name = "lbrematkhau";
            this.lbrematkhau.Size = new System.Drawing.Size(0, 13);
            this.lbrematkhau.TabIndex = 7;
            // 
            // tabPage17
            // 
            this.tabPage17.BackColor = System.Drawing.Color.Transparent;
            this.tabPage17.Controls.Add(this.pndanhsachnv);
            this.tabPage17.HorizontalScrollbarBarColor = true;
            this.tabPage17.Location = new System.Drawing.Point(4, 35);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Size = new System.Drawing.Size(875, 473);
            this.tabPage17.TabIndex = 4;
            this.tabPage17.Text = "Thống kê SP bán chạy";
            this.tabPage17.VerticalScrollbarBarColor = true;
            // 
            // pndanhsachnv
            // 
            this.pndanhsachnv.Controls.Add(this.dtgridspbanchay);
            this.pndanhsachnv.Controls.Add(this.ngayktsp);
            this.pndanhsachnv.Controls.Add(this.label1);
            this.pndanhsachnv.Controls.Add(this.btnthongkespbanchay);
            this.pndanhsachnv.Controls.Add(this.ngaybdsp);
            this.pndanhsachnv.Controls.Add(this.label2);
            this.pndanhsachnv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pndanhsachnv.Location = new System.Drawing.Point(0, 0);
            this.pndanhsachnv.Name = "pndanhsachnv";
            this.pndanhsachnv.Size = new System.Drawing.Size(875, 473);
            this.pndanhsachnv.TabIndex = 33;
            // 
            // dtgridspbanchay
            // 
            this.dtgridspbanchay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridspbanchay.Location = new System.Drawing.Point(26, 74);
            this.dtgridspbanchay.Name = "dtgridspbanchay";
            this.dtgridspbanchay.Size = new System.Drawing.Size(696, 359);
            this.dtgridspbanchay.TabIndex = 24;
            // 
            // ngayktsp
            // 
            this.ngayktsp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayktsp.Location = new System.Drawing.Point(322, 24);
            this.ngayktsp.Name = "ngayktsp";
            this.ngayktsp.Size = new System.Drawing.Size(252, 20);
            this.ngayktsp.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ngày kết thúc";
            // 
            // btnthongkespbanchay
            // 
            this.btnthongkespbanchay.Location = new System.Drawing.Point(597, 21);
            this.btnthongkespbanchay.Name = "btnthongkespbanchay";
            this.btnthongkespbanchay.Size = new System.Drawing.Size(125, 23);
            this.btnthongkespbanchay.TabIndex = 20;
            this.btnthongkespbanchay.Text = "Thống kê";
            this.btnthongkespbanchay.Click += new System.EventHandler(this.btnthongkespbanchay_Click);
            // 
            // ngaybdsp
            // 
            this.ngaybdsp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaybdsp.Location = new System.Drawing.Point(26, 21);
            this.ngaybdsp.Name = "ngaybdsp";
            this.ngaybdsp.Size = new System.Drawing.Size(252, 20);
            this.ngaybdsp.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // thongkeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tabControl5);
            this.Name = "thongkeview";
            this.Size = new System.Drawing.Size(883, 512);
            this.tabControl5.ResumeLayout(false);
            this.tabPage16.ResumeLayout(false);
            this.pnnhanvienthem.ResumeLayout(false);
            this.pnnhanvienthem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage17.ResumeLayout(false);
            this.pndanhsachnv.ResumeLayout(false);
            this.pndanhsachnv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridspbanchay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroTabControl tabControl5;
        private MetroFramework.Controls.MetroTabPage tabPage16;
        private System.Windows.Forms.Panel pnnhanvienthem;
        private System.Windows.Forms.DateTimePicker denngayhd;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroButton btnthongkedoanhthu;
        private System.Windows.Forms.DateTimePicker tungayhd;
        private System.Windows.Forms.Label lbngaysinh;
        private System.Windows.Forms.Label lbrematkhau;
        private MetroFramework.Controls.MetroTabPage tabPage17;
        private System.Windows.Forms.Panel pndanhsachnv;
        private System.Windows.Forms.DateTimePicker ngayktsp;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnthongkespbanchay;
        private System.Windows.Forms.DateTimePicker ngaybdsp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dtgridspbanchay;
    }
}
