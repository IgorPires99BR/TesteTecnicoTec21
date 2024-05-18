namespace TesteTecnicoTec21
{
    partial class TelaDadosTitulo
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
            this.DataApresentacao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvarDados = new System.Windows.Forms.Button();
            this.txtDataApresentacao = new System.Windows.Forms.MaskedTextBox();
            this.txtValorCustas = new System.Windows.Forms.MaskedTextBox();
            this.lblIdTitulo = new System.Windows.Forms.Label();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira os dados de Data e Custo";
            // 
            // DataApresentacao
            // 
            this.DataApresentacao.AutoSize = true;
            this.DataApresentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DataApresentacao.Location = new System.Drawing.Point(37, 104);
            this.DataApresentacao.Name = "DataApresentacao";
            this.DataApresentacao.Size = new System.Drawing.Size(201, 24);
            this.DataApresentacao.TabIndex = 1;
            this.DataApresentacao.Text = "Data de Apresentação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(37, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor das Custas:";
            // 
            // btnSalvarDados
            // 
            this.btnSalvarDados.Location = new System.Drawing.Point(42, 236);
            this.btnSalvarDados.Name = "btnSalvarDados";
            this.btnSalvarDados.Size = new System.Drawing.Size(428, 31);
            this.btnSalvarDados.TabIndex = 5;
            this.btnSalvarDados.Text = "Salvar";
            this.btnSalvarDados.UseVisualStyleBackColor = true;
            this.btnSalvarDados.Click += new System.EventHandler(this.btnSalvarDados_Click);
            // 
            // txtDataApresentacao
            // 
            this.txtDataApresentacao.Location = new System.Drawing.Point(248, 109);
            this.txtDataApresentacao.Mask = "00/00/0000";
            this.txtDataApresentacao.Name = "txtDataApresentacao";
            this.txtDataApresentacao.Size = new System.Drawing.Size(223, 20);
            this.txtDataApresentacao.TabIndex = 6;
            this.txtDataApresentacao.ValidatingType = typeof(System.DateTime);
            // 
            // txtValorCustas
            // 
            this.txtValorCustas.Location = new System.Drawing.Point(248, 168);
            this.txtValorCustas.Mask = "00000,00";
            this.txtValorCustas.Name = "txtValorCustas";
            this.txtValorCustas.Size = new System.Drawing.Size(222, 20);
            this.txtValorCustas.TabIndex = 7;
            this.txtValorCustas.ValidatingType = typeof(int);
            // 
            // lblIdTitulo
            // 
            this.lblIdTitulo.AutoSize = true;
            this.lblIdTitulo.Location = new System.Drawing.Point(13, 40);
            this.lblIdTitulo.Name = "lblIdTitulo";
            this.lblIdTitulo.Size = new System.Drawing.Size(0, 13);
            this.lblIdTitulo.TabIndex = 8;
            // 
            // lblAlerta
            // 
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAlerta.ForeColor = System.Drawing.Color.Red;
            this.lblAlerta.Location = new System.Drawing.Point(52, 296);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(0, 20);
            this.lblAlerta.TabIndex = 9;
            // 
            // TelaDadosTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 343);
            this.Controls.Add(this.lblAlerta);
            this.Controls.Add(this.lblIdTitulo);
            this.Controls.Add(this.txtValorCustas);
            this.Controls.Add(this.txtDataApresentacao);
            this.Controls.Add(this.btnSalvarDados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataApresentacao);
            this.Controls.Add(this.label1);
            this.Name = "TelaDadosTitulo";
            this.Text = "TelaDadosTitulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DataApresentacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvarDados;
        private System.Windows.Forms.MaskedTextBox txtDataApresentacao;
        private System.Windows.Forms.MaskedTextBox txtValorCustas;
        private System.Windows.Forms.Label lblIdTitulo;
        private System.Windows.Forms.Label lblAlerta;
    }
}