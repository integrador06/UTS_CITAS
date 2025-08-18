using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace EspecialistaPROYECTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LlenarGrid();
        }


        string connectionString = "workstation id=generador_de_citas.mssql.somee.com;packet size=4096;user id=uts2025_SQLLogin_1;pwd=ueow787blr;data source=generador_de_citas.mssql.somee.com;persist security info=False;initial catalog=generador_de_citas;TrustServerCertificate=True";

        private void LlenarGrid()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT id, nombre, especialidad, fecha FROM Especialista";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);


                    Grid.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        
        private void buttonSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonELIMINAR_Click(object sender, EventArgs e)
        {
            if (Grid.SelectedRows.Count > 0)
            {

                int idSeleccionado = Convert.ToInt32(Grid.SelectedRows[0].Cells[0].Value);


                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar ?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    string connectionString = "workstation id=generador_de_citas.mssql.somee.com;packet size=4096;user id=uts2025_SQLLogin_1;pwd=ueow787blr;data source=generador_de_citas.mssql.somee.com;persist security info=False;initial catalog=generador_de_citas;TrustServerCertificate=True";
                    string sqlQuery = "DELETE FROM Especialista WHERE id = @id";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                            {
                                command.Parameters.AddWithValue("@id", idSeleccionado);
                                command.ExecuteNonQuery();

                                MessageBox.Show("eliminado correctamente.");


                                LlenarGrid();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"NO SE ELIMINO : {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        

        }

        void Limpiar()
        {

            txtNombre.Text = "";
            txtEspecialidad.Text = "";


        }
        

        private void buttonNUEVO_Click(object sender, EventArgs e)
        {

            Limpiar();
        }

        private void buttonGUARDAR_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    string nombre = txtNombre.Text;
                    string especialidad = txtEspecialidad.Text;
                    DateTime fecha = dtpFecha.Value;

                    string sqlQuery = "INSERT INTO Especialista(nombre, especialidad, fecha) VALUES (@nombre, @especialidad, @fecha)";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@especialidad", especialidad);
                        command.Parameters.AddWithValue("@fecha", fecha);


                        command.ExecuteNonQuery();

                        MessageBox.Show("¡Datos guardados correctamente!");


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al guardar los datos: {ex.Message}");
                }
            }
        }
    }
    
}
