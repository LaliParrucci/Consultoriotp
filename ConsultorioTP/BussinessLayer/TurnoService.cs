using Consultorio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.DataAccessLayer;
using System.Windows.Forms;
using System.Data;

namespace Consultorio.BussinessLayer
{
    class TurnoService
    {
        internal IList<Turno> recuperarTurnos()
        {
            return oTurnoDao.GetAll();
        }

        private TurnoDao oTurnoDao = new TurnoDao();

        public bool crearTurnoConHistorial(Turno oTurno, string obs)
        {
            return oTurnoDao.crearTurnoConHistorial(oTurno, obs);
        }

        public IList<Turno> recuperarTurnoFecha(DateTime fecha)
        {
            return oTurnoDao.GetTurnoFecha(fecha);
        }

        public bool validarTurno(Turno ob, string disp)
        {
            if(ob.Fecha == null )
            {
                MessageBox.Show("Debe seleccionar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (disp == "NO")
            {
                MessageBox.Show("Debe seleccionar una hora que esté disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public Turno getTurnoFechaHoraProfesional(DateTime fecha, string hora, int id)
        {
            return oTurnoDao.getTurnoFechaHoraProf(fecha, hora, id);
        }

        internal Turno recuperarTurnoFechaDni(DateTime today, string dni)
        {
            return oTurnoDao.GetTurnoFechaDni(today, dni);
        }

        public bool eliminarTurnoConHistorial(Turno oTurno)
        {
            return oTurnoDao.eliminarTurnoConHistorial(oTurno);
        }

        public bool modificarTurnoConHistorialS(Turno oTurno, string observacion, Turno turnoViejo)
        {
            return oTurnoDao.modificarTurnoConHistorial(oTurno, observacion, turnoViejo);
        }

        public DataTable estadisticaConcretados(string desde, string hasta)
        {
            return oTurnoDao.estadisticaConcretados(desde, hasta);
        }
    }
}
