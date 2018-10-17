using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaEvolution.Modelo
{
    public class Controle
    {

        public String mensagem;
        public void CadastrarCliente(List<String> ListaCliente)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosCliente(ListaCliente);
            if (validacao.mensagem.Equals(""))
            {
                Cliente cliente = new Cliente();
                cliente.Cod_Cliente =ListaCliente[0];
                cliente.Nome = ListaCliente[1];
                cliente.Razao_Social = ListaCliente[2];
                cliente.CPF = ListaCliente[3];
                cliente.CNPJ = ListaCliente[4];
                cliente.Email_Contato = ListaCliente[5];
                cliente.End_Completo = ListaCliente[6];
                cliente.Telefone = ListaCliente[7];
                DAL.ClienteDAO ClienteDAO = new DAL.ClienteDAO();
                ClienteDAO.CadastrarCliente(cliente);
                this.mensagem = ClienteDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }



        }


        public Modelo.Cliente PesquisarCliente(List<String> ListaCliente)
        {
            this.mensagem = "";
            Cliente cliente = new Cliente();
            Validacao validacao = new Validacao();
            validacao.ValidarDadosCliente(ListaCliente);
            if (validacao.mensagem.Equals(""))
            {
                cliente.Cod_Cliente = validacao.Cod_Cliente;
                DAL.ClienteDAO ClienteDAO = new DAL.ClienteDAO();
                cliente = ClienteDAO.PesquisarCliente(cliente);
                this.mensagem = ClienteDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
                return cliente;


            }



        }



        //public Modelo.Cliente EditarCliente(Modelo.Cliente cliente)
        //{



        //}


       // public Modelo.Cliente ExcluirCliente(Modelo.Cliente cliente)
        //{



        //}
    }

