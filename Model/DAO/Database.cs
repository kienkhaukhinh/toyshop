using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.ENTITY;
using System.Linq.Expressions;
using System.Data.Entity;
using Model.VIEWMODEL;

namespace Model.DAO
{
   public class Database<T> where T : class
    {
       public TOYDB db = new TOYDB();
       public static string error_message = "";
       public static bool trudiemtichluy;
        public List<T> GetList()
        {
           return db.Set<T>().ToList();
        }
        public bool Insert(T dto)
        {
            bool ok = false;
            try
            {
                db.Entry(dto).State = EntityState.Added;
                db.SaveChanges();
                ok = true;
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }

            return ok;
        }
        public bool Delete(T dto)
        {
            bool ok = false;
            {
                try
                {
                    db.Entry(dto).State = EntityState.Deleted;
                    db.SaveChanges();
                    ok = true;
                }
                catch (Exception ex)
                {
                    error_message = ex.Message;
                }
            }
            return ok;
        }
        public bool Update(T dto)
        {
            bool ok = false;
            {
                try
                {
                    db.Entry(dto).State = EntityState.Modified;
                    db.SaveChanges();
                    ok = true;
                }
                catch (Exception ex)
                {
                    error_message = ex.Message;
                }
            }
            return ok;
        }

        public List<T> Search(Expression<Func<T, bool>> where)
        {

            return db.Set<T>().Where(where).ToList();
        }
       //lay duy nhat
        public T GetSingle(Expression<Func<T, bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }
        public bool Exists(Expression<Func<T, bool>> where)
        {
            return db.Set<T>().Any(where);
        }
        
       // DONDATHANG


        public bool Insert(DONDATHANG ddh, List<CT_DONDATHANG> ctdh)
        {
            bool insert = false;
            try
            {
                db.DONDATHANGs.Add(ddh);
                db.SaveChanges();
                foreach (CT_DONDATHANG ct in ctdh)
                {
                    ct.IDDONDAT = ddh.ID;
                    db.CT_DONDATHANG.Add(ct);
                    db.SaveChanges();
                    insert = true;
                }
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }
            return insert;

        }

        public List<ViewCTDDH> GetList(int ma)
        {
            var query = from ctddh in db.CT_DONDATHANG
                        join sp in db.SANPHAMs
                       on ctddh.IDSANPHAM equals sp.ID
                        where ctddh.IDDONDAT == ma
                        select new ViewCTDDH()
                        {
                            MaSP = sp.ID,
                            TenSP = sp.TENSP,
                            SL_Nhap = ctddh.SL_NHAP,
                            SL = ctddh.SL,
                            DonGia = ctddh.DONGIA,
                            TongTien = ctddh.TONG
                        };
            return query.ToList();
        }

        public bool Update(int maddh, List<CT_DONDATHANG> ctdh)
        {
            //SANPHAMDAO spdao = new SANPHAMDAO();
            //CTDONHANGDAO ctdao = new CTDONHANGDAO();
            bool update = false;
            try
            {
                foreach (CT_DONDATHANG ct_in_list in ctdh)
                {
                    int sl_hientai = db.CT_DONDATHANG.Where(x => x.IDSANPHAM == ct_in_list.IDSANPHAM && x.IDDONDAT == ct_in_list.IDDONDAT).Select(x => x.SL_NHAP).FirstOrDefault();

                    if (UpdateSLNhap(ct_in_list))
                    {
                       CapNhatSLTonSP(ct_in_list.IDSANPHAM, ct_in_list.SL_NHAP - sl_hientai);
                    }

                }
                UpdateTrangThai(maddh);
                update = true;
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }
            return update;
        }



        public void UpdateTrangThai(int maddh)
        {
            int sum_sl_dat = db.CT_DONDATHANG.Where(X => X.IDDONDAT == maddh).Sum(x => x.SL);
            int sum_sl_nhap = db.CT_DONDATHANG.Where(X => X.IDDONDAT == maddh).Sum(x => x.SL_NHAP);
            if (sum_sl_dat == sum_sl_nhap)
            {
                try
                {
                    DONDATHANG dh = db.DONDATHANGs.Where(x => x.ID == maddh).FirstOrDefault();
                    dh.TRANGTHAI = true;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    error_message = ex.Message;
                }
            }
        }

        public bool DeleteWithCTDDH(DONDATHANG dh)
        {
            bool delete = false;
            try
            {
                    var list_with_ctddh = db.CT_DONDATHANG.Where(x => x.IDDONDAT == dh.ID);
                    db.CT_DONDATHANG.RemoveRange(list_with_ctddh);
                    db.SaveChanges();
                    delete = true;
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }
            return delete;
        }

