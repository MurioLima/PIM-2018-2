//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelpDesk.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Produto 
    {
        [System.ComponentModel.DataAnnotations.Key]
        public string Cod_Produto { get; set; }
        public string Desc_Produto { get; set; }
        public string Cod_Cliente { get; set; }

        private static Context db = new Context();

        public List<Produto> GetProdutos(string codCliente)
        
        {
                 return db.Produto.ToList().Where(p => p.Cod_Cliente == codCliente).ToList<Produto>();
        }
      
    }
}
