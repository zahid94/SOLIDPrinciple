using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Service.LSP
{
    public interface IAction<TEntity> where TEntity : class
    {
        TEntity AddEntity(TEntity entity);
    }
}
