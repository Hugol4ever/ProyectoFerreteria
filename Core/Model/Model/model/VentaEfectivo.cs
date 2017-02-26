namespace Model
{
    class VentaEfectivo : Venta
    {
        #region "Atributos"
        private int _idVentaEfectivo;
        private double _efectivo;
        #endregion

        #region "Constructores"
        public VentaEfectivo()
        {

        }

        public VentaEfectivo(double efectivo)
        {
            _efectivo = efectivo;
        }

        public VentaEfectivo(string fecha, Usuario cajero, double total, double efectivo) : base(fecha, cajero, total)
        {
            _efectivo = efectivo;
        }
        #endregion

        #region "Métodos accesibles"
        public int IdVentaEfectivo
        {
            set
            {
                _idVentaEfectivo = value;
            }
            get
            {
                return _idVentaEfectivo;
            }
        }

        public double Efectivo
        {
            set
            {
                _efectivo = value;
            }
            get
            {
                return _efectivo;
            }
        }
        #endregion
    }
}