using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SistemaEvolution.Apresentacao
{

    //Código para iniciar o form↓
    public partial class frmUsuario : Window
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        //Código do botao para chamar o cadastro usuario↓
        private void btnCadastrarUsuario_Click(object sender, RoutedEventArgs e)
        {
            List<String> ListaUsuario = new List<string>();
            ListaUsuario.Add(txbIdUsuario.Text);
            ListaUsuario.Add(txbSenha.Text);
            string Acesso = "";
            if (rdbCliente.IsChecked == true) Acesso = "C";
            if (rdbFuncionario.IsChecked == true) Acesso = "F";
            ListaUsuario.Add(Acesso);


            Modelo.EvolutionEntities acesso = new Modelo.EvolutionEntities();
            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastrarUsuario(ListaUsuario);
            MessageBox.Show(controle.mensagem);
        }

        //Código do botao para chamar o pesquisar usuario↓
        private void btnPesquisarUsuario_Click(object sender, RoutedEventArgs e)
        {
            List<String> ListaUsuario = new List<string>();
            ListaUsuario.Add(txbEDIdUsuario.Text);
            ListaUsuario.Add("");


            Modelo.Controle controle = new Modelo.Controle();
            controle.PesquisarUsuario(ListaUsuario);
            Modelo.Usuario usuario = new Modelo.Usuario();
            if (Modelo.atbEstaticos.listaUsuarioEstatico == null)
            {
                MessageBox.Show("Nome Invalido");
            }
            else
            if (Modelo.atbEstaticos.listaUsuarioEstatico.Count() == 0)
            {
                MessageBox.Show("Não existe resposta para esta consulta");
            }

            else
            if (Modelo.atbEstaticos.listaUsuarioEstatico.Count() == 1)
            {
                usuario=Modelo.atbEstaticos.listaUsuarioEstatico[0];
                txbEDIdUsuario.Text = usuario.ID_usuario;
                txbEDSenha.Text = usuario.Senha;
            }
        }

        //Código do botao para chamar o excluir usuario↓

        private void btnExcluirUsuario_Click(object sender, RoutedEventArgs e)
        {
            String[] dados = { txbEDIdUsuario.Text, txbEDSenha.Text};
            List<String> ListaUsuario = new List<string>(dados);
            Modelo.Controle controle = new Modelo.Controle();
            MessageBoxResult resultado = MessageBox.Show("Deseja realmente excluir ?",
                "Alerta de exclusão", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (resultado == MessageBoxResult.Yes)
            {
                controle.ExcluirUsuario(ListaUsuario);
                MessageBox.Show(controle.mensagem);
            }

        }

        //Código do botao para chamar o editar usuario↓
        private void btnEditarUsuario_Click(object sender, RoutedEventArgs e)
        {
            List<String> ListaUsuario = new List<string>();
            ListaUsuario.Add(txbEDIdUsuario.Text);
            ListaUsuario.Add(txbEDSenha.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.EditarUsuario(ListaUsuario);
            MessageBox.Show(controle.mensagem);

        }
    }   
}
