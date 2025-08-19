namespace codigo_inicial_proyecto.pantalla_consulta
{
    partial class pantallaCONSULTA
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
            this.lblnombre_paciente = new System.Windows.Forms.Label();
            this.lblnombre_especialista = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblID_consulta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtime_fecha_cons = new System.Windows.Forms.DateTimePicker();
            this.txt_ID_cons = new System.Windows.Forms.TextBox();
            this.txt_nombre_esp = new System.Windows.Forms.TextBox();
            this.txt_nombre_paci = new System.Windows.Forms.TextBox();
            this.lblfecha_consulta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_trataOmedi = new System.Windows.Forms.TextBox();
            this.txt_motivo_cons = new System.Windows.Forms.TextBox();
            this.txt_diagnostico = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtGrV_tabla_cons = new System.Windows.Forms.DataGridView();
            this.txtObser_adi = new System.Windows.Forms.TextBox();
            this.btnGuardad_consulta = new System.Windows.Forms.Button();
            this.btnActualizar_consulta = new System.Windows.Forms.Button();
            this.btnObtener_consulta = new System.Windows.Forms.Button();
            this.btnEliminar_consulta = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrV_tabla_cons)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombre_paciente
            // 
            this.lblnombre_paciente.AutoSize = true;
            this.lblnombre_paciente.Location = new System.Drawing.Point(27, 12);
            this.lblnombre_paciente.Name = "lblnombre_paciente";
            this.lblnombre_paciente.Size = new System.Drawing.Size(168, 16);
            this.lblnombre_paciente.TabIndex = 1;
            this.lblnombre_paciente.Text = "NOMBRE DEL PACIENTE:";
            // 
            // lblnombre_especialista
            // 
            this.lblnombre_especialista.AutoSize = true;
            this.lblnombre_especialista.Location = new System.Drawing.Point(29, 46);
            this.lblnombre_especialista.Name = "lblnombre_especialista";
            this.lblnombre_especialista.Size = new System.Drawing.Size(166, 16);
            this.lblnombre_especialista.TabIndex = 2;
            this.lblnombre_especialista.Text = "NOMBRE ESPECIALISTA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "MOTIVO DE LA CONSULTA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "TRATAMIENTO O MEDICAMENTO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "DIAGNOSTICO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "OBSERVACIONES ADICIONALES:";
            // 
            // lblID_consulta
            // 
            this.lblID_consulta.AutoSize = true;
            this.lblID_consulta.Location = new System.Drawing.Point(651, 12);
            this.lblID_consulta.Name = "lblID_consulta";
            this.lblID_consulta.Size = new System.Drawing.Size(99, 16);
            this.lblID_consulta.TabIndex = 9;
            this.lblID_consulta.Text = "ID CONSULTA:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtime_fecha_cons);
            this.panel1.Controls.Add(this.txt_ID_cons);
            this.panel1.Controls.Add(this.txt_nombre_esp);
            this.panel1.Controls.Add(this.txt_nombre_paci);
            this.panel1.Controls.Add(this.lblfecha_consulta);
            this.panel1.Controls.Add(this.lblID_consulta);
            this.panel1.Controls.Add(this.lblnombre_paciente);
            this.panel1.Controls.Add(this.lblnombre_especialista);
            this.panel1.Location = new System.Drawing.Point(2, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 85);
            this.panel1.TabIndex = 10;
            // 
            // dtime_fecha_cons
            // 
            this.dtime_fecha_cons.Location = new System.Drawing.Point(775, 37);
            this.dtime_fecha_cons.Name = "dtime_fecha_cons";
            this.dtime_fecha_cons.Size = new System.Drawing.Size(200, 22);
            this.dtime_fecha_cons.TabIndex = 14;
            // 
            // txt_ID_cons
            // 
            this.txt_ID_cons.Location = new System.Drawing.Point(775, 6);
            this.txt_ID_cons.Name = "txt_ID_cons";
            this.txt_ID_cons.Size = new System.Drawing.Size(239, 22);
            this.txt_ID_cons.TabIndex = 13;
            // 
            // txt_nombre_esp
            // 
            this.txt_nombre_esp.Location = new System.Drawing.Point(225, 39);
            this.txt_nombre_esp.Name = "txt_nombre_esp";
            this.txt_nombre_esp.Size = new System.Drawing.Size(273, 22);
            this.txt_nombre_esp.TabIndex = 12;
            // 
            // txt_nombre_paci
            // 
            this.txt_nombre_paci.Location = new System.Drawing.Point(225, 9);
            this.txt_nombre_paci.Name = "txt_nombre_paci";
            this.txt_nombre_paci.Size = new System.Drawing.Size(273, 22);
            this.txt_nombre_paci.TabIndex = 11;
            // 
            // lblfecha_consulta
            // 
            this.lblfecha_consulta.AutoSize = true;
            this.lblfecha_consulta.Location = new System.Drawing.Point(581, 45);
            this.lblfecha_consulta.Name = "lblfecha_consulta";
            this.lblfecha_consulta.Size = new System.Drawing.Size(169, 16);
            this.lblfecha_consulta.TabIndex = 10;
            this.lblfecha_consulta.Text = "FECHA DE LA CONSULTA";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(509, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 30);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "CONSULTA";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_trataOmedi);
            this.panel2.Controls.Add(this.txt_motivo_cons);
            this.panel2.Controls.Add(this.txt_diagnostico);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(2, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 147);
            this.panel2.TabIndex = 11;
            // 
            // txt_trataOmedi
            // 
            this.txt_trataOmedi.Location = new System.Drawing.Point(281, 110);
            this.txt_trataOmedi.Name = "txt_trataOmedi";
            this.txt_trataOmedi.Size = new System.Drawing.Size(749, 22);
            this.txt_trataOmedi.TabIndex = 10;
            // 
            // txt_motivo_cons
            // 
            this.txt_motivo_cons.Location = new System.Drawing.Point(281, 25);
            this.txt_motivo_cons.Name = "txt_motivo_cons";
            this.txt_motivo_cons.Size = new System.Drawing.Size(749, 22);
            this.txt_motivo_cons.TabIndex = 9;
            // 
            // txt_diagnostico
            // 
            this.txt_diagnostico.Location = new System.Drawing.Point(281, 53);
            this.txt_diagnostico.Multiline = true;
            this.txt_diagnostico.Name = "txt_diagnostico";
            this.txt_diagnostico.Size = new System.Drawing.Size(749, 35);
            this.txt_diagnostico.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtGrV_tabla_cons);
            this.panel3.Controls.Add(this.txtObser_adi);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(2, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1116, 221);
            this.panel3.TabIndex = 12;
            // 
            // dtGrV_tabla_cons
            // 
            this.dtGrV_tabla_cons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrV_tabla_cons.Location = new System.Drawing.Point(19, 105);
            this.dtGrV_tabla_cons.Name = "dtGrV_tabla_cons";
            this.dtGrV_tabla_cons.RowHeadersWidth = 51;
            this.dtGrV_tabla_cons.RowTemplate.Height = 24;
            this.dtGrV_tabla_cons.Size = new System.Drawing.Size(1083, 102);
            this.dtGrV_tabla_cons.TabIndex = 10;
            this.dtGrV_tabla_cons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrV_tabla_cons_CellContentClick);
            // 
            // txtObser_adi
            // 
            this.txtObser_adi.Location = new System.Drawing.Point(281, 15);
            this.txtObser_adi.Multiline = true;
            this.txtObser_adi.Name = "txtObser_adi";
            this.txtObser_adi.Size = new System.Drawing.Size(821, 70);
            this.txtObser_adi.TabIndex = 9;
            // 
            // btnGuardad_consulta
            // 
            this.btnGuardad_consulta.Location = new System.Drawing.Point(38, 512);
            this.btnGuardad_consulta.Name = "btnGuardad_consulta";
            this.btnGuardad_consulta.Size = new System.Drawing.Size(159, 40);
            this.btnGuardad_consulta.TabIndex = 13;
            this.btnGuardad_consulta.Text = "GUARDAR CONSULTA";
            this.btnGuardad_consulta.UseVisualStyleBackColor = true;
            this.btnGuardad_consulta.Click += new System.EventHandler(this.btnGuardad_consulta_Click);
            // 
            // btnActualizar_consulta
            // 
            this.btnActualizar_consulta.Location = new System.Drawing.Point(264, 512);
            this.btnActualizar_consulta.Name = "btnActualizar_consulta";
            this.btnActualizar_consulta.Size = new System.Drawing.Size(203, 40);
            this.btnActualizar_consulta.TabIndex = 14;
            this.btnActualizar_consulta.Text = "ACTUALIZAR CONSULTA";
            this.btnActualizar_consulta.UseVisualStyleBackColor = true;
            this.btnActualizar_consulta.Click += new System.EventHandler(this.btnActualizar_consulta_Click);
            // 
            // btnObtener_consulta
            // 
            this.btnObtener_consulta.Location = new System.Drawing.Point(525, 512);
            this.btnObtener_consulta.Name = "btnObtener_consulta";
            this.btnObtener_consulta.Size = new System.Drawing.Size(171, 40);
            this.btnObtener_consulta.TabIndex = 15;
            this.btnObtener_consulta.Text = "OBTENER CONSULTA";
            this.btnObtener_consulta.UseVisualStyleBackColor = true;
            this.btnObtener_consulta.Click += new System.EventHandler(this.btnObtener_consulta_Click);
            // 
            // btnEliminar_consulta
            // 
            this.btnEliminar_consulta.Location = new System.Drawing.Point(751, 512);
            this.btnEliminar_consulta.Name = "btnEliminar_consulta";
            this.btnEliminar_consulta.Size = new System.Drawing.Size(173, 40);
            this.btnEliminar_consulta.TabIndex = 16;
            this.btnEliminar_consulta.Text = "ELIMINAR CONSULTA";
            this.btnEliminar_consulta.UseVisualStyleBackColor = true;
            this.btnEliminar_consulta.Click += new System.EventHandler(this.btnEliminar_consulta_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(982, 512);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(99, 40);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // pantallaCONSULTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1116, 580);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btnEliminar_consulta);
            this.Controls.Add(this.btnObtener_consulta);
            this.Controls.Add(this.btnActualizar_consulta);
            this.Controls.Add(this.btnGuardad_consulta);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Name = "pantallaCONSULTA";
            this.Text = "pantallaCONSULTA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrV_tabla_cons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre_paciente;
        private System.Windows.Forms.Label lblnombre_especialista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblID_consulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblfecha_consulta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtime_fecha_cons;
        private System.Windows.Forms.TextBox txt_ID_cons;
        private System.Windows.Forms.TextBox txt_nombre_esp;
        private System.Windows.Forms.TextBox txt_nombre_paci;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_trataOmedi;
        private System.Windows.Forms.TextBox txt_motivo_cons;
        private System.Windows.Forms.TextBox txt_diagnostico;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtObser_adi;
        private System.Windows.Forms.Button btnGuardad_consulta;
        private System.Windows.Forms.Button btnActualizar_consulta;
        private System.Windows.Forms.Button btnObtener_consulta;
        private System.Windows.Forms.Button btnEliminar_consulta;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DataGridView dtGrV_tabla_cons;
    }
}