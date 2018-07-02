using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Lógica interna para DetalhesSapato.xaml
    /// </summary>
    public partial class DetalhesSapato : Window
    {

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

        public DetalhesSapato(Sapato sapato)
        {
            InitializeComponent();
            this.DataContext = this;

            this.Sapatoss = SapatoDAO.RetorarSapatoPorNome(sapato);
        }

        private void Click_SalvarSapato(object sender, RoutedEventArgs e)
        {
            try
            {
                int idSapato = Convert.ToInt32(txtIdSapato.Text);

                Sapato sapato = SapatoDAO.BuscarSapatoPorId(idSapato);

                if (txtModelo.Text == "")
                {
                    sapato.Modelo = "";
                }
                else
                {
                    sapato.Modelo = txtModelo.Text;
                }

                if (RB_Sim.IsChecked == true)
                {
                    sapato.Cadarco = true;
                }
                else
                {
                    sapato.Cadarco = false;
                }

                if (txtMaterialSapato.Text == "")
                {
                    sapato.Material = "";
                }
                else
                {
                    sapato.Material = txtMaterialSapato.Text;
                }

                if (txtCorSapato.Text == "")
                {
                    sapato.Cor = "";
                }
                else
                {
                    sapato.Cor = txtCorSapato.Text;
                }

                if (txtPrecoSapato.Text == "")
                {
                    sapato.Preco = 0.00;
                }
                else
                {
                    sapato.Preco = Convert.ToDouble(txtPrecoSapato.Text);
                }

                if (TextBox38.Text.Equals(""))
                {
                    sapato.Quantidade38 = 0;
                }
                else
                {
                    sapato.Quantidade38 = Convert.ToInt32(TextBox38.Text);
                }

                if (TextBox39.Text.Equals(""))
                {
                    sapato.Quantidade39 = 0;
                }
                else
                {
                    sapato.Quantidade39 = Convert.ToInt32(TextBox39.Text);
                }

                if (TextBox40.Text.Equals(""))
                {
                    sapato.Quantidade40 = 0;
                }
                else
                {
                    sapato.Quantidade40 = Convert.ToInt32(TextBox40.Text);
                }

                if (TextBox41.Text.Equals(""))
                {
                    sapato.Quantidade41 = 0;
                }
                else
                {
                    sapato.Quantidade41 = Convert.ToInt32(TextBox41.Text);
                }

                if (TextBox42.Text.Equals(""))
                {
                    sapato.Quantidade42 = 0;
                }
                else
                {
                    sapato.Quantidade42 = Convert.ToInt32(TextBox42.Text);
                }

                if (TextBox43.Text.Equals(""))
                {
                    sapato.Quantidade43 = 0;
                }
                else
                {
                    sapato.Quantidade43 = Convert.ToInt32(TextBox43.Text);
                }

                if (TextBox44.Text.Equals(""))
                {
                    sapato.Quantidade44 = 0;
                }
                else
                {
                    sapato.Quantidade44 = Convert.ToInt32(TextBox44.Text);
                }

                if (SapatoDAO.AlterarSapato(sapato))
                {
                    MessageBox.Show("Sapato alterado com sucesso!");
                    Sapatos sapatos = new Sapatos();
                    this.Close();
                    sapatos.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Erro, tente novamente!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os dados do sapato!");
            }
        }

        private void Click_VoltarDetalhesSapato(object sender, RoutedEventArgs e)
        {
            Sapatos sapatos = new Sapatos();
            this.Close();
            sapatos.ShowDialog();
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

        private void CheckBox44_Unchecked(object sender, RoutedEventArgs e)
        {
            TextBox44.IsEnabled = false;
        }

        private void CheckBox43_Unchecked(object sender, RoutedEventArgs e)
        {
            TextBox43.IsEnabled = false;
        }

        private void CheckBox42_Unchecked(object sender, RoutedEventArgs e)
        {
            TextBox42.IsEnabled = false;
        }

        private void CheckBox41_Unchecked(object sender, RoutedEventArgs e)
        {
            TextBox41.IsEnabled = false;
        }

        private void CheckBox40_Unchecked(object sender, RoutedEventArgs e)
        {
            TextBox40.IsEnabled = false;
        }

        private void CheckBox39_Unchecked(object sender, RoutedEventArgs e)
        {
            TextBox39.IsEnabled = false;
        }

        private void CheckBox38_Unchecked(object sender, RoutedEventArgs e)
        {
            TextBox38.IsEnabled = false;
        }
    }
}
