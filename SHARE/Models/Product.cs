using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHARE.Models
{
    public class Product
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string Name, string Description, int Quantity)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;

        }
    }
}