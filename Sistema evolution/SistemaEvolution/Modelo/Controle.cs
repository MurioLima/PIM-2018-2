using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaEvolution.Modelo
{
    public class Controle
    {


        // Abaixo Crud cliente
        public String mensagem;
        public void CadastrarCliente(List<String> ListaCliente)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosCliente(ListaCliente);
            if (validacao.mensagem.Equals(""))
            {
                Cliente cliente = new Cliente();
                cliente.Cod_Cliente = ListaCliente[0];
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


        public void PesquisarClientePorNome(List<String> ListaCliente)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosCliente(ListaCliente);
            if (validacao.mensagem.Equals(""))
            {
                DAL.ClienteDAO clienteDAO = new DAL.ClienteDAO();
                Cliente cliente = new Cliente();
                cliente.Nome = ListaCliente[1];
                atbEstaticos.listaClienteEstatico = clienteDAO.PesquisarClientePorNome(cliente);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }


        public void ExcluirCliente(List<String> ListaCliente)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosCliente(ListaCliente);
            if (validacao.mensagem.Equals(""))
            {
                Cliente cliente = new Cliente();
                cliente.Cod_Cliente = validacao.Cod_Cliente;
                DAL.ClienteDAO clienteDAO = new DAL.ClienteDAO();

                if (clienteDAO.PesquisarCliente(cliente).Nome != null)
                {
                    clienteDAO.ExcluirCliente(cliente);
                    this.mensagem = clienteDAO.mensagem;
                }
                else
                {
                    this.mensagem = "Não existe este ID";
                }
            }
        }

        public void EditarCliente(List<String> ListaCliente)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosCliente(ListaCliente);
            if (validacao.mensagem.Equals(""))
            {
                Cliente cliente = new Cliente();
                cliente.Cod_Cliente = validacao.Cod_Cliente;
                cliente.Cod_Cliente = ListaCliente[0];
                cliente.Nome = ListaCliente[1];
                cliente.Razao_Social = ListaCliente[2];
                cliente.CPF = ListaCliente[3];
                cliente.CNPJ = ListaCliente[4];
                cliente.Email_Contato = ListaCliente[5];
                cliente.End_Completo = ListaCliente[6];
                cliente.Telefone = ListaCliente[7];
                DAL.ClienteDAO clienteDAO = new DAL.ClienteDAO();
                clienteDAO.EditarCliente(cliente);
                this.mensagem = clienteDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }


        // Abaixo Crud Funcionario


        public void CadastrarFuncionario(List<String> ListaFuncionario)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosFuncionario(ListaFuncionario);
            if (validacao.mensagem.Equals(""))
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Cod_Funcionario = ListaFuncionario[0];
                funcionario.Nome_Completo = ListaFuncionario[1];
                funcionario.Nome_Tratamento = ListaFuncionario[2];
                funcionario.CPF = ListaFuncionario[3];
                funcionario.End_Completo = ListaFuncionario[4];
                funcionario.Telefone = ListaFuncionario[5];
                funcionario.Email_Contato = ListaFuncionario[6];
                DAL.FuncionarioDAO FuncionarioDAO = new DAL.FuncionarioDAO();
                FuncionarioDAO.CadastrarFuncionario(funcionario);
                this.mensagem = FuncionarioDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }

        }

        public Modelo.Funcionario PesquisarFuncionario(List<String> ListaFuncionario)
        {
            this.mensagem = "";
            Funcionario funcionario = new Funcionario();
            Validacao validacao = new Validacao();
            validacao.ValidarDadosFuncionario(ListaFuncionario);
            if (validacao.mensagem.Equals(""))
            {
                funcionario.Cod_Funcionario = validacao.Cod_Funcionario;
                DAL.FuncionarioDAO FuncionarioDAO = new DAL.FuncionarioDAO();
                funcionario = FuncionarioDAO.PesquisarFuncionario(funcionario);
                this.mensagem = FuncionarioDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
            return funcionario;
        }


    public void PesquisarFuncionarioPorNome(List<String> ListaFuncionario)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosFuncionario(ListaFuncionario);
            if (validacao.mensagem.Equals(""))
            {
                DAL.FuncionarioDAO FuncionarioDAO = new DAL.FuncionarioDAO();
                Funcionario funcionario = new Funcionario();
                funcionario.Nome_Completo = ListaFuncionario[1];
                atbEstaticos.listaFuncionarioEstatico = FuncionarioDAO.PesquisarFuncionarioPorNome(funcionario);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void ExcluirFuncionario(List<String> ListaFuncionario)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosFuncionario(ListaFuncionario);
            if (validacao.mensagem.Equals(""))
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Cod_Funcionario = validacao.Cod_Funcionario;
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                if (funcionarioDAO.PesquisarFuncionario(funcionario).Nome_Completo != null)
                {
                    funcionarioDAO.ExcluirFuncionario(funcionario);
                    this.mensagem = funcionarioDAO.mensagem;
                }
                else
                {
                    this.mensagem = "Não existe este ID";
                }
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void EditarFuncionario(List<String> ListaFuncionario)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosFuncionario(ListaFuncionario);
            if (validacao.mensagem.Equals(""))
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Cod_Funcionario = validacao.Cod_Cliente;
                funcionario.Cod_Funcionario = ListaFuncionario[0];
                funcionario.Nome_Completo = ListaFuncionario[1];
                funcionario.Nome_Tratamento = ListaFuncionario[2];
                funcionario.CPF = ListaFuncionario[3];
                funcionario.End_Completo = ListaFuncionario[4];
                funcionario.Telefone = ListaFuncionario[5];
                funcionario.Email_Contato = ListaFuncionario[6];
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                funcionarioDAO.EditarFuncionario(funcionario);
                this.mensagem = funcionarioDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        //Abaixo Crud Produto

        public void CadastrarProduto(List<String> ListaProduto)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosProduto(ListaProduto);
            if (validacao.mensagem.Equals(""))
            {
                Produto produto = new Produto();
                produto.Cod_Produto = ListaProduto[0];
                produto.Desc_Produto = ListaProduto[1];
                produto.Cod_Cliente = ListaProduto[2];


                DAL.ProdutoDAO ProdutoDAO = new DAL.ProdutoDAO();
                ProdutoDAO.CadastrarProduto(produto);
                this.mensagem = ProdutoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void PesquisarProduto(List<String> ListaProduto)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosProduto(ListaProduto);
            if (validacao.mensagem.Equals(""))
            {
                DAL.ProdutoDAO ProdutoDAO = new DAL.ProdutoDAO();
                Produto produto = new Produto();
                produto.Cod_Produto = ListaProduto[0];
                produto.Cod_Cliente = ListaProduto[2];
                atbEstaticos.listaProdutoEstatico = ProdutoDAO.PesquisarProduto(produto);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }

        }


    public void EditarProduto(List<String> ListaProduto)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosProduto(ListaProduto);
            if (validacao.mensagem.Equals(""))
            {
                Produto produto = new Produto();
                produto.Cod_Produto = validacao.Cod_Produto;
                produto.Cod_Produto = ListaProduto[0];
                produto.Desc_Produto = ListaProduto[1];
                produto.Cod_Cliente = ListaProduto[2];

                DAL.ProdutoDAO produtoDAO = new DAL.ProdutoDAO();
                produtoDAO.EditarProduto(produto);
                this.mensagem = produtoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }


        }


        public void ExcluirProduto(List<String> ListaProduto)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosProduto(ListaProduto);
            if (validacao.mensagem.Equals(""))
            {
                Produto produto= new Produto();
                produto.Cod_Produto = validacao.Cod_Produto;
                DAL.ProdutoDAO produtoDAO = new DAL.ProdutoDAO();
                if (produtoDAO.PesquisarProduto(produto) != null)
                {
                    produtoDAO.ExcluirProduto(produto);
                    this.mensagem = produtoDAO.mensagem;
                }
                else
                {
                    this.mensagem = "Não existe este ID";
                }
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }

        }





    }
    
}





