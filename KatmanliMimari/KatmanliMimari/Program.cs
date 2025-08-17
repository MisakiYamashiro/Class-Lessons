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
            #region Kategori Ekle


            //Kategori kat = new Kategori();
            //kat.Isim = "Kaloriferler";
            //kat.Aciklama = "Sıcak su ile ısıtılan demir.";

            //if (islem.KategoriIsimKontrol(kat.Isim))
            //{
            //    if (islem.KategoriEkle(kat))
            //    {
            //        Console.WriteLine("Ekleme Başarılı");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ekleme Başarısız");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Bu kategori daha önce eklenmiş!!!");
            //}

            #endregion
            #region Ürün Listele
            List<Urun> urunler = islem.UrunListele();
            foreach (Urun item in urunler)
            {

                Console.WriteLine($"ID == {item.UrunID}");
                Console.WriteLine($"İsim = {item.UrunAdi}");
                Console.WriteLine($"Fiyat = {item.Fiyat}");
                Console.WriteLine($"Kategori = {item.Kategori}");
                Console.WriteLine($"Tedarikçi = {item.Tedarikci}");
                Console.WriteLine("\n");
            }
            #endregion
            #region SatistaMi == True
            //List<Urun> urunler = islem.UrunListele();
            //foreach (Urun item in urunler)
            //{
            //    if (item.SatistaMi == true)
            //    {
            //            Console.WriteLine($"ID == {item.UrunID}");
            //            Console.WriteLine($"İsim = {item.UrunAdi}");
            //            Console.WriteLine($"Fiyat = {item.Fiyat}");
            //            Console.WriteLine($"Kategori = {item.Kategori}");
            //            Console.WriteLine($"Tedarikçi = {item.Tedarikci}");
            //            Console.WriteLine("\n");
            //    }
            //}
            #endregion
            #region Ürün Listele Overload
            //List<Urun> urunler = islem.UrunListele(true);
            //foreach (Urun item in urunler)
            //{
            //    Console.WriteLine($"## ID = {item.UrunID} ##");
            //    Console.WriteLine($"İsim = {item.UrunAdi}");
            //    Console.WriteLine($"Fiyat = {item.Fiyat}");
            //    Console.WriteLine($"Kategori = {item.Kategori}");
            //    Console.WriteLine($"Tedarikçi = {item.Tedarikci}");
            //    Console.WriteLine("\n");
            //}
            #endregion
            #region Ürün Ekle
            //Urun u = new Urun();
            //u.UrunAdi = "Palamut Lakerda";
            //u.TedarikciID = 5;
            //u.KategoriID = 8;
            //u.Fiyat = 450;
            //u.Stok = 100;
            //u.GuvenlikStok = 10;
            //u.SatistaMi = false;

            //if (islem.UrunEkle(u))
            //{
            //    Console.WriteLine("BAŞARDIM");
            //}
            #endregion

        }
    }
}
