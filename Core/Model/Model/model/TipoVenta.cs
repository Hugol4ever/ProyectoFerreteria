namespace Model
{
    class TipoVenta
    {
        #region "Atributos"
        private int _idTipoVenta;
        private string _tipoDeVenta;
        #endregion

        #region "Constructores"
        public TipoVenta()
        {

        }

        public TipoVenta(string tipoVenta)
        {
            _tipoDeVenta = tipoVenta;
        }
        #endregion

        #region "Métodos accesibles"
        public int IdTipoVenta
        {
            set
            {
                _idTipoVenta = value;
            }
            get
            {
                return _idTipoVenta;
            }
        }

        public string TipoDeVenta
        {
            set
            {
                _tipoDeVenta = value;
            }
            get
            {
                return _tipoDeVenta;
            }
        }
        #endregion
    }
}