using E_CommerceDb.DAL.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB.Map.Option
{
    public class CategoryMap : CoreMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Categories");
            Property(i => i.CategoryName).HasMaxLength(10).IsRequired();
            Property(i => i.CategoryDescription).HasMaxLength(40).IsRequired();
            Property(i => i.Picture).IsRequired();
            Property(i => i.status.ToString()).IsRequired();

            HasMany(i => i.products)
                .WithRequired(i => i.category)
                .HasForeignKey(i => i.CategoryID)
                .WillCascadeOnDelete(false);


        }


    }
}
