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
    /// Lógica interna para CadastrarSapato.xaml
    /// </summary>
    public partial class CadastrarSapato : Window
    {
        public CadastrarSapato()
        {
            InitializeComponent();
        }

        private void BTN_Voltar(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }

        private void BTN_Limpar(object sender, RoutedEventArgs e)
        {
            TxtModelo.Clear();
            RB_Sim.IsChecked = false;
            RB_Nao.IsChecked = false;
            TxtPreco.Text = "";
            TxtMaterial.Clear();
            TxtCor.Clear();
            TextBox38.Clear();
            TextBox38.IsEnabled = false;
            CheckBox38.IsChecked = false;
            TextBox39.Clear();
            TextBox39.IsEnabled = false;
            CheckBox39.IsChecked = false;
            TextBox40.Clear();
            TextBox40.IsEnabled = false;
            CheckBox40.IsChecked = false;
            TextBox41.Clear();
            TextBox41.IsEnabled = false;
            CheckBox41.IsChecked = false;
            TextBox42.Clear();
            TextBox42.IsEnabled = false;
            CheckBox42.IsChecked = false;
            TextBox43.Clear();
            TextBox43.IsEnabled = false;
            CheckBox43.IsChecked = false;
            TextBox44.Clear();
            TextBox44.IsEnabled = false;
            CheckBox44.IsChecked = false;
        }

        private void BTN_Salvar(object sender, RoutedEventArgs e)
        {
            try
            {
                Sapato sapato = new Sapato();

               
                    sapato.Modelo = TxtModelo.Text;
                

                if (RB_Sim.IsChecked == true)
                {
                    sapato.Cadarco = true;
                }
                else
                {
                    sapato.Cadarco = false;
                }

                
                    sapato.Material = TxtMaterial.Text;
                

                
                    sapato.Cor = TxtCor.Text;
                

                
                    sapato.Preco = Convert.ToDouble(TxtPreco.Text);
                

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

                if (SapatoDAO.AdicionarProduto(sapato))
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
                MessageBox.Show("Verifique os dados do sapato!");
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
