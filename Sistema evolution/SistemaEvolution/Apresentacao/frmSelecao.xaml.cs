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

    //Código para inciar o form seleção↓
    public partial class frmSelecao : Window
    {
        public frmSelecao()
        {
            InitializeComponent();
            InicializarDTG();
        }

        //Código para inciar form DTG↓
        public void InicializarDTG()
        {
            dtgSelecao.ItemsSource = Modelo.atbEstaticos.listaClienteEstatico;
        }

        //Código do para fechar o form dtg↓
        private void btnConfirmarSelecao_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Código para selecionar a lista↓
        private void dtgSelecao_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Modelo.atbEstaticos.listaClienteEstatico.Clear();
            Modelo.atbEstaticos.listaClienteEstatico.Add(
                (Modelo.Cliente)dtgSelecao.SelectedItem);

        }
    }
}
