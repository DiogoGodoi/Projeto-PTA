namespace EstoqueView
{
    partial class SaidaView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.codFuncionario = new System.Windows.Forms.Label();
            this.btnBuscarRequisitante = new System.Windows.Forms.Button();
            this.txtNomeRequisitante = new System.Windows.Forms.TextBox();
            this.txtCracha = new System.Windows.Forms.TextBox();
            this.lblNomeRequisitante = new System.Windows.Forms.Label();
            this.btnAcrescentar = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblRequisitante = new System.Windows.Forms.Label();
            this.btnAdcionar = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listSaida = new System.Windows.Forms.ListView();
            this.grdTitulo = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.grdEstoque = new System.Windows.Forms.DataGridView();
            this.estoqueTB = new EstoqueView.estoqueTB();
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueTableAdapter = new EstoqueView.estoqueTBTableAdapters.EstoqueTableAdapter();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.grdTitulo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox2.Controls.Add(this.codFuncionario);
            this.groupBox2.Controls.Add(this.btnBuscarRequisitante);
            this.groupBox2.Controls.Add(this.txtNomeRequisitante);
            this.groupBox2.Controls.Add(this.txtCracha);
            this.groupBox2.Controls.Add(this.lblNomeRequisitante);
            this.groupBox2.Controls.Add(this.btnAcrescentar);
            this.groupBox2.Controls.Add(this.txtItem);
            this.groupBox2.Controls.Add(this.lblRequisitante);
            this.groupBox2.Controls.Add(this.btnAdcionar);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSubtrair);
            this.groupBox2.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(20, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 155);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimentar Estoque";
            // 
            // codFuncionario
            // 
            this.codFuncionario.AutoSize = true;
            this.codFuncionario.ForeColor = System.Drawing.Color.Black;
            this.codFuncionario.Location = new System.Drawing.Point(15, 35);
            this.codFuncionario.Name = "codFuncionario";
            this.codFuncionario.Size = new System.Drawing.Size(40, 16);
            this.codFuncionario.TabIndex = 29;
            this.codFuncionario.Text = "Crachá";
            // 
            // btnBuscarRequisitante
            // 
            this.btnBuscarRequisitante.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBuscarRequisitante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBuscarRequisitante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarRequisitante.ForeColor = System.Drawing.Color.White;
            this.btnBuscarRequisitante.Location = new System.Drawing.Point(206, 31);
            this.btnBuscarRequisitante.Name = "btnBuscarRequisitante";
            this.btnBuscarRequisitante.Size = new System.Drawing.Size(47, 23);
            this.btnBuscarRequisitante.TabIndex = 28;
            this.btnBuscarRequisitante.Text = "Buscar";
            this.btnBuscarRequisitante.UseVisualStyleBackColor = false;
            this.btnBuscarRequisitante.Click += new System.EventHandler(this.btnBuscarRequisitante_Click);
            // 
            // txtNomeRequisitante
            // 
            this.txtNomeRequisitante.Enabled = false;
            this.txtNomeRequisitante.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeRequisitante.Location = new System.Drawing.Point(302, 34);
            this.txtNomeRequisitante.Name = "txtNomeRequisitante";
            this.txtNomeRequisitante.Size = new System.Drawing.Size(246, 21);
            this.txtNomeRequisitante.TabIndex = 27;
            // 
            // txtCracha
            // 
            this.txtCracha.Location = new System.Drawing.Point(60, 32);
            this.txtCracha.Name = "txtCracha";
            this.txtCracha.Size = new System.Drawing.Size(140, 23);
            this.txtCracha.TabIndex = 26;
            // 
            // lblNomeRequisitante
            // 
            this.lblNomeRequisitante.AutoSize = true;
            this.lblNomeRequisitante.ForeColor = System.Drawing.Color.Black;
            this.lblNomeRequisitante.Location = new System.Drawing.Point(266, 35);
            this.lblNomeRequisitante.Name = "lblNomeRequisitante";
            this.lblNomeRequisitante.Size = new System.Drawing.Size(34, 16);
            this.lblNomeRequisitante.TabIndex = 25;
            this.lblNomeRequisitante.Text = "Nome";
            // 
            // btnAcrescentar
            // 
            this.btnAcrescentar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAcrescentar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAcrescentar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcrescentar.ForeColor = System.Drawing.Color.White;
            this.btnAcrescentar.Location = new System.Drawing.Point(171, 103);
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
            this.txtItem.Location = new System.Drawing.Point(60, 67);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(488, 21);
            this.txtItem.TabIndex = 22;
            // 
            // lblRequisitante
            // 
            this.lblRequisitante.AutoSize = true;
            this.lblRequisitante.ForeColor = System.Drawing.Color.Black;
            this.lblRequisitante.Location = new System.Drawing.Point(15, 68);
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
            this.btnAdcionar.Location = new System.Drawing.Point(426, 103);
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
            this.txtQuantidade.Size = new System.Drawing.Size(84, 23);
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
            this.btnSubtrair.Location = new System.Drawing.Point(298, 103);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(122, 23);
            this.btnSubtrair.TabIndex = 17;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemover.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(341, 488);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(121, 23);
            this.btnRemover.TabIndex = 25;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(164, 488);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(121, 23);
            this.btnConfirmar.TabIndex = 26;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item";
            this.columnHeader2.Width = 400;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantidade";
            this.columnHeader3.Width = 100;
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
            this.listSaida.Location = new System.Drawing.Point(20, 290);
            this.listSaida.Margin = new System.Windows.Forms.Padding(2);
            this.listSaida.MultiSelect = false;
            this.listSaida.Name = "listSaida";
            this.listSaida.Size = new System.Drawing.Size(560, 171);
            this.listSaida.TabIndex = 15;
            this.listSaida.UseCompatibleStateImageBehavior = false;
            this.listSaida.View = System.Windows.Forms.View.Details;
            // 
            // grdTitulo
            // 
            this.grdTitulo.Controls.Add(this.lblTitulo);
            this.grdTitulo.Location = new System.Drawing.Point(20, 10);
            this.grdTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.grdTitulo.Name = "grdTitulo";
            this.grdTitulo.Padding = new System.Windows.Forms.Padding(2);
            this.grdTitulo.Size = new System.Drawing.Size(948, 81);
            this.grdTitulo.TabIndex = 27;
            this.grdTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bernard MT Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(436, 25);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(79, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SAÍDA";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.txtProcurar);
            this.groupBox1.Controls.Add(this.btnProcurar);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(586, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 77);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // txtProcurar
            // 
            this.txtProcurar.Location = new System.Drawing.Point(138, 31);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(224, 23);
            this.txtProcurar.TabIndex = 5;
            // 
            // btnProcurar
            // 
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
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(13, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(34, 16);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn});
            this.grdEstoque.DataSource = this.estoqueBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdEstoque.DefaultCellStyle = dataGridViewCellStyle10;
            this.grdEstoque.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.grdEstoque.Location = new System.Drawing.Point(589, 204);
            this.grdEstoque.Name = "grdEstoque";
            this.grdEstoque.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grdEstoque.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEstoque.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.grdEstoque.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdEstoque.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Navy;
            this.grdEstoque.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.grdEstoque.RowTemplate.DefaultCellStyle.Format = "N0";
            this.grdEstoque.RowTemplate.DefaultCellStyle.NullValue = null;
            this.grdEstoque.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grdEstoque.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEstoque.RowTemplate.Height = 15;
            this.grdEstoque.Size = new System.Drawing.Size(376, 307);
            this.grdEstoque.TabIndex = 35;
            this.grdEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEstoque_CellContentClick);
            // 
            // estoqueTB
            // 
            this.estoqueTB.DataSetName = "estoqueTB";
            this.estoqueTB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataMember = "Estoque";
            this.estoqueBindingSource.DataSource = this.estoqueTB;
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Item";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SaidaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 536);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdEstoque);
            this.Controls.Add(this.grdTitulo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.listSaida);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SaidaView";
            this.Text = "Saida";
            this.Load += new System.EventHandler(this.SaidaView_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grdTitulo.ResumeLayout(false);
            this.grdTitulo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblRequisitante;
        private System.Windows.Forms.Button btnAdcionar;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnAcrescentar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listSaida;
        private System.Windows.Forms.Label codFuncionario;
        private System.Windows.Forms.Button btnBuscarRequisitante;
        private System.Windows.Forms.TextBox txtNomeRequisitante;
        private System.Windows.Forms.TextBox txtCracha;
        private System.Windows.Forms.Label lblNomeRequisitante;
        private System.Windows.Forms.GroupBox grdTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView grdEstoque;
        private estoqueTB estoqueTB;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private estoqueTBTableAdapters.EstoqueTableAdapter estoqueTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    }
}