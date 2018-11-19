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
        //Declaraçao das variaveis↓
        EvolutionEntities Produto = new EvolutionEntities();
        public String mensagem;

        //Código para cadastrar produto↓
        public void CadastrarProduto(Modelo.Produto produto)
        {
            this.mensagem = "";
            try
            {
                Produto.Produto.Add(produto);
                Produto.SaveChanges();
                this.mensagem = "Produto cadastrado com sucesso";

            }
            catch (Exception e)
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

        //Código para excluir produto↓
        public void ExcluirProduto(Modelo.Produto produto)
        {
            this.mensagem = "";
            produto = Produto.Produto.Find(produto.Cod_Produto);
            Produto.Produto.Remove(produto);
            Produto.SaveChanges();
            this.mensagem = "Produto excluída com sucesso !!!!!";

        }

        //Código para editar produto↓
        public void EditarProduto(Modelo.Produto produto)
        { 
        
            this.mensagem = "";
            Produto.Entry(produto).State = System.Data.EntityState.Modified;
            Produto.SaveChanges();
            this.mensagem = "Produto editada com sucesso !!!!!";

        }
    }
}



