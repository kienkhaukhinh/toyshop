using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DAO;
using Model.ENTITY;
using Model.VIEWMODEL;
namespace Model.BUS
{
    public class DONDATHANGBUS
    {
        Database<DONDATHANG> dao;
        public DONDATHANGBUS()
        {
            dao = new Database<DONDATHANG>();
        }

        public List<DONDATHANG> GetList()
        {
            return dao.GetList();
        }
        public bool Insert(DONDATHANG dh,List<CT_DONDATHANG> ct)
        {
            return dao.Insert(dh, ct);
        }
        public bool Update(int maddh,List<CT_DONDATHANG> ctdh)
        {
            return dao.Update(maddh,ctdh);
        }
        public List<ViewCTDDH> GetList(int ma)
        {
            return dao.GetList(ma);
        }
        public List<DONDATHANG> Search(bool trangthai)
        {
            return dao.Search(x => x.TRANGTHAI == trangthai);
        }
        public DONDATHANG Search(int ma)
        {
            return dao.GetSingle(x => x.ID == ma);
        }

        public bool Delete(DONDATHANG dh)
        {
            if (dao.Delete(dh))
            {
                return dao.DeleteWithCTDDH(dh);
            }
            return false;
        }




        //co phuong thuc search trong generic
    }
}
