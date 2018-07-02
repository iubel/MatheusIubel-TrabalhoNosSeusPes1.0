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
using Controlador.Model;
using Controlador.DAO;

namespace WPF
{
    /// <summary>
    /// Lógica interna para CadastrarCliente.xaml
    /// </summary>
    public partial class CadastrarCliente : Window
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void BTN_Limpar(object sender, RoutedEventArgs e)
        {
            TxtNomePessoaFisica.Clear();
            TxtNomePessoaJuridica.Clear();
            TxtCNPJ.Clear();
            TxtCPF.Clear();
            TxtEndereco.Clear();
            TxtRazaoSocial.Clear();
        }

        private void RB_PessoaFisica(object sender, RoutedEventArgs e)
        {
            GridPessoaFisica.Visibility = Visibility.Visible;
            GridPessoaJuridica.Visibility = Visibility.Hidden;
        }

        private void RB_PessoaJuridica(object sender, RoutedEventArgs e)
        {
            GridPessoaJuridica.Visibility = Visibility.Visible;
            GridPessoaFisica.Visibility = Visibility.Hidden;
        }

        private void BTN_Voltar(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }

        private void BTN_SalvarPessoaFisica(object sender, RoutedEventArgs e)
        {
            try
            {
                ClientePessoaFisica clientePessoaFisica = new ClientePessoaFisica();

                
                    clientePessoaFisica.Nome = TxtNomePessoaFisica.Text;
                

                    clientePessoaFisica.CPF = TxtCPF.Text;

                clientePessoaFisica.DataDeNascimento = (DateTime)DataDeNascimento.SelectedDate;
                

                if (ClienteDAO.CadastrarClientePessoaFisica(clientePessoaFisica))
                {
                    MessageBox.Show("Sucesso, cliente cadastrado como pessoa física!");
                }
                else
                {
                    MessageBox.Show("Erro, tente novamente cadastrar o cliente!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os dados do cliente!");
            }

            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }

        private void BTN_SalvarPessoaJuridica(object sender, RoutedEventArgs e)
        {
            try
            {
                ClientePessoaJuridica clientePessoaJuridica = new ClientePessoaJuridica();
                

                    clientePessoaJuridica.Nome = TxtNomePessoaJuridica.Text;
          
                
                    clientePessoaJuridica.RazaoSocial = TxtRazaoSocial.Text;
        
                    clientePessoaJuridica.CNPJ = TxtCNPJ.Text;
                

               
                    clientePessoaJuridica.Endereco = TxtEndereco.Text;
                

                if (ClienteDAO.CadastrarClientePessoaJuridica(clientePessoaJuridica))
                {
                    MessageBox.Show("Sucesso, cliente cadastrado como pessoa jurídica!");
                }
                else
                {
                    MessageBox.Show("Erro, tente novamente cadastrar o cliente!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os dados do cliente!");
            }

            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }
    }
}
