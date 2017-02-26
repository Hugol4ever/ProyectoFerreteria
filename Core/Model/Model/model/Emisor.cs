namespace Model
{
    class Emisor : Persona
    {
        #region "Atributos"
        private int _idEmisor;
        private string _rfc;
        private string _correo;
        private int? _numeroInt;
        private int _numeroExt;
        private int _codigoPostal;
        private string _estado;
        private string _municipio;
        private string _regimen;
        private string _lugar;
        #endregion

        #region "Constructores"
        public Emisor()
        {

        }

        public Emisor(string rfc, string correo, int? numeroInt, int numeroExt, int codigoPostal, string estado, string municipio, string regimen, string lugar)
        {
            _rfc = rfc;
            _correo = correo;
            _numeroInt = numeroInt;
            _numeroExt = numeroExt;
            _codigoPostal = codigoPostal;
            _estado = estado;
            _municipio = municipio;
            _regimen = regimen;
            _lugar = lugar;
        }

        public Emisor(string rfc, string correo, int? numeroInt, int numeroExt, int codigoPostal, string estado, string municipio, string regimen, string lugar, string nombres, string apellidos, string colonia, string calle, string telefono) : base(nombres, apellidos, colonia, calle, telefono)
        {
            _rfc = rfc;
            _correo = correo;
            _numeroInt = numeroInt;
            _numeroExt = numeroExt;
            _codigoPostal = codigoPostal;
            _estado = estado;
            _municipio = municipio;
            _regimen = regimen;
            _lugar = lugar;
        }
        #endregion

        #region "Métodos accesibles"
        public int IdEmisor
        {
            set
            {
                _idEmisor = value;
            }
            get
            {
                return _idEmisor;
            }
        }

        public string Rfc
        {
            set
            {
                _rfc = value;
            }
            get
            {
                return _rfc;
            }
        }

        public string Correo
        {
            set
            {
                _correo = value;
            }
            get
            {
                return _correo;
            }
        }

        public int? NumeroInt
        {
            set
            {
                _numeroInt = value;
            }
            get
            {
                return _numeroInt;
            }
        }

        public int NumeroExt
        {
            set
            {
                _numeroExt = value;
            }
            get
            {
                return _numeroExt;
            }
        }

        public int CodigoPostal
        {
            set
            {
                _codigoPostal = value;
            }
            get
            {
                return _codigoPostal;
            }
        }

        public string Estado
        {
            set
            {
                _estado = value;
            }
            get
            {
                return _estado;
            }
        }

        public string Municipio
        {
            set
            {
                _municipio = value;
            }
            get
            {
                return _municipio;
            }
        }

        public string Regimen
        {
            set
            {
                _regimen = value;
            }
            get
            {
                return _regimen;
            }
        }

        public string Lugar
        {
            set
            {
                _lugar = value;
            }
            get
            {
                return _lugar;
            }
        }
        #endregion
    }
}