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
                    cliente.Nome = dataReader["Nome"].ToString();
                    cliente.Razao_Social = dataReader["Razao_Social"].ToString();
                    cliente.CPF = dataReader["CPF"].ToString();
                    cliente.CNPJ = dataReader["CNPJ"].ToString();
                    cliente.Email_Contato = dataReader["Email_Contato"].ToString();
                    cliente.End_Completo = dataReader["End_Completo"].ToString();                  
                    cliente.Telefone = dataReader["Telefone"].ToString();

                    
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

        public List<Modelo.Cliente> PesquisarClientePorNome(Modelo.Cliente cliente)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            List<Modelo.Cliente> listaCliente = new List<Modelo.Cliente>();

            cmd.CommandText = @"select * from Cliente
                              where Nome like @Nome";
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome + "%");
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Modelo.Cliente clienteLista = new Modelo.Cliente();
                    clienteLista.Cod_Cliente = dataReader["Cod_Cliente"].ToString();
                    clienteLista.Nome = dataReader["Nome"].ToString();
                    clienteLista.Razao_Social = dataReader["Razao_Social"].ToString();
                    clienteLista.CPF = dataReader["CPF"].ToString();
                    clienteLista.CNPJ = dataReader["CNPJ"].ToString();
                    clienteLista.Email_Contato = dataReader["Email_Contato"].ToString();
                    clienteLista.End_Completo = dataReader["End_Completo"].ToString();
                    clienteLista.Telefone = dataReader["Telefone"].ToString();
                    listaCliente.Add(clienteLista);
                }
                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return listaCliente;



        }

        public void ExcluirCliente(Modelo.Cliente cliente)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from Cliente where Cod_Cliente=@Cod_Cliente";
            cmd.Parameters.AddWithValue("@Cod_Cliente", cliente.Cod_Cliente);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem= "Pessoa excluída com sucesso !!!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }


        public void EditarCliente (Modelo.Cliente cliente)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Cliente
                              set Cod_Cliente=@Cod_Cliente,Nome=@Nome,Razao_Social=@Razao_Social,CPF=@CPF,CNPJ=@CNPJ,Email_Contato=@Email_Contato,End_Completo=@End_Completo,Telefone=@Telefone
                              where Cod_Cliente = @Cod_Cliente";
            cmd.Parameters.AddWithValue("@Cod_Cliente", cliente.Cod_Cliente);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Pessoa editada com sucesso !!!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }



        }




    }
    











    

