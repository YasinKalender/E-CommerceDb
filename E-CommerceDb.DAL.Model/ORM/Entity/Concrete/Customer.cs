using E_CommerceDb.DAL.Model.ORM.Entity.Abstract;
using E_CommerceDb.DAL.Model.ORM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.DAL.Model.ORM.Entity.Concrete
{
    public class Customer:BaseEntity,ISuppilersCustomers
    {
        public string CampanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public int Fax { get; set; }

        public virtual Role role { get; set; }

        public List<Orders> orders { get; set; }

    }
}
