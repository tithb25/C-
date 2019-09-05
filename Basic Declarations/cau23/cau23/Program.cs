using System;

namespace cau23
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Nhap mot chuoi: ");
            str = Convert.ToString(Console.ReadLine());

            Console.WriteLine(str.ToLower());
        }
    }
}
