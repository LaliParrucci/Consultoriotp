using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.DataAccessLayer
{
    class Service
    {
        public int convertirA0(Object row)
        {
            int num;
            if (row.ToString() == "")
            {
                num = 0;
            }
            else { num = Convert.ToInt32(row.ToString()); }
            return num;
        }
    }
}
