﻿
namespace WindowsFormsApp1
{
    partial class FrmMenu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu_Principal));
            this.mascotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevaMascotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMascotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verContactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarMedicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVacunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verStockToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDiagnosticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDiagnosticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especieDeMascotaMasAtendidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usoDeMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dueñosYMascotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratoriosYMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticosYConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verSintomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarSintomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Bienvenido = new System.Windows.Forms.Label();
            this.BtnMP_Salir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mascotasToolStripMenuItem
            // 
            this.mascotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevaMascotaToolStripMenuItem,
            this.verMascotasToolStripMenuItem});
            this.mascotasToolStripMenuItem.Name = "mascotasToolStripMenuItem";
            this.mascotasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.mascotasToolStripMenuItem.Text = "Mascotas";
            // 
            // registrarNuevaMascotaToolStripMenuItem
            // 
            this.registrarNuevaMascotaToolStripMenuItem.Name = "registrarNuevaMascotaToolStripMenuItem";
            this.registrarNuevaMascotaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.registrarNuevaMascotaToolStripMenuItem.Text = "Registrar nueva mascota";
            // 
            // verMascotasToolStripMenuItem
            // 
            this.verMascotasToolStripMenuItem.Name = "verMascotasToolStripMenuItem";
            this.verMascotasToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.verMascotasToolStripMenuItem.Text = "Ver mascotas";
            // 
            // laboratorioToolStripMenuItem
            // 
            this.laboratorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarLaboratorioToolStripMenuItem,
            this.verContactosToolStripMenuItem});
            this.laboratorioToolStripMenuItem.Name = "laboratorioToolStripMenuItem";
            this.laboratorioToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.laboratorioToolStripMenuItem.Text = "Laboratorios";
            this.laboratorioToolStripMenuItem.Click += new System.EventHandler(this.laboratorioToolStripMenuItem_Click);
            // 
            // registrarLaboratorioToolStripMenuItem
            // 
            this.registrarLaboratorioToolStripMenuItem.Name = "registrarLaboratorioToolStripMenuItem";
            this.registrarLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.registrarLaboratorioToolStripMenuItem.Text = "Registrar laboratorio";
            this.registrarLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.registrarLaboratorioToolStripMenuItem_Click);
            // 
            // verContactosToolStripMenuItem
            // 
            this.verContactosToolStripMenuItem.Name = "verContactosToolStripMenuItem";
            this.verContactosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.verContactosToolStripMenuItem.Text = "Ver contactos";
            this.verContactosToolStripMenuItem.Click += new System.EventHandler(this.verContactosToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.mascotasToolStripMenuItem,
            this.medicamentoToolStripMenuItem,
            this.vacunasToolStripMenuItem,
            this.laboratorioToolStripMenuItem,
            this.diagnosticosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.reportesToolStripMenuItem,
            this.listadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem,
            this.verUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.usuariosToolStripMenuItem.Text = "Empleados";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.iniciarSesionToolStripMenuItem.Text = "Registrar empleados";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // verUsuariosToolStripMenuItem
            // 
            this.verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            this.verUsuariosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.verUsuariosToolStripMenuItem.Text = "Ver empleados";
            this.verUsuariosToolStripMenuItem.Click += new System.EventHandler(this.verUsuariosToolStripMenuItem_Click);
            // 
            // medicamentoToolStripMenuItem
            // 
            this.medicamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarMedicamentoToolStripMenuItem,
            this.verStockToolStripMenuItem});
            this.medicamentoToolStripMenuItem.Name = "medicamentoToolStripMenuItem";
            this.medicamentoToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.medicamentoToolStripMenuItem.Text = "Medicamentos";
            this.medicamentoToolStripMenuItem.Click += new System.EventHandler(this.medicamentoToolStripMenuItem_Click);
            // 
            // registrarMedicamentoToolStripMenuItem
            // 
            this.registrarMedicamentoToolStripMenuItem.Name = "registrarMedicamentoToolStripMenuItem";
            this.registrarMedicamentoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.registrarMedicamentoToolStripMenuItem.Text = "Registrar medicamento";
            this.registrarMedicamentoToolStripMenuItem.Click += new System.EventHandler(this.registrarMedicamentoToolStripMenuItem_Click);
            // 
            // verStockToolStripMenuItem
            // 
            this.verStockToolStripMenuItem.Name = "verStockToolStripMenuItem";
            this.verStockToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.verStockToolStripMenuItem.Text = "Ver stock";
            // 
            // vacunasToolStripMenuItem
            // 
            this.vacunasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVacunaToolStripMenuItem,
            this.verStockToolStripMenuItem1});
            this.vacunasToolStripMenuItem.Name = "vacunasToolStripMenuItem";
            this.vacunasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.vacunasToolStripMenuItem.Text = "Vacunas";
            // 
            // registrarVacunaToolStripMenuItem
            // 
            this.registrarVacunaToolStripMenuItem.Name = "registrarVacunaToolStripMenuItem";
            this.registrarVacunaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarVacunaToolStripMenuItem.Text = "Registrar vacuna";
            this.registrarVacunaToolStripMenuItem.Click += new System.EventHandler(this.registrarVacunaToolStripMenuItem_Click);
            // 
            // verStockToolStripMenuItem1
            // 
            this.verStockToolStripMenuItem1.Name = "verStockToolStripMenuItem1";
            this.verStockToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.verStockToolStripMenuItem1.Text = "Ver stock";
            // 
            // diagnosticosToolStripMenuItem
            // 
            this.diagnosticosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarDiagnosticoToolStripMenuItem,
            this.verDiagnosticosToolStripMenuItem});
            this.diagnosticosToolStripMenuItem.Name = "diagnosticosToolStripMenuItem";
            this.diagnosticosToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.diagnosticosToolStripMenuItem.Text = "Diagnosticos ";
            // 
            // registrarDiagnosticoToolStripMenuItem
            // 
            this.registrarDiagnosticoToolStripMenuItem.Name = "registrarDiagnosticoToolStripMenuItem";
            this.registrarDiagnosticoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.registrarDiagnosticoToolStripMenuItem.Text = "Registrar diagnostico";
            this.registrarDiagnosticoToolStripMenuItem.Click += new System.EventHandler(this.registrarDiagnosticoToolStripMenuItem_Click);
            // 
            // verDiagnosticosToolStripMenuItem
            // 
            this.verDiagnosticosToolStripMenuItem.Name = "verDiagnosticosToolStripMenuItem";
            this.verDiagnosticosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.verDiagnosticosToolStripMenuItem.Text = "Ver diagnosticos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem,
            this.especieDeMascotaMasAtendidaToolStripMenuItem,
            this.usoDeMedicamentosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem
            // 
            this.cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem.Name = "cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem";
            this.cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem.Text = "Atencion de mascotas por empleado";
            this.cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem_Click);
            // 
            // especieDeMascotaMasAtendidaToolStripMenuItem
            // 
            this.especieDeMascotaMasAtendidaToolStripMenuItem.Name = "especieDeMascotaMasAtendidaToolStripMenuItem";
            this.especieDeMascotaMasAtendidaToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.especieDeMascotaMasAtendidaToolStripMenuItem.Text = "Especies de mascotas mas atendidas";
            // 
            // usoDeMedicamentosToolStripMenuItem
            // 
            this.usoDeMedicamentosToolStripMenuItem.Name = "usoDeMedicamentosToolStripMenuItem";
            this.usoDeMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.usoDeMedicamentosToolStripMenuItem.Text = "Frecuencia de uso de medicamentos";
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dueñosYMascotasToolStripMenuItem,
            this.laboratoriosYMedicamentosToolStripMenuItem,
            this.diagnosticosYConsultasToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // dueñosYMascotasToolStripMenuItem
            // 
            this.dueñosYMascotasToolStripMenuItem.Name = "dueñosYMascotasToolStripMenuItem";
            this.dueñosYMascotasToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.dueñosYMascotasToolStripMenuItem.Text = "Dueños y mascotas";
            // 
            // laboratoriosYMedicamentosToolStripMenuItem
            // 
            this.laboratoriosYMedicamentosToolStripMenuItem.Name = "laboratoriosYMedicamentosToolStripMenuItem";
            this.laboratoriosYMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.laboratoriosYMedicamentosToolStripMenuItem.Text = "Laboratorios y medicamentos";
            // 
            // diagnosticosYConsultasToolStripMenuItem
            // 
            this.diagnosticosYConsultasToolStripMenuItem.Name = "diagnosticosYConsultasToolStripMenuItem";
            this.diagnosticosYConsultasToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.diagnosticosYConsultasToolStripMenuItem.Text = "Diagnosticos y consultas";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verSintomasToolStripMenuItem,
            this.registrarSintomaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.toolStripMenuItem1.Text = "Sintomas";
            // 
            // verSintomasToolStripMenuItem
            // 
            this.verSintomasToolStripMenuItem.Name = "verSintomasToolStripMenuItem";
            this.verSintomasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verSintomasToolStripMenuItem.Text = "Ver sintomas";
            this.verSintomasToolStripMenuItem.Click += new System.EventHandler(this.verSintomasToolStripMenuItem_Click);
            // 
            // registrarSintomaToolStripMenuItem
            // 
            this.registrarSintomaToolStripMenuItem.Name = "registrarSintomaToolStripMenuItem";
            this.registrarSintomaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarSintomaToolStripMenuItem.Text = "Registrar sintoma";
            // 
            // Bienvenido
            // 
            this.Bienvenido.Font = new System.Drawing.Font("Copperplate Gothic Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenido.Location = new System.Drawing.Point(385, 43);
            this.Bienvenido.Name = "Bienvenido";
            this.Bienvenido.Size = new System.Drawing.Size(297, 54);
            this.Bienvenido.TabIndex = 1;
            this.Bienvenido.Text = "¡¡Bienvenido!!";
            this.Bienvenido.Click += new System.EventHandler(this.Bienvenido_Click);
            // 
            // BtnMP_Salir
            // 
            this.BtnMP_Salir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnMP_Salir.Location = new System.Drawing.Point(492, 388);
            this.BtnMP_Salir.Name = "BtnMP_Salir";
            this.BtnMP_Salir.Size = new System.Drawing.Size(116, 39);
            this.BtnMP_Salir.TabIndex = 2;
            this.BtnMP_Salir.Text = "Salir";
            this.BtnMP_Salir.UseVisualStyleBackColor = false;
            this.BtnMP_Salir.Click += new System.EventHandler(this.BtnMP_Salir_Click);
            // 
            // FrmMenu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(682, 439);
            this.Controls.Add(this.BtnMP_Salir);
            this.Controls.Add(this.Bienvenido);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mascotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevaMascotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMascotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verContactosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarMedicamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarLaboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVacunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeMascotasAtendidasPorEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especieDeMascotaMasAtendidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usoDeMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dueñosYMascotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratoriosYMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticosYConsultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verStockToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem diagnosticosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarDiagnosticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDiagnosticosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUsuariosToolStripMenuItem;
        private System.Windows.Forms.Label Bienvenido;
        private System.Windows.Forms.Button BtnMP_Salir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verSintomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarSintomaToolStripMenuItem;
    }
}
