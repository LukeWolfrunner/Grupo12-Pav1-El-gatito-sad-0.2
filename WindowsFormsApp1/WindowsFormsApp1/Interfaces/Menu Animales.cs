﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Interfaces.Razas;

namespace WindowsFormsApp1.Interfaces
{
    public partial class Frm_Menu_Animales : Form
    {
        public Frm_Menu_Animales()
        {
            InitializeComponent();
        }

        private void Btn_Animales_Salir_Click(object sender, EventArgs e)
        {
            Form menu_principal = new FrmMenu_Principal();
            menu_principal.Show();
            this.Dispose();
        }

        private void Btn_Registrar_Raza_Click(object sender, EventArgs e)
        {
            Form menu_registrar_raza = new Frm_Registrar_Raza();
            menu_registrar_raza.Show();
            this.Dispose();
        }
    }
}
