using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstoqueControle;
using EstoqueModel;

namespace AlterarInsumoView
{
    public partial class TelaAlterarInsumo : Form
    {

        ctrlEstoque _ctrlEstoque = new ctrlEstoque();
        mdlEstoque _mdlEstoque = new mdlEstoque();

        public TelaAlterarInsumo()
        {
            InitializeComponent();
        }

        private void frmAlterarInsumo_Load(object sender, EventArgs e)
        {
            try
            {
            this.estoqueTableAdapter.Fill(this.estoqueTB.Estoque);
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

        private void grdEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItem.Text = grdEstoque.SelectedCells[0].Value.ToString();
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

        private void btnBuscaEmpresa_Click(object sender, EventArgs e)
        {
                    string item = txtItem.Text;

                    DataTable retorno = _ctrlEstoque.Pesquisar(item);
                
                    if(retorno != null)
            {
                    txtCodigo.Text = _ctrlEstoque.getCodigo().ToString();
                    txtItem.Text = _ctrlEstoque.getItem();
                    txtTipoUnitario.Text = _ctrlEstoque.getTipoUn();
                    txtQuantidade.Text = _ctrlEstoque.getQtd().ToString();
                    txtEstoqueMin.Text = _ctrlEstoque.getEstoqueMin().ToString();
            }
              
        }

        private void radUN_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoUnitario.Text = "UN";
        }

        private void radCL_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoUnitario.Text = "CL";
        }

        private void radKG_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoUnitario.Text = "KG";
        }

        private void radMI_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoUnitario.Text = "MI";
        }

        private void radGL_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoUnitario.Text = "GL";
        }

        private void radFD_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoUnitario.Text = "FD";
        }

        private void radBD_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoUnitario.Text = "BD";
        }

        private void radMt_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoUnitario.Text = "MT";
        }

        private void radPR_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoUnitario.Text = "PR";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {

            int codigo = Convert.ToInt32(txtCodigo.Text);
            string item = txtItem.Text;
            string unidade = txtTipoUnitario.Text;
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            int estoqueMin = Convert.ToInt32(txtEstoqueMin.Text);

            _mdlEstoque.codigo = codigo;
            _mdlEstoque.nome = item.ToUpper();
            _mdlEstoque.unidade = unidade;
            _mdlEstoque.quantidade = quantidade;
            _mdlEstoque.qtdMinima = estoqueMin;
            
            bool retorno = _ctrlEstoque.Alterar(_mdlEstoque, item);

            if(retorno == true)
            {
                txtCodigo.Text = String.Empty;
                txtItem.Text = String.Empty;
                txtTipoUnitario.Text = String.Empty;
                txtQuantidade.Text = String.Empty;
                txtEstoqueMin.Text = String.Empty;

                MessageBox.Show("Alterado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro na alteração", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro interno: " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
