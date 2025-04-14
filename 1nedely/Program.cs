using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1nedely
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string GetInfo() 
        {
            return $"Название: {Name}, Цена: {Price}";
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(GetInfo());
        }
    }


    public class Electronics : Product
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Electronics(string name, double price, string brand, string model) : base(name, price) 
        {
            Brand = brand;
            Model = model;
        }

        public override string GetInfo() 
        {
            return $"{base.GetInfo()}, Бренд: {Brand}, Модель: {Model}";
        }

        public override void PrintInfo() 
        {
            Console.WriteLine(GetInfo());
        }
    }


    public class Store
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void PrintAllProducts()
        {
            foreach (var product in Products)
            {
                product.PrintInfo();
                Console.WriteLine("---"); 
            }
        }
    }
    internal class Program
    { 
        static void Main(string[] args)
        {

            Store store = new Store();


            Product laptop = new Product("Ноутбук", 34000.00);
            Electronics phone = new Electronics("Смартфон", 76000.00, "Samsung", "Galaxy S23");

            store.AddProduct(laptop);
            store.AddProduct(phone);

            Console.WriteLine("Товары в магазине:");
            store.PrintAllProducts();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
