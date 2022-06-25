using Microsoft.Extensions.DependencyInjection;
using System;
using UnitOfWorkDesignPattern.BLL.Concrete;
using UnitOfWorkDesignPattern.BLL.Interfaces;
using UnitOfWorkDesignPattern.DAL.Context;
using UnitOfWorkDesignPattern.DAL.Interfaces;
using UnitOfWorkDesignPattern.DAL.Repositories;
using UnitOfWorkDesignPattern.DAL.UnitOfWork;

namespace UnitOfWorkDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var provider = new ServiceCollection().AddDbContext<UowContext>()
                .AddScoped(typeof(IGenericService<>),typeof(GenericManager<>))
                .AddScoped(typeof(IGenericDal<>),typeof(EfGenericRepository<>))
                .AddScoped<IAccountService,AccountManager>()
                .AddScoped<IUnitOfWork,UnitOfWork>()
                .BuildServiceProvider();

            var accountService = provider.GetService<IAccountService>();

            accountService.Add(new Entities.Account
            {
                CustomerName = "Emre",
                Total = 1500
            });

            System.Console.WriteLine("İşlem gerçekleşti");
        }
    }
}
