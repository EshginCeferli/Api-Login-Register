﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.DTOs.Product
{
    public class ProductUpdateDto
    {
        public string? Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
    }
}
