using System;

namespace cau8_cuuChuong
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, result;
            Console.Write("Enter the number: ");
            num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                result = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, result);
            }
        }
    }
}
