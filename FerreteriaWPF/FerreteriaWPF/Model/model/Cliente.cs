namespace Model
{
    public class Cliente : Persona
    {
        #region "Atributos"
        protected int _idCliente;
        protected double _limiteCredito;
        protected double _creditoDisponible;
        protected bool _activo;
        #endregion

        #region "Constructores"
        public Cliente()
        {

        }

        public Cliente(double limiteCredito, double creditoDisponible, bool activo)
        {
            _limiteCredito = limiteCredito;
            _creditoDisponible = creditoDisponible;
            _activo = activo;
        }

        public Cliente(string nombres, string apellidos, string colonia, string calle, string telefono, double limitCredito, double creditoDisponible, bool activo) : base(nombres, apellidos, colonia, calle, telefono)
        {
            _limiteCredito = limitCredito;
            _creditoDisponible = creditoDisponible;
            _activo = activo;
        }
        #endregion

        #region "Métodos accesibles"
        public int IdCliente
        {
            set
            {
                _idCliente = value;
            }
            get
            {
                return _idCliente;
            }
        }

        public double LimiteCredito
        {
            set
            {
                _limiteCredito = value;
            }
            get
            {
                return _limiteCredito;
            }
        }

        public double CreditoDisponible
        {
            set
            {
                _creditoDisponible = value;
            }
            get
            {
                return _creditoDisponible;
            }
        }
        #endregion
    }
}