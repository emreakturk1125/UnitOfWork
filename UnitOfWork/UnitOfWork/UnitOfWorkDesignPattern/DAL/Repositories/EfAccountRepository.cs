using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDesignPattern.DAL.Context;
using UnitOfWorkDesignPattern.DAL.Interfaces;
using UnitOfWorkDesignPattern.Entities;

namespace UnitOfWorkDesignPattern.DAL.Repositories
{
    public class EfAccountRepository : EfGenericRepository<Account>,IAccountDal
    {
        public EfAccountRepository(UowContext uowContext) : base(uowContext)
        {
        }
    }
}
