using EstoqueControle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HistoricoControle;
using HistoricoModel;
using System.Data.SqlClient;
using Conexao;
using HistoricoView;
using System.Threading;
using ColaboradoresControle;
using colaboradoreModel;
using UsuariosModel;
using EstoqueView;

namespace Almoxarifado
{
    public partial class frmEstoque : Form
    {
        ctrlEstoque _ctrlEstoque = new ctrlEstoque();
        ctrlHistorico _ctrlHistorico = new ctrlHistorico();
        mdlHistorico _mdlHistorico = new mdlHistorico();
        ctrlColaboradores _ctrlColaboradores = new ctrlColaboradores();
        Thread _thread;
        
        public frmEstoque()
        {
            InitializeComponent();
        }
        private void btnProcurar_Click_1(object sender, EventArgs e)
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
            }   else
                {
                    MessageBox.Show("Digite o nome do item", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch(Exception)
            {
                MessageBox.Show("Erro na pesquisa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEntrada_Click(object sender, EventArgs e)
        {

            _thread = new Thread(TelaEntrada);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }
        private void btnSaida_Click(object sender, EventArgs e)
        {
            
            _thread = new Thread(TelaSaida);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }
        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            _thread = new Thread(TelaDevolucao);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        
        }
        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            ctrlEstoque _ctrlEstoque = new ctrlEstoque();

            grdEstoque.DataSource = _ctrlEstoque.Exibir();
        }
        private void btnEstoqueZerado_Click_1(object sender, EventArgs e)
        {
            ctrlEstoque _ctrlEstoque = new ctrlEstoque();

            grdEstoque.DataSource = _ctrlEstoque.ExibirZerado();
        }
        private void frmEstoque_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Maximized;
            try
            {
            // TODO: esta linha de código carrega dados na tabela 'dbGaleria.Estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter.Fill(this.dbGaleria.Estoque);
            }catch(Exception)
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
            txtProcurar.Text = grdEstoque.SelectedCells[0].Value.ToString();
        }
        public void telaHistorico()
        {
            Application.Run(new TelaHistorico());
        }
        public void TelaSaida()
        {
            Application.Run(new SaidaView());
        }

        public void TelaDevolucao()
        {
            Application.Run(new DevolucaoView());
        }

        public void TelaEntrada()
        {
            Application.Run(new EntradaView());
        }

        private void grdEstoque_CellContentClick(object sender, EventArgs e)
        {
            txtProcurar.Text = grdEstoque.SelectedCells[0].Value.ToString();
        }
    }
}
