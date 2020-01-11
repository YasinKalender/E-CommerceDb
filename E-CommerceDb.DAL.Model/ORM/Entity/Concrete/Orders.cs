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
        
        public DateTime OrderDate { get; set; }
     
        public DateTime RequiredDate { get; set; }
       
        public DateTime ShippedDate { get; set; }
       
        public int ShipVia { get; set; }
        
        public double Freight { get; set; }
        
        public string ShipName { get; set; }
        
        public string ShipAdress { get; set; }
        
        public string ShipCity { get; set; }
      
        public string ShipRegion { get; set; }
        
        public string ShipCountry { get; set; }
        
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
