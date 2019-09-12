using System;

namespace Excercise1+2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ten: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap tuoi: ");
            int age = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Ban chua du 20 tuoi");
                Console.Write("Nhap tuoi: ");
                age = Convert.ToInt32(Console.ReadLine());
            } while (age < 20);
            Console.WriteLine("Hello {0} {1} tuoi", name, age);
        }
    }
}
