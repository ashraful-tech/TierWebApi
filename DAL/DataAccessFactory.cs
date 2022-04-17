using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static landSellingsEntities3 db;

        static DataAccessFactory() 
        {
            db = new landSellingsEntities3(); 
        }

        public static IRepository<Buyer, int> BuyerDataAccess()
        {

            return new BuyerRepo(db);
        }

        public static IRepository<Seller, int> SellerDataAccess()
        {

            return new SellerRepo(db);
        }

        public static IRepository<Admin, int> AdminDataAccess()
        {
            return new AdminRepo(db);
        }

        public static IRepository<User, int> UserDataAccess()
        {
            return new UserRepo(db);
        }
    }
}
