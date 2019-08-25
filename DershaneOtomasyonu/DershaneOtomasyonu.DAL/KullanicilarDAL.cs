using DershaneOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DershaneOtomasyonu.DAL
{
    public class KullanicilarDAL
    {
        public static List<Kullanicilar> Listele()
        {
            List<Kullanicilar> _Kullanicilar = new List<Kullanicilar>();

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("KullanicilarListele", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = null;


            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    Kullanicilar k = new Kullanicilar();
                    k.ID = Convert.ToInt32(dr["ID"]);
                    k.K_Adi = dr["K_Adi"].ToString();
                    k.Sifre = dr["Sifre"].ToString();
                    k.Gorev = dr["Gorev"].ToString();
                    k.Adi = dr["Adi"].ToString();
                    k.Soyadi = dr["Soyadi"].ToString();
                    k.TCKN = Convert.ToDecimal(dr["TCKN"]);
                    k.Mail = dr["Mail"].ToString();
                    k.Adres = dr["Adres"].ToString();
                    k.Telefon = dr["Telefon"].ToString();
                    _Kullanicilar.Add(k);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
                cmd.Dispose();
                dr.Dispose();
            }


            return _Kullanicilar;
        }
        public static void KullanicilarEkle(Kullanicilar k)
        {

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("KullanicilarEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@K_Adi", k.K_Adi);
            cmd.Parameters.AddWithValue("@Sifre", k.Sifre);
            cmd.Parameters.AddWithValue("@Gorev", k.Gorev);
            cmd.Parameters.AddWithValue("@Adi", k.Adi);
            cmd.Parameters.AddWithValue("@Soyadi", k.Soyadi);
            cmd.Parameters.AddWithValue("@TCKN", k.TCKN);
            cmd.Parameters.AddWithValue("@Mail", k.Mail);
            cmd.Parameters.AddWithValue("@Adres", k.Adres);
            cmd.Parameters.AddWithValue("@Telefon", k.Telefon);


            try
            {
                cnn.Open();
                k.ID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
                cmd.Dispose();
            }
        }
        public static void KullanicilarGuncelle(Kullanicilar k)
        {

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("KullanicilarGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@K_Adi", k.K_Adi);
            cmd.Parameters.AddWithValue("@Sifre", k.Sifre);
            cmd.Parameters.AddWithValue("@Gorev", k.Gorev);
            cmd.Parameters.AddWithValue("@Adi", k.Adi);
            cmd.Parameters.AddWithValue("@Soyadi", k.Soyadi);
            cmd.Parameters.AddWithValue("@TCKN", k.TCKN);
            cmd.Parameters.AddWithValue("@Mail", k.Mail);
            cmd.Parameters.AddWithValue("@Adres", k.Adres);
            cmd.Parameters.AddWithValue("@Telefon", k.Telefon);
            cmd.Parameters.AddWithValue("@ID", k.ID);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
                cmd.Dispose();
            }
        }
        public static void KullanicilarSil(Kullanicilar k)
        {

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("KullanicilarSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", k.ID);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
                cmd.Dispose();
            }
        }
        public static Kullanicilar ID(int ID)
        {
            Kullanicilar k = new Kullanicilar();

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("KullanicilarID", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", ID);

            SqlDataReader dr = null;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    k.ID = Convert.ToInt32(dr["ID"]);
                    k.K_Adi = dr["K_Adi"].ToString();
                    k.Sifre = dr["Sifre"].ToString();
                    k.Gorev = dr["Gorev"].ToString();
                    k.Adi = dr["Adi"].ToString();
                    k.Soyadi = dr["Soyadi"].ToString();
                    k.TCKN = Convert.ToDecimal(dr["TCKN"]);
                    k.Mail = dr["Mail"].ToString();
                    k.Adres = dr["Adres"].ToString();
                    k.Telefon = dr["Telefon"].ToString();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
                cmd.Dispose();
                dr.Dispose();
            }

            return k;

        }
        public static Kullanicilar KullanicilarKontrol(string K_Adi, string Sifre)//kullanıcı adı şifre giriş ekranı için
        {
            Kullanicilar k = new Kullanicilar();

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("KullanicilarKontrol", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@K_Adi", K_Adi);
            cmd.Parameters.AddWithValue("@Sifre", Sifre);

            SqlDataReader dr = null;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    k.ID = Convert.ToInt32(dr["ID"]);
                    k.K_Adi = dr["K_Adi"].ToString();
                    k.Sifre = dr["Sifre"].ToString();
                    k.Gorev = dr["Gorev"].ToString();
                    k.Adi = dr["Adi"].ToString();
                    k.Soyadi = dr["Soyadi"].ToString();
                    k.TCKN = Convert.ToDecimal(dr["TCKN"]);
                    k.Mail = dr["Mail"].ToString();
                    k.Adres = dr["Adres"].ToString();
                    k.Telefon = dr["Telefon"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
                cmd.Dispose();
                dr.Dispose();
            }

            return k;
        }
        public static bool KullaniciAdiKontrol(string KullaniciAdi)//aynı kullanıcı isimlerini kontrol için
        {
            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("KullaniciAdiKontrol", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@K_Adi", KullaniciAdi);

            SqlDataReader dr = null;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
                cmd.Dispose();
                dr.Dispose();
            }

            return false;
        }
        public static bool KullaniciTCKontrol(decimal TC)//aynı kullanıcı TClerini kontrol için
        {
            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("KullaniciTCKontrol", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TCKN", TC);

            SqlDataReader dr = null;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
                cmd.Dispose();
                dr.Dispose();
            }

            return false;
        }
    }
}
