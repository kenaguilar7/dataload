using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataLoad.Data {
    public class Connection {
        public void TestConnection () {

            Console.WriteLine ("Getting Connection ...");

            var datasource = @"DESKTOP-PC\SQLEXPRESS"; //your server
            var database = "Students"; //your database name
            var username = "sa"; //username of server to connect
            var password = "password"; //password

            //your connection string 
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            var sql = "select * from ";
            //create instanace of database connection
            using (SqlConnection connection = new SqlConnection (connString)) {
                SqlCommand command = new SqlCommand (sql, connection);

                command.Parameters.AddWithValue ("@dsd", 5);

                foreach (var item in GetParam ()) {
                    command.Parameters.Add (item);
                }

                command.Connection.Open ();
                command.ExecuteNonQuery ();
            }
        }

        public IEnumerable<SqlParameter> GetParam () {

            var retorno = new List<SqlParameter> ();
            retorno.Add (new SqlParameter ("", ""));
            return retorno;

        }

    }
}