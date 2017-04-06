using Model;
using MySql.Data.MySqlClient;
using System;

namespace ViewModel
{
    public class Login
    {
        #region "Atributos"
        private Usuario _usuario;
        private Conexion _conn;
        #endregion

        #region "Constructores"
        public Login()
        {
            _conn = new Conexion();
        }

        public Login(Usuario usuario) : this()
        {
            _usuario = usuario;
        }
        #endregion

        #region "Métodos generales"
        public bool iniciarSesion()
        {
            try
            {
                MySqlCommand cmd = _conn.getConnection.CreateCommand();
                cmd.CommandText = "SELECT * FROM V_login WHERE usuario = '" + _usuario.User + "' AND contrasenia = '" + _usuario.Password + "';";
                _conn.getConnection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    _usuario.IdUsuario = reader.GetInt32("idUsuario");
                    _usuario.Nombres = reader.GetString("nombres");
                    _usuario.Perfil.IdPerfil = reader.GetInt32("idPerfil");
                    _usuario.Perfil.Perfil = reader.GetString("perfil");
                    return true;
                } else
                {
                    return false;
                }
            } catch (Exception ex)
            {
                Console.WriteLine("error -> " + ex);
                return false;
            } finally
            {
                _conn.getConnection.Close();
            }
        }
        #endregion

    }
}