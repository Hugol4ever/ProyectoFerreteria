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
    /// Interaction logic for Inventario.xaml
    /// </summary>
    public partial class Inventario : Window
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void ModificarInventario_Click(object sender, RoutedEventArgs e)
        {
            ModificarInventario a = new ModificarInventario();
            a.Owner = this;
            a.Show();
        }

        private void ReporteInventario_Click(object sender, RoutedEventArgs e)
        {
            ReporteInventario k = new ReporteInventario();
            k.Owner = this;
            k.Show();
        }
    }
}
