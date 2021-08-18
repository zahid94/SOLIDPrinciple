using SOLIDPrinciple.Models;
using SOLIDPrinciple.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Service.LSP
{
    public class KeyRequestService : IAction<KeyRequest>, IKeyRequest<KeyRequest>
    {
        private readonly IGenericRepository<KeyRequest> repository;
        public KeyRequestService()
        {
            repository = new GenericRepository<KeyRequest>();
        }
        public KeyRequest AddEntity(KeyRequest entity)
        {
            entity.RequesterId = 9; //sample
            return repository.AddEntity(entity);
        }
    }
}
