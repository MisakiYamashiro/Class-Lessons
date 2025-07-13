using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListKoleksiyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList nedir?
            //Şimdi ye kadar kendimiz birkaç tane koleksiyon sınıfı oluşturduk.
            //Peki amacı neydi?
            //Bir dizi oluşturup dizi içerisine veri ekleme ve listeleme gibi işlemleri bir düzene almak ve veri yönetimini kolaylaştırmak
            //c# bunun için "bana bırak abi, ben hallederim." demiştir.
            #endregion

            #region Kullanım
            ArrayList liste = new ArrayList();
            liste.Add("Ahmet");
            liste.Add("Mehmet");
            liste.Add(100);
            liste.Add(true);
            liste.Add(3.14);
            liste.AddRange(new int[] {1,2,3,4,5 });

            kisi k = new kisi();
            k.isim = "Ali";

            //liste.Add(k);

            liste.Insert(0, "Efe"); //En başa ekleme işlemi
            liste.RemoveAt(0); //En baştaki elemanı silme işlemi
            liste.Remove("Mehmet"); //Mehmet isimli elemanı silme işle
            liste.Remove("Meh");

            //liste.Sort(); //Sıralama işlemi, ancak bu işlem sadece string ve int gibi temel veri tipleri için geçerlidir.
            //liste.Reverse(); //Ters çevirme işlemi

            liste.TrimToSize(); //Koleksiyonun boyutunu, içindeki eleman sayısına göre ayarlar.

            Console.WriteLine("Eleman Sayısı = " + liste.Count);
            Console.WriteLine("Kapasite = " + liste.Capacity);

            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine(liste[i]);
            }
            #endregion
        }
    }
    class kisi
    { public string isim { get; set; } }
    

}
