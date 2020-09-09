using System;

namespace _20_so_nguyen_to
{
    class Program
    {
        static bool snt(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    s++;
            if (s == 2)
                return true;
            else
                return false;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n: ");
            int n, s = 0;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + " so nguyen to dau tien la: ");
            for (int i = 2; s < n; i++)
                if (snt(i) == true)
                {
                    Console.WriteLine("{0}", i);
                    s++;
                }
        }
    }
}

