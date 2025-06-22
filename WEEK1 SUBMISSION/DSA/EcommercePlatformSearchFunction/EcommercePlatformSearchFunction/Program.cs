using System;
using System.Linq;

namespace ECommerceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product { ProductId = 1, ProductName = "Laptop", Category = "Electronics" },
                new Product { ProductId = 2, ProductName = "Shirt", Category = "Apparel" },
                new Product { ProductId = 3, ProductName = "Phone", Category = "Electronics" },
                new Product { ProductId = 4, ProductName = "Book", Category = "Education" }
            };

            Console.WriteLine("🔍 Linear Search for 'Phone':");
            var result1 = SearchAlgorithms.LinearSearch(products, "Phone");
            Console.WriteLine(result1 ?? "Product not found.");

            Console.WriteLine("\n🔍 Binary Search for 'Phone':");
            // Sort products by name before binary search
            var sortedProducts = products.OrderBy(p => p.ProductName).ToArray();
            var result2 = SearchAlgorithms.BinarySearch(sortedProducts, "Phone");
            Console.WriteLine(result2 ?? "Product not found.");

            Console.ReadLine();
        }
    }
}
