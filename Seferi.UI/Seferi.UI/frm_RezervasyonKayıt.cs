using Seferi.BLL;
using Seferi.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seferi.UI
{
    public partial class frm_RezervasyonKayıt : Form
    {
        public frm_RezervasyonKayıt()
        {
            InitializeComponent();
        }

        public int SeferId { get; internal set; }
        public int BinisDurakId { get; internal set; }
        public int InisDurakId { get; internal set; }

        private void btn_RezervasyonKaydet_Click(object sender, EventArgs e)
        {
            Rezervasyonlar rezervasyon = new Rezervasyonlar();
            rezervasyon.MusteriAdiSoyadi = txt_AdSoyad.Text;
            rezervasyon.MusteriTCKN = txt_TCKN.Text;
            rezervasyon.SeferID = SeferId;
            rezervasyon.BinisDurakID = BinisDurakId;
            rezervasyon.InisDurakID = InisDurakId;
            rezervasyon.Aciklama = rtxt_Aciklama.Text;

            RezervasyonBLL.AddRezervasyon(rezervasyon);
            MessageBox.Show("Rezervasyonunuz Alınmıştır.");

        }
    }
}
