using System;

namespace DegrVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            Console.WriteLine(sayi2);
            sayi1 = sayi2;
            sayi2 = 65;

            
            Console.WriteLine(sayi2);
            
            //Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] {10, 20, 30};
            int[] sayilar2 = new int[] {100, 200, 300};
            sayilar1 = sayilar2;
            Console.WriteLine(sayilar2[0]);
            sayilar2[0] = 999;

            Console.WriteLine(sayilar2[0]);

            //int, decimal,float, double, bool(0,1) = değer tip
            //array, class, interface = referans tip
            //stack : değer tip olanların hepsi burada gerçekleşir.
            //heap  : new - bellekte yeni bir adres oluştur demek.
        }
    }
}