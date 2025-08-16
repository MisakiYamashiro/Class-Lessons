using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class BaglantiYollari
    {
        //static proje build edildiğinde ram üzerinde otomatik varedilir
        //kullanılmnası için nesne oluşutmrak gerekmez.
        public static string LocalYol = @"Data Source=EFE-S-TEMP-LAPT\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True";
        public static string CanliYol = @"Data Source=AYNEN\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True";
    }
}
