using System;

namespace Exetcise4
{
    class Program
    {
        public Program() { }

        public void Sum()
        {
            int num1, num2;

            Console.Write("Nhap so thu 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Nhap so thu 2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Result = " + (num1 + num2));
        }

        public void Subtract()
        {
            int num1, num2;

            Console.Write("Nhap so thu 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Nhap so thu 2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Result = " + (num1 - num2));
        }

        private static void Menu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1.Phep cong");
            Console.WriteLine("2.Phep tru");
            Console.WriteLine("3.Thoat");
            Console.Write("Your choice: ");
        }


        static void Main(string[] args)
        {
            Program prg = new Program();
            int choice = 0;

            do
            {
                Menu();
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        prg.Sum();
                        break;

                    case 2:
                        prg.Subtract();
                        break;

                    case 3:
                        Console.WriteLine("Ban da thoat chuong trinh");
                        break;

                    default:
                        Console.WriteLine("Khong hop le !");
                        break;
                }

            } while (choice != 3);
        }

    }
}
