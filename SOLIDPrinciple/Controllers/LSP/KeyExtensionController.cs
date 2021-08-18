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
    public class KeyExtensionController : ApiController
    {
        private readonly KeyExtensionService service;
        public KeyExtensionController()
        {
            service = new KeyExtensionService();
        }

        // POST api/<controller>
        public void Create(KeyExtension keyExtension)
        {
            if (ModelState.IsValid)
            {
                service.AddEntity(keyExtension);
            }
        }
    }
}