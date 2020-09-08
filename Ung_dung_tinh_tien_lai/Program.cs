using System;

namespace Ung_dung_tinh_tien_lai
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 1.0;
            int month = 1;
            double intersetRate = 1.0;

            Console.WriteLine("So tien gui: ");
            money = Double.Parse(Console.ReadLine());
            Console.WriteLine("So thang gui: ");
            month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("So lai suat: ");
            intersetRate = Double.Parse(Console.ReadLine());

            double totalInterset = 0;
            for (int i = 0; i < month; i++)
            {
                totalInterset = money * (intersetRate / 100) / 12 * 3;
            }
            Console.WriteLine("Tong tien lai: " + totalInterset);
        }
    }
}
