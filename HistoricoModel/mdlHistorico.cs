using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricoModel
{
    public class mdlHistorico
    {
        public string item { get; set; }
        public int quantidade { get; set; }
        public string natureza { get; set; }
        public string operador { get; set; }
        public string requisitante { get; set; }
    }
}
