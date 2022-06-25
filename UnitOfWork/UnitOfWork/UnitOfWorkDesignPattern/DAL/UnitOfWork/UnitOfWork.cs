using System;
using UnitOfWorkDesignPattern.DAL.Context;
using UnitOfWorkDesignPattern.DAL.Interfaces;
using UnitOfWorkDesignPattern.DAL.Repositories;

namespace UnitOfWorkDesignPattern.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IAccountDal AccountDal { get; set; }
        private readonly UowContext _context;
        public UnitOfWork(UowContext context)
        {
            _context = context; 
            AccountDal = new EfAccountRepository(_context);
        }

        public IGenericDal<T> GetRepository<T>() where T : class,new()
        {
            return new EfGenericRepository<T>(_context);
        }
        public void SaveChanges()
        {
           _context.SaveChanges();  
        }
    }
}
