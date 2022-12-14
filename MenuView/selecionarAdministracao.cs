using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastrarInsumoView;
using CadastrarUsuarioView;
using CadastrarColaboradorView;
using CadastrarFornecedorView;
using AlterarInsumoView;
using AlterarUsuarioView;

namespace MenuView
{
    public partial class TelaSelecaoAdministracao : Form
    {
        Thread _thread;
        public TelaSelecaoAdministracao()
        {
            InitializeComponent();
        }

        private void btnCadastrarInsumo_Click(object sender, EventArgs e)
        {
            this.Close();
            _thread = new Thread(abrirJanelaCadastrarInsumo);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }
        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            _thread = new Thread(abrirJanelaCadastrarUsuario);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }
        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
            _thread = new Thread(abrirJanelaCadastrarFuncionario);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            this.Close();
            _thread = new Thread(abrirJanelaCadastrarFornecedor);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }

        private void abrirJanelaCadastrarInsumo()
        {
            Application.Run(new TelaCadastroInsumo());
        }

        private void abrirJanelaCadastrarUsuario()
        {
            Application.Run(new frmCadastrarUsuario());
        }

        private void abrirJanelaCadastrarFuncionario()
        {
            Application.Run(new frmCadastrarColaborador());
        }

        private void abrirJanelaCadastrarFornecedor()
        {
            Application.Run(new TelaCadastroFornecedorView());
        }

        private void abrirJanelaAlterarInsumo()
        {
            Application.Run(new TelaAlterarInsumo());
        }

        private void btnAlterarInsumos_Click(object sender, EventArgs e)
        {
            this.Close();
            _thread = new Thread(abrirJanelaAlterarInsumo);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }

        private void TelaSelecaoAdministracao_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnAlterarSenhaUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            _thread = new Thread(abrirJanelaAlterarSenha);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }
        private void abrirJanelaAlterarSenha()
        {
            Application.Run(new TelaAlterarSenha());
        }

    }
}
