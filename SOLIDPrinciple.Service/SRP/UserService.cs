using SOLIDPrinciple.Models;
using SOLIDPrinciple.Models.ContextArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Service.SRP
{
    public class UserService
    {
        private readonly SOLIDPrincipleDbContext dbContext;
        public UserService()
        {
            dbContext = new SOLIDPrincipleDbContext();
        }
        public void AddUsers(Users users)
        {
            dbContext.Users.Add(users);

            TwilloService twilloService = new TwilloService();
            // THIS SRP ROLE APPLY
            twilloService.TwilioSay(users.Phone, "You are registered.");
        }
    }
}
