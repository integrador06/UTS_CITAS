using codigo_inicial_proyecto.pantalla_consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codigo_inicial_proyecto
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        
        string connectionString = "workstation id=generador_de_citas.mssql.somee.com;packet size=4096;user id=uts2025_SQLLogin_1;pwd=ueow787blr;data source=generador_de_citas.mssql.somee.com;persist security info=False;initial catalog=generador_de_citas;TrustServerCertificate=True";

        private void btnIniciarSecion_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txt_usuario.Text) || string.IsNullOrWhiteSpace(txt_contraseña.Text))
            {
                MessageBox.Show("Ingrese usuario y contraseña.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT Rol FROM Usuarios WHERE Usuario = @usuario AND Contraseña = @contraseña";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", txt_usuario.Text);
                        cmd.Parameters.AddWithValue("@contraseña", txt_contraseña.Text);

                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string rol = result.ToString();
                            MessageBox.Show("Login exitoso. Rol: " + rol);

                            // para añadir nuevo usuario
                            // Aquí puedes abrir el formulario correspondiente según el rol
                            if (rol == "Doctor")
                            {
                                //formulario doctor
                            }
                            else if (rol == "Paciente")
                            {
                                //formulario de Paciente
                                RolPacientecs rolPacientecs = new RolPacientecs();
                                rolPacientecs.Show();
                             

                            }
                            else if (rol == "Psicologo")
                            {
                                //formulario de Psicologo

                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.");
                        }
                    }
                }
            }
            catch (Exception )
            {
                MessageBox.Show("ERROR AL INICIAR SECION");
            }
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {

            RegistroForm registro = new RegistroForm();
            registro.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

