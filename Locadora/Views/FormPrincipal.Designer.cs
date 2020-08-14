namespace Locadora.Views
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label clienteLabel;
            System.Windows.Forms.Label retiradaLabel;
            System.Windows.Forms.Label carroLabel;
            System.Windows.Forms.Label deolucaoLabel;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarModeloDeCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeLocaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.locadoraDataSet = new Locadora.LocadoraDataSet();
            this.carroComboBox = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteIdComboBox = new System.Windows.Forms.ComboBox();
            this.locacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.retiradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.devolucaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            clienteLabel = new System.Windows.Forms.Label();
            retiradaLabel = new System.Windows.Forms.Label();
            carroLabel = new System.Windows.Forms.Label();
            deolucaoLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locadoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clienteLabel.Location = new System.Drawing.Point(12, 78);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(46, 15);
            clienteLabel.TabIndex = 56;
            clienteLabel.Text = "Cliente";
            // 
            // retiradaLabel
            // 
            retiradaLabel.AutoSize = true;
            retiradaLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            retiradaLabel.Location = new System.Drawing.Point(12, 117);
            retiradaLabel.Name = "retiradaLabel";
            retiradaLabel.Size = new System.Drawing.Size(54, 15);
            retiradaLabel.TabIndex = 58;
            retiradaLabel.Text = "Retirada";
            // 
            // carroLabel
            // 
            carroLabel.AutoSize = true;
            carroLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            carroLabel.Location = new System.Drawing.Point(240, 78);
            carroLabel.Name = "carroLabel";
            carroLabel.Size = new System.Drawing.Size(37, 15);
            carroLabel.TabIndex = 60;
            carroLabel.Text = "Carro";
            // 
            // deolucaoLabel
            // 
            deolucaoLabel.AutoSize = true;
            deolucaoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            deolucaoLabel.Location = new System.Drawing.Point(195, 117);
            deolucaoLabel.Name = "deolucaoLabel";
            deolucaoLabel.Size = new System.Drawing.Size(66, 15);
            deolucaoLabel.TabIndex = 62;
            deolucaoLabel.Text = "Devolução";
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
            this.menuStrip1.Size = new System.Drawing.Size(717, 24);
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
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.CadastrarClienteToolStripMenuItem_Click);
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
            this.cadastrarModeloDeCarroToolStripMenuItem.Click += new System.EventHandler(this.CadastrarModeloDeCarroToolStripMenuItem_Click);
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
            this.relatórioDeLocaçõesToolStripMenuItem.Click += new System.EventHandler(this.RelatórioDeLocaçõesToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 30);
            this.label2.TabIndex = 63;
            this.label2.Text = "Locação de veículo";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(581, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 49);
            this.button4.TabIndex = 8;
            this.button4.Text = "Deletar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Deletar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(581, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 49);
            this.button3.TabIndex = 7;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 49);
            this.button2.TabIndex = 6;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // locadoraDataSet
            // 
            this.locadoraDataSet.DataSetName = "LocadoraDataSet1";
            this.locadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carroComboBox
            // 
            this.carroComboBox.FormattingEnabled = true;
            this.carroComboBox.Location = new System.Drawing.Point(283, 76);
            this.carroComboBox.Name = "carroComboBox";
            this.carroComboBox.Size = new System.Drawing.Size(151, 21);
            this.carroComboBox.TabIndex = 2;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.locadoraDataSet;
            // 
            // locacaoBindingSource
            // 
            this.locacaoBindingSource.DataMember = "Locacao";
            this.locacaoBindingSource.DataSource = this.locadoraDataSet;
            // 
            // clienteIdComboBox
            // 
            this.clienteIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "ClienteId", true));
            this.clienteIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.locacaoBindingSource, "ClienteId", true));
            this.clienteIdComboBox.DataSource = this.clienteBindingSource;
            this.clienteIdComboBox.DisplayMember = "Nome";
            this.clienteIdComboBox.FormattingEnabled = true;
            this.clienteIdComboBox.Location = new System.Drawing.Point(64, 76);
            this.clienteIdComboBox.Name = "clienteIdComboBox";
            this.clienteIdComboBox.Size = new System.Drawing.Size(155, 21);
            this.clienteIdComboBox.TabIndex = 1;
            this.clienteIdComboBox.ValueMember = "ClienteId";
            // 
            // locacaoDataGridView
            // 
            this.locacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locacaoDataGridView.Location = new System.Drawing.Point(15, 158);
            this.locacaoDataGridView.Name = "locacaoDataGridView";
            this.locacaoDataGridView.Size = new System.Drawing.Size(551, 261);
            this.locacaoDataGridView.TabIndex = 10;
            this.locacaoDataGridView.SelectionChanged += new System.EventHandler(this.LocacaoDataGridView_SelectionChanged);
            // 
            // retiradaDateTimePicker
            // 
            this.retiradaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.retiradaDateTimePicker.Location = new System.Drawing.Point(72, 117);
            this.retiradaDateTimePicker.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.retiradaDateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.retiradaDateTimePicker.Name = "retiradaDateTimePicker";
            this.retiradaDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.retiradaDateTimePicker.TabIndex = 3;
            // 
            // devolucaoDateTimePicker
            // 
            this.devolucaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.devolucaoDateTimePicker.Location = new System.Drawing.Point(267, 117);
            this.devolucaoDateTimePicker.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.devolucaoDateTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.devolucaoDateTimePicker.Name = "devolucaoDateTimePicker";
            this.devolucaoDateTimePicker.Size = new System.Drawing.Size(102, 20);
            this.devolucaoDateTimePicker.TabIndex = 4;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 439);
            this.Controls.Add(this.devolucaoDateTimePicker);
            this.Controls.Add(this.retiradaDateTimePicker);
            this.Controls.Add(this.clienteIdComboBox);
            this.Controls.Add(this.locacaoDataGridView);
            this.Controls.Add(this.carroComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(deolucaoLabel);
            this.Controls.Add(carroLabel);
            this.Controls.Add(retiradaLabel);
            this.Controls.Add(clienteLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormPrincipal";
            this.Text = ".: Locação";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locadoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarModeloDeCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeLocaçõesToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private LocadoraDataSet locadoraDataSet;
        private System.Windows.Forms.ComboBox carroComboBox;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource locacaoBindingSource;
        private System.Windows.Forms.ComboBox clienteIdComboBox;
        private System.Windows.Forms.DataGridView locacaoDataGridView;
        private System.Windows.Forms.DateTimePicker retiradaDateTimePicker;
        private System.Windows.Forms.DateTimePicker devolucaoDateTimePicker;
    }
}