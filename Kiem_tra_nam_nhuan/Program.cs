﻿using System; 

namespace Kiem_tra_nam_nhuan
{
    class Program
    {
        static int kt(int n)
        {
            if ((n % 4 == 0 && n % 100 != 0) || (n % 400 == 0))
            {
                Console.WriteLine("Nam " + n + " la nam nhuan \n");
            }
            else 
            { 
                Console.WriteLine("Nam " + n + " khong phai la nam nhuan"); 
            }
            return n;
        }
        static void Main(string[] args)
        {
            Console.Write("\n");
            Console.Write("Kiem tra nam nhuan:\n");
            Console.Write("\n\n");

            int n;

            Console.Write("Hay nhap mot so nam bat ky: ");
            n = Convert.ToInt32(Console.ReadLine());
            kt(n);
            Console.ReadKey();
        }
    }
}
