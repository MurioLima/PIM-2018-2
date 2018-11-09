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
        public bool Logon(String ID_Usuario, String Senha)
        {
            var db = new EvolutionEntities();
            var usuario = db.Usuario.FirstOrDefault(u => u.ID_usuario == ID_Usuario && u.Senha == Senha);
            if (usuario != null)
            {
                return true;
            }
            return false;

        }
    }
}
