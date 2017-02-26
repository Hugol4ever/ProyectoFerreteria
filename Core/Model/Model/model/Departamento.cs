namespace Model
{
    class Departamento
    {
        #region "Atributos"
        private int _idDepartamento;
        private string _departamento;
        #endregion

        #region "Constructores"
        public Departamento()
        {

        }

        public Departamento(string departamento)
        {
            _departamento = departamento;
        }
        #endregion

        #region "Métodos accesibles"
        public int IdDepartamento
        {
            set
            {
                _idDepartamento = value;
            }
            get
            {
                return _idDepartamento;
            }
        }

        public string Departamentos
        {
            set
            {
                _departamento = value;
            }
            get
            {
                return _departamento;
            }
        }
        #endregion
    }
}