using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using SiliconPowerInc.Models;

namespace SiliconPowerInc.Services
{
    class BDConection
    {
        
        private SqlCommand cmd;
        private String strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SiliconPowerB" +
            "D.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection conn;

        public BDConection()
        {
            conn = new SqlConnection(strConn);
        }

        public void BdInsert(string Procedure, BD_GenericDataStorageDM data)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(Procedure, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                
                if (data.Integers != null)
                {
                    foreach (var pair in data.Integers)
                    {
                        cmd.Parameters.AddWithValue(pair.Item1, pair.Item2);
                    }
                }
                if (data.Strings != null)
                {
                    foreach (var pair in data.Strings)
                    {
                        cmd.Parameters.AddWithValue(pair.Item1, pair.Item2);
                    }
                }
                if (data.DateTimes != null)
                {
                    foreach (var pair in data.DateTimes)
                    {
                        cmd.Parameters.AddWithValue(pair.Item1, pair.Item2);
                    }
                }
                if (data.Decimals != null)
                {
                    foreach (var pair in data.Decimals)
                    {
                        cmd.Parameters.AddWithValue(pair.Item1, pair.Item2);
                    }
                }

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable BdGet(string Procedure, BD_GenericDataStorageDM data)
        {
            try
            {
                DataSet dataset;
                SqlDataAdapter dataadapter;

                conn.Open();
                cmd = new SqlCommand(Procedure, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                if(data.Integers != null)
                {
                    foreach (var pair in data.Integers)
                    {
                        cmd.Parameters.AddWithValue(pair.Item1, pair.Item2);
                    }
                }
                if (data.Strings != null)
                {
                    foreach (var pair in data.Strings)
                    {
                        cmd.Parameters.AddWithValue(pair.Item1, pair.Item2);
                    }
                }
                if (data.DateTimes != null)
                {
                    foreach (var pair in data.DateTimes)
                    {
                        cmd.Parameters.AddWithValue(pair.Item1, pair.Item2);
                    }
                }
                if (data.DateTimes != null)
                {
                    foreach (var pair in data.DateTimes)
                    {
                        cmd.Parameters.AddWithValue(pair.Item1, pair.Item2);
                    }
                }

                dataset = new DataSet();
                dataadapter = new SqlDataAdapter(cmd);
                dataadapter.Fill(dataset);

                return dataset.Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}