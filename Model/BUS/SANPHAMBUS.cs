using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DAO;
using Model.ENTITY;
namespace Model.BUS
{
    public class SANPHAMBUS
    {
        Database<SANPHAM> spdao = new Database<SANPHAM>();
        public List<SANPHAM> GetList()
        {
            return spdao.GetList();
        }

        public bool Add(SANPHAM sp)
        {
            return spdao.Insert(sp);
        }
        public bool LSPExists(int masp)
        {
            return spdao.Exists(x => x.IDLOAISP == masp);
        }

        public bool DeleteAllWithLSP(int lsp)
        {
            return spdao.DeleteAllWithLSP(lsp);
        }

        public bool CapNhatSLBayBanSP(int masp, int sl,int trangthai)
        {
            return spdao.CapNhatSLBayBanSP(masp, sl,trangthai);
        }


        public bool XuatKhoSP(int masp, int sl)
        {
            return spdao.XuatKhoSP(masp, sl);
        }


        public bool Update(SANPHAM sp)
        {
            return spdao.Update(sp);
        }
        public bool Delete(SANPHAM sp)
        {
            return spdao.Delete(sp);
        }

        public List<SANPHAM> Search(string input)
        {
            return spdao.Search(x => x.TENSP.Contains(input) || x.XUATXU.Contains(input));
        }
    }
}
