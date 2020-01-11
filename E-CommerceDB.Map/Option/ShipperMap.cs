using E_CommerceDb.DAL.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB.Map.Option
{
    public class ShipperMap : CoreMap<Shippers>
    {

        public ShipperMap()
        {

            ToTable("dbo.Shippers");
            Property(i => i.CampanyName).HasMaxLength(15).IsRequired();
            Property(i => i.Phone).HasMaxLength(15).IsRequired();

            HasMany(i => i.orders)
                .WithRequired(i => i.shippers)
                .HasForeignKey(i => i.ShippersID)
                .WillCascadeOnDelete(false);


        }
    }
}
