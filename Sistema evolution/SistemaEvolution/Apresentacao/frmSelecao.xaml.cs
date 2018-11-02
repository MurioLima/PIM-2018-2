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
    /// Lógica interna para frmSelecao.xaml
    /// </summary>
    public partial class frmSelecao : Window
    {
        public frmSelecao()
        {
            InitializeComponent();
            InicializarDTG();
        }
        public void InicializarDTG()
        {
            dtgSelecao.ItemsSource = Modelo.atbEstaticos.listaClienteEstatico;
        }

        private void btnConfirmarSelecao_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void dtgSelecao_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Modelo.atbEstaticos.listaClienteEstatico.Clear();
            Modelo.atbEstaticos.listaClienteEstatico.Add(
                (Modelo.Cliente)dtgSelecao.SelectedItem);

        }
    }
}
