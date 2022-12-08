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
        private static string acessoDB = @"Server=tcp:dgodoi.database.windows.net,1433;Initial Catalog=dbGaleria;Persist Security Info=False;User ID=Dgodoi;Password=**********;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public static SqlConnection conectar ()
        {
            SqlConnection conexao = new SqlConnection(acessoDB);
            return conexao;
        }
    }
}
