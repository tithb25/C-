using System;
using System.Collections.Generic;
using System.Text;

namespace Excercise2
{
    class Animal
    {
        private string name;
        private int age;
        private string description;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Description { get => description; set => description = value; }

        public void ViewInfo()
        {
            Console.WriteLine("Name animal: {0}", Name);
            Console.WriteLine("Age animal: {0}", Age);
            Console.WriteLine("Description animal: {0}", Description);
        }

        public void Speak()
        {

        }

        public  void Prarameter(int n)
        {
            n = Int32.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    

            }
        }
    }
}
