using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEvolution.Modelo
{
    public class Validacao
    {
        public String mensagem;
        public String Cod_Cliente;
        public String Cod_Produto;
        public String Cod_Funcionario;


        public void ValidarDadosCliente(List<String> ListaCliente)
        {
            this.mensagem = "";
            if (ListaCliente[0].Length > 5)
            this.mensagem = "Codigo com mais de 5 caracteres \n";
            if (ListaCliente[1].Length > 50)
                this.mensagem = "Nome com mais de 30 caracteres \n";
            if (ListaCliente[2].Length > 50)
                this.mensagem = "Razão Social com mais de 50 caracteres \n";
            if (ListaCliente[3].Length > 11)
                this.mensagem = "CPF com mais de 11 caracteres \n";
            if (ListaCliente[4].Length > 12)
                this.mensagem = "CNPJ com mais de 12 caracteres \n";
            if (ListaCliente[5].Length > 50)
                this.mensagem = "E-mail com mais de 50 caracteres \n";
            if (ListaCliente[6].Length > 50)
                this.mensagem = "Endereço com mais de 50 caracteres \n";
            if (ListaCliente[7].Length > 11)
                this.mensagem = "Telefone com mais de 11 caracteres \n";
            
            
            try
            {
                this.Cod_Cliente = (ListaCliente[0]);
            }
            catch (FormatException e)
            {
                this.mensagem += "ID inválido";
            }

        }

        public void ValidarDadosProduto(List<String> ListaProduto)
        {
            this.mensagem = "";
            if (ListaProduto[0].Length > 5)
                this.mensagem = "Codigo com mais de 5 caracteres \n";
            if (ListaProduto[1].Length > 100)
                this.mensagem = "Descriçao com mais de 100 caracteres \n";
            if (ListaProduto[2].Length > 5)
                this.mensagem = "Codigo com mais de 5 caracteres";
            try
            {
                this.Cod_Produto = (ListaProduto[0]);
            }
            catch (FormatException e)
            {
                this.mensagem += "ID invalido";
            }
        }


        public void ValidarDadosFuncionario(List<String> ListaFuncionario)
        {
            this.mensagem = "";
            if (ListaFuncionario[0].Length>5)
                this.mensagem= "Codigo com mais de 5 caracteres \n";
            if (ListaFuncionario[1].Length > 50)
                this.mensagem = "Nome com mais de 50 caracteres \n";
            if (ListaFuncionario[2].Length > 50)
                this.mensagem = "Nome com mais de 50 caracteres \n";
            if (ListaFuncionario[3].Length > 11)
                this.mensagem = "CPF com mais de 11 caracteres \n";
            if (ListaFuncionario[4].Length > 50)
                this.mensagem = "Endereço com mais de 50 caracteres \n";
            if (ListaFuncionario[5].Length > 11)
                this.mensagem = "Telefone com mais de 11 caracteres \n";
            if (ListaFuncionario[6].Length > 50)
                this.mensagem = "E-mail com mais de 50 caracteres \n";
            try
            {
                this.Cod_Funcionario = (ListaFuncionario[0]);
            }
            catch (FormatException e)
            {
                this.mensagem += "ID invalido";
            }

        }

    }
}
