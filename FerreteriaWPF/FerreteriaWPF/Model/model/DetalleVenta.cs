namespace Model.model
{
    public class DetalleVenta
    {
        #region "Atributos"
        private int _idDetalleVenta;
        private Producto _producto;
        private double _cantidad;
        private double _precio;
        private Venta _venta;
        #endregion

        #region "Constructores"
        public DetalleVenta()
        {

        }

        public DetalleVenta(Producto producto, double cantidad, double precio, Venta venta)
        {
            _producto = producto;
            _cantidad = cantidad;
            _precio = precio;
            _venta = venta;
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

        public Venta venta
        {
            set
            {
                _venta = value;
            }
            get
            {
                return _venta;
            }
        }
        #endregion
    }
}