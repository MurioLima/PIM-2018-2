//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaEvolution.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoAtendimento
    {
        public TipoAtendimento()
        {
            this.Chamados = new HashSet<Chamados>();
        }
    
        public string Cod_Atendimento { get; set; }
        public string Descricao { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Prioridade { get; set; }
    
        public virtual ICollection<Chamados> Chamados { get; set; }
    }
}