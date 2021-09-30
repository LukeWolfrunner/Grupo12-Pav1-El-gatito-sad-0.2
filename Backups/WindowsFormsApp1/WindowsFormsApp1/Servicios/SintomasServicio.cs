﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.RepositoriosBD;



namespace WindowsFormsApp1.Servicios
{
    class SintomasServicio
    {

        private SintomasRepositorio sint_Repositorio;
        public SintomasServicio()
        {
            sint_Repositorio = new SintomasRepositorio();
        }

        public bool RegistrarSintomaSR(Sintoma sint)
        {
            if (sint == null)
                throw new ApplicationException("Sintoma requerido");
            var filasAfectadas = sint_Repositorio.RegistrarSintomaBD(sint);
            if (filasAfectadas == 1)
                return true;
            return false;
        }
    }
}