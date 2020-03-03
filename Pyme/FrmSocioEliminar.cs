using System;
using System.Windows.Forms;

namespace Pyme
{
    public partial class FrmSocioEliminar : Form
    {
        int indiceBusqueda;
        int encontro;
        public FrmSocioEliminar()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmSocioEliminar_Load(object sender, EventArgs e)
        {
            txtApellido.Enabled = false;
            txtDni.Enabled = false;
            txtDomicilio.Enabled = false;
            txtNombre.Enabled = false;
            btnEliminar.Enabled = false;
            cmbPorcentajeLaboral.Enabled = false;

            for (int i = 0; i < Form1.Porcentajes.Length; i++)
            {
                // recorre el vector y lo carga en el combobox
                cmbPorcentajeLaboral.Items.Add(Form1.Porcentajes[i].ToString());
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            encontro = 0;
            for (int i = 0; i < Form1.EmpleadosApellido.Length; i++)
            {
                if (txtBuscaApe.Text == Form1.EmpleadosApellido[i])
                {
                    encontro = 1;
                    indiceBusqueda = i;
                }
            }
            if (encontro == 0)
            {
                txtBuscaApe.Text = "";
                MessageBox.Show("EL APELLIDO NO SE ENCUENTRA REGISTRADO");
            }
            else
            {
                txtBuscaApe.Text = "";
                btnEliminar.Enabled = true;
                txtApellido.Text = Form1.EmpleadosApellido[indiceBusqueda];
                txtNombre.Text = Form1.EmpleadosNombre[indiceBusqueda];
                txtDomicilio.Text = Form1.EmpleadosDomicilio[indiceBusqueda];
                txtDni.Text = Form1.EmpleadosDni[indiceBusqueda];
                cmbPorcentajeLaboral.Text = Form1.Porcentajes[Form1.PorcentajeSocios[indiceBusqueda]];
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Empleado oEmpleado = new Empleado(txtNombre.Text,
                                          txtApellido.Text,
                                          txtDomicilio.Text,
                                          Convert.ToInt64(txtDni.Text),
                                          indiceBusqueda
                                          );
            Form1.EmpleadosApellido[indiceBusqueda] = "";
            Form1.EmpleadosNombre[indiceBusqueda] = "";
            Form1.EmpleadosDomicilio[indiceBusqueda] = "";
            Form1.EmpleadosDni[indiceBusqueda] = "";
            Form1.PorcentajeSocios[indiceBusqueda] = 0;
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            txtDni.Text = "";
            cmbPorcentajeLaboral.Text = "";
            btnEliminar.Enabled = false;
            MessageBox.Show("REGISTRO ELIMINADO");
        }

        private void txtBuscaApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnBuscar.Focus();
            }
        }
    }
}
