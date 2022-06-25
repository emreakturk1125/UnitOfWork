using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDesignPattern.Entities;

namespace UnitOfWorkDesignPattern.DAL.Interfaces
{
    public interface IAccountDal : IGenericDal<Account>
    {
    }
}
