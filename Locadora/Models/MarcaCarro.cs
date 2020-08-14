using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Models
{
    public class MarcaCarro : DataBase
    {
        public int MarcaId { get; set; }
        public string Marca { get; set; }

        public MarcaCarro()
        {
        }

        public void Salvar(MarcaCarro marcaCarro)
        {
            string sqlInserir = "INSERT INTO MarcaCarro(Marca) VALUES (@Marca)";

            ConexaoBanco().Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@Marca", marcaCarro.Marca));

            comando.ExecuteNonQuery();
            ConexaoBanco().Close();
        }
    }
}
