using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornecedorModel
{
    public class mdlFornecedor
    {
        private string cnpj { get; set; }
        private string nomeEmpresa { get; set; }
        private string rua { get; set; }
        private int numero { get; set; }
        private string bairro { get; set; }
        private string cidade { get; set; }


        public mdlFornecedor()
        {

        }
        public mdlFornecedor(string pCnpj, string pNomeEmpresa, string pRua, int pNumero, string pBairro, string pCidade)
        {
            cnpj = pCnpj;
            nomeEmpresa = pNomeEmpresa;
            rua = pRua;   
            numero = pNumero;
            bairro = pBairro;
            cidade = pCidade;
        }

        public string getCnpj()
        {
            return cnpj;
        }
        public string getNomeEmpresa()
        {
            return nomeEmpresa;
        }
        public string getEndereco()
        {
            return rua;
        }
        public int getNumero()
        {
            return numero;
        }
        public string getBairro()
        {
            return bairro;
        }
        public string getCidade()
        {
            return cidade;
        }
    }
}
