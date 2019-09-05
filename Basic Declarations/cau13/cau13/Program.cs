using System;

namespace cau13
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter a digit: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0}{0}{0}", num);
        }
    }
}
