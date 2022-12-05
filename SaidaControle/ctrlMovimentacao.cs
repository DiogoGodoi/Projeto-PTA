using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaidaControle
{
    public class ctrlMovimentacao
    {
        public string nome;
        public string quantidade;
        public string codigo;
        public string operador;

        public ctrlMovimentacao()
        {

        }
        public ctrlMovimentacao(string pNome, string pQuantidade, string pCodigo, string pOperador)
        {
            nome = pNome;
            quantidade = pQuantidade;
            codigo = pCodigo;
            operador = pOperador;
        }
    }
}
