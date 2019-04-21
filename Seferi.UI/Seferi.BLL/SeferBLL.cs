using Seferi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seferi.BLL
{
   public static class SeferBLL
    {
        static SeferiEntities datacontext = new SeferiEntities();
        public static object GetSeferlers(int DurakID)
        {
            var durak = datacontext.GuzergahDuraklaris.Where(x=>x.DurakID==DurakID);
            var guzergah= datacontext.Seferlers.Where(x =>durak.Any(a=>x.GuzergahID==a.GuzergahID));
            return guzergah.ToList();
        }
    }
}
