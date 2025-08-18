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
            this.textBox1.Location = new System.Drawing.Point(49, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "¿Qué Quieres hacer hoy?";
            // 
            // GenerarCita
            // 
            this.GenerarCita.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerarCita.Location = new System.Drawing.Point(84, 172);
            this.GenerarCita.Name = "GenerarCita";
            this.GenerarCita.Size = new System.Drawing.Size(382, 94);
            this.GenerarCita.TabIndex = 1;
            this.GenerarCita.Text = "Generar Cita";
            this.GenerarCita.UseVisualStyleBackColor = true;
            this.GenerarCita.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModifCita
            // 
            this.ModifCita.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifCita.Location = new System.Drawing.Point(84, 286);
            this.ModifCita.Name = "ModifCita";
            this.ModifCita.Size = new System.Drawing.Size(148, 79);
            this.ModifCita.TabIndex = 2;
            this.ModifCita.Text = "Modificar Cita";
            this.ModifCita.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.btexit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ModifCita);
            this.panel1.Controls.Add(this.GenerarCita);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(14, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 405);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btexit
            // 
            this.btexit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexit.Location = new System.Drawing.Point(319, 287);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(142, 78);
            this.btexit.TabIndex = 11;
            this.btexit.Text = "Salir";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::codigo_inicial_proyecto.Properties.Resources.utsvirtual;
            this.pictureBox1.Location = new System.Drawing.Point(324, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // RolPacientecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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