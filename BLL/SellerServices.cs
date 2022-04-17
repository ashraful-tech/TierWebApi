using System;
using BEL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using AutoMapper;

namespace BLL
{
    public  class SellerServices
    {
        public static List<SellerModel> Get()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Seller, SellerModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<SellerModel>>(DataAccessFactory.SellerDataAccess().Get());
            return data;
        }

        public static List<string> GetNames()
        {
            var data = DataAccessFactory.SellerDataAccess().Get().Select(e => e.name).ToList();
            return data;
        }



        public static void Add(SellerModel s)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<SellerModel, Seller>());
            var mapper = new Mapper(config);
            var data = mapper.Map<Seller>(s);
            DataAccessFactory.SellerDataAccess().Add(data);
        }

        public static void Delete(int id)
        {
            DataAccessFactory.SellerDataAccess().Delete(id);
        }

        public static void Edit(SellerModel e)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<SellerModel, Seller>());
            var mapper = new Mapper(config);
            var dat = mapper.Map<Seller>(e);
            DataAccessFactory.SellerDataAccess().Edit(dat);

        }
    }
}
