using System;
using System.Collections.Generic;

namespace Lab4Track
{
    public class Product
    {
        public string Name { get; set; }
        public int Calories { get; set; }

        public override string ToString()
        {
            return $"Product {Name}";
        }
    }
}