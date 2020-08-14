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
    public partial class FormRelatorio : Form
    {
        DataBase db = new DataBase();

        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {          
            string sqlDataGrid = "SELECT lc.LocacaoId AS ID, ce.Nome, mc.Marca, cr.Modelo, lc.DataRetirada, lc.DataRetirada " +
                "FROM Locacao AS lc " +
                "INNER JOIN Cliente AS ce ON lc.ClienteId = ce.ClienteId " +
                "INNER JOIN Carro AS cr ON lc.CarroId = cr.CarroId " +
                "INNER JOIN MarcaCarro AS mc ON mc.MarcaId = cr.MarcaId";         
            RelatorioDataGridView.DataSource = db.Consulta(sqlDataGrid);
        }
    }
}
