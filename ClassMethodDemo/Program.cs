using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Musteri> musteriler = new List<Musteri>();

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Colak";
            musteri1.DogumYili = 1992;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Mehmet";
            musteri2.Soyadi = "Yildirim";
            musteri2.DogumYili = 1970;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Hasan";
            musteri3.Soyadi = "Yilmaz";
            musteri3.DogumYili = 1980;

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);

            musteriManager.MusteriCikar(musteri3);

            musteriler.Add(musteri1);
            musteriler.Add(musteri2);

            musteriManager.Listele(musteriler.ToArray());
        }
    }

    class Musteri
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int DogumYili { get; set; }
    }

    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " Müşteri Listesine Eklendi");
        }
        public void MusteriCikar(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " Müşteri Listesinden Çıkarıldı");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi + " " + musteri.Soyadi);
            }
        }
    }
}
