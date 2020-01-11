using E_CommerceDb.DAL.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB.Map.Option
{
    public class OrderMap : CoreMap<Orders>
    {
        public OrderMap()
        {
            ToTable("dbo.Orders");
            Property(i => i.Freight).IsRequired();
            Property(i => i.RequiredDate).IsRequired();
            Property(i => i.ShipAdress).HasMaxLength(20).IsRequired();
            Property(i => i.ShipCity).HasMaxLength(15).IsRequired();
            Property(i => i.ShipCountry).HasMaxLength(15).IsRequired();
            Property(i => i.ShipName).HasMaxLength(15).IsRequired();
            Property(i => i.ShippedDate).IsRequired();
            Property(i => i.ShipPostalCode).IsRequired();
            Property(i => i.ShipRegion).IsOptional();
            Property(i => i.ShipVia).IsOptional();
            Property(i => i.OrderDate).IsRequired();
            Property(i => i.status.ToString()).IsRequired();

            HasMany(i => i.orderDetails)
                .WithRequired(i => i.Orders)
                .HasForeignKey(i => i.OrdersID)
                .WillCascadeOnDelete(false);


            HasRequired(i => i.employees)
                .WithMany(i => i.orders)
                .HasForeignKey(i => i.EmployeesID)
                .WillCascadeOnDelete(false);

            HasRequired(i => i.shippers)
                .WithMany(i => i.orders)
                .HasForeignKey(i => i.ShippersID)
                .WillCascadeOnDelete(false);

            HasRequired(i => i.customers)
                .WithMany(i => i.orders)
                .HasForeignKey(i => i.CustomerID)
                .WillCascadeOnDelete(false);
            



        }


    }
}
