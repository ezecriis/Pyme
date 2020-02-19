using System;
using System.Windows.Forms;

namespace Pyme
{
    public partial class Form1 : Form
    {
        // combo box opcionales
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
        public static string[] Porcentajes = new string[]
        {
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "70%",
            "90%",
            "100%"
        };
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
            "CARLA",
            "YESICA",
            "LUCIO"
       };
        public static string[] EmpleadosDomicilio = new string[]
        {
            "Lincoln 2155",
            "Gianastacio 2882",
            "Binon 3663",
            "Blas Parera 2478",
            "Balcarce 1668",
            "Arieta 3602",
            "Alma Fuerte 2410",
            "Gabriel Miró 2876"
       };
        public static string[] EmpleadosDni = new string[]
        {
            "24028059",
            "22813049",
            "36626690",
            "35067040",
            "38402970",
            "30280510",
            "29871488",
            "50153046"
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
            "Balcarce 1668",
            "Arieta 3602",
            "Alma Fuerte 2410",
            "Gabriel Miró 2876"
       };
        public static string[] SocioDni = new string[]
        {
            "24028059",
            "22813049",
            "36626690",
            "35067040",
            "38402970",
            "30280510",
            "29871488",
            "50153046"
       };
        public static int[] PorcentajeSocios = new int[]
        {
            0,1,2,3,4,5,6,7
        };
        public static int[] PuestoEmpleados = new int[]
        {
            0,1,2,3,4,5,6,7
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

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
