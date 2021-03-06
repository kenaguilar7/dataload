using System;
using System.Linq; 
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataLoad.Data {

    public class ControllerData {

        private SqlConnection _controller { get; set; }

        public ControllerData () {
            _controller = new SqlConnection();
        }

        public void Ejecutar (String sqlString, CommandType type, IEnumerable<Parametro> lst) {
            
            using (SqlConnection connection = _controller)
            using (SqlCommand command = new SqlCommand (sqlString, connection)) {

                connection.Open ();

                try {

                    foreach (var item in lst) {
                        command.Parameters.AddWithValue (item.nombre, item.valor);
                    }

                    if(command.ExecuteNonQuery() == 0){
                        throw new Exception(); 
                    }else{
                        Console.WriteLine("--");
                    }

                } catch (Exception) {
                    var toSave = from l in lst select l.valor.ToString(); 
                    LogWriter log = new LogWriter ($"SqlError:{string.Join(",",toSave)}");
                }
            
            }

        }

        public void Ejecutar (String sqlString, CommandType type, Parametro parametro) {
             Ejecutar (sqlString, type, new List<Parametro> { parametro });
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