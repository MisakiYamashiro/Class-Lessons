using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenerikKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList koleksiyonunun Jenerik karşılığıdır.

            //JenerikKoleksiyon<string> koleksiyon = new JenerikKoleksiyon<string>();
            //koleksiyon.Ekle("Merhaba");
            //koleksiyon.Ekle("Dünya");

            //JenerikKoleksiyon<Insan> insanlar = new JenerikKoleksiyon<Insan>();

            //insanlar.Ekle(new Insan { Ad = "Ahmet", Soyad = "Yılmaz", Yas = 30 });
            #endregion

            #region List
            List<int> sayilar = new List<int>();
            sayilar.Add(10);
            sayilar.Add(20);
            sayilar.Add(30);
            sayilar.Add(-40);
            //sayilar.Add(50.2);

            sayilar.Insert(2, 25); // 2. indekse 25 ekler
            int[] ss = { -4, 88, 231, 82 };
            sayilar.AddRange(ss);

            sayilar.Remove(-4); // Elemanı siler
            sayilar.RemoveAt(0); // 0. indeksteki elemanı siler
            sayilar.RemoveRange(2, 2); 
            sayilar.TrimExcess(); // Listedeki nulları siler
            Console.WriteLine("Eleman Sayısı " + sayilar.Count);
            Console.WriteLine("Kapasite " + sayilar.Capacity);
            Console.WriteLine("Ortalama " + sayilar.Average());



            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.WriteLine("-------");
            sayilar.Sort();
            sayilar.Reverse();
            Console.WriteLine("En Büyük Eleman : " + sayilar.Max());
            
            Console.WriteLine("En Küçük Eleman : " + sayilar.Min());

            Console.WriteLine("Ortalama " + sayilar.Average());

            Console.WriteLine("Var Mı " + sayilar.Contains(30)); //True False Döndürür

            Console.WriteLine("Kaçıncı İndex te " + sayilar.IndexOf(88)); //Bulamazsa -1 döndürür
            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            #endregion

            #region Ödev
            // En az 25 adet kitap olucak

            //1-Türe Göre
            //2- Yayınevine Göre
            //3- İsme göre(3 karakter yeterli)
            //4- Tümü
            //5- Kiradakileri listele.

            //1,2,3,4'te kiradakiler listelenmeyecek!!

            //Kitap seçilip kiralanabilecek.
            //Sistemden çık diyene kadar devam edecek

            //Araba kiralama sistemi yakıt türü vites araç türüne göre OPSİYONEL
            
            #endregion
        }
    }
    public class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        

    }
}
