﻿using System;
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
        //Exibição do form Cliente.
        public frmClientes()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        //Abaixo Codigo do botão Cadastrar cliente.
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
            string Stat_Cliente = "";
                if (rdbStatusClienteAtivo.IsChecked == true) Stat_Cliente = "A";
                if (rdbStatusClienteInativo.IsChecked == true) Stat_Cliente = "I";
            ListaCliente.Add(Stat_Cliente);
            ListaCliente.Add(txbIdUsuario.Text);
            

            Modelo.EvolutionEntities status = new Modelo.EvolutionEntities();
            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastrarCliente(ListaCliente);
            MessageBox.Show(controle.mensagem);
        }

        //Abaixo Codigo do botão Buscar pelo Id cliente.
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
                txbEdIdUsuario.Text = cliente.ID_usuario;
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

        }

        //Abaixo Codigo do botão Buscar pelo Nome cliente.
        private void btnBuscarNome_Click(object sender, RoutedEventArgs e)
        {
            List<String> ListaCliente = new List<string>();
            ListaCliente.Add("0");
            ListaCliente.Add(txbEDNome.Text);
            ListaCliente.Add("");
            ListaCliente.Add("");
            ListaCliente.Add("");
            ListaCliente.Add("");
            ListaCliente.Add("");
            ListaCliente.Add("");
            ListaCliente.Add("");
            Modelo.Controle controle = new Modelo.Controle();
            controle.PesquisarClientePorNome(ListaCliente);
            Modelo.Cliente cliente = new Modelo.Cliente();
            if(Modelo.atbEstaticos.listaClienteEstatico==null)
            {
                MessageBox.Show("Campo Nome está vazio");
            }
            else
            if (Modelo.atbEstaticos.listaClienteEstatico.Count() ==0)
            {
                MessageBox.Show("Não existe resposta para esta consulta");
            }
            else
            if (Modelo.atbEstaticos.listaClienteEstatico.Count() == 1)
            {
                cliente = Modelo.atbEstaticos.listaClienteEstatico[0];
                txbEDCodCliente.Text = cliente.Cod_Cliente;
                txbEDNome.Text = cliente.Nome;
                txbEDRazaoSocial.Text = cliente.Razao_Social;
                txbEDCpf.Text = cliente.CPF;
                txbEDCnpj.Text = cliente.CNPJ;
                txbEDEmail_Contato.Text = cliente.Email_Contato;
                txbEDEndereco.Text = cliente.End_Completo;
                txbEDTelefone.Text = cliente.Telefone;
                txbEdIdUsuario.Text = cliente.ID_usuario;
            }
            else
            if (Modelo.atbEstaticos.listaClienteEstatico.Count >= 2)
            {
                frmSelecao frmS = new frmSelecao();
                frmS.ShowDialog();
                txbEDCodCliente.Text = Modelo.atbEstaticos.listaClienteEstatico[0].Cod_Cliente.ToString();
                txbEDNome.Text = Modelo.atbEstaticos.listaClienteEstatico[0].Nome.ToString();
                txbEDRazaoSocial.Text = Modelo.atbEstaticos.listaClienteEstatico[0].Razao_Social.ToString();
                txbEDCpf.Text = Modelo.atbEstaticos.listaClienteEstatico[0].CPF.ToString();
                txbEDCnpj.Text = Modelo.atbEstaticos.listaClienteEstatico[0].CNPJ.ToString();
                txbEDEmail_Contato.Text = Modelo.atbEstaticos.listaClienteEstatico[0].Email_Contato.ToString();
                txbEDEndereco.Text = Modelo.atbEstaticos.listaClienteEstatico[0].End_Completo.ToString();
                txbEDTelefone.Text = Modelo.atbEstaticos.listaClienteEstatico[0].Telefone.ToString();
                txbEdIdUsuario.Text = Modelo.atbEstaticos.listaClienteEstatico[0].ID_usuario.ToString();
            }
        }

        //Abaixo Codigo do botão Excluir cliente.
        private void btnExcluirCliente_Click(object sender, RoutedEventArgs e)
        {
            String[] dados = { txbEDCodCliente.Text, txbEDNome.Text, txbEDRazaoSocial.Text, txbEDCpf.Text, txbEDCnpj.Text, txbEDEmail_Contato.Text, txbEDEndereco.Text, txbEDTelefone.Text };
            List<String> ListaCliente = new List<string>(dados);
            Modelo.Controle controle = new Modelo.Controle();
            MessageBoxResult resultado = MessageBox.Show("Deseja realmente excluir ?",
                "Alerta de exclusão", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (resultado == MessageBoxResult.Yes)
            {
                controle.ExcluirCliente(ListaCliente);
                MessageBox.Show(controle.mensagem);
            }
        }

        //Abaixo Codigo do botão Editar cliente.
        private void btnEditarUsuario_Click(object sender, RoutedEventArgs e)
        {
            List<String> ListaCliente = new List<string>();
            ListaCliente.Add(txbEDCodCliente.Text);
            ListaCliente.Add(txbEDNome.Text);
            ListaCliente.Add(txbEDRazaoSocial.Text);
            ListaCliente.Add(txbEDCpf.Text);
            ListaCliente.Add(txbEDCnpj.Text);
            ListaCliente.Add(txbEDEmail_Contato.Text);
            ListaCliente.Add(txbEDEndereco.Text);
            ListaCliente.Add(txbEDTelefone.Text);
            string Stat_Cliente = "";
            if (rdbEDStatusClienteAtivo.IsChecked == true) Stat_Cliente = "A";
            if (rdbEDStatusFuncionarioInativo.IsChecked == true) Stat_Cliente = "I";
            ListaCliente.Add(Stat_Cliente);
            ListaCliente.Add(txbEdIdUsuario.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.EditarCliente(ListaCliente);
            MessageBox.Show(controle.mensagem);
            Modelo.EvolutionEntities status = new Modelo.EvolutionEntities();
        }

        private void rdbStatusClienteInativo_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
    }

