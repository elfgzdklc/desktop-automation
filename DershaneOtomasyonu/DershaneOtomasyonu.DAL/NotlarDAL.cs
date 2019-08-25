using DershaneOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DershaneOtomasyonu.DAL
{
    public class NotlarDAL
    {
        public static List<Notlar> Listele()
        {
            List<Notlar> _Notlar = new List<Notlar>();

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("NotlarListele", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = null;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    Notlar nt = new Notlar();

                    nt.ID = Convert.ToInt32(dr["ID"]);
                    nt.OgrenciID = Convert.ToInt32(dr["OgrenciID"]);
                    nt.SinavTarihi = Convert.ToDateTime(dr["SinavTarihi"]);
                    nt.Notu = Convert.ToDecimal(dr["Notu"]);
                    nt.SinavAdi = Convert.ToString(dr["SinavAdi"]);
                                     
                    
                    _Notlar.Add(nt);
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


            return _Notlar;
        }
        public static void NotlarEkle(Notlar nt)
        {

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("NotlarEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@OgrenciID", nt.OgrenciID);
            cmd.Parameters.AddWithValue("@SinavTarihi", nt.SinavTarihi);
            cmd.Parameters.AddWithValue("@Notu", nt.Notu);
            cmd.Parameters.AddWithValue("@SinavAdi", nt.SinavAdi);


            try
            {
                cnn.Open();
                nt.ID = Convert.ToInt32(cmd.ExecuteScalar());
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
        public static void NotlarGuncelle(Notlar nt)
        {

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("NotlarGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@OgrenciID", nt.OgrenciID);
            cmd.Parameters.AddWithValue("@SinavTarihi", nt.SinavTarihi);
            cmd.Parameters.AddWithValue("@Notu", nt.Notu);
            cmd.Parameters.AddWithValue("@ID", nt.ID);
            cmd.Parameters.AddWithValue("SinavAdi", nt.ID);

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
        public static void NotlarSil(Notlar nt)
        {

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("NotlarSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", nt.ID);

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
        public static Notlar ID(int ID)
        {
            Notlar nt = new Notlar();

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("NotlarID", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", ID);

            SqlDataReader dr = null;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    nt.ID = Convert.ToInt32(dr["ID"]);
                    nt.OgrenciID = Convert.ToInt32(dr["OgrenciID"]);
                    nt.SinavTarihi = Convert.ToDateTime(dr["SinavTarihi"]);
                    nt.Notu = Convert.ToDecimal(dr["Notu"]);
                    nt.SinavAdi = Convert.ToString(dr["Notu"]);
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

            return nt;

        }
    }
}
