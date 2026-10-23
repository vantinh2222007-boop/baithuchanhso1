

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhập b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Tổng = {a + b}");
        Console.WriteLine($"Hiệu = {a - b}");
        Console.WriteLine($"Tích = {a * b}");

        if (b != 0)
        {
            Console.WriteLine($"Thương = {(double)a / b}");
        }
        else
        {
            Console.WriteLine("Không thể chia cho 0!");
        }
    }
}
