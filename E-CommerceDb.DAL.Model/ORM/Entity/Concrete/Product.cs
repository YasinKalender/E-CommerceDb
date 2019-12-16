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
        [Required]
        public string ProductName { get; set; }

        [Required]
        public string QuntitiyPerUnit { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public int UnitStock { get; set; }

        [Required]
        public int UnitsOnOrder { get; set; }

        [Required]
        public int RecorderLevel { get; set; }

        [Required]
        public int Discount { get; set; }

       
        public int CategoryID { get; set; }

        public virtual Category category { get; set; }

      
        public int SuppilersID { get; set; }

        public virtual Suppilers suppilers { get; set; }

        public List<OrderDetails> orderDetails { get; set; }

    }
}
