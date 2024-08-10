using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Company
    {
        private Dictionary<Product, int> inventory = new Dictionary<Product, int>();

        public void AddProduct(Product product, int quantity)
        {
            if (inventory.ContainsKey(product))
                inventory[product] += quantity;
            else
                inventory[product] = quantity;
        }

        public void SellProduct(Product product, int quantity)
        {
            if (inventory.ContainsKey(product))
            {
                inventory[product] -= quantity;
                if (inventory[product] < 5)
                {
                    NotifySupplier(product);
                }
            }
            else
            {
                Console.WriteLine("Product not available.");
            }
        }

        private void NotifySupplier(Product product)
        {
            Console.WriteLine($"Notify supplier: Low stock for {product.Name}");
        }
    }

}
