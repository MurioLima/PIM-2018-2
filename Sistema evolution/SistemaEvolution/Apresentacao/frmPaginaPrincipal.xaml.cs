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

    //Código para iniciar o form principal↓
    public partial class frmPaginaPrincipal : Window
    {
        public frmPaginaPrincipal()
        {
            InitializeComponent();
        }

        //Código para iniciar o form usuarios↓
        private void mniPaginaUsuarios_Click(object sender, RoutedEventArgs e)
        {
            Apresentacao.frmUsuario frmC = new Apresentacao.frmUsuario();
            frmC.ShowDialog();

        }

        //Código para iniciar o form cliente↓
        private void mniPaginaClientes_Click(object sender, RoutedEventArgs e)
        {
            Apresentacao.frmClientes frmC = new Apresentacao.frmClientes();
            frmC.ShowDialog();
        }

        //Código para iniciar o form produtos↓
        private void mniPaginaProdutos_Click(object sender, RoutedEventArgs e)
        {
            Apresentacao.frmProduto frmC = new Apresentacao.frmProduto();
            frmC.ShowDialog();
        }

        //Código para iniciar o form chamados↓
        private void mniPaginaChamados_Click(object sender, RoutedEventArgs e)
        {
            Apresentacao.frmChamado frmC = new Apresentacao.frmChamado();
            frmC.ShowDialog();
        }

        //Código para iniciar o form funcionários↓
        private void mniPaginaFuncionario_Click(object sender, RoutedEventArgs e)
        {
            Apresentacao.frmFuncionario frmC = new Apresentacao.frmFuncionario();
            frmC.ShowDialog();
        }
    }
}
