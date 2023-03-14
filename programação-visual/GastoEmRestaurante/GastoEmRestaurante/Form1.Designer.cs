namespace GastoEmRestaurante
{
    partial class FormGastoEmRestaurante
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
            this.label1 = new System.Windows.Forms.Label();
            this.LABEL = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.TextBox();
            this.despesas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Despesa:";
            // 
            // LABEL
            // 
            this.LABEL.AutoSize = true;
            this.LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LABEL.Location = new System.Drawing.Point(45, 77);
            this.LABEL.Name = "LABEL";
            this.LABEL.Size = new System.Drawing.Size(113, 16);
            this.LABEL.TabIndex = 1;
            this.LABEL.Text = "Total com 10%:";
            this.LABEL.Click += new System.EventHandler(this.LABEL_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(229, 34);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(75, 23);
            this.equal.TabIndex = 2;
            this.equal.Text = "calcular";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.button1_Click);
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.Color.Yellow;
            this.total.Enabled = false;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(164, 71);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(140, 22);
            this.total.TabIndex = 3;
            // 
            // despesas
            // 
            this.despesas.Location = new System.Drawing.Point(119, 34);
            this.despesas.Name = "despesas";
            this.despesas.Size = new System.Drawing.Size(100, 22);
            this.despesas.TabIndex = 4;
            // 
            // FormGastoEmRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 167);
            this.Controls.Add(this.despesas);
            this.Controls.Add(this.total);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.LABEL);
            this.Controls.Add(this.label1);
            this.Name = "FormGastoEmRestaurante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LABEL;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox despesas;
    }
}

