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
    /// Lógica interna para Estoque.xaml
    /// </summary>
    public partial class Estoque : Window
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void BTN_Voltar(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          var query =
          from sapato in SapatoDAO.RetornarLista()
          where sapato.Quantidade38 != 0 || sapato.Quantidade39 !=0 || sapato.Quantidade40 != 0 || sapato.Quantidade41 != 0 || sapato.Quantidade42 != 0 || sapato.Quantidade43 != 0 || sapato.Quantidade44 != 0
          orderby sapato.IdSapato
          select new { sapato.Modelo, sapato.Quantidade38, sapato.Quantidade39, sapato.Quantidade40, sapato.Quantidade41, sapato.Quantidade42, sapato.Quantidade43, sapato.Quantidade44 };

            DTG_Estoque.ItemsSource = query.ToList();
        }
    }
}
