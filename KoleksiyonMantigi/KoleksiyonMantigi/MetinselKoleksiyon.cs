using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace KoleksiyonMantigi
{
    internal class MetinselKoleksiyon
    {
        MetinselKoleksiyon[] veri;

        public string Isim;
        public string Marka;
        public string Kategori;
        public double Fiyat;
        
        /// <summary>
        /// Veri dizisini RAM üzerinde var eder.
        /// </summary>
        public MetinselKoleksiyon() // Constructor
        {
            veri = new MetinselKoleksiyon[0];
        }
        /// <summary>
        /// Oluşturulan dizinin içerisine veri kaybı olmadan parametreyi ekler.
        /// </summary>
        /// <param name="Nesne">Oluşturulmuş Nesne</param>
        public void Ekle(MetinselKoleksiyon Nesne)
        {
            MetinselKoleksiyon[] gecici = new MetinselKoleksiyon[veri.Length + 1];
            Array.Copy(veri, gecici, veri.Length);
            gecici[gecici.Length - 1] = Nesne;
            veri = gecici;
        }
        /// <summary>
        /// Yeni bir ürün oluşturur.
        /// </summary>
        /// <param name="isim">Ürünün ismi</param>
        /// <param name="marka">Ürünün markası</param>
        /// <param name="kategori">Ürünün kategorisi</param>
        /// <param name="fiyat">Ürünün fiyatı</param>
        public void Ekle(string isim, string marka, string kategori, double fiyat)
        {
            MetinselKoleksiyon u = new MetinselKoleksiyon();
            u.Isim = isim;
            u.Marka = marka;
            u.Kategori = kategori;
            u.Fiyat = fiyat;

            MetinselKoleksiyon[] gecici = new MetinselKoleksiyon[veri.Length + 1];
            Array.Copy(veri, gecici, veri.Length);
            gecici[gecici.Length - 1] = u;
            veri = gecici;
        }
        /// <summary>
        /// Dizinin kaç adet index numarası olduğunu söyler.
        /// </summary>
        /// <returns></returns>
        public int UrunSayi()
        {
            return veri.Length;
        }

        /// <summary>
        /// Oluşturulan veri dizisinin içindekileri listeler.
        /// </summary>
        public void Listele()
        {
            for (int i = 0; i < veri.Length; i++)
            {
                Console.WriteLine($"Isim: {veri[i].Isim}, Marka: {veri[i].Marka}, Kategori: {veri[i].Kategori}, Fiyat: {veri[i].Fiyat}");
            }
        }
        /// <summary>
        /// Oluşturulan veri dizisinin belirli bir index numarasındaki verileri listeler.
        /// </summary>
        /// <param name="index">Veri dizisinin belirli bir index numarası</param>
        public MetinselKoleksiyon Getir(int index)
        {
            MetinselKoleksiyon u = veri[index - 1];
            return u;
        }
        /// <summary>
        /// Belirli bir kategorideki ürünleri listeler.
        /// </summary>
        /// <param name="KategoriAdi">Kategori Adı</param>
        public void KategoriyeGoreListele(string KategoriAdi)
        {
            for (int i = 0; i < veri.Length; i++)
            {
                MetinselKoleksiyon u = veri[i];
                if (u.Kategori == KategoriAdi)
                {
                    Console.WriteLine($"Isim: {veri[i].Isim}, Marka: {veri[i].Marka}, Kategori: {veri[i].Kategori}, Fiyat: {veri[i].Fiyat}");
                }
                
            }
        }
       
    }
}
