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
    public partial class BuscarPorNombre : Form
    {
        public BuscarPorNombre()
        {
            InitializeComponent();
        }

        public class Salas
        {
            public int Sala { get; set; }
            public string Sucursal { get; set; }
            public string Pelicula { get; set; }
            public string Horario { get; set; }
        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener el nombre de la película a buscar
            string peliculaABuscar = txtPelicula.Text;

            // Crear una lista para almacenar las salas encontradas
            List<Salas> salasEncontradas = new List<Salas>();

            // Buscar en cada archivo de sala si hay una película con el nombre buscado
            string rutaSalas = @"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Salas";
            foreach (string archivoSala in Directory.GetFiles(rutaSalas))
            {
                // Leer los datos de la sala
                string[] datosSala = File.ReadAllLines(archivoSala);

                // Verificar si el nombre de la película coincide con la búsqueda
                if (datosSala[2].Split(':')[1].Trim().Equals(peliculaABuscar))
                {
                    // Crear un objeto Sala con los datos de la sala encontrada
                    Salas salaEncontrada = new Salas();
                    salaEncontrada.Sala = int.Parse(datosSala[0].Split(':')[1].Trim());
                    salaEncontrada.Sucursal = datosSala[1].Split(':')[1].Trim();
                    salaEncontrada.Pelicula = datosSala[2].Split(':')[1].Trim();
                    salaEncontrada.Horario = datosSala[3].Split(':')[1].Trim();

                    // Agregar la sala encontrada a la lista
                    salasEncontradas.Add(salaEncontrada);
                }
            }

            // Rellenar el DataGridView con las salas encontradas
            dataGridView1.DataSource = salasEncontradas;
        }
    }
}
