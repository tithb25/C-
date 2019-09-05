using System;

namespace cau27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
