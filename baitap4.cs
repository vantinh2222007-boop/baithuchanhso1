

using System;
using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Tên SP: ");
            string name = Console.ReadLine();

            Console.Write("Giá SP: ");
            double price = double.Parse(Console.ReadLine());

            products.Add(new Product
            {
                Name = name,
                Price = price
            });
        }

        Console.WriteLine("\nDanh sách sản phẩm:");

        foreach (var p in products)
        {
            Console.WriteLine($"{p.Name} - {p.Price:C}");
        }
    }
}
