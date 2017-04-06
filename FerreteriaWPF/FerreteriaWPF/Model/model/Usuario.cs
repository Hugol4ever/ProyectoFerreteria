namespace Model
{
    public class Usuario : Persona
    {
        #region "Atributos"
        private int _idUsuario;
        private string _user;
        private string _password;
        private Perfiles _perfil;
        #endregion

        #region "Constructores"
        public Usuario()
        {

        }

        public Usuario(string user, string password, Perfiles perfil)
        {
            _user = user;
            _password = password;
            _perfil = perfil;
        }

        public Usuario(string nombres, string apellidos, string colonia, string calle, string telefono, string user, string password, Perfiles perfil) : base(nombres, apellidos, colonia, calle, telefono)
        {
            _user = user;
            _password = password;
            _perfil = perfil;
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

        public Perfiles Perfil
        {
            set
            {
                _perfil = value;
            }
            get
            {
                return _perfil;
            }
        }
        #endregion
    }
}