using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
     class Class1
    {
        public void Topla(int sayi1,  int sayi2)
        {
          int  toplam = sayi1 + sayi2;
        }
        public void Cıkarma(int sayi1, int sayi2)
        {
            int cıkarma = sayi1 - sayi2;
        }
        public void Bolme(int sayi1, int sayi2)
        {
            int bolme = sayi1 / sayi2;
        }
        public void Carpma(int sayi1, int sayi2)
        {
            int toplam = sayi1 * sayi2;
            Console.WriteLine("Toplam Sonuç = " + toplam);
        }

        public string Isım { get; set; }
        public string Soyad { get; set; }

        public int Age { get; set; }
    }
}
