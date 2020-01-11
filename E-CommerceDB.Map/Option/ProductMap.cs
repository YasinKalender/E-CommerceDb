using E_CommerceDb.DAL.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB.Map.Option
{
    public class ProductMap : CoreMap<Product>
    {
        public ProductMap()
        {
            ToTable("dbo.Products");
            Property(i => i.Discount).IsOptional();
            Property(i => i.ProductName).HasMaxLength(20).IsRequired();
            Property(i => i.QuntitiyPerUnit).IsOptional();
            Property(i => i.UnitPrice).IsRequired();
            Property(i => i.UnitsOnOrder).IsOptional();
            Property(i => i.UnitStock).IsRequired();
            Property(i => i.RecorderLevel).IsOptional();
            Property(i => i.status.ToString()).IsRequired();

            HasRequired(i => i.category)
                .WithMany(i => i.products)
                .HasForeignKey(i => i.CategoryID)
                .WillCascadeOnDelete(false);

            HasRequired(i => i.suppilers)
                .WithMany(i => i.products)
                .HasForeignKey(i => i.SuppilersID)
                .WillCascadeOnDelete(false);

            HasMany(i => i.orderDetails)
                .WithRequired(i => i.product)
                .HasForeignKey(i => i.ProductID)
                .WillCascadeOnDelete(false);
            



        }


    }
}
