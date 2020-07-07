using Locadora.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Locadora
{
    public partial class FormCliente : Form
    {
       
        public FormCliente()
        {
            InitializeComponent();
           
        }

        private void Limpa_TextBox()
        {
            nomeTextBox.Text = "";
            emailTextBox.Text = "";
            cPFTextBox.Text = "";
            telefoneTextBox.Text = "";
        }
        private void ClienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeTextBox.Text = clienteDataGridView.CurrentRow.Cells[1].Value.ToString();
            emailTextBox.Text = clienteDataGridView.CurrentRow.Cells[2].Value.ToString();
            cPFTextBox.Text = clienteDataGridView.CurrentRow.Cells[3].Value.ToString();
            telefoneTextBox.Text = clienteDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'locadoraDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.locadoraDataSet.Cliente);

        }

        public void Atualizar_Click(object sender, EventArgs e)
        {
            Limpa_TextBox();

            SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-M10J657;Initial Catalog=Locadora;Integrated Security=True");
            SqlCommand comando = new SqlCommand("SELECT * FROM Cliente", conexao);
            try
            {
                SqlDataAdapter adapta = new SqlDataAdapter();
                DataSet dataSet = new DataSet();
                adapta.SelectCommand = comando;
                adapta.Fill(dataSet);
                clienteDataGridView.DataSource = dataSet;
                clienteDataGridView.DataMember = dataSet.Tables[0].TableName;
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.CPF = cPFTextBox.Text;
            cliente.Telefone = telefoneTextBox.Text;

            cliente.Salvar(cliente);

            Atualizar_Click(sender, e);
            Limpa_TextBox();
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Id = int.Parse(clienteDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.CPF = cPFTextBox.Text;
            cliente.Telefone = telefoneTextBox.Text;

            cliente.Alterar(cliente);

            Atualizar_Click(sender, e);
            Limpa_TextBox();
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Id = int.Parse(clienteDataGridView.SelectedRows[0].Cells[0].Value.ToString());

            cliente.Deletar(cliente);

            Atualizar_Click(sender, e);

            Limpa_TextBox();
        }
    }
}
    