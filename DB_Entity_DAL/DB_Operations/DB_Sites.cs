using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Entity_DAL.MedelsDataBase;

namespace DB_Entity_DAL.DB_Operations
{
   public class DB_Sites
    {
        public string InsertRegion(Site sity)
        {
            try
            {
                Sell_BuyEntities db = new Sell_BuyEntities();
                db.Sites.Add(sity);
                db.SaveChanges();
                return sity.name_sity + " was succefully inserted";
            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }
        }

        public string UpdateRegion(int id, Site sity)
        {
            try
            {

                Sell_BuyEntities db = new Sell_BuyEntities();
                Site s = db.Sites.Find(id);
                s.id_region = sity.id_region;
                s.id_country = sity.id_country;
                s.name_sity = sity.name_sity;

                db.SaveChanges();
                return s.name_sity + " was succefully updated";
            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }

        }

        public string DeleteRegion(int id)
        {
            try
            {
                Sell_BuyEntities db = new Sell_BuyEntities();
                Site sity = db.Sites.Find(id);

                db.Sites.Attach(sity);
                db.Sites.Remove(sity);
                db.SaveChanges();

                return sity.name_sity + " was succefully delited";
            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }
        }

        public List<Site> GetallRegion()
        {
            try
            {
                using (Sell_BuyEntities db = new Sell_BuyEntities())
                {
                    List<Site> sity = (from x in db.Sites
                                       select x).ToList();
                    return sity;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
