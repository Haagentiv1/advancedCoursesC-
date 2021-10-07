using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace WebApplication.repositories
{
    public class Pizza
    {
        public int id { get; set; }
        public String name { get; set; }
        public String ingredients { get; set; }
        public double price { get; set; }

        public Pizza(int id, string name, string ingredients, double price)
        {
            this.id = id;
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.ingredients = ingredients ?? throw new ArgumentNullException(nameof(ingredients));
            this.price = price;
        }

        public Pizza()
        {
        }
    }
}