using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Interfaces.Empleados;
using WindowsFormsApp1.Servicios;

namespace WindowsFormsApp1.Interfaces.Laboratorios
{
    public partial class Consultar_Laboratorio : Form
    {
        private LaboratoriosServicio labService;

        public Consultar_Laboratorio()
        {
            labService = new LaboratoriosServicio();
            InitializeComponent();
        }

        private void Consultar_Laboratorio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_PAV_3K2_2021_12DataSet.LABORATORIOS' Puede moverla o quitarla según sea necesario.
            this.lABORATORIOSTableAdapter.Fill(this._PAV_3K2_2021_12DataSet.LABORATORIOS);

        }

        private void BtnCL_Salir_Click(object sender, EventArgs e)
        {
            Form menu = new Frm_Menu_Insumos();
            menu.Show();
            this.Dispose();
        }

        

        private void Btn_Eliminar_Laboratorio_Click(object sender, EventArgs e)
        {
            if (dataGrd_Consultar_Laboratorio.SelectedRows.Count == 1)
            {
                //LLamar Modificar
                var id = Convert.ToInt32(dataGrd_Consultar_Laboratorio.SelectedRows[0].Cells["idlaboratorioDataGridViewTextBoxColumn"].Value);
                new Eliminar_Laboratorio(id).Show();
                Visible = false;
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }

        private void dataGrd_Consultar_Laboratorio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Modificar_Laboratorio_Click(object sender, EventArgs e)
        {
            if (dataGrd_Consultar_Laboratorio.SelectedRows.Count == 1)
            {
                //LLamar Modificar
                var id = Convert.ToInt32(dataGrd_Consultar_Laboratorio.SelectedRows[0].Cells["idlaboratorioDataGridViewTextBoxColumn"].Value);
                new Modificar_Laboratorio(id).Show();
                Visible = false;
                return;
            }
            MessageBox.Show("Debe seleccionar solo un registro.", "Información", MessageBoxButtons.OK);
        }
    }
}
