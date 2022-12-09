namespace MenuView
{
    partial class TelaSelecaoAdministracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaSelecaoAdministracao));
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnCadastrarInsumo = new System.Windows.Forms.Button();
            this.grpTitulo = new System.Windows.Forms.GroupBox();
            this.lblOpcoes = new System.Windows.Forms.Label();
            this.btnCadastrarFornecedor = new System.Windows.Forms.Button();
            this.btnAlterarInsumos = new System.Windows.Forms.Button();
            this.grpCadastrar = new System.Windows.Forms.GroupBox();
            this.pctCadastrar = new System.Windows.Forms.PictureBox();
            this.grpAlterar = new System.Windows.Forms.GroupBox();
            this.btnAlterarSenhaUsuario = new System.Windows.Forms.Button();
            this.btnAlterarFuncionario = new System.Windows.Forms.Button();
            this.pctAlterar = new System.Windows.Forms.PictureBox();
            this.btnAlterarFornecedor = new System.Windows.Forms.Button();
            this.grpRemover = new System.Windows.Forms.GroupBox();
            this.btnDeletarUsuario = new System.Windows.Forms.Button();
            this.btnDeletarFuncionario = new System.Windows.Forms.Button();
            this.btnDeletarFornecedor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRemoverInsumos = new System.Windows.Forms.Button();
            this.grpTitulo.SuspendLayout();
            this.grpCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCadastrar)).BeginInit();
            this.grpAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAlterar)).BeginInit();
            this.grpRemover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCadastrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarUsuario.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(17, 175);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(118, 31);
            this.btnCadastrarUsuario.TabIndex = 0;
            this.btnCadastrarUsuario.Text = "Cadastrar Usuario";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = false;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(16, 224);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(119, 31);
            this.btnCadastrarFuncionario.TabIndex = 1;
            this.btnCadastrarFuncionario.Text = "Cadastrar Funcionario";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // btnCadastrarInsumo
            // 
            this.btnCadastrarInsumo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCadastrarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarInsumo.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarInsumo.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarInsumo.Location = new System.Drawing.Point(16, 325);
            this.btnCadastrarInsumo.Name = "btnCadastrarInsumo";
            this.btnCadastrarInsumo.Size = new System.Drawing.Size(119, 31);
            this.btnCadastrarInsumo.TabIndex = 2;
            this.btnCadastrarInsumo.Text = "Cadastrar Insumos";
            this.btnCadastrarInsumo.UseVisualStyleBackColor = false;
            this.btnCadastrarInsumo.Click += new System.EventHandler(this.btnCadastrarInsumo_Click);
            // 
            // grpTitulo
            // 
            this.grpTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpTitulo.Controls.Add(this.lblOpcoes);
            this.grpTitulo.Location = new System.Drawing.Point(22, 12);
            this.grpTitulo.Name = "grpTitulo";
            this.grpTitulo.Size = new System.Drawing.Size(462, 81);
            this.grpTitulo.TabIndex = 4;
            this.grpTitulo.TabStop = false;
            // 
            // lblOpcoes
            // 
            this.lblOpcoes.AutoSize = true;
            this.lblOpcoes.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcoes.ForeColor = System.Drawing.Color.Navy;
            this.lblOpcoes.Location = new System.Drawing.Point(192, 26);
            this.lblOpcoes.Name = "lblOpcoes";
            this.lblOpcoes.Size = new System.Drawing.Size(92, 31);
            this.lblOpcoes.TabIndex = 0;
            this.lblOpcoes.Text = "Opções";
            // 
            // btnCadastrarFornecedor
            // 
            this.btnCadastrarFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCadastrarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarFornecedor.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarFornecedor.Location = new System.Drawing.Point(16, 275);
            this.btnCadastrarFornecedor.Name = "btnCadastrarFornecedor";
            this.btnCadastrarFornecedor.Size = new System.Drawing.Size(119, 31);
            this.btnCadastrarFornecedor.TabIndex = 5;
            this.btnCadastrarFornecedor.Text = "Cadastrar Fornecedor";
            this.btnCadastrarFornecedor.UseVisualStyleBackColor = false;
            this.btnCadastrarFornecedor.Click += new System.EventHandler(this.btnCadastrarFornecedor_Click);
            // 
            // btnAlterarInsumos
            // 
            this.btnAlterarInsumos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterarInsumos.BackColor = System.Drawing.Color.Navy;
            this.btnAlterarInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterarInsumos.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarInsumos.ForeColor = System.Drawing.Color.White;
            this.btnAlterarInsumos.Location = new System.Drawing.Point(17, 326);
            this.btnAlterarInsumos.Name = "btnAlterarInsumos";
            this.btnAlterarInsumos.Size = new System.Drawing.Size(119, 31);
            this.btnAlterarInsumos.TabIndex = 6;
            this.btnAlterarInsumos.Text = "Alterar Insumos";
            this.btnAlterarInsumos.UseVisualStyleBackColor = false;
            this.btnAlterarInsumos.Click += new System.EventHandler(this.btnAlterarInsumos_Click);
            // 
            // grpCadastrar
            // 
            this.grpCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpCadastrar.Controls.Add(this.pctCadastrar);
            this.grpCadastrar.Controls.Add(this.btnCadastrarUsuario);
            this.grpCadastrar.Controls.Add(this.btnCadastrarFuncionario);
            this.grpCadastrar.Controls.Add(this.btnCadastrarInsumo);
            this.grpCadastrar.Controls.Add(this.btnCadastrarFornecedor);
            this.grpCadastrar.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCadastrar.Location = new System.Drawing.Point(22, 97);
            this.grpCadastrar.Name = "grpCadastrar";
            this.grpCadastrar.Size = new System.Drawing.Size(150, 386);
            this.grpCadastrar.TabIndex = 7;
            this.grpCadastrar.TabStop = false;
            this.grpCadastrar.Text = "Cadastrar";
            // 
            // pctCadastrar
            // 
            this.pctCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("pctCadastrar.Image")));
            this.pctCadastrar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctCadastrar.InitialImage")));
            this.pctCadastrar.Location = new System.Drawing.Point(17, 20);
            this.pctCadastrar.Name = "pctCadastrar";
            this.pctCadastrar.Size = new System.Drawing.Size(118, 125);
            this.pctCadastrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCadastrar.TabIndex = 7;
            this.pctCadastrar.TabStop = false;
            // 
            // grpAlterar
            // 
            this.grpAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpAlterar.Controls.Add(this.btnAlterarSenhaUsuario);
            this.grpAlterar.Controls.Add(this.btnAlterarFuncionario);
            this.grpAlterar.Controls.Add(this.pctAlterar);
            this.grpAlterar.Controls.Add(this.btnAlterarFornecedor);
            this.grpAlterar.Controls.Add(this.btnAlterarInsumos);
            this.grpAlterar.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAlterar.Location = new System.Drawing.Point(178, 97);
            this.grpAlterar.Name = "grpAlterar";
            this.grpAlterar.Size = new System.Drawing.Size(150, 386);
            this.grpAlterar.TabIndex = 8;
            this.grpAlterar.TabStop = false;
            this.grpAlterar.Text = "Alterar";
            // 
            // btnAlterarSenhaUsuario
            // 
            this.btnAlterarSenhaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterarSenhaUsuario.BackColor = System.Drawing.Color.Navy;
            this.btnAlterarSenhaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterarSenhaUsuario.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarSenhaUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAlterarSenhaUsuario.Location = new System.Drawing.Point(18, 175);
            this.btnAlterarSenhaUsuario.Name = "btnAlterarSenhaUsuario";
            this.btnAlterarSenhaUsuario.Size = new System.Drawing.Size(118, 31);
            this.btnAlterarSenhaUsuario.TabIndex = 8;
            this.btnAlterarSenhaUsuario.Text = "Alterar Senha de Usuario";
            this.btnAlterarSenhaUsuario.UseVisualStyleBackColor = false;
            this.btnAlterarSenhaUsuario.Click += new System.EventHandler(this.btnAlterarSenhaUsuario_Click);
            // 
            // btnAlterarFuncionario
            // 
            this.btnAlterarFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterarFuncionario.BackColor = System.Drawing.Color.Navy;
            this.btnAlterarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterarFuncionario.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnAlterarFuncionario.Location = new System.Drawing.Point(17, 224);
            this.btnAlterarFuncionario.Name = "btnAlterarFuncionario";
            this.btnAlterarFuncionario.Size = new System.Drawing.Size(119, 31);
            this.btnAlterarFuncionario.TabIndex = 9;
            this.btnAlterarFuncionario.Text = "Alterar Funcionario";
            this.btnAlterarFuncionario.UseVisualStyleBackColor = false;
            // 
            // pctAlterar
            // 
            this.pctAlterar.Image = ((System.Drawing.Image)(resources.GetObject("pctAlterar.Image")));
            this.pctAlterar.Location = new System.Drawing.Point(17, 20);
            this.pctAlterar.Name = "pctAlterar";
            this.pctAlterar.Size = new System.Drawing.Size(118, 125);
            this.pctAlterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAlterar.TabIndex = 9;
            this.pctAlterar.TabStop = false;
            // 
            // btnAlterarFornecedor
            // 
            this.btnAlterarFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterarFornecedor.BackColor = System.Drawing.Color.Navy;
            this.btnAlterarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterarFornecedor.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnAlterarFornecedor.Location = new System.Drawing.Point(17, 275);
            this.btnAlterarFornecedor.Name = "btnAlterarFornecedor";
            this.btnAlterarFornecedor.Size = new System.Drawing.Size(119, 31);
            this.btnAlterarFornecedor.TabIndex = 10;
            this.btnAlterarFornecedor.Text = "Alterar Fornecedor";
            this.btnAlterarFornecedor.UseVisualStyleBackColor = false;
            // 
            // grpRemover
            // 
            this.grpRemover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpRemover.Controls.Add(this.btnDeletarUsuario);
            this.grpRemover.Controls.Add(this.btnDeletarFuncionario);
            this.grpRemover.Controls.Add(this.btnDeletarFornecedor);
            this.grpRemover.Controls.Add(this.pictureBox1);
            this.grpRemover.Controls.Add(this.btnRemoverInsumos);
            this.grpRemover.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRemover.Location = new System.Drawing.Point(334, 99);
            this.grpRemover.Name = "grpRemover";
            this.grpRemover.Size = new System.Drawing.Size(150, 386);
            this.grpRemover.TabIndex = 9;
            this.grpRemover.TabStop = false;
            this.grpRemover.Text = "Remover";
            // 
            // btnDeletarUsuario
            // 
            this.btnDeletarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeletarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeletarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarUsuario.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnDeletarUsuario.Location = new System.Drawing.Point(17, 173);
            this.btnDeletarUsuario.Name = "btnDeletarUsuario";
            this.btnDeletarUsuario.Size = new System.Drawing.Size(118, 31);
            this.btnDeletarUsuario.TabIndex = 10;
            this.btnDeletarUsuario.Text = "Deletar Usuario";
            this.btnDeletarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnDeletarFuncionario
            // 
            this.btnDeletarFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeletarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeletarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarFuncionario.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnDeletarFuncionario.Location = new System.Drawing.Point(16, 222);
            this.btnDeletarFuncionario.Name = "btnDeletarFuncionario";
            this.btnDeletarFuncionario.Size = new System.Drawing.Size(119, 31);
            this.btnDeletarFuncionario.TabIndex = 11;
            this.btnDeletarFuncionario.Text = "Deletar Funcionario";
            this.btnDeletarFuncionario.UseVisualStyleBackColor = false;
            // 
            // btnDeletarFornecedor
            // 
            this.btnDeletarFornecedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeletarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeletarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletarFornecedor.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnDeletarFornecedor.Location = new System.Drawing.Point(16, 273);
            this.btnDeletarFornecedor.Name = "btnDeletarFornecedor";
            this.btnDeletarFornecedor.Size = new System.Drawing.Size(119, 31);
            this.btnDeletarFornecedor.TabIndex = 12;
            this.btnDeletarFornecedor.Text = "Deletar Fornecedor";
            this.btnDeletarFornecedor.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnRemoverInsumos
            // 
            this.btnRemoverInsumos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoverInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoverInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoverInsumos.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverInsumos.ForeColor = System.Drawing.Color.White;
            this.btnRemoverInsumos.Location = new System.Drawing.Point(17, 326);
            this.btnRemoverInsumos.Name = "btnRemoverInsumos";
            this.btnRemoverInsumos.Size = new System.Drawing.Size(119, 31);
            this.btnRemoverInsumos.TabIndex = 6;
            this.btnRemoverInsumos.Text = "Remover Insumos";
            this.btnRemoverInsumos.UseVisualStyleBackColor = false;
            // 
            // TelaSelecaoAdministracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 495);
            this.Controls.Add(this.grpRemover);
            this.Controls.Add(this.grpAlterar);
            this.Controls.Add(this.grpCadastrar);
            this.Controls.Add(this.grpTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaSelecaoAdministracao";
            this.Text = "Administração";
            this.Load += new System.EventHandler(this.TelaSelecaoAdministracao_Load);
            this.grpTitulo.ResumeLayout(false);
            this.grpTitulo.PerformLayout();
            this.grpCadastrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCadastrar)).EndInit();
            this.grpAlterar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctAlterar)).EndInit();
            this.grpRemover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Button btnCadastrarInsumo;
        private System.Windows.Forms.GroupBox grpTitulo;
        private System.Windows.Forms.Label lblOpcoes;
        private System.Windows.Forms.Button btnCadastrarFornecedor;
        private System.Windows.Forms.Button btnAlterarInsumos;
        private System.Windows.Forms.GroupBox grpCadastrar;
        private System.Windows.Forms.GroupBox grpAlterar;
        private System.Windows.Forms.PictureBox pctCadastrar;
        private System.Windows.Forms.PictureBox pctAlterar;
        private System.Windows.Forms.GroupBox grpRemover;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRemoverInsumos;
        private System.Windows.Forms.Button btnAlterarSenhaUsuario;
        private System.Windows.Forms.Button btnAlterarFuncionario;
        private System.Windows.Forms.Button btnAlterarFornecedor;
        private System.Windows.Forms.Button btnDeletarUsuario;
        private System.Windows.Forms.Button btnDeletarFuncionario;
        private System.Windows.Forms.Button btnDeletarFornecedor;
    }
}