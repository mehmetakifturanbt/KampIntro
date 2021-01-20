using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };


            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            //type-safe -- tip güvenli
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------------");
            }

            Console.WriteLine("--------------Metotlar--------------");

            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 8, 9);
            sepetManager.Ekle2("Karpuz", "İri Karpuz", 22, 8);


        }
    }
}


//Don't repeat yourself - DRY - Clean Code - Best Practice 