﻿using System;

namespace So_ngay_trong_thang
{
    class Program
    {
        static int ngaythang(int t)
        {
            int m;
            if (t <= 1 || t <= 12)
            {
                switch (t)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine("Thang {0} co 31 ngay", t); break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine("Thang {0} co 30 ngay", t); break;
                    case 2:
                        Console.WriteLine("Moi nhap them nam: ");
                        m = int.Parse(Console.ReadLine());
                        if ((m % 4 == 0 && m % 100 != 0) || m % 400 == 0)
                            Console.WriteLine("Thang {0} co 29 ngay", t);
                        else Console.WriteLine("Thang {0} co 28 ngay", t); break;
                }
            }
            else Console.WriteLine("Khong ton tai thang nay");
            return 0;
        }
        static void Main(string[] args)
        {
            int t;
            Console.WriteLine("Hay nhap thang: ");
            t = int.Parse(Console.ReadLine());
            ngaythang(t);
        }
    }
}
