
namespace WindowsFormsApp1.Interfaces.Sintomas
{
    partial class Frm_Registrar_Sintoma
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
            this.Txt_Registrar_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Registrar_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Registrar_Sintoma = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Registrar_Nombre
            // 
            this.Txt_Registrar_Nombre.Location = new System.Drawing.Point(31, 55);
            this.Txt_Registrar_Nombre.Name = "Txt_Registrar_Nombre";
            this.Txt_Registrar_Nombre.Size = new System.Drawing.Size(163, 20);
            this.Txt_Registrar_Nombre.TabIndex = 0;
            // 
            // Txt_Registrar_Descripcion
            // 
            this.Txt_Registrar_Descripcion.Location = new System.Drawing.Point(242, 55);
            this.Txt_Registrar_Descripcion.Multiline = true;
            this.Txt_Registrar_Descripcion.Name = "Txt_Registrar_Descripcion";
            this.Txt_Registrar_Descripcion.Size = new System.Drawing.Size(414, 254);
            this.Txt_Registrar_Descripcion.TabIndex = 1;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Nombre.Location = new System.Drawing.Point(31, 28);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(105, 13);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre del síntoma:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(239, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripción del síntoma:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Sintomas;
            this.pictureBox1.Location = new System.Drawing.Point(34, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Registrar_Sintoma
            // 
            this.Btn_Registrar_Sintoma.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Registrar_Sintoma.Location = new System.Drawing.Point(383, 334);
            this.Btn_Registrar_Sintoma.Name = "Btn_Registrar_Sintoma";
            this.Btn_Registrar_Sintoma.Size = new System.Drawing.Size(125, 40);
            this.Btn_Registrar_Sintoma.TabIndex = 5;
            this.Btn_Registrar_Sintoma.Text = "Registrar";
            this.Btn_Registrar_Sintoma.UseVisualStyleBackColor = false;
            this.Btn_Registrar_Sintoma.Click += new System.EventHandler(this.Btn_Registrar_Sintoma_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Salir.Location = new System.Drawing.Point(531, 333);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(125, 40);
            this.Btn_Salir.TabIndex = 6;
            this.Btn_Salir.Text = "Cancelar";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Frm_Registrar_Sintoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(684, 391);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Registrar_Sintoma);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.Txt_Registrar_Descripcion);
            this.Controls.Add(this.Txt_Registrar_Nombre);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Frm_Registrar_Sintoma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar síntoma";
            this.Load += new System.EventHandler(this.Registrar_Sintoma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Registrar_Nombre;
        private System.Windows.Forms.TextBox Txt_Registrar_Descripcion;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Registrar_Sintoma;
        private System.Windows.Forms.Button Btn_Salir;
    }
}