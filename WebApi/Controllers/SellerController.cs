using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class SellerController : ApiController
    {
        
        [Route("api/Seller/Names")]
        [HttpGet]
        public HttpResponseMessage GetNames()
        {
            var lt = SellerServices.GetNames();
            return Request.CreateResponse(HttpStatusCode.OK, lt);
        }

        [HttpGet]
        [Route("api/Seller/All")]
        public HttpResponseMessage Get()
        {
            var list = SellerServices.Get();
            return Request.CreateResponse(HttpStatusCode.OK, list);

        }

        [Route("api/Seller/Create")]
        [HttpPost]
        public void Add(SellerModel s)
        {
            SellerServices.Add(s);
        }
        [Route("api/Seller/Delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            SellerServices.Delete(id);
        }

        [Route("api/Seller/Edit")]
        [HttpPut]
        public void Edit(SellerModel e)
        {
            SellerServices.Edit(e);
        }


    }
}

