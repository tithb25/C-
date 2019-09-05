using System;

namespace cau20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(result(13, 40));
            Console.WriteLine(result(50, 21));
            Console.WriteLine(result(0, 23));
        }

        public static int result(int a, int b)
        {
            if (a > b)
            {
                return (a - b) * 2;
            }
            else
            {
                return b - a;
            }
        }
    }
}
