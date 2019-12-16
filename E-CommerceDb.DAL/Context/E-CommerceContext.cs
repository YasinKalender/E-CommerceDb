using E_CommerceDb.DAL.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.DAL.Context
{
    public class E_CommerceContext : DbContext
    {
        public E_CommerceContext()
        {
            Database.Connection.ConnectionString = @"Server=.; Database=E-CommerceDatabase; integrated security=true;";
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Employees> Employees { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }

        public DbSet<Orders> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Shippers> Shippers { get; set; }

        public DbSet<Suppilers> Suppilers { get; set; }


    }
}
