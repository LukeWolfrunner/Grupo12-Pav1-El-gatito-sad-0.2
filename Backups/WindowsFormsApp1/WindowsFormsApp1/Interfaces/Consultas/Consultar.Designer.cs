
namespace WindowsFormsApp1.Interfaces.Consultas
{
    partial class Frm_Consultas_Mascota_Select
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
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.DataGrd_Consultas_Mascota = new System.Windows.Forms.DataGridView();
            this.Número_Historia_Clinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Número_Consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Número_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrd_Consultas_Mascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.Location = new System.Drawing.Point(849, 430);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(145, 40);
            this.Btn_Salir.TabIndex = 0;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataGrd_Consultas_Mascota
            // 
            this.DataGrd_Consultas_Mascota.AllowUserToAddRows = false;
            this.DataGrd_Consultas_Mascota.AllowUserToDeleteRows = false;
            this.DataGrd_Consultas_Mascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrd_Consultas_Mascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Número_Historia_Clinica,
            this.Número_Consulta,
            this.Fecha_Ingreso,
            this.FechaEgreso,
            this.Temperatura,
            this.Observaciones,
            this.Tratamiento,
            this.Nombre,
            this.Dueño,
            this.Número_Empleado,
            this.Empleado});
            this.DataGrd_Consultas_Mascota.Location = new System.Drawing.Point(12, 12);
            this.DataGrd_Consultas_Mascota.Name = "DataGrd_Consultas_Mascota";
            this.DataGrd_Consultas_Mascota.ReadOnly = true;
            this.DataGrd_Consultas_Mascota.Size = new System.Drawing.Size(788, 329);
            this.DataGrd_Consultas_Mascota.TabIndex = 1;
            this.DataGrd_Consultas_Mascota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrd_Consultas_Mascota_CellContentClick);
            // 
            // Número_Historia_Clinica
            // 
            this.Número_Historia_Clinica.HeaderText = "Número Historia Clinica";
            this.Número_Historia_Clinica.Name = "Número_Historia_Clinica";
            this.Número_Historia_Clinica.ReadOnly = true;
            // 
            // Número_Consulta
            // 
            this.Número_Consulta.HeaderText = "Número Consulta";
            this.Número_Consulta.Name = "Número_Consulta";
            this.Número_Consulta.ReadOnly = true;
            // 
            // Fecha_Ingreso
            // 
            this.Fecha_Ingreso.HeaderText = "Fecha Ingreso";
            this.Fecha_Ingreso.Name = "Fecha_Ingreso";
            this.Fecha_Ingreso.ReadOnly = true;
            // 
            // FechaEgreso
            // 
            this.FechaEgreso.HeaderText = "Fecha Egreso";
            this.FechaEgreso.Name = "FechaEgreso";
            this.FechaEgreso.ReadOnly = true;
            // 
            // Temperatura
            // 
            this.Temperatura.HeaderText = "Temperatura";
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.ReadOnly = true;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            // 
            // Tratamiento
            // 
            this.Tratamiento.HeaderText = "Tratamiento";
            this.Tratamiento.Name = "Tratamiento";
            this.Tratamiento.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Dueño
            // 
            this.Dueño.HeaderText = "Dueño";
            this.Dueño.Name = "Dueño";
            this.Dueño.ReadOnly = true;
            // 
            // Número_Empleado
            // 
            this.Número_Empleado.HeaderText = "Número Empleado";
            this.Número_Empleado.Name = "Número_Empleado";
            this.Número_Empleado.ReadOnly = true;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Pets_Multicolor;
            this.pictureBox1.Location = new System.Drawing.Point(12, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox2.Location = new System.Drawing.Point(806, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 468);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Frm_Consultas_Mascota_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1006, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DataGrd_Consultas_Mascota);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Frm_Consultas_Mascota_Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Frm_Consultas_Mascota_Select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrd_Consultas_Mascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.DataGridView DataGrd_Consultas_Mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número_Historia_Clinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número_Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Número_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}