using System;

namespace cau14
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius;

            Console.Write("Nhap do C: ");
            celsius = int.Parse(Console.ReadLine());
            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
        }
    }
}
