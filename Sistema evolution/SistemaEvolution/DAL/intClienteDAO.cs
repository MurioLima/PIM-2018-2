using System;
using SistemaEvolution.Modelo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEvolution.DAL
{
    interface intClienteDAO
    {
        void CadastrarCliente(Cliente cliente);
        void EditarCliente(Cliente cliente);
        void ExcluirCliente(Cliente cliente);
        void PesquisarCliente(Cliente cliente);
        void PesquisarClientePorNome(Cliente cliente);
        

        
    }
}
