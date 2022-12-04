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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.codFuncionario = new System.Windows.Forms.Label();
            this.btnBuscarRequisitante = new System.Windows.Forms.Button();
            this.txtNomeRequisitante = new System.Windows.Forms.TextBox();
            this.txtCracha = new System.Windows.Forms.TextBox();
            this.lblNomeRequisitante = new System.Windows.Forms.Label();
            this.lblCracha = new System.Windows.Forms.Label();
            this.btnAcrescentar = new System.Windows.Forms.Button();
            this.btnBuscarColaborador = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblRequisitante = new System.Windows.Forms.Label();
            this.btnAdcionar = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listSaida = new System.Windows.Forms.ListView();
            this.grdTitulo = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.grdTitulo.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.lblCracha);
            this.groupBox2.Controls.Add(this.btnAcrescentar);
            this.groupBox2.Controls.Add(this.btnBuscarColaborador);
            this.groupBox2.Controls.Add(this.txtItem);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.lblRequisitante);
            this.groupBox2.Controls.Add(this.btnAdcionar);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSubtrair);
            this.groupBox2.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(27, 133);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(746, 191);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movimentar Estoque";
            // 
            // codFuncionario
            // 
            this.codFuncionario.AutoSize = true;
            this.codFuncionario.ForeColor = System.Drawing.Color.Black;
            this.codFuncionario.Location = new System.Drawing.Point(20, 43);
            this.codFuncionario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codFuncionario.Name = "codFuncionario";
            this.codFuncionario.Size = new System.Drawing.Size(53, 20);
            this.codFuncionario.TabIndex = 29;
            this.codFuncionario.Text = "Crachá";
            // 
            // btnBuscarRequisitante
            // 
            this.btnBuscarRequisitante.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBuscarRequisitante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBuscarRequisitante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarRequisitante.ForeColor = System.Drawing.Color.White;
            this.btnBuscarRequisitante.Location = new System.Drawing.Point(274, 38);
            this.btnBuscarRequisitante.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarRequisitante.Name = "btnBuscarRequisitante";
            this.btnBuscarRequisitante.Size = new System.Drawing.Size(63, 28);
            this.btnBuscarRequisitante.TabIndex = 28;
            this.btnBuscarRequisitante.Text = "Buscar";
            this.btnBuscarRequisitante.UseVisualStyleBackColor = false;
            this.btnBuscarRequisitante.Click += new System.EventHandler(this.btnBuscarRequisitante_Click);
            // 
            // txtNomeRequisitante
            // 
            this.txtNomeRequisitante.Enabled = false;
            this.txtNomeRequisitante.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeRequisitante.Location = new System.Drawing.Point(402, 42);
            this.txtNomeRequisitante.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeRequisitante.Name = "txtNomeRequisitante";
            this.txtNomeRequisitante.Size = new System.Drawing.Size(327, 24);
            this.txtNomeRequisitante.TabIndex = 27;
            // 
            // txtCracha
            // 
            this.txtCracha.Location = new System.Drawing.Point(80, 40);
            this.txtCracha.Margin = new System.Windows.Forms.Padding(4);
            this.txtCracha.Name = "txtCracha";
            this.txtCracha.Size = new System.Drawing.Size(186, 27);
            this.txtCracha.TabIndex = 26;
            // 
            // lblNomeRequisitante
            // 
            this.lblNomeRequisitante.AutoSize = true;
            this.lblNomeRequisitante.ForeColor = System.Drawing.Color.Black;
            this.lblNomeRequisitante.Location = new System.Drawing.Point(355, 43);
            this.lblNomeRequisitante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeRequisitante.Name = "lblNomeRequisitante";
            this.lblNomeRequisitante.Size = new System.Drawing.Size(45, 20);
            this.lblNomeRequisitante.TabIndex = 25;
            this.lblNomeRequisitante.Text = "Nome";
            // 
            // lblCracha
            // 
            this.lblCracha.AutoSize = true;
            this.lblCracha.ForeColor = System.Drawing.Color.Black;
            this.lblCracha.Location = new System.Drawing.Point(20, 84);
            this.lblCracha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCracha.Name = "lblCracha";
            this.lblCracha.Size = new System.Drawing.Size(52, 20);
            this.lblCracha.TabIndex = 24;
            this.lblCracha.Text = "Codigo";
            // 
            // btnAcrescentar
            // 
            this.btnAcrescentar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAcrescentar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAcrescentar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcrescentar.ForeColor = System.Drawing.Color.White;
            this.btnAcrescentar.Location = new System.Drawing.Point(228, 127);
            this.btnAcrescentar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcrescentar.Name = "btnAcrescentar";
            this.btnAcrescentar.Size = new System.Drawing.Size(162, 28);
            this.btnAcrescentar.TabIndex = 16;
            this.btnAcrescentar.Text = "+";
            this.btnAcrescentar.UseVisualStyleBackColor = false;
            this.btnAcrescentar.Click += new System.EventHandler(this.btnAcrescentar_Click);
            // 
            // btnBuscarColaborador
            // 
            this.btnBuscarColaborador.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBuscarColaborador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBuscarColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarColaborador.ForeColor = System.Drawing.Color.White;
            this.btnBuscarColaborador.Location = new System.Drawing.Point(274, 79);
            this.btnBuscarColaborador.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarColaborador.Name = "btnBuscarColaborador";
            this.btnBuscarColaborador.Size = new System.Drawing.Size(63, 28);
            this.btnBuscarColaborador.TabIndex = 23;
            this.btnBuscarColaborador.Text = "Buscar";
            this.btnBuscarColaborador.UseVisualStyleBackColor = false;
            this.btnBuscarColaborador.Click += new System.EventHandler(this.btnBuscarColaborador_Click);
            // 
            // txtItem
            // 
            this.txtItem.Enabled = false;
            this.txtItem.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(402, 83);
            this.txtItem.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(327, 24);
            this.txtItem.TabIndex = 22;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(80, 81);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(186, 27);
            this.txtCodigo.TabIndex = 21;
            // 
            // lblRequisitante
            // 
            this.lblRequisitante.AutoSize = true;
            this.lblRequisitante.ForeColor = System.Drawing.Color.Black;
            this.lblRequisitante.Location = new System.Drawing.Point(355, 84);
            this.lblRequisitante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequisitante.Name = "lblRequisitante";
            this.lblRequisitante.Size = new System.Drawing.Size(39, 20);
            this.lblRequisitante.TabIndex = 20;
            this.lblRequisitante.Text = "Item";
            // 
            // btnAdcionar
            // 
            this.btnAdcionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdcionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdcionar.ForeColor = System.Drawing.Color.White;
            this.btnAdcionar.Location = new System.Drawing.Point(568, 127);
            this.btnAdcionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdcionar.Name = "btnAdcionar";
            this.btnAdcionar.Size = new System.Drawing.Size(161, 28);
            this.btnAdcionar.TabIndex = 19;
            this.btnAdcionar.Text = "Adcionar";
            this.btnAdcionar.UseVisualStyleBackColor = false;
            this.btnAdcionar.Click += new System.EventHandler(this.btnAdcionar_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(110, 127);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(110, 27);
            this.txtQuantidade.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Quantidade";
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubtrair.ForeColor = System.Drawing.Color.White;
            this.btnSubtrair.Location = new System.Drawing.Point(398, 127);
            this.btnSubtrair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(162, 28);
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
            this.btnRemover.Location = new System.Drawing.Point(455, 600);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(161, 28);
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
            this.btnConfirmar.Location = new System.Drawing.Point(218, 600);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(161, 28);
            this.btnConfirmar.TabIndex = 26;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item";
            this.columnHeader2.Width = 300;
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
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listSaida.FullRowSelect = true;
            this.listSaida.GridLines = true;
            this.listSaida.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listSaida.HideSelection = false;
            this.listSaida.Location = new System.Drawing.Point(27, 357);
            this.listSaida.MultiSelect = false;
            this.listSaida.Name = "listSaida";
            this.listSaida.Size = new System.Drawing.Size(746, 210);
            this.listSaida.TabIndex = 15;
            this.listSaida.UseCompatibleStateImageBehavior = false;
            this.listSaida.View = System.Windows.Forms.View.Details;
            // 
            // grdTitulo
            // 
            this.grdTitulo.Controls.Add(this.lblTitulo);
            this.grdTitulo.Location = new System.Drawing.Point(27, 12);
            this.grdTitulo.Name = "grdTitulo";
            this.grdTitulo.Size = new System.Drawing.Size(746, 100);
            this.grdTitulo.TabIndex = 27;
            this.grdTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bernard MT Condensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(323, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(100, 44);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SAÍDA";
            // 
            // SaidaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.grdTitulo);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.listSaida);
            this.Controls.Add(this.groupBox2);
            this.Name = "SaidaView";
            this.Text = "Saida";
            this.Load += new System.EventHandler(this.SaidaView_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grdTitulo.ResumeLayout(false);
            this.grdTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCracha;
        private System.Windows.Forms.Button btnBuscarColaborador;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblRequisitante;
        private System.Windows.Forms.Button btnAdcionar;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnAcrescentar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
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
    }
}