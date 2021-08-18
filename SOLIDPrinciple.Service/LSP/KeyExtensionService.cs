using SOLIDPrinciple.Models;
using SOLIDPrinciple.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Service.LSP
{
    public class KeyExtensionService:IAction<KeyExtension>
    {
        private readonly IGenericRepository<KeyExtension> repository;
        public KeyExtensionService()
        {
            repository = new GenericRepository<KeyExtension>();
        }
        public KeyExtension AddEntity(KeyExtension entity)
        {
            entity.KeyRequestId = 2; ///sample
            return repository.AddEntity(entity);
        }
    }
}
