using System.Data.SqlClient;

namespace DataLoad.Data
{
    public interface IController
    {
        SqlConnection _SqlConnection {get;}
    }
}