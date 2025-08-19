using System;
using System.Windows.Forms;

namespace codigo_inicial_proyecto
{
    public partial class RolPacientecs : Form
    {
        public RolPacientecs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeleccionarCita seleccionarCita = new SeleccionarCita();
            seleccionarCita.Show();

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
