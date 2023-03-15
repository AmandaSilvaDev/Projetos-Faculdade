namespace ReajusteSalarial
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
            this.components = new System.ComponentModel.Container();
            this.lbxResumo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.btnNoturno = new System.Windows.Forms.RadioButton();
            this.btnVespetino = new System.Windows.Forms.RadioButton();
            this.btnMatutino = new System.Windows.Forms.RadioButton();
            this.gbxCategoria = new System.Windows.Forms.GroupBox();
            this.btnCalouto = new System.Windows.Forms.RadioButton();
            this.btnVeterano = new System.Windows.Forms.RadioButton();
            this.txtSituacaoEstagiario = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbxTurno.SuspendLayout();
            this.gbxCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxResumo
            // 
            this.lbxResumo.FormattingEnabled = true;
            this.lbxResumo.ItemHeight = 16;
            this.lbxResumo.Location = new System.Drawing.Point(36, 190);
            this.lbxResumo.Name = "lbxResumo";
            this.lbxResumo.Size = new System.Drawing.Size(362, 116);
            this.lbxResumo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salário Minimo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horas trabalhadas";
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(168, 25);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(100, 22);
            this.txtSalarioMinimo.TabIndex = 3;
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(168, 53);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(100, 22);
            this.txtHorasTrabalhadas.TabIndex = 4;
            // 
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.btnNoturno);
            this.gbxTurno.Controls.Add(this.btnVespetino);
            this.gbxTurno.Controls.Add(this.btnMatutino);
            this.gbxTurno.Location = new System.Drawing.Point(274, 25);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Size = new System.Drawing.Size(124, 131);
            this.gbxTurno.TabIndex = 5;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Turno";
            // 
            // btnNoturno
            // 
            this.btnNoturno.AutoSize = true;
            this.btnNoturno.Location = new System.Drawing.Point(6, 98);
            this.btnNoturno.Name = "btnNoturno";
            this.btnNoturno.Size = new System.Drawing.Size(75, 20);
            this.btnNoturno.TabIndex = 9;
            this.btnNoturno.TabStop = true;
            this.btnNoturno.Text = "Noturno";
            this.btnNoturno.UseVisualStyleBackColor = true;
            // 
            // btnVespetino
            // 
            this.btnVespetino.AutoSize = true;
            this.btnVespetino.Location = new System.Drawing.Point(6, 58);
            this.btnVespetino.Name = "btnVespetino";
            this.btnVespetino.Size = new System.Drawing.Size(89, 20);
            this.btnVespetino.TabIndex = 8;
            this.btnVespetino.TabStop = true;
            this.btnVespetino.Text = "Vespetino";
            this.btnVespetino.UseVisualStyleBackColor = true;
            // 
            // btnMatutino
            // 
            this.btnMatutino.AutoSize = true;
            this.btnMatutino.Location = new System.Drawing.Point(6, 21);
            this.btnMatutino.Name = "btnMatutino";
            this.btnMatutino.Size = new System.Drawing.Size(78, 20);
            this.btnMatutino.TabIndex = 7;
            this.btnMatutino.TabStop = true;
            this.btnMatutino.Text = "Matutino";
            this.btnMatutino.UseVisualStyleBackColor = true;
            // 
            // gbxCategoria
            // 
            this.gbxCategoria.Controls.Add(this.btnCalouto);
            this.gbxCategoria.Controls.Add(this.btnVeterano);
            this.gbxCategoria.Location = new System.Drawing.Point(36, 102);
            this.gbxCategoria.Name = "gbxCategoria";
            this.gbxCategoria.Size = new System.Drawing.Size(232, 54);
            this.gbxCategoria.TabIndex = 6;
            this.gbxCategoria.TabStop = false;
            this.gbxCategoria.Text = "Categoria";
            // 
            // btnCalouto
            // 
            this.btnCalouto.AutoSize = true;
            this.btnCalouto.Location = new System.Drawing.Point(7, 22);
            this.btnCalouto.Name = "btnCalouto";
            this.btnCalouto.Size = new System.Drawing.Size(75, 20);
            this.btnCalouto.TabIndex = 0;
            this.btnCalouto.TabStop = true;
            this.btnCalouto.Text = "Calouro";
            this.btnCalouto.UseVisualStyleBackColor = true;
            // 
            // btnVeterano
            // 
            this.btnVeterano.AutoSize = true;
            this.btnVeterano.Location = new System.Drawing.Point(111, 22);
            this.btnVeterano.Name = "btnVeterano";
            this.btnVeterano.Size = new System.Drawing.Size(83, 20);
            this.btnVeterano.TabIndex = 1;
            this.btnVeterano.TabStop = true;
            this.btnVeterano.Text = "Veterano";
            this.btnVeterano.UseVisualStyleBackColor = true;
            this.btnVeterano.CheckedChanged += new System.EventHandler(this.btnVeterano_CheckedChanged);
            // 
            // txtSituacaoEstagiario
            // 
            this.txtSituacaoEstagiario.Location = new System.Drawing.Point(36, 337);
            this.txtSituacaoEstagiario.Name = "txtSituacaoEstagiario";
            this.txtSituacaoEstagiario.Size = new System.Drawing.Size(232, 22);
            this.txtSituacaoEstagiario.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(280, 337);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 406);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSituacaoEstagiario);
            this.Controls.Add(this.gbxCategoria);
            this.Controls.Add(this.gbxTurno);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxResumo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reajuste salarial";
            this.gbxTurno.ResumeLayout(false);
            this.gbxTurno.PerformLayout();
            this.gbxCategoria.ResumeLayout(false);
            this.gbxCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxResumo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.GroupBox gbxTurno;
        private System.Windows.Forms.GroupBox gbxCategoria;
        private System.Windows.Forms.RadioButton btnNoturno;
        private System.Windows.Forms.RadioButton btnVespetino;
        private System.Windows.Forms.RadioButton btnMatutino;
        private System.Windows.Forms.RadioButton btnCalouto;
        private System.Windows.Forms.RadioButton btnVeterano;
        private System.Windows.Forms.TextBox txtSituacaoEstagiario;
        private System.Windows.Forms.Button btnCalcular;
        public System.Windows.Forms.ToolTip toolTip1;
    }
}

