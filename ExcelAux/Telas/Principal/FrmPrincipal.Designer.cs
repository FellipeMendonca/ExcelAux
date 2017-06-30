namespace ExcelAux.Telas
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxPlanilhas = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxPlanilhas
            // 
            this.cbxPlanilhas.FormattingEnabled = true;
            this.cbxPlanilhas.Location = new System.Drawing.Point(114, 12);
            this.cbxPlanilhas.Name = "cbxPlanilhas";
            this.cbxPlanilhas.Size = new System.Drawing.Size(121, 21);
            this.cbxPlanilhas.TabIndex = 0;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(420, 286);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(309, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvExcel
            // 
            this.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcel.Location = new System.Drawing.Point(12, 39);
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.Size = new System.Drawing.Size(483, 241);
            this.dgvExcel.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 321);
            this.Controls.Add(this.dgvExcel);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.cbxPlanilhas);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPlanilhas;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvExcel;
    }
}

