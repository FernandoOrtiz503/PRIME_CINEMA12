using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_cinema
{
    public partial class Pago : Form
    {
        public Pago()
        {
            InitializeComponent();
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            // Limpiar el ComboBox
            comPelicula.Items.Clear();

            // Obtener la lista de archivos de salas
            string[] archivos = Directory.GetFiles(@"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Salas\", "*.txt");

            // Iterar por cada archivo
            foreach (string archivo in archivos)
            {
                // Leer el contenido del archivo
                string[] lineas = File.ReadAllLines(archivo);

                // Obtener el nombre de la película
                string nombrePelicula = lineas.FirstOrDefault(linea => linea.StartsWith("Nombre de la Pelicula:"))?.Replace("Nombre de la Pelicula:", "").Trim();

                // Si se encontró el nombre de la película, agregarlo al ComboBox
                if (!string.IsNullOrEmpty(nombrePelicula))
                {
                    comPelicula.Items.Add(nombrePelicula);
                }
            }

            // Limpiar el ComboBox
            comFormato.Items.Clear();

            // Obtener la lista de archivos de formatos
            string[] archivos1 = Directory.GetFiles(@"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Formato\", "*.txt");

            // Iterar por cada archivo
            foreach (string archivo in archivos1)
            {
                // Leer el contenido del archivo
                string[] lineas = File.ReadAllLines(archivo);

                // Obtener el nombre del formato
                string nombreFormato = lineas.FirstOrDefault(linea => linea.StartsWith("Formato:"))?.Replace("Formato:", "").Trim();

                // Si se encontró el nombre del formato, agregarlo al ComboBox
                if (!string.IsNullOrEmpty(nombreFormato))
                {
                    comFormato.Items.Add(nombreFormato);
                }
            }
        }

        private void comPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la película seleccionada
            string peliculaSeleccionada = comPelicula.SelectedItem.ToString();

            // Obtener la lista de archivos de salas
            string[] archivos = Directory.GetFiles(@"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Salas\", "*.txt");

            // Iterar por cada archivo
            foreach (string archivo in archivos)
            {
                // Leer el contenido del archivo
                string[] lineas = File.ReadAllLines(archivo);

                // Obtener el nombre de la película
                string nombrePelicula = lineas.FirstOrDefault(linea => linea.StartsWith("Nombre de la Pelicula:"))?.Replace("Nombre de la Pelicula:", "").Trim();

                // Si se encontró el nombre de la película, obtener los demás datos de la sala
                if (!string.IsNullOrEmpty(nombrePelicula) && nombrePelicula == peliculaSeleccionada)
                {
                    // Obtener el número de sala
                    string numeroSala = lineas.FirstOrDefault(linea => linea.StartsWith("Numero de sala:"))?.Replace("Numero de sala:", "").Trim();
                    txtSala.Text = numeroSala;

                    // Obtener el nombre de la sucursal
                    string nombreSucursal = lineas.FirstOrDefault(linea => linea.StartsWith("Nombre de la Sucursal:"))?.Replace("Nombre de la Sucursal:", "").Trim();
                    txtSucursal.Text = nombreSucursal;

                    // Obtener el horario
                    string horario = lineas.FirstOrDefault(linea => linea.StartsWith("Horario:"))?.Replace("Horario:", "").Trim();
                    txtHoraio.Text = horario;

                    // Salir del bucle porque ya se encontró la sala correspondiente
                    break;
                }
            }
        }

        private void comFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comFormato.SelectedItem.ToString() == "3D")
            {
                // Obtener el valor del costo de adulto tercera edad
                string archivo = @"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Peliculas\" + comPelicula.SelectedItem.ToString() + ".txt";
                if (File.Exists(archivo))
                {
                    using (var reader = new StreamReader(archivo))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Contains("Costo tercera edad 3D:"))
                            {
                                string[] costo = line.Split(':');
                                txtCedad.Text = costo[1].Trim();
                                break;
                            }
                        }
                    }
                }

                if (File.Exists(archivo))
                {
                    using (var reader = new StreamReader(archivo))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Contains("Costo Adultos 3D:"))
                            {
                                string[] costo = line.Split(':');
                                txtCadulto.Text = costo[1].Trim();
                                break;
                            }
                        }
                    }
                }
            }
            else if (comFormato.SelectedItem.ToString() == "Tradicional")
            {
                // Obtener el valor del costo de adulto tercera edad
                string archivo = @"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Peliculas\" + comPelicula.SelectedItem.ToString() + ".txt";
                if (File.Exists(archivo))
                {
                    using (var reader = new StreamReader(archivo))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Contains("Costo tercera edad N:"))
                            {
                                string[] costo = line.Split(':');
                                txtCedad.Text = costo[1].Trim();
                                break;
                            }
                        }
                    }
                }

                if (File.Exists(archivo))
                {
                    using (var reader = new StreamReader(archivo))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Contains("Costo Adultos N:"))
                            {
                                string[] costo = line.Split(':');
                                txtCadulto.Text = costo[1].Trim();
                                break;
                            }
                        }
                    }
                }
            }

            
        }

        private void txtCantidadE_TextChanged(object sender, EventArgs e)
        {
            double cantidad = 0;
            double factor = 0;
            double total = 0;

            // Obtener el valor de txtCantidadE como número
            if (double.TryParse(txtCantidadE.Text, out cantidad))
            {
                // Obtener el valor de txtCedad como número
                if (double.TryParse(txtCedad.Text, out factor))
                {
                    // Realizar la operación de multiplicación
                    total = cantidad * factor;

                    // Mostrar el resultado en txtTotal1
                    txtTotal1.Text = total.ToString();
                }
            }
        }

        private void txtCantidadA_TextChanged(object sender, EventArgs e)
        {
            double cantidad = 0;
            double factor = 0;
            double total = 0;

            // Obtener el valor de txtCantidadE como número
            if (double.TryParse(txtCantidadA.Text, out cantidad))
            {
                // Obtener el valor de txtCedad como número
                if (double.TryParse(txtCadulto.Text, out factor))
                {
                    // Realizar la operación de multiplicación
                    total = Math.Round(cantidad * factor, 2);

                    // Mostrar el resultado en txtTotal1
                    txtTotal2.Text = total.ToString();
                }
            }
        }

        private void txtTotal1_TextChanged(object sender, EventArgs e)
        {
            double cantidad = 0;
            double factor = 0;
            double total = 0;

            // Obtener el valor de txtCantidadE como número
            if (double.TryParse(txtTotal1.Text, out cantidad))
            {
                Debug.WriteLine("Cantidad: " + cantidad);

                // Obtener el valor de txtCedad como número
                if (double.TryParse(txtTotal2.Text, out factor))
                {
                    Debug.WriteLine("Factor: " + factor);

                    // Realizar la operación de suma
                    total = Math.Round(cantidad + factor, 2);

                    // Mostrar el resultado en TxtTO
                    TxtTO.Text = total.ToString();
                }
                else
                {
                    Debug.WriteLine("Error al obtener el valor de txtTotal2");
                    TxtTO.Text = "Error en total 2";
                }
            }
            else
            {
                Debug.WriteLine("Error al obtener el valor de txtTotal1");
                TxtTO.Text = "Error en total 1";
            }
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            double pago = 0;
            double total = 0;
            double cambio = 0;

            // Obtener el valor de txtPago como número
            if (double.TryParse(txtPago.Text, out pago))
            {
                // Obtener el valor de TxtTO como número
                if (double.TryParse(TxtTO.Text, out total))
                {
                    // Realizar la operación de resta
                    cambio = Math.Round(pago - total, 2);

                    // Mostrar el resultado en txtCambio
                    txtCambio.Text = cambio.ToString();
                }
            }
        }

     

        private void BtnBvtaca_Click(object sender, EventArgs e)
        {
            int cantidadE = int.Parse(txtCantidadE.Text);
            int cantidadA = int.Parse(txtCantidadA.Text);

            // Contar la cantidad de archivos de venta existentes
            int numVentas = Directory.GetFiles(@"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Ventas")
                .Count(f => Path.GetFileName(f).StartsWith("venta"));

            // Generar el nombre del archivo de venta actual
            string nombreArchivo = $"venta{numVentas + 1}.txt";

            // Obtener los valores de los controles
            string nombre = textBox5.Text;
            string pelicula = comPelicula.Text;
            string sala = txtSala.Text;
            string sucursal = txtSucursal.Text;
            string horario = txtHoraio.Text;
            string formato = comFormato.Text;
            string cantidadEntradasE = txtCantidadE.Text;
            string cantidadEntradasA = txtCantidadA.Text;
            string costoUnitarioE = txtCedad.Text;
            string costoUnitarioA = txtCadulto.Text;
            string totalE = txtTotal1.Text;
            string totalA = txtTotal2.Text;
            string montoTotal = TxtTO.Text;
            string pago = txtPago.Text;
            string cambio = txtCambio.Text;

            // Crear un objeto StreamWriter para escribir en el archivo
            using (StreamWriter writer = new StreamWriter($@"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Ventas\{nombreArchivo}", true))
            {
                // Escribir los valores en el archivo
                writer.WriteLine($"Nombre: {nombre}");
                writer.WriteLine($"Sala: {sala}");
                writer.WriteLine($"Sucursal: {sucursal}");
                writer.WriteLine($"Horario: {horario}");
                writer.WriteLine($"Película: {pelicula}");
                writer.WriteLine($"Formato: {formato}");
                writer.WriteLine($"Cantidad entradas E: {cantidadEntradasE}");
                writer.WriteLine($"Cantidad entradas A: {cantidadEntradasA}");
                writer.WriteLine($"Costo unitario E: {costoUnitarioE}");
                writer.WriteLine($"Costo unitario A: {costoUnitarioA}");
                writer.WriteLine($"Total E: {totalE}");
                writer.WriteLine($"Total A: {totalA}");
                writer.WriteLine($"Monto total: {montoTotal}");
                writer.WriteLine($"Pago: {pago}");
                writer.WriteLine($"Cambio: {cambio}");
                writer.WriteLine("----------------------------------");
            }
            // Mostrar un mensaje de éxito
            MessageBox.Show("Los datos han sido guardados correctamente.");

            Asientos frmAsientos = new Asientos(cantidadE, cantidadA);
            frmAsientos.ShowDialog();




        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            
        }

    }
}
