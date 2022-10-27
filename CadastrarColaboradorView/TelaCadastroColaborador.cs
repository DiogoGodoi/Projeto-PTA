using colaboradoreModel;
using ColaboradoresControle;
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

namespace CadastrarColaboradorView
{
    public partial class frmCadastrarColaborador : Form
    {
        mdlColaboradores _mdlColaboradores = new mdlColaboradores();
        ctrlColaboradores _ctrlColaboradores = new ctrlColaboradores();
        public frmCadastrarColaborador()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
    
                try
                {
                    string nome = txtNome.Text;
                    int cracha = Convert.ToInt32(txtCracha.Text);
                    string setor;

                    if (radAcabamentoFinal.Checked == true)
                    {
                        setor = "ACABAMENTO FINAL";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radAcabamentoGeral.Checked == true)
                    {
                        setor = "ACABAMENTO GERAL";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radAlmoxarifado.Checked == true)
                    {
                        setor = "ALMOXARIFADO";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radComercial.Checked == true)
                    {
                        setor = "COMERCIAL";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radEstampariaColher.Checked == true)
                    {
                        setor = "ESTAMPARIA DE COLHER";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radExpedicao.Checked == true)
                    {
                        setor = "EXPEDIÇÃO";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radFinanceiro.Checked == true)
                    {
                        setor = "FINANCEIRO";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radFiscal.Checked == true)
                    {
                        setor = "FISCAL";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radForjaria.Checked == true)
                    {
                        setor = "FORJARIA";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radHigiene.Checked == true)
                    {
                        setor = "HIGIENE";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radLaminacao.Checked == true)
                    {
                        setor = "LAMINAÇÃO";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radLogistica.Checked == true)
                    {
                        setor = "LOGISTICA";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radManutencao.Checked == true)
                    {
                        setor = "MANUTENÇÃO";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radOxicorte.Checked == true)
                    {
                        setor = "OXICORTE";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radPcm.Checked == true)
                    {
                        setor = "PCM";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radProducao.Checked == true)
                    {
                        setor = "PRODUÇÃO";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radQualidade.Checked == true)
                    {
                        setor = "QUALIDADE";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radRecursosHumanos.Checked == true)
                    {
                        setor = "RECURSOS HUMANOS";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radSegTrabalho.Checked == true)
                    {
                        setor = "SEGURANÇA DO TRABALHO";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radSolda.Checked == true)
                    {
                        setor = "SOLDA";
                        _mdlColaboradores.setSetor(setor);
                    }
                    else if (radTI.Checked == true)
                    {
                        setor = "TI";
                        _mdlColaboradores.setSetor(setor);
                    }

                    _mdlColaboradores.setCracha(cracha);
                    _mdlColaboradores.setNome(nome.ToUpper());
            
                    var retorno = _ctrlColaboradores.CadastrarColaborador(_mdlColaboradores);

                    if (nome.Length <= 50)
                    {
                        _ctrlColaboradores.CadastrarColaborador(_mdlColaboradores);
                        if (retorno == true)
                        {
                            txtNome.Text = String.Empty;
                            txtCracha.Text = String.Empty;
                            txtNome.Focus();
                            MessageBox.Show("Cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Erro no cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (nome.Length > 50)
                    {
                        MessageBox.Show("Nome muito longo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (nome == "")
                    {
                        MessageBox.Show("Nome em branco", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            }
                catch (Exception)
                {
                    MessageBox.Show("Verifique se os dados foram preenchidos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }

