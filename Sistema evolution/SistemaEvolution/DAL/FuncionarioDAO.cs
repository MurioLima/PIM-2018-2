using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using SistemaEvolution.Modelo;

namespace SistemaEvolution.DAL
{
    public class FuncionarioDAO
    {
        //Chamada do entity ↓
        EvolutionEntities Funcionario = new EvolutionEntities();
        public String mensagem;

        //Código da comunicação do banco de dados para cadastrar o funcionário ↓
        public void CadastrarFuncionario(Modelo.Funcionario funcionario)
        {
            try
            {
                Funcionario.Funcionario.Add(funcionario);
                Funcionario.SaveChanges();
                this.mensagem = "Funcionario cadastrado com sucesso";
            }

            catch (Exception e)
            {

                this.mensagem = "Código do funcionário ja cadastrado,digite outro código.";
            }
        }

        //Código da comunicação do banco de dados para Pesquisar pelo id o funcionário ↓
        public Modelo.Funcionario PesquisarFuncionario(Modelo.Funcionario funcionario)
        {
            this.mensagem = "";
            return Funcionario.Funcionario.Find(funcionario.Cod_Funcionario);

        }

        //Código da comunicação do banco de dados para Pesquisar pelo nome o funcionário ↓
        public List<Modelo.Funcionario> PesquisarFuncionarioPorNome(Modelo.Funcionario funcionario)
        {
            this.mensagem = "";
            List<Modelo.Funcionario> listaFuncionario = new List<Modelo.Funcionario>();
            IQueryable lista = from Funcionario in Funcionario.Funcionario
                               where
                                   Funcionario.Nome_Completo.Contains(funcionario.Nome_Completo)
                               select Funcionario;
            foreach (Modelo.Funcionario p in lista)
            {
                listaFuncionario.Add(p);
            }
            return listaFuncionario; ;

        }

        //Código da comunicação do banco de dados para Excluir o funcionário ↓
        public void ExcluirFuncionario(Modelo.Funcionario funcionario)
        {
            this.mensagem = "";
            funcionario = Funcionario.Funcionario.Find(funcionario.Cod_Funcionario);
            Funcionario.Funcionario.Remove(funcionario);
            Funcionario.SaveChanges();
            this.mensagem = "Funcionário excluído com sucesso !!!!!";
        }

        //Código da comunicação do banco de dados para Editar o funcionário ↓
        public void EditarFuncionario(Modelo.Funcionario funcionario)
        {
            this.mensagem = "";
            Funcionario.Entry(funcionario).State = System.Data.EntityState.Modified;
            Funcionario.SaveChanges();
            this.mensagem = "Funcionário editado com sucesso !!!!!";
        }

    }


}

    

