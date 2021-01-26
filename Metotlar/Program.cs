using System;
using System.Net.WebSockets;
using System.Reflection.Metadata;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string urunAdi = "Elma";
            //double fiyati = 15;
            //string aciklama = "Amasya elmasi";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Karpuz gibi karpuz";

            Urun urun3 = new Urun();
            urun3.Adi = "muz";
            urun3.Fiyati = 43;
            urun3.Aciklama = "test";

            Urun[] urunler = new Urun[] {urun1,urun2,urun3};
            
            
           
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("--------Metotlar--------");
            //instanse - örnek
            //encapsulation
            SepetMenager sepetMenager = new SepetMenager();
            sepetMenager.Ekle(urun1);
            sepetMenager.Ekle(urun2);
            
            sepetMenager.Ekle2("Armut","sari armut",15,1000);
            sepetMenager.Ekle2("Cilek","kirmizi armut",50,1000);
            sepetMenager.Ekle2("Muz","sari muz",60,1000);
           
        }
    }
}