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

        EvolutionEntities Funcionario = new EvolutionEntities();
        public String mensagem;

        public void CadastrarFuncionario(Modelo.Funcionario funcionario)
        {
            this.mensagem = "";
            try
            {
                Funcionario.Funcionario.Add(funcionario);
                Funcionario.SaveChanges();
                this.mensagem = "Funcionário cadastrado com sucesso";
            }

            catch (EntryPointNotFoundException e)
            {

                this.mensagem = e.ToString();
            }

        }


        public Modelo.Funcionario PesquisarFuncionario(Modelo.Funcionario funcionario)
        {
            this.mensagem = "";
            return Funcionario.Funcionario.Find(funcionario.Cod_Funcionario);

        }

        public List<Modelo.Funcionario> PesquisarFuncionarioPorNome(Modelo.Funcionario funcionario)
        {
            this.mensagem = "";
            List<Modelo.Funcionario> listaFuncionario = new List<Modelo.Funcionario>();
            IQueryable lista = from Funcionario in Funcionario.Funcionario
                               where
                                   Funcionario.Nome_Completo.Contains(Funcionario.Nome_Completo)
                               select Funcionario;
            foreach (Modelo.Funcionario p in lista)
            {
                listaFuncionario.Add(p);
            }
            return listaFuncionario;

        }

        public void ExcluirFuncionario(Modelo.Funcionario funcionario)
        {
            this.mensagem = "";
            funcionario = Funcionario.Funcionario.Find(funcionario.Cod_Funcionario);
            Funcionario.Funcionario.Remove(funcionario);
            Funcionario.SaveChanges();
            this.mensagem = "Funcionário excluído com sucesso !!!!!";
        }

        public void EditarFuncionario(Modelo.Funcionario funcionario)
        {
            this.mensagem = "";
            Funcionario.Entry(funcionario).State = System.Data.EntityState.Modified;
            Funcionario.SaveChanges();
            this.mensagem = "Funcionário editado com sucesso !!!!!";
        }
        }

    }




    

