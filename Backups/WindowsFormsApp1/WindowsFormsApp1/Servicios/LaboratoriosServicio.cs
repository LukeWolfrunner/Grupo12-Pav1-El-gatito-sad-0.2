using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.RepositoriosBD;

namespace WindowsFormsApp1.Servicios
{
    class LaboratoriosServicio
    {
        private LaboratoriosRepositorio labRepo;

        public LaboratoriosServicio(LaboratoriosRepositorio laboRepo)
        {
            labRepo = laboRepo;
        }
        public LaboratoriosServicio() 
        {
            labRepo = new LaboratoriosRepositorio();
        }

        
        public bool RegistrarLaboratorio(Laboratorio lab)
        {
            if (lab == null)
                throw new ApplicationException("Laboratorio requerido");
            var filasAfectadas = labRepo.RegistrarLaboratorio(lab);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

        public Laboratorio GetLaboratorio(long id)
        {
            var laboratorio = labRepo.GetLaboratorio(id);
            return laboratorio;
        }
        public void ActualizarLaboratorio(Laboratorio lab)
        {
            var filasAfectadas = labRepo.ActualizarLaboratorio(lab);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }
        public void DarBajaLaboratorio(Laboratorio lab)
        {
            var filasAfectadas = labRepo.DarBajaLaboratorio(lab);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al eliminar.");
        }
    }
}
