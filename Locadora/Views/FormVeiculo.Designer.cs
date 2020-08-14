namespace Locadora.Views
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
            System.Windows.Forms.Label label1;
            this.valorDiariaTextBox = new System.Windows.Forms.TextBox();
            this.corTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.carroDataGridView = new System.Windows.Forms.DataGridView();
            this.CadastroVeiculo = new System.Windows.Forms.Label();
            this.deletarButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.atualizarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MarcaComboBox = new System.Windows.Forms.ComboBox();
            this.marcaCarroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locadoraDataSet1 = new Locadora.LocadoraDataSet();
            this.marcaCarroTableAdapter = new Locadora.LocadoraDataSet1TableAdapters.MarcaCarroTableAdapter();
            this.tableAdapterManager = new Locadora.LocadoraDataSet1TableAdapters.TableAdapterManager();
            this.cadastraMarcaTextBox = new System.Windows.Forms.TextBox();
            this.salvarMarcaButton = new System.Windows.Forms.Button();
            telefoneLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carroDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaCarroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locadoraDataSet1)).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(530, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 15);
            label1.TabIndex = 58;
            label1.Text = "Cadastrar Marca";
            // 
            // valorDiariaTextBox
            // 
            this.valorDiariaTextBox.Location = new System.Drawing.Point(300, 88);
            this.valorDiariaTextBox.Name = "valorDiariaTextBox";
            this.valorDiariaTextBox.Size = new System.Drawing.Size(125, 20);
            this.valorDiariaTextBox.TabIndex = 4;
            // 
            // corTextBox
            // 
            this.corTextBox.Location = new System.Drawing.Point(241, 52);
            this.corTextBox.Name = "corTextBox";
            this.corTextBox.Size = new System.Drawing.Size(125, 20);
            this.corTextBox.TabIndex = 3;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.Location = new System.Drawing.Point(69, 88);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(118, 20);
            this.modeloTextBox.TabIndex = 2;
            // 
            // carroDataGridView
            // 
            this.carroDataGridView.AllowUserToAddRows = false;
            this.carroDataGridView.AllowUserToDeleteRows = false;
            this.carroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carroDataGridView.Location = new System.Drawing.Point(17, 131);
            this.carroDataGridView.Name = "carroDataGridView";
            this.carroDataGridView.ReadOnly = true;
            this.carroDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carroDataGridView.Size = new System.Drawing.Size(541, 261);
            this.carroDataGridView.TabIndex = 9;
            this.carroDataGridView.SelectionChanged += new System.EventHandler(this.CarroDataGridView_SelectionChanged);
            // 
            // CadastroVeiculo
            // 
            this.CadastroVeiculo.Location = new System.Drawing.Point(0, 0);
            this.CadastroVeiculo.Name = "CadastroVeiculo";
            this.CadastroVeiculo.Size = new System.Drawing.Size(100, 23);
            this.CadastroVeiculo.TabIndex = 56;
            // 
            // deletarButton
            // 
            this.deletarButton.Location = new System.Drawing.Point(575, 342);
            this.deletarButton.Name = "deletarButton";
            this.deletarButton.Size = new System.Drawing.Size(122, 49);
            this.deletarButton.TabIndex = 8;
            this.deletarButton.Text = "Deletar";
            this.deletarButton.UseVisualStyleBackColor = true;
            this.deletarButton.Click += new System.EventHandler(this.DeletarButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(575, 272);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(122, 49);
            this.alterarButton.TabIndex = 7;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.AlterarButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(575, 201);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(122, 49);
            this.salvarButton.TabIndex = 6;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // atualizarButton
            // 
            this.atualizarButton.Location = new System.Drawing.Point(575, 130);
            this.atualizarButton.Name = "atualizarButton";
            this.atualizarButton.Size = new System.Drawing.Size(122, 49);
            this.atualizarButton.TabIndex = 5;
            this.atualizarButton.Text = "Atualizar";
            this.atualizarButton.UseVisualStyleBackColor = true;
            this.atualizarButton.Click += new System.EventHandler(this.AtualizarButton_Click);
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
            // MarcaComboBox
            // 
            this.MarcaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marcaCarroBindingSource, "Marca", true));
            this.MarcaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarcaComboBox.FormattingEnabled = true;
            this.MarcaComboBox.Location = new System.Drawing.Point(69, 51);
            this.MarcaComboBox.Name = "MarcaComboBox";
            this.MarcaComboBox.Size = new System.Drawing.Size(118, 21);
            this.MarcaComboBox.TabIndex = 1;
            // 
            // marcaCarroBindingSource
            // 
            this.marcaCarroBindingSource.DataMember = "MarcaCarro";
            this.marcaCarroBindingSource.DataSource = this.locadoraDataSet1;
            // 
            // locadoraDataSet1
            // 
            this.locadoraDataSet1.DataSetName = "LocadoraDataSet1";
            this.locadoraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcaCarroTableAdapter
            // 
            this.marcaCarroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarroTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.LocacaoTableAdapter = null;
            this.tableAdapterManager.MarcaCarroTableAdapter = this.marcaCarroTableAdapter;
            this.tableAdapterManager.UpdateOrder = Locadora.LocadoraDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cadastraMarcaTextBox
            // 
            this.cadastraMarcaTextBox.Location = new System.Drawing.Point(533, 42);
            this.cadastraMarcaTextBox.Name = "cadastraMarcaTextBox";
            this.cadastraMarcaTextBox.Size = new System.Drawing.Size(93, 20);
            this.cadastraMarcaTextBox.TabIndex = 59;
            // 
            // salvarMarcaButton
            // 
            this.salvarMarcaButton.Location = new System.Drawing.Point(632, 39);
            this.salvarMarcaButton.Name = "salvarMarcaButton";
            this.salvarMarcaButton.Size = new System.Drawing.Size(40, 23);
            this.salvarMarcaButton.TabIndex = 60;
            this.salvarMarcaButton.Text = "ADD";
            this.salvarMarcaButton.UseVisualStyleBackColor = true;
            this.salvarMarcaButton.Click += new System.EventHandler(this.SalvarMarcaButton_Click);
            // 
            // FormVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 402);
            this.Controls.Add(this.salvarMarcaButton);
            this.Controls.Add(this.cadastraMarcaTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.MarcaComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.valorDiariaTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.corTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.carroDataGridView);
            this.Controls.Add(this.CadastroVeiculo);
            this.Controls.Add(this.deletarButton);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.atualizarButton);
            this.Name = "FormVeiculo";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carroDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaCarroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locadoraDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valorDiariaTextBox;
        private System.Windows.Forms.TextBox corTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.DataGridView carroDataGridView;
        private System.Windows.Forms.Label CadastroVeiculo;
        private System.Windows.Forms.Button deletarButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.Button atualizarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MarcaComboBox;
        private LocadoraDataSet locadoraDataSet1;
        private System.Windows.Forms.BindingSource marcaCarroBindingSource;
        private LocadoraDataSet1TableAdapters.MarcaCarroTableAdapter marcaCarroTableAdapter;
        private LocadoraDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cadastraMarcaTextBox;
        private System.Windows.Forms.Button salvarMarcaButton;
    }
}