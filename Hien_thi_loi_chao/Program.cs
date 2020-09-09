using System;

namespace Hien_thi_loi_chao
{
    class Program
    {
        static void Hienthiloichao()
        {
            Console.WriteLine("Hay nhap ten:");
            string ten = Console.ReadLine();
            Console.WriteLine("Hello: {0}", ten);
        }
        static void Main(string[] args)
        {
            Hienthiloichao();
            Console.ReadKey();
        }
    }
}
