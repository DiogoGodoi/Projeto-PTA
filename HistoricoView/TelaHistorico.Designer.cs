namespace HistoricoView
{
    partial class TelaHistorico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdHistorico = new System.Windows.Forms.DataGridView();
            this.grpPesquisar = new System.Windows.Forms.GroupBox();
            this.btnDevolucao = new System.Windows.Forms.Button();
            this.lblFormato = new System.Windows.Forms.Label();
            this.btnPesquisarSaida = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.btnPesquisarEntrada = new System.Windows.Forms.Button();
            this.grpExibir = new System.Windows.Forms.GroupBox();
            this.btnExibirDevolucoes = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.historicoDB = new HistoricoView.HistoricoDB();
            this.historicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historicoTableAdapter = new HistoricoView.HistoricoDBTableAdapters.historicoTableAdapter();
            this.dataModificacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naturezaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requisitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorico)).BeginInit();
            this.grpPesquisar.SuspendLayout();
            this.grpExibir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historicoDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdHistorico
            // 
            this.grdHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grdHistorico.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdHistorico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataModificacaoDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.naturezaDataGridViewTextBoxColumn,
            this.operadorDataGridViewTextBoxColumn,
            this.requisitanteDataGridViewTextBoxColumn});
            this.grdHistorico.DataSource = this.historicoBindingSource;
            this.grdHistorico.Location = new System.Drawing.Point(43, 157);
            this.grdHistorico.Name = "grdHistorico";
            this.grdHistorico.ReadOnly = true;
            this.grdHistorico.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdHistorico.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Navy;
            this.grdHistorico.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.grdHistorico.Size = new System.Drawing.Size(705, 248);
            this.grdHistorico.TabIndex = 0;
            // 
            // grpPesquisar
            // 
            this.grpPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpPesquisar.Controls.Add(this.btnDevolucao);
            this.grpPesquisar.Controls.Add(this.lblFormato);
            this.grpPesquisar.Controls.Add(this.btnPesquisarSaida);
            this.grpPesquisar.Controls.Add(this.txtData);
            this.grpPesquisar.Controls.Add(this.lblData);
            this.grpPesquisar.Controls.Add(this.btnPesquisarEntrada);
            this.grpPesquisar.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPesquisar.ForeColor = System.Drawing.Color.Navy;
            this.grpPesquisar.Location = new System.Drawing.Point(43, 24);
            this.grpPesquisar.Name = "grpPesquisar";
            this.grpPesquisar.Size = new System.Drawing.Size(357, 102);
            this.grpPesquisar.TabIndex = 4;
            this.grpPesquisar.TabStop = false;
            this.grpPesquisar.Text = "Pesquisar";
            // 
            // btnDevolucao
            // 
            this.btnDevolucao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDevolucao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDevolucao.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucao.ForeColor = System.Drawing.Color.White;
            this.btnDevolucao.Location = new System.Drawing.Point(249, 63);
            this.btnDevolucao.Name = "btnDevolucao";
            this.btnDevolucao.Size = new System.Drawing.Size(89, 23);
            this.btnDevolucao.TabIndex = 13;
            this.btnDevolucao.Text = "Devoluções";
            this.btnDevolucao.UseVisualStyleBackColor = false;
            this.btnDevolucao.Click += new System.EventHandler(this.btnDevolucao_Click);
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.ForeColor = System.Drawing.Color.Navy;
            this.lblFormato.Location = new System.Drawing.Point(143, 14);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(94, 15);
            this.lblFormato.TabIndex = 12;
            this.lblFormato.Text = "Fomato: d/m/a";
            // 
            // btnPesquisarSaida
            // 
            this.btnPesquisarSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPesquisarSaida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarSaida.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarSaida.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarSaida.Location = new System.Drawing.Point(162, 63);
            this.btnPesquisarSaida.Name = "btnPesquisarSaida";
            this.btnPesquisarSaida.Size = new System.Drawing.Size(64, 23);
            this.btnPesquisarSaida.TabIndex = 11;
            this.btnPesquisarSaida.Text = "Saidas";
            this.btnPesquisarSaida.UseVisualStyleBackColor = false;
            this.btnPesquisarSaida.Click += new System.EventHandler(this.btnPesquisarSaida_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(57, 32);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(281, 22);
            this.txtData.TabIndex = 10;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Navy;
            this.lblData.Location = new System.Drawing.Point(15, 35);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(41, 15);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "Data: ";
            // 
            // btnPesquisarEntrada
            // 
            this.btnPesquisarEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPesquisarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisarEntrada.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarEntrada.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarEntrada.Location = new System.Drawing.Point(57, 63);
            this.btnPesquisarEntrada.Name = "btnPesquisarEntrada";
            this.btnPesquisarEntrada.Size = new System.Drawing.Size(78, 23);
            this.btnPesquisarEntrada.TabIndex = 8;
            this.btnPesquisarEntrada.Text = "Entradas";
            this.btnPesquisarEntrada.UseVisualStyleBackColor = false;
            this.btnPesquisarEntrada.Click += new System.EventHandler(this.btnPesquisarEntrada_Click);
            // 
            // grpExibir
            // 
            this.grpExibir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpExibir.Controls.Add(this.btnExibirDevolucoes);
            this.grpExibir.Controls.Add(this.btnSaida);
            this.grpExibir.Controls.Add(this.btnExibir);
            this.grpExibir.Controls.Add(this.btnEntrada);
            this.grpExibir.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExibir.ForeColor = System.Drawing.Color.Navy;
            this.grpExibir.Location = new System.Drawing.Point(436, 24);
            this.grpExibir.Name = "grpExibir";
            this.grpExibir.Size = new System.Drawing.Size(312, 102);
            this.grpExibir.TabIndex = 5;
            this.grpExibir.TabStop = false;
            this.grpExibir.Text = "Exibir";
            // 
            // btnExibirDevolucoes
            // 
            this.btnExibirDevolucoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExibirDevolucoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExibirDevolucoes.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirDevolucoes.ForeColor = System.Drawing.Color.White;
            this.btnExibirDevolucoes.Location = new System.Drawing.Point(207, 63);
            this.btnExibirDevolucoes.Name = "btnExibirDevolucoes";
            this.btnExibirDevolucoes.Size = new System.Drawing.Size(89, 23);
            this.btnExibirDevolucoes.TabIndex = 14;
            this.btnExibirDevolucoes.Text = "Devoluções";
            this.btnExibirDevolucoes.UseVisualStyleBackColor = false;
            this.btnExibirDevolucoes.Click += new System.EventHandler(this.btnExibirDevolucoes_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaida.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaida.ForeColor = System.Drawing.Color.White;
            this.btnSaida.Location = new System.Drawing.Point(115, 63);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(75, 23);
            this.btnSaida.TabIndex = 8;
            this.btnSaida.Text = "Saidas";
            this.btnSaida.UseVisualStyleBackColor = false;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click_1);
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.Navy;
            this.btnExibir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExibir.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.ForeColor = System.Drawing.Color.White;
            this.btnExibir.Location = new System.Drawing.Point(19, 27);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(277, 23);
            this.btnExibir.TabIndex = 6;
            this.btnExibir.Text = "Exibir tudo";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click_1);
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrada.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.Color.White;
            this.btnEntrada.Location = new System.Drawing.Point(19, 63);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(75, 23);
            this.btnEntrada.TabIndex = 7;
            this.btnEntrada.Text = "Entradas";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click_1);
            // 
            // historicoDB
            // 
            this.historicoDB.DataSetName = "HistoricoDB";
            this.historicoDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historicoBindingSource
            // 
            this.historicoBindingSource.DataMember = "historico";
            this.historicoBindingSource.DataSource = this.historicoDB;
            // 
            // historicoTableAdapter
            // 
            this.historicoTableAdapter.ClearBeforeFill = true;
            // 
            // dataModificacaoDataGridViewTextBoxColumn
            // 
            this.dataModificacaoDataGridViewTextBoxColumn.DataPropertyName = "dataModificacao";
            this.dataModificacaoDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataModificacaoDataGridViewTextBoxColumn.Name = "dataModificacaoDataGridViewTextBoxColumn";
            this.dataModificacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // naturezaDataGridViewTextBoxColumn
            // 
            this.naturezaDataGridViewTextBoxColumn.DataPropertyName = "natureza";
            this.naturezaDataGridViewTextBoxColumn.HeaderText = "Natureza";
            this.naturezaDataGridViewTextBoxColumn.Name = "naturezaDataGridViewTextBoxColumn";
            this.naturezaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operadorDataGridViewTextBoxColumn
            // 
            this.operadorDataGridViewTextBoxColumn.DataPropertyName = "operador";
            this.operadorDataGridViewTextBoxColumn.HeaderText = "Operador";
            this.operadorDataGridViewTextBoxColumn.Name = "operadorDataGridViewTextBoxColumn";
            this.operadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requisitanteDataGridViewTextBoxColumn
            // 
            this.requisitanteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.requisitanteDataGridViewTextBoxColumn.DataPropertyName = "requisitante";
            this.requisitanteDataGridViewTextBoxColumn.HeaderText = "Requisitante";
            this.requisitanteDataGridViewTextBoxColumn.Name = "requisitanteDataGridViewTextBoxColumn";
            this.requisitanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TelaHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.grpExibir);
            this.Controls.Add(this.grpPesquisar);
            this.Controls.Add(this.grdHistorico);
            this.Name = "TelaHistorico";
            this.Text = "Historico";
            this.Load += new System.EventHandler(this.TelaHistorico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHistorico)).EndInit();
            this.grpPesquisar.ResumeLayout(false);
            this.grpPesquisar.PerformLayout();
            this.grpExibir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historicoDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdHistorico;
        private System.Windows.Forms.GroupBox grpPesquisar;
        private System.Windows.Forms.Button btnPesquisarSaida;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnPesquisarEntrada;
        private System.Windows.Forms.GroupBox grpExibir;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnDevolucao;
        private System.Windows.Forms.Button btnExibirDevolucoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private HistoricoDB historicoDB;
        private System.Windows.Forms.BindingSource historicoBindingSource;
        private HistoricoDBTableAdapters.historicoTableAdapter historicoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataModificacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naturezaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requisitanteDataGridViewTextBoxColumn;
    }
}

