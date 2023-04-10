using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Prime_cinema
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Cierra el formm.
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            //Si está normal lo maximiza, si está maximizado vuelve normal.
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Si está normal lo minimiza, si está maximizado vuelve minimiza.
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Crea una instancia del nuevo formulario que deseas abrir
            Form formulario2 = new Form1();

            // Cierra el formulario actual
            this.Hide();


            // Muestra el nuevo formulario
            formulario2.ShowDialog();
        }

      

        private void btnLimpiarC_Click(object sender, EventArgs e)
        {
            txtContraseña.Clear();
            txtNombre.Clear();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre:")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre:";
                txtNombre.ForeColor = Color.Black;
                txtNombre.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña:")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {

            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña:";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.ForeColor = Color.DimGray;
            }
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            string archivo = @"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Usuarios\" + txtNombre.Text + ".txt";

            // Verificar que el archivo existe
            if (!File.Exists(archivo))
            {
                MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Leer las credenciales del archivo
            string[] lineas = File.ReadAllLines(archivo);
            string contraseñaGuardada = null;
            string rol = null;
            foreach (string linea in lineas)
            {
                if (linea.StartsWith("Contraseña:"))
                {
                    contraseñaGuardada = linea.Substring("Contraseña:".Length).Trim();
                }
                else if (linea.StartsWith("Rol:"))
                {
                    rol = linea.Substring("Rol:".Length).Trim();
                }
            }

            // Verificar que la contraseña coincide
            if (contraseñaGuardada == null || txtContraseña.Text != contraseñaGuardada)
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Iniciar sesión
            MessageBox.Show("Inicio de sesión exitoso", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Crea una instancia del nuevo formulario que deseas abrir
            Form formulario;
            if (rol == "Administrador")
            {
                formulario = new Menu1();
            }
            else
            {
                formulario = new publi();
            }

            // Cierra el formulario actual
            this.Hide();

            // Muestra el nuevo formulario
            formulario.ShowDialog();
        }
    }
}
