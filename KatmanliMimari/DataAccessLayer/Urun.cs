using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Urun
    {
        public int UrunID { get; set; }

        public string UrunAdi { get; set; }

        public int TedarikciID { get; set; }

        public string Tedarikci { get; set; }

        public int KategoriID { get; set; }

        public string Kategori { get; set; }

        public decimal Fiyat { get; set; }

        public short Stok { get; set; }

        public short GuvenlikStok { get; set; }

        public bool SatistaMi { get; set; }
    }

}
