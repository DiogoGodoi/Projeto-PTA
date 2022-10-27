using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexao;
using HistoricoModel;

namespace HistoricoControle
{
    public class ctrlHistorico
    {
        public bool CadastrarHistorico(mdlHistorico _mdlHistorico)
        {
            Conexao.ConexaoDB.conectar();
            var abrirConn = Conexao.ConexaoDB.conectar();

            try
            {
                abrirConn.Open();
                string query = "INSERT INTO historico (item, quantidade, natureza, operador, requisitante) VALUES (@item, @quantidade, @natureza, @operador, @requisitante)";
                SqlCommand comando = new SqlCommand(query, abrirConn);

                var pmtItem = comando.CreateParameter();
                pmtItem.ParameterName = "@item";
                pmtItem.DbType = DbType.String;
                pmtItem.Value = _mdlHistorico.item;
                comando.Parameters.Add(pmtItem);

                var pmtQuantidade = comando.CreateParameter();
                pmtQuantidade.ParameterName = "@quantidade";
                pmtQuantidade.DbType = DbType.Int32;
                pmtQuantidade.Value = _mdlHistorico.quantidade;
                comando.Parameters.Add(pmtQuantidade);

                var pmtNatureza = comando.CreateParameter();
                pmtNatureza.ParameterName = "@natureza";
                pmtNatureza.DbType = DbType.String;
                pmtNatureza.Value = _mdlHistorico.natureza;
                comando.Parameters.Add(pmtNatureza);

                var pmtOperador = comando.CreateParameter();
                pmtOperador.ParameterName = "@operador";
                pmtOperador.DbType = DbType.String;
                pmtOperador.Value = _mdlHistorico.operador;
                comando.Parameters.Add(pmtOperador);

                var pmtRequisitante = comando.CreateParameter();
                pmtRequisitante.ParameterName = "@requisitante";
                pmtRequisitante.DbType = DbType.String;
                pmtRequisitante.Value = _mdlHistorico.requisitante;
                comando.Parameters.Add(pmtRequisitante);

                var leitura = comando.ExecuteReader();

                if(leitura.Read() == false)
                {
                    abrirConn.Close();
                    return true;
                }else
                {
                    abrirConn.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                abrirConn.Close();
                return false;
                throw new Exception("Erro ao cadastrar " + ex.Message);
            }
            finally
            {
                abrirConn.Close();
            }

      
        }
        public DataTable ExibirHistorico()
        {
            Conexao.ConexaoDB.conectar();
            var abrirConn = Conexao.ConexaoDB.conectar();

            try
            {
                abrirConn.Open();
                string query = "SELECT * FROM historico ORDER BY dataModificacao, requisitante ASC";
                SqlCommand comando = new SqlCommand(query, abrirConn);

                comando.CommandType = CommandType.Text;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                return tabela;

            }
            catch (Exception ex)
            {
                abrirConn.Close();
                return null;
                throw new Exception("Erro ao exibir " + ex.Message);
            }finally
            {
                abrirConn.Close();
            }

        }
        public DataTable ExibirSaida()
        {
            Conexao.ConexaoDB.conectar();
            var abrirConn = Conexao.ConexaoDB.conectar();

            try
            {
                abrirConn.Open();
                string query = "SELECT * FROM historico WHERE natureza='Saída' ORDER BY dataModificacao ASC";
                SqlCommand comando = new SqlCommand(query, abrirConn);

                comando.CommandType = CommandType.Text;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                return tabela;

            }
            catch (Exception ex)
            {
                abrirConn.Close();
                return null;
                throw new Exception("Erro ao exibir " + ex.Message);
            }
            finally
            {
                abrirConn.Close();
            }

        }
        public DataTable ExibirEntrada()
        {
            Conexao.ConexaoDB.conectar();
            var abrirConn = Conexao.ConexaoDB.conectar();

            try
            {
                abrirConn.Open();
                string query = "SELECT * FROM historico WHERE natureza='Entrada' ORDER BY dataModificacao ASC";
                SqlCommand comando = new SqlCommand(query, abrirConn);

                comando.CommandType = CommandType.Text;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                return tabela;

            }
            catch (Exception ex)
            {
                abrirConn.Close();
                return null;
                throw new Exception("Erro ao exibir " + ex.Message);
            }
            finally
            {
                abrirConn.Close();
            }

        }
        public DataTable ExibirDevolucao()
        {
            Conexao.ConexaoDB.conectar();
            var abrirConn = Conexao.ConexaoDB.conectar();

            try
            {
                abrirConn.Open();
                string query = "SELECT * FROM historico WHERE natureza='Devolução' ORDER BY dataModificacao ASC";
                SqlCommand comando = new SqlCommand(query, abrirConn);

                comando.CommandType = CommandType.Text;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                return tabela;

            }
            catch (Exception ex)
            {
                abrirConn.Close();
                return null;
                throw new Exception("Erro ao exibir " + ex.Message);
            }
            finally
            {
                abrirConn.Close();
            }

        }
        public DataTable PesquisarEntrada(DateTime data)
        {
            Conexao.ConexaoDB.conectar();
            var abrirConn = Conexao.ConexaoDB.conectar();

            try
            {
                abrirConn.Open();
                string query = "SELECT * FROM historico WHERE dataModificacao =@data AND natureza ='Entrada' ORDER BY dataModificacao ASC";
                SqlCommand comando = new SqlCommand(query, abrirConn);

                comando.Parameters.AddWithValue("@data", data);

                comando.CommandType = CommandType.Text;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                return tabela;

            }
            catch (Exception ex)
            {
                abrirConn.Close();
                return null;
                throw new Exception("Erro ao exibir " + ex.Message);
            }
            finally
            {
                abrirConn.Close();
            }

        }
        public DataTable PesquisarSaida(DateTime data)
        {
            Conexao.ConexaoDB.conectar();
            var abrirConn = Conexao.ConexaoDB.conectar();

            try
            {
                abrirConn.Open();
                string query = "SELECT * FROM historico WHERE dataModificacao =@data AND natureza ='Saida' ORDER BY dataModificacao ASC";
                SqlCommand comando = new SqlCommand(query, abrirConn);

                comando.Parameters.AddWithValue("@data", data);

                comando.CommandType = CommandType.Text;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                return tabela;

            }
            catch (Exception ex)
            {
                abrirConn.Close();
                return null;
                throw new Exception("Erro ao exibir " + ex.Message);
            }
            finally
            {
                abrirConn.Close();
            }

        }
        public DataTable PesquisarDevolucao(DateTime data)
        {
            Conexao.ConexaoDB.conectar();
            var abrirConn = Conexao.ConexaoDB.conectar();

            try
            {
                abrirConn.Open();
                string query = "SELECT * FROM historico WHERE dataModificacao =@data AND natureza ='Devolução' ORDER BY dataModificacao ASC";
                SqlCommand comando = new SqlCommand(query, abrirConn);

                comando.Parameters.AddWithValue("@data", data);

                comando.CommandType = CommandType.Text;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                return tabela;

            }
            catch (Exception ex)
            {
                abrirConn.Close();
                return null;
                throw new Exception("Erro ao exibir " + ex.Message);
            }
            finally
            {
                abrirConn.Close();
            }

        }
    }
}
