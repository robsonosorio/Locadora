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
                this.clienteTableAdapter.Fill(this.locadoraDataSet.Cliente);
                Limpa_TextBox();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
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

                this.clienteTableAdapter.Fill(this.locadoraDataSet.Cliente);

                Limpa_TextBox();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
            }
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            try
            {
                cliente.Id = int.Parse(clienteDataGridView.SelectedRows[0].Cells[0].Value.ToString());

                cliente.Deletar(cliente);

                this.clienteTableAdapter.Fill(this.locadoraDataSet.Cliente);

                Limpa_TextBox();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
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
