using DershaneOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DershaneOtomasyonu.DAL
{
    public class DerslerDAL
    {
        public static List<Dersler> Listele()
        {
            List<Dersler> _Dersler = new List<Dersler>();

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("DerslerListele", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = null;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    Dersler drs = new Dersler();
                    drs.ID = Convert.ToInt32(dr["ID"]);
                    drs.DersAdi = dr["DersAdi"].ToString();
                    _Dersler.Add(drs);
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

            return _Dersler;
        }
        public static void DerslerEkle(Dersler drs)
        {
            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("DerslerEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DersAdi", drs.DersAdi);


            try
            {
                cnn.Open();
                drs.ID = Convert.ToInt32(cmd.ExecuteScalar());
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
        public static void DerslerGuncelle(Dersler drs)
        {
            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("DerslerGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DersAdi", drs.DersAdi);
            cmd.Parameters.AddWithValue("@ID", drs.ID);

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
        public static void DerslerSil(Dersler drs)
        {
            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("DerslerSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", drs.ID);

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
        public static Dersler ID(int ID)
        {
            Dersler drs = new Dersler();

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("DerslerID", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", ID);

            SqlDataReader dr = null;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    drs.ID = Convert.ToInt32(dr["ID"]);
                    drs.DersAdi = dr["DersAdi"].ToString();
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

            return drs;
        }
    }
}
