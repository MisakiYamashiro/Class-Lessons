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
            //List<Urun> urunler = islem.UrunListele();
            //foreach (Urun item in urunler)
            //{

            //    Console.WriteLine($"ID == {item.UrunID}");
            //    Console.WriteLine($"İsim = {item.UrunAdi}");
            //    Console.WriteLine($"Fiyat = {item.Fiyat}");
            //    Console.WriteLine($"Kategori = {item.Kategori}");
            //    Console.WriteLine($"Tedarikçi = {item.Tedarikci}");
            //    Console.WriteLine("\n");
            //}
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
            #region Ürün Sil
            //if (islem.UrunSil(78))
            //{
            //    Console.WriteLine("Silme işlemi başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("yok");
            //}
            #endregion
            #region Ürün Düzenle
            //Urun urunsel = new Urun();
            //urunsel.UrunAdi = "Axolotl Meat";
            //urunsel.TedarikciID = 4;
            //urunsel.KategoriID = 8;
            //urunsel.Fiyat = 20000;
            //urunsel.Stok = 25;
            //urunsel.GuvenlikStok = 5;
            //urunsel.SatistaMi = false;
            //if (islem.UrunDuzenle(urunsel, 1078))
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
            #endregion
            #region Sipariş Listele
            List<Siparisler> siparisler = islem.SiparisleriListele();
            foreach (Siparisler item in siparisler)
            {
                Console.WriteLine("OrderID: " + item.OrderID);
                Console.WriteLine("ProductID: " + item.ProductID);
                Console.WriteLine("ProductName: " + item.ProductName);
                Console.WriteLine("UnitPrice: " + item.UnitPrice);
                Console.WriteLine("OrderDate: " + item.OrderDate);
                Console.WriteLine("RequiredDate: " + item.RequiredDate);
                Console.WriteLine("ShippedDate: " + item.ShippedDate);
                Console.WriteLine("ShipVia: " + item.ShipVia_SupplierID);
                Console.WriteLine("CompanyName: " + item.CompanyName);
                Console.WriteLine("Freight: " + item.Freight);
                Console.WriteLine("ShipName: " + item.ShipName);
                Console.WriteLine("ShipAddress: " + item.ShipAddress);
                Console.WriteLine("ShipCity: " + item.ShipCity);
                Console.WriteLine("ShipRegion: " + item.ShipRegion);
                Console.WriteLine("ShipPostalCode: " + item.ShipPostalCode);
                Console.WriteLine("ShipCountry: " + item.ShipCountry);
                Console.WriteLine("CustomerID: " + item.CustomerID);
                Console.WriteLine("ContactName: " + item.ContactName);
                Console.WriteLine("ContactTitle: " + item.ContactTitle);
                Console.WriteLine("Phone: " + item.Phone);
                Console.WriteLine("EmployeeID: " + item.EmployeeID);
                Console.WriteLine("Employee: " + item.TitleOfCourtesy + " " + item.FirstName + " " + item.LastName);
                Console.WriteLine("Title: " + item.Title);
                Console.WriteLine("HomePhone: " + item.HomePhone);
                Console.WriteLine("\n\n");
            }
            #endregion

        }
    }
}
