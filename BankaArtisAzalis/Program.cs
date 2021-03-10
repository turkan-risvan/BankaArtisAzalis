using System;

namespace BankaArtisAzalis
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety=tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;

            double dolarDun = 3.33;
            double dolarBugun = 3.34;

            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Azalış Butonu");

            }
            else
            {
                Console.WriteLine("değişmez Butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);
        }
    }
}
