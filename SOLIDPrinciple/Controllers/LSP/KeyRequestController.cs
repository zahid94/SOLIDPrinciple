using SOLIDPrinciple.Models;
using SOLIDPrinciple.Service.LSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SOLIDPrinciple.Controllers.LSP
{
    [RoutePrefix("api/KeyRequest")]
    public class KeyRequestController : ApiController
    {
        private readonly KeyRequestService service;
        public KeyRequestController()
        {
            service = new KeyRequestService();
        }
        
        // POST api/<controller>
        [HttpPost]
        [Route("Create")]

        public void Create(KeyRequest keyRequest)
        {
            if (ModelState.IsValid)
            {
                service.AddEntity(keyRequest);
            }
        }
    }
}