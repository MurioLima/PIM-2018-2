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

    //Código para iniciar o form produto↓
    public partial class frmProduto : Window
    {
        public frmProduto()
        {
            InitializeComponent();
        }


        //Código do botão para cadastrar produto↓
        private void btnCadastrarProduto_Click(object sender, RoutedEventArgs e)
        {
            List<String> ListaProduto = new List<string>();
            ListaProduto.Add(txbCodProduto.Text);
            ListaProduto.Add(txbDescProduto.Text);
            ListaProduto.Add(txbCodCliente.Text);
            
            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastrarProduto(ListaProduto);
            MessageBox.Show(controle.mensagem);
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        //Código do botão para buscar o produto↓
        private void btnBuscarProduto_Click(object sender, RoutedEventArgs e)
        {
            List<String> ListaProduto = new List<string>();
            ListaProduto.Add(txbEdCodProduto.Text);
            ListaProduto.Add("");
            ListaProduto.Add("");

            Modelo.Controle controle = new Modelo.Controle();
            controle.PesquisarProduto(ListaProduto);
            Modelo.Produto produto = new Modelo.Produto();
            if (Modelo.atbEstaticos.listaProdutoEstatico == null)
            {
                MessageBox.Show("Nome Invalido");
            }
            else
            if (Modelo.atbEstaticos.listaProdutoEstatico.Count() == 0)
            {
                MessageBox.Show("Não existe resposta para esta consulta");
            }

            else
            if (Modelo.atbEstaticos.listaProdutoEstatico.Count() == 1)
            {
                produto = Modelo.atbEstaticos.listaProdutoEstatico[0];
                txbEdCodProduto.Text = produto.Cod_Produto;
                txbEdDescricaoProduto.Text = produto.Desc_Produto;
                txbEDCodCliente.Text = produto.Cod_Cliente;
                
                
            }
        }

        //Código do botão para editar produto↓
        private void btnEditarProduto_Click(object sender, RoutedEventArgs e)
        {
            List<String> ListaProduto = new List<string>();
            ListaProduto.Add(txbEdCodProduto.Text);
            ListaProduto.Add(txbEdDescricaoProduto.Text);
            ListaProduto.Add(txbEDCodCliente.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.EditarProduto(ListaProduto);
            MessageBox.Show(controle.mensagem);
        }

        //Código do botão para excluir produto↓
        private void btnExcluirProduto_Click(object sender, RoutedEventArgs e)
        {
            String[] dados = { txbEdCodProduto.Text,txbEdDescricaoProduto.Text,txbEDCodCliente.Text };
            List<String> ListaProduto= new List<string>(dados);
            Modelo.Controle controle = new Modelo.Controle();
            MessageBoxResult resultado = MessageBox.Show("Deseja realmente excluir ?",
                "Alerta de exclusão", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (resultado == MessageBoxResult.Yes)
            {
                controle.ExcluirProduto(ListaProduto);
                MessageBox.Show(controle.mensagem);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
