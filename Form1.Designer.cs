<<<<<<< HEAD
﻿namespace EspecialistaPROYECTO
=======
﻿namespace pantalla_consulta
>>>>>>> d19d37de272cfe746cc16444efb72f0804acc1d5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            this.buttonNUEVO = new System.Windows.Forms.Button();
            this.buttonGUARDAR = new System.Windows.Forms.Button();
            this.buttonELIMINAR = new System.Windows.Forms.Button();
            this.buttonSALIR = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNUEVO
            // 
            this.buttonNUEVO.Location = new System.Drawing.Point(59, 370);
            this.buttonNUEVO.Name = "buttonNUEVO";
            this.buttonNUEVO.Size = new System.Drawing.Size(129, 34);
            this.buttonNUEVO.TabIndex = 0;
            this.buttonNUEVO.Text = "NUEVO";
            this.buttonNUEVO.UseVisualStyleBackColor = true;
            this.buttonNUEVO.Click += new System.EventHandler(this.buttonNUEVO_Click);
            // 
            // buttonGUARDAR
            // 
            this.buttonGUARDAR.Location = new System.Drawing.Point(433, 370);
            this.buttonGUARDAR.Name = "buttonGUARDAR";
            this.buttonGUARDAR.Size = new System.Drawing.Size(129, 32);
            this.buttonGUARDAR.TabIndex = 1;
            this.buttonGUARDAR.Text = "GUARDAR";
            this.buttonGUARDAR.UseVisualStyleBackColor = true;
            this.buttonGUARDAR.Click += new System.EventHandler(this.buttonGUARDAR_Click);
            // 
            // buttonELIMINAR
            // 
            this.buttonELIMINAR.Location = new System.Drawing.Point(241, 370);
            this.buttonELIMINAR.Name = "buttonELIMINAR";
            this.buttonELIMINAR.Size = new System.Drawing.Size(129, 32);
            this.buttonELIMINAR.TabIndex = 2;
            this.buttonELIMINAR.Text = "ELIMINAR ";
            this.buttonELIMINAR.UseVisualStyleBackColor = true;
            this.buttonELIMINAR.Click += new System.EventHandler(this.buttonELIMINAR_Click);
            // 
            // buttonSALIR
            // 
            this.buttonSALIR.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSALIR.Location = new System.Drawing.Point(603, 371);
            this.buttonSALIR.Name = "buttonSALIR";
            this.buttonSALIR.Size = new System.Drawing.Size(129, 33);
            this.buttonSALIR.TabIndex = 3;
            this.buttonSALIR.Text = "SALIR";
            this.buttonSALIR.UseVisualStyleBackColor = false;
            this.buttonSALIR.Click += new System.EventHandler(this.buttonSALIR_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(187, 10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(115, 40);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(182, 20);
            this.txtEspecialidad.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EspecialistaPROYECTO.Properties.Resources.descarga__3_;
            this.pictureBox1.Location = new System.Drawing.Point(296, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(70, 72);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 7;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2,
            this.Column3});
            this.Grid.Location = new System.Drawing.Point(34, 232);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersVisible = false;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(403, 111);
            this.Grid.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nombre";
            this.Column1.HeaderText = "NOMBRE";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "especialidad";
            this.Column2.HeaderText = "ESPECIALIDAD";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "fecha";
            this.Column3.HeaderText = "FECHA";
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "NOMBRE DEL ESPECIALISTA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ESPECIALIDAD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "FECHA:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtEspecialidad);
            this.panel1.Location = new System.Drawing.Point(34, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 113);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSALIR);
            this.Controls.Add(this.buttonELIMINAR);
            this.Controls.Add(this.buttonGUARDAR);
            this.Controls.Add(this.buttonNUEVO);
            this.Name = "Form1";
            this.Text = "ESPECIALISTA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
