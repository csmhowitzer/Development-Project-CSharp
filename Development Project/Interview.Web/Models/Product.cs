﻿using Interview.Web.Models.Intefaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace Interview.Web.Models
{
    public partial class Product : IProduct
    {
        public Product()
        {
            InventoryTransactions = new HashSet<InventoryTransaction>();
            ProductAttributes = new HashSet<ProductAttribute>();
            ProductCategories = new HashSet<ProductCategory>();
        }

        public int InstanceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductImageUris { get; set; }
        public string ValidSkus { get; set; }
        public DateTime CreatedTimestamp { get; set; }

        public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; }
        public virtual ICollection<ProductAttribute> ProductAttributes { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}