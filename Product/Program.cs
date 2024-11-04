using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category office = new Category("Office supplies");
            Category home = new Category("Home essentials");
            Category computerParts = new Category("Computer parts");
            
            // Category test = new Category("");
            // Category test2 = new Category("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");            

            List<Product> list = new List<Product>();
            list.Add(new Product("Toothbrush", 100, home));
            list.Add(new Product("Hairdryer", 500, home));
            list.Add(new Product("Pen", 5, office));
            list.Add(new Product("Motherboard", 50000, computerParts));
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            // list.Add(new Product("Huge Book", -100));
            Console.ReadKey();
        }
    }
    class Product
    {
        int price;
        public Product(string name, int price, Category category)
        {
            this.Name = name;
            // The price is in HUF!
            this.Price = price;
            Category = category;
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    throw new Exception("Price must be greater than zero.");
                }
            }
        }
        public string Name { get; set; }
        public Category Category
        {
            get; set;
        }
        public override string ToString()
        {
            return $"Product: {Name}, Price: {Price} Ft, {Category}";
        }
    }
    class Category
    {
        string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length <= 32)
                {
                    name = value;
                }
                else
                {
                    throw new Exception($"Invalid value ({value}) for category name. It cannot be null or empty or longer than 32 characters.");
                }
            }
        }
        public override string ToString()
        {
            return $"Category: {Name}";
        }
        public Category(string name)
        {
            this.name = name;
        }
    }
}
