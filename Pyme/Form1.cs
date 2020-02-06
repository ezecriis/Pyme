using System;
using System.Windows.Forms;

namespace Pyme
{
    public partial class Form1 : Form
    {
        public static string[] EmpleadosApellido = new string[]
        {
            "GIANOTI",
            "PALACIOS",
            "PAGLINO",
            "SPALANZANI",
            "LEDESMA",
            "MADEO",
            "MUÑOZ",
            "QUIROGA"
       };
        public static string[] EmpleadosNombre = new string[]
        {
            "JOSE",
            "GERMAN",
            "DANIEL",
            "LUCIANO",
            "EZEQUIEL",
            "LEDESMA",
            "YESICA",
            "LUCIO"
       };
        public static string[] EmpleadosDomicilio = new string[]
        {
            "Lincoln 2155",
            "Gianastacio 2882",
            "Binon 3663",
            "Blas Parera 2478",
            "Arieta 3602",
            "Alma Fuerte 2410",
            "Balcarce 1668",
            "Gabriel Miró 2876"
       };
        public static string[] EmpleadosDni = new string[]
        {
            "38402970",
            "24028059",
            "22813049",
            "36626690",
            "35067040",
            "30280510",
            "29871488",
            "50153046"
       };
        public static int[] EmpleadosEmpleosAdeudada = new int[]
        {
           0,1,2,3,4,5,6,7

       };
        public static string[] Empleo = new string[]
        {
            "Lead",
            "Qa",
            "Desarrolador",
            "RRHU",
            "SSR",
            "Gerente",
            "Developer",
            "Principal"
       };
        public static string[] SocioApellido = new string[]
        {
            "GIANOTI",
            "PALACIOS",
            "PAGLINO",
            "SPALANZANI",
            "LEDESMA",
            "MADEO",
            "MUÑOZ",
            "QUIROGA"
       };
        public static string[] SocioNombre = new string[]
        {
            "JOSE",
            "GERMAN",
            "DANIEL",
            "LUCIANO",
            "EZEQUIEL",
            "LEDESMA",
            "YESICA",
            "LUCIO"
       };
        public static string[] SocioDomicilio = new string[]
        {
            "Lincoln 2155",
            "Gianastacio 2882",
            "Binon 3663",
            "Blas Parera 2478",
            "Arieta 3602",
            "Alma Fuerte 2410",
            "Balcarce 1668",
            "Gabriel Miró 2876"
       };
        public static string[] SocioDni = new string[]
        {
            "38402970",
            "24028059",
            "22813049",
            "36626690",
            "35067040",
            "30280510",
            "29871488",
            "50153046"
       };
        public static string[] SocioModulos = new string[]
        {
            "4",
            "5",
            "6",
            "13",
            "8",
            "3",
            "6",
            "8"
       };

        public static object Empleos { get; internal set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleado oFrmEmpleado = new FrmEmpleado();
            oFrmEmpleado.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificar oFrmModificar = new FrmModificar();
            oFrmModificar.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminar oFrmElimar = new FrmEliminar();
            oFrmElimar.Show();
        }

        private void nuevoSocioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSocio oFrmSocio = new FrmSocio();
            oFrmSocio.Show();
        }

        private void modificarSocioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSocioModificar oFrmSocioModificar = new FrmSocioModificar();
            oFrmSocioModificar.Show();
        }

        private void eliminarSocioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSocioEliminar oFrmSocioEliminar = new FrmSocioEliminar();
            oFrmSocioEliminar.Show();
        }
    }
}
