using System.Data.SqlClient;

namespace DataLoad.Data
{
    public class StringController : IController
    {
        public SqlConnection _SqlConnection =>  new SqlConnection();
    }
}