using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("{0} {1} isimli müşteri eklendi!",musteri.Ad,musteri.Soyad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("{0} {1} isimli müşteri silindi!", musteri.Ad, musteri.Soyad);
        }

        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("\nMÜŞTERİLER");
            Console.WriteLine("-----------\n");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine($"Müşteri adı soyadı: {musteri.Ad} {musteri.Soyad}, Yaşı: {musteri.Yas}, Kullanılabilir Hesap Bakiyesi: {musteri.HesapBakiyesi} TL ");
                Console.WriteLine(" -----------------------" );
            }
        }
    }
}
