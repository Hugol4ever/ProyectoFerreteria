namespace Model
{
    public class Salidas
    {
        #region "Atributos"
        private int _idSalida;
        private string _razon;
        private double _cantidad;
        #endregion

        #region "Constructores"
        public Salidas()
        {

        }

        public Salidas(string razon, double cantidad)
        {
            _razon = razon;
            _cantidad = cantidad;
        }
        #endregion

        #region "Métodos accesibles"
        public int IdSalida
        {
            set
            {
                _idSalida = value;
            }
            get
            {
                return _idSalida;
            }
        }

        public string Razon
        {
            set
            {
                _razon = value;
            }
            get
            {
                return _razon;
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
        #endregion
    }
}