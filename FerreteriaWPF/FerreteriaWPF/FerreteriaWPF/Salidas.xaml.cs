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
using Model;
using ViewModel;

namespace FerreteriaWPF
{
    /// <summary>
    /// Interaction logic for Salidas.xaml
    /// </summary>
    public partial class Salidas : Window
    {
        public Salidas()
        {
            InitializeComponent();
            textBox.Focus();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double cantidad = double.Parse(textBox.Text);
                string razon = textBox1.Text;
                Model.Salidas salida = new Model.Salidas(razon, cantidad);
                ViewModel.Salidas salidas = new ViewModel.Salidas(salida);
                if (salidas.registrarSalida())
                {
                    MessageBox.Show("Salida registrada con éxito.", Commons.TITULO_MENSAJES, MessageBoxButton.OK, MessageBoxImage.Information);
                    textBox.Text = null;
                    textBox1.Text = null;
                    textBox.Focus();
                }
                else
                {
                    MessageBox.Show("Algo salió mal.\nIntente otra vez.", Commons.TITULO_MENSAJES, MessageBoxButton.OK, MessageBoxImage.Error);
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Error -> " + ex);
                MessageBox.Show("Escriba una cantidad válida.", Commons.TITULO_MENSAJES, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
