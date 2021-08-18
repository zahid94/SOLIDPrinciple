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
    [RoutePrefix("api/LeaveOfAbsence")]
    public class LeaveOfAbsenceController : ApiController
    {
        private readonly LeaveOfAbsenceService service;
        public LeaveOfAbsenceController()
        {
            service = new LeaveOfAbsenceService();
        }

        [HttpGet]
        [Route("LeaveForUser/{id}")]
        // GET api/<controller>/5
        public IEnumerable<LeaveOfAbsence> LeaveForUser(int id)
        {
            return service.LeaveForUser(x=>x.UserId==id);
        }

        [HttpPost]
        [Route("Post")]
        // POST api/<controller>
        public void Post(LeaveOfAbsence absence)
        {
            if (ModelState.IsValid)
            {
                service.AddEntity(absence);
            }
        }
    }
}