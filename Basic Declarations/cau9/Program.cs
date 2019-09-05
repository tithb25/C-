using System;

namespace cau9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;

            Console.Write("Nhap so thu 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu 3: ");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu 4: ");
            num4 = int.Parse(Console.ReadLine());

            double result = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("Trung binh {0}, {1}, {2}, {3} la: {4}", num1, num2, num3, num4, result);
        }
    }
}
