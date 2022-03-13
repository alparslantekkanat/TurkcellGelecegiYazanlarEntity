﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyEntity2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public int? CategoryId { get; set; }



    }

}
