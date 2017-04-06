using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Perfiles
    {
        #region "Atributos"
        private int _idPerfil;
        private string _perfil;
        private Permisos _permisos;
        #endregion

        #region "Constructores"
        public Perfiles()
        {

        }

        public Perfiles(string perfil, Permisos permisos)
        {
            Perfil = perfil;
            Permisos = permisos;
        }
        #endregion

        #region "Métodos accesibles"
        public int IdPerfil
        {
            get
            {
                return _idPerfil;
            }

            set
            {
                _idPerfil = value;
            }
        }

        public string Perfil
        {
            get
            {
                return _perfil;
            }

            set
            {
                _perfil = value;
            }
        }

        public Permisos Permisos
        {
            get
            {
                return _permisos;
            }

            set
            {
                _permisos = value;
            }
        }
        #endregion
    }
}