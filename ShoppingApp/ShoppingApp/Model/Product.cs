﻿using System.Xml.Linq;

namespace ShoppingApp.Model
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string ImageFile { get; set; }
        public decimal Price { get; set; }
    }
}
