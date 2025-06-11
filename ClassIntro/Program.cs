using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 68;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Java";
            kurs3.egitmen = "Emir Altan";
            kurs3.izlenmeOrani = 55;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Python";
            kurs2.egitmen = "Erkan Alkan";
            kurs2.izlenmeOrani = 89;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.egitmen +" : "+ kurs.kursAdi);
            }
            Console.ReadLine();
            //Console.WriteLine(kurs1.kursAdi + " " + kurs1.egitmen);

        }
    }
    class Kurs
    {
        public string kursAdi { get; set; }
        public int izlenmeOrani { get; set; }
        public string egitmen { get; set; }
    }



}
