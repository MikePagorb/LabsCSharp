using System;
using System.Collections.Generic;

namespace Lab4Track
{
    public class Menu
    {
        public Menu()
        {
            Prices = new Dictionary<string, int>();
            Dishes = new List<Dish>();
        }
        public DateTime Date { get; set; }

        public Dictionary<string, int> Prices { get; set; }

        public List<Dish> Dishes { get; set; }

        public override string ToString()
        {
            return $"Menu from date {Date}";
        }
    }
}