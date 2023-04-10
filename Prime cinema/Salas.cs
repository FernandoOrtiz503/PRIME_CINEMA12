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
    public partial class Salas : Form
    {
        public Salas()
        {
            InitializeComponent();
        }

        private void btnAgragar_Click(object sender, EventArgs e)
        {
            // Verificar que la sala no exista aún
            string archivo = @"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Salas\" + txtNumero.Text + ".txt";
            if (File.Exists(archivo))
            {
                MessageBox.Show("La sala ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Crear el archivo de usuario
                using (TextWriter writer = new StreamWriter(archivo, true))
                {
                    writer.WriteLine($"Numero de sala: {txtNumero.Text}");
                    writer.WriteLine($"Nombre de la Sucursal: {comSucursal.SelectedItem.ToString()}");
                    writer.WriteLine($"Nombre de la Pelicula: {comPelicula.SelectedItem.ToString()}");
                    writer.WriteLine($"Horario: {txtHorario.Text}");
                }

                MessageBox.Show("Sala registrada correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos de entrada
                txtNumero.Clear();
                comSucursal.SelectedIndex = -1; // Reiniciar la selección del ComboBox
                comPelicula.SelectedIndex = -1; // Reiniciar la selección del ComboBox
                txtHorario.Clear();

                // Refrescar el DataGridView para mostrar los cambios
                Salas_Load(sender, e);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Ocurrió un error al crear el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        class Salas2
        {
            public string Numero { get; set; }
            public string NmbreSucursal { get; set; }
            public string Pelicula { get; set; }
            public string Horario { get; set; }
        }

        private void Salas_Load(object sender, EventArgs e)
        {
            // Limpiar el ComboBox
            comSucursal.Items.Clear();

            // Obtener la lista de archivos de sucursales
            string[] archivos1 = Directory.GetFiles(@"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Sucursales\", "*.txt");

            // Iterar por cada archivo y agregar el nombre de la sucursal al ComboBox
            foreach (string archivo in archivos1)
            {
                string nombre = Path.GetFileNameWithoutExtension(archivo);
                comSucursal.Items.Add(nombre);
            }


            // Limpiar el ComboBox
            comPelicula.Items.Clear();

            // Obtener la lista de archivos de peliculas
            string[] archivos2 = Directory.GetFiles(@"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Peliculas\", "*.txt");

            // Iterar por cada archivo y agregar el nombre de la peliculas al ComboBox
            foreach (string archivo in archivos2)
            {
                string nombre = Path.GetFileNameWithoutExtension(archivo);
                comPelicula.Items.Add(nombre);
            }

            // Crear una lista para almacenar las salas
            List<Salas2> salas = new List<Salas2>();

            // Obtener la ruta de la carpeta de salas
            string rutaSalass = @"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Salas";

            // Obtener la lista de archivos de la carpeta de salas
            string[] archivos = Directory.GetFiles(rutaSalass, "*.txt");

            // Para cada archivo, crear un objeto salas y agregarlo a la lista
            foreach (string archivo in archivos)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(archivo))
                    {
                        // Leer los detalles de la sacursal desde el archivo
                        string numero = reader.ReadLine()?.Split(':')[1].Trim();
                        string nombre = reader.ReadLine()?.Split(':')[1].Trim();
                        string epelicula = reader.ReadLine()?.Split(':')[1].Trim();
                        string horaio = reader.ReadLine()?.Split(':')[1].Trim();

                        // Crear un objeto Sacursal con los detalles leídos
                        Salas2 sala = new Salas2
                        {
                            Numero = numero,
                            NmbreSucursal = nombre,
                            Pelicula = epelicula,
                            Horario = horaio
                        };

                        // Agregar el objeto Sacursal a la lista
                        salas.Add(sala);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Ocurrió un error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Enlazar la lista de salas al DataGridView
            dataGridView1.DataSource = salas;

            // Verificar que la lista tenga datos
            if (salas.Count == 0)
            {
                MessageBox.Show("No se encontraron salas registradas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Actualizar el DataGridView para mostrar los cambios
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumero.Text = dataGridView1.SelectedCells[0].Value.ToString();
            
            txtHorario.Text = dataGridView1.SelectedCells[3].Value.ToString();
           
        

        }
    }
}
