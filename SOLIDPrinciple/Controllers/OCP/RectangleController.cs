using SOLIDPrinciple.Service.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SOLIDPrinciple.Controllers.OCP
{
    public class RectangleController : ApiController
    {
        private readonly RectangleService service;

        // GET api/<controller>/5
        public double AreaGet(int Height,int Width)
        {
            service.Height = Height;
            service.Width = Width;
            return service.Area();
        }
    }
}