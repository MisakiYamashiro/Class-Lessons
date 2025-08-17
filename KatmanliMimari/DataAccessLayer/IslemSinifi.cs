using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class IslemSinifi
    {
        SqlConnection con;
        SqlCommand cmd;

        public IslemSinifi()
        {
            //con = new SqlConnection(@"Data Source=EFE-S-TEMP-LAPT\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            con = new SqlConnection(BaglantiYollari.LocalYol);
            cmd = con.CreateCommand();

        }

        #region Kategori Metotları

        //Ekleme
        public List<Kategori> KategoriListele()
        {
            List<Kategori> kategoriler = new List<Kategori>();
            try
            {
                cmd.CommandText = "Select CategoryID, CategoryName, Description from Categories";
                cmd.Parameters.Clear();
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    Kategori kat = new Kategori();
                    kat.ID = reader.GetInt32(0);
                    kat.Isim = reader.GetString(1);
                    if(!reader.IsDBNull(2))
                    {
                        kat.Aciklama = reader.GetString(2);
                    }
                    else
                    {
                        kat.Aciklama = "**Kategori açıklama girilmemiş.";
                    }
                        kategoriler.Add(kat);
                }
                return kategoriler;
            }

            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool KategoriEkle(string isim, string aciklama)
        {
            try
            {
                cmd.CommandText = "insert into Categories(CategoryName, Description) values(@i,@a)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@i", isim);
                cmd.Parameters.AddWithValue("@a", aciklama);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;

            }
            finally
            {
                con.Close();
            }
            
        }
        
        public bool KategoriEkle(Kategori Kat)
        {
            try
            {
                cmd.CommandText = "insert into Categories(CategoryName, Description) values(@i,@a)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@i", Kat.Isim);
                cmd.Parameters.AddWithValue("@a", Kat.Aciklama);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public void KategoriSil(int ID)
        {
            try
            {
                cmd.CommandText = "delete Categories where CategoryID= @katasdasda";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@katasdasda", ID);
                con.Open();
                cmd.ExecuteNonQuery();
                
            }
            finally 
            {

                con.Close();
            }
        }

        public bool KategoriGuncelle(Kategori Kat)
        {
            try
            {
                cmd.CommandText = "update Categories set CategoryName=@naberrasreada, Description=@aciklamasdasd where CategoryID=@iddadsfgpfgjpdfjpfjpgfpj";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@naberrasreada", Kat.Isim);
                cmd.Parameters.AddWithValue("@aciklamasdasd", Kat.Aciklama);
                cmd.Parameters.AddWithValue("@iddadsfgpfgjpdfjpfjpgfpj", Kat.ID);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
                
            }
            finally
            {
                con.Close();
            }
        }

        public bool KategoriIsimKontrol(string isim)
        {
            try
            {
                cmd.CommandText = "select count(*) from Categories where CategoryName=@cn";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cn", isim);
                con.Open();

                int sayi = Convert.ToInt32(cmd.ExecuteScalar());
                if (sayi == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Ürün Metotları

        public List<Urun> UrunListele()
        {
            List<Urun> urunler = new List<Urun>();
            try
            {
                cmd.CommandText = "SELECT P.ProductID, P.ProductName, P.SupplierID, S.CompanyName, P.CategoryID, C.CategoryName, P.UnitPrice, P.UnitsInStock, P.ReorderLevel, P.Discontinued FROM Products as P join Suppliers as S on P.SupplierID = S.SupplierID join Categories as C on P.CategoryID = C.CategoryID";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Urun u = new Urun();
                    u.UrunID = reader.GetInt32(0);
                    u.UrunAdi = reader.GetString(1);
                    u.TedarikciID = reader.GetInt32(2);
                    u.Tedarikci = reader.GetString(3);
                    u.KategoriID = reader.GetInt32(4);
                    u.Kategori = reader.GetString(5);
                    u.Fiyat = reader.GetDecimal(6);
                    u.Stok = reader.GetInt16(7);
                    u.GuvenlikStok = reader.GetInt16(8);
                    u.SatistaMi = reader.GetBoolean(9);
                    urunler.Add(u);
                }
                return urunler;
            }
            catch 
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Urun> UrunListele(bool satisdurum)
        {
            List<Urun> urunler = new List<Urun>();
            try
            {
                cmd.CommandText = "SELECT P.ProductID, P.ProductName, P.SupplierID, S.CompanyName, P.CategoryID, C.CategoryName, P.UnitPrice, P.UnitsInStock, P.ReorderLevel, P.Discontinued FROM Products as P join Suppliers as S on P.SupplierID = S.SupplierID join Categories as C on P.CategoryID = C.CategoryID where P.Discontinued = @sd";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sd", satisdurum);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Urun u = new Urun();
                    u.UrunID = reader.GetInt32(0);
                    u.UrunAdi = reader.GetString(1);
                    u.TedarikciID = reader.GetInt32(2);
                    u.Tedarikci = reader.GetString(3);
                    u.KategoriID = reader.GetInt32(4);
                    u.Kategori = reader.GetString(5);
                    u.Fiyat = reader.GetDecimal(6);
                    u.Stok = reader.GetInt16(7);
                    u.GuvenlikStok = reader.GetInt16(8);
                    u.SatistaMi = reader.GetBoolean(9);
                    urunler.Add(u);
                }
                return urunler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }


        public bool UrunEkle(Urun urn)
        {
            try
            {
                cmd.CommandText = "insert into Products(ProductName,SupplierID,CategoryID,UnitPrice,UnitsInStock,ReorderLevel,Discontinued) values(@productName,@supplierID,@categoryID,@unitPrice,@unitsInStock,@reorderLevel,@discontinued)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@productName", urn.UrunAdi);
                cmd.Parameters.AddWithValue("@supplierID", urn.TedarikciID);
                cmd.Parameters.AddWithValue("@categoryID", urn.KategoriID);
                cmd.Parameters.AddWithValue("@unitPrice", urn.Fiyat);
                cmd.Parameters.AddWithValue("@unitsInStock", urn.Stok);
                cmd.Parameters.AddWithValue("@reorderLevel", urn.GuvenlikStok);
                cmd.Parameters.AddWithValue("@discontinued", urn.SatistaMi);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
    }
}
