using System;

namespace cau18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so thu 1:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so thu 2:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiem tra co 1 so am va 1 so duong:");
            if((x < 0 && y > 0) || (x > 0 && y < 0))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
