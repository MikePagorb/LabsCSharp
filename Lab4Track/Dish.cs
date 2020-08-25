using System.Collections.Generic;
using System.Runtime;

namespace Lab4Track
{
    public class Dish
    {

        public string Name { get; set; }

        public List<Product> Products { get; set; }

        public override string ToString()
        {
            return $"Dish {Name} Products: {string.Join(",", Products)}";
        }
    }
}