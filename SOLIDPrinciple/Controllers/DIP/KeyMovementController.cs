using SOLIDPrinciple.Models;
using SOLIDPrinciple.Service.DIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SOLIDPrinciple.Controllers.DIP
{
    public class KeyMovementController : ApiController
    {
        private readonly IMaster<KeyMovement> Service;
        public KeyMovementController()
        {
            Service = new KeyMovementService();
        }

        // POST api/<controller>
        public IHttpActionResult Create(KeyMovement keyMovement)
        {
            if (ModelState.IsValid)
            {
                Service.AddEntity(keyMovement);
                return Content(HttpStatusCode.Created,"Accept Key Movement");
            }
            else
            {
                return Content(HttpStatusCode.NotAcceptable, "Required fill is not fullfill.");
            }
        }
    }
}