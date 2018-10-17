using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaEvolution.DAL
{
    public class ClienteDAO
    {
        Conexao conexaoBD = new Conexao();
        SqlDataReader dataReader;
        public String mensagem;

        public void CadastrarCliente(Modelo.Cliente cliente)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Cliente
                (Cod_Cliente,Nome,Razao_Social,CPF,CNPJ,Email_Contato,End_Completo,Telefone)
                values
                (@Cod_Cliente,@Nome,@Razao_Social,@CPF,@CNPJ,@Email_Contato,@End_Completo,@Telefone)";
            cmd.Parameters.AddWithValue("@Cod_Cliente", cliente.Cod_Cliente);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Razao_Social", cliente.Razao_Social);
            cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
            cmd.Parameters.AddWithValue("@CNPJ", cliente.CNPJ);
            cmd.Parameters.AddWithValue("@Email_Contato", cliente.Email_Contato);
            cmd.Parameters.AddWithValue("@End_Completo", cliente.End_Completo);   
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Pessoa cadastrada com sucesso !!!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }


        }


        public Modelo.Cliente PesquisarCliente(Modelo.Cliente cliente)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Cliente 
                where Cod_Cliente = @Cod_Cliente";
            cmd.Parameters.AddWithValue("@Cod_Cliente", cliente.Cod_Cliente);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    cliente.Cod_Cliente = dataReader["Cod_Cliente"].ToString();
                    cliente.Nome = dataReader["Nome_Fantasia"].ToString();
                    cliente.Email_Contato = dataReader["Email"].ToString();
                    cliente.End_Completo = dataReader["End_Completo"].ToString();
                    cliente.CNPJ = dataReader["CNPJ"].ToString();
                    cliente.CPF = dataReader["CPF"].ToString();
                    cliente.Telefone = dataReader["Telefone"].ToString();
                    cliente.Razao_Social = dataReader["Raz_Social"].ToString();
                }
                else
                {
                    cliente.Cod_Cliente = "[1]";
                }
                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return cliente;

        }
        }



        //public Modelo.Cliente EditarCliente(Modelo.Cliente cliente)
       // {



        //}


        //public Modelo.Cliente ExcluirCliente(Modelo.Cliente cliente)
        //{



       // }







    }

