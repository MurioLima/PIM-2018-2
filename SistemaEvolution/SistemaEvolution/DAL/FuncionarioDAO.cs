using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SistemaEvolution.DAL
{
    public class FuncionarioDAO
    {
        Conexao conexaoBD = new Conexao();
        SqlDataReader dataReader;
        public String mensagem;

        public void CadastrarFuncionario(Modelo.Funcionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Funcionario
                                (Cod_Funcionario,Nome_Completo,Nome_Tratamento,CPF,End_Completo,Telefone,Email_Contato)
                                 values
                                (@Cod_Funcionario,@Nome_Completo,@Nome_Tratamento,@CPF,@End_Completo,@Telefone,@Email_Contato)";
            cmd.Parameters.AddWithValue("@Cod_Funcionario", funcionario.Cod_Funcionario);
            cmd.Parameters.AddWithValue("@Nome_Completo", funcionario.Nome_Completo);
            cmd.Parameters.AddWithValue("@Nome_Tratamento", funcionario.Nome_Tratamento);
            cmd.Parameters.AddWithValue("@CPF", funcionario.CPF);
            cmd.Parameters.AddWithValue("@End_Completo", funcionario.End_Completo);
            cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
            cmd.Parameters.AddWithValue("@Email_Contato", funcionario.Email_Contato);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Funcionario cadastrado com sucesso !!!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }

        }


        public Modelo.Funcionario PesquisarFuncionario(Modelo.Funcionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select * from Funcionario 
                where Cod_Funcionario = @Cod_Funcionario";
            cmd.Parameters.AddWithValue("@Cod_Funcionario", funcionario.Cod_Funcionario);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    funcionario.Cod_Funcionario = dataReader["Cod_Funcionario"].ToString();
                    funcionario.Nome_Completo = dataReader["Nome_Completo"].ToString();
                    funcionario.Nome_Tratamento= dataReader["Nome_Tratamento"].ToString();
                    funcionario.CPF = dataReader["CPF"].ToString();                   
                    funcionario.End_Completo = dataReader["End_Completo"].ToString();
                    funcionario.Telefone = dataReader["Telefone"].ToString();
                    funcionario.Email_Contato = dataReader["Email_Contato"].ToString();


                }
                else
                {
                    funcionario.Cod_Funcionario= "[1]";
                }
                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return funcionario;

        }

        public List<Modelo.Funcionario> PesquisarFuncionarioPorNome(Modelo.Funcionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            List<Modelo.Funcionario> ListaFuncionario  = new List<Modelo.Funcionario>();

            cmd.CommandText = @"select * from Funcionario
                              where Nome_Completo like @Nome_Completo";
            cmd.Parameters.AddWithValue("@Nome_Completo", funcionario.Nome_Completo + "%");
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Modelo.Funcionario funcionarioLista = new Modelo.Funcionario();
                    funcionarioLista.Cod_Funcionario= dataReader["Cod_Funcionario"].ToString();
                    funcionarioLista.Nome_Completo = dataReader["Nome_Completo"].ToString();
                    funcionarioLista.Nome_Tratamento = dataReader["Nome_Tratamento"].ToString();
                    funcionarioLista.CPF = dataReader["CPF"].ToString();
                    funcionarioLista.End_Completo = dataReader["End_Completo"].ToString();
                    funcionarioLista.Telefone = dataReader["Telefone"].ToString();
                    funcionarioLista.Email_Contato = dataReader["Email_Contato"].ToString();
                    ListaFuncionario.Add(funcionarioLista);
                }
                dataReader.Close();
                conexaoBD.Desconectar();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
            return ListaFuncionario;

        }

        public void ExcluirFuncionario(Modelo.Funcionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"delete from Funcionario where Cod_Funcionario=@Cod_Funcionario";
            cmd.Parameters.AddWithValue("@Cod_Funcionario", funcionario.Cod_Funcionario);
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Pessoa excluída com sucesso !!!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }
        }

        public void EditarFuncionario(Modelo.Funcionario funcionario)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Funcionario
                              set Cod_Funcionario=@Cod_Funcionario,Nome_Completo=@Nome_Completo,Nome_Tratamento=@Nome_Tratamento,CPF=@CPF,End_Completo=@End_Completo,Telefone=@Telefone,Email_Contato=@Email_Contato
                               where Cod_Funcionario = @Cod_Funcionario";
            cmd.Parameters.AddWithValue("Cod_Funcionario", funcionario.Cod_Funcionario);
            cmd.Parameters.AddWithValue("Nome_Completo", funcionario.Nome_Completo);
            cmd.Parameters.AddWithValue("Nome_Tratamento", funcionario.Nome_Tratamento);
            cmd.Parameters.AddWithValue("CPF",funcionario.CPF);
            cmd.Parameters.AddWithValue("End_Completo", funcionario.End_Completo);
            cmd.Parameters.AddWithValue("Telefone", funcionario.Telefone);
            cmd.Parameters.AddWithValue("Email_Contato", funcionario.Email_Contato);
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

    

