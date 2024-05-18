namespace TesteTecnicoTec21
{
    partial class TelaImportacao
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.dgvTitulos = new System.Windows.Forms.DataGridView();
            this.colunaDados = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protocoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDevedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDevedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeApresentanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoApresentanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCredorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoCredorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especieTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech21dbDataSet = new TesteTecnicoTec21.Tech21dbDataSet();
            this.titulosTableAdapter = new TesteTecnicoTec21.Tech21dbDataSetTableAdapters.TitulosTableAdapter();
            this.tech21dbDataSet1 = new TesteTecnicoTec21.Tech21dbDataSet1();
            this.titulosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.titulosTableAdapter1 = new TesteTecnicoTec21.Tech21dbDataSet1TableAdapters.TitulosTableAdapter();
            this.DataApresentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCustas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech21dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech21dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione o Arquivo XML";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(215, 63);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(179, 31);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // lblAlerta
            // 
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta.ForeColor = System.Drawing.Color.Red;
            this.lblAlerta.Location = new System.Drawing.Point(691, 63);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(0, 24);
            this.lblAlerta.TabIndex = 3;
            // 
            // dgvTitulos
            // 
            this.dgvTitulos.AutoGenerateColumns = false;
            this.dgvTitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaDados,
            this.idTituloDataGridViewTextBoxColumn,
            this.protocoloDataGridViewTextBoxColumn,
            this.nomeDevedorDataGridViewTextBoxColumn,
            this.documentoDevedorDataGridViewTextBoxColumn,
            this.nomeApresentanteDataGridViewTextBoxColumn,
            this.documentoApresentanteDataGridViewTextBoxColumn,
            this.nomeCredorDataGridViewTextBoxColumn,
            this.documentoCredorDataGridViewTextBoxColumn,
            this.numeroTituloDataGridViewTextBoxColumn,
            this.valorTituloDataGridViewTextBoxColumn,
            this.dataEmissaoDataGridViewTextBoxColumn,
            this.especieTituloDataGridViewTextBoxColumn,
            this.DataApresentacao,
            this.ValorCustas});
            this.dgvTitulos.DataSource = this.titulosBindingSource1;
            this.dgvTitulos.Location = new System.Drawing.Point(16, 114);
            this.dgvTitulos.Name = "dgvTitulos";
            this.dgvTitulos.Size = new System.Drawing.Size(1444, 366);
            this.dgvTitulos.TabIndex = 4;
            this.dgvTitulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTitulos_CellClick);
            // 
            // colunaDados
            // 
            this.colunaDados.HeaderText = "Dados";
            this.colunaDados.Name = "colunaDados";
            this.colunaDados.Text = "Selecione";
            this.colunaDados.UseColumnTextForButtonValue = true;
            // 
            // idTituloDataGridViewTextBoxColumn
            // 
            this.idTituloDataGridViewTextBoxColumn.DataPropertyName = "IdTitulo";
            this.idTituloDataGridViewTextBoxColumn.HeaderText = "IdTitulo";
            this.idTituloDataGridViewTextBoxColumn.Name = "idTituloDataGridViewTextBoxColumn";
            this.idTituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTituloDataGridViewTextBoxColumn.Visible = false;
            // 
            // protocoloDataGridViewTextBoxColumn
            // 
            this.protocoloDataGridViewTextBoxColumn.DataPropertyName = "Protocolo";
            this.protocoloDataGridViewTextBoxColumn.HeaderText = "Protocolo";
            this.protocoloDataGridViewTextBoxColumn.Name = "protocoloDataGridViewTextBoxColumn";
            // 
            // nomeDevedorDataGridViewTextBoxColumn
            // 
            this.nomeDevedorDataGridViewTextBoxColumn.DataPropertyName = "NomeDevedor";
            this.nomeDevedorDataGridViewTextBoxColumn.HeaderText = "NomeDevedor";
            this.nomeDevedorDataGridViewTextBoxColumn.Name = "nomeDevedorDataGridViewTextBoxColumn";
            // 
            // documentoDevedorDataGridViewTextBoxColumn
            // 
            this.documentoDevedorDataGridViewTextBoxColumn.DataPropertyName = "DocumentoDevedor";
            this.documentoDevedorDataGridViewTextBoxColumn.HeaderText = "DocumentoDevedor";
            this.documentoDevedorDataGridViewTextBoxColumn.Name = "documentoDevedorDataGridViewTextBoxColumn";
            // 
            // nomeApresentanteDataGridViewTextBoxColumn
            // 
            this.nomeApresentanteDataGridViewTextBoxColumn.DataPropertyName = "NomeApresentante";
            this.nomeApresentanteDataGridViewTextBoxColumn.HeaderText = "NomeApresentante";
            this.nomeApresentanteDataGridViewTextBoxColumn.Name = "nomeApresentanteDataGridViewTextBoxColumn";
            // 
            // documentoApresentanteDataGridViewTextBoxColumn
            // 
            this.documentoApresentanteDataGridViewTextBoxColumn.DataPropertyName = "DocumentoApresentante";
            this.documentoApresentanteDataGridViewTextBoxColumn.HeaderText = "DocumentoApresentante";
            this.documentoApresentanteDataGridViewTextBoxColumn.Name = "documentoApresentanteDataGridViewTextBoxColumn";
            // 
            // nomeCredorDataGridViewTextBoxColumn
            // 
            this.nomeCredorDataGridViewTextBoxColumn.DataPropertyName = "NomeCredor";
            this.nomeCredorDataGridViewTextBoxColumn.HeaderText = "NomeCredor";
            this.nomeCredorDataGridViewTextBoxColumn.Name = "nomeCredorDataGridViewTextBoxColumn";
            // 
            // documentoCredorDataGridViewTextBoxColumn
            // 
            this.documentoCredorDataGridViewTextBoxColumn.DataPropertyName = "DocumentoCredor";
            this.documentoCredorDataGridViewTextBoxColumn.HeaderText = "DocumentoCredor";
            this.documentoCredorDataGridViewTextBoxColumn.Name = "documentoCredorDataGridViewTextBoxColumn";
            // 
            // numeroTituloDataGridViewTextBoxColumn
            // 
            this.numeroTituloDataGridViewTextBoxColumn.DataPropertyName = "NumeroTitulo";
            this.numeroTituloDataGridViewTextBoxColumn.HeaderText = "NumeroTitulo";
            this.numeroTituloDataGridViewTextBoxColumn.Name = "numeroTituloDataGridViewTextBoxColumn";
            // 
            // valorTituloDataGridViewTextBoxColumn
            // 
            this.valorTituloDataGridViewTextBoxColumn.DataPropertyName = "ValorTitulo";
            this.valorTituloDataGridViewTextBoxColumn.HeaderText = "ValorTitulo";
            this.valorTituloDataGridViewTextBoxColumn.Name = "valorTituloDataGridViewTextBoxColumn";
            // 
            // dataEmissaoDataGridViewTextBoxColumn
            // 
            this.dataEmissaoDataGridViewTextBoxColumn.DataPropertyName = "DataEmissao";
            this.dataEmissaoDataGridViewTextBoxColumn.HeaderText = "DataEmissao";
            this.dataEmissaoDataGridViewTextBoxColumn.Name = "dataEmissaoDataGridViewTextBoxColumn";
            // 
            // especieTituloDataGridViewTextBoxColumn
            // 
            this.especieTituloDataGridViewTextBoxColumn.DataPropertyName = "EspecieTitulo";
            this.especieTituloDataGridViewTextBoxColumn.HeaderText = "EspecieTitulo";
            this.especieTituloDataGridViewTextBoxColumn.Name = "especieTituloDataGridViewTextBoxColumn";
            // 
            // titulosBindingSource
            // 
            this.titulosBindingSource.DataMember = "Titulos";
            this.titulosBindingSource.DataSource = this.tech21dbDataSet;
            // 
            // tech21dbDataSet
            // 
            this.tech21dbDataSet.DataSetName = "Tech21dbDataSet";
            this.tech21dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titulosTableAdapter
            // 
            this.titulosTableAdapter.ClearBeforeFill = true;
            // 
            // tech21dbDataSet1
            // 
            this.tech21dbDataSet1.DataSetName = "Tech21dbDataSet1";
            this.tech21dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titulosBindingSource1
            // 
            this.titulosBindingSource1.DataMember = "Titulos";
            this.titulosBindingSource1.DataSource = this.tech21dbDataSet1;
            // 
            // titulosTableAdapter1
            // 
            this.titulosTableAdapter1.ClearBeforeFill = true;
            // 
            // DataApresentacao
            // 
            this.DataApresentacao.DataPropertyName = "DataApresentacao";
            this.DataApresentacao.HeaderText = "DataApresentacao";
            this.DataApresentacao.Name = "DataApresentacao";
            // 
            // ValorCustas
            // 
            this.ValorCustas.DataPropertyName = "ValorCustas";
            this.ValorCustas.HeaderText = "ValorCustas";
            this.ValorCustas.Name = "ValorCustas";
            // 
            // Reload
            // 
            this.Reload.Location = new System.Drawing.Point(400, 63);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(180, 31);
            this.Reload.TabIndex = 5;
            this.Reload.Text = "Reload";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // TelaImportacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 513);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.dgvTitulos);
            this.Controls.Add(this.lblAlerta);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.label1);
            this.Name = "TelaImportacao";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TelaImportacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech21dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech21dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label lblAlerta;
        private System.Windows.Forms.DataGridView dgvTitulos;
        private Tech21dbDataSet tech21dbDataSet;
        private System.Windows.Forms.BindingSource titulosBindingSource;
        private Tech21dbDataSetTableAdapters.TitulosTableAdapter titulosTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn colunaDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDevedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDevedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeApresentanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoApresentanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCredorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoCredorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especieTituloDataGridViewTextBoxColumn;
        private Tech21dbDataSet1 tech21dbDataSet1;
        private System.Windows.Forms.BindingSource titulosBindingSource1;
        private Tech21dbDataSet1TableAdapters.TitulosTableAdapter titulosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataApresentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCustas;
        private System.Windows.Forms.Button Reload;
    }
}

