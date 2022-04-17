using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BuyerRepo : IRepository<Buyer, int>
    {
        landSellingsEntities3 db;

        public BuyerRepo(landSellingsEntities3 db)
        {
            this.db = db;
        }
        public void Add(Buyer e)
        {
            db.Buyers.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var e = db.Buyers.FirstOrDefault(en => en.id == id);
            db.Buyers.Remove(e);
            db.SaveChanges();
        }

        public void Edit(Buyer e)
        {
            var d = db.Buyers.FirstOrDefault(en => en.id == e.id);
            db.Entry(d).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Buyer> Get()
        {
            return db.Buyers.ToList();
        }

        public Buyer Get(int id)
        {
            return db.Buyers.FirstOrDefault(e => e.id == id);
        }
    }
}
