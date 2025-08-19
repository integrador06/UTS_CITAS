namespace codigo_inicial_proyecto
{
    partial class pantalla_pacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHistorial = new System.Windows.Forms.TextBox();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.buttonCONSULTAR = new System.Windows.Forms.Button();
            this.buttonActualizar_datos = new System.Windows.Forms.Button();
            this.buttonGuardar_paciente = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIDPaciente = new System.Windows.Forms.TextBox();
            this.labelHistorial = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelsexo = new System.Windows.Forms.Label();
            this.labelFechaNAci = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPaciente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHistorial
            // 
            this.txtHistorial.Location = new System.Drawing.Point(226, 341);
            this.txtHistorial.Name = "txtHistorial";
            this.txtHistorial.Size = new System.Drawing.Size(265, 22);
            this.txtHistorial.TabIndex = 49;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(548, 206);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(197, 23);
            this.button_Limpiar.TabIndex = 48;
            this.button_Limpiar.Text = "Limpiar casillas";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Hombre ",
            "Mujer",
            "Otro"});
            this.cmbSexo.Location = new System.Drawing.Point(226, 239);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 24);
            this.cmbSexo.TabIndex = 47;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(226, 204);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaNacimiento.TabIndex = 46;
            // 
            // buttonCONSULTAR
            // 
            this.buttonCONSULTAR.Location = new System.Drawing.Point(548, 168);
            this.buttonCONSULTAR.Name = "buttonCONSULTAR";
            this.buttonCONSULTAR.Size = new System.Drawing.Size(197, 23);
            this.buttonCONSULTAR.TabIndex = 45;
            this.buttonCONSULTAR.Text = "CONSULTAR HISTORIAL";
            this.buttonCONSULTAR.UseVisualStyleBackColor = true;
            // 
            // buttonActualizar_datos
            // 
            this.buttonActualizar_datos.Location = new System.Drawing.Point(548, 121);
            this.buttonActualizar_datos.Name = "buttonActualizar_datos";
            this.buttonActualizar_datos.Size = new System.Drawing.Size(197, 23);
            this.buttonActualizar_datos.TabIndex = 44;
            this.buttonActualizar_datos.Text = "Actualizar Datos";
            this.buttonActualizar_datos.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar_paciente
            // 
            this.buttonGuardar_paciente.Location = new System.Drawing.Point(548, 87);
            this.buttonGuardar_paciente.Name = "buttonGuardar_paciente";
            this.buttonGuardar_paciente.Size = new System.Drawing.Size(197, 23);
            this.buttonGuardar_paciente.TabIndex = 43;
            this.buttonGuardar_paciente.Text = "Guardar paciente";
            this.buttonGuardar_paciente.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(226, 302);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 22);
            this.txtDireccion.TabIndex = 42;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(226, 272);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 41;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(226, 164);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 40;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(226, 128);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 39;
            // 
            // txtIDPaciente
            // 
            this.txtIDPaciente.Location = new System.Drawing.Point(226, 89);
            this.txtIDPaciente.Name = "txtIDPaciente";
            this.txtIDPaciente.Size = new System.Drawing.Size(100, 22);
            this.txtIDPaciente.TabIndex = 38;
            this.txtIDPaciente.TextChanged += new System.EventHandler(this.txtIDPaciente_TextChanged);
            // 
            // labelHistorial
            // 
            this.labelHistorial.AutoSize = true;
            this.labelHistorial.Location = new System.Drawing.Point(88, 341);
            this.labelHistorial.Name = "labelHistorial";
            this.labelHistorial.Size = new System.Drawing.Size(104, 16);
            this.labelHistorial.TabIndex = 37;
            this.labelHistorial.Text = "Historial medico";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(128, 302);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(64, 16);
            this.labelDireccion.TabIndex = 36;
            this.labelDireccion.Text = "Direccion";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(147, 272);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 16);
            this.labelEmail.TabIndex = 35;
            this.labelEmail.Text = "Email";
            // 
            // labelsexo
            // 
            this.labelsexo.AutoSize = true;
            this.labelsexo.Location = new System.Drawing.Point(152, 239);
            this.labelsexo.Name = "labelsexo";
            this.labelsexo.Size = new System.Drawing.Size(36, 16);
            this.labelsexo.TabIndex = 34;
            this.labelsexo.Text = "sexo";
            // 
            // labelFechaNAci
            // 
            this.labelFechaNAci.AutoSize = true;
            this.labelFechaNAci.Location = new System.Drawing.Point(55, 204);
            this.labelFechaNAci.Name = "labelFechaNAci";
            this.labelFechaNAci.Size = new System.Drawing.Size(137, 16);
            this.labelFechaNAci.TabIndex = 33;
            this.labelFechaNAci.Text = "Fecha De Nacimiento";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(135, 171);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(57, 16);
            this.labelApellido.TabIndex = 32;
            this.labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(132, 135);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 16);
            this.labelNombre.TabIndex = 31;
            this.labelNombre.Text = "Nombre";
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Location = new System.Drawing.Point(117, 93);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(75, 16);
            this.labelPaciente.TabIndex = 30;
            this.labelPaciente.Text = "ID paciente";
            // 
            // pantalla_pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHistorial);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.buttonCONSULTAR);
            this.Controls.Add(this.buttonActualizar_datos);
            this.Controls.Add(this.buttonGuardar_paciente);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDPaciente);
            this.Controls.Add(this.labelHistorial);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelsexo);
            this.Controls.Add(this.labelFechaNAci);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelPaciente);
            this.Name = "pantalla_pacientes";
            this.Text = "pantalla_pacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHistorial;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Button buttonCONSULTAR;
        private System.Windows.Forms.Button buttonActualizar_datos;
        private System.Windows.Forms.Button buttonGuardar_paciente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIDPaciente;
        private System.Windows.Forms.Label labelHistorial;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelsexo;
        private System.Windows.Forms.Label labelFechaNAci;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPaciente;
    }
}