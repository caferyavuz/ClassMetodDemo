using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    public class MusteriManager
    {
        List<Musteri> musteriler;
        public MusteriManager()
        {
            musteriler = new List<Musteri>();
        }
        public void MusteriEkle(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine($"{musteri.Ad} {musteri.Soyad} isimli müşteri eklendi.");
        }

        public void MusteriSil(Musteri musteri)
        {
            musteriler.Remove(musteri);
            Console.WriteLine($"{musteri.Ad} {musteri.Soyad} isimli müşteri silindi.");
        }

        public void MusteriListele()
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine($"{musteri.Id} - {musteri.Ad} - {musteri.Soyad}");
            }
        }
    }
}
