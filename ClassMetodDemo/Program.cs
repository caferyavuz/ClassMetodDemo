using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Recep Cafer";
            musteri1.Soyad = "Yavuz";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Anıl";
            musteri2.Soyad = "Öztürk";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Mehmet";
            musteri3.Soyad = "Can";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

            musteriManager.MusteriSil(musteri2);

            musteriManager.MusteriListele();
        }
    }
}
