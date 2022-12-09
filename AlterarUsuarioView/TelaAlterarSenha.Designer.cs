namespace AlterarUsuarioView
{
    partial class TelaAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAlterarSenha));
            this.grpTitulo = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpCadastrar = new System.Windows.Forms.GroupBox();
            this.txtAcessos = new System.Windows.Forms.TextBox();
            this.lblAcesso = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpAcessos = new System.Windows.Forms.GroupBox();
            this.radAlmoxarifado = new System.Windows.Forms.RadioButton();
            this.radAdministracao = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdUsuarios = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTB = new AlterarUsuarioView.UsuariosTB();
            this.usuariosTableAdapter = new AlterarUsuarioView.UsuariosTBTableAdapters.UsuariosTableAdapter();
            this.grpTitulo.SuspendLayout();
            this.grpCadastrar.SuspendLayout();
            this.grpAcessos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosTB)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTitulo
            // 
            this.grpTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpTitulo.Controls.Add(this.lblTitulo);
            this.grpTitulo.Location = new System.Drawing.Point(23, 29);
            this.grpTitulo.Name = "grpTitulo";
            this.grpTitulo.Size = new System.Drawing.Size(650, 52);
            this.grpTitulo.TabIndex = 5;
            this.grpTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(243, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(140, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Alterar Senha";
            // 
            // grpCadastrar
            // 
            this.grpCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpCadastrar.Controls.Add(this.txtAcessos);
            this.grpCadastrar.Controls.Add(this.lblAcesso);
            this.grpCadastrar.Controls.Add(this.btnBuscar);
            this.grpCadastrar.Controls.Add(this.grpAcessos);
            this.grpCadastrar.Controls.Add(this.txtNome);
            this.grpCadastrar.Controls.Add(this.txtSenha);
            this.grpCadastrar.Controls.Add(this.btnAlterarSenha);
            this.grpCadastrar.Controls.Add(this.lblNome);
            this.grpCadastrar.Controls.Add(this.lblCodigo);
            this.grpCadastrar.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCadastrar.ForeColor = System.Drawing.Color.Navy;
            this.grpCadastrar.Location = new System.Drawing.Point(23, 99);
            this.grpCadastrar.Name = "grpCadastrar";
            this.grpCadastrar.Size = new System.Drawing.Size(248, 332);
            this.grpCadastrar.TabIndex = 4;
            this.grpCadastrar.TabStop = false;
            this.grpCadastrar.Text = "Cadastrar";
            // 
            // txtAcessos
            // 
            this.txtAcessos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAcessos.Enabled = false;
            this.txtAcessos.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcessos.Location = new System.Drawing.Point(79, 107);
            this.txtAcessos.Name = "txtAcessos";
            this.txtAcessos.Size = new System.Drawing.Size(142, 21);
            this.txtAcessos.TabIndex = 16;
            // 
            // lblAcesso
            // 
            this.lblAcesso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAcesso.AutoSize = true;
            this.lblAcesso.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcesso.ForeColor = System.Drawing.Color.Black;
            this.lblAcesso.Location = new System.Drawing.Point(24, 108);
            this.lblAcesso.Name = "lblAcesso";
            this.lblAcesso.Size = new System.Drawing.Size(45, 16);
            this.lblAcesso.TabIndex = 15;
            this.lblAcesso.Text = "Acessos:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(160, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(61, 20);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpAcessos
            // 
            this.grpAcessos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpAcessos.Controls.Add(this.radAlmoxarifado);
            this.grpAcessos.Controls.Add(this.radAdministracao);
            this.grpAcessos.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAcessos.Location = new System.Drawing.Point(27, 151);
            this.grpAcessos.Name = "grpAcessos";
            this.grpAcessos.Size = new System.Drawing.Size(194, 92);
            this.grpAcessos.TabIndex = 11;
            this.grpAcessos.TabStop = false;
            this.grpAcessos.Text = "Acessos";
            // 
            // radAlmoxarifado
            // 
            this.radAlmoxarifado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radAlmoxarifado.AutoSize = true;
            this.radAlmoxarifado.Location = new System.Drawing.Point(47, 52);
            this.radAlmoxarifado.Name = "radAlmoxarifado";
            this.radAlmoxarifado.Size = new System.Drawing.Size(60, 19);
            this.radAlmoxarifado.TabIndex = 10;
            this.radAlmoxarifado.TabStop = true;
            this.radAlmoxarifado.Text = "Padrão";
            this.radAlmoxarifado.UseVisualStyleBackColor = true;
            this.radAlmoxarifado.CheckedChanged += new System.EventHandler(this.radAlmoxarifado_CheckedChanged);
            // 
            // radAdministracao
            // 
            this.radAdministracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radAdministracao.AutoSize = true;
            this.radAdministracao.Location = new System.Drawing.Point(47, 27);
            this.radAdministracao.Name = "radAdministracao";
            this.radAdministracao.Size = new System.Drawing.Size(92, 19);
            this.radAdministracao.TabIndex = 9;
            this.radAdministracao.TabStop = true;
            this.radAdministracao.Text = "Administracao";
            this.radAdministracao.UseVisualStyleBackColor = true;
            this.radAdministracao.CheckedChanged += new System.EventHandler(this.radAdministracao_CheckedChanged);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(79, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(142, 21);
            this.txtNome.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(107, 66);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(114, 21);
            this.txtSenha.TabIndex = 5;
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterarSenha.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterarSenha.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarSenha.ForeColor = System.Drawing.Color.White;
            this.btnAlterarSenha.Location = new System.Drawing.Point(74, 272);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(98, 23);
            this.btnAlterarSenha.TabIndex = 4;
            this.btnAlterarSenha.Text = "Alterar";
            this.btnAlterarSenha.UseVisualStyleBackColor = false;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(24, 67);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(77, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Alterar Senha:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(24, 34);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Usuario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtProcurar);
            this.groupBox1.Controls.Add(this.btnProcurar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(291, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 77);
            this.groupBox1.TabIndex = 41;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.grdUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grdUsuarios.AutoGenerateColumns = false;
            this.grdUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdUsuarios.BackgroundColor = System.Drawing.Color.Silver;
            this.grdUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn});
            this.grdUsuarios.DataSource = this.usuariosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdUsuarios.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.grdUsuarios.Location = new System.Drawing.Point(291, 193);
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdUsuarios.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdUsuarios.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Navy;
            this.grdUsuarios.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.grdUsuarios.RowTemplate.DefaultCellStyle.Format = "N0";
            this.grdUsuarios.RowTemplate.DefaultCellStyle.NullValue = null;
            this.grdUsuarios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grdUsuarios.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUsuarios.RowTemplate.Height = 15;
            this.grdUsuarios.Size = new System.Drawing.Size(382, 238);
            this.grdUsuarios.TabIndex = 40;
            this.grdUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEstoque_CellContentClick);
            this.grdUsuarios.Click += new System.EventHandler(this.btnBuscar_Click);
            this.grdUsuarios.DoubleClick += new System.EventHandler(this.btnBuscar_Click);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.usuariosTB;
            // 
            // usuariosTB
            // 
            this.usuariosTB.DataSetName = "UsuariosTB";
            this.usuariosTB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // TelaAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdUsuarios);
            this.Controls.Add(this.grpTitulo);
            this.Controls.Add(this.grpCadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaAlterarSenha";
            this.Text = "Alterar Senha";
            this.Load += new System.EventHandler(this.TelaAlterarSenha_Load);
            this.grpTitulo.ResumeLayout(false);
            this.grpTitulo.PerformLayout();
            this.grpCadastrar.ResumeLayout(false);
            this.grpCadastrar.PerformLayout();
            this.grpAcessos.ResumeLayout(false);
            this.grpAcessos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpCadastrar;
        private System.Windows.Forms.GroupBox grpAcessos;
        private System.Windows.Forms.RadioButton radAlmoxarifado;
        private System.Windows.Forms.RadioButton radAdministracao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnAlterarSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdUsuarios;
        private UsuariosTB usuariosTB;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private UsuariosTBTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtAcessos;
        private System.Windows.Forms.Label lblAcesso;
    }
}