=======
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardarConsulta = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Doagnostico = new System.Windows.Forms.Label();
            this.lbl_trataOmedicamento = new System.Windows.Forms.Label();
            this.txt_motivoConsult = new System.Windows.Forms.TextBox();
            this.txt_Diagnostico = new System.Windows.Forms.TextBox();
            this.txt_trataOmedicamento = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_nombreEsp = new System.Windows.Forms.TextBox();
            this.txtNombrePaci = new System.Windows.Forms.TextBox();
            this.lbl_nmbrePaciente = new System.Windows.Forms.Label();
            this.lbl_nmbreEspecia = new System.Windows.Forms.Label();
            this.lbl_fechConsulta = new System.Windows.Forms.Label();
            this.dtTIME_fechaConsulta = new System.Windows.Forms.DateTimePicker();
            this.lbl_IDconsulta = new System.Windows.Forms.Label();
            this.txt_IDconsulta = new System.Windows.Forms.TextBox();
            this.txtobservacionAdi = new System.Windows.Forms.TextBox();
            this.lbl_ObservaAdicionales = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_actualizar_cons = new System.Windows.Forms.Button();
            this.btn_obtener_cons = new System.Windows.Forms.Button();
            this.btn_eliminar_cons = new System.Windows.Forms.Button();
            this.dgv_listar_consultas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listar_consultas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.dgv_listar_consultas);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtobservacionAdi);
            this.panel1.Controls.Add(this.lbl_ObservaAdicionales);
            this.panel1.Location = new System.Drawing.Point(16, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 565);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_eliminar_cons);
            this.panel4.Controls.Add(this.btn_obtener_cons);
            this.panel4.Controls.Add(this.btn_actualizar_cons);
            this.panel4.Controls.Add(this.btn_cancelar);
            this.panel4.Controls.Add(this.btn_guardarConsulta);
            this.panel4.Location = new System.Drawing.Point(0, 485);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1174, 80);
            this.panel4.TabIndex = 24;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(899, 43);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(171, 28);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardarConsulta
            // 
            this.btn_guardarConsulta.Location = new System.Drawing.Point(22, 43);
            this.btn_guardarConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardarConsulta.Name = "btn_guardarConsulta";
            this.btn_guardarConsulta.Size = new System.Drawing.Size(217, 28);
            this.btn_guardarConsulta.TabIndex = 0;
            this.btn_guardarConsulta.Text = "GUARDAR CONSULTA";
            this.btn_guardarConsulta.UseVisualStyleBackColor = true;
            this.btn_guardarConsulta.Click += new System.EventHandler(this.btn_guardarConsulta_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lbl_Doagnostico);
            this.panel3.Controls.Add(this.lbl_trataOmedicamento);
            this.panel3.Controls.Add(this.txt_motivoConsult);
            this.panel3.Controls.Add(this.txt_Diagnostico);
            this.panel3.Controls.Add(this.txt_trataOmedicamento);
            this.panel3.Location = new System.Drawing.Point(0, 134);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1178, 118);
            this.panel3.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Motivo de la consulta:";
            // 
            // lbl_Doagnostico
            // 
            this.lbl_Doagnostico.AutoSize = true;
            this.lbl_Doagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Doagnostico.Location = new System.Drawing.Point(24, 50);
            this.lbl_Doagnostico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Doagnostico.Name = "lbl_Doagnostico";
            this.lbl_Doagnostico.Size = new System.Drawing.Size(103, 20);
            this.lbl_Doagnostico.TabIndex = 15;
            this.lbl_Doagnostico.Text = "Diagnostico:";
            // 
            // lbl_trataOmedicamento
            // 
            this.lbl_trataOmedicamento.AutoSize = true;
            this.lbl_trataOmedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trataOmedicamento.Location = new System.Drawing.Point(24, 83);
            this.lbl_trataOmedicamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_trataOmedicamento.Name = "lbl_trataOmedicamento";
            this.lbl_trataOmedicamento.Size = new System.Drawing.Size(222, 20);
            this.lbl_trataOmedicamento.TabIndex = 16;
            this.lbl_trataOmedicamento.Text = "Tratamiento o Medicamento:";
            // 
            // txt_motivoConsult
            // 
            this.txt_motivoConsult.Location = new System.Drawing.Point(271, 6);
            this.txt_motivoConsult.Margin = new System.Windows.Forms.Padding(4);
            this.txt_motivoConsult.Multiline = true;
            this.txt_motivoConsult.Name = "txt_motivoConsult";
            this.txt_motivoConsult.Size = new System.Drawing.Size(705, 32);
            this.txt_motivoConsult.TabIndex = 19;
            // 
            // txt_Diagnostico
            // 
            this.txt_Diagnostico.Location = new System.Drawing.Point(271, 46);
            this.txt_Diagnostico.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Diagnostico.Multiline = true;
            this.txt_Diagnostico.Name = "txt_Diagnostico";
            this.txt_Diagnostico.Size = new System.Drawing.Size(705, 24);
            this.txt_Diagnostico.TabIndex = 17;
            // 
            // txt_trataOmedicamento
            // 
            this.txt_trataOmedicamento.Location = new System.Drawing.Point(270, 79);
            this.txt_trataOmedicamento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_trataOmedicamento.Multiline = true;
            this.txt_trataOmedicamento.Name = "txt_trataOmedicamento";
            this.txt_trataOmedicamento.Size = new System.Drawing.Size(705, 24);
            this.txt_trataOmedicamento.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(511, 5);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(167, 34);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "CONSULTA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.txt_nombreEsp);
            this.panel2.Controls.Add(this.txtNombrePaci);
            this.panel2.Controls.Add(this.lbl_nmbrePaciente);
            this.panel2.Controls.Add(this.lbl_nmbreEspecia);
            this.panel2.Controls.Add(this.lbl_fechConsulta);
            this.panel2.Controls.Add(this.dtTIME_fechaConsulta);
            this.panel2.Controls.Add(this.lbl_IDconsulta);
            this.panel2.Controls.Add(this.txt_IDconsulta);
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 89);
            this.panel2.TabIndex = 1;
            // 
            // txt_nombreEsp
            // 
            this.txt_nombreEsp.Location = new System.Drawing.Point(271, 50);
            this.txt_nombreEsp.Name = "txt_nombreEsp";
            this.txt_nombreEsp.Size = new System.Drawing.Size(273, 22);
            this.txt_nombreEsp.TabIndex = 16;
            // 
            // txtNombrePaci
            // 
            this.txtNombrePaci.Location = new System.Drawing.Point(270, 22);
            this.txtNombrePaci.Name = "txtNombrePaci";
            this.txtNombrePaci.Size = new System.Drawing.Size(274, 22);
            this.txtNombrePaci.TabIndex = 15;
            // 
            // lbl_nmbrePaciente
            // 
            this.lbl_nmbrePaciente.AutoSize = true;
            this.lbl_nmbrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nmbrePaciente.Location = new System.Drawing.Point(24, 22);
            this.lbl_nmbrePaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nmbrePaciente.Name = "lbl_nmbrePaciente";
            this.lbl_nmbrePaciente.Size = new System.Drawing.Size(168, 20);
            this.lbl_nmbrePaciente.TabIndex = 3;
            this.lbl_nmbrePaciente.Text = "Nombre del paciente:";
            // 
            // lbl_nmbreEspecia
            // 
            this.lbl_nmbreEspecia.AutoSize = true;
            this.lbl_nmbreEspecia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nmbreEspecia.Location = new System.Drawing.Point(24, 57);
            this.lbl_nmbreEspecia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nmbreEspecia.Name = "lbl_nmbreEspecia";
            this.lbl_nmbreEspecia.Size = new System.Drawing.Size(194, 20);
            this.lbl_nmbreEspecia.TabIndex = 4;
            this.lbl_nmbreEspecia.Text = "Nombre del especialista:";
            // 
            // lbl_fechConsulta
            // 
            this.lbl_fechConsulta.AutoSize = true;
            this.lbl_fechConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechConsulta.Location = new System.Drawing.Point(620, 59);
            this.lbl_fechConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fechConsulta.Name = "lbl_fechConsulta";
            this.lbl_fechConsulta.Size = new System.Drawing.Size(169, 20);
            this.lbl_fechConsulta.TabIndex = 2;
            this.lbl_fechConsulta.Text = "Fecha de la consulta:";
            // 
            // dtTIME_fechaConsulta
            // 
            this.dtTIME_fechaConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTIME_fechaConsulta.Location = new System.Drawing.Point(806, 57);
            this.dtTIME_fechaConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.dtTIME_fechaConsulta.Name = "dtTIME_fechaConsulta";
            this.dtTIME_fechaConsulta.Size = new System.Drawing.Size(122, 22);
            this.dtTIME_fechaConsulta.TabIndex = 12;
            this.dtTIME_fechaConsulta.Value = new System.DateTime(2025, 8, 15, 20, 39, 19, 0);
            // 
            // lbl_IDconsulta
            // 
            this.lbl_IDconsulta.AutoSize = true;
            this.lbl_IDconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDconsulta.Location = new System.Drawing.Point(620, 26);
            this.lbl_IDconsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IDconsulta.Name = "lbl_IDconsulta";
            this.lbl_IDconsulta.Size = new System.Drawing.Size(99, 20);
            this.lbl_IDconsulta.TabIndex = 0;
            this.lbl_IDconsulta.Text = "ID consulta:";
            // 
            // txt_IDconsulta
            // 
            this.txt_IDconsulta.Location = new System.Drawing.Point(806, 26);
            this.txt_IDconsulta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IDconsulta.Name = "txt_IDconsulta";
            this.txt_IDconsulta.Size = new System.Drawing.Size(132, 22);
            this.txt_IDconsulta.TabIndex = 1;
            // 
            // txtobservacionAdi
            // 
            this.txtobservacionAdi.Location = new System.Drawing.Point(270, 260);
            this.txtobservacionAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtobservacionAdi.Multiline = true;
            this.txtobservacionAdi.Name = "txtobservacionAdi";
            this.txtobservacionAdi.Size = new System.Drawing.Size(705, 74);
            this.txtobservacionAdi.TabIndex = 21;
            // 
            // lbl_ObservaAdicionales
            // 
            this.lbl_ObservaAdicionales.AutoSize = true;
            this.lbl_ObservaAdicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ObservaAdicionales.Location = new System.Drawing.Point(24, 314);
            this.lbl_ObservaAdicionales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ObservaAdicionales.Name = "lbl_ObservaAdicionales";
            this.lbl_ObservaAdicionales.Size = new System.Drawing.Size(215, 20);
            this.lbl_ObservaAdicionales.TabIndex = 20;
            this.lbl_ObservaAdicionales.Text = "Observaciones adicionales:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_actualizar_cons
            // 
            this.btn_actualizar_cons.Location = new System.Drawing.Point(253, 43);
            this.btn_actualizar_cons.Name = "btn_actualizar_cons";
            this.btn_actualizar_cons.Size = new System.Drawing.Size(204, 28);
            this.btn_actualizar_cons.TabIndex = 2;
            this.btn_actualizar_cons.Text = "ACTUALIZAR CONSULTA";
            this.btn_actualizar_cons.UseVisualStyleBackColor = true;
            this.btn_actualizar_cons.Click += new System.EventHandler(this.btn_actualizar_cons_Click);
            // 
            // btn_obtener_cons
            // 
            this.btn_obtener_cons.Location = new System.Drawing.Point(483, 43);
            this.btn_obtener_cons.Name = "btn_obtener_cons";
            this.btn_obtener_cons.Size = new System.Drawing.Size(176, 28);
            this.btn_obtener_cons.TabIndex = 3;
            this.btn_obtener_cons.Text = "OBTENER CONSULTA";
            this.btn_obtener_cons.UseVisualStyleBackColor = true;
            this.btn_obtener_cons.Click += new System.EventHandler(this.btn_obtener_cons_Click);
            // 
            // btn_eliminar_cons
            // 
            this.btn_eliminar_cons.Location = new System.Drawing.Point(680, 43);
            this.btn_eliminar_cons.Name = "btn_eliminar_cons";
            this.btn_eliminar_cons.Size = new System.Drawing.Size(172, 28);
            this.btn_eliminar_cons.TabIndex = 4;
            this.btn_eliminar_cons.Text = "ELIMINAR CONSULTA";
            this.btn_eliminar_cons.UseVisualStyleBackColor = true;
            this.btn_eliminar_cons.Click += new System.EventHandler(this.btn_eliminar_cons_Click);
            // 
            // dgv_listar_consultas
            // 
            this.dgv_listar_consultas.AllowUserToOrderColumns = true;
            this.dgv_listar_consultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listar_consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listar_consultas.Location = new System.Drawing.Point(41, 355);
            this.dgv_listar_consultas.Name = "dgv_listar_consultas";
            this.dgv_listar_consultas.RowHeadersWidth = 51;
            this.dgv_listar_consultas.RowTemplate.Height = 24;
            this.dgv_listar_consultas.Size = new System.Drawing.Size(935, 123);
            this.dgv_listar_consultas.TabIndex = 25;
            this.dgv_listar_consultas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listar_consultas_CellClick);
            this.dgv_listar_consultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listar_consultas_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1227, 606);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CONSULTA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listar_consultas)).EndInit();
