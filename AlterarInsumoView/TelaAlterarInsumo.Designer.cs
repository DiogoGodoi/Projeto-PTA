namespace AlterarInsumoView
{
    partial class TelaAlterarInsumo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAlterarInsumo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.grdInsumo = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueTB = new AlterarInsumoView.EstoqueTB();
            this.grdTitulo = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpAlterarInsumo = new System.Windows.Forms.GroupBox();
            this.lblEstoqueMin = new System.Windows.Forms.Label();
            this.txtEstoqueMin = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.grpTipoUnitario = new System.Windows.Forms.GroupBox();
            this.radPR = new System.Windows.Forms.RadioButton();
            this.radUN = new System.Windows.Forms.RadioButton();
            this.radMt = new System.Windows.Forms.RadioButton();
            this.radCL = new System.Windows.Forms.RadioButton();
            this.radBD = new System.Windows.Forms.RadioButton();
            this.radKG = new System.Windows.Forms.RadioButton();
            this.radFD = new System.Windows.Forms.RadioButton();
            this.radMI = new System.Windows.Forms.RadioButton();
            this.radGL = new System.Windows.Forms.RadioButton();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnBuscaEmpresa = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblRequisitante = new System.Windows.Forms.Label();
            this.txtTipoUnitario = new System.Windows.Forms.TextBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.estoqueTableAdapter = new AlterarInsumoView.EstoqueTBTableAdapters.EstoqueTableAdapter();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueTB)).BeginInit();
            this.grdTitulo.SuspendLayout();
            this.grpAlterarInsumo.SuspendLayout();
            this.grpTipoUnitario.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.txtProcurar);
            this.groupBox1.Controls.Add(this.btnProcurar);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(610, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 77);
            this.groupBox1.TabIndex = 39;
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
            // grdInsumo
            // 
            this.grdInsumo.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.grdInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grdInsumo.AutoGenerateColumns = false;
            this.grdInsumo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdInsumo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdInsumo.BackgroundColor = System.Drawing.Color.Silver;
            this.grdInsumo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInsumo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInsumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn});
            this.grdInsumo.DataSource = this.estoqueBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdInsumo.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdInsumo.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.grdInsumo.Location = new System.Drawing.Point(610, 245);
            this.grdInsumo.Name = "grdInsumo";
            this.grdInsumo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInsumo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdInsumo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInsumo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdInsumo.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdInsumo.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Navy;
            this.grdInsumo.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.grdInsumo.RowTemplate.DefaultCellStyle.Format = "N0";
            this.grdInsumo.RowTemplate.DefaultCellStyle.NullValue = null;
            this.grdInsumo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grdInsumo.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInsumo.RowTemplate.Height = 15;
            this.grdInsumo.Size = new System.Drawing.Size(382, 238);
            this.grdInsumo.TabIndex = 38;
            this.grdInsumo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEstoque_CellContentClick);
            this.grdInsumo.Click += new System.EventHandler(this.btnBuscaEmpresa_Click);
            this.grdInsumo.DoubleClick += new System.EventHandler(this.btnBuscaEmpresa_Click);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Item";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // grdTitulo
            // 
            this.grdTitulo.Controls.Add(this.lblTitulo);
            this.grdTitulo.Location = new System.Drawing.Point(40, 39);
            this.grdTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.grdTitulo.Name = "grdTitulo";
            this.grdTitulo.Padding = new System.Windows.Forms.Padding(2);
            this.grdTitulo.Size = new System.Drawing.Size(952, 81);
            this.grdTitulo.TabIndex = 37;
            this.grdTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bernard MT Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(389, 26);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(201, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ALTERAR INSUMO";
            // 
            // grpAlterarInsumo
            // 
            this.grpAlterarInsumo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grpAlterarInsumo.Controls.Add(this.lblEstoqueMin);
            this.grpAlterarInsumo.Controls.Add(this.txtEstoqueMin);
            this.grpAlterarInsumo.Controls.Add(this.lblQuantidade);
            this.grpAlterarInsumo.Controls.Add(this.txtQuantidade);
            this.grpAlterarInsumo.Controls.Add(this.grpTipoUnitario);
            this.grpAlterarInsumo.Controls.Add(this.lblCodigo);
            this.grpAlterarInsumo.Controls.Add(this.btnBuscaEmpresa);
            this.grpAlterarInsumo.Controls.Add(this.txtItem);
            this.grpAlterarInsumo.Controls.Add(this.txtCodigo);
            this.grpAlterarInsumo.Controls.Add(this.lblRequisitante);
            this.grpAlterarInsumo.Controls.Add(this.txtTipoUnitario);
            this.grpAlterarInsumo.Controls.Add(this.lblUnidade);
            this.grpAlterarInsumo.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAlterarInsumo.ForeColor = System.Drawing.Color.Navy;
            this.grpAlterarInsumo.Location = new System.Drawing.Point(40, 151);
            this.grpAlterarInsumo.Name = "grpAlterarInsumo";
            this.grpAlterarInsumo.Size = new System.Drawing.Size(551, 235);
            this.grpAlterarInsumo.TabIndex = 35;
            this.grpAlterarInsumo.TabStop = false;
            this.grpAlterarInsumo.Text = "Alterar Insumo";
            // 
            // lblEstoqueMin
            // 
            this.lblEstoqueMin.AutoSize = true;
            this.lblEstoqueMin.ForeColor = System.Drawing.Color.Black;
            this.lblEstoqueMin.Location = new System.Drawing.Point(402, 68);
            this.lblEstoqueMin.Name = "lblEstoqueMin";
            this.lblEstoqueMin.Size = new System.Drawing.Size(82, 16);
            this.lblEstoqueMin.TabIndex = 34;
            this.lblEstoqueMin.Text = "Estoque Minimo";
            // 
            // txtEstoqueMin
            // 
            this.txtEstoqueMin.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueMin.Location = new System.Drawing.Point(492, 67);
            this.txtEstoqueMin.Name = "txtEstoqueMin";
            this.txtEstoqueMin.Size = new System.Drawing.Size(36, 21);
            this.txtEstoqueMin.TabIndex = 33;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.ForeColor = System.Drawing.Color.Black;
            this.lblQuantidade.Location = new System.Drawing.Point(268, 67);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(63, 16);
            this.lblQuantidade.TabIndex = 32;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(335, 66);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(61, 21);
            this.txtQuantidade.TabIndex = 31;
            // 
            // grpTipoUnitario
            // 
            this.grpTipoUnitario.Controls.Add(this.radPR);
            this.grpTipoUnitario.Controls.Add(this.radUN);
            this.grpTipoUnitario.Controls.Add(this.radMt);
            this.grpTipoUnitario.Controls.Add(this.radCL);
            this.grpTipoUnitario.Controls.Add(this.radBD);
            this.grpTipoUnitario.Controls.Add(this.radKG);
            this.grpTipoUnitario.Controls.Add(this.radFD);
            this.grpTipoUnitario.Controls.Add(this.radMI);
            this.grpTipoUnitario.Controls.Add(this.radGL);
            this.grpTipoUnitario.Location = new System.Drawing.Point(17, 103);
            this.grpTipoUnitario.Name = "grpTipoUnitario";
            this.grpTipoUnitario.Size = new System.Drawing.Size(511, 117);
            this.grpTipoUnitario.TabIndex = 30;
            this.grpTipoUnitario.TabStop = false;
            this.grpTipoUnitario.Text = "Selecione o tipo unitário";
            // 
            // radPR
            // 
            this.radPR.AutoSize = true;
            this.radPR.Location = new System.Drawing.Point(356, 38);
            this.radPR.Name = "radPR";
            this.radPR.Size = new System.Drawing.Size(39, 20);
            this.radPR.TabIndex = 48;
            this.radPR.TabStop = true;
            this.radPR.Text = "PR";
            this.radPR.UseVisualStyleBackColor = true;
            this.radPR.CheckedChanged += new System.EventHandler(this.radPR_CheckedChanged);
            // 
            // radUN
            // 
            this.radUN.AutoSize = true;
            this.radUN.Location = new System.Drawing.Point(128, 38);
            this.radUN.Name = "radUN";
            this.radUN.Size = new System.Drawing.Size(37, 20);
            this.radUN.TabIndex = 40;
            this.radUN.TabStop = true;
            this.radUN.Text = "UN";
            this.radUN.UseVisualStyleBackColor = true;
            this.radUN.CheckedChanged += new System.EventHandler(this.radUN_CheckedChanged);
            // 
            // radMt
            // 
            this.radMt.AutoSize = true;
            this.radMt.Location = new System.Drawing.Point(299, 77);
            this.radMt.Name = "radMt";
            this.radMt.Size = new System.Drawing.Size(39, 20);
            this.radMt.TabIndex = 47;
            this.radMt.TabStop = true;
            this.radMt.Text = "MT";
            this.radMt.UseVisualStyleBackColor = true;
            this.radMt.CheckedChanged += new System.EventHandler(this.radMt_CheckedChanged);
            // 
            // radCL
            // 
            this.radCL.AutoSize = true;
            this.radCL.Location = new System.Drawing.Point(186, 38);
            this.radCL.Name = "radCL";
            this.radCL.Size = new System.Drawing.Size(35, 20);
            this.radCL.TabIndex = 41;
            this.radCL.TabStop = true;
            this.radCL.Text = "CL";
            this.radCL.UseVisualStyleBackColor = true;
            this.radCL.CheckedChanged += new System.EventHandler(this.radCL_CheckedChanged);
            // 
            // radBD
            // 
            this.radBD.AutoSize = true;
            this.radBD.Location = new System.Drawing.Point(246, 77);
            this.radBD.Name = "radBD";
            this.radBD.Size = new System.Drawing.Size(39, 20);
            this.radBD.TabIndex = 46;
            this.radBD.TabStop = true;
            this.radBD.Text = "BD";
            this.radBD.UseVisualStyleBackColor = true;
            this.radBD.CheckedChanged += new System.EventHandler(this.radBD_CheckedChanged);
            // 
            // radKG
            // 
            this.radKG.AutoSize = true;
            this.radKG.Location = new System.Drawing.Point(246, 38);
            this.radKG.Name = "radKG";
            this.radKG.Size = new System.Drawing.Size(39, 20);
            this.radKG.TabIndex = 42;
            this.radKG.TabStop = true;
            this.radKG.Text = "KG";
            this.radKG.UseVisualStyleBackColor = true;
            this.radKG.CheckedChanged += new System.EventHandler(this.radKG_CheckedChanged);
            // 
            // radFD
            // 
            this.radFD.AutoSize = true;
            this.radFD.Location = new System.Drawing.Point(186, 77);
            this.radFD.Name = "radFD";
            this.radFD.Size = new System.Drawing.Size(37, 20);
            this.radFD.TabIndex = 45;
            this.radFD.TabStop = true;
            this.radFD.Text = "FD";
            this.radFD.UseVisualStyleBackColor = true;
            this.radFD.CheckedChanged += new System.EventHandler(this.radFD_CheckedChanged);
            // 
            // radMI
            // 
            this.radMI.AutoSize = true;
            this.radMI.Location = new System.Drawing.Point(301, 38);
            this.radMI.Name = "radMI";
            this.radMI.Size = new System.Drawing.Size(37, 20);
            this.radMI.TabIndex = 43;
            this.radMI.TabStop = true;
            this.radMI.Text = "MI";
            this.radMI.UseVisualStyleBackColor = true;
            this.radMI.CheckedChanged += new System.EventHandler(this.radMI_CheckedChanged);
            // 
            // radGL
            // 
            this.radGL.AutoSize = true;
            this.radGL.Location = new System.Drawing.Point(128, 77);
            this.radGL.Name = "radGL";
            this.radGL.Size = new System.Drawing.Size(37, 20);
            this.radGL.TabIndex = 44;
            this.radGL.TabStop = true;
            this.radGL.Text = "GL";
            this.radGL.UseVisualStyleBackColor = true;
            this.radGL.CheckedChanged += new System.EventHandler(this.radGL_CheckedChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(14, 68);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(39, 16);
            this.lblCodigo.TabIndex = 29;
            this.lblCodigo.Text = "Codigo";
            // 
            // btnBuscaEmpresa
            // 
            this.btnBuscaEmpresa.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBuscaEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBuscaEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscaEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnBuscaEmpresa.Location = new System.Drawing.Point(459, 28);
            this.btnBuscaEmpresa.Name = "btnBuscaEmpresa";
            this.btnBuscaEmpresa.Size = new System.Drawing.Size(69, 23);
            this.btnBuscaEmpresa.TabIndex = 28;
            this.btnBuscaEmpresa.Text = "Buscar";
            this.btnBuscaEmpresa.UseVisualStyleBackColor = false;
            this.btnBuscaEmpresa.Visible = false;
            this.btnBuscaEmpresa.Click += new System.EventHandler(this.btnBuscaEmpresa_Click);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(60, 29);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(468, 23);
            this.txtItem.TabIndex = 26;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(61, 66);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(86, 21);
            this.txtCodigo.TabIndex = 22;
            // 
            // lblRequisitante
            // 
            this.lblRequisitante.AutoSize = true;
            this.lblRequisitante.ForeColor = System.Drawing.Color.Black;
            this.lblRequisitante.Location = new System.Drawing.Point(14, 31);
            this.lblRequisitante.Name = "lblRequisitante";
            this.lblRequisitante.Size = new System.Drawing.Size(30, 16);
            this.lblRequisitante.TabIndex = 20;
            this.lblRequisitante.Text = "Item";
            // 
            // txtTipoUnitario
            // 
            this.txtTipoUnitario.Enabled = false;
            this.txtTipoUnitario.Location = new System.Drawing.Point(229, 65);
            this.txtTipoUnitario.Name = "txtTipoUnitario";
            this.txtTipoUnitario.Size = new System.Drawing.Size(32, 23);
            this.txtTipoUnitario.TabIndex = 18;
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.ForeColor = System.Drawing.Color.Black;
            this.lblUnidade.Location = new System.Drawing.Point(153, 66);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(70, 16);
            this.lblUnidade.TabIndex = 14;
            this.lblUnidade.Text = "Tipo Unitário";
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(250, 407);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(121, 23);
            this.btnConfirmar.TabIndex = 19;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // TelaAlterarInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 520);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdInsumo);
            this.Controls.Add(this.grdTitulo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grpAlterarInsumo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaAlterarInsumo";
            this.Text = "Alterar Insumo";
            this.Load += new System.EventHandler(this.frmAlterarInsumo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueTB)).EndInit();
            this.grdTitulo.ResumeLayout(false);
            this.grdTitulo.PerformLayout();
            this.grpAlterarInsumo.ResumeLayout(false);
            this.grpAlterarInsumo.PerformLayout();
            this.grpTipoUnitario.ResumeLayout(false);
            this.grpTipoUnitario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView grdInsumo;
        private System.Windows.Forms.GroupBox grdTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpAlterarInsumo;
        private System.Windows.Forms.Button btnBuscaEmpresa;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblRequisitante;
        private System.Windows.Forms.TextBox txtTipoUnitario;
        private System.Windows.Forms.Label lblUnidade;
        private EstoqueTB estoqueTB;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private EstoqueTBTableAdapters.EstoqueTableAdapter estoqueTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEstoqueMin;
        private System.Windows.Forms.TextBox txtEstoqueMin;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.GroupBox grpTipoUnitario;
        private System.Windows.Forms.RadioButton radPR;
        private System.Windows.Forms.RadioButton radUN;
        private System.Windows.Forms.RadioButton radMt;
        private System.Windows.Forms.RadioButton radCL;
        private System.Windows.Forms.RadioButton radBD;
        private System.Windows.Forms.RadioButton radKG;
        private System.Windows.Forms.RadioButton radFD;
        private System.Windows.Forms.RadioButton radMI;
        private System.Windows.Forms.RadioButton radGL;
        private System.Windows.Forms.Button btnConfirmar;
    }
}

