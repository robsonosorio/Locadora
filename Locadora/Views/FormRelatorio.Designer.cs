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
            this.locadoraDataSet = new Locadora.LocadoraDataSet();
            this.RelatorioDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.locadoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // locadoraDataSet
            // 
            this.locadoraDataSet.DataSetName = "LocadoraDataSet";
            this.locadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RelatorioDataGridView);
            this.Name = "FormRelatorio";
            this.Text = ".: Relatório de locações";
            this.Load += new System.EventHandler(this.FormRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locadoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LocadoraDataSet locadoraDataSet;
        private System.Windows.Forms.DataGridView RelatorioDataGridView;
        private System.Windows.Forms.Label label1;
    }
}