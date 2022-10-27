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
                    if (leitura["nome"].ToString() == nome && leitura["senha"].ToString() == senha && leitura["nivel"].ToString() == "1")
                    {
                        _mdlUsuarios.Autenticar(leitura["nome"].ToString(), leitura["senha"].ToString(), "1");
                        return "administrador";
                    }
                    else if (leitura["nome"].ToString() == nome && leitura["senha"].ToString() == senha && leitura["nivel"].ToString() == "2")
                    {
                        _mdlUsuarios.Autenticar(leitura["nome"].ToString(), leitura["senha"].ToString(), "2");
                        return "almoxarifado";
                    }
                    else if (leitura["nome"].ToString() == nome && leitura["senha"].ToString() == senha && leitura["nivel"].ToString() == "3")
                    {
                        _mdlUsuarios.Autenticar(leitura["nome"].ToString(), leitura["senha"].ToString(), "3");
                        return "epi";
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
            return false;
        }
    }
}
