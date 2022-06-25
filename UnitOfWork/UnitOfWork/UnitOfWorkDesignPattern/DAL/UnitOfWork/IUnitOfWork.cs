using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDesignPattern.DAL.Interfaces;

namespace UnitOfWorkDesignPattern.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericDal<T> GetRepository<T>() where T : class, new();
        IAccountDal AccountDal { get; set; }
        void SaveChanges();
    }
}
