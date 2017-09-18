using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using Model.VIEWMODEL;
using Model.BUS;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1.View
{
    public partial class thongkeview : UserControl
    {
        public thongkeview()
        {
            InitializeComponent();
        }

 

        private void btnthongkedoanhthu_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            DateTime dt = DateTime.Now;
            DateTime start = tungayhd.Value;
            DateTime finish = denngayhd.Value;
            if ((finish - start).TotalDays > 0)
            {

                if ((finish - start).TotalDays < 32)
                {
                    HOADONBUS bus = new HOADONBUS();
                    Axis XA = chart1.ChartAreas[0].AxisX;
                    Axis YA = chart1.ChartAreas[0].AxisY;
                    Series S1 = chart1.Series[0];
                    List<DateTime> dates = new List<DateTime>();
                    S1.LegendText = +dt.Day + "/" + dt.Month + "/" + dt.Year;


                    // show the year in the legend:
                    S1.LegendText = "Doanh thu (VNĐ) ";
                    // move to the bottom center:
                    chart1.Legends[0].Docking = Docking.Bottom;
                    chart1.Legends[0].Alignment = StringAlignment.Center;

                    chart1.Series[0].XValueType = ChartValueType.Date;


                    XA.MajorGrid.Enabled = false;         // no gridlines
                    XA.LabelStyle.Format = "dd/MM/yyyy";         // show months as names

                    XA.IntervalType = DateTimeIntervalType.Days;  // show axis labels.. 
                    XA.Interval = 1;

                    YA.LabelStyle.Format = "##0";  // for kilos etc you need to scale the y-values!
                    int y = 1;
                    if (y == 12) y = 1;

                    chart1.Series["Doanh thu"].IsValueShownAsLabel = true;

                    for (DateTime x = start; x <= finish; x = x.AddDays(1))
                    {
                        dates.Add(x);
                    }
                    //có ph?t

                    foreach (DateTime d in dates)
                    {
                        chart1.Series[0].Points.AddXY(d, bus.doanhthutheongay(d.Day, d.Month, d.Year));
                        y++;
                    }

                }
                else
                {
                    MessageBox.Show("Số liệu thống kê ngày bắt đầu và ngày kết thúc phải nhỏ hơn 31");
                }

            }
            else
            {
                MessageBox.Show("Ngày nhập không hợp lệ");
            }


        }

        private void btnthongkespbanchay_Click(object sender, EventArgs e)
        {
            DateTime tungay;
            DateTime denngay;

            HOADONBUS bus = new HOADONBUS();
            if (ngaybdsp.Value.Date <= ngayktsp.Value.Date)
            {

                tungay = ngaybdsp.Value.Date;
                denngay = ngayktsp.Value.AddDays(1);
                List<sanphambanchayviewmodel> lst_bchay = bus.soluongbanranhieunhat(tungay, denngay);
                dtgridspbanchay.DataSource = lst_bchay;

            }
            else
            {
                MessageBox.Show("Ngày nhập không hợp lệ");
            }



        }
    }
}
