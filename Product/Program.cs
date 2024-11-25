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
            list.Add(new Product("Pen", 5, office, 10));
            list.Add(new Product("Motherboard", 50000, computerParts, 50));
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            // list.Add(new Product("Huge Book", -100));
            // list.Add(new Product("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee", 100, home));
            // list.Add(new Product("CPU", 1000000, computerParts, 200));
            Console.ReadKey();
        }
    }
    class Product
    {
        int price;
        string name;
        // The discount is in percentage 
        int discount;
        public Product(string name, int price, Category category, int discount=0)
        {
            this.Name = name;
            // The price is in HUF!
            this.Price = price;
            Category = category;
            this.Discount = discount;
        }
        public int Price
        {
            get
            {
                return price * (100 - discount) / 100;
            }
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
        public int Discount
        {
            get { return discount; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    discount = value;
                }
                else
                {
                    throw new Exception("Discount must be between 0 and 100.");
                }
            }
        }
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
                    throw new Exception($"Invalid value ({value}) for product name. It cannot be null or empty or longer than 32 characters.");
                }
            }
        }
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
