using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.Servicios;

namespace WindowsFormsApp1.Interfaces.Calendarios_Vac
{
    public partial class Frm_Borrar_Cal_Y_Det : Form
    {
        private Calendario_Vacunacion calendario;
        private CalendariosVacServicio calendario_servicio;
        private DetalleCalendarioVacServicio detalle_servicio;

        public Frm_Borrar_Cal_Y_Det(long id)
        {
            detalle_servicio = new DetalleCalendarioVacServicio();
            calendario_servicio = new CalendariosVacServicio();
            calendario = calendario_servicio.GetCalendario(id);
            InitializeComponent();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                BorrarCalendarioYDetalles();
                CerrarFormulario();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form consultar_calendarios = new Frm_Consultar_Calendarios_Vac();
            consultar_calendarios.Show();
            this.Dispose();
        }

        private void BorrarCalendarioYDetalles()
        {
            calendario_servicio.BorrarCalendarioYDetalles(calendario);
            detalle_servicio.BorrarCalendarioYDetalles(calendario.nro_calendario_vac);
            MessageBox.Show("La operación se realizó con éxito", "Información", MessageBoxButtons.OK);
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Form consultar_calendarios = new Frm_Consultar_Calendarios_Vac();
            consultar_calendarios.Show();
            this.Dispose();
        }
    }
}
