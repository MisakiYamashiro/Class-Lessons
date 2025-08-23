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
        SqlConnection conBayern;
        SqlCommand cmd;
        SqlCommand cmdBayern;

        public IslemSinifi()
        {
            //con = new SqlConnection(@"Data Source=EFE-S-TEMP-LAPT\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            con = new SqlConnection(BaglantiYollari.LocalYol);
            conBayern = new SqlConnection(BaglantiYollari.LocalBayernYol);
            cmd = con.CreateCommand();
            cmdBayern = conBayern.CreateCommand();

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
        public bool UrunSil(int id)
        {
            try
            {
                cmd.CommandText = "delete from Products where ProductID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
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

        public bool UrunDuzenle(Urun urun, int ID)
        {
            try
            {
                cmd.CommandText = "update Products set ProductName=@pn,SupplierID=@sid,CategoryID=@cid,UnitPrice=@up,UnitsInStock=@uis,ReorderLevel=@rl,Discontinued=@dc where ProductID=@urunid";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pn", urun.UrunAdi);
                cmd.Parameters.AddWithValue("@sid", urun.TedarikciID);
                cmd.Parameters.AddWithValue("@cid", urun.KategoriID);
                cmd.Parameters.AddWithValue("@up", urun.Fiyat);
                cmd.Parameters.AddWithValue("@uis", urun.Stok);
                cmd.Parameters.AddWithValue("@rl", urun.GuvenlikStok);
                cmd.Parameters.AddWithValue("@dc", urun.SatistaMi);
                cmd.Parameters.AddWithValue("@urunid", ID);
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

        #region Tedarikçi Metotları
        public bool TedarikciEkle(Tedarikci td)
        {
            try
            {
                cmd.CommandText = "insert into Suppliers(CompanyName, ContactName,ContactTitle,Address,City) values(@cn,@ctn,@ctt,@ad,@city)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cn", td.CompanyName);
                cmd.Parameters.AddWithValue("@ctt", td.ContactTitle);
                cmd.Parameters.AddWithValue("@ctn", td.ContactName);
                cmd.Parameters.AddWithValue("@ad", td.Address);
                cmd.Parameters.AddWithValue("@city", td.City);
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

        public bool TedarikciSil(int id)
        {
            
            try
            {
                cmd.CommandText = "delete from Suppliers where SupplierID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
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

        public List<Tedarikci> TedarikciListele(Tedarikci supplier)
        {
            List<Tedarikci> tedarikciler = new List<Tedarikci>();
            try
            {
                cmd.CommandText = "select @CompanyName, @ContactName, @ContactTitle, @Address,@City from Suppliers";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CompanyName", supplier.CompanyName);
                cmd.Parameters.AddWithValue("@ContactName", supplier.ContactName);
                cmd.Parameters.AddWithValue("@ContactTitle", supplier.ContactTitle);
                cmd.Parameters.AddWithValue("@Address", supplier.Address);
                cmd.Parameters.AddWithValue("@City", supplier.City);
                con.Open();
                SqlDataReader SQLdr = cmd.ExecuteReader();
                while (SQLdr.Read())
                {
                    string CompName = SQLdr.GetString(0);
                    string ContName = SQLdr.GetString(1);
                    string ContTitle = SQLdr.GetString(2);
                    string Address = SQLdr.GetString(3);
                    string City = SQLdr.GetString(4);
                    Tedarikci td = new Tedarikci();
                    tedarikciler.Add(td);
                }
                return tedarikciler;
            }                          
            finally
            {
                con.Close();
            }
        }

        public bool TedarikciDuzenle(Tedarikci supplier)
        { 
            try
            {
                cmd.CommandText = "insert into Suppliers(CompanyName, ContactName, ContactTitle, Address, City) values(@companyName, @contactName, @contactTitle, @address, @city)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@companyName", supplier.CompanyName);
                cmd.Parameters.AddWithValue("@contactName", supplier.ContactName);
                cmd.Parameters.AddWithValue("@contactTitle", supplier.ContactTitle);
                cmd.Parameters.AddWithValue("@address", supplier.Address);
                cmd.Parameters.AddWithValue("@city", supplier.City);
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

        #region Siparisler Metotlari
        public bool YeniSiparisEkle(Siparisler order)
        {
            try
            {
                cmd.CommandText = "insert into Orders(CustomerID, EmployeeID, OrderDate,RequiredDate, ShippedDate, ShipVia,Freight, ShipName, ShipAddress, ShipCity,ShipRegion,ShipPostalCode,ShipCountry) values(@customerID, @employeeID, @orderDate,@requiredDate, @shippedDate, @shipVia,@freight, @shipName, @shipAddress, @shipCity,@shipRegion,@shipPostalCode,@shipCountry)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@customerID", order.CustomerID);
                cmd.Parameters.AddWithValue("@employeeID", order.EmployeeID);
                cmd.Parameters.AddWithValue("@orderDate", order.OrderDate);
                cmd.Parameters.AddWithValue("@requiredDate", order.RequiredDate);
                cmd.Parameters.AddWithValue("@shippedDate", order.ShippedDate);
                cmd.Parameters.AddWithValue("@shipVia", order.ShipVia_SupplierID);
                cmd.Parameters.AddWithValue("@shipName", order.ShipName);
                cmd.Parameters.AddWithValue("@shipAddress", order.ShipAddress);
                cmd.Parameters.AddWithValue("@shipCity", order.ShipCity);
                cmd.Parameters.AddWithValue("@shipRegion", order.ShipRegion);
                cmd.Parameters.AddWithValue("@shipPostalCode", order.ShipPostalCode);
                cmd.Parameters.AddWithValue("@shipCountry", order.ShipCountry);
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

        public List<Siparisler> SiparisleriListele()
        {
            List<Siparisler> siparisler = new List<Siparisler>();
            try
            {
                cmd.CommandText = "select O.OrderID,OD.ProductID,P.ProductName,OD.UnitPrice,O.OrderDate,O.RequiredDate,O.ShippedDate,O.ShipVia, S.CompanyName,O.Freight,O.ShipName,O.ShipAddress,O.ShipCity,O.ShipRegion,O.ShipPostalCode,O.ShipCountry,C.CustomerID,C.ContactName,C.ContactTitle,C.Phone,E.EmployeeID,E.TitleOfCourtesy + ' ' + E.FirstName + ' ' + E.LastName as Employee,E.Title,E.HomePhone from Orders as O join Customers as C on O.CustomerID = C.CustomerID join Shippers as S on O.ShipVia = S.ShipperID join Employees as E on O.EmployeeID = E.EmployeeID join [Order Details] as OD on O.OrderID = OD.OrderID join Products as P on OD.ProductID = P.ProductID group by O.OrderID,OD.ProductID,P.ProductName,OD.UnitPrice,O.OrderDate,O.RequiredDate,O.ShippedDate,O.ShipVia, S.CompanyName,O.Freight,O.ShipName,O.ShipAddress,O.ShipCity,O.ShipRegion,O.ShipPostalCode,O.ShipCountry,C.CustomerID,C.ContactName,C.ContactTitle,C.Phone,E.EmployeeID,E.TitleOfCourtesy + ' ' + E.FirstName + ' ' + E.LastName,E.Title,E.HomePhone order by ProductID";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Siparisler siparisler1 = new Siparisler();
                    if (!r.IsDBNull(0))
                    {
                        siparisler1.OrderID = r.GetInt32(0);
                    }
                    else
                    {
                        siparisler1.OrderID = -1; // Veya uygun bir default değer
                    }

                    if (!r.IsDBNull(1))
                    {
                        siparisler1.ProductID = r.GetInt32(1);
                    }
                    else
                    {
                        siparisler1.ProductID = -1;
                    }

                    if (!r.IsDBNull(2))
                    {
                        siparisler1.ProductName = r.GetString(2);
                    }
                    else
                    {
                        siparisler1.ProductName = "**ProductName girilmemiş.";
                    }

                    if (!r.IsDBNull(3))
                    {
                        siparisler1.UnitPrice = r.GetDecimal(3);
                    }
                    else
                    {
                        siparisler1.UnitPrice = 0;
                    }

                    if (!r.IsDBNull(4))
                    {
                        siparisler1.OrderDate = r.GetDateTime(4);
                    }
                    else
                    {
                        siparisler1.OrderDate = DateTime.MinValue;
                    }

                    if (!r.IsDBNull(5))
                    {
                        siparisler1.RequiredDate = r.GetDateTime(5);
                    }
                    else
                    {
                        siparisler1.RequiredDate = DateTime.MinValue;
                    }

                    if (!r.IsDBNull(6))
                    {
                        siparisler1.ShippedDate = r.GetDateTime(6);
                    }
                    else
                    {
                        siparisler1.ShippedDate = DateTime.MinValue;
                    }

                    if (!r.IsDBNull(7))
                    {
                        siparisler1.ShipVia_SupplierID = r.GetInt32(7);
                    }
                    else
                    {
                        siparisler1.ShipVia_SupplierID = -1;
                    }

                    if (!r.IsDBNull(8))
                    {
                        siparisler1.CompanyName = r.GetString(8);
                    }
                    else
                    {
                        siparisler1.CompanyName = "**CompanyName girilmemiş.";
                    }

                    if (!r.IsDBNull(9))
                    {
                        siparisler1.Freight = r.GetDecimal(9);
                    }
                    else
                    {
                        siparisler1.Freight = 0;
                    }

                    if (!r.IsDBNull(10))
                    {
                        siparisler1.ShipName = r.GetString(10);
                    }
                    else
                    {
                        siparisler1.ShipName = "**ShipName girilmemiş.";
                    }

                    if (!r.IsDBNull(11))
                    {
                        siparisler1.ShipAddress = r.GetString(11);
                    }
                    else
                    {
                        siparisler1.ShipAddress = "**ShipAddress girilmemiş.";
                    }

                    if (!r.IsDBNull(12))
                    {
                        siparisler1.ShipCity = r.GetString(12);
                    }
                    else
                    {
                        siparisler1.ShipCity = "**ShipCity girilmemiş.";
                    }

                    if (!r.IsDBNull(13))
                    {
                        siparisler1.ShipRegion = r.GetString(13);
                    }
                    else
                    {
                        siparisler1.ShipRegion = "**ShipRegion girilmemiş.";
                    }

                    if (!r.IsDBNull(14))
                    {
                        siparisler1.ShipPostalCode = r.GetString(14);
                    }
                    else
                    {
                        siparisler1.ShipPostalCode = "**ShipPostalCode girilmemiş.";
                    }

                    if (!r.IsDBNull(15))
                    {
                        siparisler1.ShipCountry = r.GetString(15);
                    }
                    else
                    {
                        siparisler1.ShipCountry = "**ShipCountry girilmemiş.";
                    }

                    if (!r.IsDBNull(16))
                    {
                        siparisler1.CustomerID = r.GetString(16);
                    }
                    else
                    {
                        siparisler1.CustomerID = "**CustomerID girilmemiş.";
                    }

                    if (!r.IsDBNull(17))
                    {
                        siparisler1.ContactName = r.GetString(17);
                    }
                    else
                    {
                        siparisler1.ContactName = "**ContactName girilmemiş.";
                    }

                    if (!r.IsDBNull(18))
                    {
                        siparisler1.ContactTitle = r.GetString(18);
                    }
                    else
                    {
                        siparisler1.ContactTitle = "**ContactTitle girilmemiş.";
                    }

                    if (!r.IsDBNull(19))
                    {
                        siparisler1.Phone = r.GetString(19);
                    }
                    else
                    {
                        siparisler1.Phone = "**Phone girilmemiş.";
                    }

                    if (!r.IsDBNull(20))
                    {
                        siparisler1.EmployeeID = r.GetInt32(20);
                    }
                    else
                    {
                        siparisler1.EmployeeID = -1;
                    }


                    if (!r.IsDBNull(22))
                    {
                        siparisler1.Title = r.GetString(22);
                    }
                    else
                    {
                        siparisler1.Title = "**Title girilmemiş.";
                    }

                    if (!r.IsDBNull(23))
                    {
                        siparisler1.HomePhone = r.GetString(23);
                    }
                    else
                    {
                        siparisler1.HomePhone = "**HomePhone girilmemiş.";
                    }
                    siparisler.Add(siparisler1);

                }
                return siparisler;
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

        public void SiparisSil(int id)
        {
            try
            {
                cmd.CommandText = "delete from Orders where OrderID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }
        public bool SiparisDuzenle(Siparisler siparis, int id)
        {
            try
            {
                cmd.CommandText = "update Orders to CustomerID=@ci,EmployeeID=@ei, OrderDate=@od, RequiredDate=@rd,ShippedDate=@sd,ShipVia=@sv,Freight=@f,ShipName=@sn,ShipAddress=@sa,ShipCity=@sc,ShipRegion=@sr,ShipPostalCode=@spc,ShipCountry=sc where OrderID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ci", siparis.CustomerID);
                cmd.Parameters.AddWithValue("@ei", siparis.EmployeeID);
                cmd.Parameters.AddWithValue("@od", siparis.OrderDate);
                cmd.Parameters.AddWithValue("@rd", siparis.RequiredDate);
                cmd.Parameters.AddWithValue("@sd", siparis.ShippedDate);
                cmd.Parameters.AddWithValue("@sv", siparis.ShipVia_SupplierID);
                cmd.Parameters.AddWithValue("@f", siparis.Freight);
                cmd.Parameters.AddWithValue("@sn", siparis.ShipName);
                cmd.Parameters.AddWithValue("@sa", siparis.ShipAddress);
                cmd.Parameters.AddWithValue("@sc", siparis.ShipCity);
                cmd.Parameters.AddWithValue("@sr", siparis.ShipRegion);
                cmd.Parameters.AddWithValue("@spc", siparis.ShipPostalCode);
                cmd.Parameters.AddWithValue("@sc", siparis.ShipCity);
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
