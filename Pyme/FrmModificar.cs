using System;
using System.Windows.Forms;

namespace Pyme
{
    public partial class FrmModificar : Form
    {
        int indiceBusqueda, encontro;
        int indicePuestoLaboral, indicePuestoBusqueda; // toma indice del combobox

        public FrmModificar()
        {
            InitializeComponent();
        }
        private void FrmModificar_Load(object sender, EventArgs e)
        {
            txtApellido.Enabled = false;
            txtDni.Enabled = false;
            txtDomicilio.Enabled = false;
            txtNombre.Enabled = false;
            btnModificar.Enabled = false;
            cmbPuestoLaboral.Enabled = false;

            for (int i = 0; i < Form1.Empleo.Length; i++)
            {
                // recorre el vector y lo carga en el combobox
                cmbPuestoLaboral.Items.Add(Form1.Empleo[i].ToString());
            }
        }
        private void cmbPuestoLaboral_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            indicePuestoLaboral = cmbPuestoLaboral.SelectedIndex;
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            encontro = 0;
            for (int i = 0; i < Form1.EmpleadosApellido.Length; i++)
            {
                if (txtBusquedaApe.Text == Form1.EmpleadosApellido[i])
                {
                    encontro = 1;
                    indiceBusqueda = i;
                }
            }
            if (encontro == 0)
            {
                MessageBox.Show("EL APELLIDO NO SE ENCUENTRA REGISTRADO");
            }
            else
            {
                txtBusquedaApe.Text = "";
                txtApellido.Enabled = true;
                txtDni.Enabled = true;
                txtDomicilio.Enabled = true;
                txtNombre.Enabled = true;
                btnModificar.Enabled = true;
                cmbPuestoLaboral.Enabled = true;
                txtApellido.Text = Form1.EmpleadosApellido[indiceBusqueda];
                txtNombre.Text = Form1.EmpleadosNombre[indiceBusqueda];
                txtDomicilio.Text = Form1.EmpleadosDomicilio[indiceBusqueda];
                txtDni.Text = Form1.EmpleadosDni[indiceBusqueda];


                indicePuestoBusqueda = Form1.PuestoEmpleados[indiceBusqueda];

                cmbPuestoLaboral.Text = Form1.Empleo[indicePuestoBusqueda];
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Empleado oEmpleado = new Empleado(txtNombre.Text,
                                           txtApellido.Text,
                                           txtDomicilio.Text,
                                           Convert.ToInt64(txtDni.Text),
                                           indicePuestoLaboral
                                           );
            Form1.EmpleadosApellido[indiceBusqueda] = Convert.ToString(txtApellido.Text);
            Form1.EmpleadosNombre[indiceBusqueda] = Convert.ToString(txtNombre.Text);
            Form1.EmpleadosDomicilio[indiceBusqueda] = Convert.ToString(txtDomicilio.Text);
            Form1.EmpleadosDni[indiceBusqueda] = Convert.ToString(txtDni.Text);
            Form1.PuestoEmpleados[indiceBusqueda] = indicePuestoLaboral;
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            txtDni.Text = "";
            cmbPuestoLaboral.Text = "";
            txtApellido.Enabled = false;
            txtDni.Enabled = false;
            txtDomicilio.Enabled = false;
            txtNombre.Enabled = false;
            btnModificar.Enabled = false;
            cmbPuestoLaboral.Enabled = false;
            MessageBox.Show("Apellido: " + oEmpleado.Apellido + "\nNombre: " + oEmpleado.Nombre + "\nDomicilio: " + oEmpleado.Domicilio + "\nDni: " + oEmpleado.Dni + "\nEl puesto laboral es: " + Form1.Empleo[indicePuestoLaboral]);
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtBusquedaApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnBuscar.Focus();
            }
        }
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnBuscar_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnModificar_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextAlignChanged(object sender, EventArgs e)
        {
        }
        private void btnAtras_TabStopChanged(object sender, EventArgs e)
        {
        }

        private void txtBusquedaApe_Click(object sender, EventArgs e)
        {
        }
    }
}
