namespace Model
{
    class Venta
    {
        #region "Atributos"
        protected int _idVenta;
        protected string _fecha;
        protected Usuario _cajero;
        protected double _total;
        #endregion

        #region "Constructores"
        public Venta()
        {

        }

        public Venta(string fecha, Usuario cajero, double total)
        {
            _fecha = fecha;
            _cajero = cajero;
            _total = total;
        }
        #endregion

        #region "Métodos accesibles"
        public int IdVenta
        {
            set
            {
                _idVenta = value;
            }
            get
            {
                return _idVenta;
            }
        }

        public string Fecha
        {
            set
            {
                _fecha = value;
            }
            get
            {
                return _fecha;
            }
        }

        public Usuario Cajero
        {
            set
            {
                _cajero = value;
            }
            get
            {
                return _cajero;
            }
        }

        public double Total
        {
            set
            {
                _total = value;
            }
            get
            {
                return _total;
            }
        }
        #endregion
    }
}