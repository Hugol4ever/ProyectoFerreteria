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
    /// Interaction logic for FacturarVenta.xaml
    /// </summary>
    public partial class FacturarVenta : Window
    {
        public FacturarVenta()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            FacturarVenta1 a = new FacturarVenta1();
            a.Owner = this;
            a.Show();

        }

        private void nuevoCfac_Click(object sender, RoutedEventArgs e)
        {
            NuevoClienteFactura b = new NuevoClienteFactura();
            b.Owner = this;
            b.Show();
        }

        private void modCfac_Click(object sender, RoutedEventArgs e)
        {
            NuevoClienteFactura b = new NuevoClienteFactura();
            b.Owner = this;
            b.Show();
        }
    }
}
