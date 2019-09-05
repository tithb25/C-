using System;

namespace cau5_hoandoiso
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, count;
            Console.Write("\nInput the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            count = num1;
            num1 = num2;
            num2 = count;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            Console.Read();
        }
    }
}
