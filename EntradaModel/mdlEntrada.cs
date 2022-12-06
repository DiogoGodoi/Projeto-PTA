using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaModel
{
    public class mdlEntrada
    {
        private int numeroDaNf { get; set; }
        private string empresa { get; set; }
        private string item { get; set; }
        private int quantidade { get; set; }
        private string recebedor { get; set; }

        public mdlEntrada(int numeroDaNf, string empresa, string item, int quantidade, string recebedor)
        {
            this.numeroDaNf = numeroDaNf;
            this.empresa = empresa;
            this.item = item;
            this.quantidade = quantidade;
            this.recebedor = recebedor;
        }

        public int getNumeroDaNf()
        {
            return numeroDaNf;
        }
        public string getEmpresa()
        {
            return empresa;
        }
        public string getItem()
        {
            return item;
        }
        public int getQuantidade()
        {
            return quantidade;
        }
        public string getRecebedor()
        {
            return recebedor;
        }
    }
}
