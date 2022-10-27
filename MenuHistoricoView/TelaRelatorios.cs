using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using RelatoriosControle;
using HistoricoControle;

namespace MenuHistoricoView
{
    public partial class TelaRelatorios : Form
    {
       ctrlRelatorios _ctrlRelatorios = new ctrlRelatorios();
       ctrlHistorico _ctrlHistorico = new ctrlHistorico();
        public TelaRelatorios()
        {
            InitializeComponent();
        }

        private void btnRelatorioHistorico_Click(object sender, EventArgs e)
        {

            try
            {

                SaveFileDialog arquivo = new SaveFileDialog();
                arquivo.FileName = "Arquivo";
                arquivo.Filter = "PDF (.pdf) | *.pdf";

                if (arquivo.ShowDialog() == DialogResult.OK)
                {
                    _ctrlRelatorios.gerarRelatorioMovimentacao(arquivo.FileName, _ctrlHistorico.ExibirHistorico());
                    MessageBox.Show("Arquivo salvo");
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro interno");
            }
        }
        private void btnExibirEntradas_Click(object sender, EventArgs e)
        {
            try
            {

                SaveFileDialog arquivo = new SaveFileDialog();
                arquivo.FileName = "Arquivo";
                arquivo.Filter = "PDF (.pdf) | *.pdf";

                if (arquivo.ShowDialog() == DialogResult.OK)
                {
                    _ctrlRelatorios.gerarRelatorioMovimentacao(arquivo.FileName, _ctrlHistorico.ExibirEntrada());
                    MessageBox.Show("Arquivo salvo");
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro interno");
            }
        }
        private void btnExibirSaidas_Click(object sender, EventArgs e)
        {
            try
            {

                SaveFileDialog arquivo = new SaveFileDialog();
                arquivo.FileName = "Arquivo";
                arquivo.Filter = "PDF (.pdf) | *.pdf";

                if (arquivo.ShowDialog() == DialogResult.OK)
                {
                    _ctrlRelatorios.gerarRelatorioMovimentacao(arquivo.FileName, _ctrlHistorico.ExibirSaida());
                    MessageBox.Show("Arquivo salvo");
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro interno");
            }
        }

    }
}
