namespace MenuView
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnAdm = new System.Windows.Forms.Button();
            this.btnAlmoxarifado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.pctAdministracao = new System.Windows.Forms.PictureBox();
            this.pictAlmoxarifado = new System.Windows.Forms.PictureBox();
            this.pictHistoricos = new System.Windows.Forms.PictureBox();
            this.pictRelatorios = new System.Windows.Forms.PictureBox();
            this.grpTitulo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpContent = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdministracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictAlmoxarifado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictHistoricos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRelatorios)).BeginInit();
            this.grpTitulo.SuspendLayout();
            this.grpContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdm
            // 
            this.btnAdm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdm.BackColor = System.Drawing.Color.Navy;
            this.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdm.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdm.ForeColor = System.Drawing.Color.White;
            this.btnAdm.Location = new System.Drawing.Point(96, 247);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(85, 23);
            this.btnAdm.TabIndex = 0;
            this.btnAdm.Text = "Adminsitração";
            this.btnAdm.UseVisualStyleBackColor = false;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // btnAlmoxarifado
            // 
            this.btnAlmoxarifado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlmoxarifado.BackColor = System.Drawing.Color.Navy;
            this.btnAlmoxarifado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlmoxarifado.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmoxarifado.ForeColor = System.Drawing.Color.White;
            this.btnAlmoxarifado.Location = new System.Drawing.Point(314, 247);
            this.btnAlmoxarifado.Name = "btnAlmoxarifado";
            this.btnAlmoxarifado.Size = new System.Drawing.Size(75, 23);
            this.btnAlmoxarifado.TabIndex = 1;
            this.btnAlmoxarifado.Text = "Almoxarifado";
            this.btnAlmoxarifado.UseVisualStyleBackColor = false;
            this.btnAlmoxarifado.Click += new System.EventHandler(this.btnAlmoxarifado_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(60, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario Logado: ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblUsuario.Location = new System.Drawing.Point(100, 409);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 16);
            this.lblUsuario.TabIndex = 4;
            // 
            // btnHistorico
            // 
            this.btnHistorico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHistorico.BackColor = System.Drawing.Color.Navy;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistorico.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.Color.White;
            this.btnHistorico.Location = new System.Drawing.Point(523, 247);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(75, 23);
            this.btnHistorico.TabIndex = 5;
            this.btnHistorico.Text = "Historicos";
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRelatorios.BackColor = System.Drawing.Color.Navy;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorios.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.Location = new System.Drawing.Point(737, 247);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(75, 23);
            this.btnRelatorios.TabIndex = 6;
            this.btnRelatorios.Text = "Relatorios";
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // pctAdministracao
            // 
            this.pctAdministracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctAdministracao.Image = ((System.Drawing.Image)(resources.GetObject("pctAdministracao.Image")));
            this.pctAdministracao.Location = new System.Drawing.Point(63, 72);
            this.pctAdministracao.Name = "pctAdministracao";
            this.pctAdministracao.Size = new System.Drawing.Size(157, 154);
            this.pctAdministracao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAdministracao.TabIndex = 7;
            this.pctAdministracao.TabStop = false;
            // 
            // pictAlmoxarifado
            // 
            this.pictAlmoxarifado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictAlmoxarifado.Image = ((System.Drawing.Image)(resources.GetObject("pictAlmoxarifado.Image")));
            this.pictAlmoxarifado.Location = new System.Drawing.Point(273, 72);
            this.pictAlmoxarifado.Name = "pictAlmoxarifado";
            this.pictAlmoxarifado.Size = new System.Drawing.Size(157, 154);
            this.pictAlmoxarifado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictAlmoxarifado.TabIndex = 8;
            this.pictAlmoxarifado.TabStop = false;
            // 
            // pictHistoricos
            // 
            this.pictHistoricos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictHistoricos.Image = ((System.Drawing.Image)(resources.GetObject("pictHistoricos.Image")));
            this.pictHistoricos.Location = new System.Drawing.Point(484, 72);
            this.pictHistoricos.Name = "pictHistoricos";
            this.pictHistoricos.Size = new System.Drawing.Size(157, 154);
            this.pictHistoricos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictHistoricos.TabIndex = 10;
            this.pictHistoricos.TabStop = false;
            // 
            // pictRelatorios
            // 
            this.pictRelatorios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("pictRelatorios.Image")));
            this.pictRelatorios.Location = new System.Drawing.Point(692, 72);
            this.pictRelatorios.Name = "pictRelatorios";
            this.pictRelatorios.Size = new System.Drawing.Size(157, 154);
            this.pictRelatorios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictRelatorios.TabIndex = 11;
            this.pictRelatorios.TabStop = false;
            // 
            // grpTitulo
            // 
            this.grpTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpTitulo.Controls.Add(this.label2);
            this.grpTitulo.Location = new System.Drawing.Point(40, 30);
            this.grpTitulo.Name = "grpTitulo";
            this.grpTitulo.Size = new System.Drawing.Size(906, 88);
            this.grpTitulo.TabIndex = 12;
            this.grpTitulo.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(347, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menu Principal";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(737, 314);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Logout";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // grpContent
            // 
            this.grpContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpContent.Controls.Add(this.lblUser);
            this.grpContent.Controls.Add(this.pctAdministracao);
            this.grpContent.Controls.Add(this.btnSair);
            this.grpContent.Controls.Add(this.btnAdm);
            this.grpContent.Controls.Add(this.label1);
            this.grpContent.Controls.Add(this.btnAlmoxarifado);
            this.grpContent.Controls.Add(this.pictRelatorios);
            this.grpContent.Controls.Add(this.btnHistorico);
            this.grpContent.Controls.Add(this.pictHistoricos);
            this.grpContent.Controls.Add(this.btnRelatorios);
            this.grpContent.Controls.Add(this.pictAlmoxarifado);
            this.grpContent.Location = new System.Drawing.Point(40, 141);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(906, 388);
            this.grpContent.TabIndex = 14;
            this.grpContent.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblUser.Location = new System.Drawing.Point(153, 321);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(87, 16);
            this.lblUser.TabIndex = 14;
            this.lblUser.Text = "Usuario Logado: ";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 576);
            this.Controls.Add(this.grpContent);
            this.Controls.Add(this.grpTitulo);
            this.Controls.Add(this.lblUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctAdministracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictAlmoxarifado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictHistoricos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRelatorios)).EndInit();
            this.grpTitulo.ResumeLayout(false);
            this.grpTitulo.PerformLayout();
            this.grpContent.ResumeLayout(false);
            this.grpContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.Button btnAlmoxarifado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.PictureBox pctAdministracao;
        private System.Windows.Forms.PictureBox pictAlmoxarifado;
        private System.Windows.Forms.PictureBox pictHistoricos;
        private System.Windows.Forms.PictureBox pictRelatorios;
        private System.Windows.Forms.GroupBox grpTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox grpContent;
        private System.Windows.Forms.Label lblUser;
    }
}

