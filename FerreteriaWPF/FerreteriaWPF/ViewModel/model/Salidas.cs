using MySql.Data.MySqlClient;
using System;

namespace ViewModel
{
    public class Salidas
    {

        private Model.Salidas _salidas;
        private Conexion _conn;

        public Salidas()
        {
            _conn = new Conexion();
        }

        public Salidas(Model.Salidas salidas) : this()
        {
            _salidas = salidas;
        }

        public bool registrarSalida()
        {
            try
            {
                MySqlCommand cmd = _conn.getConnection.CreateCommand();
                cmd.CommandText = "CALL SP_registrarSalidas(@razon, @cantidad);";
                cmd.Parameters.AddWithValue("@razon", _salidas.Razon);
                cmd.Parameters.AddWithValue("@cantidad", _salidas.Cantidad);
                _conn.getConnection.Open();
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                return true;
            } catch (Exception ex)
            {
                Console.WriteLine("Error -> " + ex);
                return false;
            } finally
            {
                _conn.getConnection.Close();
            }
        }
    }
}