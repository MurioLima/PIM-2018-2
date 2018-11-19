using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEvolution.Modelo;

namespace SistemaEvolution.DAL
{
    public class ChamadoDAO
    {
        //Declaração da variavel↓
        EvolutionEntities Chamados = new EvolutionEntities();
        public String mensagem;




        //Código para pesquisar chamados↓
        public List<Modelo.Chamados> PesquisarChamados(Modelo.Chamados chamados)
        {
            this.mensagem = "";
            List<Modelo.Chamados> listaChamados = new List<Modelo.Chamados>();
            IQueryable lista = from Chamados in Chamados.Chamados
                               where
                                   Chamados.Cod_Chamado.Contains(chamados.Cod_Chamado)
                               select Chamados;
            foreach (Modelo.Chamados p in lista)
            {
                listaChamados.Add(p);
            }
            return listaChamados;

        }


    }


}
