namespace Locadora.Views.Cliente
{
    partial class FormVeiculo
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
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nomeLabel;
            this.valorDiariaTextBox = new System.Windows.Forms.TextBox();
            this.corTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.veiculoDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDiariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locadoraDataSet = new Locadora.LocadoraDataSet();
            this.CadastroVeiculo = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.veiculoTableAdapter = new Locadora.LocadoraDataSetTableAdapters.VeiculoTableAdapter();
            this.tableAdapterManager = new Locadora.LocadoraDataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locadoraDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneLabel.Location = new System.Drawing.Point(208, 91);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(86, 15);
            telefoneLabel.TabIndex = 53;
            telefoneLabel.Text = "Valor da Diária";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cPFLabel.Location = new System.Drawing.Point(208, 54);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(26, 15);
            cPFLabel.TabIndex = 51;
            cPFLabel.Text = "Cor";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(14, 90);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(49, 15);
            emailLabel.TabIndex = 49;
            emailLabel.Text = "Modelo";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(12, 54);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(41, 15);
            nomeLabel.TabIndex = 47;
            nomeLabel.Text = "Marca";
            // 
            // valorDiariaTextBox
            // 
            this.valorDiariaTextBox.Location = new System.Drawing.Point(300, 88);
            this.valorDiariaTextBox.Name = "valorDiariaTextBox";
            this.valorDiariaTextBox.Size = new System.Drawing.Size(125, 20);
            this.valorDiariaTextBox.TabIndex = 55;
            // 
            // corTextBox
            // 
            this.corTextBox.Location = new System.Drawing.Point(241, 52);
            this.corTextBox.Name = "corTextBox";
            this.corTextBox.Size = new System.Drawing.Size(125, 20);
            this.corTextBox.TabIndex = 54;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.Location = new System.Drawing.Point(69, 88);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(118, 20);
            this.modeloTextBox.TabIndex = 52;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.Location = new System.Drawing.Point(69, 54);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(118, 20);
            this.marcaTextBox.TabIndex = 50;
            // 
            // veiculoDataGridView
            // 
            this.veiculoDataGridView.AllowUserToAddRows = false;
            this.veiculoDataGridView.AllowUserToDeleteRows = false;
            this.veiculoDataGridView.AutoGenerateColumns = false;
            this.veiculoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veiculoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.valorDiariaDataGridViewTextBoxColumn});
            this.veiculoDataGridView.DataSource = this.veiculoBindingSource;
            this.veiculoDataGridView.Location = new System.Drawing.Point(17, 131);
            this.veiculoDataGridView.Name = "veiculoDataGridView";
            this.veiculoDataGridView.ReadOnly = true;
            this.veiculoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.veiculoDataGridView.Size = new System.Drawing.Size(541, 261);
            this.veiculoDataGridView.TabIndex = 48;
            this.veiculoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VeiculoDataGridView_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "Cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "Cor";
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            this.corDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDiariaDataGridViewTextBoxColumn
            // 
            this.valorDiariaDataGridViewTextBoxColumn.DataPropertyName = "ValorDiaria";
            this.valorDiariaDataGridViewTextBoxColumn.HeaderText = "ValorDiaria";
            this.valorDiariaDataGridViewTextBoxColumn.Name = "valorDiariaDataGridViewTextBoxColumn";
            this.valorDiariaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataMember = "Veiculo";
            this.veiculoBindingSource.DataSource = this.locadoraDataSet;
            // 
            // locadoraDataSet
            // 
            this.locadoraDataSet.DataSetName = "LocadoraDataSet";
            this.locadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CadastroVeiculo
            // 
            this.CadastroVeiculo.Location = new System.Drawing.Point(0, 0);
            this.CadastroVeiculo.Name = "CadastroVeiculo";
            this.CadastroVeiculo.Size = new System.Drawing.Size(100, 23);
            this.CadastroVeiculo.TabIndex = 56;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(575, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 49);
            this.button4.TabIndex = 45;
            this.button4.Text = "Deletar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Deletar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(575, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 49);
            this.button3.TabIndex = 44;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(575, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 49);
            this.button2.TabIndex = 43;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 49);
            this.button1.TabIndex = 42;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // veiculoTableAdapter
            // 
            this.veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Locadora.LocadoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VeiculoTableAdapter = this.veiculoTableAdapter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 30);
            this.label2.TabIndex = 57;
            this.label2.Text = "Cadastro de veiculos";
            // 
            // FormVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.valorDiariaTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.corTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(this.veiculoDataGridView);
            this.Controls.Add(this.CadastroVeiculo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormVeiculo";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veiculoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locadoraDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valorDiariaTextBox;
        private System.Windows.Forms.TextBox corTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.DataGridView veiculoDataGridView;
        private System.Windows.Forms.Label CadastroVeiculo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private LocadoraDataSet locadoraDataSet;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private LocadoraDataSetTableAdapters.VeiculoTableAdapter veiculoTableAdapter;
        private LocadoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDiariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}