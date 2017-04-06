namespace Model
{
    public class TipoVenta
    {
        #region "Atributos"
        private int _idTipoVenta;
        private string _tipoDeVenta;
        private bool _activo;
        #endregion

        #region "Constructores"
        public TipoVenta()
        {

        }

        public TipoVenta(string tipoVenta, bool activo)
        {
            _tipoDeVenta = tipoVenta;
            _activo = activo;
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

        public bool Activo
        {
            set
            {
                _activo = value;
            }
            get
            {
                return _activo;
            }
        }
        #endregion
    }
}