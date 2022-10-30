﻿using CRM.Entity.Layer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DataAccess.Layer.Concrete
{  
        public class Context : DbContext
        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-60DI5A8;Database=DbCRM;User Id=aycaa; Password=admin; integrated security=True;");
            }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Category> Categories { get; set; }
    }
    
}
