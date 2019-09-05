using System;

namespace cau19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumTriple(2, 2));
            Console.WriteLine(SumTriple(12, 10));
            Console.WriteLine(SumTriple(-5, 2));
        }
        public static int SumTriple(int a, int b)
        {
            if(a == b)
            {
                return (a + b) * 3;
            }
            else
            {
                return a + b;
            }
        }
    }
}
