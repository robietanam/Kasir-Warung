using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PBO_Kasir.models
{
    public class userModel
    {
        SqlDBHelper objSqlDb = new SqlDBHelper();
        public userModel()
        {

        }
        public DataTable getLogin()
        {
            string query = "SELECT * FROM userLogin;";
            DataTable dt = objSqlDb.ExecuteQuery(query);
            return dt;
        }
        public void updateLogin(string nama_user, string password)
        {
            string query = @"update userLogin set nama_user = :nama::varchar(255),
                                password = :pass::varchar(255) 
                                where no_index = 1;";

            objSqlDb.ExecuteNonQuery(query,
                new NpgsqlParameter(":nama", nama_user),
                new NpgsqlParameter(":pass", password)
                );
        }
    }
    }
