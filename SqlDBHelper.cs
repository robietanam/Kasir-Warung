using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace PBO_Kasir
{
    public class SqlDBHelper
    {
        private NpgsqlConnection connection;
        public SqlDBHelper()
        {
            connection = new NpgsqlConnection();
            connection.ConnectionString = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=Kasir_PBO;CommandTimeout=10";
            // ConfigurationManager.ConnectionStrings["constr"].ToString();
            
        }

        public DataTable ExecuteQuery(string sql)
        {
            DataTable dt = new DataTable();
            if (connection.State != ConnectionState.Open)
            {
                //
            }
            else
            {
                connection.Close();
            }
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = sql; // "select * from users.person";
            cmd.CommandType = CommandType.Text;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

            da.Fill(dt);
            cmd.Dispose();
            connection.Close();

            return dt;
        }


        public DataTable ExecuteQuery(string sql, params NpgsqlParameter[] parameters)
        {
            DataSet ds = new DataSet();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
            foreach (var item in parameters)
            {
                cmd.Parameters.Add(item);
            }

            try
            {
                cmd.Connection.Open();
                new NpgsqlDataAdapter(cmd).Fill(ds);
                cmd.Connection.Close();
            }
            catch (NpgsqlException ex)
            {
                //Show a message or log a message on ex.Message
            }
            return ds.Tables[0];
        }

        public void ExecuteQuery(ref DataTable dt, string sql)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = sql; // "select * from users.person";
                cmd.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

                da.Fill(dt);
                cmd.Dispose();
                connection.Close();
            }
            catch (Exception ex) { }
        }


        public void ExecuteNonQuery(string sql, params NpgsqlParameter[] parameters)
        {
            
            DataSet ds = new DataSet();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
            foreach (var item in parameters)
            {
                cmd.Parameters.Add(item);
            }
            if (connection.State != ConnectionState.Open)
            {
                //
            }
            else
            {
                connection.Close();
            }
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Connection.Close();
            

        }

        public void ExecuteNonQuery(string query)
        {

            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            connection.Close();


        }

    }
}