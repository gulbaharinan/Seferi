using Seferi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seferi.BLL
{
    public static class DurakBLL
    {
        static SeferiEntities datacontext = new SeferiEntities();

        public static List<Duraklar> GetDuraklar()
        {
            return datacontext.Duraklars.ToList();
        }

        public static object GetNereye(int DurakId)
        {
            List<int> guzergahIDs = datacontext.GuzergahDuraklaris.Where(x => x.DurakID == DurakId).Select(a=>a.GuzergahID).ToList();
            List<int> durakIDs = datacontext.GuzergahDuraklaris.Where(x => guzergahIDs.Contains(x.GuzergahID)).Select(a => a.DurakID).ToList();
            List<Duraklar> duraklar = datacontext.Duraklars.Where(a => durakIDs.Contains(a.DurakID)).ToList();
            return duraklar;
        }

        public static List<GuzergahDuraklari> GetGuzergahDuraklaris(int ıd)
        {
            return datacontext.GuzergahDuraklaris.Where(a => a.DurakID == ıd).ToList();

        }

       
    }
}
