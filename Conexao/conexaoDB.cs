using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace Conexao
{
    public class ConexaoDB
    {
        private static string acessoDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Almoxarifado.mdf; Integrated Security=SSPI; Connect Timeout=30";
        
        public static SqlConnection conectar ()
        {
            SqlConnection conexao = new SqlConnection(acessoDB);
            return conexao;
        }
    }
}
