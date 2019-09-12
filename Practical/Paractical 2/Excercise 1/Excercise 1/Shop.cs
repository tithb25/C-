using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise_1
{
    class Shop
    {
        private List<Product> ProductsList;

        internal List<Product> ProductsList1 { get => ProductsList; set => ProductsList = value; }

        public Shop()
        {
            ProductsList1 = new List<Product>();
        }

        public void AddProduct()
        {
            Product product = new Product();
            Console.Write("Nhap ten sp: ");
            product.Name1 = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap mo ta sp: ");
            product.Description1 = Convert.ToString(Console.ReadLine());
            //Console.Write("Nhap gia sp: ");
            //product.Price1 = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Nhap gia sp: ");
                product.Price1 = Convert.ToInt32(Console.ReadLine());
            } while (product.Price1 < 0 || product.Price1 > 100);
            ProductsList1.Add(product);
        }
        public void RemoveProduct()
        {
            Console.Write("Nhap ten sp can xoa: ");
            string name = Convert.ToString(Console.ReadLine());
            int check = 0;
            foreach (var item1 in ProductsList1)
            {
                if (name == item1.Name1)
                {
                    ProductsList1.Remove(item1);
                    check++;
                    break;
                }
                else
                {
                    Console.WriteLine("Nhap sai sp. Nhap lai: ");
                    name = Console.ReadLine();
                }
            }
        }

        public void IterateProductList()
        {
            foreach (var item2 in ProductsList1)
            {
                item2.ViewInfo();
            }
        }

        public void SearchProduct()
        {
            Console.WriteLine("Nhap sp can tim: ");
            string seachname = Convert.ToString(Console.ReadLine());
            int count = 0;
            foreach (var item3 in ProductsList1)
            {
                if (seachname == item3.Name1)
                {
                    item3.ViewInfo();
                    count++;
                    break;
                }
                else
                {
                    Console.WriteLine("Nhap sai sp. Nhap lai: ");
                    seachname = Convert.ToString(Console.ReadLine());
                }
            }
        }
    }
}
