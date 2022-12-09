using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosModel
{
    public class mdlUsuarios
    {
        private static string nome { get; set; }
        private static string senha { get; set; }
        public static string nivel { get; set; }

        public string pNome { get; set; }
        public string pSenha { get; set; }
        public string pNivel { get; set; }

        public static string setNome(string paramNome)
        {
            return nome = paramNome;
        }
        public static string setSenha(string paramSenha)
        {
            return senha = paramSenha;
        }
        public static string setNivel(string paramNivel)
        {
            return nivel = paramNivel;
        }
        public static string getNome ()
        {
            return nome;
        }
        public static string getSenha()
        {
            return senha;
        }
        public static string getNivel()
        {
            return nivel;
        }
        public void Autenticar(string paramNome, string paramSenha, string paramNivel)
        {
            nome = paramNome;
            senha = paramSenha;
            nivel = paramNivel; 
        }

        public static void sair()
        {
            nome = "";
            senha = "";
            nivel = "";
        }
    }
}
