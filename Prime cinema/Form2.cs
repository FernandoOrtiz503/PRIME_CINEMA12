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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            //Cierra el form.
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
            txtCorreo.Clear();
            txtDui.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
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

        private void txtDui_Enter(object sender, EventArgs e)
        {
            if (txtDui.Text == "Dui:")
            {
                txtDui.Text = "";
                txtDui.ForeColor = Color.Black;
            }
        }

        private void txtDui_Leave(object sender, EventArgs e)
        {

            if (txtDui.Text == "")
            {
                txtDui.Text = "Dui:";
                txtDui.ForeColor = Color.Black;
                txtDui.ForeColor = Color.DimGray;
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Direccion:")
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.Black;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "Direccion:";
                txtDireccion.ForeColor = Color.Black;
                txtDireccion.ForeColor = Color.DimGray;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono:")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Telefono:";
                txtTelefono.ForeColor = Color.Black;
                txtTelefono.ForeColor = Color.DimGray;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo:")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo:";
                txtCorreo.ForeColor = Color.Black;
                txtCorreo.ForeColor = Color.DimGray;
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


        private bool ExisteDui(string dui)
        {
            string[] archivos = Directory.GetFiles(@"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Usuarios\", "*.txt");
            foreach (string archivo in archivos)
            {
                using (TextReader reader = new StreamReader(archivo))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        if (linea.StartsWith("DUI:") && linea.Substring(4).Trim() == dui)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private void btnRegristrar_Click(object sender, EventArgs e)
        {

            // Verificar que el usuario no existe aún
            string archivo = @"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Usuarios\" + txtNombre.Text + ".txt";
            if (File.Exists(archivo))
            {
                MessageBox.Show("El usuario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar que el DUI no esté registrado
            if (ExisteDui(txtDui.Text))
            {
                MessageBox.Show("El DUI ingresado ya está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Crear el archivo de usuario
                using (TextWriter writer = new StreamWriter(archivo, true))
                {
                    writer.WriteLine($"Contraseña: {txtContraseña.Text}");
                    writer.WriteLine($"Correo electrónico: {txtCorreo.Text}");
                    writer.WriteLine($"DUI: {txtDui.Text}");
                    writer.WriteLine($"Teléfono: {txtTelefono.Text}");
                    writer.WriteLine($"Dirección: {txtDireccion.Text}");

                    // Agregar el rol de usuario normal
                    writer.WriteLine("Rol: Usuario");
                }

                MessageBox.Show("Usuario registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos de entrada
                txtContraseña.Clear();
                txtCorreo.Clear();
                txtDui.Clear();
                txtTelefono.Clear();
                txtDireccion.Clear();
                txtNombre.Clear();
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Ocurrió un error al crear el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    } 
}
