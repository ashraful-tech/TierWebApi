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
    public class AdminController : ApiController
    {
        [Route("api/Admin/Names")]
        [HttpGet]
        public HttpResponseMessage GetNames()
        {
            var lt = AdminService.GetNames();
            return Request.CreateResponse(HttpStatusCode.OK, lt);
        }

        [HttpGet]
        [Route("api/Admin/All")]
        public HttpResponseMessage Get()
        {
            var list = AdminService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, list);

        }

        [Route("api/Admin/Create")]
        [HttpPost]
        public void Add(AdminModel s)
        {
            AdminService.Add(s);
        }
        [Route("api/Admin/Delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            AdminService.Delete(id);
        }

        [Route("api/Admin/Edit")]
        [HttpPut]
        public void Edit(AdminModel e)
        {
            AdminService.Edit(e);
        }

        [Route("api/Admin/User/Edit")]
        [HttpPut]
        public void Edit(UserModel e)
        {
            UserService.Edit(e);
        }

    }
}
