using System;

namespace Dien_tich_HCN
{
    class Program
    {
        static float tinhdientich(float a, float b)
        {
            float dientich = a * b;
            Console.WriteLine("Dien tich HCN la: " + dientich);
            return dientich;
        }
        static void Main(string[] args)
        {
            Console.Write("\n");
            Console.Write("Tinh dien tich HCN:\n");
            Console.Write("\n\n");

            float cd;
            float cr;

            Console.Write("Nhap vao chieu dai HCN:\n ");
            cd = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao chieu rong HCN:\n ");
            cr = float.Parse(Console.ReadLine());
            tinhdientich(cd, cr);
        }
    }
}
