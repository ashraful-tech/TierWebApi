using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BuyerRepo
    {
        static landSellingsEntities1 db;

        static BuyerRepo()
        {
            db = new landSellingsEntities1();
        }
        public static List<Buyer> Get()
        {
            return db.Buyers.ToList();
        }

        public static Buyer Get(int id)
        {
            return db.Buyers.FirstOrDefault(e => e.id == id);
        }

        public static void Edit(Buyer b)
        {
            var ds = db.Buyers.FirstOrDefault(e => e.id == b.id);
            db.Entry(ds).CurrentValues.SetValues(b);
            db.SaveChanges();
        }
        public static void Delete(int id)
        {
            var ds = db.Buyers.FirstOrDefault(e => e.id == id);
            db.Buyers.Remove(ds);
            db.SaveChanges();
        }

        public static void Add(Buyer s)
        {
            db.Buyers.Add(s);
            db.SaveChanges();
        }


    }
}
