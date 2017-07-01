namespace ExcelAux.Telas.Modificacao
{
    partial class FrmTarefas
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
            this.cbxFinalizado = new System.Windows.Forms.ComboBox();
            this.cbxPrioridade = new System.Windows.Forms.ComboBox();
            this.tbnSalvar = new System.Windows.Forms.Button();
            this.lblFinalizado = new System.Windows.Forms.Label();
            this.txbTermino = new System.Windows.Forms.TextBox();
            this.lblTermino = new System.Windows.Forms.Label();
            this.txbInicio = new System.Windows.Forms.TextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxFinalizado
            // 
            this.cbxFinalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFinalizado.FormattingEnabled = true;
            this.cbxFinalizado.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbxFinalizado.Location = new System.Drawing.Point(402, 86);
            this.cbxFinalizado.Name = "cbxFinalizado";
            this.cbxFinalizado.Size = new System.Drawing.Size(92, 26);
            this.cbxFinalizado.TabIndex = 35;
            // 
            // cbxPrioridade
            // 
            this.cbxPrioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPrioridade.FormattingEnabled = true;
            this.cbxPrioridade.Items.AddRange(new object[] {
            "Alta",
            "Média",
            "Baixa"});
            this.cbxPrioridade.Location = new System.Drawing.Point(402, 31);
            this.cbxPrioridade.Name = "cbxPrioridade";
            this.cbxPrioridade.Size = new System.Drawing.Size(92, 26);
            this.cbxPrioridade.TabIndex = 34;
            // 
            // tbnSalvar
            // 
            this.tbnSalvar.Location = new System.Drawing.Point(220, 172);
            this.tbnSalvar.Name = "tbnSalvar";
            this.tbnSalvar.Size = new System.Drawing.Size(75, 23);
            this.tbnSalvar.TabIndex = 33;
            this.tbnSalvar.Text = "Salvar";
            this.tbnSalvar.UseVisualStyleBackColor = true;
            this.tbnSalvar.Click += new System.EventHandler(this.tbnSalvar_Click);
            // 
            // lblFinalizado
            // 
            this.lblFinalizado.AutoSize = true;
            this.lblFinalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalizado.Location = new System.Drawing.Point(301, 85);
            this.lblFinalizado.Name = "lblFinalizado";
            this.lblFinalizado.Size = new System.Drawing.Size(95, 18);
            this.lblFinalizado.TabIndex = 32;
            this.lblFinalizado.Text = "Finalizado: ";
            // 
            // txbTermino
            // 
            this.txbTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTermino.Location = new System.Drawing.Point(391, 140);
            this.txbTermino.Name = "txbTermino";
            this.txbTermino.Size = new System.Drawing.Size(100, 24);
            this.txbTermino.TabIndex = 31;
            // 
            // lblTermino
            // 
            this.lblTermino.AutoSize = true;
            this.lblTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermino.Location = new System.Drawing.Point(242, 143);
            this.lblTermino.Name = "lblTermino";
            this.lblTermino.Size = new System.Drawing.Size(143, 18);
            this.lblTermino.TabIndex = 30;
            this.lblTermino.Text = "Data de Termino: ";
            // 
            // txbInicio
            // 
            this.txbInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInicio.Location = new System.Drawing.Point(136, 140);
            this.txbInicio.Name = "txbInicio";
            this.txbInicio.Size = new System.Drawing.Size(100, 24);
            this.txbInicio.TabIndex = 29;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(9, 143);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(121, 18);
            this.lblInicio.TabIndex = 28;
            this.lblInicio.Text = "Data de Inicio: ";
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridade.Location = new System.Drawing.Point(301, 30);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(95, 18);
            this.lblPrioridade.TabIndex = 27;
            this.lblPrioridade.Text = "Prioridade: ";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescricao.Location = new System.Drawing.Point(96, 82);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(199, 24);
            this.txbDescricao.TabIndex = 26;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(9, 85);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(95, 18);
            this.lblDescricao.TabIndex = 25;
            this.lblDescricao.Text = "Descricao: ";
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(195, 24);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 24);
            this.txbNome.TabIndex = 22;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(129, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 18);
            this.lblNome.TabIndex = 21;
            this.lblNome.Text = "Nome: ";
            // 
            // txbId
            // 
            this.txbId.Enabled = false;
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(49, 24);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(58, 24);
            this.txbId.TabIndex = 20;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(9, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 18);
            this.lblId.TabIndex = 19;
            this.lblId.Text = "ID: ";
            // 
            // FrmTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 207);
            this.Controls.Add(this.cbxFinalizado);
            this.Controls.Add(this.cbxPrioridade);
            this.Controls.Add(this.tbnSalvar);
            this.Controls.Add(this.lblFinalizado);
            this.Controls.Add(this.txbTermino);
            this.Controls.Add(this.lblTermino);
            this.Controls.Add(this.txbInicio);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.lblPrioridade);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblId);
            this.Name = "FrmTarefas";
            this.Text = "FrmTarefas";
            this.Load += new System.EventHandler(this.FrmTarefas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFinalizado;
        private System.Windows.Forms.ComboBox cbxPrioridade;
        private System.Windows.Forms.Button tbnSalvar;
        private System.Windows.Forms.Label lblFinalizado;
        private System.Windows.Forms.TextBox txbTermino;
        private System.Windows.Forms.Label lblTermino;
        private System.Windows.Forms.TextBox txbInicio;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lblId;
    }
}