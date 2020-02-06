namespace Pyme
{
    public class Empleado : Persona
    {
        #region Atributos
        private int _indiceEmpleo;
        #endregion 


        #region propiedades

        public int IndiceEmpleo
        {
            get { return this._indiceEmpleo; }
            set { this._indiceEmpleo = value; }
        }
        #endregion
        #region Constructores
        public Empleado()
            : base()
        { }
        public Empleado(string nombre, string apellido, string domicilio, long dni, int IndiceEmpleo)
            : base(nombre, apellido, domicilio, dni)
        {
            this._indiceEmpleo = IndiceEmpleo;
        }
        #endregion
    }
}