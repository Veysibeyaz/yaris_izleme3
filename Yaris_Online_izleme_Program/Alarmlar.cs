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
    public partial class Alarmlar : Form
    {
        public bool degergönder;
        public string[] Alarm_Saati_Vp = new string[40];
        public string[] Alarm_Saati_KK = new string[15];
        public string[] Alarm_Saati_KBK = new string[15];
        public string[] Alarm_Saati_SS = new string[15];
        public string[] Alarm_Saati_S = new string[30];
        public string[] Alarm_Saati_R = new string[30];
        public Alarmlar()
        {
            InitializeComponent();
            /*
             dataGridView1.ColumnCount = 3;
             dataGridView1.Columns[0].Name = "ID";
             dataGridView1.Columns[1].Name = "Adı Soyadı";
             dataGridView1.Columns[2].Name = "E-Mail";

             if (degergönder == true)
                 {
                 //DataGridView satır (veri) ekleme - Dizi ile
                 string[] row = new string[] { "1", "Fatih Alkan", "info@mail.com" };
                 dataGridView1.Rows.Add(row);
                 row = new string[] { "DateTime", degergönder.ToString(), "info@mail.com" };
                 dataGridView1.Rows.Add(row);
                 row = new string[] { "3", "Beyazıt Alkan", "info@mail.com" };
                 dataGridView1.Rows.Add(row);

                 DataTable dt = new DataTable();
                 dt.Columns.Add("ID");
                 dt.Columns.Add("Adı Soyadı");
                 dt.Columns.Add("E-Mail");

                 DataRow drow = dt.NewRow();
                 drow["ID"] = "1";
                 drow["Adı Soyadı"] ="mehmet";
                 drow["E-Mail"] = "info@mail.com";
                 dt.Rows.Add(drow);
                 dataGridView1.DataSource = dt;
             }
             */
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

            //  Vulkanizasyon_Alarm_VP.Items.Clear();
            //  string[] Alarms = new string[2];
            //  ListViewItem itm;
            //  // if (Alarm_Saati_Vp[1] == null){Alarms[1] = "Acil Stop Basılı";} bu eklenecek ************
            //  if (u_anasayfa.Hmı_Alarm_1_VP == true) { if (Alarm_Saati_Vp[1] == null) { Alarm_Saati_Vp[1] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[1]; Alarms[1] = "Panel Acil Stop Basılı"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_2_VP == true) { if (Alarm_Saati_Vp[2] == null) { Alarm_Saati_Vp[2] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[2]; Alarms[1] = "Üst tabla basınç limiti aşıldı"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_3_VP == true) { if (Alarm_Saati_Vp[3] == null) { Alarm_Saati_Vp[3] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[3]; Alarms[1] = "Piston torbaya girme mesafesinden orta kısmına gelene kadar basınc limiti aşıldı"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_4_VP == true) { if (Alarm_Saati_Vp[4] == null) { Alarm_Saati_Vp[4] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[4]; Alarms[1] = "Tutucu malafaları bırakamadı"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_5_VP == true) { if (Alarm_Saati_Vp[5] == null) { Alarm_Saati_Vp[5] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[5]; Alarms[1] = "Tutucu malafaları alamadı"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_6_VP == true) { if (Alarm_Saati_Vp[6] == null) { Alarm_Saati_Vp[6] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[6]; Alarms[1] = "Giris Piston ilerleme hatası, ileride sensör veya ileri basınc sivici hatası"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_7_VP == true) { if (Alarm_Saati_Vp[7] == null) { Alarm_Saati_Vp[7] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[7]; Alarms[1] = "Giris Piston Gerileme hatası, Geride sensör veya Geride basınc sivici hatası"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_8_VP == true) { if (Alarm_Saati_Vp[8] == null) { Alarm_Saati_Vp[8] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[8]; Alarms[1] = "Giris Piston Sensör Çakısma Hatası"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_9_VP == true) { if (Alarm_Saati_Vp[9] == null) { Alarm_Saati_Vp[9] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[9]; Alarms[1] = "Orta Piston ilerleme hatası, ileride sensör veya ileri basınc sivici hatası"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_10_VP == true) { if (Alarm_Saati_Vp[10] == null) { Alarm_Saati_Vp[10] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[10]; Alarms[1] = "Orta Piston Gerileme hatası, geride sensör veya geri basınc sivici hata"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_11_VP == true) { if (Alarm_Saati_Vp[11] == null) { Alarm_Saati_Vp[11] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[11]; Alarms[1] = "Orta Piston Sensör Çakısma Hatası"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_12_VP == true) { if (Alarm_Saati_Vp[12] == null) { Alarm_Saati_Vp[12] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[12]; Alarms[1] = "Cikis Piston ilerleme hatası,ileride sensör veya ileri basınc sivici hatası"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_13_VP == true) { if (Alarm_Saati_Vp[13] == null) { Alarm_Saati_Vp[13] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[13]; Alarms[1] = "Cikis Piston Gerileme hatası, Geride sensör veya Geri basınc sivici hatası"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_14_VP == true) { if (Alarm_Saati_Vp[14] == null) { Alarm_Saati_Vp[14] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[14]; Alarms[1] = "Cikis Piston Sensör Çakısma Hatası"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_15_VP == true) { if (Alarm_Saati_Vp[15] == null) { Alarm_Saati_Vp[15] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[15]; Alarms[1] = "Tutucu Kapatma Hatası, Kapalı basınc sivici hatası"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_16_VP == true) { if (Alarm_Saati_Vp[16] == null) { Alarm_Saati_Vp[16] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[16]; Alarms[1] = "Tutucu Açma Hatası, Açık basınc sivici hatası "; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_17_VP == true) { if (Alarm_Saati_Vp[17] == null) { Alarm_Saati_Vp[17] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[17]; Alarms[1] = "Hidrolik Motor Termik Kapalı(11KW)"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_18_VP == true) { if (Alarm_Saati_Vp[18] == null) { Alarm_Saati_Vp[18] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[18]; Alarms[1] = "Servo Adaption Fault"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_19_VP == true) { if (Alarm_Saati_Vp[19] == null) { Alarm_Saati_Vp[19] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[19]; Alarms[1] = "Servo Communication Fault"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_20_VP == true) { if (Alarm_Saati_Vp[20] == null) { Alarm_Saati_Vp[20] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[20]; Alarms[1] = "Servo Configürasyon Fault"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_21_VP == true) { if (Alarm_Saati_Vp[21] == null) { Alarm_Saati_Vp[21] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[21]; Alarms[1] = "Servo Direction Fault"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_22_VP == true) { if (Alarm_Saati_Vp[22] == null) { Alarm_Saati_Vp[22] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[22]; Alarms[1] = "Servo Drive Fault"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_23_VP == true) { if (Alarm_Saati_Vp[23] == null) { Alarm_Saati_Vp[23] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[23]; Alarms[1] = "Servo Following Fault"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_24_VP == true) { if (Alarm_Saati_Vp[24] == null) { Alarm_Saati_Vp[24] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[24]; Alarms[1] = "Servo Position Fault"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_25_VP == true) { if (Alarm_Saati_Vp[25] == null) { Alarm_Saati_Vp[25] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[25]; Alarms[1] = "Servo Soft(SW) Limit Fault"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_26_VP == true) { if (Alarm_Saati_Vp[26] == null) { Alarm_Saati_Vp[26] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[26]; Alarms[1] = "Servo System Fault"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_27_VP == true) { if (Alarm_Saati_Vp[27] == null) { Alarm_Saati_Vp[27] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[27]; Alarms[1] = "Servo System Homing Hatası"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_28_VP == true) { if (Alarm_Saati_Vp[28] == null) { Alarm_Saati_Vp[28] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[28]; Alarms[1] = "Servo Enable Hatası"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_29_VP == true) { if (Alarm_Saati_Vp[29] == null) { Alarm_Saati_Vp[29] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[29]; Alarms[1] = "Servo hatası"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_30_VP == true) { if (Alarm_Saati_Vp[30] == null) { Alarm_Saati_Vp[30] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[30]; Alarms[1] = "Rezerve"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_31_VP == true) { if (Alarm_Saati_Vp[31] == null) { Alarm_Saati_Vp[31] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[31]; Alarms[1] = "Rezerve"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_32_VP == true) { if (Alarm_Saati_Vp[32] == null) { Alarm_Saati_Vp[32] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[32]; Alarms[1] = "Rezerve"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_33_VP == true) { if (Alarm_Saati_Vp[33] == null) { Alarm_Saati_Vp[33] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[33]; Alarms[1] = "Rezerve"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_34_VP == true) { if (Alarm_Saati_Vp[34] == null) { Alarm_Saati_Vp[34] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[34]; Alarms[1] = "Rezerve"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_35_VP == true) { if (Alarm_Saati_Vp[35] == null) { Alarm_Saati_Vp[35] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[35]; Alarms[1] = "Rezerve"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_36_VP == true) { if (Alarm_Saati_Vp[36] == null) { Alarm_Saati_Vp[36] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[36]; Alarms[1] = "Rezerve"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_37_VP == true) { if (Alarm_Saati_Vp[37] == null) { Alarm_Saati_Vp[37] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[37]; Alarms[1] = "Rezerve"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_38_VP == true) { if (Alarm_Saati_Vp[38] == null) { Alarm_Saati_Vp[38] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[38]; Alarms[1] = "Rezerve"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_39_VP == true) { if (Alarm_Saati_Vp[39] == null) { Alarm_Saati_Vp[39] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[39]; Alarms[1] = "Rezerve"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //  if (u_anasayfa.Hmı_Alarm_40_VP == true) { if (Alarm_Saati_Vp[40] == null) { Alarm_Saati_Vp[40] = (DateTime.Now).ToString(); } Alarms[0] = Alarm_Saati_Vp[40]; Alarms[1] = "Rezerve"; itm = new ListViewItem(Alarms); Vulkanizasyon_Alarm_VP.Items.Add(itm); }
            //
            //  Kaucuk_Kesme_Alarm_KK.Items.Clear();
            //  string[] Alarms_KK = new string[2];
            //  ListViewItem itm_KK;
            //  if (u_anasayfa.Hmı_Alarm_1_KK == true) { if (Alarm_Saati_KK[1] == null) { Alarm_Saati_KK[1] = (DateTime.Now).ToString(); } Alarms_KK[0] = Alarm_Saati_KK[1]; Alarms_KK[1] = "Kauçuk Kesme Acil Stop Basılı"; itm_KK = new ListViewItem(Alarms_KK); Kaucuk_Kesme_Alarm_KK.Items.Add(itm_KK); }
            //  if (u_anasayfa.Hmı_Alarm_2_KK == true) { if (Alarm_Saati_KK[2] == null) { Alarm_Saati_KK[2] = (DateTime.Now).ToString(); } Alarms_KK[0] = Alarm_Saati_KK[2]; Alarms_KK[1] = "Kesme Piston ilerleme hatası"; itm_KK = new ListViewItem(Alarms_KK); Kaucuk_Kesme_Alarm_KK.Items.Add(itm_KK); }
            //  if (u_anasayfa.Hmı_Alarm_3_KK == true) { if (Alarm_Saati_KK[3] == null) { Alarm_Saati_KK[3] = (DateTime.Now).ToString(); } Alarms_KK[0] = Alarm_Saati_KK[3]; Alarms_KK[1] = "Kesme Piston gerileme hatası"; itm_KK = new ListViewItem(Alarms_KK); Kaucuk_Kesme_Alarm_KK.Items.Add(itm_KK); }
            //  if (u_anasayfa.Hmı_Alarm_4_KK == true) { if (Alarm_Saati_KK[4] == null) { Alarm_Saati_KK[4] = (DateTime.Now).ToString(); } Alarms_KK[0] = Alarm_Saati_KK[4]; Alarms_KK[1] = "Kesme Piston ileri-geri sensör cakısma hatası"; itm_KK = new ListViewItem(Alarms_KK); Kaucuk_Kesme_Alarm_KK.Items.Add(itm_KK); }
            //  if (u_anasayfa.Hmı_Alarm_5_KK == true) { if (Alarm_Saati_KK[5] == null) { Alarm_Saati_KK[5] = (DateTime.Now).ToString(); } Alarms_KK[0] = Alarm_Saati_KK[5]; Alarms_KK[1] = "Enkoder Degeri ilerlemiyor"; itm_KK = new ListViewItem(Alarms_KK); Kaucuk_Kesme_Alarm_KK.Items.Add(itm_KK); }
            //  if (u_anasayfa.Hmı_Alarm_6_KK == true) { if (Alarm_Saati_KK[6] == null) { Alarm_Saati_KK[6] = (DateTime.Now).ToString(); } Alarms_KK[0] = Alarm_Saati_KK[6]; Alarms_KK[1] = "Rezerve"; itm_KK = new ListViewItem(Alarms_KK); Kaucuk_Kesme_Alarm_KK.Items.Add(itm_KK); }
            //  if (u_anasayfa.Hmı_Alarm_7_KK == true) { if (Alarm_Saati_KK[7] == null) { Alarm_Saati_KK[7] = (DateTime.Now).ToString(); } Alarms_KK[0] = Alarm_Saati_KK[7]; Alarms_KK[1] = "Rezerve"; itm_KK = new ListViewItem(Alarms_KK); Kaucuk_Kesme_Alarm_KK.Items.Add(itm_KK); }
            //  if (u_anasayfa.Hmı_Alarm_8_KK == true) { if (Alarm_Saati_KK[8] == null) { Alarm_Saati_KK[8] = (DateTime.Now).ToString(); } Alarms_KK[0] = Alarm_Saati_KK[8]; Alarms_KK[1] = "Rezerve"; itm_KK = new ListViewItem(Alarms_KK); Kaucuk_Kesme_Alarm_KK.Items.Add(itm_KK); }
            //  if (u_anasayfa.Hmı_Alarm_9_KK == true) { if (Alarm_Saati_KK[9] == null) { Alarm_Saati_KK[9] = (DateTime.Now).ToString(); } Alarms_KK[0] = Alarm_Saati_KK[9]; Alarms_KK[1] = "Rezerve"; itm_KK = new ListViewItem(Alarms_KK); Kaucuk_Kesme_Alarm_KK.Items.Add(itm_KK); }
            //  if (u_anasayfa.Hmı_Alarm_10_KK == true) { if (Alarm_Saati_KK[10] == null) { Alarm_Saati_KK[10] = (DateTime.Now).ToString(); } Alarms_KK[0] = Alarm_Saati_KK[10]; Alarms_KK[1] = "Rezerve"; itm_KK = new ListViewItem(Alarms_KK); Kaucuk_Kesme_Alarm_KK.Items.Add(itm_KK); }
            //  if (u_anasayfa.Hmı_Alarm_11_KK == true) { if (Alarm_Saati_KK[11] == null) { Alarm_Saati_KK[11] = (DateTime.Now).ToString(); } Alarms_KK[0] = Alarm_Saati_KK[11]; Alarms_KK[1] = "Rezerve"; itm_KK = new ListViewItem(Alarms_KK); Kaucuk_Kesme_Alarm_KK.Items.Add(itm_KK); }
            //  if (u_anasayfa.Hmı_Alarm_12_KK == true) { if (Alarm_Saati_KK[12] == null) { Alarm_Saati_KK[12] = (DateTime.Now).ToString(); } Alarms_KK[0] = Alarm_Saati_KK[12]; Alarms_KK[1] = "Rezerve"; itm_KK = new ListViewItem(Alarms_KK); Kaucuk_Kesme_Alarm_KK.Items.Add(itm_KK); }
            //  if (u_anasayfa.Hmı_Alarm_13_KK == true) { if (Alarm_Saati_KK[13] == null) { Alarm_Saati_KK[13] = (DateTime.Now).ToString(); } Alarms_KK[0] = Alarm_Saati_KK[13]; Alarms_KK[1] = "Rezerve"; itm_KK = new ListViewItem(Alarms_KK); Kaucuk_Kesme_Alarm_KK.Items.Add(itm_KK); }
            //  if (u_anasayfa.Hmı_Alarm_14_KK == true) { if (Alarm_Saati_KK[14] == null) { Alarm_Saati_KK[14] = (DateTime.Now).ToString(); } Alarms_KK[0] = Alarm_Saati_KK[14]; Alarms_KK[1] = "Rezerve"; itm_KK = new ListViewItem(Alarms_KK); Kaucuk_Kesme_Alarm_KK.Items.Add(itm_KK); }
            //  if (u_anasayfa.Hmı_Alarm_15_KK == true) { if (Alarm_Saati_KK[15] == null) { Alarm_Saati_KK[15] = (DateTime.Now).ToString(); } Alarms_KK[0] = Alarm_Saati_KK[15]; Alarms_KK[1] = "Rezerve"; itm_KK = new ListViewItem(Alarms_KK); Kaucuk_Kesme_Alarm_KK.Items.Add(itm_KK); }
            //
            //  Kort_Bezi_Koparma_Alarm_KBK.Items.Clear();
            //  string[] Alarms_KBK = new string[2];
            //  ListViewItem itm_KBK;
            //  if (u_anasayfa.Hmı_Alarm_1_KBK == true) { if (Alarm_Saati_KBK[1] == null) { Alarm_Saati_KBK[1] = (DateTime.Now).ToString(); } Alarms_KBK[0] = Alarm_Saati_KBK[1]; Alarms_KBK[1] = "Kort Bezi Koparma Acil Stop Basılı"; itm_KBK = new ListViewItem(Alarms_KBK); Kort_Bezi_Koparma_Alarm_KBK.Items.Add(itm_KBK); }
            //  if (u_anasayfa.Hmı_Alarm_2_KBK == true) { if (Alarm_Saati_KBK[2] == null) { Alarm_Saati_KBK[2] = (DateTime.Now).ToString(); } Alarms_KBK[0] = Alarm_Saati_KBK[2]; Alarms_KBK[1] = "Balata Piston ilerleme hatası"; itm_KBK = new ListViewItem(Alarms_KBK); Kort_Bezi_Koparma_Alarm_KBK.Items.Add(itm_KBK); }
            //  if (u_anasayfa.Hmı_Alarm_3_KBK == true) { if (Alarm_Saati_KBK[3] == null) { Alarm_Saati_KBK[3] = (DateTime.Now).ToString(); } Alarms_KBK[0] = Alarm_Saati_KBK[3]; Alarms_KBK[1] = "Balata Piston gerileme hatası"; itm_KBK = new ListViewItem(Alarms_KBK); Kort_Bezi_Koparma_Alarm_KBK.Items.Add(itm_KBK); }
            //  if (u_anasayfa.Hmı_Alarm_4_KBK == true) { if (Alarm_Saati_KBK[4] == null) { Alarm_Saati_KBK[4] = (DateTime.Now).ToString(); } Alarms_KBK[0] = Alarm_Saati_KBK[4]; Alarms_KBK[1] = "Balata Piston ileri-geri sensör cakısması"; itm_KBK = new ListViewItem(Alarms_KBK); Kort_Bezi_Koparma_Alarm_KBK.Items.Add(itm_KBK); }
            //  if (u_anasayfa.Hmı_Alarm_5_KBK == true) { if (Alarm_Saati_KBK[5] == null) { Alarm_Saati_KBK[5] = (DateTime.Now).ToString(); } Alarms_KBK[0] = Alarm_Saati_KBK[5]; Alarms_KBK[1] = "Üst Baskı Silindir  ilerleme hatası"; itm_KBK = new ListViewItem(Alarms_KBK); Kort_Bezi_Koparma_Alarm_KBK.Items.Add(itm_KBK); }
            //  if (u_anasayfa.Hmı_Alarm_6_KBK == true) { if (Alarm_Saati_KBK[6] == null) { Alarm_Saati_KBK[6] = (DateTime.Now).ToString(); } Alarms_KBK[0] = Alarm_Saati_KBK[6]; Alarms_KBK[1] = "Üst Baskı Silindir  gerileme hatası"; itm_KBK = new ListViewItem(Alarms_KBK); Kort_Bezi_Koparma_Alarm_KBK.Items.Add(itm_KBK); }
            //  if (u_anasayfa.Hmı_Alarm_7_KBK == true) { if (Alarm_Saati_KBK[7] == null) { Alarm_Saati_KBK[7] = (DateTime.Now).ToString(); } Alarms_KBK[0] = Alarm_Saati_KBK[7]; Alarms_KBK[1] = "Tambur Tutucu ilerleme hatası"; itm_KBK = new ListViewItem(Alarms_KBK); Kort_Bezi_Koparma_Alarm_KBK.Items.Add(itm_KBK); }
            //  if (u_anasayfa.Hmı_Alarm_8_KBK == true) { if (Alarm_Saati_KBK[8] == null) { Alarm_Saati_KBK[8] = (DateTime.Now).ToString(); } Alarms_KBK[0] = Alarm_Saati_KBK[8]; Alarms_KBK[1] = "Tambur Tutucu gerileme hatası"; itm_KBK = new ListViewItem(Alarms_KBK); Kort_Bezi_Koparma_Alarm_KBK.Items.Add(itm_KBK); }
            //  if (u_anasayfa.Hmı_Alarm_9_KBK == true) { if (Alarm_Saati_KBK[9] == null) { Alarm_Saati_KBK[9] = (DateTime.Now).ToString(); } Alarms_KBK[0] = Alarm_Saati_KBK[9]; Alarms_KBK[1] = "Enkoder Degeri ilerlemiyor"; itm_KBK = new ListViewItem(Alarms_KBK); Kort_Bezi_Koparma_Alarm_KBK.Items.Add(itm_KBK); }
            //  if (u_anasayfa.Hmı_Alarm_10_KBK == true) { if (Alarm_Saati_KBK[10] == null) { Alarm_Saati_KBK[10] = (DateTime.Now).ToString(); } Alarms_KBK[0] = Alarm_Saati_KBK[10]; Alarms_KBK[1] = "Rezerve"; itm_KBK = new ListViewItem(Alarms_KBK); Kort_Bezi_Koparma_Alarm_KBK.Items.Add(itm_KBK); }
            //  if (u_anasayfa.Hmı_Alarm_11_KBK == true) { if (Alarm_Saati_KBK[11] == null) { Alarm_Saati_KBK[11] = (DateTime.Now).ToString(); } Alarms_KBK[0] = Alarm_Saati_KBK[11]; Alarms_KBK[1] = "Rezerve"; itm_KBK = new ListViewItem(Alarms_KBK); Kort_Bezi_Koparma_Alarm_KBK.Items.Add(itm_KBK); }
            //  if (u_anasayfa.Hmı_Alarm_12_KBK == true) { if (Alarm_Saati_KBK[12] == null) { Alarm_Saati_KBK[12] = (DateTime.Now).ToString(); } Alarms_KBK[0] = Alarm_Saati_KBK[12]; Alarms_KBK[1] = "Rezerve"; itm_KBK = new ListViewItem(Alarms_KBK); Kort_Bezi_Koparma_Alarm_KBK.Items.Add(itm_KBK); }
            //  if (u_anasayfa.Hmı_Alarm_13_KBK == true) { if (Alarm_Saati_KBK[13] == null) { Alarm_Saati_KBK[13] = (DateTime.Now).ToString(); } Alarms_KBK[0] = Alarm_Saati_KBK[13]; Alarms_KBK[1] = "Rezerve"; itm_KBK = new ListViewItem(Alarms_KBK); Kort_Bezi_Koparma_Alarm_KBK.Items.Add(itm_KBK); }
            //  if (u_anasayfa.Hmı_Alarm_14_KBK == true) { if (Alarm_Saati_KBK[14] == null) { Alarm_Saati_KBK[14] = (DateTime.Now).ToString(); } Alarms_KBK[0] = Alarm_Saati_KBK[14]; Alarms_KBK[1] = "Rezerve"; itm_KBK = new ListViewItem(Alarms_KBK); Kort_Bezi_Koparma_Alarm_KBK.Items.Add(itm_KBK); }
            //  if (u_anasayfa.Hmı_Alarm_15_KBK == true) { if (Alarm_Saati_KBK[15] == null) { Alarm_Saati_KBK[15] = (DateTime.Now).ToString(); } Alarms_KBK[0] = Alarm_Saati_KBK[15]; Alarms_KBK[1] = "Rezerve"; itm_KBK = new ListViewItem(Alarms_KBK); Kort_Bezi_Koparma_Alarm_KBK.Items.Add(itm_KBK); }
            //
            //  Sıyırma_Sogutma_Alarm_SS.Items.Clear();
            //  string[] Alarms_SS = new string[2];
            //  ListViewItem itm_SS;
            //  if (u_anasayfa.Hmı_Alarm_1_SS == true) { if (Alarm_Saati_SS[1] == null) { Alarm_Saati_SS[1] = (DateTime.Now).ToString(); } Alarms_SS[0] = Alarm_Saati_SS[1]; Alarms_SS[1] = "Sıyırıcı üst tabla ilerleme(yukarı) hatası"; itm_SS = new ListViewItem(Alarms_SS); Sıyırma_Sogutma_Alarm_SS.Items.Add(itm_SS); }
            //  if (u_anasayfa.Hmı_Alarm_2_SS == true) { if (Alarm_Saati_SS[2] == null) { Alarm_Saati_SS[2] = (DateTime.Now).ToString(); } Alarms_SS[0] = Alarm_Saati_SS[2]; Alarms_SS[1] = "Sıyırıcı üst tabla ilerleme(yukarı) ara sensör hatası"; itm_SS = new ListViewItem(Alarms_SS); Sıyırma_Sogutma_Alarm_SS.Items.Add(itm_SS); }
            //  if (u_anasayfa.Hmı_Alarm_3_SS == true) { if (Alarm_Saati_SS[3] == null) { Alarm_Saati_SS[3] = (DateTime.Now).ToString(); } Alarms_SS[0] = Alarm_Saati_SS[3]; Alarms_SS[1] = "Sıyırıcı üst tabla gerileme(Asagı) hatası"; itm_SS = new ListViewItem(Alarms_SS); Sıyırma_Sogutma_Alarm_SS.Items.Add(itm_SS); }
            //  if (u_anasayfa.Hmı_Alarm_4_SS == true) { if (Alarm_Saati_SS[4] == null) { Alarm_Saati_SS[4] = (DateTime.Now).ToString(); } Alarms_SS[0] = Alarm_Saati_SS[4]; Alarms_SS[1] = "Sıyırıcı Üst tabla Sensör cakısması"; itm_SS = new ListViewItem(Alarms_SS); Sıyırma_Sogutma_Alarm_SS.Items.Add(itm_SS); }
            //  if (u_anasayfa.Hmı_Alarm_5_SS == true) { if (Alarm_Saati_SS[5] == null) { Alarm_Saati_SS[5] = (DateTime.Now).ToString(); } Alarms_SS[0] = Alarm_Saati_SS[5]; Alarms_SS[1] = "Hmı_Sıyırıcı _Tutucu_ilerleme (kapatma) hatası"; itm_SS = new ListViewItem(Alarms_SS); Sıyırma_Sogutma_Alarm_SS.Items.Add(itm_SS); }
            //  if (u_anasayfa.Hmı_Alarm_6_SS == true) { if (Alarm_Saati_SS[6] == null) { Alarm_Saati_SS[6] = (DateTime.Now).ToString(); } Alarms_SS[0] = Alarm_Saati_SS[6]; Alarms_SS[1] = "Hmı_Sıyırıcı _Tutucu_gerileme (acma) hatası"; itm_SS = new ListViewItem(Alarms_SS); Sıyırma_Sogutma_Alarm_SS.Items.Add(itm_SS); }
            //  if (u_anasayfa.Hmı_Alarm_7_SS == true) { if (Alarm_Saati_SS[7] == null) { Alarm_Saati_SS[7] = (DateTime.Now).ToString(); } Alarms_SS[0] = Alarm_Saati_SS[7]; Alarms_SS[1] = "Hidroik Motor Termik Kapalı(2,2KW)"; itm_SS = new ListViewItem(Alarms_SS); Sıyırma_Sogutma_Alarm_SS.Items.Add(itm_SS); }
            //  if (u_anasayfa.Hmı_Alarm_8_SS == true) { if (Alarm_Saati_SS[8] == null) { Alarm_Saati_SS[8] = (DateTime.Now).ToString(); } Alarms_SS[0] = Alarm_Saati_SS[8]; Alarms_SS[1] = "Rezerve"; itm_SS = new ListViewItem(Alarms_SS); Sıyırma_Sogutma_Alarm_SS.Items.Add(itm_SS); }
            //  if (u_anasayfa.Hmı_Alarm_9_SS == true) { if (Alarm_Saati_SS[9] == null) { Alarm_Saati_SS[9] = (DateTime.Now).ToString(); } Alarms_SS[0] = Alarm_Saati_SS[9]; Alarms_SS[1] = "Rezerve"; itm_SS = new ListViewItem(Alarms_SS); Sıyırma_Sogutma_Alarm_SS.Items.Add(itm_SS); }
            //  if (u_anasayfa.Hmı_Alarm_10_SS == true) { if (Alarm_Saati_SS[10] == null) { Alarm_Saati_SS[10] = (DateTime.Now).ToString(); } Alarms_SS[0] = Alarm_Saati_SS[10]; Alarms_SS[1] = "Rezerve"; itm_SS = new ListViewItem(Alarms_SS); Sıyırma_Sogutma_Alarm_SS.Items.Add(itm_SS); }
            //  if (u_anasayfa.Hmı_Alarm_11_SS == true) { if (Alarm_Saati_SS[11] == null) { Alarm_Saati_SS[11] = (DateTime.Now).ToString(); } Alarms_SS[0] = Alarm_Saati_SS[11]; Alarms_SS[1] = "Rezerve"; itm_SS = new ListViewItem(Alarms_SS); Sıyırma_Sogutma_Alarm_SS.Items.Add(itm_SS); }
            //  if (u_anasayfa.Hmı_Alarm_12_SS == true) { if (Alarm_Saati_SS[12] == null) { Alarm_Saati_SS[12] = (DateTime.Now).ToString(); } Alarms_SS[0] = Alarm_Saati_SS[12]; Alarms_SS[1] = "Rezerve"; itm_SS = new ListViewItem(Alarms_SS); Sıyırma_Sogutma_Alarm_SS.Items.Add(itm_SS); }
            //  if (u_anasayfa.Hmı_Alarm_13_SS == true) { if (Alarm_Saati_SS[13] == null) { Alarm_Saati_SS[13] = (DateTime.Now).ToString(); } Alarms_SS[0] = Alarm_Saati_SS[13]; Alarms_SS[1] = "Rezerve"; itm_SS = new ListViewItem(Alarms_SS); Sıyırma_Sogutma_Alarm_SS.Items.Add(itm_SS); }
            //  if (u_anasayfa.Hmı_Alarm_14_SS == true) { if (Alarm_Saati_SS[14] == null) { Alarm_Saati_SS[14] = (DateTime.Now).ToString(); } Alarms_SS[0] = Alarm_Saati_SS[14]; Alarms_SS[1] = "Rezerve"; itm_SS = new ListViewItem(Alarms_SS); Sıyırma_Sogutma_Alarm_SS.Items.Add(itm_SS); }
            //  if (u_anasayfa.Hmı_Alarm_15_SS == true) { if (Alarm_Saati_SS[15] == null) { Alarm_Saati_SS[15] = (DateTime.Now).ToString(); } Alarms_SS[0] = Alarm_Saati_SS[15]; Alarms_SS[1] = "Rezerve"; itm_SS = new ListViewItem(Alarms_SS); Sıyırma_Sogutma_Alarm_SS.Items.Add(itm_SS); }
            //
            //  Sarma_Alarm_S.Items.Clear();
            //  string[] Alarms_S = new string[2];
            //  ListViewItem itm_S;
            //  if (u_anasayfa.Hmı_Alarm_1_S == true) { if (Alarm_Saati_S[1] == null) { Alarm_Saati_S[1] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[1]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_2_S == true) { if (Alarm_Saati_S[2] == null) { Alarm_Saati_S[2] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[2]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_3_S == true) { if (Alarm_Saati_S[3] == null) { Alarm_Saati_S[3] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[3]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_4_S == true) { if (Alarm_Saati_S[4] == null) { Alarm_Saati_S[4] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[4]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_5_S == true) { if (Alarm_Saati_S[5] == null) { Alarm_Saati_S[5] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[5]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_6_S == true) { if (Alarm_Saati_S[6] == null) { Alarm_Saati_S[6] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[6]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_7_S == true) { if (Alarm_Saati_S[7] == null) { Alarm_Saati_S[7] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[7]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_8_S == true) { if (Alarm_Saati_S[8] == null) { Alarm_Saati_S[8] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[8]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_9_S == true) { if (Alarm_Saati_S[9] == null) { Alarm_Saati_S[9] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[9]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_10_S == true) { if (Alarm_Saati_S[10] == null) { Alarm_Saati_S[10] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[10]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_11_S == true) { if (Alarm_Saati_S[11] == null) { Alarm_Saati_S[11] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[11]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_12_S == true) { if (Alarm_Saati_S[12] == null) { Alarm_Saati_S[12] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[12]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_13_S == true) { if (Alarm_Saati_S[13] == null) { Alarm_Saati_S[13] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[13]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_14_S == true) { if (Alarm_Saati_S[14] == null) { Alarm_Saati_S[14] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[14]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_15_S == true) { if (Alarm_Saati_S[15] == null) { Alarm_Saati_S[15] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[15]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_16_S == true) { if (Alarm_Saati_S[16] == null) { Alarm_Saati_S[16] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[16]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_17_S == true) { if (Alarm_Saati_S[17] == null) { Alarm_Saati_S[17] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[17]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_18_S == true) { if (Alarm_Saati_S[18] == null) { Alarm_Saati_S[18] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[18]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_19_S == true) { if (Alarm_Saati_S[19] == null) { Alarm_Saati_S[19] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[19]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_20_S == true) { if (Alarm_Saati_S[20] == null) { Alarm_Saati_S[20] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[20]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_21_S == true) { if (Alarm_Saati_S[21] == null) { Alarm_Saati_S[21] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[21]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_22_S == true) { if (Alarm_Saati_S[22] == null) { Alarm_Saati_S[22] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[22]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_23_S == true) { if (Alarm_Saati_S[23] == null) { Alarm_Saati_S[23] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[23]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_24_S == true) { if (Alarm_Saati_S[24] == null) { Alarm_Saati_S[24] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[24]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_25_S == true) { if (Alarm_Saati_S[25] == null) { Alarm_Saati_S[25] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[25]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            //  if (u_anasayfa.Hmı_Alarm_26_S == true) { if (Alarm_Saati_S[26] == null) { Alarm_Saati_S[26] = (DateTime.Now).ToString(); } Alarms_S[0] = Alarm_Saati_S[26]; Alarms_S[1] = "Rezerve"; itm_S = new ListViewItem(Alarms_S); Sarma_Alarm_S.Items.Add(itm_S); }
            // 
            //
            //  Robot_Alarm_R.Items.Clear();
            //  string[] Alarms_R = new string[2];
            //  ListViewItem itm_R;
            //  if (u_anasayfa.Hmı_Alarm_1_ABB == true) { if (Alarm_Saati_R[1] == null) { Alarm_Saati_R[1] = (DateTime.Now).ToString(); } Alarms_R[0] = Alarm_Saati_R[1]; Alarms_R[1] = "Rezerve"; itm_R = new ListViewItem(Alarms_R); Robot_Alarm_R.Items.Add(itm_R); }
            //  if (u_anasayfa.Hmı_Alarm_2_ABB == true) { if (Alarm_Saati_R[2] == null) { Alarm_Saati_R[2] = (DateTime.Now).ToString(); } Alarms_R[0] = Alarm_Saati_R[2]; Alarms_R[1] = "Robot Tutucu ilerleme Kapatma) hatası"; itm_R = new ListViewItem(Alarms_R); Robot_Alarm_R.Items.Add(itm_R); }
            //  if (u_anasayfa.Hmı_Alarm_3_ABB == true) { if (Alarm_Saati_R[3] == null) { Alarm_Saati_R[3] = (DateTime.Now).ToString(); } Alarms_R[0] = Alarm_Saati_R[3]; Alarms_R[1] = "Robot Tutucu Gerileme (Açma) hatası"; itm_R = new ListViewItem(Alarms_R); Robot_Alarm_R.Items.Add(itm_R); }
            //  if (u_anasayfa.Hmı_Alarm_4_ABB == true) { if (Alarm_Saati_R[4] == null) { Alarm_Saati_R[4] = (DateTime.Now).ToString(); } Alarms_R[0] = Alarm_Saati_R[4]; Alarms_R[1] = "Rezerve"; itm_R = new ListViewItem(Alarms_R); Robot_Alarm_R.Items.Add(itm_R); }
            //  if (u_anasayfa.Hmı_Alarm_5_ABB == true) { if (Alarm_Saati_R[5] == null) { Alarm_Saati_R[5] = (DateTime.Now).ToString(); } Alarms_R[0] = Alarm_Saati_R[5]; Alarms_R[1] = "Rezerve"; itm_R = new ListViewItem(Alarms_R); Robot_Alarm_R.Items.Add(itm_R); }
            //  if (u_anasayfa.Hmı_Alarm_6_ABB == true) { if (Alarm_Saati_R[6] == null) { Alarm_Saati_R[6] = (DateTime.Now).ToString(); } Alarms_R[0] = Alarm_Saati_R[6]; Alarms_R[1] = "Rezerve"; itm_R = new ListViewItem(Alarms_R); Robot_Alarm_R.Items.Add(itm_R); }
            //  if (u_anasayfa.Hmı_Alarm_7_ABB == true) { if (Alarm_Saati_R[7] == null) { Alarm_Saati_R[7] = (DateTime.Now).ToString(); } Alarms_R[0] = Alarm_Saati_R[7]; Alarms_R[1] = "Rezerve"; itm_R = new ListViewItem(Alarms_R); Robot_Alarm_R.Items.Add(itm_R); }
            //  if (u_anasayfa.Hmı_Alarm_8_ABB == true) { if (Alarm_Saati_R[8] == null) { Alarm_Saati_R[8] = (DateTime.Now).ToString(); } Alarms_R[0] = Alarm_Saati_R[8]; Alarms_R[1] = "Rezerve"; itm_R = new ListViewItem(Alarms_R); Robot_Alarm_R.Items.Add(itm_R); }
            //  if (u_anasayfa.Hmı_Alarm_9_ABB == true) { if (Alarm_Saati_R[9] == null) { Alarm_Saati_R[9] = (DateTime.Now).ToString(); } Alarms_R[0] = Alarm_Saati_R[9]; Alarms_R[1] = "Rezerve"; itm_R = new ListViewItem(Alarms_R); Robot_Alarm_R.Items.Add(itm_R); }
            //  if (u_anasayfa.Hmı_Alarm_10_ABB == true) { if (Alarm_Saati_R[10] == null) { Alarm_Saati_R[10] = (DateTime.Now).ToString(); } Alarms_R[0] = Alarm_Saati_R[10]; Alarms_R[1] = "Rezerve"; itm_R = new ListViewItem(Alarms_R); Robot_Alarm_R.Items.Add(itm_R); }
            //  if (u_anasayfa.Hmı_Alarm_11_ABB == true) { if (Alarm_Saati_R[11] == null) { Alarm_Saati_R[11] = (DateTime.Now).ToString(); } Alarms_R[0] = Alarm_Saati_R[11]; Alarms_R[1] = "Rezerve"; itm_R = new ListViewItem(Alarms_R); Robot_Alarm_R.Items.Add(itm_R); }
            //  if (u_anasayfa.Hmı_Alarm_12_ABB == true) { if (Alarm_Saati_R[12] == null) { Alarm_Saati_R[12] = (DateTime.Now).ToString(); } Alarms_R[0] = Alarm_Saati_R[12]; Alarms_R[1] = "Rezerve"; itm_R = new ListViewItem(Alarms_R); Robot_Alarm_R.Items.Add(itm_R); }
            //  if (u_anasayfa.Hmı_Alarm_13_ABB == true) { if (Alarm_Saati_R[13] == null) { Alarm_Saati_R[13] = (DateTime.Now).ToString(); } Alarms_R[0] = Alarm_Saati_R[13]; Alarms_R[1] = "Rezerve"; itm_R = new ListViewItem(Alarms_R); Robot_Alarm_R.Items.Add(itm_R); }
            //  if (u_anasayfa.Hmı_Alarm_14_ABB == true) { if (Alarm_Saati_R[14] == null) { Alarm_Saati_R[14] = (DateTime.Now).ToString(); } Alarms_R[0] = Alarm_Saati_R[14]; Alarms_R[1] = "Rezerve"; itm_R = new ListViewItem(Alarms_R); Robot_Alarm_R.Items.Add(itm_R); }
            //  if (u_anasayfa.Hmı_Alarm_15_ABB == true) { if (Alarm_Saati_R[15] == null) { Alarm_Saati_R[15] = (DateTime.Now).ToString(); } Alarms_R[0] = Alarm_Saati_R[15]; Alarms_R[1] = "Rezerve"; itm_R = new ListViewItem(Alarms_R); Robot_Alarm_R.Items.Add(itm_R); }
            }
            catch
            {
                MessageBox.Show("Plc Değişken Veri Okuma Yazma Error");
            }
        }  
            
        public bool set1;
        private void Alarmlar_Shown(object sender, EventArgs e)
        {
            Alarm_Tab.SelectedIndex = u_anasayfa.Alarm_Sayfa_index;
            Vulkanizasyon_Alarm_VP.Columns.Add("Alarm Saati", 200);
            Vulkanizasyon_Alarm_VP.Columns.Add("Alarm Açıklama", 500);
            Sarma_Alarm_S.Columns.Add("Alarm Saati", 200);
            Sarma_Alarm_S.Columns.Add("Alarm Açıklama", 500);
            Kaucuk_Kesme_Alarm_KK.Columns.Add("Alarm Saati", 200);
            Kaucuk_Kesme_Alarm_KK.Columns.Add("Alarm Açıklama", 500);
            Kort_Bezi_Koparma_Alarm_KBK.Columns.Add("Alarm Saati", 200);
            Kort_Bezi_Koparma_Alarm_KBK.Columns.Add("Alarm Açıklama", 500);
            Sıyırma_Sogutma_Alarm_SS.Columns.Add("Alarm Saati", 200);
            Sıyırma_Sogutma_Alarm_SS.Columns.Add("Alarm Açıklama", 500);
            Robot_Alarm_R.Columns.Add("Alarm Saati", 200);
            Robot_Alarm_R.Columns.Add("Alarm Açıklama", 500);
    
            
        }

        private void Alarmlar_Load(object sender, EventArgs e)
        {                  
            PlcAlarmTimer.Start();
        }

        private void Alarmlar_Leave(object sender, EventArgs e)
        {
            PlcAlarmTimer.Stop();
        }
    }
}
  