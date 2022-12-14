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
using FornecedorControle;
using EntradaControle;

namespace MenuHistoricoView
{
    public partial class TelaRelatorios : Form
    {
       ctrlRelatorios _ctrlRelatorios = new ctrlRelatorios();
       ctrlHistorico _ctrlHistorico = new ctrlHistorico();
       ctrlColaboradores _ctrlColaboradores = new ctrlColaboradores();
       ctrlForrnecedor _ctrlFornecedor = new ctrlForrnecedor();
        ctrlEntrada _ctrlEntrada = new ctrlEntrada();
        
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
                    _ctrlRelatorios.gerarRelatorioMovimentacaoEntrada(arquivo.FileName, _ctrlEntrada.ExibirEntrada());
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
        private void btnEstoqueMin_Click(object sender, EventArgs e)
        {
            try
            {

                SaveFileDialog arquivo = new SaveFileDialog();
                arquivo.FileName = "Arquivo";
                arquivo.Filter = "PDF (.pdf) | *.pdf";

                if (arquivo.ShowDialog() == DialogResult.OK)
                {
                    _ctrlRelatorios.relatorioEstoqueMin(arquivo.FileName, _ctrlHistorico.ExibirMinimo());
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
            this.WindowState = FormWindowState.Maximized;
            txtNomeRequisitante.Enabled = false;
        }
        private void btnBuscarPorItem_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                bool retorno = _ctrlHistorico.PesquisarPorCodigo(codigo);

                if (retorno == false)
                {
                    MessageBox.Show("Item não localizado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtItem.Text = _ctrlHistorico.getItem();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor digite o código do item", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGerarSaidaPorItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItem.Text == String.Empty)
                {
                    MessageBox.Show("Por favor digite o codigo do item");
                }
                else
                {
                    SaveFileDialog arquivo = new SaveFileDialog();
                    arquivo.FileName = "Arquivo";
                    arquivo.Filter = "PDF (.pdf) | *.pdf";

                    if (arquivo.ShowDialog() == DialogResult.OK)
                    {
                        _ctrlRelatorios.gerarRelatorioMovimentacao(arquivo.FileName, _ctrlHistorico.PesquisarPorItemNatureza(txtItem.Text, "SAÍDA"));
                        MessageBox.Show("Arquivo salvo");
                    }
                    else
                    {
                        MessageBox.Show("Operação cancelada");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro interno"+ ex);
            }
        }
        private void btnGerarDevolucaoPorItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItem.Text == String.Empty)
                {
                    MessageBox.Show("Por favor digite o codigo do item");
                }
                else
                {
                    SaveFileDialog arquivo = new SaveFileDialog();
                    arquivo.FileName = "Arquivo";
                    arquivo.Filter = "PDF (.pdf) | *.pdf";

                    if (arquivo.ShowDialog() == DialogResult.OK)
                    {
                        _ctrlRelatorios.gerarRelatorioMovimentacao(arquivo.FileName, _ctrlHistorico.PesquisarPorItemNatureza(txtItem.Text, "DEVOLUÇÃO"));
                        MessageBox.Show("Arquivo salvo");
                    }
                    else
                    {
                        MessageBox.Show("Operação cancelada");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro interno" + ex);
            }
        }
        private void btnGerarTudoPorItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItem.Text == String.Empty)
                {
                    MessageBox.Show("Por favor digite o codigo do item");
                }
                else
                {
                    SaveFileDialog arquivo = new SaveFileDialog();
                    arquivo.FileName = "Arquivo";
                    arquivo.Filter = "PDF (.pdf) | *.pdf";

                    if (arquivo.ShowDialog() == DialogResult.OK)
                    {
                        _ctrlRelatorios.gerarRelatorioMovimentacao(arquivo.FileName, _ctrlHistorico.PesquisarPorItem(txtItem.Text));
                        MessageBox.Show("Arquivo salvo");
                    }
                    else
                    {
                        MessageBox.Show("Operação cancelada");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro interno" + ex);
            }
        }
        private void btnBuscarEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                string cnpj = txtCnpj.Text;
                bool retorno = _ctrlFornecedor.ProcurarPorCnpj(cnpj);

                if (retorno == false)
                {
                    MessageBox.Show("Fornecedor não localizado", "Não localizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtNomeEmpresa.Text = _ctrlFornecedor.getNomeEmpresa();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor digite o cnpj da empresa", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGerarEntrada_Click(object sender, EventArgs e)
        {

            if (txtCnpj.Text == String.Empty)
            {
                MessageBox.Show("Por favor digite o cnpj da empresa");
            }
            else
            {

                string nomeEmpresa = txtNomeEmpresa.Text;

                SaveFileDialog arquivo = new SaveFileDialog();
                arquivo.FileName = "Arquivo";
                arquivo.Filter = "PDF (.pdf) | *.pdf";

                if (arquivo.ShowDialog() == DialogResult.OK)
                {
                    _ctrlRelatorios.gerarRelatorioPorEmpresa(arquivo.FileName, nomeEmpresa, _ctrlEntrada.Pesquisar(nomeEmpresa));
                    MessageBox.Show("Arquivo salvo");
                    nomeEmpresa = String.Empty;
                }
                else
                {
                    MessageBox.Show("Sem dados");
                }

            }
        }

        private void btnGerarEntradas_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItem.Text == String.Empty)
                {
                    MessageBox.Show("Por favor digite o codigo do item");
                }
                else
                {
                    SaveFileDialog arquivo = new SaveFileDialog();
                    arquivo.FileName = "Arquivo";
                    arquivo.Filter = "PDF (.pdf) | *.pdf";

                    if (arquivo.ShowDialog() == DialogResult.OK)
                    {
                        _ctrlRelatorios.gerarRelatorioMovimentacaoEntrada(arquivo.FileName, _ctrlEntrada.PesquisarPorItemNatureza(txtItem.Text));
                        MessageBox.Show("Arquivo salvo");
                    }
                    else
                    {
                        MessageBox.Show("Operação cancelada");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro interno" + ex);
            }
        }
    }
}

