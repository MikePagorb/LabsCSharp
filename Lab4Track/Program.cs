﻿using System;
using System.Collections.Generic;
using System.Linq;

//Розробити структуру даних для зберігання інформації про меню ресторану.
// Для об‘єктів зберігається наступна інформація: продукт – назва, кількість калорій;
//блюдо – назва, продукти та їх кількість; меню – дата, блюдо, вартість.(LINQ to obj)


namespace Lab4Track
{
    class Program
    {

        static void Main(string[] args)
        {
            (List<Product> products, List<Dish> dishes, List<Menu> menus) Data = GetMenu();
            var products = Data.products;
            var dishes = Data.dishes;
            var menus = Data.menus;
            Console.WriteLine("Initialize");

            Console.WriteLine("1)List of all menus:");


            foreach (var menu in menus)
            {
                Console.WriteLine($"Menu from {menu.Date} \n" +
                                  $"Dishes: {string.Join(',', menu.Dishes)}");
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("2) All products, that have >30 calories");
            var caloriesResult = products.Where(p => p.Calories > 30);
            foreach (var product in caloriesResult)
            {
                Console.WriteLine($"Product {product.Name} with {product.Calories} calories");
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("3) All products and dishes, where they used");
            // var result = from pr in products
            //             join dish in dishes on pr equals dish.Products.Contains()
            var result = products.Select(p => new
            {
                Name = p.Name,
                Dishes = dishes.Where(d => d.Products.Contains(p)).Select(d => d.Name)
            });

            foreach (var product in result)
            {
                Console.WriteLine($"Product {product.Name} in dishes {string.Join(",", product.Dishes)}");
            }
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("4) Products, ordered by Calories");
            var resultOrderCalories = products.OrderBy(p => p.Calories);
            foreach (var product in resultOrderCalories)
            {
                Console.WriteLine($"Product {product.Name} Calories : {product.Calories}");
            }
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("5) Products, contains 'a'");
            var resultA = products.Where(p => p.Name.Contains("a"));
            foreach (var product in resultA)
            {
                Console.WriteLine($"Product {product.Name} Calories : {product.Calories}");
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("6) All dishes, where one product contains 'a'");
            var resultCotainsA = dishes.Where(d => d.Products.Any(p => p.Name.Contains("a")));
            foreach (var dish in resultCotainsA)
            {
                Console.WriteLine($"Dish {dish.Name}, Products {string.Join(",", dish.Products)}");
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("7) All dishes, grouped by products count");
            var resultGrouped = dishes.GroupBy(d => d.Products.Count);
            foreach (var dish in resultGrouped)
            {
                Console.WriteLine($"{dish.Key}: \n {string.Join("\n", dish)}");
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("8) Sum product for each menu");
            var resultSum = menus.Select(m => new { Menu = m.Date, Sum = m.Prices.Values.Sum() });
            foreach (var menu in resultSum)
            {
                Console.WriteLine($"{menu.Menu}: {menu.Sum}");
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("9) All menus, that contains eggs");
            var resultContains = menus.Where(m => m.Dishes.Any(p => p.Products.Any(p => p.Name == "Egg")));
            foreach (var menu in resultContains)
            {
                Console.WriteLine($"Menu from date : {menu.Date}");
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("10) All menus grouped by date");
            var resultDate = from menu in menus
                              group menu by menu.Date;
            foreach (var menu in resultDate)
            {
                Console.WriteLine($"{menu.Key} Count : {menu.Count()}");
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("11) All dishes in menus orderd by price");
            var res = menus.Select(m => new { Date = m.Date, Dishes = m.Prices.OrderBy(d => d.Value) });
            foreach (var menu in res)
            {
                Console.WriteLine($"Menu : {menu.Date.Date} Dishes {string.Join(",", menu.Dishes)}");
            }

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("12) All dishes and number of products");
            var resultNumbers = from d in dishes
                                 select new { Name = d.Name, Count = d.Products.Count };
            foreach (var dish in resultNumbers)
            {
                Console.WriteLine($"Dish {dish.Name} Count {dish.Count}");
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("13) All dishes, where sum of calories < 150");
            var caloriesRes = dishes.Where(d => d.Products.Select(p => p.Calories).Sum() < 150).Select(p => new { Name = p.Name, Sum = p.Products.Select(p => p.Calories).Sum() });

            foreach (var dish in caloriesRes)
            {
                Console.WriteLine($"Dish {dish.Name} Calories {dish.Sum}");
            }

            Console.WriteLine("14) All menus, where sum > 440");
            var resultSumAll = menus.Select(m => new { Menu = m.Date, Sum = m.Prices.Values.Sum() }).Where(m => m.Sum > 440);
            foreach (var menu in resultSumAll)
            {
                Console.WriteLine($"{menu.Menu}: {menu.Sum}");
            }
            Console.WriteLine("15) Products and dishes, where it is");
            var productsResult = products.Select(p => new
            { Producs = p.Name, Dishes = dishes.Where(d => d.Products.Contains(p)) });
            foreach (var product in productsResult)
            {
                Console.WriteLine($"Product {product.Producs} in {string.Join(",", product.Dishes.Select(d => d.Name))} dishes\n");
            }


        }

        private static (List<Product> products, List<Dish> dishes, List<Menu> menus) GetMenu()
        {
            List<Product> product = new List<Product>()
            {
                new Product() {Name = "Cheaken", Calories = 45},
                new Product() {Name = "Chees", Calories = 67},
                new Product() {Name = "Vino", Calories = 43},
                new Product() {Name = "Meat", Calories = 100},
                new Product() {Name = "Milk", Calories = 20},
                new Product() {Name = "Potato", Calories = 56},
                new Product() {Name = "Tomato", Calories = 34},
                new Product() {Name = "Egg", Calories = 30}
            };
            List<Dish> dishes = new List<Dish>()
            {
                new Dish() {Name = "Dish1", Products = new List<Product>() {product[0], product[3]}},
                new Dish() {Name = "Dish2", Products = new List<Product>() {product[3], product[7], product[3]}},
                new Dish() {Name = "Dish3", Products = new List<Product>() {product[5], product[6], product[4]}},
                new Dish() {Name = "Dish4", Products = new List<Product>() {product[3], product[2]}},
                new Dish() {Name = "Dish5", Products = new List<Product>() {product[1], product[7], product[0], product[2], product[2]}},
                new Dish() {Name = "Dish6", Products = new List<Product>() {product[7], product[4], product[1], product[7]}},
                new Dish() {Name = "Dish7", Products = new List<Product>() {product[1], product[6]}},
                new Dish() {Name = "Dish8", Products = new List<Product>() {product[3], product[7], product[4], product[1]}}
            };

            List<Menu> menus = new List<Menu>();
            var random = new Random();
            for (int i = 0; i < 5; i++)
            {
                var menu = new Menu() { Date = DateTime.Now.Add(TimeSpan.FromDays(random.Next(1, 7))) };
                for (int j = 0; j < random.Next(1, 5); j++)
                {
                    var dish = dishes[random.Next(0, dishes.Count - 1)];
                    menu.Dishes.Add(dish);
                    try
                    {
                        menu.Prices.Add(dish.Name, random.Next(100, 500));
                    }
                    catch
                    {
                        continue;
                    }
                }
                menus.Add(menu);
            }

            return (product, dishes, menus);

        }
    }
}