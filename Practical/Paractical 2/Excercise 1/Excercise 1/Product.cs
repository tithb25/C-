using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise_1
{
    class Product
    {
        private string Name;
        private string Description;
        private double Price;
        private int[] rate;

        public string Name1 { get => Name; set => Name = value; }
        public string Description1 { get => Description; set => Description = value; }
        public double Price1 { get => Price; set => Price = value; }
        public int[] Rate { get => rate; set => rate = value; }

        public Product()
        {

        }

        public Product(string name, string description, double price)
        {
            Name1 = name;
            Description1 = description;
            Price1 = price;
        }

        public void ViewInfo()
        {
            Console.WriteLine("Ten sp: {0}", Name1);
            Console.WriteLine("Mo ta sp: {0}", Description1);
            Console.WriteLine("Gia sp: {0}", Price1);
        }
    }
}
