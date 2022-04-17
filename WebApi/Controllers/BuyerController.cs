using BLL;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class BuyerController : ApiController
    { 
        [Route("api/Buyer/Names")]
        [HttpGet]
        public HttpResponseMessage GetNames()
        {
            var lt= BuyerService.GetNames();
            return Request.CreateResponse(HttpStatusCode.OK, lt);
        }

        [HttpGet]
        [Route("api/Buyer/All")]
        public HttpResponseMessage Get()
        {
            var list = BuyerService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, list);

        }

        [Route("api/Buyer/Create")]
        [HttpPost]
        public void Add(BuyerModel s)
        {
            BuyerService.Add(s);
        }
        [Route("api/Buyer/Delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            BuyerService.Delete(id);
        }

        [Route("api/Buyer/Edit")]
        [HttpPut]
        public void Edit(BuyerModel e)
        {
            BuyerService.Edit(e);
        }

        
    }
         
    
}
