using System;

namespace cau15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(remove_char("w3resource", 1));
            //Console.WriteLine(remove_char("w3resource", 9));
            //Console.WriteLine(remove_char("w3resource", 0));
        }
        public static string remove_char(string str, int n)
        {
            Console.Write("Nhap vi tri xoa: ");
            n = int.Parse(Console.ReadLine());
            return str.Remove(n, 1);
        }
    }
}
