﻿using System;
using System.Collections.Generic;

namespace SaleSystemData.Models
{
    public partial class Product
    {
        public Product()
        {
            Order = new HashSet<Order>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public string Unit { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
