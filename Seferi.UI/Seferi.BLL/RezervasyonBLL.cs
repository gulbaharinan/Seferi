using Seferi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seferi.BLL
{
   public static class RezervasyonBLL
    {
       static SeferiEntities datacontext = new SeferiEntities();
        public static void AddRezervasyon(Rezervasyonlar rezervasyon)
        {
            Rezervasyonlar rezerve = new Rezervasyonlar();
            rezerve.MusteriAdiSoyadi = rezervasyon.MusteriAdiSoyadi;
            rezerve.MusteriTCKN = rezervasyon.MusteriTCKN;
            rezerve.InisDurakID = rezervasyon.InisDurakID;
            rezerve.BinisDurakID = rezervasyon.BinisDurakID;
            rezerve.SeferID = rezervasyon.SeferID;
            rezerve.Aciklama = rezervasyon.Aciklama;

            datacontext.Rezervasyonlars.Add(rezerve);
            datacontext.SaveChanges();

            
        }

    }
}
