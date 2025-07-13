using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyKavrami
{
    internal class Insan
    {
        public string isim;
        private string soyisim;
        
        public void setSoyisim(string soyisim)
        {
            this.soyisim = soyisim;
            //this = bu sınıfa ait olan demek
        } 

        public string getSoyisim()
        {
            return soyisim;
        }

        public string DogumYeri { get; set; }//Auto Implamented Property
        public int Yas { get; set; }
    }
}
