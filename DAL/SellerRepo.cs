using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SellerRepo : IRepository<Seller, int>
    {
        landSellingsEntities3 db;

        public SellerRepo(landSellingsEntities3 db)
        {
            this.db = db;
        }
        public void Add(Seller e)
        {
            db.Sellers.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var e = db.Sellers.FirstOrDefault(en => en.id == id);
            db.Sellers.Remove(e);
            db.SaveChanges();
        }

        public void Edit(Seller e)
        {
            var d = db.Sellers.FirstOrDefault(en => en.id == e.id);
            db.Entry(d).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Seller> Get()
        {
            return db.Sellers.ToList();
        }

        public Seller Get(int id)
        {
            return db.Sellers.FirstOrDefault(e => e.id == id);
        }
       
    }
}
