namespace PesoIdeal
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
            this.btnMasc = new System.Windows.Forms.RadioButton();
            this.btnFemi = new System.Windows.Forms.RadioButton();
            this.boxSexo = new System.Windows.Forms.GroupBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblPesoIdeal = new System.Windows.Forms.TextBox();
            this.boxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMasc
            // 
            this.btnMasc.AutoSize = true;
            this.btnMasc.Location = new System.Drawing.Point(6, 36);
            this.btnMasc.Name = "btnMasc";
            this.btnMasc.Size = new System.Drawing.Size(89, 20);
            this.btnMasc.TabIndex = 0;
            this.btnMasc.TabStop = true;
            this.btnMasc.Text = "Masculino";
            this.btnMasc.UseVisualStyleBackColor = true;
            this.btnMasc.CheckedChanged += new System.EventHandler(this.btnMasc_CheckedChanged);
            // 
            // btnFemi
            // 
            this.btnFemi.AutoSize = true;
            this.btnFemi.Location = new System.Drawing.Point(101, 36);
            this.btnFemi.Name = "btnFemi";
            this.btnFemi.Size = new System.Drawing.Size(83, 20);
            this.btnFemi.TabIndex = 1;
            this.btnFemi.TabStop = true;
            this.btnFemi.Text = "Feminino";
            this.btnFemi.UseVisualStyleBackColor = true;
            this.btnFemi.CheckedChanged += new System.EventHandler(this.btnFemi_CheckedChanged);
            // 
            // boxSexo
            // 
            this.boxSexo.Controls.Add(this.btnMasc);
            this.boxSexo.Controls.Add(this.btnFemi);
            this.boxSexo.Location = new System.Drawing.Point(29, 33);
            this.boxSexo.Name = "boxSexo";
            this.boxSexo.Size = new System.Drawing.Size(195, 78);
            this.boxSexo.TabIndex = 2;
            this.boxSexo.TabStop = false;
            this.boxSexo.Text = "Sexo";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(245, 66);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 3;
            this.txtAltura.Text = "0";
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.Location = new System.Drawing.Point(179, 138);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(100, 22);
            this.lblPesoIdeal.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.boxSexo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.boxSexo.ResumeLayout(false);
            this.boxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnMasc;
        private System.Windows.Forms.RadioButton btnFemi;
        private System.Windows.Forms.GroupBox boxSexo;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox lblPesoIdeal;
    }
}

