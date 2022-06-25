using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDesignPattern.BLL.Interfaces;
using UnitOfWorkDesignPattern.DAL.UnitOfWork;

namespace UnitOfWorkDesignPattern.BLL.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class,new()
    {
        private readonly IUnitOfWork _unitOfWork;       
        public GenericManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;   
        }
        public void Add(T entity)
        {
             _unitOfWork.GetRepository<T>().Add(entity);
            _unitOfWork.SaveChanges();  
        }
         
    } 
}
