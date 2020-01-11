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
       
        string CampanyName { get; set; }

        
        string ContactName { get; set; }

        
        string ContactTitle { get; set; }

       
        string Adress { get; set; }

        
        string City { get; set; }

        
        string Region { get; set; }

       
        int PostalCode { get; set; }

       

        string Country { get; set; }

        
        string Phone { get; set; }

        int Fax { get; set; }

        
    }
}
