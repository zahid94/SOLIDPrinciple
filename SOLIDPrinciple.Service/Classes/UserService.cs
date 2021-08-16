using SOLIDPrinciple.Models;
using SOLIDPrinciple.Models.ContextArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Service.Classes
{
    public class UserService
    {
        private readonly SOLIDPrincipleDbContext dbContext;
        private readonly TwilloService twilloService;
        public UserService()
        {
            dbContext = new SOLIDPrincipleDbContext();
        }
        public void AddUsers(Users users)
        {
            dbContext.Users.Add(users);
            
            // THIS SRP ROLE APPLY
            twilloService.TwilioSay(users.Phone, "You are registered.");
        }
    }
}
