using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuariosControler;
using UsuariosModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace AlterarUsuarioView
{
    public partial class TelaAlterarSenha : Form
    {
        ctrlUsuarios _ctrlUsuario = new ctrlUsuarios();
        mdlUsuarios _mdlUsuario;
        public TelaAlterarSenha()
        {
            InitializeComponent();
        }

        private void TelaAlterarSenha_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            try
            {
            this.usuariosTableAdapter.Fill(this.usuariosTB.Usuarios);
            }
            catch (Exception)
            {

            }
            finally
            {
                DataTable tabela = _ctrlUsuario.Exibir();
                grdUsuarios.DataSource = tabela;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            bool retorno = _ctrlUsuario.Pesquisar(nome);

            if (retorno == true)
            {
                txtNome.Text = _ctrlUsuario.getNome();
                txtSenha.Text = _ctrlUsuario.getSenha();
                txtAcessos.Text = _ctrlUsuario.getNivel();
            }
        }

        private void grdEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = grdUsuarios.SelectedCells[0].Value.ToString();
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtNome.Text;

            mdlUsuarios.setNome(nome.ToUpper());
            mdlUsuarios.setSenha(senha);
            
            if (radAdministracao.Checked == true)
            {
                mdlUsuarios.setNivel("ADMINISTRAÇÃO");
            }else if(radAlmoxarifado.Checked == true)
            {
                mdlUsuarios.setNivel("PADRÃO");
            }

            bool retorno = _ctrlUsuario.Alterar(_mdlUsuario, nome);

            if(retorno == true)
            {
                MessageBox.Show("Alterado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = String.Empty;
                txtSenha.Text = String.Empty;
            }

        }

        private void radAlmoxarifado_CheckedChanged(object sender, EventArgs e)
        {
            txtAcessos.Text = "PADRÃO";
        }

        private void radAdministracao_CheckedChanged(object sender, EventArgs e)
        {
            txtAcessos.Text = "ADMINISTRAÇÃO";
        }
    }
}
