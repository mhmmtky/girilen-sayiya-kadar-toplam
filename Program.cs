using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayiToplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i = 0; i<=sayi; i++)
            {
                toplam = toplam + i;
            }
            Console.WriteLine(toplam);
            Console.ReadKey();
        }
    }
}
