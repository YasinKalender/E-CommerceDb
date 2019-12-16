using E_CommerceDb.DAL.Model.ORM.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.DAL.Model.ORM.Entity.Abstract
{
    public interface ISuppilersCustomers
    {
        [Required, MaxLength(20)]
        string CampanyName { get; set; }

        [Required, MaxLength(20)]
        string ContactName { get; set; }

        [Required, MaxLength(10)]
        string ContactTitle { get; set; }

        [Required, MaxLength(30)]
        string Adress { get; set; }

        [Required, MaxLength(10)]
        string City { get; set; }

        [Required, MaxLength(10)]
        string Region { get; set; }

        [Required, MaxLength(10)]
        int PostalCode { get; set; }

        [Required, MaxLength(10)]

        string Country { get; set; }

        [Required, MaxLength(10)]
        string Phone { get; set; }

        int Fax { get; set; }

        
    }
}
