﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntradaModel;
using System.Data;
using System.Data.SqlClient;
using Conexao;

namespace EntradaControle
{
    public class ctrlEntrada
    {
        public bool Cadastrar(mdlEntrada _mdlEntrada)
        {
        Conexao.ConexaoDB.conectar();
        var abrirConn = Conexao.ConexaoDB.conectar();
        
        try
            {
                abrirConn.Open();
                string query = "INSERT INTO Entrada (numeroDaNf, empresa, item, quantidade, recebedor) VALUES (@numeroDaNf, @empresa, @item, @quantidade, @recebedor)";
                SqlCommand comando = new SqlCommand(query, abrirConn);

                var pmtNumeroDaNf = comando.CreateParameter();
                pmtNumeroDaNf.ParameterName = "@numeroDaNf";
                pmtNumeroDaNf.DbType = DbType.Int32;
                pmtNumeroDaNf.Value = _mdlEntrada.getNumeroDaNf();
                comando.Parameters.Add(pmtNumeroDaNf);

                var pmtEmpresa = comando.CreateParameter();
                pmtEmpresa.ParameterName = "@empresa";
                pmtEmpresa.DbType = DbType.String;
                pmtEmpresa.Value = _mdlEntrada.getEmpresa();
                comando.Parameters.Add(pmtEmpresa);

                var pmtItem = comando.CreateParameter();
                pmtItem.ParameterName = "@item";
                pmtItem.DbType = DbType.String;
                pmtItem.Value = _mdlEntrada.getItem();
                comando.Parameters.Add(pmtItem);

                var pmtQuantidade = comando.CreateParameter();
                pmtQuantidade.ParameterName = "@quantidade";
                pmtQuantidade.DbType = DbType.Int32;
                pmtQuantidade.Value = _mdlEntrada.getQuantidade();
                comando.Parameters.Add(pmtQuantidade);

                var pmtRecebedor = comando.CreateParameter();
                pmtRecebedor.ParameterName = "@recebedor";
                pmtRecebedor.DbType = DbType.String;
                pmtRecebedor.Value = _mdlEntrada.getRecebedor();
                comando.Parameters.Add(pmtRecebedor);

                var leitura = comando.ExecuteReader();

                if (leitura.Read() == false)
                {
                    abrirConn.Close();
                    return true;
                }
                else
                {
                    abrirConn.Close();
                    return false;
                }
            }
            catch(Exception ex)
            {
                abrirConn.Close();
                throw new Exception("Erro: " + ex.Message);
            }
            finally
            {
                abrirConn.Close();
            }

        }
    }
}