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
            frm.BinisDurakId =int.Parse(cmb_Nereden.SelectedValue.ToString());
            frm.InisDurakId = int.Parse(cmb_Nereye.SelectedValue.ToString());
            frm.ShowDialog();
            

        }
        
        private void frm_GüzergahSecimi_Load(object sender, EventArgs e)
        {       
            cmb_Nereden.DataSource= DurakBLL.GetDuraklar();
            cmb_Nereden.DisplayMember = "DurakAdi";
        }

        private void cmb_Nereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Nereden.ValueMember = "DurakID";
            int durakId = Convert.ToInt32(cmb_Nereden.SelectedValue);
            var Durak = DurakBLL.GetNereye(durakId);
            cmb_Nereye.DataSource = Durak;
            cmb_Nereye.DisplayMember = "DurakAdi";           
        }

        private void cmb_Nereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Nereye.ValueMember = "DurakID";            
            int DurakID = Convert.ToInt32(cmb_Nereye.SelectedValue);
            dgv_Sefer.DataSource = SeferBLL.GetSeferlers(DurakID);
            
        }
    }
}
