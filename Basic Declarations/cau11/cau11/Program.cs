using System;

namespace cau11
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Nhap tuoi cua ban: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Ban trong tre hon {0}", age);
        }
    }
}
