namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numUm = new System.Windows.Forms.TextBox();
            this.numDois = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.operacao = new System.Windows.Forms.ComboBox();
            this.equal = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.resul = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numUm
            // 
            this.numUm.BackColor = System.Drawing.SystemColors.Highlight;
            this.numUm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUm.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.numUm.Location = new System.Drawing.Point(232, 84);
            this.numUm.Name = "numUm";
            this.numUm.Size = new System.Drawing.Size(209, 57);
            this.numUm.TabIndex = 0;
            this.numUm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUm.TextChanged += new System.EventHandler(this.numUm_TextChanged);
            this.numUm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numUm_KeyPress);
            // 
            // numDois
            // 
            this.numDois.BackColor = System.Drawing.SystemColors.Highlight;
            this.numDois.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDois.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.numDois.Location = new System.Drawing.Point(232, 161);
            this.numDois.Name = "numDois";
            this.numDois.Size = new System.Drawing.Size(209, 57);
            this.numDois.TabIndex = 1;
            this.numDois.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDois.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numDois_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(71, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(68, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // operacao
            // 
            this.operacao.BackColor = System.Drawing.SystemColors.Highlight;
            this.operacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operacao.ForeColor = System.Drawing.Color.Wheat;
            this.operacao.FormattingEnabled = true;
            this.operacao.Items.AddRange(new object[] {
            "adição",
            "subtração",
            "multiplicação",
            "divisão"});
            this.operacao.Location = new System.Drawing.Point(232, 29);
            this.operacao.Name = "operacao";
            this.operacao.Size = new System.Drawing.Size(209, 37);
            this.operacao.TabIndex = 4;
            this.operacao.Text = "operação";
            this.operacao.SelectedIndexChanged += new System.EventHandler(this.operacao_SelectedIndexChanged);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.Blue;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.equal.ForeColor = System.Drawing.Color.MintCream;
            this.equal.Location = new System.Drawing.Point(59, 339);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(181, 80);
            this.equal.TabIndex = 5;
            this.equal.Text = "equal";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Blue;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.clear.ForeColor = System.Drawing.Color.MintCream;
            this.clear.Location = new System.Drawing.Point(260, 339);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(181, 80);
            this.clear.TabIndex = 6;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // resul
            // 
            this.resul.BackColor = System.Drawing.SystemColors.Highlight;
            this.resul.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resul.Enabled = false;
            this.resul.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resul.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.resul.Location = new System.Drawing.Point(232, 246);
            this.resul.Name = "resul";
            this.resul.Size = new System.Drawing.Size(209, 57);
            this.resul.TabIndex = 7;
            this.resul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(65, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 526);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resul);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.operacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDois);
            this.Controls.Add(this.numUm);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numUm;
        private System.Windows.Forms.TextBox numDois;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox operacao;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox resul;
        private System.Windows.Forms.Label label3;
    }
}

