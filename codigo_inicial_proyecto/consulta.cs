using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigo_inicial_proyecto.pantalla_consulta
{
   
    internal class consulta
    {
        public consulta()
        {
            // Constructor vacío
        }
        private int con_id;
        private string con_nombre_paciente;
        private string con_nombre_especialista;
        private DateTime con_fecha = DateTime.Today;
        private TimeSpan con_hora = DateTime.Now.TimeOfDay;
        private string con_motivo_consulta;
        private string con_diagnostico;
        private string con_tratamiento_medicamento;
        private string con_observaciones_adicionales;



        public consulta(int con_id, string con_nombre_paciente, string con_nombre_especialista, DateTime con_fecha, TimeSpan con_hora, string con_motivo_consulta, string con_diagnostico, string con_tratamiento_medicamento, string con_observaciones_adicionales)
        {
            this.con_id = con_id;
            this.con_nombre_paciente = con_nombre_paciente;
            this.con_nombre_especialista = con_nombre_especialista;
            this.con_fecha = con_fecha;
            this.con_hora = con_hora;
            this.con_motivo_consulta = con_motivo_consulta;
            this.con_diagnostico = con_diagnostico;
            this.con_tratamiento_medicamento = con_tratamiento_medicamento;
            this.con_observaciones_adicionales = con_observaciones_adicionales;
        }

        public int Con_id { get => con_id; set => con_id = value; }
        public string Con_nombre_paciente { get => con_nombre_paciente; set => con_nombre_paciente = value; }
        public string Con_nombre_especialista { get => con_nombre_especialista; set => con_nombre_especialista = value; }
        public DateTime Con_fecha { get => con_fecha; set => con_fecha = value; }
        public TimeSpan Con_hora { get => con_hora; set => con_hora = value; }
        public string Con_motivo_consulta { get => con_motivo_consulta; set => con_motivo_consulta = value; }
        public string Con_diagnostico { get => con_diagnostico; set => con_diagnostico = value; }
        public string Con_tratamiento_medicamento { get => con_tratamiento_medicamento; set => con_tratamiento_medicamento = value; }
        public string Con_observaciones_adicionales { get => con_observaciones_adicionales; set => con_observaciones_adicionales = value; }
    }
}
