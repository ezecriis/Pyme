namespace Pyme
{
    public class Persona
    {
        #region Atributos
        private string _nombre;
        private string _apellido;
        private string _domicilio;
        private long _dni;

        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }
        public string Domicilio
        {
            get { return this._domicilio; }
            set { this._domicilio = value; }
        }
        public long Dni
        {
            get { return this._dni; }
            set { this._dni = value; }
        }

        #endregion

        #region Constructores
        public Persona()
        {
        }
        public Persona(string nombre, string apellido, string domicilio, long dni)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._domicilio = domicilio;
            this._dni = dni;
        }
        #endregion
    }
}