﻿using System;
using System.Windows.Forms;

namespace Pyme
{
    public partial class FrmSocioModificar : Form
    {
        int indiceBusqueda;
        int encontro;
        int indicePorcentaje; // toma indice dek combobox
        public FrmSocioModificar()
        {
            InitializeComponent();
        }

        private void FrmSocioModificar_Load(object sender, EventArgs e)
        {
            txtApellido.Enabled = false;
            txtDni.Enabled = false;
            txtDomicilio.Enabled = false;
            txtNombre.Enabled = false;
            btnModificar.Enabled = false;
            cmbPorcentajeLaboral.Enabled = false;

            for (int i = 0; i < Form1.Porcentajes.Length; i++)
            {
                // recorre el vector y lo carga en el combobox
                cmbPorcentajeLaboral.Items.Add(Form1.Porcentajes[i].ToString());
            }
        }
        private void cmbPuestoLaboral_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cmbPorcentajeLaboral_SelectedIndexChanged(object sender, EventArgs e)
        {
            indicePorcentaje = cmbPorcentajeLaboral.SelectedIndex;
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
                cmbPorcentajeLaboral.Enabled = true;
                txtApellido.Text = Form1.EmpleadosApellido[indiceBusqueda];
                txtNombre.Text = Form1.EmpleadosNombre[indiceBusqueda];
                txtDomicilio.Text = Form1.EmpleadosDomicilio[indiceBusqueda];
                txtDni.Text = Form1.EmpleadosDni[indiceBusqueda];
                cmbPorcentajeLaboral.Text = Form1.Porcentajes[Form1.PorcentajeSocios[indiceBusqueda]];
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Empleado oEmpleado = new Empleado(txtNombre.Text,
                                           txtApellido.Text,
                                           txtDomicilio.Text,
                                           Convert.ToInt64(txtDni.Text),
                                           indicePorcentaje
                                           );
            Form1.EmpleadosApellido[indiceBusqueda] = Convert.ToString(txtApellido.Text);
            Form1.EmpleadosNombre[indiceBusqueda] = Convert.ToString(txtNombre.Text);
            Form1.EmpleadosDomicilio[indiceBusqueda] = Convert.ToString(txtDomicilio.Text);
            Form1.EmpleadosDni[indiceBusqueda] = Convert.ToString(txtDni.Text);
            Form1.PorcentajeSocios[indiceBusqueda] = indicePorcentaje;
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            txtDni.Text = "";
            cmbPorcentajeLaboral.Text = "";
            txtApellido.Enabled = false;
            txtDni.Enabled = false;
            txtDomicilio.Enabled = false;
            txtNombre.Enabled = false;
            btnModificar.Enabled = false;
            cmbPorcentajeLaboral.Enabled = false;
            MessageBox.Show("Apellido: " + oEmpleado.Apellido + "\nNombre: " + oEmpleado.Nombre + "\nDomicilio: " + oEmpleado.Domicilio + "\nDni: " + oEmpleado.Dni + "\nPorcentaje en la empresa: " + Form1.Porcentajes[indicePorcentaje]);
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
        private void txtBusquedaApe_TextChanged(object sender, EventArgs e)
        {
            // txtBusquedaApe.Select();
        }

        private void FrmSocioModificar_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
