using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace KatmanliMimari
{
    internal class Program
    {
        static void Main(string[] args)
        {


            IslemSinifi islem = new IslemSinifi();

            Kategori kat = new Kategori();
            kat.Isim = "Kaloriferler";
            kat.Aciklama = "Sıcak su ile ısıtılan demir.";

            if (islem.KategoriIsimKontrol(kat.Isim))
            {
                if (islem.KategoriEkle(kat))
                {
                    Console.WriteLine("Ekleme Başarılı");
                }
                else
                {
                    Console.WriteLine("Ekleme Başarısız");
                }
            }
            else
            {
                Console.WriteLine("Bu kategori daha önce eklenmiş!!!");
            }




        }
    }
}
