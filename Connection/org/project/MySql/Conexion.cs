using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;

namespace Connection.org.project.MySql
{
    class Conexion
    {
        //Atributos
        private String _driverName;
        private String _url;
        private String _server;
        private int _port;
        private String _dataBase;
        private String _userName;
        private String _password;
        private MySqlConnection _con;

        //Métodos
        public MySqlConnection abrir()
        {
            if (_con == null || _con.State.Equals("Closed"))
            {
                _con.Open();
            }
            return _con;
        }

        //Constructor
        public Conexion() : this("com.mysql.jdbc.Driver", "localhost", 3306, "BD_Ferreteria", "root", "root")
        {
            
        }

        public Conexion(String driverName, String server, int port, String dataBase, String userName, String password)
        {
            _driverName = driverName;
            _server = server;
            _port = port;
            _dataBase = dataBase;
            _userName = userName;
            _password = password;

            try
            {
                String _connection = "Server=" + _server + "; Database=" + _dataBase + "; Uid=" + _userName + 
                    "; Pwd=" + _password + ";";
                _con = new MySqlConnection(_connection);
            } catch(Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex);
            }
        }

        //Sección de Gettes y Settes
    }
}
