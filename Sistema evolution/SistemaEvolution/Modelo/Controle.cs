using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaEvolution.Modelo
{
    public class Controle
    {


        //Crud cliente ↓

        //Código do Cadastrar cliente ↓
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
                cliente.Stat_Cliente = ListaCliente[8]; 
                DAL.ClienteDAO ClienteDAO = new DAL.ClienteDAO();
                ClienteDAO.CadastrarCliente(cliente);
                this.mensagem = ClienteDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }

        }

        //Código do Pesquisar pelo id cliente ↓
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

        //Código do Pesquisar pelo nome cliente ↓
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

        //Código do Excluir cliente ↓
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

        //Código do Editar cliente ↓
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
                cliente.Stat_Cliente = ListaCliente[8];
                DAL.ClienteDAO clienteDAO = new DAL.ClienteDAO();
                clienteDAO.EditarCliente(cliente);
                this.mensagem = clienteDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }


        //Crud Funcionario ↓ 

        //Código do Cadastrar funcionário ↓ 
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
                funcionario.Stat_Funcionario = ListaFuncionario[7];
                DAL.FuncionarioDAO FuncionarioDAO = new DAL.FuncionarioDAO();
                FuncionarioDAO.CadastrarFuncionario(funcionario);
                this.mensagem = FuncionarioDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }

        }

        //Código do Pesquisar funcionário ↓ 
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


        //Código do Pesquisar funcionário pelo nome ↓ 
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

        //Código do Excluir funcionário ↓ 
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

        //Código do Editar funcionário ↓ 
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
                funcionario.Stat_Funcionario = ListaFuncionario[7];
                DAL.FuncionarioDAO funcionarioDAO = new DAL.FuncionarioDAO();
                funcionarioDAO.EditarFuncionario(funcionario);
                this.mensagem = funcionarioDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        //Crud Produto ↓


        //Código do Cadastrar Produto ↓ 
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


        //Código do Pesquisar Produto ↓ 
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


        //Código do Editar Produto ↓ 
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

        //Código do Excluir Produto ↓ 
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


        //Crud Usuário ↓

        //Código do Cadastrar Usuário ↓ 
        public void CadastrarUsuario(List<String> ListaUsuario)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosUsuario(ListaUsuario);
            if (validacao.mensagem.Equals(""))
            {
                Usuario usuario = new Usuario();
                usuario.ID_usuario = ListaUsuario[0];
                usuario.Senha = ListaUsuario[1];
                usuario.Acesso = ListaUsuario[2];
                DAL.UsuarioDAO UsuarioDAO = new DAL.UsuarioDAO();
                UsuarioDAO.CadastrarUsuario(usuario);
                this.mensagem = UsuarioDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        //Código do Pesquisar Usuário ↓
        public void PesquisarUsuario(List<String> ListaUsuario)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosUsuario(ListaUsuario);
            if (validacao.mensagem.Equals(""))
            {
                DAL.UsuarioDAO UsuarioDAO = new DAL.UsuarioDAO();
                Usuario usuario = new Usuario();
                usuario.ID_usuario = ListaUsuario[0];
                usuario.Senha = ListaUsuario[1];
                atbEstaticos.listaUsuarioEstatico = UsuarioDAO.PesquisarUsuario(usuario);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        //Código do Editar Usuário ↓
        public void EditarUsuario(List<String> ListaUsuario)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosUsuario(ListaUsuario);
            if (validacao.mensagem.Equals(""))
            {
                Usuario usuario = new Usuario();
                usuario.ID_usuario = validacao.ID_usuario;
                usuario.ID_usuario = ListaUsuario[0];
                usuario.Senha = ListaUsuario[1];


                DAL.UsuarioDAO usuarioDAO = new DAL.UsuarioDAO();
                usuarioDAO.EditarUsuario(usuario);
                this.mensagem = usuarioDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }


        }
        //Código do Excluir Usuário ↓
        public void ExcluirUsuario(List<String> ListaUsuario)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosUsuario(ListaUsuario);
            if (validacao.mensagem.Equals(""))
            {
                Usuario usuario = new Usuario();
                usuario.ID_usuario = validacao.ID_usuario;
                DAL.UsuarioDAO usuarioDAO = new DAL.UsuarioDAO();
                if (usuarioDAO.PesquisarUsuario(usuario) != null)
                {
                    usuarioDAO.ExcluirUsuario(usuario);
                    this.mensagem = usuarioDAO.mensagem;
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



        public void CadastrarTipoAtendimento(List<String> ListaTipoAtendimento)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosAtendimento(ListaTipoAtendimento);
            if (validacao.mensagem.Equals(""))
            {
                TipoAtendimento tipoAtendimento = new TipoAtendimento();
                tipoAtendimento.Cod_Atendimento = ListaTipoAtendimento[0];
                tipoAtendimento.Descricao = ListaTipoAtendimento[1];
                tipoAtendimento.Prioridade = ListaTipoAtendimento[2];

                DAL.AtendimentoDAO atendimentoDAO = new DAL.AtendimentoDAO();
                atendimentoDAO.CadastrarTipoAtendimento(tipoAtendimento);
                this.mensagem = atendimentoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

        public void PesquisarChamados(List<String> ListaChamados)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosChamados(ListaChamados);
            if (validacao.mensagem.Equals(""))
            {
                DAL.ChamadoDAO ChamadosDAO = new DAL.ChamadoDAO();
                Chamados chamados = new Chamados();
                chamados.Cod_Chamado = ListaChamados[0];
                chamados.Desc_Chamado = ListaChamados[1];   
                atbEstaticos.listaChamadosEstatico = ChamadosDAO.PesquisarChamados(chamados);
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }




    }
    
}





