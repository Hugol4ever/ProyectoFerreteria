namespace Model
{
    public class VentaMixta : Venta
    {
        #region "Atributos"
        private int _idVentaMixta;
        private double _efectivo;
        private string _referencia;
        #endregion

        #region "Constructores"
        public VentaMixta()
        {

        }

        public VentaMixta(double efectivo, string referencia)
        {
            _efectivo = efectivo;
            _referencia = referencia;
        }

        public VentaMixta(double efectivo, string referencia, string fecha, Usuario cajero, double total, bool cancelada) : base(fecha, cajero, total, cancelada)
        {
            _efectivo = efectivo;
            _referencia = referencia;
        }
        #endregion

        #region "Métodos accesibles"
        public int IdVentaMixta
        {
            get
            {
                return _idVentaMixta;
            }

            set
            {
                _idVentaMixta = value;
            }
        }

        public double Efectivo
        {
            get
            {
                return _efectivo;
            }

            set
            {
                _efectivo = value;
            }
        }

        public string Referencia
        {
            get
            {
                return _referencia;
            }

            set
            {
                _referencia = value;
            }
        }
        #endregion
    }
}