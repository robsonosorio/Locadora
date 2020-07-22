namespace Locadora.Views
{
    partial class FormRelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.locadoraDataSet1 = new Locadora.LocadoraDataSet();
            this.RelatorioDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarModeloDeCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeLocaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.locadoraDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // locadoraDataSet1
            // 
            this.locadoraDataSet1.DataSetName = "LocadoraDataSet";
            this.locadoraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RelatorioDataGridView
            // 
            this.RelatorioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RelatorioDataGridView.Location = new System.Drawing.Point(9, 65);
            this.RelatorioDataGridView.Name = "RelatorioDataGridView";
            this.RelatorioDataGridView.Size = new System.Drawing.Size(655, 325);
            this.RelatorioDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relatório de locações";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.veiculoToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar cliente";
            // 
            // veiculoToolStripMenuItem
            // 
            this.veiculoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarModeloDeCarroToolStripMenuItem});
            this.veiculoToolStripMenuItem.Name = "veiculoToolStripMenuItem";
            this.veiculoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.veiculoToolStripMenuItem.Text = "Veiculo";
            // 
            // cadastrarModeloDeCarroToolStripMenuItem
            // 
            this.cadastrarModeloDeCarroToolStripMenuItem.Name = "cadastrarModeloDeCarroToolStripMenuItem";
            this.cadastrarModeloDeCarroToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.cadastrarModeloDeCarroToolStripMenuItem.Text = "Cadastrar modelo de carro";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDeLocaçõesToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relatórioDeLocaçõesToolStripMenuItem
            // 
            this.relatórioDeLocaçõesToolStripMenuItem.Name = "relatórioDeLocaçõesToolStripMenuItem";
            this.relatórioDeLocaçõesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.relatórioDeLocaçõesToolStripMenuItem.Text = "Relatório de locações";
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 398);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RelatorioDataGridView);
            this.Name = "FormRelatorio";
            this.Text = ".: Relatório de locações";
            this.Load += new System.EventHandler(this.FormRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locadoraDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LocadoraDataSet locadoraDataSet1;
        private System.Windows.Forms.DataGridView RelatorioDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarModeloDeCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeLocaçõesToolStripMenuItem;
    }
}