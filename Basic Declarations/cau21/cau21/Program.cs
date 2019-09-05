using System;

namespace cau21
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Nhap 1 so: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap 1 so: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x + y = {0}", (x + y));
            if(x == 20 || y == 20 || (x + y == 20))
            {
                Console.WriteLine(true);
            }
        }
    }
}
