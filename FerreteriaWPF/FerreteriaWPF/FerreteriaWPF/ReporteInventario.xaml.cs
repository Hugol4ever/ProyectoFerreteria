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
    /// Interaction logic for ReporteInventario.xaml
    /// </summary>
    public partial class ReporteInventario : Window
    {
        public ReporteInventario()
        {
            InitializeComponent();
        }

        private void AgregarInventario_Click(object sender, RoutedEventArgs e)
        {
            Inventario a = new Inventario();
            a.Owner = this;
            a.Show();
        }

        private void ModificarInventario_Click(object sender, RoutedEventArgs e)
        {
            ModificarInventario a = new ModificarInventario();
            a.Owner = this;
            a.Show();
        }
    }
}
