using System.Data.SqlClient;


namespace Locadora.Models
{
    public class Carro : DataBase
    {
        public int CarroId { get; set; }
        public int MarcaId { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public double ValorDiaria { get; set; }

        public void Salvar(Carro carro)
        {
            string sqlInserir = "INSERT INTO Carro(MarcaId, Modelo, Cor, ValorDiaria) VALUES (@MarcaId, @Modelo, @Cor, @ValorDiaria)";

            ConexaoBanco().Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@MarcaId", carro.MarcaId));
            comando.Parameters.Add(new SqlParameter("@Modelo", carro.Modelo));
            comando.Parameters.Add(new SqlParameter("@Cor", carro.Cor));
            comando.Parameters.Add(new SqlParameter("@ValorDiaria", carro.ValorDiaria));

            comando.ExecuteNonQuery();
            ConexaoBanco().Close();
        }

        public void Alterar(Carro carro)
        {
            string sqlInserir = "UPDATE Carro SET  MarcaId=@MarcaId, Modelo=@Modelo, Cor=@Cor, ValorDiaria=@ValorDiaria WHERE CarroId=@CarroId";

            ConexaoBanco().Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@CarroId", carro.CarroId));
            comando.Parameters.Add(new SqlParameter("@MarcaId", carro.MarcaId));
            comando.Parameters.Add(new SqlParameter("@Modelo", carro.Modelo));
            comando.Parameters.Add(new SqlParameter("@Cor", carro.Cor));
            comando.Parameters.Add(new SqlParameter("@ValorDiaria", carro.ValorDiaria));

            comando.ExecuteNonQuery();
            ConexaoBanco().Close();
        }

        public void Deletar(Carro carro)
        {
            string sqlInserir = "DELETE FROM Carro WHERE CarroId=@CarroId";
            ConexaoBanco().Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@CarroId", carro.CarroId));

            comando.ExecuteNonQuery();
            ConexaoBanco().Close();
        }
    }
}
