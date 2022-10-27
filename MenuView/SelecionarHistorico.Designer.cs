namespace MenuView
{
    partial class frmSelecionarHistorico
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
            this.btnHistoricoEpi = new System.Windows.Forms.Button();
            this.btnHistoricoAlmoxarifado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHistoricoEpi
            // 
            this.btnHistoricoEpi.BackColor = System.Drawing.Color.Navy;
            this.btnHistoricoEpi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistoricoEpi.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoricoEpi.ForeColor = System.Drawing.Color.White;
            this.btnHistoricoEpi.Location = new System.Drawing.Point(12, 32);
            this.btnHistoricoEpi.Name = "btnHistoricoEpi";
            this.btnHistoricoEpi.Size = new System.Drawing.Size(292, 32);
            this.btnHistoricoEpi.TabIndex = 0;
            this.btnHistoricoEpi.Text = "Epi";
            this.btnHistoricoEpi.UseVisualStyleBackColor = false;
            this.btnHistoricoEpi.Click += new System.EventHandler(this.btnHistoricoEpi_Click);
            // 
            // btnHistoricoAlmoxarifado
            // 
            this.btnHistoricoAlmoxarifado.BackColor = System.Drawing.Color.Navy;
            this.btnHistoricoAlmoxarifado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistoricoAlmoxarifado.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoricoAlmoxarifado.ForeColor = System.Drawing.Color.White;
            this.btnHistoricoAlmoxarifado.Location = new System.Drawing.Point(12, 106);
            this.btnHistoricoAlmoxarifado.Name = "btnHistoricoAlmoxarifado";
            this.btnHistoricoAlmoxarifado.Size = new System.Drawing.Size(292, 32);
            this.btnHistoricoAlmoxarifado.TabIndex = 1;
            this.btnHistoricoAlmoxarifado.Text = "Almoxarifado";
            this.btnHistoricoAlmoxarifado.UseVisualStyleBackColor = false;
            this.btnHistoricoAlmoxarifado.Click += new System.EventHandler(this.btnHistoricoAlmoxarifado_Click);
            // 
            // frmSelecionarHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 170);
            this.Controls.Add(this.btnHistoricoAlmoxarifado);
            this.Controls.Add(this.btnHistoricoEpi);
            this.Name = "frmSelecionarHistorico";
            this.Text = "Selecionar Historico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHistoricoEpi;
        private System.Windows.Forms.Button btnHistoricoAlmoxarifado;
    }
}