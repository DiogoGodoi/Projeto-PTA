using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaidaControle
{
    public class ctrlMovimentacao
    {
        public string cnpj;
        public string nomeEmpresa;
        public int nf;
        public string nome;
        public string quantidade;
        public string codigo;
        public string operador;
        public static string item;

        public ctrlMovimentacao()
        {

        }
        public ctrlMovimentacao(string pNome, string pQuantidade, string pOperador)
        {
            nome = pNome;
            item = pNome;
            quantidade = pQuantidade;
            operador = pOperador;
        }
        public ctrlMovimentacao(string pCnpj, string pNomeEmpresa, int pNf, string pNome, string pQuantidade, string pOperador)
        {
            cnpj = pCnpj;
            nomeEmpresa = pNomeEmpresa;
            nf = pNf;
            nome = pNome;
            quantidade = pQuantidade;
            operador = pOperador;
            item = pNome;
        }
        
        
    }
}
