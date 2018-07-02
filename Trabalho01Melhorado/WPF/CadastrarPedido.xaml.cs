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
using Controlador.DAO;
using Controlador.Model;

namespace WPF
{
    /// <summary>
    /// Lógica interna para CadastrarPedido.xaml
    /// </summary>
    public partial class CadastrarPedido : Window
    {
        public CadastrarPedido()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var query =
            from cliente in ClienteDAO.RetornarListaClientePessoaJuridica()
            where cliente.ClienteId != 0
            orderby cliente.Nome
            select new { cliente.Nome };

            cboClientesPessoaJuridica.ItemsSource = query.ToList();

            var queryy =
            from sapato in SapatoDAO.RetornarLista()
            where sapato.Modelo != ""
            orderby sapato.Modelo
            select new { sapato.Modelo };

            cboModelos.ItemsSource = queryy.ToList();

            var queryyy =
            from cliente in ClienteDAO.RetornarListaPessoaFisica()
            where cliente.ClienteId != 0
            orderby cliente.Nome
            select new { cliente.Nome };

            cboClientesPessoaFisica.ItemsSource = queryyy.ToList();

        }

        private void BTN_Limpar(object sender, RoutedEventArgs e)
        {
            txtPrecoTT.Clear();
            txtPrecoUN.Clear();
        }

        private void BTN_Voltar(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }

        private void Click_PessoaJuridica(object sender, RoutedEventArgs e)
        {
            GRID_PessoaJuridica.Visibility = Visibility.Visible;
            GRID_PessoaFisica.Visibility = Visibility.Hidden;
        }

        private void Click_PessoaFisica(object sender, RoutedEventArgs e)
        {
            GRID_PessoaJuridica.Visibility = Visibility.Hidden;
            GRID_PessoaFisica.Visibility = Visibility.Visible;
        }

        private void BTN_SalvarPedidoParaPessoaFisica(object sender, RoutedEventArgs e)
        {
            try
            {
                int idCliente = (Int32)cboClientesPessoaFisica.SelectedValue;
                ClientePessoaFisica clientePessoaFisica = ClienteDAO.BuscarClientePessoaFisicaPorId(idCliente);
                int idModelo = (Int32)cboModelos.SelectedValue;
                Sapato sapato = SapatoDAO.BuscarSapatoPorId(idModelo);
                Pedido pedido = new Pedido
                {
                    Modelo = sapato.Modelo,
                    PrecoTotal = Convert.ToDouble(txtPrecoTT.Text),
                    Quantidade38 = Convert.ToInt32(TextBox38.Text),
                    Quantidade39 = Convert.ToInt32(TextBox39.Text),
                    Quantidade40 = Convert.ToInt32(TextBox40.Text),
                    Quantidade41 = Convert.ToInt32(TextBox41.Text),
                    Quantidade42 = Convert.ToInt32(TextBox42.Text),
                    Quantidade43 = Convert.ToInt32(TextBox43.Text),
                    Quantidade44 = Convert.ToInt32(TextBox44.Text),
                    PrecoUnidade = Convert.ToDouble(txtPrecoUN.Text),
                    ClientePessoaFisica = clientePessoaFisica
                };
                if (PedidoDAO.AdicionarPedido(pedido))
                {
                    MessageBox.Show("Sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro!");
                }
                MainWindow main = new MainWindow();
                this.Close();
                main.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os dados do pedido!");
            }
        }

        private void BTN_SalvarPedidoParaPessoaJuridica(object sender, RoutedEventArgs e)
        {
            try
            {
                int idCliente = (Int32)cboClientesPessoaJuridica.SelectedValue;
                ClientePessoaJuridica clientePessoaJuridica = ClienteDAO.BuscarClientePessoaJuridicaPorId(idCliente);
                int idModelo = (Int32)cboModelos.SelectedValue;
                Sapato sapato = SapatoDAO.BuscarSapatoPorId(idModelo);
                Pedido pedido = new Pedido
                {
                    Modelo = sapato.Modelo,
                    PrecoTotal = Convert.ToDouble(txtPrecoTT.Text),
                    Quantidade38 = Convert.ToInt32(TextBox38.Text),
                    Quantidade39 = Convert.ToInt32(TextBox39.Text),
                    Quantidade40 = Convert.ToInt32(TextBox40.Text),
                    Quantidade41 = Convert.ToInt32(TextBox41.Text),
                    Quantidade42 = Convert.ToInt32(TextBox42.Text),
                    Quantidade43 = Convert.ToInt32(TextBox43.Text),
                    Quantidade44 = Convert.ToInt32(TextBox44.Text),
                    PrecoUnidade = Convert.ToDouble(txtPrecoUN.Text),
                    ClientePessoaJuridica = clientePessoaJuridica
                };
                if (PedidoDAO.AdicionarPedido(pedido))
                {
                    MessageBox.Show("Sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro!");
                }
                MainWindow main = new MainWindow();
                this.Close();
                main.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os dados do pedido!");
            }
        }

        private void CheckBox38_Checked(object sender, RoutedEventArgs e)
        {
            TextBox38.IsEnabled = true;
        }

        private void CheckBox39_Checked(object sender, RoutedEventArgs e)
        {
            TextBox39.IsEnabled = true;
        }

        private void CheckBox40_Checked(object sender, RoutedEventArgs e)
        {
            TextBox40.IsEnabled = true;
        }

        private void CheckBox41_Checked(object sender, RoutedEventArgs e)
        {
            TextBox41.IsEnabled = true;
        }

        private void CheckBox42_Checked(object sender, RoutedEventArgs e)
        {
            TextBox42.IsEnabled = true;
        }

        private void CheckBox43_Checked(object sender, RoutedEventArgs e)
        {
            TextBox43.IsEnabled = true;
        }

        private void CheckBox44_Checked(object sender, RoutedEventArgs e)
        {
            TextBox44.IsEnabled = true;
        }

        private void CheckBox38_Unchecked(object sender, RoutedEventArgs e)
        {
            TextBox38.IsEnabled = false;
        }

        private void CheckBox39_Unchecked(object sender, RoutedEventArgs e)
        {
            TextBox39.IsEnabled = false;
        }

        private void CheckBox40_Unchecked(object sender, RoutedEventArgs e)
        {
            TextBox40.IsEnabled = false;
        }

        private void CheckBox41_Unchecked(object sender, RoutedEventArgs e)
        {
            TextBox41.IsEnabled = false;
        }

        private void CheckBox42_Unchecked(object sender, RoutedEventArgs e)
        {
            TextBox42.IsEnabled = false;
        }

        private void CheckBox43_Unchecked(object sender, RoutedEventArgs e)
        {
            TextBox43.IsEnabled = false;
        }

        private void CheckBox44_Unchecked(object sender, RoutedEventArgs e)
        {
            TextBox44.IsEnabled = false;
        }
    }
}
