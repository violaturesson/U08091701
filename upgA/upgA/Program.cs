using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upgA
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of products
            List<Product> products = new List<Product>();
            products.Add(new Product() {Name="Svart bil", Price=100 });
            products.Add(new Product() { Name = "Blå bil", Price = 200 });
            products.Add(new Product() { Name = "Grå bil", Price = 150 });
            products.Add(new Product() { Name = "Röd bil", Price = 120 });
            products.Add(new Product() { Name = "Silver bil", Price = 170 });

            //Write
            Console.WriteLine(string.Format("Det finns {0} produkter i listan", products.Count));

            //Write on same line
            for (int i = 0; i < (products.Count-1); i++)
            {
                Product p = (Product)products[i];
                Console.Write(string.Format("{0} | ", p.Name));
            }
            Product q = (Product)products[products.Count - 1];
            Console.Write(q.Name);
            Console.WriteLine();

            //Max
            List<Product> sorted;
            sorted = products.OrderByDescending(s => s.Price).ToList();
            Console.WriteLine(string.Format("Den dyraste produkten är {0}, och kostar {1}",sorted[0].Name, sorted[0].Price));

            //Average
            Console.WriteLine(string.Format("Snittpriset är {0} kr.", products.Average(s=>s.Price)));
        }
    }
}
