using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosModel;
using Conexao;
using System.Data;
using System.Data.SqlClient;

namespace UsuariosControler
{
    public class ctrlUsuarios
    {
        private string nome { get; set; }
        private string senha { get; set; }
        private string nivel { get; set; }
    
        public string getNome()
        {
            return nome;
        }
        public string getSenha()
        {
            return senha;
        }
        public string getNivel()
        {
            return nivel;
        }
        public string logar(string nome, string senha)
        {
            mdlUsuarios _mdlUsuarios = new mdlUsuarios();
            Conexao.ConexaoDB.conectar();
            var abrirConn = ConexaoDB.conectar();

            try
            {
                abrirConn.Open();
                string query = "SELECT nome, senha, nivel FROM Usuarios WHERE nome=@nome AND senha=@senha";
                SqlCommand comando = new SqlCommand(query, abrirConn);

                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@senha", senha);

                var leitura = comando.ExecuteReader();

                while (leitura.Read())
                {
                    if (leitura["nome"].ToString() == nome && leitura["senha"].ToString() == senha && leitura["nivel"].ToString() == "ADMINISTRAÇÃO")
                    {
                        _mdlUsuarios.Autenticar(leitura["nome"].ToString(), leitura["senha"].ToString(), "ADMINISTRAÇÃO");
                        return "ADMINISTRAÇÃO";
                    }
                    else if (leitura["nome"].ToString() == nome && leitura["senha"].ToString() == senha && leitura["nivel"].ToString() == "PADRÃO")
                    {
                        _mdlUsuarios.Autenticar(leitura["nome"].ToString(), leitura["senha"].ToString(), "PADRÃO");
                        return "PADRÃO";
                    }else
                    {
                        return "";
                    }

                }

            }
            catch(Exception ex)
            {

                abrirConn.Close();
                return "";
                throw new Exception("Erro ao autenticar: " + ex.Message);
            }finally
            {
                abrirConn.Close();
            }
            return "";
        }
        public bool Cadastrar(mdlUsuarios _mdlUsuarios)
        {
            Conexao.ConexaoDB.conectar();
            var abrirCONN = ConexaoDB.conectar();

            try
            {
                abrirCONN.Open();
                string query = "INSERT INTO Usuarios (nome, senha, nivel) VALUES (@nome, @senha, @nivel)";
                SqlCommand comando = new SqlCommand(query, abrirCONN);

                var pmtNome = comando.CreateParameter();
                pmtNome.ParameterName = "@nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = mdlUsuarios.getNome();
                comando.Parameters.Add(pmtNome);

                var pmtSenha = comando.CreateParameter();
                pmtSenha.ParameterName = "@senha";
                pmtSenha.DbType = DbType.String;
                pmtSenha.Value = mdlUsuarios.getSenha();
                comando.Parameters.Add(pmtSenha);

                var pmtNivel = comando.CreateParameter();
                pmtNivel.ParameterName = "@nivel";
                pmtNivel.DbType = DbType.String;
                pmtNivel.Value = mdlUsuarios.getNivel();
                comando.Parameters.Add(pmtNivel);

                var leitura = comando.ExecuteReader();

                if (leitura.Read() == false)
                {
                    abrirCONN.Close();
                    return true;
                }else
                {
                    abrirCONN.Close();
                    return false;
                }

            }
            catch(Exception ex)
            {
                abrirCONN.Close();
                return false;
                throw new Exception("Erro ao cadastrar: " + ex.Message);
            }
            finally
            {
                abrirCONN.Close();
            }
        }
        public bool Pesquisar(string pNome)
        {
            Conexao.ConexaoDB.conectar();
            var abrirCONN = ConexaoDB.conectar();

            try
            {
                abrirCONN.Open();
                string query = "SELECT * FROM Usuarios WHERE nome=@nome";
                SqlCommand comando = new SqlCommand(query, abrirCONN);
                comando.Parameters.AddWithValue("@nome",pNome);

                var leitra = comando.ExecuteReader();

                if (leitra.Read() == true)
                {
                    nome = leitra["nome"].ToString();
                    senha = leitra["senha"].ToString();
                    nivel = leitra["nivel"].ToString();
                    abrirCONN.Close();
                    return true;
                }
                else
                {
                    abrirCONN.Close();
                    return false;
                }


            }catch(Exception ex)
            {
                abrirCONN.Close();
                return false;
                throw new Exception("Erro interno: " + ex.Message);
            }
            finally
            {
                abrirCONN.Close();
            }
        }
        public bool Alterar(mdlUsuarios _mdlUsuarios, string user)
        {
            Conexao.ConexaoDB.conectar();
            var abrirCONN = ConexaoDB.conectar();

            try
            {
                abrirCONN.Open();
                string query = "UPDATE Usuarios SET nome = @nome, senha = @senha, nivel = @nivel WHERE nome = @user";
                SqlCommand comando = new SqlCommand(query, abrirCONN);

                var pmtNome = comando.CreateParameter();
                pmtNome.ParameterName = "@nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = mdlUsuarios.getNome();
                comando.Parameters.Add(pmtNome);

                var pmtSenha = comando.CreateParameter();
                pmtSenha.ParameterName = "@senha";
                pmtSenha.DbType = DbType.String;
                pmtSenha.Value = mdlUsuarios.getSenha();
                comando.Parameters.Add(pmtSenha);

                var pmtNivel = comando.CreateParameter();
                pmtNivel.ParameterName = "@nivel";
                pmtNivel.DbType = DbType.String;
                pmtNivel.Value = mdlUsuarios.getNivel();
                comando.Parameters.Add(pmtNivel);

                var pmtUser = comando.CreateParameter();
                pmtUser.ParameterName = "@user";
                pmtUser.DbType = DbType.String;
                pmtUser.Value = user;
                comando.Parameters.Add(pmtUser);

                var leitura = comando.ExecuteReader();

                if(leitura.Read() == true)
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
                throw new Exception("Erro interno: "+ex.Message);
            }
            finally
            {
                abrirCONN.Close();
            }
        }

        public DataTable Exibir()
        {
            Conexao.ConexaoDB.conectar();
            var abrirCONN = ConexaoDB.conectar();

            try
            {
                abrirCONN.Open();

                string query = "SELECT * FROM Usuarios";
                SqlCommand comando = new SqlCommand(query, abrirCONN);
                comando.CommandType = CommandType.Text;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                
                return tabela;
                

            }catch(Exception ex)
            {
                abrirCONN.Close();
                return null;
                throw new Exception("Erro interno: " + ex.Message);
            }
            finally
            {
                abrirCONN.Close();
            }
        }
    }

        
}
