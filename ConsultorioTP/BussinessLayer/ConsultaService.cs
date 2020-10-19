﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.DataAccessLayer;
using Consultorio.Entities;
using System.Data;
using System.Windows.Forms;

namespace Consultorio.BussinessLayer
{
    class ConsultaService
    {
        //public bool crearTurnoConHistorial(Turno oTurno, string obs)
        //{
        //    return oTurnoDao.crearTurnoConHistorial(oTurno, obs);
        //}

        private ConsultaDao oConsultaDao;
        private Consulta oConsulta = new Consulta();
        public ConsultaService()
        {
            oConsultaDao = new ConsultaDao();
        }
        public IList<Consulta> recuperarConsultas()
        {
            return oConsultaDao.GetAll();
        }


        public bool crearConsultaTransaccion(Consulta consulta)
        {
            return oConsultaDao.crearConsulta(consulta);
        }

        public bool validarInsumo(string n, string s)
        {
            if (n == string.Empty)
            {
                MessageBox.Show("Ingrese un nombre, por favor", "Nombre de insumo vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try { Convert.ToInt32(s); }
            catch
            {
                MessageBox.Show("Ingrese una cantidad válida para el stock, por favor", "Stock asignado inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        internal DataTable recuperarPacientesPorProfesionalPorfecha(DateTime desde, DateTime hasta)
        {
            return oConsultaDao.recuperarPacientePorProfesionalPorFecha(desde, hasta);
        }
        //public bool existeInsumo(int id)
        //{
        //    if (this.recuperarInsumoPorId(id) != null) { return true; }
        //    return false;
        //}

    }
}
