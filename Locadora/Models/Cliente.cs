using System;
using Locadora.LocadoraDataSetTableAdapters;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Locadora.Models
{
    public class Cliente : DataBase
    {
        public int Id { get; set; }
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
          
            conexao.Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@Nome", cliente.Nome));
            comando.Parameters.Add(new SqlParameter("@Email", cliente.Email));
            comando.Parameters.Add(new SqlParameter("@CPF", cliente.CPF));
            comando.Parameters.Add(new SqlParameter("@Telefone", cliente.Telefone));

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Alterar(Cliente cliente)
        {
            string sqlInserir = "UPDATE Cliente SET Nome=@Nome, Email=@Email, CPF=@CPF, Telefone=@Telefone WHERE Id=@Id";
           
            conexao.Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@Id", cliente.Id));
            comando.Parameters.Add(new SqlParameter("@Nome", cliente.Nome));
            comando.Parameters.Add(new SqlParameter("@Email", cliente.Email));
            comando.Parameters.Add(new SqlParameter("@CPF", cliente.CPF));
            comando.Parameters.Add(new SqlParameter("@Telefone", cliente.Telefone));

            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Deletar(Cliente cliente)
        {
            string sqlInserir = "DELETE FROM Cliente WHERE Id =@Id";
            conexao.Open();
            SqlCommand comando = new SqlCommand(sqlInserir, conexao);

            comando.Parameters.Add(new SqlParameter("@Id", cliente.Id));

            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
