namespace Model
{
    public class VentaEfectivo : Venta
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

        public VentaEfectivo(string fecha, Usuario cajero, double total, bool cancelada, double efectivo) : base(fecha, cajero, total, cancelada)
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