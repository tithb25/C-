using System;

namespace cau7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Input the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
        }
    }
}
