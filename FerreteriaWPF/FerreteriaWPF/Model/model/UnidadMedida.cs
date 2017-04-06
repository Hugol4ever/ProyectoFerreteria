namespace Model
{
    public class UnidadMedida
    {
        #region "Atributos"
        private int _idUnidadMedida;
        private string _unidadDeMedida;
        #endregion

        #region "Constructores"
        public UnidadMedida()
        {

        }

        public UnidadMedida(string tipoVenta)
        {
            _unidadDeMedida = tipoVenta;
        }
        #endregion

        #region "Métodos accesibles"
        public int IdUnidadMedida
        {
            set
            {
                _idUnidadMedida = value;
            }
            get
            {
                return _idUnidadMedida;
            }
        }

        public string UnidadDeMedida
        {
            set
            {
                _unidadDeMedida = value;
            }
            get
            {
                return _unidadDeMedida;
            }
        }
        #endregion
    }
}