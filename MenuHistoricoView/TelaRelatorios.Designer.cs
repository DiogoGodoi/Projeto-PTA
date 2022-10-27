namespace MenuHistoricoView
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
            this.btnImpressaoEntradas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImpressaoEntradas
            // 
            this.btnImpressaoEntradas.Location = new System.Drawing.Point(98, 66);
            this.btnImpressaoEntradas.Name = "btnImpressaoEntradas";
            this.btnImpressaoEntradas.Size = new System.Drawing.Size(75, 23);
            this.btnImpressaoEntradas.TabIndex = 0;
            this.btnImpressaoEntradas.Text = "Imprimir Entradas";
            this.btnImpressaoEntradas.UseVisualStyleBackColor = true;
            this.btnImpressaoEntradas.Click += new System.EventHandler(this.btnImpressaoEntradas_Click);
            // 
            // TelaRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImpressaoEntradas);
            this.Name = "TelaRelatorios";
            this.Text = "Relatorios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImpressaoEntradas;
    }
}

