using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Ketegoriler";
            int igrenciSayisi = 32000;
            double  faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artıs Butonu");
            }
            else
            {
                Console.WriteLine("Esittir Butonu");
            }

            

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
    