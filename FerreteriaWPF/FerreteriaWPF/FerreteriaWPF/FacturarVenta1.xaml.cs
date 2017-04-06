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
    /// Interaction logic for FacturarVenta1.xaml
    /// </summary>
    public partial class FacturarVenta1 : Window
    {
        public FacturarVenta1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            VerificarFactura a = new VerificarFactura();
            a.Owner = this;
            a.Show();
            
        }
    }
}
