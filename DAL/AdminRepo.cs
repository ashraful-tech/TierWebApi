using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminRepo : IRepository<Admin, int>
    {
        landSellingsEntities4 db;

        public AdminRepo(landSellingsEntities4 db)
        {
            this.db = db;
        }

        public void Add(Admin e)
        {
            db.Admins.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var e = db.Admins.FirstOrDefault(en => en.id == id);
            db.Admins.Remove(e);
            db.SaveChanges();
        }

        public void Edit(Admin e)
        {
            var d = db.Admins.FirstOrDefault(en => en.id == e.id);
            db.Entry(d).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Admin> Get()
        {
            return db.Admins.ToList();
        }

        public Admin Get(int id)
        {
            return db.Admins.FirstOrDefault(e => e.id == id);
        }
    }
}
