using System;

namespace Excercise_1
{
    class Program
    {
        private static void Menu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1.AddProduct");
            Console.WriteLine("2.RemoveProduct");
            Console.WriteLine("3.IterateProductList");
            Console.WriteLine("4.SearchProduct");
            Console.WriteLine("5.Exit");
            Console.Write("Your choice: ");
        }

        static void Main(string[] args)
        {
            Shop myShop = new Shop();
            int choice = 0;

            do
            {
                Menu();
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        myShop.AddProduct();
                        break;

                    case 2:
                        myShop.RemoveProduct();
                        break;

                    case 3:
                        myShop.IterateProductList();
                        break;

                    case 4:
                        myShop.SearchProduct();
                        break;

                    case 5:
                        Console.WriteLine("Ban da thoat chuong trinh");
                        break;

                    default:
                        Console.WriteLine("Khong hop le !");
                        break;
                }

            } while (choice != 5);
        }
    }
}
