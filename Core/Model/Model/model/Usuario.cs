namespace Model
{
    class Usuario : Persona
    {
        #region "Atributos"
        private int _idUsuario;
        private string _user;
        private string _password;
        #endregion

        #region "Constructores"
        public Usuario()
        {

        }

        public Usuario(string user, string password)
        {
            _user = user;
            _password = password;
        }

        public Usuario(string nombres, string apellidos, string colonia, string calle, string telefono, string user, string password) : base(nombres, apellidos, colonia, calle, telefono)
        {
            _user = user;
            _password = password;
        }
        #endregion

        #region "Métodos accesibles"
        public int IdUsuario
        {
            set
            {
                _idUsuario = value;
            }
            get
            {
                return _idUsuario;
            }
        }

        public string User
        {
            set
            {
                _user = value;
            }
            get
            {
                return _user;
            }
        }

        public string Password
        {
            set
            {
                _password = value;
            }
            get
            {
                return _password;
            }
        }
        #endregion
    }
}