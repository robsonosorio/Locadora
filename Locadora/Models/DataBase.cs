using System.Data.SqlClient;
using System.Data;

namespace Locadora.Models
{
    public class DataBase
    {
        public SqlConnection conexao;
        public DataBase()
        {
            string con = "Data Source=DESKTOP-M10J657;Initial Catalog=Locadora;Integrated Security=True";
            conexao = new SqlConnection(con);
        }
    }
}
