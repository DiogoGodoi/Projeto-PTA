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
        private string item;

        public string getItem()
        {
            return item;
        }

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
                string query = "SELECT * FROM historico ORDER BY dataModificacao ASC";
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
        public DataTable ExibirMinimo()
        {

            Conexao.ConexaoDB.conectar();
            var abrirConn = Conexao.ConexaoDB.conectar();

            try
            {
                abrirConn.Open();
                string query = "SELECT nome, quantidade, estoqueMin FROM Estoque WHERE quantidade<=estoqueMin ORDER BY nome ASC";
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
                throw new Exception("Erro interno ao acesso a base " + ex.Message);
            }
            finally
            {
                abrirConn.Close();
            }

        }
        public DataTable PesquisarTudo(DateTime data)
        {
            Conexao.ConexaoDB.conectar();
            var abrirConn = Conexao.ConexaoDB.conectar();

            try
            {
                abrirConn.Open();
                string query = "SELECT * FROM historico WHERE dataModificacao =@data ORDER BY natureza, requisitante DSC";
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
                string query = "SELECT * FROM historico WHERE dataModificacao =@data AND natureza ='Saída' ORDER BY dataModificacao ASC";
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
        public DataTable PesquisarTudoPorNome(string requisitante)
        {
            Conexao.ConexaoDB.conectar();
            var abrirConn = Conexao.ConexaoDB.conectar();

            try
            {
                abrirConn.Open();
                string query = "SELECT * FROM historico WHERE requisitante=@requisitante ORDER BY dataModificacao, natureza DSC";
                SqlCommand comando = new SqlCommand(query, abrirConn);

                comando.Parameters.AddWithValue("@requisitante", requisitante);

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
        public DataTable PesquisarEntradaPorNome(string requisitante)
        {
            Conexao.ConexaoDB.conectar();
            var abrirConn = Conexao.ConexaoDB.conectar();

            try
            {
                abrirConn.Open();
                string query = "SELECT * FROM historico WHERE requisitante=@requisitante AND natureza='Entrada' ORDER BY dataModificacao ASC";
                SqlCommand comando = new SqlCommand(query, abrirConn);

                comando.Parameters.AddWithValue("@requisitante", requisitante);

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
        public DataTable PesquisarSaidaPorNome(string requisitante)
        {
            Conexao.ConexaoDB.conectar();
            var abrirConn = Conexao.ConexaoDB.conectar();

            try
            {
                abrirConn.Open();
                string query = "SELECT * FROM historico WHERE requisitante=@requisitante AND natureza='Saída' ORDER BY dataModificacao ASC";
                SqlCommand comando = new SqlCommand(query, abrirConn);

                comando.Parameters.AddWithValue("@requisitante", requisitante);

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
        public DataTable PesquisarDevolucaoPorNome(string requisitante)
        {
            Conexao.ConexaoDB.conectar();
            var abrirConn = Conexao.ConexaoDB.conectar();

            try
            {
                abrirConn.Open();
                string query = "SELECT * FROM historico WHERE requisitante=@requisitante AND natureza='Devolução' ORDER BY dataModificacao ASC";
                SqlCommand comando = new SqlCommand(query, abrirConn);

                comando.Parameters.AddWithValue("@requisitante", requisitante);

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
        public bool PesquisarPorCodigo(int codigo)
        {
            Conexao.ConexaoDB.conectar();
            var abrirConn = Conexao.ConexaoDB.conectar();
            try
            {
                abrirConn.Open();
                string query = "SELECT nome, unidade, quantidade, codigo, estoqueMin FROM Estoque WHERE codigo LIKE @codigo";
                SqlCommand comando = new SqlCommand(query, abrirConn);

                comando.Parameters.AddWithValue("@codigo", codigo + "%");

                comando.CommandType = CommandType.Text;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);

                var leitura = comando.ExecuteReader();

                if (leitura.Read() == true)
                {
                    item = leitura["nome"].ToString();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                abrirConn.Close();
                return false;
                throw new Exception("Erro ao acesso a base " + ex.Message);
            }
            finally
            {
                abrirConn.Close();
            }
        }
        public DataTable PesquisarPorItemNatureza(string item, string natureza)
        {
            Conexao.ConexaoDB.conectar();
            var abrirConn = Conexao.ConexaoDB.conectar();

            try
            {
                abrirConn.Open();
                string query = "SELECT * FROM historico WHERE item=@item AND natureza=@natureza ORDER BY dataModificacao ASC";
                SqlCommand comando = new SqlCommand(query, abrirConn);

                comando.Parameters.AddWithValue("@item", item);
                comando.Parameters.AddWithValue("@natureza", natureza);

                comando.CommandType = CommandType.Text;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);

                comando.ExecuteReader();

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
        public DataTable PesquisarPorItem(string item)
        {
            Conexao.ConexaoDB.conectar();
            var abrirConn = Conexao.ConexaoDB.conectar();

            try
            {
                abrirConn.Open();
                string query = "SELECT * FROM historico WHERE item=@item ORDER BY dataModificacao ASC";
                SqlCommand comando = new SqlCommand(query, abrirConn);

                comando.Parameters.AddWithValue("@item", item);

                comando.CommandType = CommandType.Text;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);

                comando.ExecuteReader();

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
