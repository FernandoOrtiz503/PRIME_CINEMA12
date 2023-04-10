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
    public partial class peliculas : Form
    {
        public peliculas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verificar que La sucursal  no exista aún
            string archivo = @"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Peliculas\" + txtNombre.Text + ".txt";
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
                    writer.WriteLine($"Nombre de la Pelicula: {txtNombre.Text}");
                    writer.WriteLine($"Genero de la pelucla: {txtGenero.Text}");
                    writer.WriteLine($"Clasificacion: {txtClase.Text}");
                    writer.WriteLine($"Costo Adultos N: {txtAdultoN.Text}");
                    writer.WriteLine($"Costo tercera edad N: {txtEdadN.Text}");
                    writer.WriteLine($"Costo Adultos 3D: {txtAdultos3d.Text}");
                    writer.WriteLine($"Costo tercera edad 3D: {txtEdad3d.Text}");

                }

                MessageBox.Show("Sucursal registrada correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Limpiar los campos de entrada
                txtNombre.Clear();
                txtGenero.Clear();
                txtClase.Clear();
                txtAdultoN.Clear();
                txtEdadN.Clear();
                txtAdultos3d.Clear();
                txtEdad3d.Clear();

                // Refrescar el DataGridView para mostrar los cambios
                peliculas_Load(sender, e);


            }
            catch (IOException ex)
            {
                MessageBox.Show($"Ocurrió un error al crear el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        class Peliculas
        {
            public string Pelicula { get; set; }
            public string Genero { get; set; }
            public string clasificacion { get; set; }
            public string Costo_adultos_normal { get; set; }
            public string Costo_tercera_edad_normal { get; set; }
            public string Costo_adultos_3D { get; set; }
            public string Costo_tercera_edad_3D { get; set; }
        }

     

        private void peliculas_Load(object sender, EventArgs e)
        {
            string carpeta = @"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Peliculas\";
            DataTable dt = new DataTable();

            // Crear las columnas del DataTable
            dt.Columns.Add("Nombre de la Pelicula");
            dt.Columns.Add("Genero de la pelucla");
            dt.Columns.Add("Clasificacion");
            dt.Columns.Add("Costo Adultos N");
            dt.Columns.Add("Costo tercera edad N");
            dt.Columns.Add("Costo Adultos 3D");
            dt.Columns.Add("Costo tercera edad 3D");

            // Leer los archivos de la carpeta Peliculas
            foreach (string archivo in Directory.GetFiles(carpeta))
            {
                if (Path.GetExtension(archivo) == ".txt")
                {
                    // Leer los datos del archivo y agregarlos al DataTable
                    using (StreamReader reader = new StreamReader(archivo))
                    {
                        DataRow row = dt.NewRow();
                        row["Nombre de la Pelicula"] = reader.ReadLine().Split(':')[1].Trim();
                        row["Genero de la pelucla"] = reader.ReadLine().Split(':')[1].Trim();
                        row["Clasificacion"] = reader.ReadLine().Split(':')[1].Trim();
                        string line = reader.ReadLine();
                        if (line != null && line.Contains(":"))
                        {
                            string[] parts = line.Split(new char[] { ':' }, 2);
                            if (parts.Length == 2)
                            {
                                string key = parts[0].Trim();
                                string value = parts[1].Trim();
                                row[key] = value;
                            }
                        }

                        row["Costo tercera edad N"] = reader.ReadLine().Split(new char[] { ':' }, 2)[1].Trim();
                        row["Costo Adultos 3D"] = reader.ReadLine().Split(new char[] { ':' }, 2)[1].Trim();
                        row["Costo tercera edad 3D"] = reader.ReadLine().Split(new char[] { ':' }, 2)[1].Trim();
                        //row["Costo Adultos N"] = reader.ReadLine().Split(new char[] { ':' }, 2)[1].Trim();
                        //row["Costo tercera edad N"] = reader.ReadLine().Split(':')[1].Trim();
                        //row["Costo Adultos 3D"] = reader.ReadLine().Split(':')[1].Trim();
                        //row["Costo tercera edad 3D"] = reader.ReadLine().Split(':')[1].Trim();
                        dt.Rows.Add(row);
                    }
                }
            }

            // Asignar el DataTable como origen de datos del DataGridView
            dataGridView1.DataSource = dt;
        }
    
    }
}
