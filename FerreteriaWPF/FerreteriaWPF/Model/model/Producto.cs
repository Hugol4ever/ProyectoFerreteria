namespace Model
{
    public class Producto
    {
        #region "Atributos"
        private int _idProducto;
        private int _codigoBarras;
        private string _nombre;
        private TipoVenta _tipoVenta;
        private double _precioCompra;
        private double _precioVenta;
        private double _precioMayoreo;
        private UnidadMedida _unidadMedida;
        private double _cantidad;
        private Departamento _departamento;
        private bool _descuento;
        #endregion

        #region "Constructores"
        public Producto()
        {

        }

        public Producto(int idProducto, int codigoBarras, string nombre, TipoVenta tipoVenta, double precioCompra, double precioVenta, double precioMayoreo, UnidadMedida unidadMedida, double cantidad, Departamento departamento, bool descuento)
        {
            _idProducto = idProducto;
            _codigoBarras = codigoBarras;
            _nombre = nombre;
            _tipoVenta = tipoVenta;
            _precioCompra = precioCompra;
            _precioVenta = precioVenta;
            _precioMayoreo = precioMayoreo;
            _unidadMedida = unidadMedida;
            _cantidad = cantidad;
            _departamento = departamento;
            _descuento = descuento;
        }
        #endregion

        #region "Métodos accesibles"
        public int IdProducto
        {
            set
            {
                _idProducto = value;
            }
            get
            {
                return _idProducto;
            }
        }

        public int CodigoBarras
        {
            set
            {
                _codigoBarras = value;
            }
            get
            {
                return _codigoBarras;
            }
        }

        public string Nombre
        {
            set
            {
                _nombre = value;
            }
            get
            {
                return _nombre;
            }
        }

        public TipoVenta TipoVenta
        {
            set
            {
                _tipoVenta = value;
            }
            get
            {
                return _tipoVenta;
            }
        }

        public double PrecioCompra
        {
            set
            {
                _precioCompra = value;
            }
            get
            {
                return _precioCompra;
            }
        }

        public double PrecioVenta
        {
            set
            {
                _precioVenta = value;
            }
            get
            {
                return _precioVenta;
            }
        }

        public double PrecioMayoreo
        {
            set
            {
                _precioMayoreo = value;
            }
            get
            {
                return _precioMayoreo;
            }
        }

        public UnidadMedida UnidadMedida
        {
            set
            {
                _unidadMedida = value;
            }
            get
            {
                return _unidadMedida;
            }
        }

        public double Cantidad
        {
            set
            {
                _cantidad = value;
            }
            get
            {
                return _cantidad;
            }
        }

        public Departamento Departanento
        {
            set
            {
                _departamento = value;
            }
            get
            {
                return _departamento;
            }
        }

        public bool Descuento
        {
            set
            {
                _descuento = value;
            }
            get
            {
                return _descuento;
            }
        }
        #endregion
    }
}