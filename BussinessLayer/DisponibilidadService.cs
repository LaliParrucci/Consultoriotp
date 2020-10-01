using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.DataAccessLayer;
using Consultorio.Entities;

namespace Consultorio.BussinessLayer
{
    class DisponibilidadService
    {
        TurnoDao oTurnoDao = new TurnoDao();
        public IList<Disponibilidad> recuperarTurno(string matricula, string fecha)
        {
            return oTurnoDao.GetTodos(matricula, fecha); 
        }

        public IList<Disponibilidad> recuperarTurnoDisp(string matricula, string fecha)
        {
            return oTurnoDao.GetTodosDisp(matricula, fecha);
        }
    }
}
