using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataLoad.Data {

    public class ControllerData {

        private IController _controller { get; set; }

        public ControllerData () {
            _controller = new StringController ();
        }
        public int Ejecutar (String sqlString, List<Parametro> lst, CommandType type) {

            var retorno = 0;

            using (SqlConnection connection = _controller._SqlConnection)
            using (SqlTransaction tr = connection.BeginTransaction (IsolationLevel.Serializable)) {

                try {

                    SqlCommand command = new SqlCommand (sqlString, connection, tr);

                    foreach (var item in lst) {
                        command.Parameters.AddWithValue (item.nombre, item.valor);
                    }

                    retorno = command.ExecuteNonQuery ();
                    tr.Commit ();

                } catch (Exception ex) {
                    tr.Rollback ();
                    throw ex;
                }
            }

            return retorno;
        }

    }

}