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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CadastrarRB_Checked(object sender, RoutedEventArgs e)
        {
            GridCadastrar.Visibility = Visibility.Visible;
            GridListar.Visibility = Visibility.Hidden;
        }

        private void ListarRB_Checked(object sender, RoutedEventArgs e)
        {
            GridListar.Visibility = Visibility.Visible;
            GridCadastrar.Visibility = Visibility.Hidden;
        }

        private void BTN_Sapatos(object sender, RoutedEventArgs e)
        {
            Sapatos sapatos = new Sapatos();
            this.Hide();
            sapatos.ShowDialog();
        }

        private void BTN_Estoque(object sender, RoutedEventArgs e)
        {
            Estoque estoque = new Estoque();
            this.Hide();
            estoque.ShowDialog();
        }

        private void BTN_Sapato(object sender, RoutedEventArgs e)
        {
            CadastrarSapato cadastrarSapato = new CadastrarSapato();
            this.Hide();
            cadastrarSapato.ShowDialog();
        }

        private void BTN_Pedido(object sender, RoutedEventArgs e)
        {
            CadastrarPedido cadastrarPedido = new CadastrarPedido();
            this.Hide();
            cadastrarPedido.ShowDialog();
        }

        private void BTN_Cliente(object sender, RoutedEventArgs e)
        {
            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            this.Hide();
            cadastrarCliente.ShowDialog();
        }
    }
}
