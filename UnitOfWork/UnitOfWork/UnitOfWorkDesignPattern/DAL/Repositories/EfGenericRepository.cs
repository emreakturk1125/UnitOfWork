using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDesignPattern.DAL.Context;
using UnitOfWorkDesignPattern.DAL.Interfaces;

namespace UnitOfWorkDesignPattern.DAL.Repositories
{
    public class EfGenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        private readonly UowContext _uowContext;
        public EfGenericRepository(UowContext uowContext)
        {
            _uowContext = uowContext;
        }
         
        public void Add(T entity)
        {
           _uowContext.Add(entity);
        }
    }
}
