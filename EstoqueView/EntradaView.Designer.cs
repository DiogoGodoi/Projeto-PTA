namespace EstoqueView
{
    partial class EntradaView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaView));
            this.grdTitulo = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.listSaida = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.lblNf = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.btnBuscaEmpresa = new System.Windows.Forms.Button();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.btnAcrescentar = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblRequisitante = new System.Windows.Forms.Label();
            this.btnAdcionar = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.grdEstoque = new System.Windows.Forms.DataGridView();
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueTB = new EstoqueView.EstoqueTB();
            this.estoqueTableAdapter = new EstoqueView.EstoqueTBTableAdapters.EstoqueTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdTitulo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueTB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdTitulo
            // 
            this.grdTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdTitulo.Controls.Add(this.lblTitulo);
            this.grdTitulo.Location = new System.Drawing.Point(20, 25);
            this.grdTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.grdTitulo.Name = "grdTitulo";
            this.grdTitulo.Padding = new System.Windows.Forms.Padding(2);
            this.grdTitulo.Size = new System.Drawing.Size(1150, 81);
            this.grdTitulo.TabIndex = 32;
            this.grdTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bernard MT Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(537, 25);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(115, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ENTRADA";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(213, 499);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(121, 23);
            this.btnConfirmar.TabIndex = 31;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemover.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(432, 499);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(121, 23);
            this.btnRemover.TabIndex = 30;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // listSaida
            // 
            this.listSaida.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listSaida.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listSaida.FullRowSelect = true;
            this.listSaida.GridLines = true;
            this.listSaida.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listSaida.HideSelection = false;
            this.listSaida.Location = new System.Drawing.Point(20, 282);
            this.listSaida.Margin = new System.Windows.Forms.Padding(2);
            this.listSaida.MultiSelect = false;
            this.listSaida.Name = "listSaida";
            this.listSaida.Size = new System.Drawing.Size(718, 171);
            this.listSaida.TabIndex = 29;
            this.listSaida.UseCompatibleStateImageBehavior = false;
            this.listSaida.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item";
            this.columnHeader2.Width = 500;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantidade";
            this.columnHeader3.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox2.Controls.Add(this.txtNF);
            this.groupBox2.Controls.Add(this.lblNf);
            this.groupBox2.Controls.Add(this.lblCnpj);
            this.groupBox2.Controls.Add(this.btnBuscaEmpresa);
            this.groupBox2.Controls.Add(this.txtNomeEmpresa);
            this.groupBox2.Controls.Add(this.txtCnpj);
            this.groupBox2.Controls.Add(this.lblNomeEmpresa);
            this.groupBox2.Controls.Add(this.btnAcrescentar);
            this.groupBox2.Controls.Add(this.txtItem);
            this.groupBox2.Controls.Add(this.lblRequisitante);
            this.groupBox2.Controls.Add(this.btnAdcionar);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSubtrair);
            this.groupBox2.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(20, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 155);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimentar Estoque";
            // 
            // txtNF
            // 
            this.txtNF.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNF.Location = new System.Drawing.Point(636, 33);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(40, 21);
            this.txtNF.TabIndex = 31;
            // 
            // lblNf
            // 
            this.lblNf.AutoSize = true;
            this.lblNf.ForeColor = System.Drawing.Color.Black;
            this.lblNf.Location = new System.Drawing.Point(612, 35);
            this.lblNf.Name = "lblNf";
            this.lblNf.Size = new System.Drawing.Size(18, 16);
            this.lblNf.TabIndex = 30;
            this.lblNf.Text = "NF";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.ForeColor = System.Drawing.Color.Black;
            this.lblCnpj.Location = new System.Drawing.Point(15, 35);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(27, 16);
            this.lblCnpj.TabIndex = 29;
            this.lblCnpj.Text = "Cnpj";
            // 
            // btnBuscaEmpresa
            // 
            this.btnBuscaEmpresa.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBuscaEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBuscaEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnBuscaEmpresa.Location = new System.Drawing.Point(206, 31);
            this.btnBuscaEmpresa.Name = "btnBuscaEmpresa";
            this.btnBuscaEmpresa.Size = new System.Drawing.Size(47, 23);
            this.btnBuscaEmpresa.TabIndex = 28;
            this.btnBuscaEmpresa.Text = "Buscar";
            this.btnBuscaEmpresa.UseVisualStyleBackColor = false;
            this.btnBuscaEmpresa.Click += new System.EventHandler(this.btnBuscaEmpresa_Click);
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Enabled = false;
            this.txtNomeEmpresa.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEmpresa.Location = new System.Drawing.Point(320, 34);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(286, 21);
            this.txtNomeEmpresa.TabIndex = 27;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(60, 32);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(140, 23);
            this.txtCnpj.TabIndex = 26;
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.ForeColor = System.Drawing.Color.Black;
            this.lblNomeEmpresa.Location = new System.Drawing.Point(266, 35);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(48, 16);
            this.lblNomeEmpresa.TabIndex = 25;
            this.lblNomeEmpresa.Text = "Empresa";
            // 
            // btnAcrescentar
            // 
            this.btnAcrescentar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAcrescentar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAcrescentar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcrescentar.ForeColor = System.Drawing.Color.White;
            this.btnAcrescentar.Location = new System.Drawing.Point(235, 103);
            this.btnAcrescentar.Name = "btnAcrescentar";
            this.btnAcrescentar.Size = new System.Drawing.Size(122, 23);
            this.btnAcrescentar.TabIndex = 16;
            this.btnAcrescentar.Text = "+";
            this.btnAcrescentar.UseVisualStyleBackColor = false;
            this.btnAcrescentar.Click += new System.EventHandler(this.btnAcrescentar_Click);
            // 
            // txtItem
            // 
            this.txtItem.Enabled = false;
            this.txtItem.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(60, 66);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(616, 21);
            this.txtItem.TabIndex = 22;
            // 
            // lblRequisitante
            // 
            this.lblRequisitante.AutoSize = true;
            this.lblRequisitante.ForeColor = System.Drawing.Color.Black;
            this.lblRequisitante.Location = new System.Drawing.Point(15, 71);
            this.lblRequisitante.Name = "lblRequisitante";
            this.lblRequisitante.Size = new System.Drawing.Size(30, 16);
            this.lblRequisitante.TabIndex = 20;
            this.lblRequisitante.Text = "Item";
            // 
            // btnAdcionar
            // 
            this.btnAdcionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdcionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdcionar.ForeColor = System.Drawing.Color.White;
            this.btnAdcionar.Location = new System.Drawing.Point(558, 103);
            this.btnAdcionar.Name = "btnAdcionar";
            this.btnAdcionar.Size = new System.Drawing.Size(121, 23);
            this.btnAdcionar.TabIndex = 19;
            this.btnAdcionar.Text = "Adcionar";
            this.btnAdcionar.UseVisualStyleBackColor = false;
            this.btnAdcionar.Click += new System.EventHandler(this.btnAdcionar_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(82, 103);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(118, 23);
            this.txtQuantidade.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Quantidade";
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubtrair.ForeColor = System.Drawing.Color.White;
            this.btnSubtrair.Location = new System.Drawing.Point(400, 103);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(122, 23);
            this.btnSubtrair.TabIndex = 17;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // grdEstoque
            // 
            this.grdEstoque.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.grdEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEstoque.AutoGenerateColumns = false;
            this.grdEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdEstoque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdEstoque.BackgroundColor = System.Drawing.Color.Silver;
            this.grdEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.quantidade});
            this.grdEstoque.DataSource = this.estoqueBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdEstoque.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdEstoque.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.grdEstoque.Location = new System.Drawing.Point(791, 215);
            this.grdEstoque.Name = "grdEstoque";
            this.grdEstoque.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdEstoque.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEstoque.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdEstoque.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdEstoque.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Navy;
            this.grdEstoque.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.grdEstoque.RowTemplate.DefaultCellStyle.Format = "N0";
            this.grdEstoque.RowTemplate.DefaultCellStyle.NullValue = null;
            this.grdEstoque.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grdEstoque.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEstoque.RowTemplate.Height = 15;
            this.grdEstoque.Size = new System.Drawing.Size(379, 307);
            this.grdEstoque.TabIndex = 33;
            this.grdEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEstoque_CellContentClick_1);
            this.grdEstoque.DoubleClick += new System.EventHandler(this.grdEstoque_CellContentClick_1);
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataMember = "Estoque";
            this.estoqueBindingSource.DataSource = this.estoqueTB;
            // 
            // estoqueTB
            // 
            this.estoqueTB.DataSetName = "EstoqueTB";
            this.estoqueTB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtProcurar);
            this.groupBox1.Controls.Add(this.btnProcurar);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(788, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 77);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // txtProcurar
            // 
            this.txtProcurar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProcurar.Location = new System.Drawing.Point(138, 31);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(224, 23);
            this.txtProcurar.TabIndex = 5;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProcurar.BackColor = System.Drawing.Color.Navy;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProcurar.ForeColor = System.Drawing.Color.White;
            this.btnProcurar.Location = new System.Drawing.Point(54, 31);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(78, 23);
            this.btnProcurar.TabIndex = 4;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(13, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(34, 16);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Item";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 114;
            // 
            // EntradaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 564);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdEstoque);
            this.Controls.Add(this.grdTitulo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.listSaida);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntradaView";
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.EntradaView_Load);
            this.grdTitulo.ResumeLayout(false);
            this.grdTitulo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueTB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grdTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ListView listSaida;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Button btnBuscaEmpresa;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.Button btnAcrescentar;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnAdcionar;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.TextBox txtNF;
        private System.Windows.Forms.Label lblNf;
        private System.Windows.Forms.DataGridView grdEstoque;
        private EstoqueTB estoqueTB;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private EstoqueTBTableAdapters.EstoqueTableAdapter estoqueTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRequisitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
    }
}