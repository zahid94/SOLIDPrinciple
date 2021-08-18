using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Service.ISP
{
    public interface ICommon<TEntity> where TEntity : class
    {
        TEntity AddEntity(TEntity entity);
    }
}
