using E_CommerceDb.DAL.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB.Map.Option
{
    public class OrderDetailsMap : CoreMap<OrderDetails>
    {
        public OrderDetailsMap()
        {
            ToTable("dbo.OrderDetails");
            Property(i => i.Discount).IsOptional();
            Property(i => i.UnitPrice).IsRequired();
            Property(i => i.Quantity).IsOptional();
            Property(i => i.status.ToString()).IsRequired();


            HasRequired(i => i.product)
                .WithMany(i => i.orderDetails)
                .HasForeignKey(i => i.ProductID)
                .WillCascadeOnDelete(false);

            HasRequired(i => i.Orders)
                .WithMany(i => i.orderDetails)
                .HasForeignKey(i => i.OrdersID)
                .WillCascadeOnDelete(false);
        }



    }
}
