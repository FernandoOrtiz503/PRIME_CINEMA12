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
    public partial class BuscarPorSucursal : Form
    {
        public BuscarPorSucursal()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            string sucursalSeleccionada = comSucursal.SelectedItem.ToString();
            string rutaDirectorioSalas = @"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Salas\";
            string rutaDirectorioPeliculas = @"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Peliculas\";
            string[] archivosSalas = Directory.GetFiles(rutaDirectorioSalas);

            DataTable dt = new DataTable();
            dt.Columns.Add("Numero de sala");
            dt.Columns.Add("Nombre de la Sucursal");
            dt.Columns.Add("Nombre de la pelicula");
            dt.Columns.Add("Horario");

            foreach (string archivoSala in archivosSalas)
            {
                string[] lineasSala = File.ReadAllLines(archivoSala);
                string sucursal = lineasSala[1].Replace("Nombre de la Sucursal: ", "");

                if (sucursal == sucursalSeleccionada)
                {
                    DataRow dr = dt.NewRow();
                    dr["Numero de sala"] = lineasSala[0].Replace("Numero de sala: ", "");
                    dr["Nombre de la Sucursal"] = sucursal;
                    dr["Nombre de la pelicula"] = lineasSala[2].Replace("Nombre de la pelicula: ", "");
                    dr["Horario"] = lineasSala[3].Replace("Horario: ", "");

                    dt.Rows.Add(dr);
                }
            }

            dataGridView1.DataSource = dt;
        }

        private void BuscarPorSucursal_Load(object sender, EventArgs e)
        {
            string rutaDirectorio = @"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Salas\";
            string[] archivos = Directory.GetFiles(rutaDirectorio);

            HashSet<string> sucursales = new HashSet<string>();
            foreach (string archivo in archivos)
            {
                string[] lineas = File.ReadAllLines(archivo);
                string sucursal = lineas[1].Replace("Nombre de la Sucursal: ", "");
                sucursales.Add(sucursal);
            }

            comSucursal.Items.AddRange(sucursales.ToArray());
        }
    }
}
