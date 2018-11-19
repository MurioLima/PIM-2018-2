using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SistemaEvolution.Modelo;

namespace SistemaEvolution.DAL
{
    public class UsuarioDAO
    {
        //Declaraçao das variaveis↓
        EvolutionEntities Usuario = new EvolutionEntities();
        public String mensagem;

        //Código para cadastrar o usuario↓
        public void CadastrarUsuario(Modelo.Usuario usuario)

        {
            try
            {
                Usuario.Usuario.Add(usuario);
                Usuario.SaveChanges();
                this.mensagem = "Usuario cadastrado com sucesso";

            }
            catch (Exception e)
            {

                this.mensagem = "Código do cliente ja cadastrado,digite outro código.";
            }

        }

        
        //Código para pesquisar o usuario pelo ID↓
        public List<Modelo.Usuario> PesquisarUsuario(Modelo.Usuario usuario)
        {
            this.mensagem = "";
            List<Modelo.Usuario> listaUsuario = new List<Modelo.Usuario>();
            IQueryable lista = from Usuario in Usuario.Usuario
                               where
                                   Usuario.ID_usuario.Contains(usuario.ID_usuario)
                               select Usuario;
            foreach (Modelo.Usuario p in lista)
            {
                listaUsuario.Add(p);
            }
            return listaUsuario;

        }

        //Código para excluir o usuario↓
        public void ExcluirUsuario(Modelo.Usuario usuario)
        {
            this.mensagem = "";
            usuario = Usuario.Usuario.Find(usuario.ID_usuario);
            Usuario.Usuario.Remove(usuario);
            Usuario.SaveChanges();
            this.mensagem = "Usuário excluído com sucesso !!!!!";

        }

        //Código para editar o usuario↓
        public void EditarUsuario(Modelo.Usuario usuario)
        {

            this.mensagem = "";
            Usuario.Entry(usuario).State = System.Data.EntityState.Modified;
            Usuario.SaveChanges();
            this.mensagem = "Usuário editado com sucesso !!!!!";

        }

    }
}
