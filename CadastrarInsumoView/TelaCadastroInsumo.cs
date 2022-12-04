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

namespace CadastrarInsumoView
{
    public partial class TelaCadastroInsumo : Form
    {
        mdlEstoque _mdlEstoque = new mdlEstoque();
        ctrlEstoque _ctrlEstoque = new ctrlEstoque();
        public TelaCadastroInsumo()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            try
            {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nome = txtNome.Text;
            string unidade;
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            int quantidadeMin = Convert.ToInt32(txtQtdMin.Text);

                if (radBD.Checked == true)
                {
                    unidade = "BD";
                    _mdlEstoque.unidade = unidade;
                }
                else if (radCL.Checked == true)
                {
                    unidade = "CL";
                    _mdlEstoque.unidade = unidade;
                }
                else if (radFD.Checked == true)
                {
                    unidade = "FD";
                    _mdlEstoque.unidade = unidade;
                }
                else if (radGL.Checked == true)
                {
                    unidade = "GL";
                    _mdlEstoque.unidade = unidade;
                }
                else if (radKG.Checked == true)
                {
                    unidade = "KG";
                    _mdlEstoque.unidade = unidade;
                }
                else if (radMI.Checked == true)
                {
                    unidade = "MI";
                    _mdlEstoque.unidade = unidade;
                }
                else if (radUN.Checked == true)
                {
                    unidade = "UN";
                    _mdlEstoque.unidade = unidade;
                }
                else if (radMt.Checked == true)
                {
                    unidade = "MT";
                    _mdlEstoque.unidade = unidade;
                }

                _mdlEstoque.codigo = codigo;
                _mdlEstoque.nome = nome.ToUpper();
                _mdlEstoque.quantidade = quantidade;
                _mdlEstoque.qtdMinima = quantidadeMin;

                var retorno = _ctrlEstoque.CadastrarInsumo(_mdlEstoque);

                if(nome.Length <= 40)
                {
                    _ctrlEstoque.CadastrarInsumo(_mdlEstoque);
                    if(retorno == true)
                    {
                        txtCodigo.Text = String.Empty;
                        txtNome.Text = String.Empty;
                        txtQuantidade.Text = String.Empty;
                        txtCodigo.Focus();
                        MessageBox.Show("Cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                    {
                        MessageBox.Show("Erro no cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }else if (nome.Length > 40)
                {
                    MessageBox.Show("Nome do item é muito longo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Verifique se os dados foram preenchidos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
