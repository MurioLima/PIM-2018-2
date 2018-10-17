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
    /// Interaction logic for frmClientes.xaml
    /// </summary>
    public partial class frmClientes : Window
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnCadastrarUsuario_Click(object sender, RoutedEventArgs e)
        {
            List<String> ListaCliente = new List<string>();
            ListaCliente.Add(txbCodCliente.Text);
            ListaCliente.Add(txbNome.Text);
            ListaCliente.Add(txbRazaoSocial.Text);
            ListaCliente.Add(txbCpf.Text);
            ListaCliente.Add(txbCnpj.Text);
            ListaCliente.Add(txbEmail_Contato.Text);
            ListaCliente.Add(txbEndereço.Text);          
            ListaCliente.Add(txbTelefone.Text);

            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastrarCliente(ListaCliente);
            MessageBox.Show(controle.mensagem);

            
        }

        private void btnBuscarCliente_Click(object sender, RoutedEventArgs e)
        {
            List<String> ListaCliente = new List<string>();
            ListaCliente.Add(txbEDCodCliente.Text);
            ListaCliente.Add("");
            ListaCliente.Add("");
            ListaCliente.Add("");
            ListaCliente.Add("");
            ListaCliente.Add("");
            ListaCliente.Add("");
            ListaCliente.Add("");
            Modelo.Controle controle = new Modelo.Controle();
            Modelo.Cliente cliente = controle.PesquisarCliente(ListaCliente);
            if (controle.mensagem.Equals(""))
            {

                txbEDCodCliente.Text = cliente.Cod_Cliente;
                txbEDNome.Text = cliente.Nome;
                txbEDRazaoSocial.Text = cliente.Razao_Social;
                txbEDCpf.Text = cliente.CPF;
                txbEDCnpj.Text = cliente.CNPJ;
                txbEDEmail_Contato.Text = cliente.Email_Contato;
                txbEDEndereco.Text = cliente.End_Completo;
                txbEDTelefone.Text = cliente.Telefone;
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

            }




        }
    }

