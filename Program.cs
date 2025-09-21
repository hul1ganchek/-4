using System;
using System.Collections.Generic;

namespace Divan
{
    class Furniture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public Furniture(int id, string name, decimal price, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

        public void Info()
        {
            Console.WriteLine($"{Id}. {Name} ({Category}) - {Price} руб.");
        }
    }

    class Store
    {
        public List<Furniture> Products = new List<Furniture>();

        public void ShowCatalog()
        {
            Console.WriteLine("\nКаталог мебели Divan:");
            foreach (var item in Products)
                item.Info();
        }
    }

    class Cart
    {
        public List<Furniture> Items = new List<Furniture>();

        public void Show()
        {
            Console.WriteLine("\nКорзина:");
            if (Items.Count == 0)
                Console.WriteLine("Корзина пуста.");
            else
                foreach (var item in Items)
                    item.Info();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Store divan = new Store();
            divan.Products.Add(new Furniture(1, "Диван Милан", 25990, "Диваны"));
            divan.Products.Add(new Furniture(2, "Стол дубовый", 14990, "Столы"));
            divan.Products.Add(new Furniture(3, "Кресло Комфорт", 10990, "Кресла"));

            Cart cart = new Cart();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n=== Мебельный центр DIVAN ===");
                Console.WriteLine("1. Показать каталог");
                Console.WriteLine("2. Показать корзину");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите действие: ");

                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        divan.ShowCatalog();
                        break;
                    case "2":
                        cart.Show();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                }
            }

            Console.WriteLine("\nСпасибо за посещение Divan!");
            Console.WriteLine("Нажмите любую клавишу, чтобы выйти...");
            Console.ReadKey();
        }
    }
}
