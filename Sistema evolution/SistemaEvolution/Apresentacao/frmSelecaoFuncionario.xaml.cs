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
    /// <summary>
    /// Lógica interna para frmSelecaoFuncionario.xaml
    /// </summary>
    public partial class frmSelecaoFuncionario : Window
    {
        public frmSelecaoFuncionario()
        {
            InitializeComponent();
        }
        public void InicializarDTG()
        {
            dtgSelecaoFuncionario.ItemsSource = Modelo.atbEstaticos.listaFuncionarioEstatico;
        }

        private void dtgSelecaoFuncionario_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Modelo.atbEstaticos.listaFuncionarioEstatico.Clear();
            Modelo.atbEstaticos.listaFuncionarioEstatico.Add(
                (Modelo.Funcionario)dtgSelecaoFuncionario.SelectedItem);
        }
    }
}
