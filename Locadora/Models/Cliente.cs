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
    class Cliente : DataBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }

        public Cliente()
        {
        }

        public void Salvar(Cliente Cliente)
        {
                conexao.Open();

                string inserir = "INSERT INTO Cliente(Nome, Email, CPF, Telefone) VALUES (@Nome, @Email, @CPF, @Telefone)";
                SqlCommand comando = new SqlCommand(inserir, conexao);

                comando.Parameters.Add(new SqlParameter("@Nome", cliente.Nome));
                comando.Parameters.Add(new SqlParameter("@Email", cliente.Email));
                comando.Parameters.Add(new SqlParameter("@CPF", cliente.CPF));
                comando.Parameters.Add(new SqlParameter("@Telefone", cliente.Telefone));

                comando.ExecuteNonQuery();
                conexao.Close();    
        }

        public void Alterar(Cliente cliente)
        {
            conexao.Open();

            string alterar = "UPDATE Cliente SET Nome=@Nome, Email=@Email, CPF=@CPF, Telefone=@Telefone WHERE Id=@Id";
            SqlCommand comando = new SqlCommand(alterar, conexao);

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
            conexao.Open();

            string deletar = "DELETE FROM Cliente WHERE Id =@Id";
            SqlCommand comando = new SqlCommand(deletar, conexao);

            comando.Parameters.Add(new SqlParameter("@Id", cliente.Id));

            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
