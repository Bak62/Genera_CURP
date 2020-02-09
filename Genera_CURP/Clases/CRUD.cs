using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Genera_CURP.Modelos;

namespace Genera_CURP.Clases
{
    public class CRUD
    {
        public static bool SavePersona(tbPersona p)
        {
            try
            {
                using (bdCURPEntities _entity = new bdCURPEntities())
                {
                    _entity.tbPersonas.Add(p);
                    _entity.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
