using System.Data.SqlClient;


namespace Locadora.Models
{
    public class Cliente : DataBase
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }

        public Cliente()
        {
        }

        public void Salvar(Cliente cliente)
        {
            string sqlInserir = "INSERT INTO Cliente(Nome, Email, CPF, Telefone) VALUES (@Nome, @Email, @CPF, @Telefone)";

            ConexaoBanco().Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@Nome", cliente.Nome));
            comando.Parameters.Add(new SqlParameter("@Email", cliente.Email));
            comando.Parameters.Add(new SqlParameter("@CPF", cliente.CPF));
            comando.Parameters.Add(new SqlParameter("@Telefone", cliente.Telefone));

            comando.ExecuteNonQuery();
            ConexaoBanco().Close();
        }

        public void Alterar(Cliente cliente)
        {
            string sqlInserir = "UPDATE Cliente SET Nome=@Nome, Email=@Email, CPF=@CPF, Telefone=@Telefone WHERE ClienteId=@ClienteId";

            ConexaoBanco().Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@ClienteId", cliente.ClienteId));
            comando.Parameters.Add(new SqlParameter("@Nome", cliente.Nome));
            comando.Parameters.Add(new SqlParameter("@Email", cliente.Email));
            comando.Parameters.Add(new SqlParameter("@CPF", cliente.CPF));
            comando.Parameters.Add(new SqlParameter("@Telefone", cliente.Telefone));

            comando.ExecuteNonQuery();
            ConexaoBanco().Close();
        }

        public void Deletar(Cliente cliente)
        {
            string sqlInserir = "DELETE FROM Cliente WHERE ClienteId =@ClienteId";
            ConexaoBanco().Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@ClienteId", cliente.ClienteId));

            comando.ExecuteNonQuery();
            ConexaoBanco().Close();
        }
    }
}
