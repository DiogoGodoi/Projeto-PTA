namespace Controle_de_Estoque
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.grpEntrar = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.grpTitle = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpEntrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.grpTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEntrar
            // 
            this.grpEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpEntrar.BackColor = System.Drawing.SystemColors.Control;
            this.grpEntrar.Controls.Add(this.txtSenha);
            this.grpEntrar.Controls.Add(this.lblUsuario);
            this.grpEntrar.Controls.Add(this.txtUsuario);
            this.grpEntrar.Controls.Add(this.btnEntrar);
            this.grpEntrar.Controls.Add(this.lblSenha);
            this.grpEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpEntrar.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEntrar.ForeColor = System.Drawing.Color.Navy;
            this.grpEntrar.Location = new System.Drawing.Point(23, 192);
            this.grpEntrar.Name = "grpEntrar";
            this.grpEntrar.Size = new System.Drawing.Size(466, 253);
            this.grpEntrar.TabIndex = 0;
            this.grpEntrar.TabStop = false;
            this.grpEntrar.Text = "Logar";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.Location = new System.Drawing.Point(138, 145);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(249, 25);
            this.txtSenha.TabIndex = 9;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Navy;
            this.lblUsuario.Location = new System.Drawing.Point(55, 56);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 18);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(138, 56);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(249, 25);
            this.txtUsuario.TabIndex = 8;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrar.BackColor = System.Drawing.Color.Navy;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(216, 204);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(104, 28);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click_1);
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Navy;
            this.lblSenha.Location = new System.Drawing.Point(55, 145);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(42, 18);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "Senha";
            // 
            // pctLogo
            // 
            this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(132, 89);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(267, 97);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 1;
            this.pctLogo.TabStop = false;
            // 
            // grpTitle
            // 
            this.grpTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpTitle.Controls.Add(this.lblTitulo);
            this.grpTitle.Location = new System.Drawing.Point(132, 12);
            this.grpTitle.Name = "grpTitle";
            this.grpTitle.Size = new System.Drawing.Size(267, 59);
            this.grpTitle.TabIndex = 2;
            this.grpTitle.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(38, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(218, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Controle de estoque";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 465);
            this.Controls.Add(this.grpTitle);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.grpEntrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpEntrar.ResumeLayout(false);
            this.grpEntrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.grpTitle.ResumeLayout(false);
            this.grpTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEntrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.GroupBox grpTitle;
        private System.Windows.Forms.Label lblTitulo;
    }
}

