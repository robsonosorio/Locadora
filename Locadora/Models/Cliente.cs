using System;
using Locadora.LocadoraDataSetTableAdapters;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locadora.Repositorio;

namespace Locadora.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }

        public Cliente()
        {
        }

        // teste // criar propriedades e metodos de leitura de dados????
        
        public void Atualizar()
        {
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

            string sqlInserir = "SELECT * FROM Cliente";
            clienteRepositorio.Atualizar(sqlInserir);
           
        }

        public void Salvar()
        {
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

            string sqlInserir = "INSERT INTO Cliente(Nome, Email, CPF, Telefone) VALUES (@Nome, @Email, @CPF, @Telefone)";
            clienteRepositorio.Salvar(sqlInserir);
        }

        public void Alterar()
        {
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

            string sqlInserir = "UPDATE Cliente SET Nome=@Nome, Email=@Email, CPF=@CPF, Telefone=@Telefone WHERE Id=@Id";
            clienteRepositorio.Alterar(sqlInserir);
        }

        public void Deletar( )
        {
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio();

            string sqlInserir = "DELETE FROM Cliente WHERE Id =@Id";
            clienteRepositorio.Deletar(sqlInserir);
        }

    }
}
