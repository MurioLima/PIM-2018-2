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
<<<<<<< HEAD
            if (login.Logon(ID_Usuario, Senha) == true)
            {
                Apresentacao.frmPaginaPrincipal frmC = new Apresentacao.frmPaginaPrincipal();
                frmC.ShowDialog();
            }
            if (login.Logon(ID_Usuario, Senha) == false)
            {
                MessageBox.Show("Login ou Senha incorretos");
            }

=======
            if (login.Logon(ID_Usuario, Senha) == true) 
            {
                Apresentacao.frmPaginaPrincipal frmC = new Apresentacao.frmPaginaPrincipal();
                frmC.ShowDialog();
            }
            if (login.Logon(ID_Usuario, Senha) == false)
            {
                MessageBox.Show ("Login ou Senha incorretos");
            }  
            
>>>>>>> eb4fcb6a5c9a64f036add94f9c4c9972a5caaf08
        }
    }
}