using System;
using System.Windows.Forms;

namespace codigo_inicial_proyecto
{
    public partial class SeleccionarCita : Form
    {
        public SeleccionarCita()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CitaPsic citaPsic = new CitaPsic();
            citaPsic.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CitaMed citaMed = new CitaMed();
            citaMed.Show();
        }
    }
}
