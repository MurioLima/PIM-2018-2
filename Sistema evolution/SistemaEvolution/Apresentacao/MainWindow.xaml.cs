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
            string Email_Contato;
            string Senha;
            Email_Contato = txbLogin.Text;
            Senha = txbSenha.Text;

            if (login.Logon(Email_Contato, Senha) == true)
            {
                Apresentacao.frmPaginaPrincipal frmC = new Apresentacao.frmPaginaPrincipal();
                frmC.ShowDialog();
            }
            if (login.Logon(Email_Contato, Senha) == false)
            {
                MessageBox.Show("Login ou Senha incorretos");
            }

            
            }  
            

        }
    }
}