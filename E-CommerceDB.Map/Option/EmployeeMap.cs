using E_CommerceDb.DAL.Model.ORM.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB.Map.Option
{
    public class EmployeeMap : CoreMap<Employees>
    {
        public EmployeeMap()
        {
            ToTable("dbo.Employees");
            Property(i => i.Adress).HasMaxLength(30).IsRequired();
            Property(i => i.BirthDate).IsOptional();
            Property(i => i.Country).HasMaxLength(15).IsRequired();
            Property(i => i.Extension).IsOptional();
            Property(i => i.FirstName).HasMaxLength(15).IsRequired();
            Property(i => i.HireDate).IsRequired();
            Property(i => i.HomePhone).IsRequired();
            Property(i => i.LastName).HasMaxLength(15).IsRequired();
            Property(i => i.Notes).IsOptional();
            Property(i => i.Photo).IsOptional();
            Property(i => i.PostalCode).IsOptional();
            Property(i => i.Region).IsOptional();
            Property(i => i.ReposTo).IsOptional();
            Property(i => i.Title).IsRequired();
            Property(i => i.TitleOfCourtesy).IsRequired();
            Property(i => i.role.ToString()).IsRequired();

            HasMany(i => i.orders)
                .WithRequired(i => i.employees)
                .HasForeignKey(i => i.EmployeesID)
                .WillCascadeOnDelete(false);
            


        }


    }
}
