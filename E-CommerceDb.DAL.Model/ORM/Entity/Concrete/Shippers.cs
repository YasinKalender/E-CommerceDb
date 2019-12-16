﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDb.DAL.Model.ORM.Entity.Concrete
{
    public class Shippers:BaseEntity
    {
        [Required]
        public string CampanyName { get; set; }

        [Required]
        public string Phone { get; set; }

        public List<Orders> orders { get; set; }
    }
}
