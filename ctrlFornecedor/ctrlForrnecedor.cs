using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexao;
using FornecedorModel;
using System.Data;
using System.Data.SqlClient;

namespace FornecedorControle
{
    public class ctrlForrnecedor
    {
        private string nomeEmpresa;

        public string getNomeEmpresa()
        {
            return nomeEmpresa;
        }
        public bool Cadastrar (mdlFornecedor _mdlFornecedor)
        {
            Conexao.ConexaoDB.conectar();
            var abrirCONN = ConexaoDB.conectar();

            try
            {
                abrirCONN.Open();

                string query = "INSERT INTO Fornecedor (cnpj, nomeEmpresa, rua, numero, bairro, cidade) VALUES (@cnpj, @nomeEmpresa, @rua, @numero, @bairro, @cidade)";
                SqlCommand comando = new SqlCommand(query, abrirCONN);

                var pmtCnpj = comando.CreateParameter();
                pmtCnpj.ParameterName = "@cnpj";
                pmtCnpj.DbType = DbType.String;
                pmtCnpj.Value = _mdlFornecedor.getCnpj();
                comando.Parameters.Add(pmtCnpj);

                var pmtNomeEmpresa = comando.CreateParameter();
                pmtNomeEmpresa.ParameterName = "@nomeEmpresa";
                pmtNomeEmpresa.DbType = DbType.String;
                pmtNomeEmpresa.Value = _mdlFornecedor.getNomeEmpresa();
                comando.Parameters.Add(pmtNomeEmpresa);

                var pmtEndereco = comando.CreateParameter();
                pmtEndereco.ParameterName = "@rua";
                pmtEndereco.DbType = DbType.String;
                pmtEndereco.Value = _mdlFornecedor.getEndereco();
                comando.Parameters.Add(pmtEndereco);

                var pmtNumero = comando.CreateParameter();
                pmtNumero.ParameterName = "@numero";
                pmtNumero.DbType = DbType.Int32;
                pmtNumero.Value = _mdlFornecedor.getNumero();
                comando.Parameters.Add(pmtNumero);

                var pmtBairro = comando.CreateParameter();
                pmtBairro.ParameterName = "@bairro";
                pmtBairro.DbType = DbType.String;
                pmtBairro.Value = _mdlFornecedor.getBairro();
                comando.Parameters.Add(pmtBairro);

                var pmtCidade = comando.CreateParameter();
                pmtCidade.ParameterName = "@cidade";
                pmtCidade.DbType = DbType.String;
                pmtCidade.Value = _mdlFornecedor.getCidade();
                comando.Parameters.Add(pmtCidade);

                var leitura = comando.ExecuteReader();

                if(leitura.Read() == false)
                {
                    abrirCONN.Close();
                    return true;
                }else
                {
                    abrirCONN.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Erro: " + ex.Message);
            }
            finally
            {
                abrirCONN.Close();
            }
        }

        public bool ProcurarPorCnpj(string cnpj)
        {
            Conexao.ConexaoDB.conectar();
            var abrirCONN = ConexaoDB.conectar();

            try
            {
                abrirCONN.Open();

                string query = "SELECT * FROM Fornecedor WHERE cnpj=@cnpj";
                SqlCommand comando = new SqlCommand(query, abrirCONN);

                comando.Parameters.AddWithValue("@cnpj", cnpj);

                var leitura = comando.ExecuteReader();

                if (leitura.Read())
                {
                    nomeEmpresa = leitura["nomeEmpresa"].ToString();
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
                return false;
                throw new Exception("Erro: " + ex.Message);
            }
            finally
            {
                abrirCONN.Close();
            }
        }

    }
}
