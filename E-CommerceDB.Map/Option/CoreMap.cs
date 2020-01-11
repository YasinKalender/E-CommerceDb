using E_CommerceDb.DAL.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB.Map.Option
{
    public class CoreMap<T>:EntityTypeConfiguration <T> where T : BaseEntity
    {

        public CoreMap()
        {
            Property(i => i.ID).HasColumnName("ID").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(i => i.AddDate).HasColumnName("AddDate").IsRequired();
            Property(i => i.DeleteDate).HasColumnName("DeleteDate").IsOptional();
            Property(i => i.UpdateDate).HasColumnName("UpdateDate").IsOptional();
            Property(i => i.status.ToString()).HasColumnName("Status").IsRequired();
        }
    }
}
