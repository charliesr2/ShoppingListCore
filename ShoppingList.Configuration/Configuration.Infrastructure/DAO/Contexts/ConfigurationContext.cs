using Configuration.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Configuration.Infrastructure.DAO.Contexts
{
    public class ConfigurationContext : DbContext
    {
        public DbSet<ConfigurationEntity> Configurations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.99.100;Database=ShoppingList;User Id=SA;Password = yourStrong(!)Password");
        }
    }
}
