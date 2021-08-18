﻿using SOLIDPrinciple.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.Service.ISP
{
    public class Payment : ICommon<Payment>, IPayment<Payment>
    {
        private readonly IGenericRepository<Payment> repository;
        public Payment()
        {
            repository = new GenericRepository<Payment>();
        }
        public Payment AddEntity(Payment entity)
        {
            return repository.AddEntity(entity);
        }

        public IEnumerable<Payment> PaymentForUser(Expression<Func<Payment, bool>> expression)
        {
            return repository.GetFilterRecord(expression);
        }
    }
}
