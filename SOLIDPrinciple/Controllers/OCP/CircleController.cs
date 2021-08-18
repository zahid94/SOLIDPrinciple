using SOLIDPrinciple.Service.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SOLIDPrinciple.Controllers.OCP
{
    [RoutePrefix("api/Circle")]
    public class CircleController : ApiController
    {
        private readonly CircleService service;
        public CircleController()
        {
            service = new CircleService();
        }

        [HttpGet]
        [Route("AreaGet/Radius")]
        // GET api/<controller>/5
        public double AreaGet(int Radius)
        {
            service.Radius = Radius;

            return service.Area();
        }
    }
}