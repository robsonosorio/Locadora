using System.Data.SqlClient;


namespace Locadora.Models
{
    class Carro : DataBase
    {
        public int CarroId { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public double ValorDiaria { get; set; }

        public void Salvar(Carro carro)
        {
            string sqlInserir = "INSERT INTO Veiculo(Marca, Modelo, Cor, ValorDiaria) VALUES (@Marca, @Modelo, @Cor, @ValorDiaria)";

            conexao.Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@Marca", carro.Marca));
            comando.Parameters.Add(new SqlParameter("@Modelo", carro.Modelo));
            comando.Parameters.Add(new SqlParameter("@Cor", carro.Cor));
            comando.Parameters.Add(new SqlParameter("@ValorDiaria", carro.ValorDiaria));

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Alterar(Carro carro)
        {

            string sqlInserir = "UPDATE Veiculo SET Marca=@Marca, Modelo=@Modelo, Cor=@Cor, ValorDiaria=@ValorDiaria WHERE Id=@Id";

            conexao.Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@Id", carro.CarroId));
            comando.Parameters.Add(new SqlParameter("@Marca", carro.Marca));
            comando.Parameters.Add(new SqlParameter("@Modelo", carro.Modelo));
            comando.Parameters.Add(new SqlParameter("@Cor", carro.Cor));
            comando.Parameters.Add(new SqlParameter("@ValorDiaria", carro.ValorDiaria));

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Deletar(Carro carro)
        {
            string sqlInserir = "DELETE FROM Veiculo WHERE Id=@Id";
            conexao.Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@Id", carro.CarroId));

            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
