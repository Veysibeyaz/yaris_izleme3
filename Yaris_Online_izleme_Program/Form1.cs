using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yaris_Online_izleme_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        private void pictureBox1_Click(object sender, EventArgs e)
        { 
           // radialMenu1.ShowPopup(Cursor.Position); 
        }

        GANI_S7COM con = new GANI_S7COM();
        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void tmrGecikme_Tick(object sender, EventArgs e)
        {
            tmrGecikme.Stop();
            this.Close();
        }

        private void toolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            txtIPAdres.Text = Properties.Settings.Default.IP_ADRES;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IP_ADRES = txtIPAdres.Text;
            Properties.Settings.Default.Save();
        }

        private void btnTekrarBaglan_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void tmrAcilisGecikme_Tick(object sender, EventArgs e)
        {
           tmrAcilisGecikme.Stop();
            try
            {
               //con.Conn("S71200", Properties.Settings.Default.IP_ADRES);
                con.Conn("S71200", "192.168.16.1");
                if (!con.SoketDurum)
                {
                    progressConn.Description = "Soket Açılamadı : " + con.PLC_Message_Label;
                    btnTekrarBaglan.Visible = true;
                }
                else if (!con.BaglantiDurum)
                {
                    progressConn.Description = "Haberleşme Sağlanamadı : " + con.PLC_Message_Label;
                    btnTekrarBaglan.Visible = true;
                }
                else
                {
                    progressConn.Description = "Haberleşme Başarılı Şekilde Kuruldu";
                    tmrGecikme.Start();
                }
            }
            catch
            {
                MessageBox.Show("baglantı yok plc");
            }
        }
    }
}
