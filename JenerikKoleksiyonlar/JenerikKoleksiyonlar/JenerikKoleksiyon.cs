using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenerikKoleksiyonlar
{
    internal class JenerikKoleksiyon<T>
    {
        T[] dizi;

        public JenerikKoleksiyon()
        {
            dizi = new T[0];
        }
        public void Ekle(T veri)
        {
            T[] yeniDizi = new T[dizi.Length + 1];
            Array.Copy(dizi, yeniDizi, dizi.Length);
            yeniDizi[yeniDizi.Length - 1] = veri;
            dizi = yeniDizi;
        }
    }
}
