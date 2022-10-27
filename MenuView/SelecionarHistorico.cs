using HistoricoView;
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

namespace MenuView
{
    public partial class frmSelecionarHistorico : Form
    {
        Thread _thread;
        public frmSelecionarHistorico()
        {
            InitializeComponent();
        }

        private void btnHistoricoAlmoxarifado_Click(object sender, EventArgs e)
        {
            this.Close();
            _thread = new Thread(abrirJanelaHistoricoAlmoxarifado);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();    
        }

        private void btnHistoricoEpi_Click(object sender, EventArgs e)
        {

        }

        private void abrirJanelaHistoricoAlmoxarifado()
        {
            Application.Run(new TelaHistorico());
        }
    }
}
