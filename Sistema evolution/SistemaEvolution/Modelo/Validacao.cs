﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaEvolution.Modelo;
using SistemaEvolution.Apresentacao;

namespace SistemaEvolution.Modelo
{
    //Declaração das variaveis↓
    public class Validacao
    {
        public String mensagem;
        public String Cod_Cliente;
        public String Cod_Produto;
        public String Cod_Funcionario;
        public String ID_usuario;




        //Código de validação do cliente↓
        public void ValidarDadosCliente(List<String> ListaCliente)
        {
            this.mensagem = "";
            if (ListaCliente[0] == "")
                this.mensagem = "Código do cliente está vazio \n";
            if (ListaCliente[0].Length > 5)
                this.mensagem = "Código com mais de 5 caracteres \n";
            if (ListaCliente[1].Length > 50)
                this.mensagem = "Nome com mais de 30 caracteres \n";
            if (ListaCliente[1] == "")
                this.mensagem = "Nome do cliente está vazio \n";
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

        //Código de validação do produto↓
        public void ValidarDadosProduto(List<String> ListaProduto)
        {
            this.mensagem = "";
            if (ListaProduto[0] == "")
                this.mensagem = "Código do produto está vazio \n";
            if (ListaProduto[0].Length > 5)
                this.mensagem = "Código do produto com mais de 5 caracteres \n";
            if (ListaProduto[1].Length > 100)
                this.mensagem = "Descriçao com mais de 100 caracteres \n";

            if (ListaProduto[2].Length > 5)
                this.mensagem = "Código do cliente com mais de 5 caracteres";
            try
            {
                this.Cod_Produto = (ListaProduto[0]);
            }
            catch (FormatException e)
            {
                this.mensagem += "ID inválido";
            }

        }

        //Código de validação do funcionário↓
        public void ValidarDadosFuncionario(List<String> ListaFuncionario)
        {
            this.mensagem = "";
            if (ListaFuncionario[0] =="")
                this.mensagem = "Código do funcionário está vazio \n";
            if (ListaFuncionario[0].Length>5)
                this.mensagem= "Código com mais de 5 caracteres \n";
            if (ListaFuncionario[1] =="")
                this.mensagem = "Nome do funcionário está vazio \n";
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
                this.mensagem += "ID inválido";
            }
        }

        //Código de validação do usuario↓
        public void ValidarDadosUsuario(List<String> ListaUsuario)
        {
            this.mensagem = "";
            if(ListaUsuario[0].Length>20)
                this.mensagem = "Código com mais de 5 caracteres \n";
            try
            {
                this.ID_usuario = (ListaUsuario[0]);
            }
            catch (FormatException e)
            {
                this.mensagem += "ID inválido";
            }
        }

        //Código de validação do chamado↓
        public void ValidarDadosChamados(List<String> ListaChamados)
        {
            this.mensagem = "";
            if (ListaChamados[0].Length > 8)
                this.mensagem = "Código com mais de 8 caracteres \n";
            try
            {
                this.Cod_Produto = (ListaChamados[0]);
            }
            catch (FormatException e)
            {
                this.mensagem += "ID inválido";
            }
        }

        //Código de validação do atendimento↓
        public void ValidarDadosAtendimento(List<String> ListaTipoAtendimento)
        {
            this.mensagem = "";
            if (ListaTipoAtendimento[0].Length > 8)
                this.mensagem = "Código com mais de 5 caracteres \n";
            if (ListaTipoAtendimento[0]=="")
                this.mensagem = "Código está vazio \n";
            if (ListaTipoAtendimento[2]=="")
                this.mensagem = "Escolha uma prioridade \n";
            try
            {
                this.Cod_Produto = (ListaTipoAtendimento[0]);
            }
            catch (FormatException e)
            {
                this.mensagem += "ID inválido";
            }
        }

    }
    
}
