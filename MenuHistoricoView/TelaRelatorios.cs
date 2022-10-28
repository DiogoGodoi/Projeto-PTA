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
using System.Security.Cryptography;
using ColaboradoresControle;

namespace MenuHistoricoView
{
    public partial class TelaRelatorios : Form
    {
       ctrlRelatorios _ctrlRelatorios = new ctrlRelatorios();
       ctrlHistorico _ctrlHistorico = new ctrlHistorico();
       ctrlColaboradores _ctrlColaboradores = new ctrlColaboradores();
        
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
        private void btnGerarDevolucao_Click(object sender, EventArgs e)
        {
            try
            {

                SaveFileDialog arquivo = new SaveFileDialog();
                arquivo.FileName = "Arquivo";
                arquivo.Filter = "PDF (.pdf) | *.pdf";

                if (arquivo.ShowDialog() == DialogResult.OK)
                {
                    _ctrlRelatorios.gerarRelatorioMovimentacao(arquivo.FileName, _ctrlHistorico.ExibirDevolucao());
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

        private void btnGerarTudoData_Click(object sender, EventArgs e)
        {
            try
            {

                var data = Convert.ToDateTime(txtDataMovimentacao.Text);
                SaveFileDialog arquivo = new SaveFileDialog();
                arquivo.FileName = "Arquivo";
                arquivo.Filter = "PDF (.pdf) | *.pdf";

                if (arquivo.ShowDialog() == DialogResult.OK)
                {
                    _ctrlRelatorios.gerarRelatorioMovimentacao(arquivo.FileName, _ctrlHistorico.PesquisarTudo(data));
                    MessageBox.Show("Arquivo salvo");
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor insira uma data");
            }
        }
        private void btnBuscarPorData_Click(object sender, EventArgs e)
        {

            try
            {
                
                var dia = Convert.ToDateTime(txtDataMovimentacao.Text);

                SaveFileDialog arquivo = new SaveFileDialog();
                arquivo.FileName = "Arquivo";
                arquivo.Filter = "PDF (.pdf) | *.pdf";

                if (arquivo.ShowDialog() == DialogResult.OK)
                {
                    _ctrlRelatorios.gerarRelatorioMovimentacao(arquivo.FileName, _ctrlHistorico.PesquisarEntrada(dia));
                    MessageBox.Show("Arquivo salvo");
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                }
                
                {
                    MessageBox.Show("Por favor insira a data");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor insira uma data");
            }
        }
        private void btnGerarSaidas_Click(object sender, EventArgs e)
        {

            try
            {

                var dia = Convert.ToDateTime(txtDataMovimentacao.Text);
                SaveFileDialog arquivo = new SaveFileDialog();
                arquivo.FileName = "Arquivo";
                arquivo.Filter = "PDF (.pdf) | *.pdf";

                if (arquivo.ShowDialog() == DialogResult.OK)
                {
                    _ctrlRelatorios.gerarRelatorioMovimentacao(arquivo.FileName, _ctrlHistorico.PesquisarSaida(dia));
                    MessageBox.Show("Arquivo salvo");
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor insira uma data");
            }
        }
        private void btnGerarDevolucaoData_Click(object sender, EventArgs e)
        {

            try
            {

                var data = Convert.ToDateTime(txtDataMovimentacao.Text);
                SaveFileDialog arquivo = new SaveFileDialog();
                arquivo.FileName = "Arquivo";
                arquivo.Filter = "PDF (.pdf) | *.pdf";

                if (arquivo.ShowDialog() == DialogResult.OK)
                {
                    _ctrlRelatorios.gerarRelatorioMovimentacao(arquivo.FileName, _ctrlHistorico.PesquisarDevolucao(data));
                    MessageBox.Show("Arquivo salvo");
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor insira uma data");
            }
        }

        private void btnGerarTudoCraha_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCracha.Text == String.Empty)
                {
                    MessageBox.Show("Por favor digite o crachá do colaborador");
                }
                else
                {


                    SaveFileDialog arquivo = new SaveFileDialog();
                    arquivo.FileName = "Arquivo";
                    arquivo.Filter = "PDF (.pdf) | *.pdf";

                    if (arquivo.ShowDialog() == DialogResult.OK)
                    {
                        _ctrlRelatorios.gerarRelatorioMovimentacao(arquivo.FileName, _ctrlHistorico.PesquisarTudoPorNome(txtNomeRequisitante.Text));
                        MessageBox.Show("Arquivo salvo");
                    }
                    else
                    {
                        MessageBox.Show("Operação cancelada");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("SemDados");
            }
        }
        private void btnGerarSaidaCracha_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCracha.Text == String.Empty)
                {
                    MessageBox.Show("Por favor digite o crachá do colaborador");
                }
                else
                {

            
                SaveFileDialog arquivo = new SaveFileDialog();
                arquivo.FileName = "Arquivo";
                arquivo.Filter = "PDF (.pdf) | *.pdf";

                if (arquivo.ShowDialog() == DialogResult.OK)
                {
                    _ctrlRelatorios.gerarRelatorioMovimentacao(arquivo.FileName, _ctrlHistorico.PesquisarSaidaPorNome(txtNomeRequisitante.Text));
                    MessageBox.Show("Arquivo salvo");
                }
                else
                {
                    MessageBox.Show("Operação cancelada");
                }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("SemDados");
            }
        }
        private void btnGerarDevolucoesCracha_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCracha.Text == String.Empty)
                {
                    MessageBox.Show("Por favor digite o crachá do colaborador");
                }
                else
                {
                    SaveFileDialog arquivo = new SaveFileDialog();
                    arquivo.FileName = "Arquivo";
                    arquivo.Filter = "PDF (.pdf) | *.pdf";

                    if (arquivo.ShowDialog() == DialogResult.OK)
                    {
                        _ctrlRelatorios.gerarRelatorioMovimentacao(arquivo.FileName, _ctrlHistorico.PesquisarDevolucaoPorNome(txtNomeRequisitante.Text));
                        MessageBox.Show("Arquivo salvo");
                    }
                    else
                    {
                        MessageBox.Show("Operação cancelada");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro interno");
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int cracha = Convert.ToInt32(txtCracha.Text);
                bool retorno = _ctrlColaboradores.pesquisarColaborador(cracha);

                if (retorno == false)
                {
                    MessageBox.Show("Colaborador não localizado", "Não localizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtNomeRequisitante.Text = _ctrlColaboradores.getNome();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor digite o número do crachá", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TelaRelatorios_Load(object sender, EventArgs e)
        {
            txtNomeRequisitante.Enabled = false;
        }
    }
}

