﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEvolution.Modelo;

namespace SistemaEvolution.DAL
{
    public class AtendimentoDAO
    {
        EvolutionEntities TipoAtendimento = new EvolutionEntities();
        public String mensagem;
        public void CadastrarTipoAtendimento(Modelo.TipoAtendimento tipoAtendimento)
        {
            this.mensagem = "";
            try
            {
                TipoAtendimento.TipoAtendimento.Add(tipoAtendimento);
                TipoAtendimento.SaveChanges();
                this.mensagem = "Atendimento cadastrado com sucesso";
            }
            catch (Exception e)
            {

                this.mensagem = "Código do Atendimento ja cadastrado, digite outro código.";
            }
        }
    }
}