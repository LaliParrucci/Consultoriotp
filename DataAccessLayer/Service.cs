using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.DataAccessLayer
{
    static class Service
    {
        public static int convertirA0(Object row)
        {
            int num;
            if (row.ToString() == "")
            {
                num = 0;
            }
            else { num = Convert.ToInt32(row.ToString()); }
            return num;
        }
        public static int esInt(string num)
        {
            try
            {
                return Convert.ToInt32(num);
            }
            catch(Exception e)
            {
                return 0;
            }
        }
    }
}
