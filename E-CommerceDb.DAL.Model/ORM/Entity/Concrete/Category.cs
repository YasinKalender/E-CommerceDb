using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.DAL.Model.ORM.Entity.Concrete
{
    public class Category:BaseEntity
    {
       
        public string CategoryName { get; set; }

       
        public string CategoryDescription { get; set; }

        public string Picture { get; set; }

        public List<Product> products { get; set; }

    }
}
