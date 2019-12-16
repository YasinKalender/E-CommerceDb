using E_CommerceDb.DAL.Model.ORM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.DAL.Model.ORM.Entity.Concrete
{
    public class Employees:BaseEntity
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string TitleOfCourtesy { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime HireDate { get; set; }

        public string Adress { get; set; }

        public string Region { get; set; }

        public int PostalCode { get; set; }

        public string Country { get; set; }

        public string HomePhone { get; set; }

        public int Extension { get; set; }

        public string Photo { get; set; }

        public string Notes { get; set; }

        public int ReposTo { get; set; }

        public virtual Role role { get; set; }


        public List<Orders> orders { get; set; }
    }
}
