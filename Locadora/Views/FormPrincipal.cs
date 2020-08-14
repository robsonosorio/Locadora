using Locadora.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.Views
{
    public partial class FormPrincipal : Form
    {
        DataBase db = new DataBase();

        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void Clear_TextBox()
        {
            clienteIdComboBox.Text = "";
            carroComboBox.Text = "";
        }
        private void CadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente form = new FormCliente();
            form.Show();
        }

        private void CadastrarModeloDeCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVeiculo form = new FormVeiculo();
            form.Show();
        }

        private void RelatórioDeLocaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorio form = new FormRelatorio();
            form.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            string sqlDataGrid = "SELECT lc.LocacaoId AS ID, ce.Nome, cr.Modelo, lc.DataRetirada, lc.DataDevolucao " +
                "FROM Locacao AS lc " +
                "INNER JOIN Cliente AS ce ON lc.ClienteId = ce.ClienteId " +
                "INNER JOIN Carro AS cr ON lc.CarroId = cr.CarroId ";
            locacaoDataGridView.DataSource = db.Consulta(sqlDataGrid);

            string sqlCliente = "SELECT ClienteId, Nome FROM Cliente ORDER BY Nome";
            clienteIdComboBox.DataSource = db.Consulta(sqlCliente);
            clienteIdComboBox.DisplayMember = "Nome";
            clienteIdComboBox.ValueMember = "ClienteId";

            string sqlCarro = "SELECT CarroId, Modelo FROM Carro ORDER BY Modelo";
            carroComboBox.DataSource = db.Consulta(sqlCarro);
            carroComboBox.DisplayMember = "Modelo";
            carroComboBox.ValueMember = "CarroId";

            Clear_TextBox();
        }

        private void LocacaoDataGridView_SelectionChanged(object sender, EventArgs e)
        { 
            clienteIdComboBox.Text = locacaoDataGridView.CurrentRow.Cells[1].Value.ToString();
            carroComboBox.Text = locacaoDataGridView.CurrentRow.Cells[2].Value.ToString();
            retiradaDateTimePicker.Text = locacaoDataGridView.CurrentRow.Cells[3].Value.ToString();
            devolucaoDateTimePicker.Text = locacaoDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                FormPrincipal_Load(sender, e);
                Clear_TextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorre erro" + ex.Message);
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Locacao locacao = new Locacao();
            try
            {
                locacao.ClienteId = int.Parse(clienteIdComboBox.SelectedValue.ToString());
                locacao.CarroId = int.Parse(carroComboBox.SelectedValue.ToString()); 
                locacao.DataRetirada = retiradaDateTimePicker.Value;
                locacao.DataDevolucao = devolucaoDateTimePicker.Value;

                locacao.Salvar(locacao);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro!" + ex.Message);
            }
            finally
            {
                FormPrincipal_Load(sender, e);
                Clear_TextBox();
            }
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            Locacao locacao = new Locacao();
            try
            {
                locacao.LocacaoId = int.Parse(locacaoDataGridView.CurrentRow.Cells[0].Value.ToString());
                locacao.ClienteId = int.Parse(clienteIdComboBox.SelectedValue.ToString());
                locacao.CarroId = int.Parse(carroComboBox.SelectedValue.ToString());
                locacao.DataRetirada = retiradaDateTimePicker.Value;
                locacao.DataDevolucao = devolucaoDateTimePicker.Value;

                locacao.Alterar(locacao);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
            }
            finally
            {
                FormPrincipal_Load(sender, e);
                Clear_TextBox();
            }
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            Locacao locacao = new Locacao();
            try
            {
                locacao.LocacaoId = int.Parse(locacaoDataGridView.CurrentRow.Cells[0].Value.ToString());

                locacao.Deletar(locacao); ;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorre erro: " + ex.Message);
            }
            finally
            {
                FormPrincipal_Load(sender, e);
                Clear_TextBox();
            }
        }
    }
}
