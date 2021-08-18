using SOLIDPrinciple.Models;
using SOLIDPrinciple.Service.ISP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SOLIDPrinciple.Controllers.ISP
{
    [RoutePrefix("api/Payment")]
    public class PaymentController : ApiController
    {
        private readonly PaymentService service;
        public PaymentController()
        {
            service = new PaymentService();
        }

        [HttpGet]
        [Route("PaymentForUsers/{Id}")]
        // GET api/<controller>
        public IEnumerable<Payment> PaymentForUsers(int Id)
        {
            return service.PaymentForUser(x=>x.UserId==Id);
        }

        [HttpPost]
        [Route("Create")]
        // POST api/<controller>
        public void Create(Payment payment)
        {
            if (ModelState.IsValid)
            {
                service.AddEntity(payment);
            }
        }
    }
}