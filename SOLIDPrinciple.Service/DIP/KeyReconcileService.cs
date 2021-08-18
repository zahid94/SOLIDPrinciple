using SOLIDPrinciple.Models;
using SOLIDPrinciple.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Service.DIP
{
    public class KeyReconcileService : IMaster<KeyReconcile>
    {
        private readonly IGenericRepository<KeyReconcile> repository;
        public KeyReconcileService()
        {
            repository = new GenericRepository<KeyReconcile>();
        }
        public KeyReconcile AddEntity(KeyReconcile entity)
        {
            return repository.AddEntity(entity);
        }
    }
}
