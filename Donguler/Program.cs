using System;
using System.ComponentModel.DataAnnotations;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştiricisi Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            // array - dizi
            
            string[] kurslar = new string[]
            {
                "Yazılım Geliştiricisi Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs", 
                "Java",
                "Python"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);   
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            
            Console.WriteLine("Dongu Sonu - Footer");
        }
    }
}