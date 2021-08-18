using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Service.DIP
{
    public interface IMaster<TEntity> where TEntity : class
    {
        TEntity AddEntity(TEntity entity);
    }
}
