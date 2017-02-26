namespace Model
{
    class Cliente : Persona
    {
        #region "Atributos"
        protected int _idCliente;
        protected double _limiteCredito;
        protected double _creditoDisponible;
        #endregion

        #region "Constructores"
        public Cliente()
        {

        }

        public Cliente(double limiteCredito, double creditoDisponible)
        {
            _limiteCredito = limiteCredito;
            _creditoDisponible = creditoDisponible;
        }

        public Cliente(string nombres, string apellidos, string colonia, string calle, string telefono, double limitCredito, double creditoDisponible) : base(nombres, apellidos, colonia, calle, telefono)
        {
            _limiteCredito = limitCredito;
            _creditoDisponible = creditoDisponible;
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