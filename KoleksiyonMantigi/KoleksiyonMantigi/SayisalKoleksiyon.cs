using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoleksiyonMantigi
{
    internal class SayisalKoleksiyon
    {
        int[] sayilar; //Global Tanımlama
        //Sınıf içerisinde tanımlanan her metot'da bu dizi erişilebilir olsun.
        //Dikkat sayılar dizisinin erişim belirteci private(Diğer sınıflardan erişime kapalı)

        public void DiziYarat()
        {
            sayilar = new int[0];
        }
        /// <summary>
        /// Koleksiyona veri eklemek için kullanılır
        /// </summary>
        /// <param name="sayi">Koleksiyon int türünde oluşturulduğu için parametremiz int türündedir.</param>
        public void Ekle(int sayi)
        {
            int[] gecici = new int[sayilar.Length + 1];
            Array.Copy(sayilar, gecici, sayilar.Length);
            gecici[gecici.Length - 1] = sayi;
            sayilar = gecici;
        }

        public int ElemanSayiGetir()
        {
            return sayilar.Length;
        }
        
        public void ElemanYazdir(int index)
        {
            if (index >= sayilar.Length)
            {
                Console.WriteLine("Dizi'de elemanlar 0 ile " + (sayilar.Length - 1) + " arasında numaralandırılmıştır.");
            }
            else
            {
                Console.WriteLine(sayilar[index]);
            }
        }
        public void TumunuYazdir()
        {
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
        }
    }
}
