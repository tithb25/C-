using System;

namespace cau10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("Nhap x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Nhap z: ");
            z = int.Parse(Console.ReadLine());

            double result1, result2;
            result1 = (x + y) * z;
            result2 = x * y + y * z;
            Console.WriteLine("Ket qua cua (x + y) .z la: {0} va xy + yz la: {1}", result1, result2);
        }
    }
}
