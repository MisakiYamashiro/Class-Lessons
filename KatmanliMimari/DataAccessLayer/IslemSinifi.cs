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

        #endregion
    }
}
