using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace codigo_inicial_proyecto
{
    public partial class RegistroForm : Form
    {
        string connectionString = "workstation id=generador_de_citas.mssql.somee.com;packet size=4096;user id=uts2025_SQLLogin_1;pwd=ueow787blr;data source=generador_de_citas.mssql.somee.com;persist security info=False;initial catalog=generador_de_citas;TrustServerCertificate=True";
        public RegistroForm()
        {
            InitializeComponent();
            this.Load += RegistroForm_Load;
        }
        private void RegistroForm_Load(object sender, EventArgs e)
        {
            cmbRol.Items.Add("Doctor");
            cmbRol.Items.Add("Paciente");
            cmbRol.Items.Add("Psicologo");
        }


        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text) || cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    //inserta un usuario nuevo en la base de datos
                    string query = "INSERT INTO Usuarios (usuario, contraseña, Rol) VALUES (@usuario, @contraseña, @rol)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@contraseña", txtContraseña.Text);
                        cmd.Parameters.AddWithValue("@rol", cmbRol.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Usuario registrado con éxito.");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al registrar el usuario ");
            }
        }
    }
}
