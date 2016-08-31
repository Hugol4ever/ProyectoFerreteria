using Core.org.project.connection;
using MySql.Data.MySqlClient;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Connection cn = new Connection();
                MySqlConnection con = cn.abrir();
                MySqlDataReader consultar;
                if (con != null)
                {
                    MessageBox.Show("Ok");
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT * FROM Usuario";
                    con.Open();
                    consultar = cmd.ExecuteReader();
                    while (consultar.Read())
                    {
                        MessageBox.Show(consultar.GetString(1));
                    }
                }
                else
                {
                    MessageBox.Show("No");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
