using DershaneOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DershaneOtomasyonu.DAL
{
    public class OgretmenDAL
    {
        public static List<Ogretmen> Listele()
        {
            List<Ogretmen> _Ogretmenler = new List<Ogretmen>();

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("OgretmenListele", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = null;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    Ogretmen ogrt = new Ogretmen();
                    ogrt.ID = Convert.ToInt32(dr["ID"]);
                    ogrt.KullanicilarID = Convert.ToInt32(dr["KullanicilarID"]);
                    ogrt.Brans = dr["Brans"].ToString();
                    _Ogretmenler.Add(ogrt);
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


            return _Ogretmenler;
        }
        public static void OgretmenEkle(Ogretmen ogrt)
        {

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("OgretmenEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KullanicilarID", ogrt.KullanicilarID);
            cmd.Parameters.AddWithValue("@Brans", ogrt.Brans);

            try
            {
                cnn.Open();
                ogrt.ID = Convert.ToInt32(cmd.ExecuteScalar());
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
        public static void OgretmenGuncelle(Ogretmen ogrt)
        {

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("OgretmenGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KullanicilarID", ogrt.KullanicilarID);
            cmd.Parameters.AddWithValue("@Brans", ogrt.Brans);
            cmd.Parameters.AddWithValue("@ID", ogrt.ID);

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
        public static void OgretmenSil(Ogretmen ogrt)
        {

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("OgretmenSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", ogrt.ID);

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
        public static Ogretmen ID(int ID)
        {
            Ogretmen ogrt = new Ogretmen();

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("OgretmenID", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", ID);

            SqlDataReader dr = null;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {

                    ogrt.ID = Convert.ToInt32(dr["ID"]);
                    ogrt.KullanicilarID = Convert.ToInt32(dr["KullanicilarID"]);
                    ogrt.Brans = dr["Brans"].ToString();

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

            return ogrt;

        }
    }
}
