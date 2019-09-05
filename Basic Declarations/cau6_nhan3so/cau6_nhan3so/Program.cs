using System;

namespace cau6_nhan3so
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Input the first number to multiply: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("Expected Output: ");
            int result = num1 * num2 * num3;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}",
                                    num1, num2, num3, result);
        }
    }
}
