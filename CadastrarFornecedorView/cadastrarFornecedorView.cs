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
using FornecedorModel;

namespace CadastrarFornecedorView
{
    public partial class cadastrarFornecedorView : Form
    {
        ctrlForrnecedor _ctrlFornecedor = new ctrlForrnecedor();
        mdlFornecedor _mdlFornecedor;
        public cadastrarFornecedorView()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {

            string cnpj = txtCnpj.Text;
            string nomeEmpresa = txtNomeEmpresa.Text;
            string rua = txtRua.Text;
            int numero = Convert.ToInt32(txtNumero.Text);
            string bairro = txtBairro.Text;
            string cidade = txtCidade.Text;

            _mdlFornecedor = new mdlFornecedor(cnpj, nomeEmpresa.ToUpper(), rua.ToUpper(), numero, bairro.ToUpper(), cidade.ToUpper());

            bool retorno = _ctrlFornecedor.Cadastrar(_mdlFornecedor);

            if(retorno == true)
            {
                txtCnpj.Text = String.Empty;
                txtNomeEmpresa.Text = String.Empty;
                txtRua.Text = String.Empty;

                MessageBox.Show("Cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro no cadastro");
            }
            }
            catch
            {
                MessageBox.Show("Dados incompletos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
