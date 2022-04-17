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
    public class UserController : ApiController
    {
        [Route("api/User/Names")]
        [HttpGet]
        public HttpResponseMessage GetNames()
        {
            var lt = UserService.GetNames();
            return Request.CreateResponse(HttpStatusCode.OK, lt);
        }

        [HttpGet]
        [Route("api/User/All")]
        public HttpResponseMessage Get()
        {
            var list = UserService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, list);

        }

        [Route("api/User/Create")]
        [HttpPost]
        public void Add(UserModel s)
        {
            UserService.Add(s);
        }
        [Route("api/User/Delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            UserService.Delete(id);
        }

        [Route("api/Admin/Edit")]
        [HttpPut]
        public void Edit(UserModel e)
        {
            UserService.Edit(e);
        }
    }
}
