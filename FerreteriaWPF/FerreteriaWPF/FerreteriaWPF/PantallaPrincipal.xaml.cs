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
using DemoCSTimbraCFDI;
using Model;
using ViewModel;

namespace FerreteriaWPF
{
    /// <summary>
    /// Interaction logic for PantallaPrincipal.xaml
    /// </summary>
    public partial class PantallaPrincipal : Window
    {

        private Usuario _usuarios;
        private ViewModel.Permisos _permisos;

        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        public PantallaPrincipal(Usuario usuarios) : this()
        {
            _usuarios = usuarios;
            _permisos = new ViewModel.Permisos(_usuarios);
            aplicar();
        }

        private void MenuItem_SourceUpdated(object sender, DataTransferEventArgs e)
        {
          
        }

        private void ArticuloComún_Click(object sender, RoutedEventArgs e)
        {
            ArticuloComun a = new ArticuloComun();
            a.Owner = this;
            a.Show();
        }

        private void consU_Click(object sender, RoutedEventArgs e)
        {
            ConfUsuario jhd = new ConfUsuario();
            jhd.Owner = this;
            jhd.Show();
        }


        private void Buscar_Click(object sender, RoutedEventArgs e)
        {
            Buscar b = new Buscar();
            b.Owner = this;
            b.Show();
        }

        private void Salidas_Click(object sender, RoutedEventArgs e)
        {
            Salidas c = new Salidas();
            c.ShowDialog();
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            VentaProducto f = new VentaProducto();
            f.Owner = this;
            f.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Cobrar g = new Cobrar();
            g.Owner = this;
            g.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VentasDeDia d = new VentasDeDia();
            d.Owner = this;
            d.Show();
        }

        private void ClientesM_Click(object sender, RoutedEventArgs e)
        {
            bool cc = _usuarios.Perfil.Permisos.CrearCliente;
            bool ec = _usuarios.Perfil.Permisos.EliminarCliente;
            bool mc = _usuarios.Perfil.Permisos.ModificarCliente;
            Clientes h = new FerreteriaWPF.Clientes(cc, ec, mc);
            h.Owner = this;
            h.Show();
        }
        
        private void ProductosM_Click(object sender, RoutedEventArgs e)
        {
            Producto i = new Producto();
            i.Owner = this;
            i.Show();
        }

        private void InventarioM_Click(object sender, RoutedEventArgs e)
        {
            Inventario j = new Inventario();
            j.Owner = this;
            j.Show();
        }

        private void FacturaM_Click(object sender, RoutedEventArgs e)
        {
            Factura k = new Factura();
            k.Owner = this;
            k.Show();
        }

        private void  ReporteM_Click(object sender, RoutedEventArgs e)
        {
            Reportes w = new Reportes();
            w.Owner = this;
            w.Show();

        }

        private void OhSm_Click(object sender, RoutedEventArgs e)
        {
            OpHabilitadas m = new OpHabilitadas();
            m.Owner = this;
            m.Show();
        }

        private void UsM_Click(object sender, RoutedEventArgs e)
        {
            Usuarios n = new Usuarios();
            n.Owner = this;
            n.Show();
        }

        private void FacSm_Click(object sender, RoutedEventArgs e)
        {
            ConFactura o = new ConFactura();
            o.Owner = this;
            o.Show();
        }

        private void TsM_Click(object sender, RoutedEventArgs e)
        {
            ConfTictket w = new ConfTictket();
            w.Owner = this;
            w.Show();
        }

        private void UmSm_Click(object sender, RoutedEventArgs e)
        {
            UnidadesMedida q = new UnidadesMedida();
            q.Owner = this;
            q.Show();
        }

        private void IsM_Click(object sender, RoutedEventArgs e)
        {
            Impuestos r = new Impuestos();
            r.Owner = this;
            r.Show();
        }

        private void FpSm_Click(object sender, RoutedEventArgs e)
        {
            Window1 s = new Window1();
            s.Owner = this;
            s.Show();
        }

        private void SmSm_Click(object sender, RoutedEventArgs e)
        {
            SimboloMoneda t = new SimboloMoneda();
            t.Owner = this;
            t.Show();
        }

        private void LsM_Click(object sender, RoutedEventArgs e)
        {
            Logotipo u = new Logotipo();
            u.Owner = this;
            u.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CotizacionSM v = new CotizacionSM();
            v.Owner = this;
            v.Show();
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", Commons.TITULO_MENSAJES, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MainWindow m = new MainWindow();
                m.Show();
                this.Close();
            }
        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            Program.Main();
        }

        private void aplicar()
        {
            label1.Content = _usuarios.Nombres;
            _permisos.aplicar();
            Salidas.IsEnabled = _usuarios.Perfil.Permisos.RegistroSalidas;
        }
    }
}
