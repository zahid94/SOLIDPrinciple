using SOLIDPrinciple.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Service.ISP
{
    public class LeaveOfAbsence : ICommon<LeaveOfAbsence>, ILeaveOfAbsence<LeaveOfAbsence>
    {
        private readonly IGenericRepository<LeaveOfAbsence> repository;
        public LeaveOfAbsence()
        {
            repository = new GenericRepository<LeaveOfAbsence>();
        }
        public LeaveOfAbsence AddEntity(LeaveOfAbsence entity)
        {
            return repository.AddEntity(entity);
        }

        public IEnumerable<LeaveOfAbsence> LeaveForUser(Expression<Func<LeaveOfAbsence, bool>> expression)
        {
            return repository.GetFilterRecord(expression);
        }
    }
}
