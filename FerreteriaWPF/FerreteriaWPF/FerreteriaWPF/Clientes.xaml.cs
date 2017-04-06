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

namespace FerreteriaWPF
{
    /// <summary>
    /// Interaction logic for Clientes.xaml
    /// </summary>
    public partial class Clientes : Window
    {
        public Clientes()
        {
            InitializeComponent();
        }

        public Clientes(bool crearCliente, bool eliminarCliente, bool modificarCliente) : this()
        {
            button3.IsEnabled = crearCliente;
            button1.IsEnabled = eliminarCliente;
            button2.IsEnabled = modificarCliente;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NuevoCliente a = new NuevoCliente();
            a.Owner = this;
            a.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            NuevoCliente a = new NuevoCliente();
            a.Owner = this;
            a.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            EstadoClienteIn a = new EstadoClienteIn();
            a.Owner = this;
            a.Show();
        }
    }
}
