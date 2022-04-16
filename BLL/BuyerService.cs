using BLL.BEnt;
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
            var data = mapper.Map<List<BuyerModel>>(BuyerRepo.Get());
            return data;
        }

        public static List<string> GetNames()
        {
            var data = BuyerRepo.Get().Select(e=> e.name).ToList();
            return data;
        }

        

        public static void Add(BuyerModel s)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BuyerModel, Buyer>());
            var mapper = new Mapper(config);
            var data = mapper.Map<Buyer>(s);
            BuyerRepo.Add(data);
        }

        public static void Delete(int id)
        {
            BuyerRepo.Delete(id);
        }

        public static void Edit(BuyerModel e)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BuyerModel, Buyer>());
            var mapper = new Mapper(config);
            var data = mapper.Map<Buyer>(e);
            BuyerRepo.Edit(data);
        }
    }
}
