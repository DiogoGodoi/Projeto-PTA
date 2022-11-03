namespace MenuHistoricoView
{
    partial class TelaRelatorios
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
            this.btnRelatorioHistorico = new System.Windows.Forms.Button();
            this.grpMovimentacoes = new System.Windows.Forms.GroupBox();
            this.btnGerarDevolucao = new System.Windows.Forms.Button();
            this.btnExibirSaidas = new System.Windows.Forms.Button();
            this.btnExibirEntradas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGerarTudoCraha = new System.Windows.Forms.Button();
            this.btnGerarTudoData = new System.Windows.Forms.Button();
            this.btnGerarDevolucaoData = new System.Windows.Forms.Button();
            this.btnGerarDevolucoesCracha = new System.Windows.Forms.Button();
            this.btnGerarSaidaCracha = new System.Windows.Forms.Button();
            this.txtNomeRequisitante = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCracha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerarSaidas = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.txtDataMovimentacao = new System.Windows.Forms.TextBox();
            this.btnBuscarPorData = new System.Windows.Forms.Button();
            this.grpTitulo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpMovimentacoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRelatorioHistorico
            // 
            this.btnRelatorioHistorico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRelatorioHistorico.BackColor = System.Drawing.Color.Navy;
            this.btnRelatorioHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioHistorico.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioHistorico.ForeColor = System.Drawing.Color.White;
            this.btnRelatorioHistorico.Location = new System.Drawing.Point(20, 80);
            this.btnRelatorioHistorico.Name = "btnRelatorioHistorico";
            this.btnRelatorioHistorico.Size = new System.Drawing.Size(139, 28);
            this.btnRelatorioHistorico.TabIndex = 0;
            this.btnRelatorioHistorico.Text = "Gerar total";
            this.btnRelatorioHistorico.UseVisualStyleBackColor = false;
            this.btnRelatorioHistorico.Click += new System.EventHandler(this.btnRelatorioHistorico_Click);
            // 
            // grpMovimentacoes
            // 
            this.grpMovimentacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpMovimentacoes.Controls.Add(this.btnGerarDevolucao);
            this.grpMovimentacoes.Controls.Add(this.btnExibirSaidas);
            this.grpMovimentacoes.Controls.Add(this.btnExibirEntradas);
            this.grpMovimentacoes.Controls.Add(this.btnRelatorioHistorico);
            this.grpMovimentacoes.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMovimentacoes.ForeColor = System.Drawing.Color.Navy;
            this.grpMovimentacoes.Location = new System.Drawing.Point(25, 135);
            this.grpMovimentacoes.Name = "grpMovimentacoes";
            this.grpMovimentacoes.Size = new System.Drawing.Size(181, 310);
            this.grpMovimentacoes.TabIndex = 1;
            this.grpMovimentacoes.TabStop = false;
            this.grpMovimentacoes.Text = "Movimentações Gerais";
            // 
            // btnGerarDevolucao
            // 
            this.btnGerarDevolucao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarDevolucao.BackColor = System.Drawing.Color.Navy;
            this.btnGerarDevolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarDevolucao.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarDevolucao.ForeColor = System.Drawing.Color.White;
            this.btnGerarDevolucao.Location = new System.Drawing.Point(20, 219);
            this.btnGerarDevolucao.Name = "btnGerarDevolucao";
            this.btnGerarDevolucao.Size = new System.Drawing.Size(139, 28);
            this.btnGerarDevolucao.TabIndex = 4;
            this.btnGerarDevolucao.Text = "Gerar Devolução";
            this.btnGerarDevolucao.UseVisualStyleBackColor = false;
            this.btnGerarDevolucao.Click += new System.EventHandler(this.btnGerarDevolucao_Click);
            // 
            // btnExibirSaidas
            // 
            this.btnExibirSaidas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExibirSaidas.BackColor = System.Drawing.Color.Navy;
            this.btnExibirSaidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirSaidas.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirSaidas.ForeColor = System.Drawing.Color.White;
            this.btnExibirSaidas.Location = new System.Drawing.Point(20, 171);
            this.btnExibirSaidas.Name = "btnExibirSaidas";
            this.btnExibirSaidas.Size = new System.Drawing.Size(139, 28);
            this.btnExibirSaidas.TabIndex = 3;
            this.btnExibirSaidas.Text = "Gerar saídas";
            this.btnExibirSaidas.UseVisualStyleBackColor = false;
            this.btnExibirSaidas.Click += new System.EventHandler(this.btnExibirSaidas_Click);
            // 
            // btnExibirEntradas
            // 
            this.btnExibirEntradas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExibirEntradas.BackColor = System.Drawing.Color.Navy;
            this.btnExibirEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirEntradas.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirEntradas.ForeColor = System.Drawing.Color.White;
            this.btnExibirEntradas.Location = new System.Drawing.Point(20, 125);
            this.btnExibirEntradas.Name = "btnExibirEntradas";
            this.btnExibirEntradas.Size = new System.Drawing.Size(139, 28);
            this.btnExibirEntradas.TabIndex = 2;
            this.btnExibirEntradas.Text = "Gerar entradas";
            this.btnExibirEntradas.UseVisualStyleBackColor = false;
            this.btnExibirEntradas.Click += new System.EventHandler(this.btnExibirEntradas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnGerarTudoCraha);
            this.groupBox1.Controls.Add(this.btnGerarTudoData);
            this.groupBox1.Controls.Add(this.btnGerarDevolucaoData);
            this.groupBox1.Controls.Add(this.btnGerarDevolucoesCracha);
            this.groupBox1.Controls.Add(this.btnGerarSaidaCracha);
            this.groupBox1.Controls.Add(this.txtNomeRequisitante);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtCracha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGerarSaidas);
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Controls.Add(this.txtDataMovimentacao);
            this.groupBox1.Controls.Add(this.btnBuscarPorData);
            this.groupBox1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(242, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 310);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerar por filtro";
            // 
            // btnGerarTudoCraha
            // 
            this.btnGerarTudoCraha.BackColor = System.Drawing.Color.Navy;
            this.btnGerarTudoCraha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarTudoCraha.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarTudoCraha.ForeColor = System.Drawing.Color.White;
            this.btnGerarTudoCraha.Location = new System.Drawing.Point(19, 260);
            this.btnGerarTudoCraha.Name = "btnGerarTudoCraha";
            this.btnGerarTudoCraha.Size = new System.Drawing.Size(354, 28);
            this.btnGerarTudoCraha.TabIndex = 17;
            this.btnGerarTudoCraha.Text = "Gerar tudo";
            this.btnGerarTudoCraha.UseVisualStyleBackColor = false;
            this.btnGerarTudoCraha.Click += new System.EventHandler(this.btnGerarTudoCraha_Click);
            // 
            // btnGerarTudoData
            // 
            this.btnGerarTudoData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarTudoData.BackColor = System.Drawing.Color.Navy;
            this.btnGerarTudoData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarTudoData.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarTudoData.ForeColor = System.Drawing.Color.White;
            this.btnGerarTudoData.Location = new System.Drawing.Point(19, 124);
            this.btnGerarTudoData.Name = "btnGerarTudoData";
            this.btnGerarTudoData.Size = new System.Drawing.Size(354, 28);
            this.btnGerarTudoData.TabIndex = 16;
            this.btnGerarTudoData.Text = "Gerar tudo";
            this.btnGerarTudoData.UseVisualStyleBackColor = false;
            this.btnGerarTudoData.Click += new System.EventHandler(this.btnGerarTudoData_Click);
            // 
            // btnGerarDevolucaoData
            // 
            this.btnGerarDevolucaoData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarDevolucaoData.BackColor = System.Drawing.Color.Yellow;
            this.btnGerarDevolucaoData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarDevolucaoData.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarDevolucaoData.ForeColor = System.Drawing.Color.Black;
            this.btnGerarDevolucaoData.Location = new System.Drawing.Point(269, 80);
            this.btnGerarDevolucaoData.Name = "btnGerarDevolucaoData";
            this.btnGerarDevolucaoData.Size = new System.Drawing.Size(104, 28);
            this.btnGerarDevolucaoData.TabIndex = 15;
            this.btnGerarDevolucaoData.Text = "Gerar Devoluções";
            this.btnGerarDevolucaoData.UseVisualStyleBackColor = false;
            this.btnGerarDevolucaoData.Click += new System.EventHandler(this.btnGerarDevolucaoData_Click);
            // 
            // btnGerarDevolucoesCracha
            // 
            this.btnGerarDevolucoesCracha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarDevolucoesCracha.BackColor = System.Drawing.Color.Yellow;
            this.btnGerarDevolucoesCracha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarDevolucoesCracha.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarDevolucoesCracha.ForeColor = System.Drawing.Color.Black;
            this.btnGerarDevolucoesCracha.Location = new System.Drawing.Point(213, 215);
            this.btnGerarDevolucoesCracha.Name = "btnGerarDevolucoesCracha";
            this.btnGerarDevolucoesCracha.Size = new System.Drawing.Size(160, 28);
            this.btnGerarDevolucoesCracha.TabIndex = 14;
            this.btnGerarDevolucoesCracha.Text = "Gerar Devoluções";
            this.btnGerarDevolucoesCracha.UseVisualStyleBackColor = false;
            this.btnGerarDevolucoesCracha.Click += new System.EventHandler(this.btnGerarDevolucoesCracha_Click);
            // 
            // btnGerarSaidaCracha
            // 
            this.btnGerarSaidaCracha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarSaidaCracha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGerarSaidaCracha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarSaidaCracha.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarSaidaCracha.ForeColor = System.Drawing.Color.White;
            this.btnGerarSaidaCracha.Location = new System.Drawing.Point(19, 215);
            this.btnGerarSaidaCracha.Name = "btnGerarSaidaCracha";
            this.btnGerarSaidaCracha.Size = new System.Drawing.Size(161, 28);
            this.btnGerarSaidaCracha.TabIndex = 12;
            this.btnGerarSaidaCracha.Text = "Gerar Saidas";
            this.btnGerarSaidaCracha.UseVisualStyleBackColor = false;
            this.btnGerarSaidaCracha.Click += new System.EventHandler(this.btnGerarSaidaCracha_Click);
            // 
            // txtNomeRequisitante
            // 
            this.txtNomeRequisitante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeRequisitante.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeRequisitante.Location = new System.Drawing.Point(213, 174);
            this.txtNomeRequisitante.Name = "txtNomeRequisitante";
            this.txtNomeRequisitante.Size = new System.Drawing.Size(160, 21);
            this.txtNomeRequisitante.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.Green;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(158, 172);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCracha
            // 
            this.txtCracha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCracha.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCracha.Location = new System.Drawing.Point(114, 174);
            this.txtCracha.Name = "txtCracha";
            this.txtCracha.Size = new System.Drawing.Size(38, 21);
            this.txtCracha.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtrar por crachá";
            // 
            // btnGerarSaidas
            // 
            this.btnGerarSaidas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarSaidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGerarSaidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarSaidas.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarSaidas.ForeColor = System.Drawing.Color.White;
            this.btnGerarSaidas.Location = new System.Drawing.Point(143, 80);
            this.btnGerarSaidas.Name = "btnGerarSaidas";
            this.btnGerarSaidas.Size = new System.Drawing.Size(103, 28);
            this.btnGerarSaidas.TabIndex = 6;
            this.btnGerarSaidas.Text = "Gerar Saidas";
            this.btnGerarSaidas.UseVisualStyleBackColor = false;
            this.btnGerarSaidas.Click += new System.EventHandler(this.btnGerarSaidas_Click);
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(15, 41);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(83, 16);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Filtrar por data";
            // 
            // txtDataMovimentacao
            // 
            this.txtDataMovimentacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDataMovimentacao.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataMovimentacao.Location = new System.Drawing.Point(114, 40);
            this.txtDataMovimentacao.Name = "txtDataMovimentacao";
            this.txtDataMovimentacao.Size = new System.Drawing.Size(259, 21);
            this.txtDataMovimentacao.TabIndex = 3;
            // 
            // btnBuscarPorData
            // 
            this.btnBuscarPorData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarPorData.BackColor = System.Drawing.Color.Green;
            this.btnBuscarPorData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPorData.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorData.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorData.Location = new System.Drawing.Point(19, 80);
            this.btnBuscarPorData.Name = "btnBuscarPorData";
            this.btnBuscarPorData.Size = new System.Drawing.Size(103, 28);
            this.btnBuscarPorData.TabIndex = 0;
            this.btnBuscarPorData.Text = "Gerar Entradas";
            this.btnBuscarPorData.UseVisualStyleBackColor = false;
            this.btnBuscarPorData.Click += new System.EventHandler(this.btnBuscarPorData_Click);
            // 
            // grpTitulo
            // 
            this.grpTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpTitulo.Controls.Add(this.label2);
            this.grpTitulo.Location = new System.Drawing.Point(25, 12);
            this.grpTitulo.Name = "grpTitulo";
            this.grpTitulo.Size = new System.Drawing.Size(619, 100);
            this.grpTitulo.TabIndex = 3;
            this.grpTitulo.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(239, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Relatórios";
            // 
            // TelaRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 481);
            this.Controls.Add(this.grpTitulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpMovimentacoes);
            this.Name = "TelaRelatorios";
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.TelaRelatorios_Load);
            this.grpMovimentacoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpTitulo.ResumeLayout(false);
            this.grpTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRelatorioHistorico;
        private System.Windows.Forms.GroupBox grpMovimentacoes;
        private System.Windows.Forms.Button btnExibirSaidas;
        private System.Windows.Forms.Button btnExibirEntradas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDataMovimentacao;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnGerarSaidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCracha;
        private System.Windows.Forms.Button btnGerarSaidaCracha;
        private System.Windows.Forms.TextBox txtNomeRequisitante;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBuscarPorData;
        private System.Windows.Forms.Button btnGerarDevolucoesCracha;
        private System.Windows.Forms.Button btnGerarDevolucao;
        private System.Windows.Forms.GroupBox grpTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGerarDevolucaoData;
        private System.Windows.Forms.Button btnGerarTudoData;
        private System.Windows.Forms.Button btnGerarTudoCraha;
    }
}

