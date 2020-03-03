using System;
using System.Windows.Forms;

namespace Pyme
{
    public partial class FrmEmpleado : Form
    {
        int indiceEmpleo;
        int largo;
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void cmbPuestoLaboral_SelectedIndexChanged(object sender, EventArgs e)
        {
            // guarda el indice del item seleccionado
            indiceEmpleo = cmbPuestoLaboral.SelectedIndex;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            // toma el largo actual del vector
            largo = Form1.EmpleadosApellido.Length;
            for (int i = 0; i < Form1.Empleo.Length; i++)
            {
                // recorre el vector y lo carga en el combobox
                cmbPuestoLaboral.Items.Add(Form1.Empleo[i].ToString());
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
                                               indiceEmpleo
                                               );
                Form1.EmpleadosApellido[largo - 1] = Convert.ToString(txtApellido.Text);
                Form1.EmpleadosNombre[largo - 1] = Convert.ToString(txtNombre.Text);
                Form1.EmpleadosDomicilio[largo - 1] = Convert.ToString(txtDomicilio.Text);
                Form1.EmpleadosDni[largo - 1] = Convert.ToString(txtDni.Text);
                Form1.PuestoEmpleados[largo - 1] = indiceEmpleo;
                txtApellido.Text = "";
                txtNombre.Text = "";
                txtDomicilio.Text = "";
                txtDni.Text = "";
                MessageBox.Show("Apellido: " + oEmpleado.Apellido + "\nNombre: " + oEmpleado.Nombre + "\nDomicilio: " + oEmpleado.Domicilio + "\nDni: " + oEmpleado.Dni + "\nPuesto de trabajo: " + Form1.Empleo[indiceEmpleo]);
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
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
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

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            if(txtNombre.Text.Trim() == "")
            {
                epError.SetError(txtNombre, "Introduzca el nombre..");
                txtNombre.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
        private void txtApellido_Validated(object sender, EventArgs e)
        {
            if (txtApellido.Text.Trim() == "")
            {
                epError.SetError(txtApellido, "Introduzca el apellido..");
                txtApellido.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtDni_Validated(object sender, EventArgs e)
        {
            if (txtDni.Text.Trim() == "")
            {
                epError.SetError(txtDni, "Introduzca el DNI..");
                txtDni.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtDomicilio_Validated(object sender, EventArgs e)
        {
            if (txtDomicilio.Text.Trim() == "")
            {
                epError.SetError(txtDomicilio, "Introduzca el domicilio..");
                txtDomicilio.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        public new void Validate()
        {
            if((txtNombre.Text == "") && (txtApellido.Text == "") && (txtDni.Text == "") && (txtDomicilio.Text == ""))
            {
                MessageBox.Show("Complete los campos! ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
            }
        }
    }
}
