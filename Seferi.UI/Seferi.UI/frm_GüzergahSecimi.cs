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
    public partial class frm_GüzergahSecimi : Form
    {
        public frm_GüzergahSecimi()
        {
            InitializeComponent();
        }

        private void btn_RezervasyonEkle_Click(object sender, EventArgs e)
        {
            frm_RezervasyonKayıt frm = new frm_RezervasyonKayıt();
            frm.SeferId = int.Parse(dgv_Sefer.SelectedRows[0].Cells["SeferID"].Value.ToString());
            frm.BinisDurakId = int.Parse(cmb_Nereden.SelectedValue.ToString());
            frm.InisDurakId = int.Parse(cmb_Nereye.SelectedValue.ToString());
            frm.ShowDialog();

        }

        private void frm_GüzergahSecimi_Load(object sender, EventArgs e)
        {
            cmb_Nereden.DisplayMember = "DurakAdi";
            cmb_Nereden.ValueMember = "DurakID";
            cmb_Nereden.DataSource = DurakBLL.GetDuraklar();
        }

        private void cmb_Nereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            int durakId = Convert.ToInt32(cmb_Nereden.SelectedValue);
            var Durak = DurakBLL.GetNereye(durakId);
            cmb_Nereye.DisplayMember = "DurakAdi";
            cmb_Nereye.ValueMember = "DurakID";
            cmb_Nereye.DataSource = Durak;
        }

        private void cmb_Nereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            int binisdurakid = (int)cmb_Nereden.SelectedValue;
            int inisdurakid = (int)cmb_Nereye.SelectedValue;

            List<GuzergahDuraklari> binis = DurakBLL.GetGuzergahDuraklaris(binisdurakid);
            List<GuzergahDuraklari> inis = DurakBLL.GetGuzergahDuraklaris(inisdurakid);

            foreach (var item in binis)
            {
                foreach (var item2 in inis)
                {
                    if (item.GuzergahID==item2.GuzergahID && item.Sira<item2.Sira)
                    {
                        dgv_Sefer.DataSource = SeferBLL.GetSeferlers(item.GuzergahID);
                    }
                }
            }

            
        }
    }
}
