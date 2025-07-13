using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMetotlar
{
    internal class Math
    {

        //Overload Metotlar
        //İsimleri aynı ancak metot imzaları(aldıkları parametrelerin türü veya sayısı) farklı olan metotlara denir. 
        public int Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
        //public double DoubleTopla(double sayi1, double sayi2)
        //{
        //    double toplam = sayi1 + sayi2;
        //    return toplam;
        //}
        public double Topla(double sayi1, double sayi2)
        {
            double toplam = sayi1 + sayi2;
            return toplam;
        }

        public double Topla(string sayi1, string sayi2)
        {
            double toplam = Convert.ToDouble(sayi1) + Convert.ToDouble(sayi2);
            return toplam;
        }
    }
}
