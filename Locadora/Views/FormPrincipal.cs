using Locadora.Views.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora.Views
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
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
    }
}
