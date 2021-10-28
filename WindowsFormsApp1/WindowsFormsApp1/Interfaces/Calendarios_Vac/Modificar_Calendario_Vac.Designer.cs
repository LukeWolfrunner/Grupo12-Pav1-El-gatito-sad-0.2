﻿
namespace WindowsFormsApp1.Interfaces.Calendarios_Vac
{
    partial class Frm_Modificar_Calendario_Vac
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
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Txt_Observaciones = new System.Windows.Forms.TextBox();
            this.Btn_Ver_Mascotas = new System.Windows.Forms.Button();
            this.Dtp_Fecha_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Cmb_Nro_Historia_Clinica = new System.Windows.Forms.ComboBox();
            this.Lbl_Observaciones = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Inicio = new System.Windows.Forms.Label();
            this.Lbl_Nro_Historia_Clinica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Cancelar.Location = new System.Drawing.Point(406, 286);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(125, 40);
            this.Btn_Cancelar.TabIndex = 65;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Modificar.Location = new System.Drawing.Point(241, 286);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(125, 40);
            this.Btn_Modificar.TabIndex = 64;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // Txt_Observaciones
            // 
            this.Txt_Observaciones.Location = new System.Drawing.Point(209, 110);
            this.Txt_Observaciones.Multiline = true;
            this.Txt_Observaciones.Name = "Txt_Observaciones";
            this.Txt_Observaciones.Size = new System.Drawing.Size(356, 154);
            this.Txt_Observaciones.TabIndex = 63;
            // 
            // Btn_Ver_Mascotas
            // 
            this.Btn_Ver_Mascotas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Ver_Mascotas.Location = new System.Drawing.Point(440, 24);
            this.Btn_Ver_Mascotas.Name = "Btn_Ver_Mascotas";
            this.Btn_Ver_Mascotas.Size = new System.Drawing.Size(125, 40);
            this.Btn_Ver_Mascotas.TabIndex = 62;
            this.Btn_Ver_Mascotas.Text = "Ver mascotas";
            this.Btn_Ver_Mascotas.UseVisualStyleBackColor = false;
            // 
            // Dtp_Fecha_Inicio
            // 
            this.Dtp_Fecha_Inicio.Location = new System.Drawing.Point(209, 66);
            this.Dtp_Fecha_Inicio.Name = "Dtp_Fecha_Inicio";
            this.Dtp_Fecha_Inicio.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Fecha_Inicio.TabIndex = 61;
            // 
            // Cmb_Nro_Historia_Clinica
            // 
            this.Cmb_Nro_Historia_Clinica.FormattingEnabled = true;
            this.Cmb_Nro_Historia_Clinica.Location = new System.Drawing.Point(209, 24);
            this.Cmb_Nro_Historia_Clinica.Name = "Cmb_Nro_Historia_Clinica";
            this.Cmb_Nro_Historia_Clinica.Size = new System.Drawing.Size(200, 21);
            this.Cmb_Nro_Historia_Clinica.TabIndex = 60;
            // 
            // Lbl_Observaciones
            // 
            this.Lbl_Observaciones.AutoSize = true;
            this.Lbl_Observaciones.Location = new System.Drawing.Point(32, 113);
            this.Lbl_Observaciones.Name = "Lbl_Observaciones";
            this.Lbl_Observaciones.Size = new System.Drawing.Size(81, 13);
            this.Lbl_Observaciones.TabIndex = 59;
            this.Lbl_Observaciones.Text = "Observaciones:";
            // 
            // Lbl_Fecha_Inicio
            // 
            this.Lbl_Fecha_Inicio.AutoSize = true;
            this.Lbl_Fecha_Inicio.Location = new System.Drawing.Point(32, 73);
            this.Lbl_Fecha_Inicio.Name = "Lbl_Fecha_Inicio";
            this.Lbl_Fecha_Inicio.Size = new System.Drawing.Size(151, 13);
            this.Lbl_Fecha_Inicio.TabIndex = 58;
            this.Lbl_Fecha_Inicio.Text = "Fecha de inicio del calendario:";
            // 
            // Lbl_Nro_Historia_Clinica
            // 
            this.Lbl_Nro_Historia_Clinica.AutoSize = true;
            this.Lbl_Nro_Historia_Clinica.Location = new System.Drawing.Point(32, 32);
            this.Lbl_Nro_Historia_Clinica.Name = "Lbl_Nro_Historia_Clinica";
            this.Lbl_Nro_Historia_Clinica.Size = new System.Drawing.Size(133, 13);
            this.Lbl_Nro_Historia_Clinica.TabIndex = 57;
            this.Lbl_Nro_Historia_Clinica.Text = "Número de historia clínica:";
            // 
            // Frm_Modificar_Calendario_Vac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(604, 346);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Txt_Observaciones);
            this.Controls.Add(this.Btn_Ver_Mascotas);
            this.Controls.Add(this.Dtp_Fecha_Inicio);
            this.Controls.Add(this.Cmb_Nro_Historia_Clinica);
            this.Controls.Add(this.Lbl_Observaciones);
            this.Controls.Add(this.Lbl_Fecha_Inicio);
            this.Controls.Add(this.Lbl_Nro_Historia_Clinica);
            this.Name = "Frm_Modificar_Calendario_Vac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar calendario de vacunación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.TextBox Txt_Observaciones;
        private System.Windows.Forms.Button Btn_Ver_Mascotas;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Inicio;
        private System.Windows.Forms.ComboBox Cmb_Nro_Historia_Clinica;
        private System.Windows.Forms.Label Lbl_Observaciones;
        private System.Windows.Forms.Label Lbl_Fecha_Inicio;
        private System.Windows.Forms.Label Lbl_Nro_Historia_Clinica;
    }
}