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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRelatorios));
            this.btnRelatorioHistorico = new System.Windows.Forms.Button();
            this.grpMovimentacoes = new System.Windows.Forms.GroupBox();
            this.btnEstoqueMin = new System.Windows.Forms.Button();
            this.btnGerarDevolucao = new System.Windows.Forms.Button();
            this.btnExibirSaidas = new System.Windows.Forms.Button();
            this.btnExibirEntradas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.btnBuscarEmpresa = new System.Windows.Forms.Button();
            this.btnGerarEntrada = new System.Windows.Forms.Button();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGerarEntradas = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscarPorItem = new System.Windows.Forms.Button();
            this.btnGerarSaidaPorItem = new System.Windows.Forms.Button();
            this.btnGerarTudoPorItem = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnGerarDevolucaoPorItem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCracha = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNomeRequisitante = new System.Windows.Forms.TextBox();
            this.btnGerarSaidaCracha = new System.Windows.Forms.Button();
            this.btnGerarDevolucoesCracha = new System.Windows.Forms.Button();
            this.btnGerarTudoCraha = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblData = new System.Windows.Forms.Label();
            this.btnBuscarPorData = new System.Windows.Forms.Button();
            this.txtDataMovimentacao = new System.Windows.Forms.TextBox();
            this.btnGerarSaidas = new System.Windows.Forms.Button();
            this.btnGerarDevolucaoData = new System.Windows.Forms.Button();
            this.btnGerarTudoData = new System.Windows.Forms.Button();
            this.grpTitulo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpMovimentacoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.btnRelatorioHistorico.Location = new System.Drawing.Point(18, 94);
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
            this.grpMovimentacoes.Controls.Add(this.btnEstoqueMin);
            this.grpMovimentacoes.Controls.Add(this.btnGerarDevolucao);
            this.grpMovimentacoes.Controls.Add(this.btnExibirSaidas);
            this.grpMovimentacoes.Controls.Add(this.btnExibirEntradas);
            this.grpMovimentacoes.Controls.Add(this.btnRelatorioHistorico);
            this.grpMovimentacoes.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMovimentacoes.ForeColor = System.Drawing.Color.Navy;
            this.grpMovimentacoes.Location = new System.Drawing.Point(24, 144);
            this.grpMovimentacoes.Name = "grpMovimentacoes";
            this.grpMovimentacoes.Size = new System.Drawing.Size(181, 389);
            this.grpMovimentacoes.TabIndex = 1;
            this.grpMovimentacoes.TabStop = false;
            this.grpMovimentacoes.Text = "Movimentações Gerais";
            // 
            // btnEstoqueMin
            // 
            this.btnEstoqueMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEstoqueMin.BackColor = System.Drawing.Color.Navy;
            this.btnEstoqueMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoqueMin.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueMin.ForeColor = System.Drawing.Color.White;
            this.btnEstoqueMin.Location = new System.Drawing.Point(18, 282);
            this.btnEstoqueMin.Name = "btnEstoqueMin";
            this.btnEstoqueMin.Size = new System.Drawing.Size(139, 28);
            this.btnEstoqueMin.TabIndex = 5;
            this.btnEstoqueMin.Text = "Gerar Estoque Min";
            this.btnEstoqueMin.UseVisualStyleBackColor = false;
            this.btnEstoqueMin.Click += new System.EventHandler(this.btnEstoqueMin_Click);
            // 
            // btnGerarDevolucao
            // 
            this.btnGerarDevolucao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarDevolucao.BackColor = System.Drawing.Color.Navy;
            this.btnGerarDevolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarDevolucao.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarDevolucao.ForeColor = System.Drawing.Color.White;
            this.btnGerarDevolucao.Location = new System.Drawing.Point(18, 234);
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
            this.btnExibirSaidas.Location = new System.Drawing.Point(18, 185);
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
            this.btnExibirEntradas.Location = new System.Drawing.Point(18, 140);
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
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(223, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 389);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerar por filtro";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblCnpj);
            this.groupBox5.Controls.Add(this.txtCnpj);
            this.groupBox5.Controls.Add(this.btnBuscarEmpresa);
            this.groupBox5.Controls.Add(this.btnGerarEntrada);
            this.groupBox5.Controls.Add(this.txtNomeEmpresa);
            this.groupBox5.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(477, 204);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(390, 156);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pesquisar entradas por empresa";
            // 
            // lblCnpj
            // 
            this.lblCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(10, 48);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(27, 16);
            this.lblCnpj.TabIndex = 25;
            this.lblCnpj.Text = "Cnpj";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCnpj.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(43, 47);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(97, 21);
            this.txtCnpj.TabIndex = 26;
            // 
            // btnBuscarEmpresa
            // 
            this.btnBuscarEmpresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarEmpresa.BackColor = System.Drawing.Color.Green;
            this.btnBuscarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpresa.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEmpresa.Location = new System.Drawing.Point(146, 45);
            this.btnBuscarEmpresa.Name = "btnBuscarEmpresa";
            this.btnBuscarEmpresa.Size = new System.Drawing.Size(49, 23);
            this.btnBuscarEmpresa.TabIndex = 27;
            this.btnBuscarEmpresa.Text = "Buscar";
            this.btnBuscarEmpresa.UseVisualStyleBackColor = false;
            this.btnBuscarEmpresa.Click += new System.EventHandler(this.btnBuscarEmpresa_Click);
            // 
            // btnGerarEntrada
            // 
            this.btnGerarEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarEntrada.BackColor = System.Drawing.Color.Navy;
            this.btnGerarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarEntrada.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarEntrada.ForeColor = System.Drawing.Color.White;
            this.btnGerarEntrada.Location = new System.Drawing.Point(13, 90);
            this.btnGerarEntrada.Name = "btnGerarEntrada";
            this.btnGerarEntrada.Size = new System.Drawing.Size(354, 28);
            this.btnGerarEntrada.TabIndex = 31;
            this.btnGerarEntrada.Text = "Gerar ";
            this.btnGerarEntrada.UseVisualStyleBackColor = false;
            this.btnGerarEntrada.Click += new System.EventHandler(this.btnGerarEntrada_Click);
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeEmpresa.Enabled = false;
            this.txtNomeEmpresa.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEmpresa.Location = new System.Drawing.Point(201, 47);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(164, 21);
            this.txtNomeEmpresa.TabIndex = 28;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGerarEntradas);
            this.groupBox4.Controls.Add(this.lblCodigo);
            this.groupBox4.Controls.Add(this.txtCodigo);
            this.groupBox4.Controls.Add(this.btnBuscarPorItem);
            this.groupBox4.Controls.Add(this.btnGerarSaidaPorItem);
            this.groupBox4.Controls.Add(this.btnGerarTudoPorItem);
            this.groupBox4.Controls.Add(this.txtItem);
            this.groupBox4.Controls.Add(this.btnGerarDevolucaoPorItem);
            this.groupBox4.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(33, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(426, 156);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Por item";
            // 
            // btnGerarEntradas
            // 
            this.btnGerarEntradas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarEntradas.BackColor = System.Drawing.Color.Green;
            this.btnGerarEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarEntradas.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarEntradas.ForeColor = System.Drawing.Color.White;
            this.btnGerarEntradas.Location = new System.Drawing.Point(26, 69);
            this.btnGerarEntradas.Name = "btnGerarEntradas";
            this.btnGerarEntradas.Size = new System.Drawing.Size(105, 28);
            this.btnGerarEntradas.TabIndex = 25;
            this.btnGerarEntradas.Text = "Gerar Entradas";
            this.btnGerarEntradas.UseVisualStyleBackColor = false;
            this.btnGerarEntradas.Click += new System.EventHandler(this.btnGerarEntradas_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(25, 34);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(79, 16);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Codigo do item";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(120, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(70, 21);
            this.txtCodigo.TabIndex = 19;
            // 
            // btnBuscarPorItem
            // 
            this.btnBuscarPorItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarPorItem.BackColor = System.Drawing.Color.Green;
            this.btnBuscarPorItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPorItem.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorItem.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorItem.Location = new System.Drawing.Point(196, 31);
            this.btnBuscarPorItem.Name = "btnBuscarPorItem";
            this.btnBuscarPorItem.Size = new System.Drawing.Size(49, 23);
            this.btnBuscarPorItem.TabIndex = 20;
            this.btnBuscarPorItem.Text = "Buscar";
            this.btnBuscarPorItem.UseVisualStyleBackColor = false;
            this.btnBuscarPorItem.Click += new System.EventHandler(this.btnBuscarPorItem_Click);
            // 
            // btnGerarSaidaPorItem
            // 
            this.btnGerarSaidaPorItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarSaidaPorItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGerarSaidaPorItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarSaidaPorItem.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarSaidaPorItem.ForeColor = System.Drawing.Color.White;
            this.btnGerarSaidaPorItem.Location = new System.Drawing.Point(150, 69);
            this.btnGerarSaidaPorItem.Name = "btnGerarSaidaPorItem";
            this.btnGerarSaidaPorItem.Size = new System.Drawing.Size(102, 28);
            this.btnGerarSaidaPorItem.TabIndex = 22;
            this.btnGerarSaidaPorItem.Text = "Gerar Saidas";
            this.btnGerarSaidaPorItem.UseVisualStyleBackColor = false;
            this.btnGerarSaidaPorItem.Click += new System.EventHandler(this.btnGerarSaidaPorItem_Click);
            // 
            // btnGerarTudoPorItem
            // 
            this.btnGerarTudoPorItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarTudoPorItem.BackColor = System.Drawing.Color.Navy;
            this.btnGerarTudoPorItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarTudoPorItem.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarTudoPorItem.ForeColor = System.Drawing.Color.White;
            this.btnGerarTudoPorItem.Location = new System.Drawing.Point(26, 103);
            this.btnGerarTudoPorItem.Name = "btnGerarTudoPorItem";
            this.btnGerarTudoPorItem.Size = new System.Drawing.Size(354, 28);
            this.btnGerarTudoPorItem.TabIndex = 24;
            this.btnGerarTudoPorItem.Text = "Gerar tudo";
            this.btnGerarTudoPorItem.UseVisualStyleBackColor = false;
            this.btnGerarTudoPorItem.Click += new System.EventHandler(this.btnGerarTudoPorItem_Click);
            // 
            // txtItem
            // 
            this.txtItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItem.Enabled = false;
            this.txtItem.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(255, 33);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(125, 21);
            this.txtItem.TabIndex = 21;
            // 
            // btnGerarDevolucaoPorItem
            // 
            this.btnGerarDevolucaoPorItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarDevolucaoPorItem.BackColor = System.Drawing.Color.Yellow;
            this.btnGerarDevolucaoPorItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarDevolucaoPorItem.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarDevolucaoPorItem.ForeColor = System.Drawing.Color.Black;
            this.btnGerarDevolucaoPorItem.Location = new System.Drawing.Point(268, 69);
            this.btnGerarDevolucaoPorItem.Name = "btnGerarDevolucaoPorItem";
            this.btnGerarDevolucaoPorItem.Size = new System.Drawing.Size(111, 28);
            this.btnGerarDevolucaoPorItem.TabIndex = 23;
            this.btnGerarDevolucaoPorItem.Text = "Gerar Devoluções";
            this.btnGerarDevolucaoPorItem.UseVisualStyleBackColor = false;
            this.btnGerarDevolucaoPorItem.Click += new System.EventHandler(this.btnGerarDevolucaoPorItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtCracha);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtNomeRequisitante);
            this.groupBox3.Controls.Add(this.btnGerarSaidaCracha);
            this.groupBox3.Controls.Add(this.btnGerarDevolucoesCracha);
            this.groupBox3.Controls.Add(this.btnGerarTudoCraha);
            this.groupBox3.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(465, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 167);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Por colaborador";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtrar por crachá";
            // 
            // txtCracha
            // 
            this.txtCracha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCracha.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCracha.Location = new System.Drawing.Point(120, 29);
            this.txtCracha.Name = "txtCracha";
            this.txtCracha.Size = new System.Drawing.Size(38, 21);
            this.txtCracha.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.Green;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(164, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNomeRequisitante
            // 
            this.txtNomeRequisitante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeRequisitante.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeRequisitante.Location = new System.Drawing.Point(219, 29);
            this.txtNomeRequisitante.Name = "txtNomeRequisitante";
            this.txtNomeRequisitante.Size = new System.Drawing.Size(160, 21);
            this.txtNomeRequisitante.TabIndex = 10;
            // 
            // btnGerarSaidaCracha
            // 
            this.btnGerarSaidaCracha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarSaidaCracha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGerarSaidaCracha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarSaidaCracha.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarSaidaCracha.ForeColor = System.Drawing.Color.White;
            this.btnGerarSaidaCracha.Location = new System.Drawing.Point(25, 70);
            this.btnGerarSaidaCracha.Name = "btnGerarSaidaCracha";
            this.btnGerarSaidaCracha.Size = new System.Drawing.Size(161, 28);
            this.btnGerarSaidaCracha.TabIndex = 12;
            this.btnGerarSaidaCracha.Text = "Gerar Saidas";
            this.btnGerarSaidaCracha.UseVisualStyleBackColor = false;
            this.btnGerarSaidaCracha.Click += new System.EventHandler(this.btnGerarSaidaCracha_Click);
            // 
            // btnGerarDevolucoesCracha
            // 
            this.btnGerarDevolucoesCracha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarDevolucoesCracha.BackColor = System.Drawing.Color.Yellow;
            this.btnGerarDevolucoesCracha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarDevolucoesCracha.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarDevolucoesCracha.ForeColor = System.Drawing.Color.Black;
            this.btnGerarDevolucoesCracha.Location = new System.Drawing.Point(219, 70);
            this.btnGerarDevolucoesCracha.Name = "btnGerarDevolucoesCracha";
            this.btnGerarDevolucoesCracha.Size = new System.Drawing.Size(160, 28);
            this.btnGerarDevolucoesCracha.TabIndex = 14;
            this.btnGerarDevolucoesCracha.Text = "Gerar Devoluções";
            this.btnGerarDevolucoesCracha.UseVisualStyleBackColor = false;
            this.btnGerarDevolucoesCracha.Click += new System.EventHandler(this.btnGerarDevolucoesCracha_Click);
            // 
            // btnGerarTudoCraha
            // 
            this.btnGerarTudoCraha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarTudoCraha.BackColor = System.Drawing.Color.Navy;
            this.btnGerarTudoCraha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarTudoCraha.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarTudoCraha.ForeColor = System.Drawing.Color.White;
            this.btnGerarTudoCraha.Location = new System.Drawing.Point(25, 115);
            this.btnGerarTudoCraha.Name = "btnGerarTudoCraha";
            this.btnGerarTudoCraha.Size = new System.Drawing.Size(354, 28);
            this.btnGerarTudoCraha.TabIndex = 17;
            this.btnGerarTudoCraha.Text = "Gerar tudo";
            this.btnGerarTudoCraha.UseVisualStyleBackColor = false;
            this.btnGerarTudoCraha.Click += new System.EventHandler(this.btnGerarTudoCraha_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblData);
            this.groupBox2.Controls.Add(this.btnBuscarPorData);
            this.groupBox2.Controls.Add(this.txtDataMovimentacao);
            this.groupBox2.Controls.Add(this.btnGerarSaidas);
            this.groupBox2.Controls.Add(this.btnGerarDevolucaoData);
            this.groupBox2.Controls.Add(this.btnGerarTudoData);
            this.groupBox2.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 167);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Por data";
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(24, 31);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(83, 16);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Filtrar por data";
            // 
            // btnBuscarPorData
            // 
            this.btnBuscarPorData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarPorData.BackColor = System.Drawing.Color.Green;
            this.btnBuscarPorData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPorData.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorData.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorData.Location = new System.Drawing.Point(28, 70);
            this.btnBuscarPorData.Name = "btnBuscarPorData";
            this.btnBuscarPorData.Size = new System.Drawing.Size(103, 28);
            this.btnBuscarPorData.TabIndex = 0;
            this.btnBuscarPorData.Text = "Gerar Entradas";
            this.btnBuscarPorData.UseVisualStyleBackColor = false;
            this.btnBuscarPorData.Click += new System.EventHandler(this.btnBuscarPorData_Click);
            // 
            // txtDataMovimentacao
            // 
            this.txtDataMovimentacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDataMovimentacao.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataMovimentacao.Location = new System.Drawing.Point(123, 30);
            this.txtDataMovimentacao.Name = "txtDataMovimentacao";
            this.txtDataMovimentacao.Size = new System.Drawing.Size(259, 21);
            this.txtDataMovimentacao.TabIndex = 3;
            // 
            // btnGerarSaidas
            // 
            this.btnGerarSaidas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarSaidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGerarSaidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarSaidas.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarSaidas.ForeColor = System.Drawing.Color.White;
            this.btnGerarSaidas.Location = new System.Drawing.Point(152, 70);
            this.btnGerarSaidas.Name = "btnGerarSaidas";
            this.btnGerarSaidas.Size = new System.Drawing.Size(103, 28);
            this.btnGerarSaidas.TabIndex = 6;
            this.btnGerarSaidas.Text = "Gerar Saidas";
            this.btnGerarSaidas.UseVisualStyleBackColor = false;
            this.btnGerarSaidas.Click += new System.EventHandler(this.btnGerarSaidas_Click);
            // 
            // btnGerarDevolucaoData
            // 
            this.btnGerarDevolucaoData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarDevolucaoData.BackColor = System.Drawing.Color.Yellow;
            this.btnGerarDevolucaoData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarDevolucaoData.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarDevolucaoData.ForeColor = System.Drawing.Color.Black;
            this.btnGerarDevolucaoData.Location = new System.Drawing.Point(278, 70);
            this.btnGerarDevolucaoData.Name = "btnGerarDevolucaoData";
            this.btnGerarDevolucaoData.Size = new System.Drawing.Size(104, 28);
            this.btnGerarDevolucaoData.TabIndex = 15;
            this.btnGerarDevolucaoData.Text = "Gerar Devoluções";
            this.btnGerarDevolucaoData.UseVisualStyleBackColor = false;
            this.btnGerarDevolucaoData.Click += new System.EventHandler(this.btnGerarDevolucaoData_Click);
            // 
            // btnGerarTudoData
            // 
            this.btnGerarTudoData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarTudoData.BackColor = System.Drawing.Color.Navy;
            this.btnGerarTudoData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarTudoData.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarTudoData.ForeColor = System.Drawing.Color.White;
            this.btnGerarTudoData.Location = new System.Drawing.Point(28, 114);
            this.btnGerarTudoData.Name = "btnGerarTudoData";
            this.btnGerarTudoData.Size = new System.Drawing.Size(354, 28);
            this.btnGerarTudoData.TabIndex = 16;
            this.btnGerarTudoData.Text = "Gerar tudo";
            this.btnGerarTudoData.UseVisualStyleBackColor = false;
            this.btnGerarTudoData.Click += new System.EventHandler(this.btnGerarTudoData_Click);
            // 
            // grpTitulo
            // 
            this.grpTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpTitulo.Controls.Add(this.label2);
            this.grpTitulo.Location = new System.Drawing.Point(24, 12);
            this.grpTitulo.Name = "grpTitulo";
            this.grpTitulo.Size = new System.Drawing.Size(1086, 115);
            this.grpTitulo.TabIndex = 25;
            this.grpTitulo.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(473, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Relatórios";
            // 
            // TelaRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 617);
            this.Controls.Add(this.grpTitulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpMovimentacoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaRelatorios";
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.TelaRelatorios_Load);
            this.grpMovimentacoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button btnGerarDevolucaoData;
        private System.Windows.Forms.Button btnGerarTudoData;
        private System.Windows.Forms.Button btnGerarTudoCraha;
        private System.Windows.Forms.Button btnEstoqueMin;
        private System.Windows.Forms.Button btnGerarTudoPorItem;
        private System.Windows.Forms.Button btnGerarDevolucaoPorItem;
        private System.Windows.Forms.Button btnGerarSaidaPorItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnBuscarPorItem;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox grpTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Button btnBuscarEmpresa;
        private System.Windows.Forms.Button btnGerarEntrada;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Button btnGerarEntradas;
    }
}

