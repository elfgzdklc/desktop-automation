using DershaneOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DershaneOtomasyonu.DAL
{
    public class OgrenciDAL
    {
        public static List<Ogrenci> Listele()
        {
            List<Ogrenci> _Ogrenciler = new List<Ogrenci>();

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("OgrenciListele", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = null;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    Ogrenci ogrn = new Ogrenci();
                    ogrn.ID = Convert.ToInt32(dr["ID"]);
                    ogrn.Adi = dr["Adi"].ToString();
                    ogrn.Soyadi = dr["Soyadi"].ToString();
                    ogrn.TCKN = Convert.ToDecimal(dr["TCKN"]);
                    ogrn.Telefon = dr["Telefon"].ToString();
                    ogrn.Mail = dr["Mail"].ToString();
                    ogrn.Adres = dr["Adres"].ToString();
                    ogrn.VeliAdi = dr["VeliAdi"].ToString();
                    ogrn.VeliTelefonu = dr["VeliTelefonu"].ToString();
                    ogrn.SinifID = Convert.ToInt32(dr["SinifID"]);

                    _Ogrenciler.Add(ogrn);
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


            return _Ogrenciler;
        }
        public static void OgrenciEkle(Ogrenci ogrn)
        {

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("OgrenciEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Adi", ogrn.Adi);
            cmd.Parameters.AddWithValue("@Soyadi", ogrn.Soyadi);
            cmd.Parameters.AddWithValue("@TCKN", ogrn.TCKN);
            cmd.Parameters.AddWithValue("@Telefon", ogrn.Telefon);
            cmd.Parameters.AddWithValue("@Mail", ogrn.Mail);
            cmd.Parameters.AddWithValue("@Adres", ogrn.Adres);
            cmd.Parameters.AddWithValue("@VeliAdi", ogrn.VeliAdi);
            cmd.Parameters.AddWithValue("@VeliTelefonu", ogrn.VeliTelefonu);
            cmd.Parameters.AddWithValue("@SinifID", ogrn.SinifID);


            try
            {
                cnn.Open();
                ogrn.ID = Convert.ToInt32(cmd.ExecuteScalar());
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
        public static void OgrenciGuncelle(Ogrenci ogrn)
        {

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("OgrenciGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Adi", ogrn.Adi);
            cmd.Parameters.AddWithValue("@Soyadi", ogrn.Soyadi);
            cmd.Parameters.AddWithValue("@TCKN", ogrn.TCKN);
            cmd.Parameters.AddWithValue("@Telefon", ogrn.Telefon);
            cmd.Parameters.AddWithValue("@Mail", ogrn.Mail);
            cmd.Parameters.AddWithValue("@Adres", ogrn.Adres);
            cmd.Parameters.AddWithValue("@VeliAdi", ogrn.VeliAdi);
            cmd.Parameters.AddWithValue("@VeliTelefonu", ogrn.VeliTelefonu);
            cmd.Parameters.AddWithValue("@SinifID", ogrn.SinifID);
            cmd.Parameters.AddWithValue("@ID", ogrn.ID);

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
        public static void OgrenciSil(Ogrenci ogrn)
        {

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("OgrenciSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", ogrn.ID);
            
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
        public static Ogrenci ID(int ID)
        {
            Ogrenci ogrn = new Ogrenci();

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("OgrenciID", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", ID);

            SqlDataReader dr = null;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    ogrn.ID = Convert.ToInt32(dr["ID"]);
                    ogrn.Adi = dr["Adi"].ToString();
                    ogrn.Soyadi = dr["Soyadi"].ToString();
                    ogrn.TCKN = Convert.ToDecimal(dr["TCKN"]);
                    ogrn.Telefon = dr["Telefon"].ToString();
                    ogrn.Mail = dr["Mail"].ToString();
                    ogrn.Adres = dr["Adres"].ToString();
                    ogrn.VeliAdi = dr["VeliAdi"].ToString();
                    ogrn.VeliTelefonu = dr["VeliTelefonu"].ToString();
                    ogrn.SinifID = Convert.ToInt32(dr["SinifID"]);
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

            return ogrn;

        }
        public static bool OgrenciTCKontrol(decimal tc)//aynı öğrenci TClerini kontrol için
        {
            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("OgrenciTCKontrol", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TCKN", tc);

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
