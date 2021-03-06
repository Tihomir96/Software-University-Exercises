﻿using System.Collections.Generic;

namespace ProductsShop.Data.Models
{
    public class Category
    {
        public Category()
        {
            this.Products=new List<CategoryProduct>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CategoryProduct> Products { get; set; }
    }
}
