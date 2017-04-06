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
    /// Interaction logic for ModificarInventario.xaml
    /// </summary>
    public partial class ModificarInventario : Window
    {
        public ModificarInventario()
        {
            InitializeComponent();
        }

        private void AgregarInventario_Click(object sender, RoutedEventArgs e)
        {
            Inventario a = new Inventario();
            a.Owner = this;
            a.Show();
        }

        private void ReporteInventario_Click(object sender, RoutedEventArgs e)
        {
            ReporteInventario b = new ReporteInventario();
            b.Owner = this;
            b.Show();
        }
    }
}
