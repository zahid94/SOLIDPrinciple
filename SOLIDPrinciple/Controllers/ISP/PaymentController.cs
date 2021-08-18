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
    public class PaymentController : ApiController
    {
        private readonly PaymentService service;
        public PaymentController()
        {
            service = new PaymentService();
        }
        // GET api/<controller>
        public IEnumerable<Payment> PaymentForUsers(int Id)
        {
            return service.PaymentForUser(x=>x.UserId==Id);
        }

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