﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SporthalC3.API
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        public String Name { get; set; }




    }
}
