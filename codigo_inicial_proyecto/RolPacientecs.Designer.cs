namespace codigo_inicial_proyecto
{
    partial class RolPacientecs
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GenerarCita = new System.Windows.Forms.Button();
            this.ModifCita = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btexit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(65, 84);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 33);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "¿Qué Quieres hacer hoy?";
            // 
            // GenerarCita
            // 
            this.GenerarCita.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerarCita.Location = new System.Drawing.Point(112, 212);
            this.GenerarCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GenerarCita.Name = "GenerarCita";
            this.GenerarCita.Size = new System.Drawing.Size(509, 116);
            this.GenerarCita.TabIndex = 1;
            this.GenerarCita.Text = "Generar Cita";
            this.GenerarCita.UseVisualStyleBackColor = true;
            this.GenerarCita.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModifCita
            // 
            this.ModifCita.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifCita.Location = new System.Drawing.Point(112, 352);
            this.ModifCita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifCita.Name = "ModifCita";
            this.ModifCita.Size = new System.Drawing.Size(197, 97);
            this.ModifCita.TabIndex = 2;
            this.ModifCita.Text = "Modificar Cita";
            this.ModifCita.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.btexit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ModifCita);
            this.panel1.Controls.Add(this.GenerarCita);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(19, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 498);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btexit
            // 
            this.btexit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexit.Location = new System.Drawing.Point(425, 353);
            this.btexit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(189, 96);
            this.btexit.TabIndex = 11;
            this.btexit.Text = "Salir";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::codigo_inicial_proyecto.Properties.Resources.utsvirtual;
            this.pictureBox1.Location = new System.Drawing.Point(432, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // RolPacientecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(744, 554);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RolPacientecs";
            this.Text = "Paciente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GenerarCita;
        private System.Windows.Forms.Button ModifCita;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btexit;
    }
}