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
    /// Interaction logic for ClienteFacturacion.xaml
    /// </summary>
    public partial class ClienteFacturacion : Window
    {
        public ClienteFacturacion()
        {
            InitializeComponent();
        }

        public void nuevoCfac_Click(object sender, RoutedEventArgs e)
        {
            NuevoClienteFactura a = new NuevoClienteFactura();
            a.Owner = this;
            a.Show();
        }

        public void modCfac_Click(object sender, RoutedEventArgs e)
        {
            NuevoClienteFactura b = new NuevoClienteFactura();
            b.Owner = this;
            b.Show();
        }
    }
}
