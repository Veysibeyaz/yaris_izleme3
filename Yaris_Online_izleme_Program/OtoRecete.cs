using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Yaris_Online_izleme_Programı
{
    public partial class OtoRecete : Form
    {
        public OtoRecete()
        {
            InitializeComponent();
        }
        Anasayfa Otorecete = (Anasayfa)Application.OpenForms["Anasayfa"];
        private void btnAc_Click(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedIndex > -1)
            {
                Otorecete.p_ayarlar.recipeOku(lstRecipes.SelectedItem.ToString());
                this.Close();
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtRecete.Text != "")
            {
                Otorecete.p_ayarlar.recipeKaydet(txtRecete.Text);
                receteGoster();
            }
            else
            {
                MessageBox.Show("Kayıt için reçete seçiniz?");
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstRecipes.SelectedIndex > -1)
            {
                if (MessageBox.Show(lstRecipes.Items[lstRecipes.SelectedIndex].ToString() + " isimli reçeteyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    File.Delete(Directory.GetCurrentDirectory() + "\\Recipe\\" + lstRecipes.Items[lstRecipes.SelectedIndex].ToString() + ".sktp");
                }
            }
            receteGoster();
        }
        void receteGoster()
        {
            lstRecipes.Items.Clear();
            string[] paths = Directory.GetFiles(Directory.GetCurrentDirectory() + "//Recipe");
            for (int i = 0; i < paths.Length; i++)
            {
                paths[i] = paths[i].Replace(Directory.GetCurrentDirectory() + "//Recipe", "").Replace(".sktp", "").Replace("\\", "");
            }
            lstRecipes.Items.AddRange(paths);
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OtoRecete_Load(object sender, EventArgs e)
        {
            receteGoster();
        }
        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtRecete.Text = lstRecipes.SelectedItem.ToString();
            }
            catch
            {

            }

        }
    }
}
