namespace Model
{
    class Persona
    {

        #region "Atributos"
        protected int _idPersona;
        protected string _nombres;
        protected string _apellidos;
        protected string _colonia;
        protected string _calle;
        protected string _telefono;
        #endregion

        #region "Constructores"
        public Persona()
        {

        }

        public Persona(string nombres, string apellidos, string colonia, string calle, string telefono)
        {
            _nombres = nombres;
            _apellidos = apellidos;
            _colonia = colonia;
            _calle = calle;
            _telefono = telefono;
        }
        #endregion

        #region "Métodos accesibles"
        public int IdPersona
        {
            set
            {
                _idPersona = value;
            }
            get
            {
                return _idPersona;
            }
        }

        public string Nombres
        {
            set
            {
                _nombres = value;
            }
            get
            {
                return _nombres;
            }
        }

        public string Apellidos
        {
            set
            {
                _apellidos = value;
            }
            get
            {
                return _apellidos;
            }
        }

        public string Colonia
        {
            set
            {
                _colonia = value;
            }
            get
            {
                return _colonia;
            }
        }

        public string Calle
        {
            set
            {
                _calle = value;
            }
            get
            {
                return _calle;
            }
        }

        public string Telefono
        {
            set
            {
                _telefono = value;
            }
            get
            {
                return _telefono;
            }
        }
        #endregion
    }
}