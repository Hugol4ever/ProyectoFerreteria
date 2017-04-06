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
    /// Interaction logic for Proveedor.xaml
    /// </summary>
    public partial class Producto : Window
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NuevoProducto a = new NuevoProducto();
            a.Owner = this;
            a.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NuevoProducto a = new NuevoProducto();
            a.Owner = this;
            a.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Departamento a = new Departamento();
            a.Owner=this;
            a.Show();
        }
    }
}
