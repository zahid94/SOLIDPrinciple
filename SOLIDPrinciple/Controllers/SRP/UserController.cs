using SOLIDPrinciple.Models;
using SOLIDPrinciple.Service.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SOLIDPrinciple.Controllers.SRP
{
    public class UserController : ApiController
    {
        private readonly UserService service;
        public UserController()
        {
            service = new UserService();
        }

        // POST api/<controller>
        public IHttpActionResult Create(Users users)
        {
            if (ModelState.IsValid)
            {
                service.AddUsers(users);
                return Content(HttpStatusCode.Created, "User added.");
            }
            else
            {
                return Content(HttpStatusCode.NotAcceptable, "Requirement is not fullfull.");
            }
        }
    }
}