>>>>>>> d19d37de272cfe746cc16444efb72f0804acc1d5
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Button buttonNUEVO;
        private System.Windows.Forms.Button buttonGUARDAR;
        private System.Windows.Forms.Button buttonELIMINAR;
        private System.Windows.Forms.Button buttonSALIR;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
=======
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_IDconsulta;
        private System.Windows.Forms.Label lbl_IDconsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_nmbreEspecia;
        private System.Windows.Forms.Label lbl_nmbrePaciente;
        private System.Windows.Forms.Label lbl_fechConsulta;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker dtTIME_fechaConsulta;
        private System.Windows.Forms.Label lbl_Doagnostico;
        private System.Windows.Forms.Label lbl_trataOmedicamento;
        private System.Windows.Forms.TextBox txt_trataOmedicamento;
        private System.Windows.Forms.TextBox txt_Diagnostico;
        private System.Windows.Forms.TextBox txt_motivoConsult;
        private System.Windows.Forms.TextBox txtobservacionAdi;
        private System.Windows.Forms.Label lbl_ObservaAdicionales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardarConsulta;
        private System.Windows.Forms.TextBox txtNombrePaci;
        private System.Windows.Forms.TextBox txt_nombreEsp;
        private System.Windows.Forms.Button btn_eliminar_cons;
        private System.Windows.Forms.Button btn_obtener_cons;
        private System.Windows.Forms.Button btn_actualizar_cons;
        private System.Windows.Forms.DataGridView dgv_listar_consultas;
>>>>>>> d19d37de272cfe746cc16444efb72f0804acc1d5
    }
}

