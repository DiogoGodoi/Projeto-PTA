using ColaboradoresControle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FornecedorControle;
using EstoqueControle;
using SaidaControle;
using UsuariosModel;
using HistoricoControle;
using HistoricoModel;
using RelatoriosControle;
using EntradaControle;
using EntradaModel;

namespace EstoqueView
{
    public partial class EntradaView : Form
    {
        mdlEntrada _mdlEntrada;
        ctrlRelatorios _ctrlRelatorios = new ctrlRelatorios();
        ctrlEntrada _ctrlEntrada = new ctrlEntrada();
        mdlHistorico _mdlHistorico = new mdlHistorico();
        ctrlHistorico _ctrlHistorico = new ctrlHistorico();
        ctrlForrnecedor _ctrlFornecedor = new ctrlForrnecedor();
        ctrlEstoque _ctrlEstoque = new ctrlEstoque();
        List<ctrlMovimentacao> list = new List<ctrlMovimentacao>();
        ListViewItem items;
        int contador;
        public EntradaView()
        {
            InitializeComponent();
        }

        private void btnBuscaEmpresa_Click(object sender, EventArgs e)
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

        private void btnBuscarItem_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                _ctrlEstoque.PesquisarPorCodigo(codigo);

                if (_ctrlEstoque.PesquisarPorCodigo(codigo) == null)
                {
                    MessageBox.Show("Item não localizado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtItem.Text = _ctrlEstoque.getItem();
                    txtItem.Enabled = false;
                }
                else
                {
                    txtItem.Text = _ctrlEstoque.getItem();
                    txtItem.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Erro", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAcrescentar_Click(object sender, EventArgs e)
        {
            contador++;
            txtQuantidade.Text = contador.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            contador--;

            if (Convert.ToUInt32(txtQuantidade.Text) == 0)
            {
                MessageBox.Show("Sem valor para subtrair");
            }
            else
            {
                txtQuantidade.Text = contador.ToString();
            }
        }

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            try
            {

                ctrlMovimentacao _ctrlMovimentacao = new ctrlMovimentacao();

                string cnpj = txtCnpj.Text;
                string nomeEmpresa = txtNomeEmpresa.Text;
                int nf = Convert.ToInt32(txtNF.Text);
                int codigo = Convert.ToInt32(txtCodigo.Text);
                string item = txtItem.Text;
                string quantidade = txtQuantidade.Text;
                string operador = mdlUsuarios.getNome();

                if (txtCnpj.Text == String.Empty || txtNomeEmpresa.Text == String.Empty || 
                    txtNF.Text == String.Empty || txtCodigo.Text == String.Empty || 
                    txtItem.Text == String.Empty || txtQuantidade.Text == String.Empty)
                {
                    MessageBox.Show("Dados incompletos");
                }
                else
                {
                    list.Add(new ctrlMovimentacao(cnpj, nomeEmpresa, nf, codigo.ToString(), item, quantidade, operador));

                    foreach (var i in list)
                    {
                        items = new ListViewItem(i.codigo);
                        items.SubItems.Add(i.nome);
                        items.SubItems.Add(i.quantidade);
                    }

                    listSaida.Items.Add(items);
                    txtCnpj.Enabled = false;
                    txtNF.Enabled = false;
                    txtCodigo.Text = String.Empty;
                    txtItem.Text = String.Empty;
                    txtQuantidade.Text = String.Empty;
                    contador = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dados incompletos");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var indice = listSaida.SelectedItems[0].Index;
            list.RemoveAt(indice);
            listSaida.SelectedItems[0].Remove();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int numeroDaNf = Convert.ToInt32(txtNF.Text);
            string nomeDaEmpresa = txtNomeEmpresa.Text;
            string item = txtItem.Text;
            string quantidade = txtQuantidade.Text;
            string recebedor = mdlUsuarios.getNome();

            foreach (var items in list)
            {
                _ctrlEstoque.Pesquisar(items.nome);
                if (Convert.ToInt32(items.quantidade) > _ctrlEstoque.getQtd())
                {
                    MessageBox.Show("O item: " + items.nome + " não pode ser baixado, quantidade insufuciente no estoque");
                }
                else
                {
                    _ctrlEstoque.Entrada(items.nome, items.quantidade);

                    _mdlHistorico.natureza = "ENTRADA";
                    _mdlHistorico.operador = mdlUsuarios.getNome();
                    _mdlHistorico.quantidade = Convert.ToInt32(items.quantidade);
                    _mdlHistorico.item = items.nome;
                    _mdlHistorico.requisitante = recebedor.ToUpper();

                    _ctrlHistorico.CadastrarHistorico(_mdlHistorico);

                    _mdlEntrada = new mdlEntrada(numeroDaNf, nomeDaEmpresa, item, Convert.ToInt32(quantidade), recebedor);

                    _ctrlEntrada.Cadastrar(_mdlEntrada);

                    txtCnpj.Text = String.Empty;
                    txtCnpj.Enabled = true;
                    txtNomeEmpresa.Text = String.Empty;
                    txtNF.Text = String.Empty;
                    txtNF.Enabled = true;
                    txtCodigo.Text = String.Empty;
                    txtItem.Text = String.Empty;
                    txtQuantidade.Text = String.Empty;

                }
            }

            var resposta = MessageBox.Show("Deseja imprimir comprovante ", "Comprovante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                SaveFileDialog arquivo = new SaveFileDialog();
                arquivo.FileName = "Arquivo";
                arquivo.Filter = "PDF (.pdf) | *.pdf";

                if (arquivo.ShowDialog() == DialogResult.OK)
                {
                    _ctrlRelatorios.gerarRelatorioSaida("Saída", arquivo.FileName, nomeDaEmpresa, "", list);
                    MessageBox.Show("Arquivo salvo");
                }
                else
                {
                    MessageBox.Show("Sem dados");
                }

            }
        }
    }
}
