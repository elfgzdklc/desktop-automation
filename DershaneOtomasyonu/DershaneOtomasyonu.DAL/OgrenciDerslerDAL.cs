using DershaneOtomasyonu.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DershaneOtomasyonu.DAL
{
    public class OgrenciDerslerDAL
    {
        public static List<OgrenciDersler> Listele()
        {
            List<OgrenciDersler> _OgDersler = new List<OgrenciDersler>();

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("OgrenciDerslerListele", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = null;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    OgrenciDersler ogders = new OgrenciDersler();

                    ogders.ID = Convert.ToInt32(dr["ID"]);
                    ogders.OgrenciID = Convert.ToInt32(dr["OgrenciID"]);
                    ogders.DersID = Convert.ToInt32(dr["DersID"]);
                    _OgDersler.Add(ogders);
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


            return _OgDersler;
        }
        public static void OgrenciDerslerEkle(OgrenciDersler ogders)
        {

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("OgrenciDerslerEkle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@OgrenciID", ogders.OgrenciID);
            cmd.Parameters.AddWithValue("@DersID", ogders.DersID);


            try
            {
                cnn.Open();
                ogders.ID = Convert.ToInt32(cmd.ExecuteScalar());
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
        public static void OgrenciDerslerGuncelle(OgrenciDersler ogders)
        {

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("OgrenciDerslerGuncelle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@OgrenciID", ogders.OgrenciID);
            cmd.Parameters.AddWithValue("@DersID", ogders.DersID);
            cmd.Parameters.AddWithValue("@ID", ogders.ID);

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
        public static void OgrenciDerslerSil(OgrenciDersler ogders)
        {

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("OgrenciDerslerSil", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", ogders.ID);

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
        public static OgrenciDersler ID(int ID)
        {
            OgrenciDersler ogders = new OgrenciDersler();

            SqlConnection cnn = new SqlConnection(Tool.ConnectionString);
            SqlCommand cmd = new SqlCommand("OgrenciDerslerID", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", ID);

            SqlDataReader dr = null;

            try
            {
                cnn.Open();

                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dr.Read())
                {
                    ogders.ID = Convert.ToInt32(dr["ID"]);
                    ogders.OgrenciID = Convert.ToInt32(dr["OgrenciID"]);
                    ogders.DersID = Convert.ToInt32(dr["DersID"]);
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

            return ogders;

        }
    }
}
