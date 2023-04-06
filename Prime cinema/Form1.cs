

namespace Prime_cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            //Cierra el form.
            this.Close();
        }

        private void max_Click(object sender, EventArgs e)
        {
            //Si está normal lo maximiza, si está maximizado vuelve normal.
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            //Si está normal lo minimiza, si está maximizado vuelve minimiza.
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Crea una instancia del nuevo formulario que deseas abrir
            Form formulario2 = new Form2();

            // Cierra el formulario actual
            this.Hide();

            // Abre el nuevo formulario
            formulario2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            // Crea una instancia del nuevo formulario que deseas abrir
            Form formulario2 = new Form3();

            // Cierra el formulario actual
            this.Hide();
      

            // Muestra el nuevo formulario
            formulario2.ShowDialog();

        }
    }
}