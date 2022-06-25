using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDesignPattern.Entities;

namespace UnitOfWorkDesignPattern.DAL.Context
{
    public class UowContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.254.98;Database=Deneme;user id=tekhne;password=42+SqSKm-E]+;MultipleActiveResultSets=True;");
        }

        public DbSet<Account> Accounts { get; set; }    
    }
}
