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
        public string Name { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"Category: {Name}";
        }
        public Category(string name)
        {
            Name = name;
        }
    }
}
