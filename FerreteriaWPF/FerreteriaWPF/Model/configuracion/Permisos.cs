using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Permisos
    {
        #region "Atributos"
        private int _idPermiso;
        private bool _aplicaMayoreo;
        private bool _historialVentas;
        private bool _registroSalidas;
        private bool _cobrar;
        private bool _cobrarCredito;
        private bool _cobrarVenta;
        private bool _eliminarArticuloVenta;
        private bool _facturar;
        private bool _verFacturas;
        private bool _administrarCredito;
        private bool _crearCliente;
        private bool _eliminarCliente;
        private bool _modificarCliente;
        private bool _crearProductos;
        private bool _modificarProductos;
        private bool _eliminarProductos;
        private bool _verVentas;
        private bool _agregarMercancia;
        private bool _modificarInventario;
        private bool _verReporteExistencias;
        private bool _realizarCorteTurno;
        private bool _verGanancias;
        private bool _cambiarConfiguraciones;
        private bool _cambiarPermisos;
        #endregion

        #region "Constructores"
        public Permisos()
        {

        }

        public Permisos(bool aplicaMayoreo, bool historialVentas, bool registroSalidas, bool cobrar, bool cobrarCredito, bool cobrarVenta, bool eliminarArticuloVenta, bool facturar, bool verFacturas, bool administrarCredito, bool crearCliente, bool eliminarCliente, bool modificarCliente, bool crearProductos, bool modificarProductos, bool eliminarProductos, bool verVentas, bool agregarMercancia, bool modificarInventario, bool verReporteExistencias, bool realizarCorteTurno, bool verGanancias, bool cambiarConfiguraciones, bool cambiarPermisos)
        {
            AplicaMayoreo = aplicaMayoreo;
            HistorialVentas = historialVentas;
            RegistroSalidas = registroSalidas;
            Cobrar = cobrar;
            CobrarCredito = cobrarCredito;
            CobrarVenta = cobrarVenta;
            EliminarArticuloVenta = eliminarArticuloVenta;
            Facturar = facturar;
            VerFacturas = verFacturas;
            AdministrarCredito = administrarCredito;
            CrearCliente = crearCliente;
            EliminarCliente = eliminarCliente;
            ModificarCliente = modificarCliente;
            CrearProductos = crearProductos;
            ModificarProductos = modificarProductos;
            EliminarProductos = eliminarProductos;
            VerVentas = verVentas;
            AgregarMercancia = agregarMercancia;
            ModificarInventario = modificarInventario;
            VerReporteExistencias = verReporteExistencias;
            RealizarCorteTurno = realizarCorteTurno;
            VerGanancias = verGanancias;
            CambiarConfiguraciones = cambiarConfiguraciones;
            CambiarPermisos = cambiarPermisos;
    }
        #endregion

        #region "Métodos accesibles"
        public int IdConfiguracion
        {
            get
            {
                return _idPermiso;
            }

            set
            {
                _idPermiso = value;
            }
        }

        public bool AplicaMayoreo
        {
            get
            {
                return _aplicaMayoreo;
            }

            set
            {
                _aplicaMayoreo = value;
            }
        }

        public bool HistorialVentas
        {
            get
            {
                return _historialVentas;
            }

            set
            {
                _historialVentas = value;
            }
        }

        public bool RegistroSalidas
        {
            get
            {
                return _registroSalidas;
            }

            set
            {
                _registroSalidas = value;
            }
        }

        public bool Cobrar
        {
            get
            {
                return _cobrar;
            }

            set
            {
                _cobrar = value;
            }
        }

        public bool CobrarCredito
        {
            get
            {
                return _cobrarCredito;
            }

            set
            {
                _cobrarCredito = value;
            }
        }

        public bool CobrarVenta
        {
            get
            {
                return _cobrarVenta;
            }

            set
            {
                _cobrarVenta = value;
            }
        }

        public bool EliminarArticuloVenta
        {
            get
            {
                return _eliminarArticuloVenta;
            }

            set
            {
                _eliminarArticuloVenta = value;
            }
        }

        public bool Facturar
        {
            get
            {
                return _facturar;
            }

            set
            {
                _facturar = value;
            }
        }

        public bool VerFacturas
        {
            get
            {
                return _verFacturas;
            }

            set
            {
                _verFacturas = value;
            }
        }

        public bool AdministrarCredito
        {
            get
            {
                return _administrarCredito;
            }

            set
            {
                _administrarCredito = value;
            }
        }

        public bool CrearCliente
        {
            get
            {
                return _crearCliente;
            }

            set
            {
                _crearCliente = value;
            }
        }

        public bool EliminarCliente
        {
            get
            {
                return _eliminarCliente;
            }

            set
            {
                _eliminarCliente = value;
            }
        }

        public bool ModificarCliente
        {
            get
            {
                return _modificarCliente;
            }

            set
            {
                _modificarCliente = value;
            }
        }

        public bool CrearProductos
        {
            get
            {
                return _crearProductos;
            }

            set
            {
                _crearProductos = value;
            }
        }

        public bool ModificarProductos
        {
            get
            {
                return _modificarProductos;
            }

            set
            {
                _modificarProductos = value;
            }
        }

        public bool EliminarProductos
        {
            get
            {
                return _eliminarProductos;
            }

            set
            {
                _eliminarProductos = value;
            }
        }

        public bool VerVentas
        {
            get
            {
                return _verVentas;
            }

            set
            {
                _verVentas = value;
            }
        }

        public bool AgregarMercancia
        {
            get
            {
                return _agregarMercancia;
            }

            set
            {
                _agregarMercancia = value;
            }
        }

        public bool ModificarInventario
        {
            get
            {
                return _modificarInventario;
            }

            set
            {
                _modificarInventario = value;
            }
        }

        public bool VerReporteExistencias
        {
            get
            {
                return _verReporteExistencias;
            }

            set
            {
                _verReporteExistencias = value;
            }
        }

        public bool RealizarCorteTurno
        {
            get
            {
                return _realizarCorteTurno;
            }

            set
            {
                _realizarCorteTurno = value;
            }
        }

        public bool VerGanancias
        {
            get
            {
                return _verGanancias;
            }

            set
            {
                _verGanancias = value;
            }
        }

        public bool CambiarConfiguraciones
        {
            get
            {
                return _cambiarConfiguraciones;
            }

            set
            {
                _cambiarConfiguraciones = value;
            }
        }

        public bool CambiarPermisos
        {
            get
            {
                return _cambiarPermisos;
            }

            set
            {
                _cambiarPermisos = value;
            }
        }
        #endregion
    }
}