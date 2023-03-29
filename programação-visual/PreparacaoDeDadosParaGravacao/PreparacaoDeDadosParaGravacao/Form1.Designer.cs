namespace PreparacaoDeDadosParaGravacao
{
    partial class Form1
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
            this.btnCriarLinhas = new System.Windows.Forms.Button();
            this.btnCriarArquivo = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.sfdGravarArquivo = new System.Windows.Forms.SaveFileDialog();
            this.txtNumeroFuncionarios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriarLinhas
            // 
            this.btnCriarLinhas.Location = new System.Drawing.Point(376, 24);
            this.btnCriarLinhas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCriarLinhas.Name = "btnCriarLinhas";
            this.btnCriarLinhas.Size = new System.Drawing.Size(100, 28);
            this.btnCriarLinhas.TabIndex = 0;
            this.btnCriarLinhas.Text = "Criar Linhas";
            this.btnCriarLinhas.UseVisualStyleBackColor = true;
            this.btnCriarLinhas.Click += new System.EventHandler(this.btnCriarLinhas_Click);
            // 
            // btnCriarArquivo
            // 
            this.btnCriarArquivo.Location = new System.Drawing.Point(45, 302);
            this.btnCriarArquivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCriarArquivo.Name = "btnCriarArquivo";
            this.btnCriarArquivo.Size = new System.Drawing.Size(176, 28);
            this.btnCriarArquivo.TabIndex = 1;
            this.btnCriarArquivo.Text = "Criar arquivo";
            this.btnCriarArquivo.UseVisualStyleBackColor = true;
            this.btnCriarArquivo.Click += new System.EventHandler(this.btnCriarArquivo_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(298, 302);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(178, 28);
            this.btnReiniciar.TabIndex = 2;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // sfdGravarArquivo
            // 
            this.sfdGravarArquivo.DefaultExt = "*.txt";
            this.sfdGravarArquivo.Filter = " Arquivos textos|*.txt";
            this.sfdGravarArquivo.Title = " Dados para geração de arquivo";
            // 
            // txtNumeroFuncionarios
            // 
            this.txtNumeroFuncionarios.Location = new System.Drawing.Point(151, 29);
            this.txtNumeroFuncionarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeroFuncionarios.Name = "txtNumeroFuncionarios";
            this.txtNumeroFuncionarios.Size = new System.Drawing.Size(71, 20);
            this.txtNumeroFuncionarios.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nr. de Funcionarios:";
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(45, 58);
            this.dgvFuncionarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.RowHeadersWidth = 51;
            this.dgvFuncionarios.RowTemplate.Height = 24;
            this.dgvFuncionarios.Size = new System.Drawing.Size(431, 221);
            this.dgvFuncionarios.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 366);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroFuncionarios);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCriarArquivo);
            this.Controls.Add(this.btnCriarLinhas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarLinhas;
        private System.Windows.Forms.Button btnCriarArquivo;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.SaveFileDialog sfdGravarArquivo;
        private System.Windows.Forms.TextBox txtNumeroFuncionarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
    }
}

