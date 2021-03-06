﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.DataAccessLayer;
using System.Data;
using Consultorio.Entities;
using System.Windows.Forms;

namespace Consultorio.BussinessLayer
{
    class PracticaService
    {
        private PracticaDao oPracticaDao;
        private Practica oPractica = new Practica();
        public PracticaService()
        {
            oPracticaDao = new PracticaDao();
        }
        public IList<Practica> recuperarPracticas()
        {
            return oPracticaDao.GetAll();
        }
        public DataTable recuPracticasObraSocial(int id, string desde, string hasta)
        {
            return oPracticaDao.ObtenerListadoPracticasConObraSocial(id, desde, hasta);
        }
        public DataTable recuPracticasProfesional(int id, string desde, string hasta)
        {
            return oPracticaDao.ObtenerListadoPracticasConProfesional(id, desde, hasta);
        }
        public Practica recuperarPracticasPorId(int id)
        {
            return oPracticaDao.GetPractica(id);
        }

        public Practica recuperarPracticasPorNom(string nom)
        {
            return oPracticaDao.GetPracticaNom(nom);
        }

        public bool validarPractica(Practica obPractica)
        {
            if (obPractica.Nombre == string.Empty)
            {
                MessageBox.Show("Debe ingresar un nombre para la práctica", "Nombre de práctica vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public bool existePractica(int id)
        {
            if (oPracticaDao.GetPractica(id) != null) { return true; }
            return false;
        }
        public void altaPractica(Practica ob, bool esAlta)
        {
            string nom = ob.Nombre;
            string desc = ob.Descripcion;
            int imp = ob.Importe;
            int id = ob.Id_practica;
            oPracticaDao.actualizacion(nom, desc, imp, id, esAlta);
        }
        public void bajaPractica(int id)
        {
            oPracticaDao.baja(id);
        }
    }
}    
