using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataLoad.Data {
    public class Connection {
        public void TestConnection () {



        }

        public IEnumerable<SqlParameter> GetParam () {

            var retorno = new List<SqlParameter> ();
            retorno.Add (new SqlParameter ("", ""));
            return retorno;

        }

    }
}