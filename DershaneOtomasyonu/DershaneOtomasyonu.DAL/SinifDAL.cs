using DershaneOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DershaneOtomasyonu.DAL
{
    public class SinifDAL
    {
        public static List<Sinif> Listele()
        {
            List<Sinif> _Sinifler = new List<Sinif>();

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("SinifListele", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = null;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    Sinif snf = new Sinif();
                    snf.ID = Convert.ToInt32(dr["ID"]);
                    snf.SubeAdi = dr["SubeAdi"].ToString();
                    snf.BolumAdi = dr["BolumAdi"].ToString();
                    snf.SinifDurumu = dr["SinifDurumu"].ToString();
                    _Sinifler.Add(snf);
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


            return _Sinifler;
        }
        public static void SinifEkle(Sinif snf)
        {

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("SinifEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SubeAdi", snf.SubeAdi);
            cmd.Parameters.AddWithValue("@BolumAdi", snf.BolumAdi);
            cmd.Parameters.AddWithValue("@SinifDurumu", snf.SinifDurumu);

            try
            {
                cnn.Open();
                snf.ID = Convert.ToInt32(cmd.ExecuteScalar());
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
        public static void SinifGuncelle(Sinif snf)
        {

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("SinifGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SubeAdi", snf.SubeAdi);
            cmd.Parameters.AddWithValue("@BolumAdi", snf.BolumAdi);
            cmd.Parameters.AddWithValue("@SinifDurumu", snf.SinifDurumu);
            cmd.Parameters.AddWithValue("@ID", snf.ID);

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
        public static void SinifSil(Sinif snf)
        {

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("SinifSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", snf.ID);

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
        public static Sinif ID(int ID)
        {
            Sinif snf = new Sinif();

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("SinifID", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", ID);

            SqlDataReader dr = null;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    snf.ID = Convert.ToInt32(dr["ID"]);
                    snf.SubeAdi = dr["SubeAdi"].ToString();
                    snf.BolumAdi = dr["BolumAdi"].ToString();
                    snf.SinifDurumu = dr["SinifDurumu"].ToString();
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

            return snf;

        }
        public static bool SinifKontrol(string SinifAdi,string BolumAdi,string SubeAdi)//aynı sinif isimlerini kontrol için
        {
            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("SinifKontrol", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SinifDurumu", SinifAdi);
            cmd.Parameters.AddWithValue("@BolumAdi", BolumAdi);
            cmd.Parameters.AddWithValue("@SubeAdi", SubeAdi);

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
