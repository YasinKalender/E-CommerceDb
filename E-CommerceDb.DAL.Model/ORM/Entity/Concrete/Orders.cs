using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.DAL.Model.ORM.Entity.Concrete
{
    public class Orders:BaseEntity
    {
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime RequiredDate { get; set; }
        [Required]
        public DateTime ShippedDate { get; set; }
        [Required]
        public int ShipVia { get; set; }
        [Required]
        public double Freight { get; set; }
        [Required]
        public string ShipName { get; set; }
        [Required]
        public string ShipAdress { get; set; }
        [Required]
        public string ShipCity { get; set; }
        [Required]
        public string ShipRegion { get; set; }
        [Required]
        public string ShipCountry { get; set; }
        [Required]
        public int ShipPostalCode { get; set; }

        public List<OrderDetails> orderDetails { get; set; }


     
        public int EmployeesID { get; set; }

        public  virtual Employees employees { get; set; }

    
        public int ShippersID { get; set; }

        public virtual Shippers shippers { get; set; }

        public int CustomerID { get; set; }

        public virtual Customer customers { get; set; }

    }
}
