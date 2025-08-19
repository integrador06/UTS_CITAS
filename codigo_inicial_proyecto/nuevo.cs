using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace codigo_inicial_proyecto
{
    public partial class nuevo : Form
    {
        static consulta_controlador controlador = new consulta_controlador();
        string connectionString = "workstation id=generador_de_citas.mssql.somee.com;packet size=4096;user id=uts2025_SQLLogin_1;pwd=ueow787blr;data source=generador_de_citas.mssql.somee.com;persist security info=False;initial catalog=generador_de_citas;TrustServerCertificate=True";

        private void LimpiarCampos()
        {
            txt_ID_cons.Clear();
            txt_nombre_paci.Clear();
            txt_nombre_esp.Clear();
            dtime_fecha_cons.Value = DateTime.Today;
            txt_motivo_cons.Clear();
            txt_diagnostico.Clear();
            txt_trataOmedi.Clear();
            txtObser_adi.Clear();
        }
        public nuevo()
        {
            InitializeComponent();
        }

        private void btnGuardad_consulta_Click(object sender, EventArgs e)
        {
            
            int idIngresadoPorUsuario = int.Parse(txt_ID_cons.Text); bool idExiste; using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlConnection connn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM consulta WHERE con_Id = @id", conn))
                    { cmdCheck.Parameters.AddWithValue("@id", idIngresadoPorUsuario); idExiste = (int)cmdCheck.ExecuteScalar() > 0; }
                    if (idExiste)
                    {
                        MessageBox.Show("El ID ya existe, elige otro.");
                    }
                    else
                    {

                        consulta nuevaConsulta = new consulta
                        {
                            Con_nombre_paciente = txt_nombre_paci.Text,
                            Con_nombre_especialista = txt_nombre_esp.Text,
                            Con_fecha = dtime_fecha_cons.Value.Date,
                            Con_hora = DateTime.Now.TimeOfDay,
                            Con_motivo_consulta = txt_motivo_cons.Text,
                            Con_diagnostico = txt_diagnostico.Text,
                            Con_tratamiento_medicamento = txt_trataOmedi.Text,
                            Con_observaciones_adicionales = txtObser_adi.Text
                        };
                        bool exito = controlador.AgregarConsulta(nuevaConsulta);
                        if (exito)
                        {
                            MessageBox.Show("Consulta guardada exitosamente.");
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Error al guardar la consulta.");
                            LimpiarCampos();
                            return;
                        }
                    }
                }
            }
        }

        private void btnActualizar_consulta_Click(object sender, EventArgs e)
        {
            consulta miConsulta = new consulta
            {
                Con_id = int.Parse(txt_ID_cons.Text),
                Con_nombre_paciente = txt_nombre_paci.Text,
                Con_nombre_especialista = txt_nombre_esp.Text,
                Con_fecha = dtime_fecha_cons.Value.Date,
                Con_motivo_consulta = txt_motivo_cons.Text,
                Con_diagnostico = txt_diagnostico.Text,
                Con_tratamiento_medicamento = txt_trataOmedi.Text,
                Con_observaciones_adicionales = txtObser_adi.Text
            };
            bool actualizado = new consulta_controlador().ActualizarConsulta(miConsulta);
            if (actualizado)
                MessageBox.Show("Consulta actualizada correctamente.");
            else
                MessageBox.Show("No se pudo actualizar la consulta.");
        }

        private void btnObtener_consulta_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_ID_cons.Text);
            consulta miConsulta = new consulta_controlador().ObtenerConsulta(id);
            if (miConsulta != null)
            {
                txt_nombre_paci.Text = miConsulta.Con_nombre_paciente;
                txt_nombre_esp.Text = miConsulta.Con_nombre_especialista;
                dtime_fecha_cons.Value = miConsulta.Con_fecha;
                txt_motivo_cons.Text = miConsulta.Con_motivo_consulta;
                txt_diagnostico.Text = miConsulta.Con_diagnostico;
                txt_trataOmedi.Text = miConsulta.Con_tratamiento_medicamento;
                txtObser_adi.Text = miConsulta.Con_observaciones_adicionales;
            }
            else
            {
                MessageBox.Show("No se encontró la consulta con ese ID.");
            }
        }

        private void btnEliminar_consulta_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_ID_cons.Text);
            bool eliminado = new consulta_controlador().EliminarConsulta(id);
            if (eliminado)
            {
                MessageBox.Show("Consulta eliminada correctamente."); this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la consulta.");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
