using Consultorio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.DataAccessLayer;

namespace Consultorio.BussinessLayer
{
    class TurnoService
    {
        internal IList<Turno> recuperarTurnos()
        {
            throw new NotImplementedException();
        }

        private TurnoDao oTurnoDao;
        private Practica oPractica = new Practica();
        public void comenzarTransaccion()
        {
            oTurnoDao.conectarConTransaccion();
        }
    }
}
