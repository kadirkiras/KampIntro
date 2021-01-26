using System;
using System.Net.WebSockets;

namespace Metotlar
{
    public class SepetMenager
    {
        // naming convertion
        // syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urun.Adi);
        }
        
        //Tavsiye edilmeyen yontem
        public void Ekle2(string urunAdi, string urunAciklama, double fiyat, int StokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urunAdi);
        }
        
        
        
    }
}