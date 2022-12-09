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

            DataTable retorno = _ctrlUsuario.Pesquisar(nome);

            if (retorno != null)
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
            mdlUsuarios _mdlUsuarios = new mdlUsuarios();

            try
            {
            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            string acessos = txtAcessos.Text;

            _mdlUsuarios.pNome = nome.ToUpper();
            _mdlUsuarios.pSenha = senha.ToUpper();
            _mdlUsuarios.pNivel = acessos.ToUpper();

            if (radAdministracao.Checked == true)
            {
                _mdlUsuarios.pNivel = "ADMINISTRAÇÃO";
            }else if(radAlmoxarifado.Checked == true)
            {
                _mdlUsuarios.pNivel = "PADRÃO";
            }

            bool retorno = _ctrlUsuario.Alterar(_mdlUsuarios, nome);

            if(retorno == true)
            {
                MessageBox.Show("Alterado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = String.Empty;
                txtSenha.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Erro na alteração", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro interno: "+ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtProcurar.Text;
                DataTable retorno = _ctrlUsuario.Pesquisar(nome);

                if (retorno == null)
                {
                    MessageBox.Show("Item não localizado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProcurar.Text = String.Empty;
                    grdUsuarios.DataSource = _ctrlUsuario.Exibir();
                }
                else if (retorno != null && nome != String.Empty)
                {
                    grdUsuarios.DataSource = _ctrlUsuario.Pesquisar(nome);
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
    }
}
