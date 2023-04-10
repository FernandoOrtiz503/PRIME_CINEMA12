using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Prime_cinema.BuscarPorNombre;

namespace Prime_cinema
{
    public partial class Cartelera : Form
    {
        public Cartelera()
        {
            InitializeComponent();
        }

        private void Cartelera_Load(object sender, EventArgs e)
        {
            // Crear una lista para almacenar las salas
            List<Sala> salas = new List<Sala>();

            // Obtener la ruta de la carpeta de salas
            string rutaSalas = @"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Salas";

            // Obtener la lista de archivos de la carpeta de salas
            string[] archivos = Directory.GetFiles(rutaSalas, "*.txt");

            // Para cada archivo, crear un objeto Sala y agregarlo a la lista
            foreach (string archivo in archivos)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(archivo))
                    {
                        // Leer los detalles de la sala desde el archivo
                        string numero = reader.ReadLine()?.Split(':')[1].Trim();
                        string sucursal = reader.ReadLine()?.Split(':')[1].Trim();
                        string pelicula = reader.ReadLine()?.Split(':')[1].Trim();
                        string horario = reader.ReadLine()?.Split(':')[1].Trim();

                        // Crear un objeto Sala con los detalles leídos
                        Sala sala = new Sala
                        {
                            Numero = numero,
                            Sucursal = sucursal,
                            Pelicula = pelicula,
                            Horario = horario
                        };

                        // Agregar el objeto Sala a la lista
                        salas.Add(sala);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Ocurrió un error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Asignar la lista de salas al objeto DataSource del DataGridView
            dataGridView1.DataSource = salas;
        }

        public class Sala
        {
            public string Numero { get; set; }
            public string Sucursal { get; set; }
            public string Pelicula { get; set; }
            public string Horario { get; set; }
        }
    }
}
