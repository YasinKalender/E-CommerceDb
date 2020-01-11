using E_CommerceDb.DAL.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB.Map.Option
{
    public class SuppilersMap : CoreMap<Suppilers>
    {
        public SuppilersMap()
        {

            ToTable("dbo.Suppilers");
            Property(i => i.Adress).HasMaxLength(20).IsRequired();
            Property(i => i.CampanyName).HasMaxLength(15).IsRequired();
            Property(i => i.City).IsRequired();
            Property(i => i.ContactName).HasMaxLength(15).IsRequired();
            Property(i => i.ContactTitle).IsRequired();
            Property(i => i.Country).HasMaxLength(15).IsRequired();
            Property(i => i.Fax).IsOptional();
            Property(i => i.HomePage).IsOptional();
            Property(i => i.Phone).HasMaxLength(15).IsRequired();
            Property(i => i.PostalCode).IsRequired();
            Property(i => i.Region).IsRequired();
            Property(i => i.status.ToString()).IsRequired();

            HasMany(i => i.products)
                .WithRequired(i => i.suppilers)
                .HasForeignKey(i => i.SuppilersID)
                .WillCascadeOnDelete(false);



        }



    }
}