       //CT_DONDATHANGDAO
        public bool UpdateSLNhap(CT_DONDATHANG ctiet)
        {
            bool update = false;
            try
            {

                CT_DONDATHANG ct = db.CT_DONDATHANG.FirstOrDefault(x=>x.IDDONDAT == ctiet.IDDONDAT && x.IDSANPHAM == ctiet.IDSANPHAM);
                if (ct != null)
                {
                    ct.SL_NHAP = ctiet.SL_NHAP;
                    db.SaveChanges();
                    update = true;
                }
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }
            return update;
        }

       //HOADONDAO

        public bool Insert(HOADON hd, List<CT_HOADON> lcthd)
        {
            bool insert = false;
            try
            {
                db.HOADONs.Add(hd);
                db.SaveChanges();
                foreach (CT_HOADON ct in lcthd)
                {
                    ct.IDHOADON = hd.ID;
                    db.CT_HOADON.Add(ct);
                    db.SaveChanges();

                }
                insert = true;
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }
            return insert;


        }


        public List<sanphambanchayviewmodel> soluongbanranhieunhat(DateTime ngaynhaptu, DateTime ngaynhapden)
        {
            var query =
                        (from hds in db.HOADONs
                         from sp in db.SANPHAMs

                         from cthds in db.CT_HOADON
                         let totalQuantity = (from op in db.CT_HOADON
                                              where op.IDHOADON == hds.ID && sp.ID == op.IDSANPHAM && hds.NGAYXUAT >= ngaynhaptu && hds.NGAYXUAT <= ngaynhapden
                                              select op.SL).Sum()

                         where totalQuantity > 0

                         orderby totalQuantity descending
                         select new sanphambanchayviewmodel
                         {
                             id = sp.ID,
                             tensp = sp.TENSP,
                             giaban = sp.GIATIEN,
                             soluongbanra = totalQuantity,

                         }).Distinct().Take(10);
            return query.ToList();
        }

       //KHACHHANGDAO

        public List<string> GetIDList(DateTime today)
        {
            return db.KHACHHANGTTs.Where(x => x.NGAYHETHAN >= today).Select(x => x.ID).ToList();
        }


        public bool UpdateDiemTL(string makh, int diemcong)
        {
            bool update = false;
            KHACHHANGTT kh = new KHACHHANGTT();
            kh = db.KHACHHANGTTs.Where(x => x.ID == makh).FirstOrDefault();
            try
            {
                kh.DIEMTL += diemcong;
                db.SaveChanges();
                update = true;
                if (kh.DIEMTL >= 10)
                {
                    kh.DIEMTL = kh.DIEMTL - 10;
                    db.SaveChanges();
                    trudiemtichluy = true;
                }
                else
                {
                    trudiemtichluy = false;
                }
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }
            return update;
        }

       
       
       //SANPHAMDAO


        public bool CapNhatSLBayBanSP(int masp, int sl, int trangthai)
        {
            bool capnhat = false;
            try
            {
                SANPHAM sp = db.SANPHAMs.Where(x => x.ID == masp).FirstOrDefault();
                if (trangthai == 1) // ban san pham ra
                {
                    sp.SLBAYBAN = sp.SLBAYBAN - sl;
                }
                else if (trangthai == 0) // thu ve san pham
                {
                    sp.SLBAYBAN = sp.SLBAYBAN + sl;
                }
                else if (trangthai == 2) // sua so luong bay ban (dung cho viec sua so luong trong gridview xuatkho va chi tiet don hang)
                {
                    sp.SLBAYBAN = sl;
                }
                db.SaveChanges();
                capnhat = true;
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }
            return capnhat;
        }

        public bool XuatKhoSP(int masp, int sl)
        {
            bool capnhat = false;
            try
            {
                SANPHAM sp = db.SANPHAMs.Where(x => x.ID == masp).FirstOrDefault();
                sp.SLTON = sp.SLTON - sl;
                sp.SLBAYBAN = sp.SLBAYBAN + sl;

                db.SaveChanges();
                capnhat = true;
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }
            return capnhat;
        }


        public bool CapNhatSLTonSP(int masp, int sl)
        {
            bool capnhat = false;
            try
            {
                SANPHAM sp = db.SANPHAMs.Where(x => x.ID == masp).FirstOrDefault();
                sp.SLTON = sp.SLTON + sl;
                db.SaveChanges();
                capnhat = true;
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }
            return capnhat;
        }



        public bool DeleteAllWithLSP(int lsp)
        {
            bool delete = false;
            try
            {
                var list_with_lsp = db.SANPHAMs.Where(x => x.IDLOAISP == lsp);
                db.SANPHAMs.RemoveRange(list_with_lsp);
                db.SaveChanges();
                delete = true;
            }
            catch (Exception ex)
            {
                error_message = ex.Message;
            }
            return delete;
        }





    }
}
