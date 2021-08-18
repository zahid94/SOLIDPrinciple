using SOLIDPrinciple.Models;
using SOLIDPrinciple.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Service.DIP
{
    public class KeyMovementService : IMaster<KeyMovement>
    {
        private readonly IGenericRepository<KeyMovement> repository;
        public KeyMovementService()
        {
            repository = new GenericRepository<KeyMovement>();
        }
        public KeyMovement AddEntity(KeyMovement entity)
        {
            return repository.AddEntity(entity);
        }
    }
}
