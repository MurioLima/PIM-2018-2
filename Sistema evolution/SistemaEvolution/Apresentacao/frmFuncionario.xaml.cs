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
    /// Interaction logic for frmFuncionario.xaml
    /// </summary>
    public partial class frmFuncionario : Window
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

       

        private void btnCadastrarFuncionario_Click_1(object sender, RoutedEventArgs e)
        {
            List<String> ListaFuncionario = new List<string>();
            ListaFuncionario.Add(txbCodFuncionario.Text);
            ListaFuncionario.Add(txbNomeCompleto.Text);
            ListaFuncionario.Add(txbNomeTratamento.Text);
            ListaFuncionario.Add(txbCpf.Text);
            ListaFuncionario.Add(txbEndereço.Text);
            ListaFuncionario.Add(txbTelefone.Text);
            ListaFuncionario.Add(txbEmailContato.Text);
            string stat_Funcionario = "";
            if (rdbStatusFuncionarioAtivo.IsChecked == true) stat_Funcionario = "A";
            if (rdbStatusFuncionarioInativo.IsChecked == true) stat_Funcionario = "I";
            ListaFuncionario.Add(stat_Funcionario);
            ListaFuncionario.Add(txbIdUsuario.Text);

            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastrarFuncionario(ListaFuncionario);
            MessageBox.Show(controle.mensagem);
        }

        private void btnBuscarNome_Click(object sender, RoutedEventArgs e)
        {
            List<String> ListaFuncionario = new List<string>();
            ListaFuncionario.Add("0");
            ListaFuncionario.Add(txbEDNomeCompleto.Text);
            ListaFuncionario.Add("");
            ListaFuncionario.Add("");
            ListaFuncionario.Add("");
            ListaFuncionario.Add("");
            ListaFuncionario.Add("");
            ListaFuncionario.Add("");

            Modelo.Controle controle = new Modelo.Controle();
            controle.PesquisarFuncionarioPorNome(ListaFuncionario);
            Modelo.Funcionario funcionario = new Modelo.Funcionario();
            if (Modelo.atbEstaticos.listaFuncionarioEstatico == null)
            {
                MessageBox.Show("Campo Nome está vazio");
            }
            else
            if (Modelo.atbEstaticos.listaFuncionarioEstatico.Count() == 0)
            {
                MessageBox.Show("Não existe resposta para esta consulta");
            }
            else
            if (Modelo.atbEstaticos.listaFuncionarioEstatico.Count() == 1)
            {
                funcionario = Modelo.atbEstaticos.listaFuncionarioEstatico[0];
                txbEDCodFuncionario.Text = funcionario.Cod_Funcionario;
                txbEDNomeCompleto.Text = funcionario.Nome_Completo;
                txbEDNomeTratamento.Text = funcionario.Nome_Tratamento;
                txbEDCpf.Text = funcionario.CPF;
                txbEDEndereco.Text = funcionario.End_Completo;
                txbEDTelefone.Text = funcionario.Telefone;
                txbEDEmailContato.Text = funcionario.Email_Contato;
                txbEdIdUsuario.Text = funcionario.ID_usuario;
            }
            else
            if (Modelo.atbEstaticos.listaFuncionarioEstatico.Count >= 2)
            {
                frmSelecaoFuncionario frmS = new frmSelecaoFuncionario();
                frmS.ShowDialog();
                txbEDCodFuncionario.Text = Modelo.atbEstaticos.listaFuncionarioEstatico[0].Cod_Funcionario.ToString();
                txbEDNomeCompleto.Text = Modelo.atbEstaticos.listaFuncionarioEstatico[0].Nome_Completo.ToString();
                txbEDNomeTratamento.Text = Modelo.atbEstaticos.listaFuncionarioEstatico[0].Nome_Tratamento.ToString();
                txbEDCpf.Text = Modelo.atbEstaticos.listaFuncionarioEstatico[0].CPF.ToString();
                txbEDEndereco.Text = Modelo.atbEstaticos.listaFuncionarioEstatico[0].End_Completo.ToString();
                txbEDTelefone.Text = Modelo.atbEstaticos.listaFuncionarioEstatico[0].Telefone.ToString();
                txbEDEmailContato.Text = Modelo.atbEstaticos.listaFuncionarioEstatico[0].Email_Contato.ToString();
                txbEdIdUsuario.Text = Modelo.atbEstaticos.listaFuncionarioEstatico[0].ID_usuario.ToString();
            }
        }



        private void btnBuscarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            List<String> ListaFuncionario = new List<string>();
            ListaFuncionario.Add(txbEDCodFuncionario.Text);
            ListaFuncionario.Add("");
            ListaFuncionario.Add("");
            ListaFuncionario.Add("");
            ListaFuncionario.Add("");
            ListaFuncionario.Add("");
            ListaFuncionario.Add("");
            ListaFuncionario.Add("");
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.Funcionario funcionario = controle.PesquisarFuncionario(ListaFuncionario);
            if (controle.mensagem.Equals(""))
            {

                txbEDCodFuncionario.Text = funcionario.Cod_Funcionario;
                txbEDNomeCompleto.Text = funcionario.Nome_Completo;
                txbEDNomeTratamento.Text = funcionario.Nome_Tratamento;
                txbEDCpf.Text = funcionario.CPF;
                txbEDEndereco.Text = funcionario.End_Completo;
                txbEDTelefone.Text = funcionario.Telefone;
                txbEDEmailContato.Text = funcionario.Email_Contato;
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void btnExcluirFuncionario_Click_1(object sender, RoutedEventArgs e)
        {
            String[] dados = { txbEDCodFuncionario.Text, txbEDNomeCompleto.Text, txbEDNomeTratamento.Text, txbEDCpf.Text, txbEDEndereco.Text, txbEDTelefone.Text, txbEDEmailContato.Text };
            List<String> ListaFuncionario = new List<string>(dados);
            Modelo.Controle controle = new Modelo.Controle();
            MessageBoxResult resultado = MessageBox.Show("Deseja realmente excluir ?",
                "Alerta de exclusão", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (resultado == MessageBoxResult.Yes)
            {
                controle.ExcluirFuncionario(ListaFuncionario);
                MessageBox.Show(controle.mensagem);
            }

        }


        private void btnEditarFuncionario_Click_1(object sender, RoutedEventArgs e)
        {
            List<String> ListaFuncionario = new List<string>();
            ListaFuncionario.Add(txbEDCodFuncionario.Text);
            ListaFuncionario.Add(txbEDNomeCompleto.Text);
            ListaFuncionario.Add(txbEDNomeTratamento.Text);
            ListaFuncionario.Add(txbEDCpf.Text);
            ListaFuncionario.Add(txbEDEndereco.Text);
            ListaFuncionario.Add(txbEDTelefone.Text);
            ListaFuncionario.Add(txbEDEmailContato.Text);
            string stat_Funcionario = "";
            if (rdbEDStatusFuncionarioAtivo.IsChecked == true) stat_Funcionario = "A";
            if (rdbEDStatusFuncionarioInativo.IsChecked == true) stat_Funcionario = "I";
            ListaFuncionario.Add(stat_Funcionario);
            ListaFuncionario.Add(txbEdIdUsuario.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.EditarFuncionario(ListaFuncionario);
            MessageBox.Show(controle.mensagem);

        }
    }
}
