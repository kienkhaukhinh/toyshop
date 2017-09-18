using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DAO;
using Model.VIEWMODEL;
using Model.ENTITY;

namespace Model.BUS
{
    public class HOADONBUS
    {
        Database<HOADON> hdao;
        public HOADONBUS()
        {
            hdao = new Database<HOADON>();
        }
        public bool Insert(HOADON hd,List<CT_HOADON> ct)
        {
            return hdao.Insert(hd, ct);
        }

        public int? doanhthutheongay(int ngay, int thang, int nam)
        {
            return hdao.Search(c => c.NGAYXUAT.Value.Month == thang && c.NGAYXUAT.Value.Year == nam && c.NGAYXUAT.Value.Day == ngay).Sum(c => c.THANHTIEN);
        }

        public List<sanphambanchayviewmodel> soluongbanranhieunhat(DateTime ngaynhaptu, DateTime ngaynhapden)
        {
            return hdao.soluongbanranhieunhat(ngaynhaptu, ngaynhapden);
        }




    }
}
