using System;
using System.Linq;
using System.Xml.Linq;

//Розробити структуру даних для зберігання інформації про меню ресторану.
//Для об‘єктів зберігається наступна інформація: продукт – назва, кількість калорій;
//блюдо – назва, продукти та їх кількість; меню – дата, блюдо, вартість.(LINQ to XML)


namespace Lab5Track
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc1 = new XDocument();

            XElement product1 = new XElement("Product");
            XElement product1Name = new XElement("NameOfProduct","Potato");
            XElement product1Calories = new XElement("Calories", "74");
            product1.Add(product1Name);
            product1.Add(product1Calories);

            XElement product2= new XElement("Product");
            XElement product2Name = new XElement("NameOfProduct", "Tomato");
            XElement product2Calories = new XElement("Calories", "20");
            product2.Add(product2Name);
            product2.Add(product2Calories);

            XElement product3 = new XElement("Product");
            XElement product3Name = new XElement("NameOfProduct", "Carrot");
            XElement product3Calories = new XElement("Calories", "34");
            product3.Add(product3Name);
            product3.Add(product3Calories);

            XElement product4 = new XElement("Product");
            XElement product4Name = new XElement("NameOfProduct", "Beef");
            XElement product4Calories = new XElement("Calories", "250");
            product4.Add(product4Name);
            product4.Add(product4Calories);

            XElement product5 = new XElement("Product");
            XAttribute product5Attr = new XAttribute("TypeProduct", "Eggs");
            XElement product5Name = new XElement("NameOfProduct", "Eggs");
            XElement product5Calories = new XElement("Calories", "150");
            product5.Add(product5Attr);
            product5.Add(product5Name);
            product5.Add(product5Calories);

            XElement product6 = new XElement("Product");
            XElement product6Name = new XElement("NameOfProduct", "Apple");
            XElement product6Calories = new XElement("Calories", "47");
            product6.Add(product6Name);
            product6.Add(product6Calories);

            XElement product7 = new XElement("Product");
            XElement product7Name = new XElement("NameOfProduct", "Oats");
            XElement product7Calories = new XElement("Calories", "357");
            product7.Add(product7Name);
            product7.Add(product7Calories);

            XElement foodstuff = new XElement("Foodstuff");
            foodstuff.Add(product1);
            foodstuff.Add(product2);
            foodstuff.Add(product3);
            foodstuff.Add(product4);
            foodstuff.Add(product5);
            foodstuff.Add(product6);
            foodstuff.Add(product7);


            xdoc1.Add(foodstuff);
            xdoc1.Save("Foodstuff.xml");

            XDocument xdoc2 = new XDocument();

            XElement dish1 = new XElement("Dish");
            XElement dish1Name = new XElement("Name", "Mash Potatoes");
            XElement dish1QuantityProducts1 = new XElement("QuantityOfGramProduct1", "400");
            XAttribute dish1Product1 = new XAttribute("Product", "Potato");
            XElement dish1QuantityProducts2 = new XElement("QuantityOfGramProduct2", "100");
            XAttribute dish1Product2 = new XAttribute("Product", "Tomato");
            XElement dish1QuantityProducts3 = new XElement("QuantityOfGramProduct3", "100");
            XAttribute dish1Product3 = new XAttribute("Product", "Egg");
            dish1QuantityProducts1.Add(dish1Product1);
            dish1QuantityProducts2.Add(dish1Product2);
            dish1QuantityProducts3.Add(dish1Product3);
            dish1.Add(dish1Name);
            dish1.Add(dish1QuantityProducts1);
            dish1.Add(dish1QuantityProducts2);
            dish1.Add(dish1QuantityProducts3);

            XElement dish2 = new XElement("Dish");
            XElement dish2Name = new XElement("Name", "Salad");
            XElement dish2QuantityProducts1 = new XElement("QuantityOfGramProduct1", "200");
            XAttribute dish2Product1 = new XAttribute("Product", "Tomato");
            XElement dish2QuantityProducts2 = new XElement("QuantityOfGramProduct2", "300");
            XAttribute dish2Product2 = new XAttribute("Product", "Carrot");
            XElement dish2QuantityProducts3 = new XElement("QuantityOfGramProduct3", "100");
            XAttribute dish2Product3 = new XAttribute("Product", "Apple");
            dish2QuantityProducts1.Add(dish2Product1);
            dish2QuantityProducts2.Add(dish2Product2);
            dish2QuantityProducts3.Add(dish2Product3);
            dish2.Add(dish2Name);
            dish2.Add(dish2QuantityProducts1);
            dish2.Add(dish2QuantityProducts2);
            dish2.Add(dish2QuantityProducts3);

            XElement dish3 = new XElement("Dish");
            XElement dish3Name = new XElement("Name", "Beef Staek");
            XElement dish3QuantityProducts1 = new XElement("QuantityOfGramProduct1", "200");
            XAttribute dish3Product1 = new XAttribute("Product", "Beef");
            XElement dish3QuantityProducts2 = new XElement("QuantityOfGramProduct2", "200");
            XAttribute dish3Product2 = new XAttribute("Product", "Tomato");
            XElement dish3QuantityProducts3 = new XElement("QuantityOfGramProduct3", "100");
            XAttribute dish3Product3 = new XAttribute("Product", "Carrot");
            dish3QuantityProducts1.Add(dish3Product1);
            dish3QuantityProducts2.Add(dish3Product2);
            dish3QuantityProducts3.Add(dish3Product3);
            dish3.Add(dish3Name);
            dish3.Add(dish3QuantityProducts1);
            dish3.Add(dish3QuantityProducts2);
            dish3.Add(dish3QuantityProducts3);

            XElement dish4 = new XElement("Dish");
            XElement dish4Name = new XElement("Name", "Morning Oats");
            XElement dish4QuantityProducts1 = new XElement("QuantityOfGramProduct1", "200");
            XAttribute dish4Product1 = new XAttribute("Product", "Oats");
            XElement dish4QuantityProducts2 = new XElement("QuantityOfGramProduct2", "100");
            XAttribute dish4Product2 = new XAttribute("Product", "Egg");
            XElement dish4QuantityProducts3 = new XElement("QuantityOfGramProduct3", "200");
            XAttribute dish4Product3 = new XAttribute("Product", "Apple");
            dish4QuantityProducts1.Add(dish4Product1);
            dish4QuantityProducts2.Add(dish4Product2);
            dish4QuantityProducts3.Add(dish4Product3);
            dish4.Add(dish4Name);
            dish4.Add(dish4QuantityProducts1);
            dish4.Add(dish4QuantityProducts2);
            dish4.Add(dish4QuantityProducts3);

            XElement dishes = new XElement("Dishes");
            dishes.Add(dish1);
            dishes.Add(dish2);
            dishes.Add(dish3);
            dishes.Add(dish4);

            xdoc2.Add(dishes);
            xdoc2.Save("Dishes.xml");

            XDocument xdoc3 = new XDocument();

            XElement menu1 = new XElement("Menu");
            XElement menu1Date = new XElement("Date", "25.06.18 12:00");
            XElement menu1Dish = new XElement("Dish", "Beef Steak");
            XElement menu1Price = new XElement("Price", "400");
            menu1.Add(menu1Date);
            menu1.Add(menu1Dish);
            menu1.Add(menu1Price);

            XElement menu2 = new XElement("Menu");
            XElement menu2Date = new XElement("Date", "13.11.18 9:00");
            XElement menu2Dish = new XElement("Dish", "Morning Oats");
            XElement menu2Price = new XElement("Price", "247");
            menu2.Add(menu2Date);
            menu2.Add(menu2Dish);
            menu2.Add(menu2Price);

            XElement menu3 = new XElement("Menu");
            XElement menu3Date = new XElement("Date", "16.03.18 12:54");
            XElement menu3Dish = new XElement("Dish", "Mash Potatoes");
            XElement menu3Price = new XElement("Price", "150");
            menu3.Add(menu3Date);
            menu3.Add(menu3Dish);
            menu3.Add(menu3Price);

            XElement menu4 = new XElement("Menu");
            XElement menu4Date = new XElement("Date", "20.06.18 13:00");
            XElement menu4Dish = new XElement("Dish", "Salad");
            XElement menu4Price = new XElement("Price", "86");
            menu4.Add(menu4Date);
            menu4.Add(menu4Dish);
            menu4.Add(menu4Price);

            XElement fullMenu = new XElement("FullMenu");
            fullMenu.Add(menu1);
            fullMenu.Add(menu2);
            fullMenu.Add(menu3);
            fullMenu.Add(menu4);

            xdoc3.Add(fullMenu);
            xdoc3.Save("Menu.xml");

            Console.WriteLine(xdoc1);
            Console.WriteLine(xdoc2);
            Console.WriteLine(xdoc3);

            XDocument products = XDocument.Load("Foodstuff.xml");
            Console.WriteLine("1) Список всех продуктов:");
            Console.WriteLine();
            foreach(XElement xElement in products.Element("Foodstuff").Elements("Product"))
            {
                XElement nameOfProduct = xElement.Element("NameOfProduct");
                XElement Calories = xElement.Element("Calories");
                if(nameOfProduct != null && Calories != null)
                {
                    Console.WriteLine($"Name of product: {nameOfProduct.Value}");
                    Console.WriteLine($"Calories of product: {Calories.Value}");
                }
                Console.WriteLine();
            }

            XDocument Dishes = XDocument.Load("Dishes.xml");
            Console.WriteLine("2) Список всех блюд:");
            Console.WriteLine();
            foreach (XElement xElement in Dishes.Element("Dishes").Elements("Dish"))
            {
                XElement Name = xElement.Element("Name");
                XElement QuantityProduct1 = xElement.Element("QuantityOfGramProduct1");
                XAttribute Product1 = xElement.Element("QuantityOfGramProduct1").Attribute("Product");
                XElement QuantityProduct2 = xElement.Element("QuantityOfGramProduct2");
                XAttribute Product2 = xElement.Element("QuantityOfGramProduct2").Attribute("Product");
                XElement QuantityProduct3 = xElement.Element("QuantityOfGramProduct3");
                XAttribute Product3 = xElement.Element("QuantityOfGramProduct3").Attribute("Product");


                if (Name!=null && QuantityProduct1 != null && Product1 != null && QuantityProduct2 != null && Product2 != null && QuantityProduct3 != null && Product3 != null)
                {
                    Console.WriteLine($"Название блюда: {Name.Value}");
                    Console.WriteLine($"Местит: {Product1.Value} {QuantityProduct1.Value} грамм, {Product2.Value} {QuantityProduct2.Value} грамм, {Product3.Value} {QuantityProduct3.Value} грамм.");
                }
                Console.WriteLine();
            }

            XDocument Menu = XDocument.Load("Menu.xml");
            Console.WriteLine("3) Список всех меню:");
            Console.WriteLine();
            foreach(XElement xElement in Menu.Element("FullMenu").Elements("Menu"))
            {
                XElement Date = xElement.Element("Date");
                XElement Dish = xElement.Element("Dish");
                XElement Price = xElement.Element("Price");

                if(Date != null && Dish!=null &&Price != null)
                {
                    Console.WriteLine($"{Dish.Value} приготовлен {Date.Value}");
                    Console.WriteLine($"Цена: {Price.Value}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("4)Список продуктов, калорийность которых больше 150:");
            Console.WriteLine();
            var result1 = from item in products.Element("Foodstuff").Elements("Product")
                          where Convert.ToInt32(item.Element("Calories").Value) > 150
                          select item;
            foreach (XElement xElement in result1)
            {
                XElement nameOfProduct = xElement.Element("NameOfProduct");
                XElement Calories = xElement.Element("Calories");
                if (nameOfProduct != null && Calories != null)
                {
                    Console.WriteLine($"Name of product: {nameOfProduct.Value}");
                    Console.WriteLine($"Calories of product: {Calories.Value}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("5)Список блюд, которые имеют вес продукта в составе больше 200 грамм:");
            Console.WriteLine();
            var result2 = Dishes.Element("Dishes").Elements("Dish").Where(item => (Convert.ToInt32(item.Element("QuantityOfGramProduct1").Value) > 200 || 
                                                                                  Convert.ToInt32(item.Element("QuantityOfGramProduct2").Value) > 200 ||
                                                                                  Convert.ToInt32(item.Element("QuantityOfGramProduct3").Value) > 200));
            foreach (XElement xElement in result2)
            {
                XElement Name = xElement.Element("Name");
                XElement QuantityProduct1 = xElement.Element("QuantityOfGramProduct1");
                XAttribute Product1 = xElement.Element("QuantityOfGramProduct1").Attribute("Product");
                XElement QuantityProduct2 = xElement.Element("QuantityOfGramProduct2");
                XAttribute Product2 = xElement.Element("QuantityOfGramProduct2").Attribute("Product");
                XElement QuantityProduct3 = xElement.Element("QuantityOfGramProduct3");
                XAttribute Product3 = xElement.Element("QuantityOfGramProduct3").Attribute("Product");


                if (Name != null && QuantityProduct1 != null && Product1 != null && QuantityProduct2 != null && Product2 != null && QuantityProduct3 != null && Product3 != null)
                {
                    Console.WriteLine($"Название блюда: {Name.Value}");
                    Console.WriteLine($"Местит: {Product1.Value} {QuantityProduct1.Value} грамм, {Product2.Value} {QuantityProduct2.Value} грамм, {Product3.Value} {QuantityProduct3.Value} грамм.");
                }
                Console.WriteLine();
            }

            Console.WriteLine("6)Список список продуктов отсортированых за алфавитом:");
            Console.WriteLine();
            var result3 = products.Element("Foodstuff").Elements("Product").OrderBy(item => item.Element("NameOfProduct").Value);

            foreach (XElement xElement in result3)
            {
                XElement nameOfProduct = xElement.Element("NameOfProduct");
                XElement Calories = xElement.Element("Calories");
                if (nameOfProduct != null && Calories != null)
                {
                    Console.WriteLine($"Name of product: {nameOfProduct.Value}");
                    Console.WriteLine($"Calories of product: {Calories.Value}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("7)Список блюд в меню, отсортированных по цене по убыванию:");
            Console.WriteLine();
            var result4 = Menu.Element("FullMenu").Elements("Menu").OrderByDescending(item => Convert.ToInt32(item.Element("Price").Value));

            foreach (XElement xElement in result4)
            {
                XElement Date = xElement.Element("Date");
                XElement Dish = xElement.Element("Dish");
                XElement Price = xElement.Element("Price");

                if (Date != null && Dish != null && Price != null)
                {
                    Console.WriteLine($"{Dish.Value} приготовлен {Date.Value}");
                    Console.WriteLine($"Цена: {Price.Value}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("8)Список блюд, в которых есть томат:");
            Console.WriteLine();
            var result5 = Dishes.Element("Dishes").Elements("Dish").Where(item => (item.Element("QuantityOfGramProduct1").Attribute("Product").Value == "Tomato"||
                                                                                  item.Element("QuantityOfGramProduct2").Attribute("Product").Value == "Tomato"||
                                                                                  item.Element("QuantityOfGramProduct3").Attribute("Product").Value == "Tomato"));

            foreach (XElement xElement in result5)
            {
                XElement Name = xElement.Element("Name");
                XElement QuantityProduct1 = xElement.Element("QuantityOfGramProduct1");
                XAttribute Product1 = xElement.Element("QuantityOfGramProduct1").Attribute("Product");
                XElement QuantityProduct2 = xElement.Element("QuantityOfGramProduct2");
                XAttribute Product2 = xElement.Element("QuantityOfGramProduct2").Attribute("Product");
                XElement QuantityProduct3 = xElement.Element("QuantityOfGramProduct3");
                XAttribute Product3 = xElement.Element("QuantityOfGramProduct3").Attribute("Product");


                if (Name != null && QuantityProduct1 != null && Product1 != null && QuantityProduct2 != null && Product2 != null && QuantityProduct3 != null && Product3 != null)
                {
                    Console.WriteLine($"Название блюда: {Name.Value}");
                    Console.WriteLine($"Местит: {Product1.Value} {QuantityProduct1.Value} грамм, {Product2.Value} {QuantityProduct2.Value} грамм, {Product3.Value} {QuantityProduct3.Value} грамм.");
                }
                Console.WriteLine();
            }

            Console.WriteLine("9)Сумма за все блюда в меню:");
            Console.WriteLine();
            var result6 = Menu.Element("FullMenu").Elements("Menu").Sum(item => Convert.ToInt32(item.Element("Price").Value));
            Console.WriteLine(result6 + " грн.");
            Console.WriteLine();

            Console.WriteLine("10)Максимальный и минимальный вес блюда в меню:");
            Console.WriteLine();
            var result7 = Dishes.Element("Dishes").Elements("Dish").Max(item => Convert.ToInt32(item.Element("QuantityOfGramProduct1").Value) +
                                                                                Convert.ToInt32(item.Element("QuantityOfGramProduct2").Value) +
                                                                                Convert.ToInt32(item.Element("QuantityOfGramProduct3").Value) );
            var result8 = Dishes.Element("Dishes").Elements("Dish").Min(item => Convert.ToInt32(item.Element("QuantityOfGramProduct1").Value) +
                                                                                Convert.ToInt32(item.Element("QuantityOfGramProduct2").Value) +
                                                                                Convert.ToInt32(item.Element("QuantityOfGramProduct3").Value));
            Console.WriteLine("Максимальный вес блюда:" + result7 +" грамм");
            Console.WriteLine("Минимальный вес блюда: " + result8 +" грамм" );
            Console.WriteLine();


            var result10 = from Mn in Menu.Element("FullMenu").Elements("Menu")
                           join Ds in Dishes.Element("Dishes").Elements("Dish") on Mn.Element("Dish").Value equals Ds.Element("Name").Value
                           select new
                           {
                               NameOfDish = Mn.Element("Dish").Value,
                               PriceOfDish = Mn.Element("Price").Value,
                               NameProduct1 = Ds.Element("QuantityOfGramProduct1").Attribute("Product").Value,
                               NameProduct2 = Ds.Element("QuantityOfGramProduct2").Attribute("Product").Value,
                               NameProduct3 = Ds.Element("QuantityOfGramProduct3").Attribute("Product").Value
                           };
            foreach (var item in result10)
                Console.WriteLine(item.NameOfDish + " По цене " + item.PriceOfDish + " грн."  + " состоит из " + item.NameProduct1 + ", " + item.NameProduct2 + ", " + item.NameProduct3);
        }
    }
}
