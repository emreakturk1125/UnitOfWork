using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDesignPattern.BLL.Interfaces;
using UnitOfWorkDesignPattern.DAL.UnitOfWork;
using UnitOfWorkDesignPattern.Entities;

namespace UnitOfWorkDesignPattern.BLL.Concrete
{
    public class AccountManager : GenericManager<Account>, IAccountService
    {
        private readonly IUnitOfWork  _unitOfWork;   
        public AccountManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;   
        }
    }
}
