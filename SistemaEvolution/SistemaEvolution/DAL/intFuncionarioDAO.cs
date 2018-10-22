using System;
using SistemaEvolution.Modelo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEvolution.DAL
{
    interface intFuncionarioDAO
    {
        void CadastrarFuncionario(Funcionario funcionario);
        void EditarFuncionario(Funcionario funcionario);
        void ExcluirFuncionario(Funcionario funcionario);
        void PesquisarFuncionario(Funcionario funcionario);
        List<Cliente> PesquisarClientePorNome(Funcionario funcionario);
    }
}
