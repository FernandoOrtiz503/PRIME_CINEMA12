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
    public partial class publi : Form
    {
        public publi()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Cierra el form.
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {

            //Si está normal lo maximiza, si está maximizado vuelve normal.
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            //Si está normal lo minimiza, si está maximizado vuelve minimiza.
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Crea una instancia del nuevo formulario que deseas abrir
            Form formulario2 = new Form1();

            // Cierra el formulario actual
            this.Hide();


            // Muestra el nuevo formulario
            formulario2.ShowDialog();
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelprin.Controls.Count > 0)
                this.panelprin.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelprin.Controls.Add(fh);
            this.panelprin.Tag = fh;
            fh.Show();

        }

        private void btnbuscanom_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new BuscarPorNombre());
        }

        private void btnmostcart_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Cartelera());
        }

        private void btnbussucu_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new BuscarPorSucursal());
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new inicio2());
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Pago());
        }
    }
}
