using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DAO;
using Model.ENTITY;
namespace Model.BUS
{
   
     public class NHACCBUS
     {
         Database<NHACC> dao = null;

         public NHACCBUS()

         {
             dao = new Database<NHACC>();
         }
         public List<NHACC> GetList()
         {
             return dao.GetList();
         }
         public bool Add(NHACC ncc)
         {
             return dao.Insert(ncc);
         }
         public bool Update(NHACC ncc)
         {
             return dao.Update(ncc);
         }
         public bool Delete(NHACC ncc)
         {
             return dao.Delete(ncc);
         }
         public NHACC Search(int mancc)
         {
             return dao.GetSingle(x => x.ID == mancc);
         }
         public List<NHACC> Search(string input)
         {
             return dao.Search(x=>x.TENNCC == input);
         }

    }

}
