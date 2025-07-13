using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMethodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama
            //Constructor = Yapıcı Method
            // Bazen programlama yaparken bir sınıfın nesnesi oluşturulduğunda otomatik olarak yapılsa iyi olur dediğimiz işlemlerle karşılaşabiliriz. İşte bu alanlarda constructor tanımlaması yapmalıyız.

            //Constructor Kuralları
            //1 Metot adı sınıfın adıyla aynı olmak zorundadır.
            //2 Metodun geri dönüş türü olmaz.
            //3 Yapıcı metotlar parametre alabilirler
            //4 Yapıcı metotların overloadları oluşturulabilir.***Overload kavramı ileride öğrenilecek.W
            #endregion

            #region Kullanım
            UrunKoleksiyonu uk = new UrunKoleksiyonu();

            Insan Efe = new Insan("Efe","Palaz",16);
            Console.WriteLine(Efe.isim + " " + Efe.soyisim + " " + Efe.yas);
            #endregion
        }
    }
    class UrunKoleksiyonu
    {
        string[] urunler;

        public UrunKoleksiyonu()//Constructor
        {
            urunler = new string[0];
        }
    }
    class Kisi
    {
        public string isim;
        public string soyisim;
    }
    class Insan
    {
        public string isim;
        public string soyisim;
        public int yas;

        public Insan(string i, string si, int y)
        {
            isim = i;
            soyisim = si;
            yas = y;
        }
    }
}
