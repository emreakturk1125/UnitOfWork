using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDesignPattern.Entities;

namespace UnitOfWorkDesignPattern.BLL.Interfaces
{
    public interface IAccountService : IGenericService<Account>
    {
    }
}
