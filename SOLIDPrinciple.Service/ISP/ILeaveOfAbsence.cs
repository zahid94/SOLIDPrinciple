using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Service.ISP
{
    public interface ILeaveOfAbsence<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> LeaveForUser(Expression<Func<TEntity, bool>> expression);
    }
}
