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
        public static List<Seferler> GetSeferlers(int GuzergahId)
        {
            return datacontext.Seferlers.Where(a => a.GuzergahID == GuzergahId).ToList();
        }
    }
}
