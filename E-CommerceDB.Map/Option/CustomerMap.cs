using E_CommerceDb.DAL.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB.Map.Option
{
    public class CustomerMap : CoreMap<Customer>
    {
        public CustomerMap()
        {
            ToTable("dbo.Customers");
            Property(i => i.CampanyName).HasMaxLength(15).IsRequired();
            Property(i => i.ContactName).HasMaxLength(15).IsRequired();
            Property(i => i.ContactTitle).HasMaxLength(15).IsRequired();
            Property(i => i.Country).HasMaxLength(10).IsRequired();
            Property(i => i.City).HasMaxLength(15).IsRequired();
            Property(i => i.Adress).HasMaxLength(40).IsRequired();
            Property(i => i.Fax).IsOptional();
            Property(i => i.Phone).HasMaxLength(20).IsRequired();
            Property(i => i.PostalCode).IsOptional();
            Property(i => i.Region).IsRequired();
            Property(i => i.role.ToString()).IsRequired();

            HasMany(i => i.orders)
                .WithRequired(i => i.customers)
                .HasForeignKey(i => i.CustomerID)
                .WillCascadeOnDelete(false);



            
        }


    }
}
