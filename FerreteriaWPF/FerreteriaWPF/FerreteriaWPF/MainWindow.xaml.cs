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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModel;
using Model;

namespace FerreteriaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox.Focus();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ingresar();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.Return) || (e.Key == Key.Tab))
            {
                passwordBox.Focus();
            }
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                ingresar();
            }
        }

        private void ingresar()
        {
            String usuario = textBox.Text;
            String password = passwordBox.Password;
            Usuario usuarios = new Usuario();
            usuarios.User = usuario;
            usuarios.Password = password;
            usuarios.Perfil = new Perfiles();
            Login login = new Login(usuarios);
            if (login.iniciarSesion())
            {
                new PantallaPrincipal(usuarios).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos.\nIntente otra véz.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                passwordBox.Focus();
                passwordBox.SelectAll();
            }
        }
    }
}
