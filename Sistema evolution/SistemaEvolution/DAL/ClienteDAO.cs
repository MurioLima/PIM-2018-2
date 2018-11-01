using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaEvolution.Modelo;

namespace SistemaEvolution.DAL
{
    public class ClienteDAO
    {

        //Declaraçao das variaveis 
        EvolutionEntities Cliente = new EvolutionEntities();
        public String mensagem;

        //Codigo para Cadastrar o Cliente
        public void CadastrarCliente(Modelo.Cliente cliente)
            
        {
            this.mensagem="";
            try
            {               
                Cliente.Cliente.Add(cliente);
                Cliente.SaveChanges();
                this.mensagem = "Cliente cadastrado com sucesso";
            }

            catch (EntryPointNotFoundException e)
            {

                this.mensagem = e.ToString();
            }
        }

        //Codigo para Pesquisar o Cliente pelo ID
        public Modelo.Cliente PesquisarCliente(Modelo.Cliente cliente)
        {
            this.mensagem = "";
            return Cliente.Cliente.Find(cliente.Cod_Cliente);

        }

        //Codigo para pesquisar o Cliente pelo nome
        public List<Modelo.Cliente> PesquisarClientePorNome(Modelo.Cliente cliente)
        {
            this.mensagem = "";
            List<Modelo.Cliente> listaCliente = new List<Modelo.Cliente>();
            IQueryable lista = from Cliente in Cliente.Cliente
                               where
                                   Cliente.Nome.Contains(cliente.Nome)
                               select Cliente;
            foreach (Modelo.Cliente p in lista)
            {
                listaCliente.Add(p);
            }
            return listaCliente;


        }

        //Codigo para Excluir o Cliente
        public void ExcluirCliente(Modelo.Cliente cliente)
        {
            this.mensagem = "";
            cliente = Cliente.Cliente.Find(cliente.Cod_Cliente);
            Cliente.Cliente.Remove(cliente);
            Cliente.SaveChanges();
            this.mensagem = "Pessoa excluída com sucesso !!!!!";
        }

        //Codigo para Editar o Cliente
        public void EditarCliente (Modelo.Cliente cliente)
        {
            this.mensagem = "";
            Cliente.Entry(cliente).State = System.Data.EntityState.Modified;
            Cliente.SaveChanges();
            this.mensagem= "Pessoa editada com sucesso !!!!!";


        }



        }




    }
    











    

