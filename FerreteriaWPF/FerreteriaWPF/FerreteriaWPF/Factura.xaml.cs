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
    /// Interaction logic for Factura.xaml
    /// </summary>
    public partial class Factura : Window
    {
        public Factura()
        {
            InitializeComponent();
        }

    private void Clientefac_Click(object sender, RoutedEventArgs e)
        {
            ClienteFacturacion a = new ClienteFacturacion();
            a.Owner = this;
            a.Show();
        }

        private void Correo_Click(object sender, RoutedEventArgs e)
        {
            FacturaCorreo b = new FacturaCorreo();
            b.Owner=this;
            b.Show();

        }

    }
}
