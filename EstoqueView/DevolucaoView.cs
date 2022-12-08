using ColaboradoresControle;
using EstoqueControle;
using HistoricoControle;
using HistoricoModel;
using RelatoriosControle;
using SaidaControle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuariosModel;

namespace EstoqueView
{
    public partial class DevolucaoView : Form
    {

        ctrlEstoque _ctrlEstoque = new ctrlEstoque();
        mdlHistorico _mdlHistorico = new mdlHistorico();
        ctrlHistorico _ctrlHistorico = new ctrlHistorico();
        ctrlRelatorios _ctrlRelatorios = new ctrlRelatorios();
        ctrlColaboradores _ctrlColaboradores = new ctrlColaboradores();
        List<ctrlMovimentacao> list = new List<ctrlMovimentacao>();
        ListViewItem items;
        int contador;

        public DevolucaoView()
        {
            InitializeComponent();
        }

        private void btnBuscarRequisitante_Click(object sender, EventArgs e)
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

                string item = txtItem.Text;
                string quantidade = txtQuantidade.Text;
                string operador = mdlUsuarios.getNome();
                _ctrlEstoque.Pesquisar(item);

                if (txtItem.Text == String.Empty || txtQuantidade.Text == String.Empty || txtCracha.Text == String.Empty)
                {
                    MessageBox.Show("Dados incompletos");

                }else if (item == ctrlMovimentacao.item)
                {
                    MessageBox.Show("Item ja adcionado");
                }
                else
                {
                    list.Add(new ctrlMovimentacao(item, quantidade, operador));

                    foreach (var i in list)
                    {
                        items = new ListViewItem(i.nome);
                        items.SubItems.Add(i.quantidade);
                    }

                    listSaida.Items.Add(items);
                    txtQuantidade.Text = String.Empty;
                    txtItem.Text = String.Empty;
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
            string nomeRequisitante = txtNomeRequisitante.Text;
            string requisitante = _ctrlColaboradores.getNome();
            string nomeSetor = _ctrlColaboradores.getSetor();
            string cracha = txtCracha.Text;

            foreach (var item in list)
            {
                
                    _ctrlEstoque.Entrada(item.nome, item.quantidade);
                    _mdlHistorico.natureza = "DEVOLUÇÃO";
                    _mdlHistorico.operador = mdlUsuarios.getNome();
                    _mdlHistorico.quantidade = Convert.ToInt32(item.quantidade);
                    _mdlHistorico.item = item.nome;
                    _mdlHistorico.requisitante = nomeRequisitante.ToUpper();

                    _ctrlHistorico.CadastrarHistorico(_mdlHistorico);

                    txtCracha.Text = String.Empty;
                    txtItem.Text = String.Empty;
                    txtNomeRequisitante.Text = String.Empty;
                    txtQuantidade.Text = String.Empty;
        
            }

            var resposta = MessageBox.Show("Deseja imprimir comprovante ", "Comprovante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                SaveFileDialog arquivo = new SaveFileDialog();
                arquivo.FileName = "Arquivo";
                arquivo.Filter = "PDF (.pdf) | *.pdf";

                if (arquivo.ShowDialog() == DialogResult.OK)
                {
                    _ctrlRelatorios.gerarRelatorioSaida("Devolução", arquivo.FileName, requisitante, nomeSetor, cracha, list);
                    MessageBox.Show("Arquivo salvo");
                }
                else
                {
                    MessageBox.Show("Sem dados");
                }

            }
        }
        private void DevolucaoView_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            try
            {
            this.estoqueTableAdapter.Fill(this.estoqueDB.Estoque);
            }
            catch (Exception)
            {

            }
            finally
            {
                ctrlEstoque _ctrlEstoque = new ctrlEstoque();
                DataTable tabela = _ctrlEstoque.Exibir();
                grdEstoque.DataSource = tabela;
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrlEstoque _ctrlEstoque = new ctrlEstoque();
                string nome = txtProcurar.Text;
                DataTable retorno = _ctrlEstoque.Pesquisar(nome);

                if (retorno == null)
                {
                    MessageBox.Show("Item não localizado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProcurar.Text = String.Empty;
                    grdEstoque.DataSource = _ctrlEstoque.Exibir();
                }
                else if (retorno != null && nome != String.Empty)
                {
                    grdEstoque.DataSource = _ctrlEstoque.Pesquisar(nome);
                }
                else
                {
                    MessageBox.Show("Digite o nome do item", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Erro na pesquisa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItem.Text = grdEstoque.SelectedCells[0].Value.ToString();
        }

        private void grdEstoque_CellContentClick(object sender, EventArgs e)
        {
            txtItem.Text = grdEstoque.SelectedCells[0].Value.ToString();
        }
    }
 }
