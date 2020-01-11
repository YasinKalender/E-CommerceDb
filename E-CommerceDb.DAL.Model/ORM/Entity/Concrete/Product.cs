using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.DAL.Model.ORM.Entity.Concrete
{
    public class Product:BaseEntity
    {
  
        public string ProductName { get; set; }

       
        public string QuntitiyPerUnit { get; set; }
        
        public decimal UnitPrice { get; set; }
        
        public int UnitStock { get; set; }

        
        public int UnitsOnOrder { get; set; }

        
        public int RecorderLevel { get; set; }

        
        public int Discount { get; set; }

       
        public int CategoryID { get; set; }

        public virtual Category category { get; set; }

      
        public int SuppilersID { get; set; }

        public virtual Suppilers suppilers { get; set; }

        public List<OrderDetails> orderDetails { get; set; }

    }
}
