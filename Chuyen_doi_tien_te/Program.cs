using System;

namespace Chuyen_doi_tien_te
{
    class Program
    {
        static int doitien(int tigia, int usd)
        {
            int vnd = tigia * usd;
            Console.WriteLine("VND chuyen doi la : {0} VND", vnd);
            return vnd;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ti gia tien:");
            int tigia = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap USD :");
            int usd = int.Parse(Console.ReadLine());
            doitien(tigia, usd);
        }
    }
}
