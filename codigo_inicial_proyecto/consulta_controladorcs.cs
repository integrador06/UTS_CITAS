using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace codigo_inicial_proyecto
{
    internal class consulta_controlador
    {
        public consulta_controlador()
        {
            //constructor vacío
        }



        public bool AgregarConsulta(consulta consulta)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion.strconexion))
                {
                    if (conn.State == 0)
                    {
                        conn.Open();
                    }

                    SqlCommand cmd = new SqlCommand("ins_consulta", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@con_nombre_paciente", consulta.Con_nombre_paciente);
                    cmd.Parameters.AddWithValue("@con_nombre_especialista", consulta.Con_nombre_especialista);
                    cmd.Parameters.AddWithValue("@con_fecha", consulta.Con_fecha);
                    cmd.Parameters.AddWithValue("@con_hora", consulta.Con_hora);
                    cmd.Parameters.AddWithValue("@con_motivo_consulta", consulta.Con_motivo_consulta);
                    cmd.Parameters.AddWithValue("@con_diagnostico", consulta.Con_diagnostico);
                    cmd.Parameters.AddWithValue("@con_tratamiento_medicamento", consulta.Con_tratamiento_medicamento);
                    cmd.Parameters.AddWithValue("@con_observaciones_adicionales", consulta.Con_observaciones_adicionales);
                    cmd.ExecuteNonQuery();
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la consulta: " + ex.Message);
                return false;
            }
        }
        public bool ActualizarConsulta(consulta consulta)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion.strconexion))
                {
                    if (conn.State == 0)
                        conn.Open();

                    SqlCommand cmd = new SqlCommand("act_consulta", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@con_id", consulta.Con_id);
                    cmd.Parameters.AddWithValue("@con_nombre_paciente", consulta.Con_nombre_paciente);
                    cmd.Parameters.AddWithValue("@con_nombre_especialista", consulta.Con_nombre_especialista);
                    cmd.Parameters.AddWithValue("@con_fecha", consulta.Con_fecha);
                    cmd.Parameters.AddWithValue("@con_hora", consulta.Con_hora);
                    cmd.Parameters.AddWithValue("@con_motivo_consulta", consulta.Con_motivo_consulta);
                    cmd.Parameters.AddWithValue("@con_diagnostico", consulta.Con_diagnostico);
                    cmd.Parameters.AddWithValue("@con_tratamiento_medicamento", consulta.Con_tratamiento_medicamento);
                    cmd.Parameters.AddWithValue("@con_observaciones_adicionales", consulta.Con_observaciones_adicionales);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la consulta: " + ex.Message);
                return false;
            }
        }
        public consulta ObtenerConsulta(int id)
        {
            consulta con = null;
            try
            {
                SqlConnection conn = new SqlConnection(conexion.strconexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                DataTable datos = new DataTable();
                if (conn.State == 0)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("bus_consulta", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@con_id", id);
                adaptador.SelectCommand = cmd;
                adaptador.Fill(datos);
                if (datos.Rows.Count > 0)
                {
                    con = new consulta
                    {
                        Con_id = Convert.ToInt32(datos.Rows[0].ItemArray[0]),
                        Con_nombre_paciente = datos.Rows[0].ItemArray[1].ToString(),
                        Con_nombre_especialista = datos.Rows[0].ItemArray[2].ToString(),
                        Con_fecha = Convert.ToDateTime(datos.Rows[0].ItemArray[3]),
                        Con_hora = TimeSpan.Parse(datos.Rows[0].ItemArray[4].ToString()),
                        Con_motivo_consulta = datos.Rows[0].ItemArray[5].ToString(),
                        Con_diagnostico = datos.Rows[0].ItemArray[6].ToString(),
                        Con_tratamiento_medicamento = datos.Rows[0].ItemArray[7].ToString(),
                        Con_observaciones_adicionales = datos.Rows[0].ItemArray[8].ToString()

                    };
                }
                return con;
            }
            catch
            {
                return con;
            }
        }
        public bool EliminarConsulta(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion.strconexion))
                {
                    if (conn.State == 0)
                        conn.Open();

                    SqlCommand cmd = new SqlCommand("bor_consulta", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@con_id", id);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la consulta: " + ex.Message);
                return false;
            }
        }
        public List<consulta> ListarConsultas()
        {

            List<consulta> consulta = new List<consulta>();
            try
            {

                using (SqlConnection conn = new SqlConnection(conexion.strconexion))
                {
                    if (conn.State == 0)
                        conn.Open();

                    SqlCommand cmd = new SqlCommand("lis_consulta", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable datos = new DataTable();
                    adaptador.Fill(datos);

                    foreach (DataRow row in datos.Rows)
                    {
                        consulta.Add(new consulta
                        {
                            Con_id = Convert.ToInt32(row["con_id"]),
                            Con_nombre_paciente = row["con_nombre_paciente"].ToString(),
                            Con_nombre_especialista = row["con_nombre_especialista"].ToString(),
                            Con_fecha = Convert.ToDateTime(row["con_fecha"]),
                            Con_hora = TimeSpan.Parse(row["con_hora"].ToString()),
                            Con_motivo_consulta = row["con_motivo_consulta"].ToString(),
                            Con_diagnostico = row["con_diagnostico"].ToString(),
                            Con_tratamiento_medicamento = row["con_tratamiento_medicamento"].ToString(),
                            Con_observaciones_adicionales = row["con_observaciones_adicionales"].ToString()
                        });
                    }
                }
                return consulta;





            }

            catch
            {
                return consulta;
            }
        }

    }
}
