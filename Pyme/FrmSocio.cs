using System;
using System.Windows.Forms;

namespace Pyme
{
    public partial class FrmSocio : Form
    {
        int indicePorcentaje;
        int largo;
       
        public FrmSocio()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSocio_Load(object sender, EventArgs e)
        {
            // toma el largo actual del vector
            largo = Form1.EmpleadosApellido.Length;
            for (int i = 0; i < Form1.Empleo.Length; i++)
            {
                // recorre el vector y lo carga en el combobox
                cmbPorcentaje.Items.Add(Form1.Porcentajes[i].ToString());
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Validate();

            if ((txtNombre.Text != "") && (txtApellido.Text != "") && (txtDni.Text != "") && (txtDomicilio.Text != ""))
            {

                Empleado oEmpleado = new Empleado(txtNombre.Text,
                                           txtApellido.Text,
                                           txtDomicilio.Text,
                                           Convert.ToInt64(txtDni.Text),
                                           indicePorcentaje
                                           );
                Form1.EmpleadosApellido[largo - 1] = Convert.ToString(txtApellido.Text);
                Form1.EmpleadosNombre[largo - 1] = Convert.ToString(txtNombre.Text);
                Form1.EmpleadosDomicilio[largo - 1] = Convert.ToString(txtDomicilio.Text);
                Form1.EmpleadosDni[largo - 1] = Convert.ToString(txtDni.Text);
                Form1.PorcentajeSocios[largo - 1] = indicePorcentaje;
                txtApellido.Text = "";
                txtNombre.Text = "";
                txtDomicilio.Text = "";
                txtDni.Text = "";
                MessageBox.Show("Apellido: " + oEmpleado.Apellido + "\nNombre: " + oEmpleado.Nombre + "\nDomicilio: " + oEmpleado.Domicilio + "\nDni: " + oEmpleado.Dni + "\nPorcentaje de la empresa: " + Form1.Porcentajes[indicePorcentaje]);
            }
        }

        private void cmbPorcentaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            // guarda el indice del item seleccionado
            indicePorcentaje = cmbPorcentaje.SelectedIndex;
        }

        public new void Validate()
        {
            if ((txtNombre.Text == "") && (txtApellido.Text == "") && (txtDni.Text == "") && (txtDomicilio.Text == ""))
            {
                MessageBox.Show("Complete los campos! ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras! ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras! ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                e.Handled = true;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permiten numeros! ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDni.Focus();
                e.Handled = true;
            }
        }
    }
}
