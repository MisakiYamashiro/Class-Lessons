using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan ins = new Insan();
            ins.isim = "Murtaza";
            ins.setSoyisim("Şuayipoğlu");
            ins.DogumYeri = "İzmir";
            Console.WriteLine(ins.isim + " " + ins.getSoyisim() + " " + ins.DogumYeri);
        }
    }
}
