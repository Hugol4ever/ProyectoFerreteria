using Model;
using MySql.Data.MySqlClient;
using System;

namespace ViewModel
{
    public class Permisos
    {
        #region "Atributos"
        private Conexion _conn;
        private Usuario _usuario;
        private Model.Permisos _permisos;
        #endregion

        #region "Constructores"
        public Permisos()
        {
            _conn = new Conexion();
            _permisos = new Model.Permisos();
        }

        public Permisos(Usuario usuario) : this()
        {
            _usuario = usuario;
        }
        #endregion

        #region "Métodos generales"
        public void aplicar()
        {
            try
            {
                MySqlCommand cmd = _conn.getConnection.CreateCommand();
                cmd.CommandText = "SELECT * FROM V_verPermisos WHERE idPerfil = " + _usuario.Perfil.IdPerfil + ";";
                _conn.getConnection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    _permisos.AplicaMayoreo = reader.GetBoolean("aplicaMayoreo");
                    _permisos.HistorialVentas = reader.GetBoolean("historialVentas");
                    _permisos.RegistroSalidas = reader.GetBoolean("registroSalidas");
                    _permisos.Cobrar = reader.GetBoolean("cobrar");
                    _permisos.CobrarCredito = reader.GetBoolean("cobrarCredito");
                    _permisos.CobrarVenta = reader.GetBoolean("cobrarVenta");
                    _permisos.EliminarArticuloVenta = reader.GetBoolean("eliminarArticuloVenta");
                    _permisos.Facturar = reader.GetBoolean("facturar");
                    _permisos.VerFacturas = reader.GetBoolean("verFacturas");
                    _permisos.AdministrarCredito = reader.GetBoolean("administrarCredito");
                    _permisos.CrearCliente = reader.GetBoolean("crearCliente");
                    _permisos.EliminarCliente = reader.GetBoolean("eliminarCliente");
                    _permisos.ModificarCliente = reader.GetBoolean("modificarCliente");
                    _permisos.CrearProductos = reader.GetBoolean("crearProductos");
                    _permisos.ModificarProductos = reader.GetBoolean("modificarProductos");
                    _permisos.EliminarProductos = reader.GetBoolean("eliminarProductos");
                    _permisos.VerVentas = reader.GetBoolean("verVentas");
                    _permisos.AgregarMercancia = reader.GetBoolean("agregarMercancia");
                    _permisos.ModificarInventario = reader.GetBoolean("modificarInventario");
                    _permisos.VerReporteExistencias = reader.GetBoolean("verReporteExistencias");
                    _permisos.RealizarCorteTurno = reader.GetBoolean("realizarCorteTurno");
                    _permisos.VerGanancias = reader.GetBoolean("verGanancias");
                    _permisos.CambiarConfiguraciones = reader.GetBoolean("cambiarConfiguraciones");
                    _permisos.CambiarPermisos = reader.GetBoolean("cambiarPermisos");
                    _usuario.Perfil.Permisos = _permisos;
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Error -> " + ex);
            }
            finally
            {
                _conn.getConnection.Close();
            }
        }
        #endregion

    }
}