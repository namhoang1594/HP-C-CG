using System;

namespace Kiem_tra_so_nguyen_to
{
    class Program
    {
        static int ktsnt(int n)
        {
            int i, s = 0;
            for (i = 1; i <= n; i++)
                if (n % i == 0)
                    s++;

            if (s == 2)
                Console.WriteLine("So da cho la so nguyen to.");
            else
                Console.WriteLine("So da cho khong phai la so nguyen to.");
            return n;
        }
        static void Main(string[] args)
        {
            Console.Write("\n");
            Console.Write("Kiem tra n co phai la so nguyen to:\n");
            Console.Write("\n\n");
            int n;
            Console.Write("Hay nhap mot so n bat ky: ");
            n = Convert.ToInt32(Console.ReadLine());
            ktsnt(n);
            Console.ReadKey();
        }
    }
}
