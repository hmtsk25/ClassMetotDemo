using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 103;
            musteri1.Ad = "Salih";
            musteri1.Soyad = "Kaplan";
            musteri1.Yas = 32;
            musteri1.HesapBakiyesi = 1_500;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 104;
            musteri2.Ad = "Buse";
            musteri2.Soyad = "Yıldız";
            musteri2.Yas = 27;
            musteri2.HesapBakiyesi = 3_500;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteriler);




            Console.Read();
        }
    }
}
