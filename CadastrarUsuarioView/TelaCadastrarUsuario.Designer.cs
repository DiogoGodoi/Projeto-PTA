namespace CadastrarUsuarioView
{
    partial class frmCadastrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarUsuario));
            this.grpTitulo = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpCadastrar = new System.Windows.Forms.GroupBox();
            this.radAlmoxarifado = new System.Windows.Forms.RadioButton();
            this.radAdministracao = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblAcessos = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grpTitulo.SuspendLayout();
            this.grpCadastrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTitulo
            // 
            this.grpTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpTitulo.Controls.Add(this.lblTitulo);
            this.grpTitulo.Location = new System.Drawing.Point(36, 20);
            this.grpTitulo.Name = "grpTitulo";
            this.grpTitulo.Size = new System.Drawing.Size(297, 52);
            this.grpTitulo.TabIndex = 3;
            this.grpTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(66, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(179, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastrar Usuario";
            // 
            // grpCadastrar
            // 
            this.grpCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpCadastrar.Controls.Add(this.radAlmoxarifado);
            this.grpCadastrar.Controls.Add(this.radAdministracao);
            this.grpCadastrar.Controls.Add(this.txtNome);
            this.grpCadastrar.Controls.Add(this.txtSenha);
            this.grpCadastrar.Controls.Add(this.btnCadastrar);
            this.grpCadastrar.Controls.Add(this.lblAcessos);
            this.grpCadastrar.Controls.Add(this.lblNome);
            this.grpCadastrar.Controls.Add(this.lblCodigo);
            this.grpCadastrar.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCadastrar.ForeColor = System.Drawing.Color.Navy;
            this.grpCadastrar.Location = new System.Drawing.Point(36, 102);
            this.grpCadastrar.Name = "grpCadastrar";
            this.grpCadastrar.Size = new System.Drawing.Size(297, 225);
            this.grpCadastrar.TabIndex = 2;
            this.grpCadastrar.TabStop = false;
            this.grpCadastrar.Text = "Cadastrar";
            // 
            // radAlmoxarifado
            // 
            this.radAlmoxarifado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radAlmoxarifado.AutoSize = true;
            this.radAlmoxarifado.Location = new System.Drawing.Point(123, 132);
            this.radAlmoxarifado.Name = "radAlmoxarifado";
            this.radAlmoxarifado.Size = new System.Drawing.Size(61, 20);
            this.radAlmoxarifado.TabIndex = 10;
            this.radAlmoxarifado.TabStop = true;
            this.radAlmoxarifado.Text = "Padrão";
            this.radAlmoxarifado.UseVisualStyleBackColor = true;
            // 
            // radAdministracao
            // 
            this.radAdministracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radAdministracao.AutoSize = true;
            this.radAdministracao.Location = new System.Drawing.Point(123, 106);
            this.radAdministracao.Name = "radAdministracao";
            this.radAdministracao.Size = new System.Drawing.Size(94, 20);
            this.radAdministracao.TabIndex = 9;
            this.radAdministracao.TabStop = true;
            this.radAdministracao.Text = "Administracao";
            this.radAdministracao.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(87, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(184, 21);
            this.txtNome.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(87, 66);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(184, 21);
            this.txtSenha.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(106, 180);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(98, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblAcessos
            // 
            this.lblAcessos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAcessos.AutoSize = true;
            this.lblAcessos.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcessos.ForeColor = System.Drawing.Color.Black;
            this.lblAcessos.Location = new System.Drawing.Point(68, 132);
            this.lblAcessos.Name = "lblAcessos";
            this.lblAcessos.Size = new System.Drawing.Size(42, 16);
            this.lblAcessos.TabIndex = 2;
            this.lblAcessos.Text = "Acessos";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(32, 67);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Senha:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(32, 35);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(37, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Nome:";
            // 
            // frmCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 344);
            this.Controls.Add(this.grpTitulo);
            this.Controls.Add(this.grpCadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastrarUsuario";
            this.Text = "Cadastrar";
            this.grpTitulo.ResumeLayout(false);
            this.grpTitulo.PerformLayout();
            this.grpCadastrar.ResumeLayout(false);
            this.grpCadastrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpCadastrar;
        private System.Windows.Forms.RadioButton radAlmoxarifado;
        private System.Windows.Forms.RadioButton radAdministracao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblAcessos;
    }
}

