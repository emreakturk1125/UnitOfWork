using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkDesignPattern.DAL.Interfaces
{
    public interface IGenericDal<T> where T : class, new()
    {
        void Add(T entity);
    }
}
