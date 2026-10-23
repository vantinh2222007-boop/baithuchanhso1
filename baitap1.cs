using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap ten cua ban: ");
        string ten = Console.ReadLine() ?? "";

        Console.WriteLine("Chao ban!");
        Console.WriteLine("Xin chao " + ten);
        Console.WriteLine("XIN CHAO MOI NGUOI!");
    }
}