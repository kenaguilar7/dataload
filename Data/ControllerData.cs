using System;
using System.Linq; 
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataLoad.Data {

    public class ControllerData {

        private SqlConnection _controller { get; set; }

        public ControllerData () {
            _controller = new SqlConnection("");
        }

        public int Ejecutar (String sqlString, CommandType type, IEnumerable<Parametro> lst) {

            using (SqlConnection connection = _controller)
            using (SqlCommand command = new SqlCommand (sqlString, connection)) {

                connection.Open ();

                try {

                    foreach (var item in lst) {
                        command.Parameters.AddWithValue (item.nombre, item.valor);
                    }

                    var retorno = command.ExecuteNonQuery ();
                    // tr.Commit ();
                    return retorno;

                } catch (Exception ex) {
                    var toSave = from l in lst select new { value = l.valor.ToString()}; 
                    LogWriter log = new LogWriter ($"SqlError:{string.Join(",",toSave)}");
                    throw ex;
                }
            
            }

        }

        public int Ejecutar (String sqlString, CommandType type, Parametro parametro) {
            return Ejecutar (sqlString, type, new List<Parametro> { parametro });
        }

        public bool ReadTable () {
            var retorno = false;

            using (SqlConnection connection = _controller) {

                using (SqlCommand cmd = new SqlCommand ("SELECT TOP 1 * FROM OITM", connection)) {
                    connection.Open ();
                    using (SqlDataReader dr = cmd.ExecuteReader ()) // or load a DataTable, ExecuteScalar, etc.    
                    {
                        while (dr.Read ()) {
                            // Console.WriteLine(dr.FieldCount); 
                        }
                    }

                    return retorno;
                }
            }
        }

        public bool IsServerConnected () {
            using (SqlConnection connection = _controller) {
                try {
                    connection.Open ();
                    return true;
                } catch (SqlException) {
                    return false;
                }
            }
        }

    }

}