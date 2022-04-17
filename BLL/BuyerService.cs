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
    public class BuyerService
    {
        public static List<BuyerModel> Get()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Buyer, BuyerModel>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<BuyerModel>>(DataAccessFactory.BuyerDataAccess().Get());
            return data;
        }

        public static List<string> GetNames()
        {
            var data = DataAccessFactory.BuyerDataAccess().Get().Select(e=> e.name).ToList();
            return data;
        }

        

        public static void Add(BuyerModel s)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BuyerModel, Buyer>());
            var mapper = new Mapper(config);
            var data = mapper.Map<Buyer>(s);
            DataAccessFactory.BuyerDataAccess().Add(data);
        }

        public static void Delete(int id)
        {
            DataAccessFactory.BuyerDataAccess().Delete(id);
        }

        public static void Edit(BuyerModel e)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BuyerModel, Buyer>());
            var mapper = new Mapper(config);
            var data = mapper.Map<Buyer>(e);
            DataAccessFactory.BuyerDataAccess().Edit(data);

        }

    }
}
