using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using colaboradoreModel;
using Conexao;

namespace ColaboradoresControle
{
    public class ctrlColaboradores
    {
        private string nome;
        private string setor;
        public string getNome()
        {
            return nome;
        }

        public string getSetor()
        {
            return setor;
        }

        public bool CadastrarColaborador(mdlColaboradores _mdlColaboradores)
        {
            Conexao.ConexaoDB.conectar();
            var abrirCONN = ConexaoDB.conectar();

            try
            {
                abrirCONN.Open();

                string query = "INSERT INTO Colaboradores (cracha, nome, setor) VALUES (@cracha, @nome, @setor)";
                SqlCommand comando = new SqlCommand(query, abrirCONN);

                var pmtCracha = comando.CreateParameter();
                pmtCracha.ParameterName = "@cracha";
                pmtCracha.DbType = DbType.Int32;
                pmtCracha.Value = _mdlColaboradores.getCracha();
                comando.Parameters.Add(pmtCracha);

                var pmtNome = comando.CreateParameter();
                pmtNome.ParameterName = "@nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _mdlColaboradores.getNome();
                comando.Parameters.Add(pmtNome);

                var pmtSetor = comando.CreateParameter();
                pmtSetor.ParameterName = "@setor";
                pmtSetor.DbType = DbType.String;
                pmtSetor.Value = _mdlColaboradores.getSetor();
                comando.Parameters.Add(pmtSetor);

                var leitura = comando.ExecuteReader();

                if (leitura.Read() == false)
                {
                    abrirCONN.Close();
                    return true;
                }
                else
                {
                    abrirCONN.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                abrirCONN.Close();
                return false;
                throw new Exception("Erro no cadastro: " + ex.Message);
            }
            finally
            {
                abrirCONN.Close();
            }

        }
        public bool pesquisarColaborador(int cracha)
        {
            Conexao.ConexaoDB.conectar();
            var abrirConn = Conexao.ConexaoDB.conectar();
            mdlColaboradores _mdlColaboradores = new mdlColaboradores();

            try
            {
                abrirConn.Open();
                string query = "SELECT * FROM colaboradores WHERE cracha =@cracha";
                SqlCommand comando = new SqlCommand(query, abrirConn);
                comando.Parameters.AddWithValue("@cracha", cracha);
                var leitura = comando.ExecuteReader();

                if(leitura.Read())
                {
                    nome = leitura["nome"].ToString();
                    setor = leitura["setor"].ToString();
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
                throw new Exception("Erro ao exibir " + ex.Message);
            }
            finally
            {
                abrirConn.Close();
            }
        }
    }
}
