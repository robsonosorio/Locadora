using System.Data.SqlClient;


namespace Locadora.Models
{
    class Veiculo : DataBase
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public double ValorDiaria { get; set; }

        public void Salvar(Veiculo veiculo)
        {
            string sqlInserir = "INSERT INTO Veiculo(Marca, Modelo, Cor, ValorDiaria) VALUES (@Marca, @Modelo, @Cor, @ValorDiaria)";

            conexao.Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@Marca", veiculo.Marca));
            comando.Parameters.Add(new SqlParameter("@Modelo", veiculo.Modelo));
            comando.Parameters.Add(new SqlParameter("@Cor", veiculo.Cor));
            comando.Parameters.Add(new SqlParameter("@ValorDiaria", veiculo.ValorDiaria));

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Alterar(Veiculo veiculo)
        {

            string sqlInserir = "UPDATE Veiculo SET Marca=@Marca, Modelo=@Modelo, Cor=@Cor, ValorDiaria=@ValorDiaria WHERE Id=@Id";

            conexao.Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@Id", veiculo.Id));
            comando.Parameters.Add(new SqlParameter("@Marca", veiculo.Marca));
            comando.Parameters.Add(new SqlParameter("@Modelo", veiculo.Modelo));
            comando.Parameters.Add(new SqlParameter("@Cor", veiculo.Cor));
            comando.Parameters.Add(new SqlParameter("@ValorDiaria", veiculo.ValorDiaria));

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Deletar(Veiculo veiculo)
        {
            string sqlInserir = "DELETE FROM Veiculo WHERE Id=@Id";
            conexao.Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@Id", veiculo.Id));

            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
