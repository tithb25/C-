using System;

namespace cau12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Nhap 1 so: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
        }
    }
}
