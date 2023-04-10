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
    public partial class Menu1 : Form
    {
        public Menu1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Cierra el form.
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            //Si está normal lo maximiza, si está maximizado vuelve normal.
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Si está normal lo minimiza, si está maximizado vuelve minimiza.
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.conteee.Controls.Count > 0)
                this.conteee.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.conteee.Controls.Add(fh);
            this.conteee.Tag = fh;
            fh.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new sucursales());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Salas());
        }

        private void btnpeliculas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new peliculas());
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Inicio());
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
    }
}
