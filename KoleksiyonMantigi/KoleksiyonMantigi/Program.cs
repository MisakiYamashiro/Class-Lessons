using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoleksiyonMantigi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama
            //Koleksiyon Aslında dizi(Array) olmayan ancak dizi işlemlerinde kolaylık sağlamak amacıyla geliştirilen sistemlerdir.
            //Biz de koleksiyon mantığını manuel olarak oluşturalım.
            #endregion

            #region Kullanım
            //SayisalKoleksiyon dizi = new SayisalKoleksiyon();
            //dizi.DiziYarat();

            //dizi.Ekle(7);
            //dizi.Ekle(5);
            //dizi.Ekle(4);
            //dizi.Ekle(2);
            //dizi.Ekle(100);
            //dizi.Ekle(10);

            //dizi.TumunuYazdir();
            //Console.WriteLine("Dizi Eleman Sayısı = " + dizi.ElemanSayiGetir());

            //dizi.ElemanYazdir(4);

            //MetinselKoleksiyon urun1 = new MetinselKoleksiyon
            //{
            //    Isim = "Galaxy S23",
            //    Marka = "Samsung",
            //    Kategori = "Akıllı Telefon",
            //    Fiyat = 44000.50
            //};

            //MetinselKoleksiyon urun2 = new MetinselKoleksiyon
            //{
            //    Isim = "MacBook Air M2",
            //    Marka = "Apple",
            //    Kategori = "Dizüstü Bilgisayar",
            //    Fiyat = 59999.99
            //};

            //MetinselKoleksiyon urun3 = new MetinselKoleksiyon
            //{
            //    Isim = "AirPods Pro",
            //    Marka = "Apple",
            //    Kategori = "Kulaklık",
            //    Fiyat = 11999.99
            //};

            //MetinselKoleksiyon urun4 = new MetinselKoleksiyon
            //{
            //    Isim = "PlayStation 5",
            //    Marka = "Sony",
            //    Kategori = "Oyun Konsolu",
            //    Fiyat = 39999.99
            //};

            //MetinselKoleksiyon urun5 = new MetinselKoleksiyon
            //{
            //    Isim = "XBOX Series X",
            //    Marka = "Microsoft",
            //    Kategori = "Oyun Konsolu",
            //    Fiyat = 39999.99
            //};

            //urun1.Ekle(urun1);
            //urun1.Ekle(urun2);
            //urun1.Listele();

            // YOL 1 
            MetinselKoleksiyon u = new MetinselKoleksiyon();
            u.Isim = "Air Jordan Mid SE";
            u.Marka = "Nike";
            u.Kategori = "Ayakkabı";
            u.Fiyat = 10000;

            u.Ekle(u);

            //YOL 2 
            u.Ekle(new MetinselKoleksiyon()
            {
                Marka = "Adadas",
                Isim = "Beşiktaş XL Forma",
                Kategori = "Giyim",
                Fiyat = 4500
            });

            //u.Listele();

            //Console.WriteLine("Lütfen Ürün No Giriniz : ");
            //int no = Convert.ToInt32(Console.ReadLine());
            //MetinselKoleksiyon secilen = u.Getir(no);
            //Console.WriteLine("Seçilen Ürün s" + secilen.Marka+" "+secilen.Isim);
            // YOL 3 
            u.Ekle("Macbook M2", "Apple", "Teknoloji", 49999.99);
            u.Listele();

            #endregion
        }
    }
}
