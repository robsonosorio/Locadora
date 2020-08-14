using System;
using System.Data;
using System.Data.SqlClient;

namespace Locadora.Models
{
    public class DataBase
    {
        public  SqlConnection conexao;
        public  SqlConnection ConexaoBanco()
        {
            string con = "Data Source=DESKTOP-M10J657;Initial Catalog=Locadora;Integrated Security=True";
            conexao = new SqlConnection(con);
            return conexao;
        }

        public  DataTable Consulta(String sql)
        {
            SqlDataAdapter adapta = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand()) {
                    cmd.CommandText = sql;
                    adapta = new SqlDataAdapter(cmd.CommandText, ConexaoBanco());
                    adapta.Fill(dt);
                    return dt;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
