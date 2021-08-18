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
    public class KeyReconcileController : ApiController
    {
        private readonly IMaster<KeyReconcile> Service;
        public KeyReconcileController()
        {
            Service = new KeyReconcileService();
        }
       
        // POST api/<controller>
        public IHttpActionResult Create(KeyReconcile keyReconcile)
        {
            if (ModelState.IsValid)
            {
                Service.AddEntity(keyReconcile);
                return Content(HttpStatusCode.Created, "Accept KeyReconcilation.");
            }
            else
            {
                return Content(HttpStatusCode.NotAcceptable,"Required fill is not fullfill.");
            }
        }
    }
}