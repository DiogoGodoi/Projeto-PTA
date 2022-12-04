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
using EstoqueView;
using UsuariosModel;
using HistoricoView;
using Almoxarifado;
using MenuHistoricoView;

namespace MenuView
{
    public partial class frmMenu : Form
    {
        Thread _thred;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            _thred = new Thread(abrirJanelaAdministracao);
            _thred.SetApartmentState(ApartmentState.STA);
            _thred.Start();
        }
        private void btnAlmoxarifado_Click(object sender, EventArgs e)
        {
            _thred = new Thread(abrirJanelaEstoque);
            _thred.SetApartmentState(ApartmentState.STA);
            _thred.Start();
        }
        private void btnHistorico_Click(object sender, EventArgs e)
        {
            _thred = new Thread(abrirJanelaHistorico);
            _thred.SetApartmentState(ApartmentState.STA);
            _thred.Start();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            mdlUsuarios.sair();
            this.Close();
        }
        private void abrirJanelaEstoque()
        {
            Application.Run(new frmEstoque());
        }
        private void abrirJanelaHistorico()
        {
            Application.Run(new TelaHistorico());
        }
        private void abrirJanelaAdministracao()
        {
            Application.Run(new TelaSelecaoAdministracao());
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {

            if(mdlUsuarios.getNivel() == "1")
            {
                btnAdm.Enabled = true;
                btnAlmoxarifado.Enabled = true;
                btnRelatorios.Enabled = true;
                btnHistorico.Enabled = true;
                lblUsuario.Text = mdlUsuarios.getNome();

            }else if (mdlUsuarios.getNivel() == "2")
            {
                btnAdm.Enabled = false;
                btnAdm.BackColor = Color.Red;
                btnAlmoxarifado.Enabled = true;
                btnRelatorios.Enabled = true;

                btnHistorico.Enabled = false;
                btnHistorico.BackColor = Color.Red;
                lblUsuario.Text = mdlUsuarios.getNome();
            }
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            _thred = new Thread(abrirJanelaRelatorios);
            _thred.SetApartmentState(ApartmentState.STA);
            _thred.Start();
        }

        private void abrirJanelaRelatorios()
        {
            Application.Run(new TelaRelatorios());
        }
    }
}
