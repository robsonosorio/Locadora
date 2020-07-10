using Locadora.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Locadora
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'locadoraDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.locadoraDataSet.Cliente);

        }

        private void ClienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeTextBox.Text = clienteDataGridView.CurrentRow.Cells[1].Value.ToString();
            emailTextBox.Text = clienteDataGridView.CurrentRow.Cells[2].Value.ToString();
            cPFTextBox.Text = clienteDataGridView.CurrentRow.Cells[3].Value.ToString();
            telefoneTextBox.Text = clienteDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        public void Atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.Fill(this.locadoraDataSet.Cliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorre erro" + ex.Message);
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Nome = nomeTextBox.Text;
                cliente.Email = emailTextBox.Text;
                cliente.CPF = cPFTextBox.Text;
                cliente.Telefone = telefoneTextBox.Text;

                cliente.Salvar(cliente);    
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
            }
            finally
            {
                this.clienteTableAdapter.Fill(this.locadoraDataSet.Cliente);
                Limpa_TextBox();
            }
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            try
            {
                cliente.Id = int.Parse(clienteDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                cliente.Nome = nomeTextBox.Text;
                cliente.Email = emailTextBox.Text;
                cliente.CPF = cPFTextBox.Text;
                cliente.Telefone = telefoneTextBox.Text;

                cliente.Alterar(cliente);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
            }
            finally
            {
                this.clienteTableAdapter.Fill(this.locadoraDataSet.Cliente);
                Limpa_TextBox();
            }
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            try
            {
                cliente.Id = int.Parse(clienteDataGridView.SelectedRows[0].Cells[0].Value.ToString());

                cliente.Deletar(cliente);;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
            }
            finally
            {
                this.clienteTableAdapter.Fill(this.locadoraDataSet.Cliente);
                Limpa_TextBox();
            }
        }

        private void Limpa_TextBox()
        {
            nomeTextBox.Text = "";
            emailTextBox.Text = "";
            cPFTextBox.Text = "";
            telefoneTextBox.Text = "";
        }

    }
}
