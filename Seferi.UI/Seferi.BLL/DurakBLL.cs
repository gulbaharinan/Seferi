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
            var guzergah = datacontext.GuzergahDuraklaris.Where(x => x.DurakID == DurakId && x.Sira!=6);
            var durak = datacontext.GuzergahDuraklaris.Where(x => guzergah.Any(a => a.GuzergahID == x.GuzergahID)).Select(
                c => new
                {
                    c.DurakID,
                    c.Duraklar.DurakAdi,
                    c.GuzergahID,
                    c.Sira

                }
                );
            return durak.ToList();
        }

       
    }
}
