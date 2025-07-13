using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math mat = new Math();
            Console.WriteLine(mat.Topla(2,5));

            //Console.WriteLine(mat.Topla(12.9,12.8));
            //Tanımlanan metot sadece int parametre aldığı için bu işlem yapılamaz

            //Console.WriteLine(mat.DoubleTopla(12.9,8.7));

            Console.WriteLine(mat.Topla(12.9,12.8));
            //Parametrelere en uygun hangisi ise o overload'ı kullanır.

            Console.WriteLine(mat.Topla("5","8.3"));
        }
    }
}
