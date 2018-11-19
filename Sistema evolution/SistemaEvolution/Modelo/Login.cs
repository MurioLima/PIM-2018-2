using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEvolution;

namespace SistemaEvolution.Modelo
{
     public class Login
    {

        //Código do login do usuario↓
        public bool Logon(String Email_Contato, String Senha)
        {
            var db = new EvolutionEntities();
            var senha = db.Usuario.FirstOrDefault(u => u.Senha == Senha);
            var email = db.Funcionario.FirstOrDefault(u => u.Email_Contato==Email_Contato);
            if (senha != null && email != null)
            {
                return true;
            }
            return false;

        }
    }
}
