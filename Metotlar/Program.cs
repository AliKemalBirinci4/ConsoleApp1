using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2 };


            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------");

            }
            Console.WriteLine("------Metotlar-------");
            //instance - örnek
            //encapsulation

            SepetManager sepetmanager =  new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
            //i did repeat myself - i should not, thats why we are using classes
            sepetmanager.Ekle2("Elma", "Yeşil Elma",11,45);
            sepetmanager.Ekle2("Armut", "Yeşil Armut", 24,55);
            sepetmanager.Ekle2("Muz", "Yeşil Muz", 15,65);
        }
    }
}
