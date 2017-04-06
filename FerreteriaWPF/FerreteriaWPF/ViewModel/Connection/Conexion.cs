using MySql.Data.MySqlClient;

namespace ViewModel
{
    public class Conexion
    {

        #region "Atributos"
        private MySqlConnectionStringBuilder _builder;
        private MySqlConnection _conn;
        #endregion

        #region "Constructores"
        public Conexion()
        {
            this._builder = new MySqlConnectionStringBuilder();
            this._builder.Server = Commons.SERVER;
            this._builder.UserID = Commons.USER;
            this._builder.Password = Commons.PASSWORD;
            this._builder.Database = Commons.DATABASE;

            this._conn = new MySqlConnection(this._builder.ToString());
        }
        #endregion

        #region "Métodos accesibles"
        public MySqlConnection getConnection
        {
            get
            {
                return _conn;
            }
        }
        #endregion

    }
}