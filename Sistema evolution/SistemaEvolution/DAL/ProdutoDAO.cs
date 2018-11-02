using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEvolution.Modelo;

namespace SistemaEvolution.DAL
{
    public class ProdutoDAO
    {
        EvolutionEntities Produto = new EvolutionEntities();
        public String mensagem;

        public void CadastrarProduto(Modelo.Produto produto)
        {
            this.mensagem = "";
            try
            {
                Produto.Produto.Add(produto);
                Produto.SaveChanges();
                this.mensagem = "Produto cadastrado com sucesso";

            }
            catch (EntryPointNotFoundException e)
            {

                this.mensagem = "Código do produto ja cadastrado, digite outro código.";
            }
        }

        //Codigo para Pesquisar o Produto pelo ID
        public List<Modelo.Produto> PesquisarProduto(Modelo.Produto produto)
        {
            this.mensagem = "";
            List<Modelo.Produto> listaProduto = new List<Modelo.Produto>();
            IQueryable lista = from Produto in Produto.Produto
                               where
                                   Produto.Cod_Produto.Contains(produto.Cod_Produto)
                               select Produto;
            foreach (Modelo.Produto p in lista)
            {
                listaProduto.Add(p);
            }
            return listaProduto;

        }

        public void ExcluirProduto(Modelo.Produto produto)
        {
            this.mensagem = "";
            produto = Produto.Produto.Find(produto.Cod_Produto);
            Produto.Produto.Remove(produto);
            Produto.SaveChanges();
            this.mensagem = "Produto excluída com sucesso !!!!!";




        }

        public void EditarProduto(Modelo.Produto produto)
        { 
        
            this.mensagem = "";
            Produto.Entry(produto).State = System.Data.EntityState.Modified;
            Produto.SaveChanges();
            this.mensagem = "Produto editada com sucesso !!!!!";

        }
    }
}


//        //Codigo para Excluir o Cliente
//        public void ExcluirProduto(Modelo.Produto produto)
//        {
//            this.mensagem = "";
//            produto = Produto.Produto.Find(produto.Cod_Produto);
//            Produto.Cliente.Remove(cliente);
//            Cliente.SaveChanges();
//            this.mensagem = "Pessoa excluída com sucesso !!!!!";
//        }

//        //Codigo para Editar o Cliente
//        public void EditarCliente(Modelo.Cliente cliente)
//        {
//            this.mensagem = "";
//            Cliente.Entry(cliente).State = System.Data.EntityState.Modified;
//            Cliente.SaveChanges();
//            this.mensagem = "Pessoa editada com sucesso !!!!!";
//        }
//    }
//}
