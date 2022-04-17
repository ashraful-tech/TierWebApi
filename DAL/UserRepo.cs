using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepo : IRepository<User, int>
    {
        landSellingsEntities3 db;

        public UserRepo (landSellingsEntities3 db)
        {
            this.db = db;
        }

        public void Add(User e)
        {
            db.Users.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(User e)
        {
            var d = db.Users.FirstOrDefault(en => en.userId == e.userId);
            db.Entry(d).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
