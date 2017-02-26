namespace Model.model
{
    class DetalleVenta : Venta
    {
        #region "Atributos"
        private int _idDetalleVenta;
        private Producto _producto;
        private int _cantidad;
        private UnidadMedida _unidadMedida;
        private double _precio;
        #endregion

        #region "Constructores"
        public DetalleVenta()
        {

        }

        public DetalleVenta(Producto producto, int cantidad, UnidadMedida unidadMedida, double precio)
        {
            _producto = producto;
            _cantidad = cantidad;
            _unidadMedida = unidadMedida;
            _precio = precio;
        }

        public DetalleVenta(Producto producto, int cantidad, UnidadMedida unidadMedida, double precio, string fecha, Usuario cajero, double total) : base(fecha, cajero, total)
        {
            _producto = producto;
            _cantidad = cantidad;
            _unidadMedida = unidadMedida;
            _precio = precio;
        }
        #endregion

        #region "Métodos accesibles"
        public int IdDetalleVenta
        {
            set
            {
                _idDetalleVenta = value;
            }
            get
            {
                return _idDetalleVenta;
            }
        }

        public Producto Producto
        {
            set
            {
                _producto = value;
            }
            get
            {
                return _producto;
            }
        }

        public int Cantidad
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

        public double Precio
        {
            set
            {
                _precio = value;
            }
            get
            {
                return _precio;
            }
        }
        #endregion
    }
}