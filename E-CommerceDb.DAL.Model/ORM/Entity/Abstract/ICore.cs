using E_CommerceDb.DAL.Model.ORM.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.DAL.Model.ORM.Entity.Abstract
{
    public interface ICore
    {

       
        int ID { get; set; }
        DateTime AddDate { get; set; }

        DateTime? DeleteDate { get; set; }

        DateTime? UpdateDate { get; set; }

        Status status { get; set; }


        



    }
}
