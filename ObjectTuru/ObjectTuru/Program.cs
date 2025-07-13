using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTuru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Object Nedir?
            //Object her türün kaynağı olan bir türdür.

            //Her tür Object'ten doğar.
            //object obj = "Yağızcan";
            //Console.WriteLine(obj);
            //obj = 45;
            //Console.WriteLine(obj);
            //obj = true;
            //Console.WriteLine(obj);
            //obj = "palaz";
            //Console.WriteLine(obj.ToUpper());


            #endregion

            #region Boxing

            //Herhangi bir türdeki verinin object türündeki alana atılması işlemine Boxing denir.

            //int sayi = 45;

            //object obj = sayi;

            //obj+=3;
            #endregion

            #region Unboxing    
            //Object türüne atanmış verinin kendi türüne Cast edilmesi işlemine Unboxing denir.
            int sayi = 45;
            object obj = sayi; // Boxing işlemi

            //int gelen = (int)obj; // Unboxing işlemi
            //gelen += 3; // Gelen değeri 48 oldu
            //Console.WriteLine(gelen);

            obj = "Selami";
            int gelen = (int)obj; // Türler tutmadığı için InvalidCastException hatası fırlatır.
            Console.WriteLine(gelen);
            #endregion
        }
    }
}
