using System;

namespace cau24
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);
        }
    }
}
