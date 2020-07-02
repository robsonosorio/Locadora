namespace locadora_de_veiculos.Views.Cliente
{
    partial class NovoCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(166, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(98, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(98, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(98, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(98, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tel. ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Confirma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(145, 243);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(237, 23);
            this.textTelefone.TabIndex = 8;
            this.textTelefone.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(145, 197);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(237, 23);
            this.textCPF.TabIndex = 7;
            this.textCPF.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(145, 149);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(237, 23);
            this.textEmail.TabIndex = 6;
            this.textEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(145, 103);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(237, 23);
            this.textNome.TabIndex = 5;
            this.textNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NovoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NovoCadastro";
            this.Text = "NovoCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textNome;
    }
}