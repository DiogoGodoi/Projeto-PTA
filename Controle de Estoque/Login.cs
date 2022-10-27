using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstoqueView;
using System.Threading;
using System.Data.SqlClient;
using UsuariosControler;
using UsuariosModel;
using MenuView;

namespace Controle_de_Estoque
{
    public partial class Login : Form
    {
        mdlUsuarios _mdlUsuarios = new mdlUsuarios();
        ctrlUsuarios _ctrlUsuarios = new ctrlUsuarios();
        Thread _thread;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {

            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;

            string retorno = _ctrlUsuarios.logar(nome.ToUpper(), senha.ToUpper());

            if(retorno == "administrador" | retorno == "almoxarifado" | retorno == "epi")
            {
                this.Close();
                _thread = new Thread(abrirJanela);
                _thread.SetApartmentState(ApartmentState.STA);
                _thread.Start();
            }else
            {
                MessageBox.Show("Usuário não localizado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void abrirJanela(object obj)
        {
            Application.Run(new frmMenu());
        }
    }
}
