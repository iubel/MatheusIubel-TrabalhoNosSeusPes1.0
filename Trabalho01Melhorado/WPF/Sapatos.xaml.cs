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
using System.ComponentModel;

namespace WPF
{
    /// <summary>
    /// Lógica interna para Sapatos.xaml
    /// </summary>
    public partial class Sapatos : Window
    {

        private void BTN_Voltar(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }

        private void BTN_Excluir(object sender, RoutedEventArgs e)
        {
            try
            {
                Sapato sapato = new Sapato();
                int idSapato = SapatoSelecionado.IdSapato;
                sapato = SapatoDAO.BuscarSapatoPorId(idSapato);
                if (SapatoDAO.RemoverSapato(sapato))
                {
                    MessageBox.Show("Sapato excluido com sucessso!");
                    this.Close();
                    Sapatos sapatos = new Sapatos();
                    sapatos.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Erro!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um sapato primeiro!");
            }

            
        }

        private Sapato _Sapato = new Sapato();
        public Sapato SapatoSelecionado
        {
            get
            {
                return _Sapato;
            }
            set
            {
                _Sapato = value;
                this.NotifyPropertyChanged("SapatoSelecionado");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string Property)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(
                    Property));
            }
        }

        public IList<Sapato> Sapatoss { get; set; }

        public Sapatos()
        {
            InitializeComponent();
            this.DataContext = this;

            this.Sapatoss = SapatoDAO.RetornarLista();
        }

        private void BTN_Detalhes(object sender, RoutedEventArgs e)
        {
            try
            {
                Sapato sapato = new Sapato();
                int idSapato = SapatoSelecionado.IdSapato;
                sapato = SapatoDAO.BuscarSapatoPorId(idSapato);
                DetalhesSapato detalhesSapato = new DetalhesSapato(sapato);
                this.Close();
                detalhesSapato.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um sapato primeiro!");
            }
           
        }
    }
}
