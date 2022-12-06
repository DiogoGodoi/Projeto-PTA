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
            this.grdTitulo = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.listSaida = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.lblCracha = new System.Windows.Forms.Label();
            this.btnAcrescentar = new System.Windows.Forms.Button();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblRequisitante = new System.Windows.Forms.Label();
            this.btnAdcionar = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.grdTitulo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdTitulo
            // 
            this.grdTitulo.Controls.Add(this.lblTitulo);
            this.grdTitulo.Location = new System.Drawing.Point(20, 25);
            this.grdTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.grdTitulo.Name = "grdTitulo";
            this.grdTitulo.Padding = new System.Windows.Forms.Padding(2);
            this.grdTitulo.Size = new System.Drawing.Size(718, 81);
            this.grdTitulo.TabIndex = 32;
            this.grdTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bernard MT Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(321, 25);
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
            this.columnHeader1,
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo";
            this.columnHeader1.Width = 100;
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
            this.groupBox2.Controls.Add(this.lblCracha);
            this.groupBox2.Controls.Add(this.btnAcrescentar);
            this.groupBox2.Controls.Add(this.btnBuscarItem);
            this.groupBox2.Controls.Add(this.txtItem);
            this.groupBox2.Controls.Add(this.txtCodigo);
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
            // lblCracha
            // 
            this.lblCracha.AutoSize = true;
            this.lblCracha.ForeColor = System.Drawing.Color.Black;
            this.lblCracha.Location = new System.Drawing.Point(15, 68);
            this.lblCracha.Name = "lblCracha";
            this.lblCracha.Size = new System.Drawing.Size(39, 16);
            this.lblCracha.TabIndex = 24;
            this.lblCracha.Text = "Codigo";
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
            // btnBuscarItem
            // 
            this.btnBuscarItem.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBuscarItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBuscarItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarItem.ForeColor = System.Drawing.Color.White;
            this.btnBuscarItem.Location = new System.Drawing.Point(206, 64);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(47, 23);
            this.btnBuscarItem.TabIndex = 23;
            this.btnBuscarItem.Text = "Buscar";
            this.btnBuscarItem.UseVisualStyleBackColor = false;
            this.btnBuscarItem.Click += new System.EventHandler(this.btnBuscarItem_Click);
            // 
            // txtItem
            // 
            this.txtItem.Enabled = false;
            this.txtItem.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(302, 66);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(374, 21);
            this.txtItem.TabIndex = 22;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(60, 66);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(140, 23);
            this.txtCodigo.TabIndex = 21;
            // 
            // lblRequisitante
            // 
            this.lblRequisitante.AutoSize = true;
            this.lblRequisitante.ForeColor = System.Drawing.Color.Black;
            this.lblRequisitante.Location = new System.Drawing.Point(266, 68);
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
            // EntradaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 564);
            this.Controls.Add(this.grdTitulo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.listSaida);
            this.Controls.Add(this.groupBox2);
            this.Name = "EntradaView";
            this.Text = "Entrada";
            this.grdTitulo.ResumeLayout(false);
            this.grdTitulo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grdTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ListView listSaida;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Button btnBuscaEmpresa;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.Label lblCracha;
        private System.Windows.Forms.Button btnAcrescentar;
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblRequisitante;
        private System.Windows.Forms.Button btnAdcionar;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.TextBox txtNF;
        private System.Windows.Forms.Label lblNf;
    }
}