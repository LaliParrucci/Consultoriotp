using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.BussinessLayer
{
    class ConsultaService
    {
        public bool crearTurnoConHistorial(Turno oTurno, string obs)
        {
            return oTurnoDao.crearTurnoConHistorial(oTurno, obs);
        }
    }
}
