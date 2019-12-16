using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.DAL.Model.ORM.Entity.Concrete
{
    public class OrderDetails:BaseEntity
    {

        public int UnitPrice { get; set; }

        public int Quantity { get; set; }

        public int Discount { get; set; }


     
        public int ProductID { get; set; }

        public virtual Product product { get; set; }

      
        public int OrdersID { get; set; }

        public virtual Orders Orders { get; set; }
    }
}
