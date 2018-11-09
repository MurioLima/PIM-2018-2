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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SistemaEvolution;

namespace SistemaEvolution
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, RoutedEventArgs e)
        {
            var login = new Modelo.Login();
            string ID_Usuario;
            string Senha;
            ID_Usuario = txbLogin.Text;
            Senha = txbSenha.Text;
            if (!login.Logon(ID_Usuario, Senha))
            {
                MessageBox.Show("Login ou senha Incorretos");
            }

            Apresentacao.frmPaginaPrincipal frmC = new Apresentacao.frmPaginaPrincipal();
            frmC.ShowDialog();
        }
    }
}
