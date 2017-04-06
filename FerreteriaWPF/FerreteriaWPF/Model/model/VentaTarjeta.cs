namespace Model
{
    public class VentaTarjeta : Venta
    {
        #region "Atributos"
        private int _idVentaTarjeta;
        private string _referencia;
        #endregion

        #region "Constructores"
        public VentaTarjeta()
        {

        }

        public VentaTarjeta(string referencia)
        {
            Referencia = referencia;
        }

        public VentaTarjeta(string referencia, string fecha, Usuario cajero, double total, bool cancelada) : base(fecha, cajero, total, cancelada)
        {
            Referencia = referencia;
        }
        #endregion

        #region "Métodos accesibles"
        public int IdVentaTarjeta
        {
            get
            {
                return _idVentaTarjeta;
            }

            set
            {
                _idVentaTarjeta = value;
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