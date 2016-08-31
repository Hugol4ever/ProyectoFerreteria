using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Core.org.project.connection
{
    class Connection
    {
        //Atributos
        private String _url;
        private String _server;
        private int _port;
        private String _dataBase;
        private String _userName;
        private String _password;
        private MySqlConnection _conn;

        //Métodos
        public MySqlConnection abrir()
        {
            try
            {
                if (_conn == null || _conn.State.Equals("Closed"))
                {
                    _conn.Open();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex);
            }
            return _conn;
        }

        public void cerrar()
        {
            try
            {
                _conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex);
            }
        }

        //Constructores
        public Connection(String _server, int _port, String _dataBase, String _userName, String _password)
        {
            this._server = _server;
            this._port = _port;
            this._dataBase = _dataBase;
            this._userName = _userName;
            this._password = _password;

            try
            {
                String _Conn = "Server=" + _server + "; Database:" + _dataBase + "; Uid=" + _userName + "; " +
                    "Pwd=" + _password;
                this._conn = new MySqlConnection(_Conn);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex);
            }
        }

        public Connection() : this("localhost", 3306, "BD_Ferreteria", "root", "root")
        {

        }

        //Gettes y Settes

    }
}
