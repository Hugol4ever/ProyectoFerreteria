namespace Model
{
    class VentaCredito : Venta
    {
        #region "Atributos"
        private int _idVentaCredito;
        private Cliente _cliente;
        #endregion

        #region "Constructores"
        public VentaCredito()
        {

        }

        public VentaCredito(Cliente cliente)
        {
            _cliente = cliente;
        }

        public VentaCredito(string fecha, Usuario cajero, double total, Cliente cliente) :base(fecha, cajero, total)
        {
            _cliente = cliente;
        }
        #endregion

        #region "Métodos accesibles"
        public int IdVentaCredito
        {
            set
            {
                _idVentaCredito = value;
            }
            get
            {
                return _idVentaCredito;
            }
        }

        public Cliente Cliente
        {
            set
            {
                _cliente = value;
            }
            get
            {
                return _cliente;
            }
        }
        #endregion
    }
}