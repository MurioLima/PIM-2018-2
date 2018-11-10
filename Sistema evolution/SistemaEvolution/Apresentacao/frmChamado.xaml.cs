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
    /// Interaction logic for frmChamado.xaml
    /// </summary>
    public partial class frmChamado : Window
    {
        public frmChamado()
        {
            InitializeComponent();
        }

        private void btnBuscarChamados_Click(object sender, RoutedEventArgs e)
        {
            List<String> ListaChamados = new List<string>();
            ListaChamados.Add(txbCodigoChamado.Text);
            ListaChamados.Add("");


            Modelo.Controle controle = new Modelo.Controle();
            controle.PesquisarChamados(ListaChamados);
            Modelo.Chamados chamados = new Modelo.Chamados();
            if (Modelo.atbEstaticos.listaChamadosEstatico == null)
            {
                MessageBox.Show("Nome Invalido");
            }
            else
            if (Modelo.atbEstaticos.listaChamadosEstatico.Count() == 0)
            {
                MessageBox.Show("Não existe resposta para esta consulta");
            }

            else
            if (Modelo.atbEstaticos.listaChamadosEstatico.Count() == 1)
            {
                chamados = Modelo.atbEstaticos.listaChamadosEstatico[0];
                txbCodigoChamado.Text = chamados.Cod_Chamado;
                txbDescriçaoChamadoCliente.Text = chamados.Desc_Chamado;
   


            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<String> ListaChamados = new List<string>();
            

            List<String> ListaAtendimento = new List<string>();
            ListaAtendimento.Add(txbCodigoAtendimento.Text);
            ListaAtendimento.Add(txbDescricaoChamadoFuncionario.Text);
            string Prioridade = "";
            if (rdbUrgente.IsChecked == true) Prioridade = "0";
            if (rdbPoucoUrgente.IsChecked == true) Prioridade = "1";
            if (rdbSemiUrgente.IsChecked == true) Prioridade = "2";
            if (rdbNaoUrgente.IsChecked == true) Prioridade = "3";

               
            ListaAtendimento.Add(Prioridade);


            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastrarTipoAtendimento(ListaAtendimento);
            MessageBox.Show(controle.mensagem);

        }
    }
}
