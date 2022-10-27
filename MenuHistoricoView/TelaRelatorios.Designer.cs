﻿namespace MenuHistoricoView
{
    partial class TelaRelatorios
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
            this.btnRelatorioHistorico = new System.Windows.Forms.Button();
            this.grpMovimentacoes = new System.Windows.Forms.GroupBox();
            this.btnExibirSaidas = new System.Windows.Forms.Button();
            this.btnExibirEntradas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtDataMovimentacao = new System.Windows.Forms.TextBox();
            this.btnBuscarPorData = new System.Windows.Forms.Button();
            this.btnGerarSaidas = new System.Windows.Forms.Button();
            this.grpMovimentacoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRelatorioHistorico
            // 
            this.btnRelatorioHistorico.BackColor = System.Drawing.Color.Navy;
            this.btnRelatorioHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioHistorico.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioHistorico.ForeColor = System.Drawing.Color.White;
            this.btnRelatorioHistorico.Location = new System.Drawing.Point(20, 36);
            this.btnRelatorioHistorico.Name = "btnRelatorioHistorico";
            this.btnRelatorioHistorico.Size = new System.Drawing.Size(139, 28);
            this.btnRelatorioHistorico.TabIndex = 0;
            this.btnRelatorioHistorico.Text = "Gerar total";
            this.btnRelatorioHistorico.UseVisualStyleBackColor = false;
            this.btnRelatorioHistorico.Click += new System.EventHandler(this.btnRelatorioHistorico_Click);
            // 
            // grpMovimentacoes
            // 
            this.grpMovimentacoes.Controls.Add(this.btnExibirSaidas);
            this.grpMovimentacoes.Controls.Add(this.btnExibirEntradas);
            this.grpMovimentacoes.Controls.Add(this.btnRelatorioHistorico);
            this.grpMovimentacoes.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMovimentacoes.ForeColor = System.Drawing.Color.Navy;
            this.grpMovimentacoes.Location = new System.Drawing.Point(25, 38);
            this.grpMovimentacoes.Name = "grpMovimentacoes";
            this.grpMovimentacoes.Size = new System.Drawing.Size(181, 195);
            this.grpMovimentacoes.TabIndex = 1;
            this.grpMovimentacoes.TabStop = false;
            this.grpMovimentacoes.Text = "Movimentações";
            // 
            // btnExibirSaidas
            // 
            this.btnExibirSaidas.BackColor = System.Drawing.Color.Navy;
            this.btnExibirSaidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirSaidas.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirSaidas.ForeColor = System.Drawing.Color.White;
            this.btnExibirSaidas.Location = new System.Drawing.Point(20, 141);
            this.btnExibirSaidas.Name = "btnExibirSaidas";
            this.btnExibirSaidas.Size = new System.Drawing.Size(139, 28);
            this.btnExibirSaidas.TabIndex = 3;
            this.btnExibirSaidas.Text = "Gerar saídas";
            this.btnExibirSaidas.UseVisualStyleBackColor = false;
            this.btnExibirSaidas.Click += new System.EventHandler(this.btnExibirSaidas_Click);
            // 
            // btnExibirEntradas
            // 
            this.btnExibirEntradas.BackColor = System.Drawing.Color.Navy;
            this.btnExibirEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirEntradas.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirEntradas.ForeColor = System.Drawing.Color.White;
            this.btnExibirEntradas.Location = new System.Drawing.Point(20, 88);
            this.btnExibirEntradas.Name = "btnExibirEntradas";
            this.btnExibirEntradas.Size = new System.Drawing.Size(139, 28);
            this.btnExibirEntradas.TabIndex = 2;
            this.btnExibirEntradas.Text = "Gerar entradas";
            this.btnExibirEntradas.UseVisualStyleBackColor = false;
            this.btnExibirEntradas.Click += new System.EventHandler(this.btnExibirEntradas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGerarSaidas);
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Controls.Add(this.txtDataMovimentacao);
            this.groupBox1.Controls.Add(this.btnBuscarPorData);
            this.groupBox1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(242, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerar por filtro";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(15, 69);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(106, 19);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Filtrar por data";
            // 
            // txtDataMovimentacao
            // 
            this.txtDataMovimentacao.Location = new System.Drawing.Point(137, 66);
            this.txtDataMovimentacao.Name = "txtDataMovimentacao";
            this.txtDataMovimentacao.Size = new System.Drawing.Size(122, 26);
            this.txtDataMovimentacao.TabIndex = 3;
            // 
            // btnBuscarPorData
            // 
            this.btnBuscarPorData.BackColor = System.Drawing.Color.Green;
            this.btnBuscarPorData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPorData.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPorData.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorData.Location = new System.Drawing.Point(275, 66);
            this.btnBuscarPorData.Name = "btnBuscarPorData";
            this.btnBuscarPorData.Size = new System.Drawing.Size(106, 28);
            this.btnBuscarPorData.TabIndex = 0;
            this.btnBuscarPorData.Text = "Gerar Entradas";
            this.btnBuscarPorData.UseVisualStyleBackColor = false;
            this.btnBuscarPorData.Click += new System.EventHandler(this.btnBuscarPorData_Click);
            // 
            // btnGerarSaidas
            // 
            this.btnGerarSaidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGerarSaidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarSaidas.Font = new System.Drawing.Font("Bernard MT Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarSaidas.ForeColor = System.Drawing.Color.White;
            this.btnGerarSaidas.Location = new System.Drawing.Point(387, 66);
            this.btnGerarSaidas.Name = "btnGerarSaidas";
            this.btnGerarSaidas.Size = new System.Drawing.Size(106, 28);
            this.btnGerarSaidas.TabIndex = 6;
            this.btnGerarSaidas.Text = "Gerar Saidas";
            this.btnGerarSaidas.UseVisualStyleBackColor = false;
            this.btnGerarSaidas.Click += new System.EventHandler(this.btnGerarSaidas_Click);
            // 
            // TelaRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 266);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpMovimentacoes);
            this.Name = "TelaRelatorios";
            this.Text = "Relatorios";
            this.grpMovimentacoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRelatorioHistorico;
        private System.Windows.Forms.GroupBox grpMovimentacoes;
        private System.Windows.Forms.Button btnExibirSaidas;
        private System.Windows.Forms.Button btnExibirEntradas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarPorData;
        private System.Windows.Forms.TextBox txtDataMovimentacao;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnGerarSaidas;
    }
}

