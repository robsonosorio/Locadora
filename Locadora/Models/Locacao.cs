using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Models
{
    public class Locacao : DataBase
    {
        public int LocacaoId { get; set; }
        public int ClienteId { get; set; }
        public int CarroId { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }

        public Locacao()
        {
        }

        public void Salvar(Locacao locacao)
        {
            string sqlInserir = "INSERT INTO Locacao(ClienteId, CarroId, DataRetirada, DataDevolucao) VALUES (@ClienteId, @CarroId, @DataRetirada, @DataDevolucao)";

            ConexaoBanco().Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@ClienteId", locacao.ClienteId));
            comando.Parameters.Add(new SqlParameter("@CarroId", locacao.CarroId));
            comando.Parameters.Add(new SqlParameter("@DataRetirada", locacao.DataRetirada));
            comando.Parameters.Add(new SqlParameter("@DataDevolucao", locacao.DataDevolucao));

            comando.ExecuteNonQuery();
            ConexaoBanco().Close();
        }

        public void Alterar(Locacao locacao)
        {
            string sqlInserir = "UPDATE Locacao SET ClienteId=@ClienteId, CarroId=@CarroId, DataRetirada=@DataRetirada, DataDevolucao=@DataDevolucao WHERE LocacaoId=@LocacaoId";

            ConexaoBanco().Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@LocacaoId", locacao.LocacaoId));
            comando.Parameters.Add(new SqlParameter("@ClienteId", locacao.ClienteId));
            comando.Parameters.Add(new SqlParameter("@CarroId", locacao.CarroId));
            comando.Parameters.Add(new SqlParameter("@DataRetirada", locacao.DataRetirada));
            comando.Parameters.Add(new SqlParameter("@DataDevolucao", locacao.DataDevolucao));

            comando.ExecuteNonQuery();
            ConexaoBanco().Close();
        }

        public void Deletar(Locacao locacao)
        {
            string sqlInserir = "DELETE FROM Locacao WHERE LocacaoId=@LocacaoId";

            ConexaoBanco().Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@LocacaoId", locacao.LocacaoId));

            comando.ExecuteNonQuery();
            ConexaoBanco().Close();
        }
    }
}
