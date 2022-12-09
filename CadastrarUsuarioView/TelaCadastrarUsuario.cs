using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuariosControler;
using UsuariosModel;

namespace CadastrarUsuarioView
{
    public partial class frmCadastrarUsuario : Form
    {
        ctrlUsuarios _ctrlUsuarios = new ctrlUsuarios();
        mdlUsuarios _mdlUsuarios = new mdlUsuarios();
        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
                try
                {
                    string nome = txtNome.Text;
                    string senha = txtSenha.Text;
                    string nivel;

                    if (radAdministracao.Checked == true)
                    {
                        nivel = "ADMINISTRAÇÃO";
                        mdlUsuarios.setNivel(nivel);
                    }
                    else if (radAlmoxarifado.Checked == true)
                    {
                        nivel = "PADRÃO";
                        mdlUsuarios.setNivel(nivel);
                    }
                    
                    mdlUsuarios.setNome(nome.ToUpper());
                    mdlUsuarios.setSenha(senha.ToUpper());

                    var retorno = _ctrlUsuarios.Cadastrar(_mdlUsuarios);

                    if (nome.Length <= 10 && senha.Length <= 8)
                    {
                        _ctrlUsuarios.Cadastrar(_mdlUsuarios);
                        if (retorno == true)
                        {
                            txtNome.Text = String.Empty;
                            txtSenha.Text = String.Empty;
                            txtNome.Focus();
                            MessageBox.Show("Cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Erro no cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (nome.Length > 10)
                    {
                        MessageBox.Show("Nome muito longo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique se os dados foram preenchidos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
