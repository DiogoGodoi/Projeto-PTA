using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colaboradoreModel
{
    public class mdlColaboradores
    {
        private string nome { get; set; }
        private int cracha { get; set; }
        private string setor { get; set; }

        public string setNome (string paramNome)
        {
            return nome = paramNome;
        }
        public string getNome()
        {
            return nome;
        }
        public int setCracha(int paramCracha)
        {
            return cracha = paramCracha;
        }
        public int getCracha()
        {
            return cracha;
        }
        public string setSetor(string paramSetor)
        {
            return setor = paramSetor;
        }
        public string getSetor()
        {
            return setor;
        }
    }
}
