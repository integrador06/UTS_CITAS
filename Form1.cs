using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pantalla_consulta
{
    public partial class Form1 : Form
    {
        static consultaControlador controlador = new consultaControlador();
        string connectionString = "workstation id=generador_de_citas.mssql.somee.com;packet size=4096;user id=uts2025_SQLLogin_1;pwd=ueow787blr;data source=generador_de_citas.mssql.somee.com;persist security info=False;initial catalog=generador_de_citas;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }
        private void CargarConsultas()
        {
            dgv_listar_consultas.DataSource = controlador.ListarConsultas();
            dgv_listar_consultas.ClearSelection();
        }
        private void LimpiarCampos()
        {
            txt_IDconsulta.Clear();
            txtNombrePaci.Clear();
            txt_nombreEsp.Clear();
            dtTIME_fechaConsulta.Value = DateTime.Today;
            txt_motivoConsult.Clear();
            txt_Diagnostico.Clear();
            txt_trataOmedicamento.Clear();
            txtobservacionAdi.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarConsultas();
        }

        private void btn_guardarConsulta_Click(object sender, EventArgs e)
        {

            int idIngresadoPorUsuario = int.Parse(txt_IDconsulta.Text);
            bool idExiste;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Comando para verificar si el ID existe
                using (SqlConnection connn= new SqlConnection(connectionString))
                {


                    // Corregido: nombre de columna correcto
                    using (SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM consulta WHERE con_Id = @id", conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@id", idIngresadoPorUsuario);
                        idExiste = (int)cmdCheck.ExecuteScalar() > 0;
                    }

                    if (idExiste)
                    {
                        MessageBox.Show("El ID ya existe, elige otro.");
                    }
                    else
                    {
                        consulta nuevaConsulta = new consulta
                        {
                            Con_nombre_paciente = txtNombrePaci.Text,
                            Con_nombre_especialista = txt_nombreEsp.Text,
                            Con_fecha = dtTIME_fechaConsulta.Value.Date,
                            Con_hora = DateTime.Now.TimeOfDay, // si quieres capturar hora actual
                            Con_motivo_consulta = txt_motivoConsult.Text,
                            Con_diagnostico = txt_Diagnostico.Text,
                            Con_tratamiento_medicamento = txt_trataOmedicamento.Text,
                            Con_observaciones_adicionales = txtobservacionAdi.Text
                        };



                        // Llamar al método para guardar
                        bool exito = controlador.AgregarConsulta(nuevaConsulta);

                        if (exito)
                        {
                            MessageBox.Show("Consulta guardada exitosamente.");
                            

                        }
                        else
                        {
                            MessageBox.Show("Error al guardar la consulta.");
                        }


                    }

                }

            }


        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
          this.Close(); 
        }

        private void dgv_listar_consultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // evita clicks en encabezado
            {
                DataGridViewRow fila = dgv_listar_consultas.Rows[e.RowIndex];

                txt_IDconsulta.Text = fila.Cells["con_Id"].Value.ToString();
                txtNombrePaci.Text = fila.Cells["con_nombre_paciente"].Value.ToString();
                txt_nombreEsp.Text = fila.Cells["con_nombre_especialista"].Value.ToString();
                dtTIME_fechaConsulta.Value = Convert.ToDateTime(fila.Cells["con_fecha"].Value);
                txt_motivoConsult.Text = fila.Cells["con_motivo_consulta"].Value.ToString();
                txt_Diagnostico.Text = fila.Cells["con_diagnostico"].Value.ToString();
                txt_trataOmedicamento.Text = fila.Cells["con_tratamiento_medicamento"].Value.ToString();
                txtobservacionAdi.Text = fila.Cells["con_observaciones_adicionales"].Value.ToString();
            }
        }

        private void btn_actualizar_cons_Click(object sender, EventArgs e)
        {
            consulta miConsulta = new consulta
            {
                Con_id = int.Parse(txt_IDconsulta.Text),
                Con_nombre_paciente = txtNombrePaci.Text,
                Con_nombre_especialista = txt_nombreEsp.Text,
                Con_fecha = dtTIME_fechaConsulta .Value.Date,
                
                Con_motivo_consulta = txt_motivoConsult.Text,
                Con_diagnostico = txt_Diagnostico.Text,
                Con_tratamiento_medicamento = txt_trataOmedicamento.Text,
                Con_observaciones_adicionales = txtobservacionAdi.Text
            };

            bool actualizado = new consultaControlador().ActualizarConsulta(miConsulta);

            if (actualizado)
                MessageBox.Show("Consulta actualizada correctamente.");
            else
                MessageBox.Show("No se pudo actualizar la consulta.");
        }

        private void btn_obtener_cons_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_IDconsulta.Text); 
            consulta miConsulta = new consultaControlador().ObtenerConsulta(id);

            if (miConsulta != null)
            {
                txtNombrePaci.Text = miConsulta.Con_nombre_paciente;
                txt_nombreEsp.Text = miConsulta.Con_nombre_especialista;
                dtTIME_fechaConsulta.Value = miConsulta.Con_fecha;
               
                txt_motivoConsult.Text = miConsulta.Con_motivo_consulta;
                txt_Diagnostico.Text = miConsulta.Con_diagnostico;
                txt_trataOmedicamento.Text = miConsulta.Con_tratamiento_medicamento;
                txtobservacionAdi.Text = miConsulta.Con_observaciones_adicionales;
            }
            else
            {
                MessageBox.Show("No se encontró la consulta con ese ID.");
            }
        }

        private void btn_eliminar_cons_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_IDconsulta.Text);

            bool eliminado = new consultaControlador().EliminarConsulta(id);

            if (eliminado)
            {
                MessageBox.Show("Consulta eliminada correctamente.");
                this.Close(); // Opcional: cerrar formulario después de eliminar
            }
            else
                MessageBox.Show("No se pudo eliminar la consulta.");

        }

        private void dgv_listar_consultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgv_listar_consultas.Rows[e.RowIndex];

                txt_IDconsulta.Text = fila.Cells["con_id"].Value.ToString();
                txtNombrePaci.Text = fila.Cells["con_nombre_paciente"].Value.ToString();
                txt_nombreEsp.Text = fila.Cells["con_nombre_especialista"].Value.ToString();
                dtTIME_fechaConsulta.Value = Convert.ToDateTime(fila.Cells["con_fecha"].Value);
                txt_motivoConsult.Text = fila.Cells["con_motivo_consulta"].Value.ToString();
                txt_Diagnostico.Text = fila.Cells["con_diagnostico"].Value.ToString();
                txt_trataOmedicamento.Text = fila.Cells["con_tratamiento_medicamento"].Value.ToString();
                txtobservacionAdi.Text = fila.Cells["con_observaciones_adicionales"].Value.ToString();
            }
        }
        
    }
    
}
