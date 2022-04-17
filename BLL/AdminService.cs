using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace BLL
{
    public class AdminService
    {
        public static List<AdminModel> Get()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Admin, AdminModel>();
                cfg.CreateMap<User, UserModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<List<AdminModel>>(DataAccessFactory.AdminDataAccess().Get());
            return data;
        }

        public static List<string> GetNames()
        {
            var data = DataAccessFactory.AdminDataAccess().Get().Select(e => e.uname).ToList();
            return data;
        }

        public static void Add(AdminModel s)
        {
            var config = new MapperConfiguration(cfg => {

                cfg.CreateMap<AdminModel, Admin>();
                cfg.CreateMap<UserModel, User>();
                }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<Admin>(s);
            DataAccessFactory.AdminDataAccess().Add(data);
        }

        public static void Delete(int id)
        {
            DataAccessFactory.AdminDataAccess().Delete(id);
        }

        public static void Edit(AdminModel e)
        {
            var config = new MapperConfiguration(cfg => {

                cfg.CreateMap<AdminModel, Admin>();
                cfg.CreateMap<UserModel, User>();
                }
                );
            var mapper = new Mapper(config);
            var data = mapper.Map<Admin>(e);
            DataAccessFactory.AdminDataAccess().Edit(data);

        }
    }
}
