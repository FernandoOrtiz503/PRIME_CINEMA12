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
    public partial class Asientos : Form
    {
        private int cantidadE;
        private int cantidadA;
        public string AsientosSeleccionados { get; set; }

        public Asientos(int cantidadE, int cantidadA)
        {
            InitializeComponent();
            this.cantidadE = cantidadE;
            this.cantidadA = cantidadA;

            for (int i = 1; i <= 40; i++)
            {
                Button btnAsiento = (Button)panel1.Controls.Find("btnAsiento" + i, true)[0];
                btnAsiento.Click += SeleccionarAsiento;
                btnAsiento.Enabled = false;
            }

            if (cantidadE > 0 || cantidadA > 0)
            {
                HabilitarAsientos();
            }
        }

        private int asientosSeleccionados = 0;

        private void SeleccionarAsiento(object sender, EventArgs e)
        {
            Button btnAsiento = (Button)sender;
            if (btnAsiento.BackColor == Color.Transparent)
            {
                if (asientosSeleccionados < cantidadE + cantidadA)
                {
                    btnAsiento.BackColor = Color.Gainsboro;
                    asientosSeleccionados++;
                }
            }
            else
            {
                btnAsiento.BackColor = Color.Transparent;
                asientosSeleccionados--;
            }

            HabilitarAsientos();


        }


        private void HabilitarAsientos()
        {
            for (int i = 1; i <= 40; i++)
            {
                Button btnAsiento = (Button)panel1.Controls.Find("btnAsiento" + i, true)[0];
                btnAsiento.Enabled = true;
            }

            int asientosHabilitados = 0;
            for (int i = 1; i <= 40; i++)
            {
                Button btnAsiento = (Button)panel1.Controls.Find("btnAsiento" + i, true)[0];
                if (btnAsiento.BackColor == Color.White)
                {
                    asientosHabilitados++;
                }
            }

            if (asientosHabilitados > cantidadE + cantidadA)
            {
                for (int i = 1; i <= 40; i++)
                {
                    Button btnAsiento = (Button)panel1.Controls.Find("btnAsiento" + i, true)[0];
                    if (btnAsiento.BackColor == Color.Transparent)
                    {
                        btnAsiento.Enabled = false;
                    }
                }
            }
        }

        private void btnAsiento1_Click(object sender, EventArgs e)
        {
            
        }


        private void btnComprar_Click(object sender, EventArgs e)
        {
            // Obtener los asientos seleccionados
            List<string> asientosSeleccionados = new List<string>();
            for (int i = 1; i <= 40; i++)
            {
                Button btnAsiento = (Button)panel1.Controls.Find("btnAsiento" + i, true)[0];
                if (btnAsiento.BackColor == Color.Gainsboro)
                {
                    asientosSeleccionados.Add(i.ToString());
                }
            }

            // Obtener el nombre del archivo de venta actual
            int numVentas = Directory.GetFiles(@"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Ventas")
                    .Count(f => Path.GetFileName(f).StartsWith("venta"));
            string nombreArchivo = $"venta{numVentas}.txt";

            // Guardar los asientos seleccionados en el archivo de venta
            using (StreamWriter writer = new StreamWriter($@"D:\ARCHIVOS!!\ESCRITORIO\prime_cinema\Prime cinema\Prime cinema\bin\Debug\Ventas\{nombreArchivo}", true))
            {
                writer.WriteLine("Asientos seleccionados:");
                foreach (string asiento in asientosSeleccionados)
                {
                    writer.WriteLine(asiento);
                }
                writer.WriteLine("----------------------------------");
            }
            MessageBox.Show($"Los asientos {string.Join(", ", asientosSeleccionados)} han sido comprados exitosamente.");
            this.Close();
        }
    }
}
