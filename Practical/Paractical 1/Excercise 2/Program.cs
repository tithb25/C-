using System;

namespace Excercise_3
{
    class Program
    {
        private static int GiaiThua(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * GiaiThua(n - 1);
        }
        static void Main(string[] args)
        {
            int n1 = 1, num, i1 = 1;
            Console.Write("Nhap so nguyen n: ");
            num = Convert.ToInt32(Console.ReadLine());

            //for
            for (i1 = 1; i1 <= num; i1++)
            {
                n1 *= i1;
            }
            Console.WriteLine("Giai thua cua {0} la: {1}", num, n1);

            //while
            int n2 = 1, i2 = 1;
            while (i2 <= num)
            {
                n2 *= i2;
                i2++;
            }
            Console.WriteLine("Giai thua cua {0} la: {1}", num, n2);

            //do_while
            int n3 = 1, i3 = 1;
            do
            {
                n3 *= i3;
                i3++;
            } while (i3 <= num);
            Console.WriteLine("Giai thua cua {0} la: {1}", num, n3);

            //recurision
            int result = GiaiThua(num);
            Console.WriteLine("Giai thua cua {0} la: {1}", num, result);
        }
    }
}
