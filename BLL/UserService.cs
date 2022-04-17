using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BLL
{
    public class UserService
    {
        public static List<UserModel> Get()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<User, UserModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<UserModel>>(DataAccessFactory.UserDataAccess().Get());
            return data;
        }

        public static List<string> GetNames()
        {
            var data = DataAccessFactory.UserDataAccess().Get().Select(e => e.uname).ToList();
            return data;
        }



        public static void Add(UserModel s)
        {
            var config = new MapperConfiguration(cfg => {

                cfg.CreateMap<UserModel, User>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(s);
            DataAccessFactory.UserDataAccess().Add(data);
        }

        public static void Delete(int id)
        {
            DataAccessFactory.UserDataAccess().Delete(id);
        }

        public static void Edit(UserModel e)
        {
            var config = new MapperConfiguration(cfg => {

                cfg.CreateMap<UserModel, User>();
            }
                );
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(e);
            DataAccessFactory.UserDataAccess().Edit(data);

        }
    }
}
