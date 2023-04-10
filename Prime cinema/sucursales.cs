using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_cinema
{
    public partial class sucursales : Form
    {
        public sucursales()
        {
            InitializeComponent();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre de la Sucursal:")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre de la Sucursal:";
                txtNombre.ForeColor = Color.Black;
                txtNombre.ForeColor = Color.DimGray;
            }
        }

        private void txtPersona_Enter(object sender, EventArgs e)
        {
            if (txtPersona.Text == "Nombre persona encargada:") 
            {
                txtPersona.Text = "";
                txtPersona.ForeColor = Color.Black;
            }
        }

        private void txtPersona_Leave(object sender, EventArgs e)
        {
            if (txtPersona.Text == "")
            {
                txtPersona.Text = "Nombre persona encargada:";
                txtPersona.ForeColor = Color.Black;
                txtPersona.ForeColor = Color.DimGray;
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


        private void button11_Click(object sender, EventArgs e)
        {
            // Verificar que La sucursal  no exista aún
            string archivo = @"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Sucursales\" + txtNombre.Text + ".txt";
            if (File.Exists(archivo))
            {
                MessageBox.Show("La sucursal ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Crear el archivo de usuario
                using (TextWriter writer = new StreamWriter(archivo, true))
                {
                    writer.WriteLine($"Nombre de la Sucursal: {txtNombre.Text}");
                    writer.WriteLine($"Nombre persona encargada: {txtPersona.Text}");
                    writer.WriteLine($"Direccion: {txtDireccion.Text}");
                    writer.WriteLine($"Teléfono: {txtTelefono.Text}");
                }

                MessageBox.Show("Sucursal registrada correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                // Limpiar los campos de entrada
                txtNombre.Clear();
                txtPersona.Clear();
                txtDireccion.Clear();
                txtTelefono.Clear();
                txtTelefono.Clear();

                // Refrescar el DataGridView para mostrar los cambios
                sucursales_Load(sender, e);


            }
            catch (IOException ex)
            {
                MessageBox.Show($"Ocurrió un error al crear el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        class Sucursal
        {
            public string Nombre { get; set; }
            public string PersonaEncargada { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
        }


        private void sucursales_Load(object sender, EventArgs e)
        {
            // Crear una lista para almacenar las sucursales
            List<Sucursal> sucursales = new List<Sucursal>();

            // Obtener la ruta de la carpeta de sucursales
            string rutaSucursales = @"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Sucursales";

            // Obtener la lista de archivos de la carpeta de sucursales
            string[] archivos = Directory.GetFiles(rutaSucursales, "*.txt");

            // Para cada archivo, crear un objeto Sucursal y agregarlo a la lista
            foreach (string archivo in archivos)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(archivo))
                    {
                        // Leer los detalles de la sucursal desde el archivo
                        string nombre = reader.ReadLine()?.Split(':')[1].Trim();
                        string persona = reader.ReadLine()?.Split(':')[1].Trim();
                        string direccion = reader.ReadLine()?.Split(':')[1].Trim();
                        string telefono = reader.ReadLine()?.Split(':')[1].Trim();

                        // Crear un objeto Sucursal con los detalles leídos
                        Sucursal sucursal = new Sucursal
                        {
                            Nombre = nombre,
                            PersonaEncargada = persona,
                            Direccion = direccion,
                            Telefono = telefono
                        };

                        // Agregar el objeto Sucursal a la lista
                        sucursales.Add(sucursal);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Ocurrió un error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Enlazar la lista de sucursales al DataGridView
            dataGridView1.DataSource = sucursales;

            // Verificar que la lista tenga datos
            if (sucursales.Count == 0)
            {
                MessageBox.Show("No se encontraron sucursales registradas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Actualizar el DataGridView para mostrar los cambios
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtPersona.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtDireccion.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtTelefono.Text = dataGridView1.SelectedCells[3].Value.ToString();

        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
