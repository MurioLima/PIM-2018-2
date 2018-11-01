using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaEvolution.DAL
{
    class Conexao
    {
        SqlConnection conexaoBD;

        public Conexao()
        {
            conexaoBD = new SqlConnection();
            conexaoBD.ConnectionString = @"Data Source=DESKTOP-6PI58CV\SQLEXPRESS;Initial Catalog=Evolution;Integrated Security=True";

        }
        public SqlConnection Conectar()
        {
            if (conexaoBD.State == System.Data.ConnectionState.Closed)
                conexaoBD.Open();
            return conexaoBD;
        }

        public void Desconectar()
        {
            if (conexaoBD.State == System.Data.ConnectionState.Open)
                conexaoBD.Close();
        }
    }
}
