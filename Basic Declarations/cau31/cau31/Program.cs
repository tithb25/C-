﻿using System;

namespace cau31
{
    class Program
    {
        public static void Main()
        {
            int[] array1 = { 1, 3, -5, 4 };
            int[] array2 = { 1, 4, -5, -2 };

            Console.WriteLine("Array1: [{0}]", string.Join(", ", array1));
            Console.WriteLine("Array2: [{0}]", string.Join(", ", array2));

            Console.WriteLine("Multiply corresponding elements of two arrays: ");

            for (int i = 0; i < array1.Length; i++)
            {

                Console.Write(array1[i] * array2[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
