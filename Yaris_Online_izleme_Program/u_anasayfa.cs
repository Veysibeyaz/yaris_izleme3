using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft;
using System.IO;
using MHJSW.ComDrvS7V6_Net;
using Microsoft.VisualBasic;


namespace Yaris_Online_izleme_Programı
{
    public partial class u_anasayfa : UserControl
    {

        u_manuel m_Manuel = new u_manuel();
        u_ayarlar m_ayarlar = new u_ayarlar();
        public static bool Programclose;

        public static bool M_Pres_1_Kalite_Onay_Başlat_Gecici;
        public static bool M_Pres_1_Forklift_Bekleme_Başlat_Gecici;
        public static bool M_Pres_1_Mola_Yemek_Başlat_Gecici;
        public static bool M_Pres_1_Parça_Bekleme_Başlat_Gecici;
        public static bool M_Pres_1_Arıza_Başlat_Gecici;
        public static bool M_Pres_1_Setup_Başlat_Gecici;
        public static bool M_Pres_1_WC_Başlat_Gecici;
        public static bool M_Pres_1_Kalıp_Arıza_Başlat_Gecici;


        public static bool M_Pres_1_Barkod_Okuma_Yapıldı;
        public static bool M_Pres_1_iş_başlat;
        public static bool M_Pres_1_iş_bitir;
        public static bool M_Pres_1_Forklift_Bekleme_Başlat;
        public static bool M_Pres_1_Forklift_Bekleme_Bitir;
        public static bool M_Pres_1_Mola_Yemek_Başlat;
        public static bool M_Pres_1_Mola_Yemek_Bitir;
        public static bool M_Pres_1_Parça_Bekleme_Başlat;
        public static bool M_Pres_1_Parça_Bekleme_Bitir;
        public static bool M_Pres_1_Kalite_Onay_Başlat;
        public static bool M_Pres_1_Kalite_Onay_Bitir;
        public static bool M_Pres_1_Arıza_Başlat;
        public static bool M_Pres_1_Arıza_Bitir;
        public static bool M_Pres_1_Setup_Başlat;
        public static bool M_Pres_1_Setup_Bitir;
        public static bool M_Pres_1_WC_Başlat;
        public static bool M_Pres_1_WC_Bitir;
        public static bool M_Pres_1_Emergency_Alarm;
        public static bool Plc_Haberleşme_Ok;
        public static bool M_Pres_1_Kalıp_Arıza_Başlat;
        public static bool M_Pres_1_Kalıp_Arıza_Bitir;
        public static bool M_Pres_1_Pres_izin_Aktif_Pasif;
        public static bool M_Pres_1_Parça_Basılması_Bekleniyor;
        public static bool M_Pres_1_Kalite_Onay_Bekleniyor;


        public static Int32 M_Pres_1_Forklift_Bekleme_Başlama_Zamanı_deneme;
        public static DateTime M_Pres_1_Barkod_Sipariş_No_Okutma_Zamanı;
        public static Int32 M_Pres_1_iş_başlama_zamanı_saat;
        public static Int32 M_Pres_1_iş_bitirme_zamanı_saat;
        public static Int32   M_Pres_1_iş_toplam_zaman;
        public static DateTime M_Pres_1_Forklift_Bekleme_Başlama_Zamanı;
        public static DateTime M_Pres_1_Forklift_Bekleme_Bitirme_zamanı;
        public static Int32 M_Pres_1_Forklift_Bekleme_Toplam_Zaman;
        public static DateTime M_Pres_1_Mola_Yemek_Başlama_Zamanı;
        public static DateTime M_Pres_1_Mola_Yemek_Bitirme_zamanı;
        public static Int32 M_Pres_1_Mola_Yemek_Toplam_Zaman;
        public static DateTime M_Pres_1_Parça_Bekleme_Başlama_Zamanı;
        public static DateTime M_Pres_1_Parça_Bekleme_Bitirme_zamanı;
        public static Int32 M_Pres_1_Parça_Bekleme_Toplam_Zaman;
        public static DateTime M_Pres_1_Kalite_Onay_Başlama_Zamanı;
        public static DateTime M_Pres_1_Kalite_Onay_Bitirme_zamanı;
        public static Int32 M_Pres_1_Kalite_Onay_Toplam_Zaman;
        public static DateTime M_Pres_1_Arıza_Başlama_Zamanı;
        public static DateTime M_Pres_1_Arıza_Bitirme_zamanı;
        public static Int32 M_Pres_1_Arıza_Toplam_Zaman;
        public static DateTime M_Pres_1_Setup_Başlama_Zamanı;
        public static DateTime M_Pres_1_Setup_Bitirme_zamanı;
        public static Int32 M_Pres_1_Setup_Toplam_Zaman;
        public static DateTime M_Pres_1_WC_Başlama_Zamanı;
        public static DateTime M_Pres_1_WC_Bitirme_zamanı;
        public static Int32 M_Pres_1_WC_Toplam_Zaman;
        public static Int32 M_Pres_1_Barkod_Okuma_Sipariş_No;
        public static DateTime M_Pres_1_Kalıp_Arıza_Başlama_Zamanı;
        public static DateTime M_Pres_1_Kalıp_Arıza_Bitirme_zamanı;
        public static Int32    M_Pres_1_Kalıp_Arıza_Toplam_Zaman;

        public static Int32 M_Pres_1_Basılan_Parça_Adedi;
        public static bool M_Pres_1_Basılan_Parça_Adedi_sıfırla;

        public static Int32 M_Pres_1_Barkod_Okuma_Sipariş_Panel;
        public static string M_Pres_1_Barkod_Okuma_Sipariş_Panel_String;
        public static Int32 M_Pres_1_Parça_Üretim_Süresi;
        public static Int32 M_Pres_1_Makina_Performansı;
        public static Int32 M_Pres_1_Operatör_Performansı;
        public static Int32 M_Pres_1_Hurda_Adeti;
        public static bool SiparişEşleşmeOk;
        public static string[] operatör_adı = new string[100];


        public static Int32 M_Pres_1_iş_başlama_zamanı_Dk;
        public static Int32 M_Pres_1_iş_başlama_zamanı_Yıl;
        public static Int32 M_Pres_1_iş_başlama_zamanı_Ay ;
        public static Int32 M_Pres_1_iş_başlama_zamanı_Gün;
        public static Int32 M_Pres_1_iş_bitirme_zamanı_DK ;
        public static Int32 M_Pres_1_iş_bitirme_zamanı_Yıl;
        public static Int32 M_Pres_1_iş_bitirme_zamanı_Ay ;
        public static Int32 M_Pres_1_iş_bitirme_zamanı_Gün;
        public static Int32 M_Pres_1_Barkod_Okutma_Saat;
        public static Int32 M_Pres_1_Barkod_Okutma_Dk ;
        public static Int32 M_Pres_1_Barkod_Okutma_Yıl ;
        public static Int32 M_Pres_1_Barkod_Okutma_Ay;
        public static Int32 M_Pres_1_Barkod_Okutma_Gün;
        public static string M_Pres_1_Barkod_Okuma_Sipariş_Kayıt_String;
        public static string M_Pres_1_Barkod_Sipariş_No_String;

       
    

        public int[] index;
        public static bool Hmı_Emergency_Alarm_VP;
        public static bool Hmı_Emergency_Alarm_KK;
        public static bool Hmı_Emergency_Alarm_KBK;
        public static bool Hmı_Emergency_Alarm_S;
        public static bool Hmı_Emergency_Alarm_Genel;
        public static bool Hmı_Emergency_Alarm_ABB;

        public string list;
        public static int oto_index;
        public static int Alarm_Sayfa_index;

        public static bool Hmı_Alarm_1_VP;
        public Int32 value = 0;


        public u_anasayfa()
        {
            InitializeComponent();
            //excelDataSource1.Fill();
            excelDataSource1.FileName = System.IO.Directory.GetCurrentDirectory() + "\\HATALAR\\" + "HATA_LOG" + ".csv";

            colTarih.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            colSaat.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;

        }
        public string txt_Null_1;
        public string txt_Null_2;
        public string txt_Null_3;
        public string txt_Null_4;
        public string txt_Null_5;
        public string txt_Null_6;

        public string DegerKontrol;
        public string MalafaKontroBırakamadı;
        public string MalafaKontrolAlamadı;
        public static bool m_Tutucuda_Malafa_Var_Yok_Kontrol;



        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            try
            {

        
            M_Pres_1_iş_toplam_zaman = Anasayfa.readDInt[0];  //db2 0.0
            M_Pres_1_Forklift_Bekleme_Toplam_Zaman = Anasayfa.readDInt[1];  //db2 4.0


                
            M_Pres_1_Mola_Yemek_Toplam_Zaman = Anasayfa.readDInt[2];  //db2 8.0
            M_Pres_1_Parça_Bekleme_Toplam_Zaman = Anasayfa.readDInt[3];  //db2 12.0
            M_Pres_1_Kalite_Onay_Toplam_Zaman = Anasayfa.readDInt[4];  //db2 16.0
            M_Pres_1_Arıza_Toplam_Zaman = Anasayfa.readDInt[5];  //db2 20.0
            M_Pres_1_Setup_Toplam_Zaman = Anasayfa.readDInt[6];  //db2 24.0
            M_Pres_1_WC_Toplam_Zaman = Anasayfa.readDInt[7];  //db2 28.0
            M_Pres_1_Basılan_Parça_Adedi = Anasayfa.readDInt[8];  //db2 32.0
                M_Pres_1_iş_başlama_zamanı_saat = Anasayfa.readDInt[9];  //db2 32.0
                M_Pres_1_iş_bitirme_zamanı_saat = Anasayfa.readDInt[10];  //db2 32.0
                M_Pres_1_Forklift_Bekleme_Başlama_Zamanı_deneme = Anasayfa.readDInt[11];
            M_Pres_1_Barkod_Okuma_Sipariş_No = Anasayfa.readDInt[25];  //db2 32.0
             M_Pres_1_Kalıp_Arıza_Toplam_Zaman = Anasayfa.readDInt[28];  //db2 20.0
                M_Pres_1_Parça_Üretim_Süresi =Anasayfa.readDInt[29];  //db2 20.0
                M_Pres_1_Makina_Performansı = Anasayfa.readDInt[30];  //db2 20.0
                M_Pres_1_Operatör_Performansı = Anasayfa.readDInt[31];  //db2 20.0
                M_Pres_1_Hurda_Adeti = Anasayfa.readDInt[32];  //db2 20.0
                M_Pres_1_iş_başlama_zamanı_Dk = Anasayfa.readDInt[33];  //db2 20.0
                M_Pres_1_iş_başlama_zamanı_Yıl = Anasayfa.readDInt[34];  //db2 20.0
                M_Pres_1_iş_başlama_zamanı_Ay = Anasayfa.readDInt[35];  //db2 20.0
                M_Pres_1_iş_başlama_zamanı_Gün = Anasayfa.readDInt[36];  //db2 20.0
                M_Pres_1_iş_bitirme_zamanı_DK = Anasayfa.readDInt[37];  //db2 20.0
                M_Pres_1_iş_bitirme_zamanı_Yıl = Anasayfa.readDInt[38];  //db2 20.0
                M_Pres_1_iş_bitirme_zamanı_Ay = Anasayfa.readDInt[39];  //db2 20.0
                M_Pres_1_iş_bitirme_zamanı_Gün = Anasayfa.readDInt[40];  //db2 20.0
                M_Pres_1_Barkod_Okutma_Saat = Anasayfa.readDInt[41];  //db2 20.0
                M_Pres_1_Barkod_Okutma_Dk = Anasayfa.readDInt[42];  //db2 20.0
                M_Pres_1_Barkod_Okutma_Yıl = Anasayfa.readDInt[43];  //db2 20.0
                M_Pres_1_Barkod_Okutma_Ay = Anasayfa.readDInt[44];  //db2 20.0
                M_Pres_1_Barkod_Okutma_Gün = Anasayfa.readDInt[45];  //db2 20.0






                M_Pres_1_Barkod_Okuma_Yapıldı = Anasayfa.getBitStateByte(Anasayfa.readBool[0], 0);    //db1 BİT 0.0   1
            M_Pres_1_iş_başlat = Anasayfa.getBitStateByte(Anasayfa.readBool[0], 1);               //db1 BİT 0.1   2
            M_Pres_1_iş_bitir= Anasayfa.getBitStateByte(Anasayfa.readBool[0], 2);                 //db1 BİT 0.2   3
            M_Pres_1_Forklift_Bekleme_Başlat = Anasayfa.getBitStateByte(Anasayfa.readBool[0], 3); //db1 BİT 0.3   4
            M_Pres_1_Forklift_Bekleme_Bitir = Anasayfa.getBitStateByte(Anasayfa.readBool[0], 4);  //db1 BİT 0.4   5
            M_Pres_1_Mola_Yemek_Başlat = Anasayfa.getBitStateByte(Anasayfa.readBool[0], 5);       //db1 BİT 0.5   6
            M_Pres_1_Mola_Yemek_Bitir = Anasayfa.getBitStateByte(Anasayfa.readBool[0], 6);        //db1 BİT 0.6   7
            M_Pres_1_Parça_Bekleme_Başlat= Anasayfa.getBitStateByte(Anasayfa.readBool[0], 7);     //db1 BİT 0.7   8
            M_Pres_1_Parça_Bekleme_Bitir= Anasayfa.getBitStateByte(Anasayfa.readBool[1], 0);      //db1 BİT 1.0   9
            M_Pres_1_Kalite_Onay_Başlat = Anasayfa.getBitStateByte(Anasayfa.readBool[1], 1);      //db1 BİT 1.1    10
            M_Pres_1_Kalite_Onay_Bitir = Anasayfa.getBitStateByte(Anasayfa.readBool[1], 2);       //db1 BİT 1.2    11
            M_Pres_1_Arıza_Başlat= Anasayfa.getBitStateByte(Anasayfa.readBool[1], 3);             //db1 BİT 1.3    12
            M_Pres_1_Arıza_Bitir = Anasayfa.getBitStateByte(Anasayfa.readBool[1], 4);             //db1 BİT 1.4    13
            M_Pres_1_Setup_Başlat = Anasayfa.getBitStateByte(Anasayfa.readBool[1], 5);            //db1 BİT 1.5    14
            M_Pres_1_Setup_Bitir= Anasayfa.getBitStateByte(Anasayfa.readBool[1], 6);              //db1 BİT 1.6    15
            M_Pres_1_WC_Başlat=Anasayfa.getBitStateByte(Anasayfa.readBool[1], 7);                 //db1 BİT 1.7    16
            M_Pres_1_WC_Bitir = Anasayfa.getBitStateByte(Anasayfa.readBool[2], 0);                //db1 BİT 2.0   17
            M_Pres_1_Emergency_Alarm= Anasayfa.getBitStateByte(Anasayfa.readBool[2], 1);          //db1 BİT 2.1   18
            Plc_Haberleşme_Ok = Anasayfa.getBitStateByte(Anasayfa.readBool[2], 2);                //db1 BİT 2.2   19
            M_Pres_1_Kalıp_Arıza_Başlat = Anasayfa.getBitStateByte(Anasayfa.readBool[2], 3);             //db1 BİT 2.3    20
            M_Pres_1_Kalıp_Arıza_Bitir = Anasayfa.getBitStateByte(Anasayfa.readBool[2], 4);             //db1 BİT 2.4    21
            M_Pres_1_Pres_izin_Aktif_Pasif=Anasayfa.getBitStateByte(Anasayfa.readBool[2], 5);             //db1 BİT 2.5    22
                M_Pres_1_Parça_Basılması_Bekleniyor = Anasayfa.getBitStateByte(Anasayfa.readBool[2], 6);//db1 BİT 2.6    21
                M_Pres_1_Kalite_Onay_Bekleniyor = Anasayfa.getBitStateByte(Anasayfa.readBool[2], 7);    //db1 BİT 2.7    21

                textBox1.Text = M_Pres_1_Hurda_Adeti.ToString();

                if (barkodtext.Text == "")
                {
                    barkodtext.Text = "0";
                }

                if ((M_Pres_1_Barkod_Sipariş_No_String == "0") && (txt_Null_1 == "txt_Null_1"))
                {
                    txt_Null_1 = "";
                    barkodtext.Text = "0";
                }
                else if (((M_Pres_1_Barkod_Sipariş_No_String != "0") && (txt_Null_1 == "txt_Null_1")))
                {
                    txt_Null_1 = "";
                    barkodtext.Text = M_Pres_1_Barkod_Sipariş_No_String;
                }
                BaslangıcSartlarıTimer.Enabled = true;

                // if (Application.OpenForms["u_anasayfa"] != null)
                // {
                //     Hmı_Emergency_Alarm_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[2], 7);   //data block 3 bit 2.7  24  
                //     Hmı_Emergency_Alarm_KK = Anasayfa.getBitStateByte(Anasayfa.readBool[9], 3);   //db3  9.3  81

                // gaugeAnlikKeceAkim.Text = Anasayfa.readFloat[6].ToString("0.00");
                // gaugeAnlikSicaklik.Text = Anasayfa.readFloat[7].ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Plc Değişken Veri Okuma Yazma Error1");
                Programclose = true;
            }
        }
        private void btnalarm(object sender, EventArgs e)
        {
            string[] deger = (sender as DevExpress.XtraEditors.SimpleButton).Tag.ToString().Split('.');
            if (deger[0] == "A")
            {
                if (Application.OpenForms["Alarmlar"] == null)
                {
                    Alarmlar alarm_form = new Alarmlar();
                    alarm_form.Show();
                    Alarm_Sayfa_index = Convert.ToInt16(deger[1]);
                }
            }
        }
        private void Vulkanizasyon_Oto_Btn_Click(object sender, EventArgs e)
        {
            //txt_Alarmlar.Items.Clear();
            //txt_Alarmlar.Items.Add("12");

            Anasayfa form = new Anasayfa();
            oto_index = 1;
            // vulkanizasyon_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png");
            // vulkanizasyon_alarm_btn.Text = "VULKANİZASYON NOK";
            //
            // vulkanizasyon_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            // vulkanizasyon_alarm_btn.Appearance.BackColor = Color.Red;
            //
            // vulkanizasyon_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            // vulkanizasyon_alarm_btn.AppearancePressed.Options.UseFont = true;
        }

        private void Sarma_Oto_Btn_Click(object sender, EventArgs e)
        {
            oto_index = 2;
            u_Otomatik_Prog form = new u_Otomatik_Prog();
            form.Show();
        }

        bool[] hataKontrol = new bool[200];
        string[] hatalar = new string[200];
        int sorguAdet = 0;


        void mesajEkle(int hataID)
        {

            if (hataKontrol[hataID] == false)
            {
                string sec = DateTime.Now.ToString("HH:mm:ss");
                string yazi = Environment.NewLine
                            + DateTime.Now.ToShortDateString() + ","
                            + sec + ","
                            + hatalar[hataID];

                File.AppendAllText(System.IO.Directory.GetCurrentDirectory() + "\\HATALAR\\" + "HATA_LOG" + ".csv", yazi);
                hataKontrol[hataID] = true;
            }
        }
        string[] adres = new string[500];
        string[] Barkod_text_ilk_Deger = new string[500];
        string[] Barkod_text_deger = new string[500];
        string[] adresayır = new string[500];
        int[] VALUESDint1 = new int[1];
        int ideger;

        private void BaslangıcSartlarıTimer_Tick(object sender, EventArgs e)
        {
            
          
           
            // int lenght = (M_Pres_1_Barkod_Okuma_Sipariş_Panel_String).Length;
            try
           {
                if (barkodtext.Text != "" )
            {
                if (M_Pres_1_Barkod_Okuma_Sipariş_Panel_String != (barkodtext.Text) )
                {
                        if (barkodtext.Text.StartsWith("("))
                        {
                            Barkod_text_ilk_Deger = barkodtext.Text.ToString().Split(')');
                            Barkod_text_deger = Barkod_text_ilk_Deger[1].ToString().Split('(');
                        }
                        else
                        {
                           
                            Barkod_text_deger[0] = barkodtext.Text;
                        }
                       
                        


                        string[,] recetesiparis = new string[10000, 100];
                        string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\ÜRÜNLER\\" + "ÜrünNumaraları" + ".txt");
                       // string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\ÜRÜNLER\\" + "REFERANSLAR VE ALT DETAY KODLARI" + ".xlsx");

                        
                        StreamWriter writersiparis = new StreamWriter(Directory.GetCurrentDirectory() + "\\ÜrünOkunan\\" + "OkutulanSiparis" + ".txt");
                        StreamWriter writerkayıt = new StreamWriter(Directory.GetCurrentDirectory() + "\\ÜrünKayıt\\" + "KayıtEdilecekSiparis" + ".txt");
                       // string[] linet = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\ÜrünOkunan\\" + "OkutulanSiparis" + ".txt");
                        //  int countd = lines.Length();
                        if (barkodtext.Text != "0")
                        {
                            for (ideger = 0; ideger < lines.Length; ideger++)
                            {
                                adres = lines[ideger].ToString().Split(';');

                                //  for (int j = 0; j < 2; j++)
                                //  {
                                //  recetesiparis[ideger, j] = adres[j];
                                //  }


                                //   if (barkodtext.Text == recetesiparis[ideger, 1])
                                if (Barkod_text_deger[0] == adres[1])
                                {


                                    SiparişEşleşmeOk = true;
                                    barkodtext.BackColor = Color.White;
                                    Anasayfa.writeBit(1, 0, 0, 1);  //barkod okuma yapıldı
                                    M_Pres_1_Barkod_Sipariş_No_String = adres[1];
                                    M_Pres_1_Barkod_Okuma_Sipariş_Kayıt_String = adres[0];

                                    listView2.Clear();
                                    listView2.Items.Add(adres[1]);
                                    listView3.Clear();
                                    listView3.Items.Add(adres[0]);


                                    for (int t = 0; t < listView2.Items.Count; t++)
                                    {
                                        writersiparis.WriteLine(listView2.Items[t].SubItems[0].Text);
                                    }
                                    for (int z = 0; z < listView3.Items.Count; z++)
                                    {
                                        writerkayıt.WriteLine(listView3.Items[z].SubItems[0].Text);
                                    }

                                    txt_Null_4 = "txt_Null_4";
                                }
                                else
                                {

                                    // SiparişEşleşmeOk = false;
                                    // barkodtext.BackColor = Color.White;
                                    // Anasayfa.writeBit(1, 0, 0, 0);  //barkod okuma yapıldı

                                    //   listView3.Clear();
                                    //   listView3.Items.Add("0");
                                    //   listView2.Clear();
                                    //   listView2.Items.Add(barkodtext.Text);
                                    //
                                    //   for (int t = 0; t < listView2.Items.Count; t++)
                                    //   {
                                    //       writersiparis.WriteLine(listView2.Items[t].SubItems[0].Text);
                                    //   }
                                    //   for (int z = 0; z < listView3.Items.Count; z++)
                                    //   {
                                    //       writerkayıt.WriteLine(listView3.Items[z].SubItems[0].Text);
                                    //   }


                                }
                            }


                        }


                        if (txt_Null_4 == "txt_Null_4" && SiparişEşleşmeOk == false)
                            {
                                txt_Null_4 = "";
                                Anasayfa.writeBit(1, 0, 0, 0);  //barkod okuma yapıldı  
                            if (barkodtext.Text!="0")
                            {
                                MessageBox.Show("SİPARİŞ NUMARASI TANIMSIZ", "SİPARİŞ BARKOD OKUTMA", MessageBoxButtons.OK);
                            }
                               

                            }
                        
                        M_Pres_1_Barkod_Okuma_Sipariş_Panel_String = (barkodtext.Text).ToString();
                    writersiparis.Close();
                    writerkayıt.Close();
                }
                else
                {
                    txt_Null_4 = "txt_Null_4";
                    SiparişEşleşmeOk = false;
                   

                    }
            }
                else
                {
                    txt_Null_4 = "txt_Null_4";
                    SiparişEşleşmeOk = false;
              
                }
            }
           catch
           {
               barkodtext.BackColor = Color.Tomato;
           }
       // //  if ((M_Pres_1_Barkod_Okuma_Sipariş_No != M_Pres_1_Barkod_Okuma_Sipariş_Panel) && lenght <= 15 && txt_Null_2 == "txt_Null_2")
       //   {
       //       txt_Null_2 = "";
        //    M_Pres_1_Barkod_Sipariş_No_Okutma_Zamanı = DateTime.Now;
       //   }           
       //   else
       //   {
       //       txt_Null_2 = "txt_Null_2";
       //   }
           
        
          //  if (lenght > 15)
          //  {
          //      MessageBox.Show("Barkod okutma degeri çok yüksek");
          //  }


            if (M_Pres_1_Barkod_Sipariş_No_String != M_Pres_1_Barkod_Okuma_Sipariş_Panel_String)
            {
                M_Pres_1_Barkod_Sipariş_No_String = M_Pres_1_Barkod_Okuma_Sipariş_Panel_String;
            }

         

            digitalGauge2.Text = M_Pres_1_Barkod_Okuma_Sipariş_Kayıt_String;
            digitalGauge1.Text =M_Pres_1_Basılan_Parça_Adedi.ToString();
            VALUESDint1[0] = M_Pres_1_Barkod_Okuma_Sipariş_No;
            Anasayfa.writedint(100, VALUESDint1);//barkod okuma sipariş no  
            if (barkodtext.Text!= "0")
            {               
                barkodtext.SelectAll();
            }
            if (Anasayfa.actPage == "u_anasayfa")
            {
                if (M_Pres_1_iş_başlat == true && txt_Null_6 == "txt_Null_6")
                {
                    barkodtext.Enabled = false;
                    txt_Null_6 = "";
                }
                
            }

                //  if (barkodtext.Text != "0")
                //  {              
                //      //  VALUESDint1[0] = Convert.ToUInt16(barkodtext.Text);               
                //      Anasayfa.writeBit(1, 0, 0, 1);  //barkod okuma yapıldı                                
                //  }
                //  if (barkodtext.Text == "0")
                //  {
                //    Anasayfa.writeBit(1, 0, 0, 0);  //barkod okuma yapıldı         
                //  }
                if (M_Pres_1_Barkod_Okuma_Yapıldı==true)
            {

                simpleButton1.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png");
                simpleButton1.Text = "BARKOD OKUTMA YAPILDI İŞ BAŞLAT";
                simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                simpleButton1.Appearance.BackColor = Color.LimeGreen;
                simpleButton1.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
                simpleButton1.AppearancePressed.Options.UseFont = true;
            }
            else
            {
                simpleButton1.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png");
                simpleButton1.Text = "BARKOD OKUTMA YAPINIZ";
                simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                simpleButton1.Appearance.BackColor = Color.Red;
                simpleButton1.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
                simpleButton1.AppearancePressed.Options.UseFont = true;
            }



            if   (M_Pres_1_iş_başlat == true)
           { M_Pres1_is_baslat_btn.Appearance.BackColor = Color.LimeGreen;}
           else
           { M_Pres1_is_baslat_btn.Appearance.BackColor = Color.Blue;}



            if (M_Pres_1_Kalite_Onay_Başlat == true)
            {                
                M_Pres_1_Kalite_Onay_Btn.Appearance.BackColor = Color.LimeGreen;
                if (M_Pres_1_Kalite_Onay_Başlat_Gecici==false)
                {   M_Pres_1_Kalite_Onay_Başlama_Zamanı = DateTime.Now;
                    M_Pres_1_Kalite_Onay_Başlat_Gecici = true;}             
            }
            else
            {
                M_Pres_1_Kalite_Onay_Btn.Appearance.BackColor = Color.Blue;
                if (M_Pres_1_Kalite_Onay_Başlat_Gecici == true)
                {
                    M_Pres_1_Kalite_Onay_Bitirme_zamanı = DateTime.Now;
                    M_Pres_1_Kalite_Onay_Bitir = true;
                    M_Pres_1_Kalite_Onay_Başlat_Gecici = false;
                }
            }

            if (M_Pres_1_Arıza_Başlat == true)
            {M_Pres_1_Arıza_Btn.Appearance.BackColor = Color.LimeGreen;           
                if (M_Pres_1_Arıza_Başlat_Gecici == false)
                { M_Pres_1_Arıza_Başlama_Zamanı= DateTime.Now;             
                   M_Pres_1_Arıza_Başlat_Gecici = true;}  }
            else
            {M_Pres_1_Arıza_Btn.Appearance.BackColor = Color.Blue;

                if (M_Pres_1_Arıza_Başlat_Gecici == true)
                { M_Pres_1_Arıza_Bitirme_zamanı = DateTime.Now;
                    M_Pres_1_Arıza_Bitir = true;
                    M_Pres_1_Arıza_Başlat_Gecici = false;}}

            if (M_Pres_1_Kalıp_Arıza_Başlat == true)
            {
                M_Pres_1_Kalıp_Arıza_Btn.Appearance.BackColor = Color.LimeGreen;
                if (M_Pres_1_Kalıp_Arıza_Başlat_Gecici == false)
                {
                    M_Pres_1_Kalıp_Arıza_Başlama_Zamanı = DateTime.Now;
                    M_Pres_1_Kalıp_Arıza_Başlat_Gecici = true;
                }
            }
            else
            {
                M_Pres_1_Kalıp_Arıza_Btn.Appearance.BackColor = Color.Blue;

                if (M_Pres_1_Kalıp_Arıza_Başlat_Gecici == true)
                {
                    M_Pres_1_Kalıp_Arıza_Bitirme_zamanı = DateTime.Now;
                    M_Pres_1_Kalıp_Arıza_Bitir = true;
                    M_Pres_1_Kalıp_Arıza_Başlat_Gecici = false;
                }
            }

            if (M_Pres_1_Forklift_Bekleme_Başlat == true)
            {M_Pres_1_Forklift_Btn.Appearance.BackColor = Color.LimeGreen;
                if (M_Pres_1_Forklift_Bekleme_Başlat_Gecici == false)
                {M_Pres_1_Forklift_Bekleme_Başlama_Zamanı = DateTime.Now;
                    M_Pres_1_Forklift_Bekleme_Başlat_Gecici = true;}}
            else
            {M_Pres_1_Forklift_Btn.Appearance.BackColor = Color.Blue;
                if (M_Pres_1_Forklift_Bekleme_Başlat_Gecici == true)
                {
                    M_Pres_1_Forklift_Bekleme_Bitirme_zamanı = DateTime.Now;
                    M_Pres_1_Forklift_Bekleme_Bitir = true;
                    M_Pres_1_Forklift_Bekleme_Başlat_Gecici = false;}}



            if (M_Pres_1_Mola_Yemek_Başlat == true)
            {
                M_Pres_1_Mola_Yemek_Btn.Appearance.BackColor = Color.LimeGreen;
                if (M_Pres_1_Mola_Yemek_Başlat_Gecici == false)
                { M_Pres_1_Mola_Yemek_Başlama_Zamanı = DateTime.Now;
                  M_Pres_1_Mola_Yemek_Başlat_Gecici = true;}}
            else
            {
                M_Pres_1_Mola_Yemek_Btn.Appearance.BackColor = Color.Blue;
                if (M_Pres_1_Mola_Yemek_Başlat_Gecici == true)
                {
                    M_Pres_1_Mola_Yemek_Bitirme_zamanı = DateTime.Now;
                    M_Pres_1_Mola_Yemek_Bitir = true;
                    M_Pres_1_Mola_Yemek_Başlat_Gecici = false;}
                }


            if (M_Pres_1_Parça_Bekleme_Başlat == true)
            {
                M_Pres_1_Parça_Bekleme_Btn.Appearance.BackColor = Color.LimeGreen;
                if (M_Pres_1_Parça_Bekleme_Başlat_Gecici == false)
                {
                    M_Pres_1_Parça_Bekleme_Başlama_Zamanı = DateTime.Now;
                    M_Pres_1_Parça_Bekleme_Başlat_Gecici = true;
                }
            }
            else
            {
                M_Pres_1_Parça_Bekleme_Btn.Appearance.BackColor = Color.Blue;
                if (M_Pres_1_Parça_Bekleme_Başlat_Gecici == true)
                {
                    M_Pres_1_Parça_Bekleme_Bitirme_zamanı= DateTime.Now;
                    M_Pres_1_Parça_Bekleme_Bitir = true;
                    M_Pres_1_Parça_Bekleme_Başlat_Gecici = false;
                }
            }

            if (M_Pres_1_Setup_Başlat == true)
            {
                M_Pres_1_Setup_Btn.Appearance.BackColor = Color.LimeGreen;
                if (M_Pres_1_Setup_Başlat_Gecici == false)
                {
                    M_Pres_1_Setup_Başlama_Zamanı = DateTime.Now;
                    M_Pres_1_Setup_Başlat_Gecici = true;
                }
            }
            else
            {
                M_Pres_1_Setup_Btn.Appearance.BackColor = Color.Blue;
                if (M_Pres_1_Setup_Başlat_Gecici == true)
                {
                    M_Pres_1_Setup_Bitirme_zamanı = DateTime.Now;
                    M_Pres_1_Setup_Bitir = true;
                    M_Pres_1_Setup_Başlat_Gecici = false;
                }
            }

            if (M_Pres_1_WC_Başlat == true)
            {
                M_Pres_1_WC_Btn.Appearance.BackColor = Color.LimeGreen;
                if (M_Pres_1_WC_Başlat_Gecici== false)
                {
                    M_Pres_1_WC_Başlama_Zamanı = DateTime.Now;
                    M_Pres_1_WC_Başlat_Gecici = true;
                }
            }
            else
            {
                M_Pres_1_WC_Btn.Appearance.BackColor = Color.Blue;
                if (M_Pres_1_WC_Başlat_Gecici == true)
                {
                    M_Pres_1_WC_Bitirme_zamanı = DateTime.Now;
                    M_Pres_1_WC_Bitir = true;
                    M_Pres_1_WC_Başlat_Gecici = false;
                }
            }

            // if  (Anasayfa.actPage =="u_anasayfa")
            //  { 
            //      //  if (Application.OpenForms["u_anasayfa"] != null)
            //      //  {
            //
            //  DialogResult dialog = new DialogResult();
            //      if (m_Tutucuda_Malafa_Var_Yok_Kontrol == true)
            //      {
            //          if (u_manuel.Hmı_StepNo_Oto_Program_VP == 1)
            //          {
            //              m_Tutucuda_Malafa_Var_Yok_Kontrol = false;
            //              dialog = (MessageBox.Show("Vulkanizasyon Presini Devreye Almak için tutucuda malafa var mı? Evet yada Hayır cevap veriniz?", "REFERANSA GÖNDERME SEÇİMİ", MessageBoxButtons.YesNoCancel));
            //              if (dialog == DialogResult.Yes)
            //              {
            //                  int[] VALUESint1 = new int[1];
            //                  VALUESint1[0] = 1;
            //                  Anasayfa.writeint(66, VALUESint1); //db27 66   malafa var baslangıca almak için  
            //                  m_Tutucuda_Malafa_Var_Yok_Kontrol = false;
            //              }
            //              else if (dialog == DialogResult.No)
            //              {
            //                  int[] VALUESint1 = new int[1];
            //                  VALUESint1[0] = 2;
            //                  Anasayfa.writeint(66, VALUESint1); //db27 66   malafa var baslangıca almak için 
            //                  m_Tutucuda_Malafa_Var_Yok_Kontrol = false;
            //              }
            //          }
            //      }
            //      if (u_manuel.Hmı_StepNo_Oto_Program_VP == 1)
            //      {
            //          if (u_manuel.Hmı_Başlangıc_Sartları_Ok_VB == true && u_manuel.Hmı_Vulkanizasyonda_Malafa_Var_Yok_Referans != 0)
            //          {
            //              Referans_Ok_VP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //              Referans_Ok_VP.Appearance.BackColor = Color.LimeGreen;
            //              Referans_Ok_VP.Text = "Referans Ok";
            //          }
            //          else
            //          {
            //              Referans_Ok_VP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //              Referans_Ok_VP.Appearance.BackColor = Color.Red;
            //              Referans_Ok_VP.Text = "Referans NOK";
            //          }
            //      }
            //      else
            //      {
            //          Referans_Ok_VP.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //          Referans_Ok_VP.Appearance.BackColor = Color.DarkBlue;
            //          Referans_Ok_VP.Text = "Referans Pasif";
            //      }
            //
            //      if (u_manuel.Hmı_StepNo_Oto_Program_S == 1)
            //      {
            //          if (u_manuel.Hmı_Başlangıc_Sartları_Ok_S == true)
            //          {
            //              Referans_Ok_SS.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //              Referans_Ok_SS.Appearance.BackColor = Color.LimeGreen;
            //              Referans_Ok_SS.Text = "Referans Ok";
            //          }
            //          else
            //          {
            //              Referans_Ok_SS.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //              Referans_Ok_SS.Appearance.BackColor = Color.Red;
            //              Referans_Ok_SS.Text = "Referans NOK";
            //          }
            //      }
            //      else
            //      {
            //          Referans_Ok_SS.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //          Referans_Ok_SS.Appearance.BackColor = Color.DarkBlue;
            //          Referans_Ok_SS.Text = "Referans Pasif";
            //      }
            //      if (u_manuel.Hmı_StepNo_Oto_Program_KK == 1)
            //      {
            //          Referans_Ok_kk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //          Referans_Ok_kk.Appearance.BackColor = Color.LimeGreen;
            //          Referans_Ok_kk.Text = "Referans OK";
            //      }
            //      else
            //      {
            //          Referans_Ok_kk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //          Referans_Ok_kk.Appearance.BackColor = Color.DarkBlue;
            //          Referans_Ok_kk.Text = "Referans Pasif";
            //      }
            //
            //      if (u_manuel.Hmı_StepNo_Oto_Program_KBK == 1)
            //      {
            //          Referans_Ok_KBK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //          Referans_Ok_KBK.Appearance.BackColor = Color.LimeGreen;
            //          Referans_Ok_KBK.Text = "Referans OK";
            //      }
            //      else
            //      {
            //          Referans_Ok_KBK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //          Referans_Ok_KBK.Appearance.BackColor = Color.DarkBlue;
            //          Referans_Ok_KBK.Text = "Referans Pasif";
            //      }
            //
            //      if (u_manuel.SARMA_BASLANGIC_OK == true)
            //      {
            //          Referans_Ok_KBK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //          Referans_Ok_KBK.Appearance.BackColor = Color.LimeGreen;
            //          Referans_Ok_KBK.Text = "Referans OK";
            //      }
            //      else
            //      {
            //          Referans_Ok_KBK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //          Referans_Ok_KBK.Appearance.BackColor = Color.DarkBlue;
            //          Referans_Ok_KBK.Text = "Referans Pasif";
            //      }



            //    //Ana Sayfa Alarmlar
            //    if (Hmı_Emergency_Alarm_VP == true)
            //    {
            //        if (txt_Null_1 != "Deger1")
            //        {
            //            vulkanizasyon_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png");
            //            vulkanizasyon_alarm_btn.Text = "VULKANİZASYON NOK";
            //            vulkanizasyon_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //            vulkanizasyon_alarm_btn.Appearance.BackColor = Color.Red;
            //            vulkanizasyon_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //            vulkanizasyon_alarm_btn.AppearancePressed.Options.UseFont = true;
            //            // index[0]=txt_Alarmlar.Items.Count;
            //            //txt_Alarmlar.Items.Clear();
            //            txt_Alarmlar.Items.Add("Vulkanizasyon Presi Alarm");
            //            txt_Null_1 = "Deger1";
            //            // index[0] = index[0] - 1;
            //        }
            //    }
            //    else
            //    {
            //        if (txt_Null_1 == "Deger1")
            //        {
            //            txt_Alarmlar.Items.Clear();
            //            txt_Null_1 = "";
            //        }
            //        if (u_manuel.Hmı_Vulkanizasyon_Devrede == 1)
            //        {
            //            if (vulkanizasyon_alarm_btn.Text != "VULKANİZASYON OK")
            //            {
            //                vulkanizasyon_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png");
            //                vulkanizasyon_alarm_btn.Text = "VULKANİZASYON OK";
            //                vulkanizasyon_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //                vulkanizasyon_alarm_btn.Appearance.BackColor = Color.LimeGreen;
            //                vulkanizasyon_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //                vulkanizasyon_alarm_btn.AppearancePressed.Options.UseFont = true;
            //                // txt_Alarmlar.Items.RemoveAt(Convert.ToInt32(index[0]));
            //            }
            //        }
            //        else
            //        {
            //            if (vulkanizasyon_alarm_btn.Text != "VULKANİZASYON NOK")
            //            {
            //                vulkanizasyon_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png");
            //                vulkanizasyon_alarm_btn.Text = "VULKANİZASYON NOK";
            //                vulkanizasyon_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //                vulkanizasyon_alarm_btn.Appearance.BackColor = Color.Red;
            //                vulkanizasyon_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //                vulkanizasyon_alarm_btn.AppearancePressed.Options.UseFont = true;
            //                // txt_Alarmlar.Items.RemoveAt(Convert.ToInt32(index[0]));
            //            }
            //        }
            //    }
            //
            //
            //    if (u_manuel.Hmı_Sarma_Alarm_int != 0)
            //    {
            //        if (txt_Null_6 != "Deger6")
            //        {
            //            sarma_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png");
            //            sarma_alarm_btn.Text = "SARMA NOK";
            //            sarma_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //            sarma_alarm_btn.Appearance.BackColor = Color.Red;
            //            sarma_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //            sarma_alarm_btn.AppearancePressed.Options.UseFont = true;
            //            // index[0]=txt_Alarmlar.Items.Count;
            //            //txt_Alarmlar.Items.Clear();
            //            txt_Alarmlar.Items.Add("Sarma Alarm");
            //            txt_Null_6 = "Deger6";
            //            // index[0] = index[0] - 1;
            //        }
            //    }
            //    else
            //    {
            //        if (txt_Null_6 == "Deger6")
            //        {
            //            txt_Alarmlar.Items.Clear();
            //            txt_Null_6 = "";
            //        }
            //        if (u_manuel.SARMA_DEVREDE == true)
            //        {
            //            if (sarma_alarm_btn.Text != "SARMA OK")
            //            {
            //                sarma_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png");
            //                sarma_alarm_btn.Text = "SARMA OK";
            //                sarma_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //                sarma_alarm_btn.Appearance.BackColor = Color.LimeGreen;
            //                sarma_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //                sarma_alarm_btn.AppearancePressed.Options.UseFont = true;
            //                // txt_Alarmlar.Items.RemoveAt(Convert.ToInt32(index[0]));
            //            }
            //        }
            //        else
            //        {
            //            if (sarma_alarm_btn.Text != "SARMA NOK")
            //            {
            //                sarma_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png");
            //                sarma_alarm_btn.Text = "SARMA NOK";
            //                sarma_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //                sarma_alarm_btn.Appearance.BackColor = Color.Red;
            //                sarma_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //                sarma_alarm_btn.AppearancePressed.Options.UseFont = true;
            //                // txt_Alarmlar.Items.RemoveAt(Convert.ToInt32(index[0]));
            //            }
            //        }
            //    }
            //
            //    if (Hmı_Emergency_Alarm_KK == true)
            //    {
            //        if (txt_Null_2 != "Deger2")
            //        {
            //            kaucuk_kesme_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png");
            //            kaucuk_kesme_alarm_btn.Text = "KAUÇUK KESME NOK";
            //            kaucuk_kesme_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //            kaucuk_kesme_alarm_btn.Appearance.BackColor = Color.Red;
            //            kaucuk_kesme_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //            kaucuk_kesme_alarm_btn.AppearancePressed.Options.UseFont = true;
            //            txt_Alarmlar.Items.Add("Kaucuk Kesme Alarm");
            //            txt_Null_2 = "Deger2";
            //        }
            //    }
            //    else
            //    {
            //        if (txt_Null_2 == "Deger2")
            //        {
            //            txt_Alarmlar.Items.Clear();
            //            txt_Null_2 = "";
            //        }
            //        if (u_manuel.Hmı_Kaucuk_Kesme_Devrede == 1)
            //        {
            //            if (kaucuk_kesme_alarm_btn.Text != "KAUÇUK KESME OK")
            //            {
            //                kaucuk_kesme_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png");
            //                kaucuk_kesme_alarm_btn.Text = "KAUÇUK KESME OK";
            //                kaucuk_kesme_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //                kaucuk_kesme_alarm_btn.Appearance.BackColor = Color.LimeGreen;
            //                kaucuk_kesme_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //                kaucuk_kesme_alarm_btn.AppearancePressed.Options.UseFont = true;
            //            }
            //        }
            //        else
            //        {
            //            if (kaucuk_kesme_alarm_btn.Text != "KAUÇUK KESME NOK")
            //            {
            //                kaucuk_kesme_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png");
            //                kaucuk_kesme_alarm_btn.Text = "KAUÇUK KESME NOK";
            //                kaucuk_kesme_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //                kaucuk_kesme_alarm_btn.Appearance.BackColor = Color.Red;
            //                kaucuk_kesme_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //                kaucuk_kesme_alarm_btn.AppearancePressed.Options.UseFont = true;
            //            }
            //        }
            //    }
            //    if (Hmı_Emergency_Alarm_KBK == true)
            //    {
            //        if (txt_Null_3 != "Deger3")
            //        {
            //            kortbezi_koparma_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png");
            //            kortbezi_koparma_alarm_btn.Text = "KORT BEZİ KOPARMA NOK";
            //            kortbezi_koparma_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //            kortbezi_koparma_alarm_btn.Appearance.BackColor = Color.Red;
            //            kortbezi_koparma_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //            kortbezi_koparma_alarm_btn.AppearancePressed.Options.UseFont = true;
            //            txt_Alarmlar.Items.Add("Kort Bezi Koparma Alarm");
            //            txt_Null_3 = "Deger3";
            //        }
            //    }
            //    else
            //    {
            //        if (txt_Null_3 == "Deger3")
            //        {
            //            txt_Alarmlar.Items.Clear();
            //            txt_Null_3 = "";
            //        }
            //        if (u_manuel.Hmı_Kort_Bezi_Koparma_Devrede == 1)
            //        {
            //            if (kortbezi_koparma_alarm_btn.Text != "KORT BEZİ KOPARMA OK")
            //            {
            //                kortbezi_koparma_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png");
            //                kortbezi_koparma_alarm_btn.Text = "KORT BEZİ KOPARMA OK";
            //                kortbezi_koparma_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //                kortbezi_koparma_alarm_btn.Appearance.BackColor = Color.LimeGreen;
            //                kortbezi_koparma_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //                kortbezi_koparma_alarm_btn.AppearancePressed.Options.UseFont = true;
            //            }
            //        }
            //        else
            //        {
            //            if (kortbezi_koparma_alarm_btn.Text != "KORT BEZİ KOPARMA NOK")
            //            {
            //                kortbezi_koparma_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png");
            //                kortbezi_koparma_alarm_btn.Text = "KORT BEZİ KOPARMA NOK";
            //                kortbezi_koparma_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //                kortbezi_koparma_alarm_btn.Appearance.BackColor = Color.Red;
            //                kortbezi_koparma_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //                kortbezi_koparma_alarm_btn.AppearancePressed.Options.UseFont = true;
            //            }
            //        }
            //    }
            //    if (Hmı_Emergency_Alarm_S == true)
            //    {
            //        if (txt_Null_4 != "Deger4")
            //        {
            //            sıyırma_sogutma_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png");
            //            sıyırma_sogutma_alarm_btn.Text = "SIYIRMA SOGUTMA NOK";
            //            sıyırma_sogutma_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //            sıyırma_sogutma_alarm_btn.Appearance.BackColor = Color.Red;
            //            sıyırma_sogutma_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //            sıyırma_sogutma_alarm_btn.AppearancePressed.Options.UseFont = true;
            //            txt_Alarmlar.Items.Add("Sıyırma ve Sogutma Alarm");
            //            txt_Null_4 = "Deger4";
            //        }
            //    }
            //    else
            //    {
            //        if (txt_Null_4 == "Deger4")
            //        {
            //            txt_Alarmlar.Items.Clear();
            //            txt_Null_4 = "";
            //        }
            //        if (u_manuel.Hmı_Sıyırma_Sogutma_Devrede == 1)
            //        {
            //            if (sıyırma_sogutma_alarm_btn.Text != "SIYIRMA SOGUTMA OK")
            //            {
            //                sıyırma_sogutma_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png");
            //                sıyırma_sogutma_alarm_btn.Text = "SIYIRMA SOGUTMA OK";
            //                sıyırma_sogutma_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //                sıyırma_sogutma_alarm_btn.Appearance.BackColor = Color.LimeGreen;
            //                sıyırma_sogutma_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //                sıyırma_sogutma_alarm_btn.AppearancePressed.Options.UseFont = true;
            //            }
            //        }
            //        else
            //        {
            //            if (sıyırma_sogutma_alarm_btn.Text != "SIYIRMA SOGUTMA NOK")
            //            {
            //                sıyırma_sogutma_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png");
            //                sıyırma_sogutma_alarm_btn.Text = "SIYIRMA SOGUTMA NOK";
            //                sıyırma_sogutma_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //                sıyırma_sogutma_alarm_btn.Appearance.BackColor = Color.Red;
            //                sıyırma_sogutma_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //                sıyırma_sogutma_alarm_btn.AppearancePressed.Options.UseFont = true;
            //            }
            //        }
            //    }
            //
            //    if (Hmı_Emergency_Alarm_ABB == true)
            //    {
            //        if (txt_Null_5 != "Deger5")
            //        {
            //            robot_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png");
            //            robot_alarm_btn.Text = "ROBOT NOK";
            //            robot_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //            robot_alarm_btn.Appearance.BackColor = Color.Red;
            //            robot_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //            robot_alarm_btn.AppearancePressed.Options.UseFont = true;
            //            txt_Alarmlar.Items.Add("Robot Alarm");
            //            txt_Null_5 = "Deger5";
            //        }
            //    }
            //    else
            //    {
            //        if (txt_Null_5 == "Deger5")
            //        {
            //            txt_Alarmlar.Items.Clear();
            //            txt_Null_5 = "";
            //        }
            //        if (u_manuel.Hmı_Robot_Devrede == 1)
            //        {
            //            if (robot_alarm_btn.Text != "ROBOT OK")
            //            {
            //                robot_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png");
            //                robot_alarm_btn.Text = "ROBOT OK";
            //                robot_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //                robot_alarm_btn.Appearance.BackColor = Color.LimeGreen;
            //                robot_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //                robot_alarm_btn.AppearancePressed.Options.UseFont = true;
            //            }
            //        }
            //        else
            //        {
            //            if (robot_alarm_btn.Text != "ROBOT NOK")
            //            {
            //                robot_alarm_btn.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png");
            //                robot_alarm_btn.Text = "ROBOT NOK";
            //                robot_alarm_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //                robot_alarm_btn.Appearance.BackColor = Color.Red;
            //                robot_alarm_btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //                robot_alarm_btn.AppearancePressed.Options.UseFont = true;
            //            }
            //        }
            //    }
            //    if (u_manuel.Hmı_Tüm_istasyonları_Devrede == 1)
            //    {
            //        if (Tümİstasyonlar_ok.Text != "İSTASYONLAR OK")
            //        {
            //            Tümİstasyonlar_ok.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png");
            //            Tümİstasyonlar_ok.Text = "İSTASYONLAR OK";
            //            Tümİstasyonlar_ok.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //            Tümİstasyonlar_ok.Appearance.BackColor = Color.LimeGreen;
            //            Tümİstasyonlar_ok.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //            Tümİstasyonlar_ok.AppearancePressed.Options.UseFont = true;
            //        }
            //    }
            //    else
            //    {
            //        if (Tümİstasyonlar_ok.Text != "İSTASYONLAR NOK")
            //        {
            //            Tümİstasyonlar_ok.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png");
            //            Tümİstasyonlar_ok.Text = "İSTASYONLAR NOK";
            //            Tümİstasyonlar_ok.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            //            Tümİstasyonlar_ok.Appearance.BackColor = Color.Red;
            //            Tümİstasyonlar_ok.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Bold);
            //            Tümİstasyonlar_ok.AppearancePressed.Options.UseFont = true;
            //        }
            //    }
            //    if (u_manuel.Hmı_Malafa_Boşaltma_Yapılmalı_VP == 1)
            //    {
            //        if (DegerKontrol == "")
            //        {
            //            AktifOperatör.Items.Add("Vulkanizasyon Presi Boşaltma Yapılmalı");
            //            DegerKontrol = "DegerKontrol";
            //        }
            //    }
            //    else
            //    {
            //        if (DegerKontrol != "")
            //        {
            //            AktifOperatör.Items.Clear();
            //            DegerKontrol = "";
            //        }
            //    }
            //    if (Hmı_Alarm_4_VP == true) //çıkış tutucu malafa alamadı
            //    {
            //        if (MalafaKontroBırakamadı == "")
            //        {
            //            AktifOperatör.Items.Add("Çıkış Tutucu Malafaları Bırakamadı Manuel Moda Alarak Tutucuları Açarak Kalan Malafayı Çıkış Alt Pistona Koyunuz Vulkanizasyon Devreye Alarak Devam Ettiriniz");
            //            MalafaKontroBırakamadı = "MalafaKontroBırakamadı";
            //        }
            //    }
            //    else
            //    {
            //        if (MalafaKontroBırakamadı != "")
            //        { AktifOperatör.Items.Clear(); MalafaKontroBırakamadı = ""; }
            //    }
            //    if (Hmı_Alarm_5_VP == true) //giriş tutucu malafa alamadı
            //    {
            //        if (MalafaKontrolAlamadı == "")
            //        {
            //            AktifOperatör.Items.Add("Giriş Tutucu Malafaları Alamadı Manuel Moda Alarak Tutucuları Açarak Malafaların Tamamını Alarak Giriş Alt Pistona Koyunuz, Otomatik Adımları Resetleyerek Tekrar Sistemi Devreye Alınız");
            //            MalafaKontrolAlamadı = "MalafaKontrolAlamadı";
            //        }
            //    }
            //    else
            //    {
            //        if (MalafaKontrolAlamadı != "")
            //        { AktifOperatör.Items.Clear(); MalafaKontrolAlamadı = ""; }
            //    }
            //}
        }
      // private void simpleButton1_Click(object sender, EventArgs e)
      // {
      //     if (Application.OpenForms["Referans_Sartlar"] == null)
      //     {
      //         Referans_Sartlar referans_form = new Referans_Sartlar();
      //         referans_form.Show();
      //     }
      // }
    
       // private void simpleButton20_Click(object sender, EventArgs e)
       // {
       //     DialogResult dialog = new DialogResult();
       //     if (u_manuel.Hmı_Otomatik_Aktif == true)
       //     {
       //         if (Hmı_Alarm_27_VP == true)
       //         {
       //             MessageBox.Show("Tüm İstasyonları Devreye Almak için Vulkanizasyon Servo Motor Home Yapılmalıdır.", "REFERANSA GÖNDERME", MessageBoxButtons.OK);
       //         }
       //         else
       //         {
       //             dialog = (MessageBox.Show("Tüm İstasyonları Devreye Almak için tutucuda malafa var mı? Evet yada Hayır cevap veriniz?", "REFERANSA GÖNDERME SEÇİMİ", MessageBoxButtons.YesNoCancel));
       //             if (dialog == DialogResult.Yes)
       //             {
       //                 int[] VALUESint1 = new int[1];
       //                 VALUESint1[0] = 1;
       //                 Anasayfa.writedint(66, VALUESint1); //db27 66   malafa var baslangıca almak için
       //                 Anasayfa.writeBit(3, 26, 1, 0); //Tüm istasyonlar devreye alma
       //             }
       //             else if (dialog == DialogResult.No)
       //             {
       //                 int[] VALUESint1 = new int[1];
       //                 VALUESint1[0] = 0;
       //                 Anasayfa.writedint(66, VALUESint1); //db27 66   malafa yok baslangıca almak için
       //                 Anasayfa.writeBit(3, 26, 1, 0); //Tüm istasyonlar devreye alma
       //             }
       //         }
       //     }
       //     else
       //     {
       //         MessageBox.Show("Tüm İstasyonları Devreye Almak için Otomatik modu aktif ediniz.", "OTOMATİK MOD KONTROLÜ", MessageBoxButtons.OK);
       //     }
       // }
          



        private void u_Anasayfa_MouseUp(object sender, MouseEventArgs e)
        {
          //  string[] adres = (sender as DevExpress.XtraEditors.SimpleButton).Tag.ToString().Split('.');
          //
          //  if (adres[0] == "C")
          //  {
          //      Anasayfa.writeBit(Convert.ToUInt16(adres[1]), Convert.ToUInt16(adres[2]), Convert.ToByte(adres[3]), 0);
          //  }
          //  {
          //      // textManSartlar.Text = "";
          //  }
        } 
        private void u_Anasayfa_MouseDown(object sender, MouseEventArgs e)
        {
          // string[] adres = (sender as DevExpress.XtraEditors.SimpleButton).Tag.ToString().Split('.');
          //
          // if (adres[0] == "S")
          // {
          //     Anasayfa.writeBit(Convert.ToUInt16(adres[1]), Convert.ToUInt16(adres[2]), Convert.ToByte(adres[3]), 1);
          // }
          // if (adres[0] == "R")
          // {
          //     Anasayfa.writeBit(Convert.ToUInt16(adres[1]), Convert.ToUInt16(adres[2]), Convert.ToByte(adres[3]), 0);
          // }
          // if (adres[0] == "T")
          // {
          //     // if (Hmı_Ust_Tabla_Serbest_Düsme_Valfi == true)
          //     //
          //     // {
          //     //     Anasayfa.writeBit(Convert.ToUInt16(adres[1]), Convert.ToUInt16(adres[2]), Convert.ToByte(adres[3]), 0);
          //     // }
          //     // else
          //     // {
          //     //     Anasayfa.writeBit(Convert.ToUInt16(adres[1]), Convert.ToUInt16(adres[2]), Convert.ToByte(adres[3]), 1);
          //     // }
          // }
          // if (adres[0] == "C")
          // {
          //     Anasayfa.writeBit(Convert.ToUInt16(adres[1]), Convert.ToUInt16(adres[2]), Convert.ToByte(adres[3]), 1);
          // }
        }
        private void M_Pres1_is_baslat_btn_Click(object sender, EventArgs e)
        {

         if (M_Pres_1_Barkod_Okuma_Yapıldı == true)
         {
             if (M_Pres_1_iş_başlat == false)
             {
                  Anasayfa.writeBit(1, 0, 1, 1); //Pres 1 iş baslatma    
                 //M_Pres_1_iş_başlama_zamanı = DateTime.Now;
               
                 barkodtext.Enabled = false;
               
             }
         }
         else
         { MessageBox.Show("İŞ BAŞLATMAK İÇİN BARKOD OKUTUNUZ.", "SİPARİŞ BARKOD OKUTMA", MessageBoxButtons.OK);
                barkodtext.Focus();
                barkodtext.SelectAll();
            }
        }

        private void M_Pres_1_Kalite_Onay_Btn_Click(object sender, EventArgs e)
        {
            if (M_Pres_1_Kalite_Onay_Başlat == true)
            {
                Anasayfa.writeBit(1, 1, 1, 0);  //pres 1 kalite onay başlat 
                M_Pres_1_Kalite_Onay_Bitirme_zamanı = DateTime.Now;
                //textBox5.Text= DateTime.Now.ToLongTimeString();
            }
            else
            {     
                Anasayfa.writeBit(1, 1, 1, 1);  //pres 1 kalite onay başlat             
                Anasayfa.writeBit(1, 0, 3, 0);  //pres 1 forklift bekleme başlat
                Anasayfa.writeBit(1, 0, 5, 0);  //pres 1 mola yemek başlat        
                Anasayfa.writeBit(1, 0, 7, 0);  //pres 1 parca bekleme başlat
                Anasayfa.writeBit(1, 1, 3, 0);  //pres 1 arıza başlat
                Anasayfa.writeBit(1, 1, 5, 0);  //pres 1 setup başlat
                Anasayfa.writeBit(1, 1, 7, 0);  //pres 1 wc başlat
                Anasayfa.writeBit(1, 2, 3, 0);  //pres 1 kalıp arıza başlat
                M_Pres_1_Kalite_Onay_Başlama_Zamanı = DateTime.Now;           
            }        
        }

        private void M_Pres_1_Arıza_Btn_Click(object sender, EventArgs e)
        {
            
            if (M_Pres_1_Arıza_Başlat == true)
            {
                Anasayfa.writeBit(1, 1, 3, 0);  //pres 1 arıza başlat
                M_Pres_1_Arıza_Bitirme_zamanı =DateTime.Now;
                //   textBox5.Text= DateTime.Now.ToLongTimeString();
            }
            else
            {
                Anasayfa.writeBit(1, 1, 3, 1);  //pres 1 arıza başlat
                Anasayfa.writeBit(1, 1, 1, 0);  //pres 1 kalite onay başlat             
                Anasayfa.writeBit(1, 0, 3, 0);  //pres 1 forklift bekleme başlat
                Anasayfa.writeBit(1, 0, 5, 0);  //pres 1 mola yemek başlat        
                Anasayfa.writeBit(1, 0, 7, 0);  //pres 1 parca bekleme başlat               
                Anasayfa.writeBit(1, 1, 5, 0);  //pres 1 setup başlat
                Anasayfa.writeBit(1, 1, 7, 0);  //pres 1 wc başlat
                Anasayfa.writeBit(1, 2, 3, 0);  //pres 1 kalıp arıza başlat
                M_Pres_1_Arıza_Başlama_Zamanı = DateTime.Now;
                
             //   M_Pres_1_Arıza_Bitirme_zamanı = Convert.ToDateTime(value);

                // textBox4.Text = DateTime.Now.ToLongTimeString();
            }
        }
        private void M_Pres_1_Kalıp_Arıza_Btn_Click(object sender, EventArgs e)
        {

            if (M_Pres_1_Kalıp_Arıza_Başlat == true)
            {
                Anasayfa.writeBit(1, 2, 3, 0);  //pres 1 kalıp arıza başlat               
                M_Pres_1_Kalıp_Arıza_Bitirme_zamanı = DateTime.Now;
                //   textBox5.Text= DateTime.Now.ToLongTimeString();
            }
            else
            {
                Anasayfa.writeBit(1, 2, 3, 1);  //pres 1 kalıp arıza başlat
                Anasayfa.writeBit(1, 1, 3, 0);  //pres 1 arıza başlat
                Anasayfa.writeBit(1, 1, 1, 0);  //pres 1 kalite onay başlat             
                Anasayfa.writeBit(1, 0, 3, 0);  //pres 1 forklift bekleme başlat
                Anasayfa.writeBit(1, 0, 5, 0);  //pres 1 mola yemek başlat        
                Anasayfa.writeBit(1, 0, 7, 0);  //pres 1 parca bekleme başlat               
                Anasayfa.writeBit(1, 1, 5, 0);  //pres 1 setup başlat
                Anasayfa.writeBit(1, 1, 7, 0);  //pres 1 wc başlat               
                M_Pres_1_Kalıp_Arıza_Başlama_Zamanı = DateTime.Now;
                // textBox4.Text = DateTime.Now.ToLongTimeString();
            }
        }
        private void M_Pres_1_Forklift_Btn_Click(object sender, EventArgs e)
        {
            if (M_Pres_1_Forklift_Bekleme_Başlat == true)
            {
                Anasayfa.writeBit(1, 0, 3, 0);  //pres 1 forklift bekleme başlat
                M_Pres_1_Forklift_Bekleme_Bitirme_zamanı = DateTime.Now;
                //textBox5.Text= DateTime.Now.ToLongTimeString();
            }
            else
            {
                Anasayfa.writeBit(1, 0, 3, 1);  //pres 1 forklift bekleme başlat
                Anasayfa.writeBit(1, 1, 3, 0);  //pres 1 arıza başlat
                Anasayfa.writeBit(1, 1, 1, 0);  //pres 1 kalite onay başlat             
                Anasayfa.writeBit(1, 0, 5, 0);  //pres 1 mola yemek başlat        
                Anasayfa.writeBit(1, 0, 7, 0);  //pres 1 parca bekleme başlat               
                Anasayfa.writeBit(1, 1, 5, 0);  //pres 1 setup başlat
                Anasayfa.writeBit(1, 1, 7, 0);  //pres 1 wc başlat
                Anasayfa.writeBit(1, 2, 3, 0);  //pres 1 kalıp arıza başlat
                M_Pres_1_Forklift_Bekleme_Başlama_Zamanı = DateTime.Now;
                //textBox4.Text = DateTime.Now.ToLongTimeString();
            }
        }

        private void M_Pres_1_Mola_Yemek_Btn_Click(object sender, EventArgs e)
        {
            if (M_Pres_1_Mola_Yemek_Başlat == true)
            {
                Anasayfa.writeBit(1, 0, 5, 0);  //pres 1 mola yemek başlat 
                M_Pres_1_Mola_Yemek_Bitirme_zamanı = DateTime.Now;
                //   textBox5.Text= DateTime.Now.ToLongTimeString();
            }
            else
            {
                Anasayfa.writeBit(1, 0, 5, 1);  //pres 1 mola yemek başlat   
                Anasayfa.writeBit(1, 0, 3, 0);  //pres 1 forklift bekleme başlat
                Anasayfa.writeBit(1, 1, 3, 0);  //pres 1 arıza başlat
                Anasayfa.writeBit(1, 1, 1, 0);  //pres 1 kalite onay başlat                  
                Anasayfa.writeBit(1, 0, 7, 0);  //pres 1 parca bekleme başlat               
                Anasayfa.writeBit(1, 1, 5, 0);  //pres 1 setup başlat
                Anasayfa.writeBit(1, 1, 7, 0);  //pres 1 wc başlat
                Anasayfa.writeBit(1, 2, 3, 0);  //pres 1 kalıp arıza başlat
                M_Pres_1_Mola_Yemek_Başlama_Zamanı = DateTime.Now;
                //textBox4.Text = DateTime.Now.ToLongTimeString();
            }
        }

        private void M_Pres_1_Parça_Bekleme_Btn_Click(object sender, EventArgs e)
        {
            if (M_Pres_1_Parça_Bekleme_Başlat == true)
            {
                Anasayfa.writeBit(1, 0, 7, 0);  //pres 1 parca bekleme başlat 
                M_Pres_1_Parça_Bekleme_Bitirme_zamanı = DateTime.Now;
                //textBox5.Text= DateTime.Now.ToLongTimeString();
            }
            else
            {
                Anasayfa.writeBit(1, 0, 7, 1);  //pres 1 parca bekleme başlat   
                Anasayfa.writeBit(1, 0, 5, 0);  //pres 1 mola yemek başlat   
                Anasayfa.writeBit(1, 0, 3, 0);  //pres 1 forklift bekleme başlat
                Anasayfa.writeBit(1, 1, 3, 0);  //pres 1 arıza başlat
                Anasayfa.writeBit(1, 1, 1, 0);  //pres 1 kalite onay başlat                              
                Anasayfa.writeBit(1, 1, 5, 0);  //pres 1 setup başlat
                Anasayfa.writeBit(1, 1, 7, 0);  //pres 1 wc başlat
                Anasayfa.writeBit(1, 2, 3, 0);  //pres 1 kalıp arıza başlat
                //   textBox4.Text = DateTime.Now.ToLongTimeString();
                M_Pres_1_Parça_Bekleme_Başlama_Zamanı = DateTime.Now;
            }
        }

        private void M_Pres_1_Setup_Btn_Click(object sender, EventArgs e)
        {
            if (M_Pres_1_Setup_Başlat == true)
            {
                Anasayfa.writeBit(1, 1, 5, 0);  //pres 1 setup başlat
                M_Pres_1_Setup_Bitirme_zamanı = DateTime.Now;
                //textBox5.Text= DateTime.Now.ToLongTimeString();
            }
            else
            {
                Anasayfa.writeBit(1, 1, 5, 1);  //pres 1 setup başlat
                Anasayfa.writeBit(1, 0, 7, 0);  //pres 1 parca bekleme başlat   
                Anasayfa.writeBit(1, 0, 5, 0);  //pres 1 mola yemek başlat   
                Anasayfa.writeBit(1, 0, 3, 0);  //pres 1 forklift bekleme başlat
                Anasayfa.writeBit(1, 1, 3, 0);  //pres 1 arıza başlat
                Anasayfa.writeBit(1, 1, 1, 0);  //pres 1 kalite onay başlat                              
                Anasayfa.writeBit(1, 1, 7, 0);  //pres 1 wc başlat
                Anasayfa.writeBit(1, 2, 3, 0);  //pres 1 kalıp arıza başlat
                M_Pres_1_Setup_Başlama_Zamanı = DateTime.Now;
                //textBox4.Text = DateTime.Now.ToLongTimeString();
            }
        }

        private void M_Pres_1_WC_Btn_Click(object sender, EventArgs e)
        {
            if (M_Pres_1_WC_Başlat == true)
            {
                Anasayfa.writeBit(1, 1, 7, 0);  //pres 1 wc başlat
                M_Pres_1_WC_Bitirme_zamanı = DateTime.Now;
                //textBox5.Text= DateTime.Now.ToLongTimeString();
            }
            else
            {
                Anasayfa.writeBit(1, 1, 7, 1);  //pres 1 wc başlat
                Anasayfa.writeBit(1, 1, 5, 0);  //pres 1 setup başlat
                Anasayfa.writeBit(1, 0, 7, 0);  //pres 1 parca bekleme başlat   
                Anasayfa.writeBit(1, 0, 5, 0);  //pres 1 mola yemek başlat   
                Anasayfa.writeBit(1, 0, 3, 0);  //pres 1 forklift bekleme başlat
                Anasayfa.writeBit(1, 1, 3, 0);  //pres 1 arıza başlat
                Anasayfa.writeBit(1, 1, 1, 0);  //pres 1 kalite onay başlat 
                Anasayfa.writeBit(1, 2, 3, 0);  //pres 1 kalıp arıza başlat
                M_Pres_1_WC_Başlama_Zamanı = DateTime.Now;
                //textBox4.Text = DateTime.Now.ToLongTimeString();
            }
        }
        string[] okunanstring = new string[1];
        string[] kayıtstring = new string[1];
        private void u_anasayfa_Load(object sender, EventArgs e)
        {
            string[] liner = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "AktifKullanıcı" + ".txt");
            int countrt = liner.Count();

         string[] lineokutulanürün = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\ÜrünOkunan\\" + "OkutulanSiparis" + ".txt");
          int countokutulan = lineokutulanürün.Count();
         //
         string[] linekayıtlıürün = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\ÜrünKayıt\\" + "KayıtEdilecekSiparis" + ".txt");
          int countkayıtlı = linekayıtlıürün.Count();


            // barkodtext.Visible = false;
            barkodtext.Focus();
            txt_Null_1 = "txt_Null_1";
            tmrCheck.Enabled = true;
            m_ayarlar.recipeOku("Yarış Kayıt Dosyası");
            hatalar = File.ReadAllLines(System.IO.Directory.GetCurrentDirectory() + "\\HATALAR\\" + "HATA" + ".txt");    
            timer1.Enabled = true;
            int i;
            for (i = 0; i < countrt; i++)
            {
                u_anasayfa.operatör_adı[i] = liner[i];
            }
            int d1;
            for (d1 = 0; d1 < countokutulan; d1++)
            {
                okunanstring[0] = lineokutulanürün[0];
                M_Pres_1_Barkod_Sipariş_No_String = okunanstring[0];
                M_Pres_1_Barkod_Okuma_Sipariş_Panel_String = M_Pres_1_Barkod_Sipariş_No_String;
                barkodtext.Text= M_Pres_1_Barkod_Sipariş_No_String;
            }
            if (countokutulan==0)
                {
                M_Pres_1_Barkod_Okuma_Sipariş_Panel_String = "0";
                barkodtext.Text = "0";
                M_Pres_1_Barkod_Sipariş_No_String = "0";
                }
            int d2;
            for (d2 = 0; d2 < countkayıtlı; d2++)
            {
                kayıtstring[0] = linekayıtlıürün[0];
                M_Pres_1_Barkod_Okuma_Sipariş_Kayıt_String = kayıtstring[0];
            }
            if (countokutulan == 0)
            {
                M_Pres_1_Barkod_Okuma_Sipariş_Kayıt_String = "0";
            }
            txt_Null_6 = "txt_Null_6";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (M_Pres_1_Barkod_Okuma_Yapıldı == true) mesajEkle(0); else hataKontrol[0] = false;
            if (M_Pres_1_iş_başlat  == true) mesajEkle(1); else hataKontrol[1] = false; 
            if (M_Pres_1_iş_bitir == true) mesajEkle(2); else hataKontrol[2] = false; M_Pres_1_iş_bitir = false;
            if (M_Pres_1_Forklift_Bekleme_Başlat == true) mesajEkle(3); else hataKontrol[3] = false;
            if (M_Pres_1_Forklift_Bekleme_Bitir == true) mesajEkle(4); else hataKontrol[4] = false; M_Pres_1_Forklift_Bekleme_Bitir = false;
            if (M_Pres_1_Mola_Yemek_Başlat == true) mesajEkle(5); else hataKontrol[5] = false;
            if (M_Pres_1_Mola_Yemek_Bitir == true) mesajEkle(6); else hataKontrol[6] = false; M_Pres_1_Mola_Yemek_Bitir = false;
            if (M_Pres_1_Parça_Bekleme_Başlat == true) mesajEkle(7); else hataKontrol[7] = false;
            if (M_Pres_1_Parça_Bekleme_Bitir == true) mesajEkle(8); else hataKontrol[8] = false; M_Pres_1_Parça_Bekleme_Bitir = false;
            if (M_Pres_1_Kalite_Onay_Başlat == true) mesajEkle(9); else hataKontrol[9] = false;
            if (M_Pres_1_Kalite_Onay_Bitir == true) mesajEkle(10); else hataKontrol[10] = false; M_Pres_1_Kalite_Onay_Bitir = false;
            if (M_Pres_1_Arıza_Başlat == true) mesajEkle(11); else hataKontrol[11] = false;
            if (M_Pres_1_Arıza_Bitir == true) mesajEkle(12); else hataKontrol[12] = false; M_Pres_1_Arıza_Bitir = false;
            if (M_Pres_1_Setup_Başlat == true) mesajEkle(13); else hataKontrol[13] = false; 
            if (M_Pres_1_Setup_Bitir == true) mesajEkle(14); else hataKontrol[14] = false; M_Pres_1_Setup_Bitir = false;
            if (M_Pres_1_WC_Başlat == true) mesajEkle(15); else hataKontrol[15] = false; 
            if (M_Pres_1_WC_Bitir == true) mesajEkle(16); else hataKontrol[16] = false; M_Pres_1_WC_Bitir = false;
            if (M_Pres_1_Kalıp_Arıza_Başlat == true) mesajEkle(17); else hataKontrol[17] = false; 
            if (M_Pres_1_Kalıp_Arıza_Bitir == true) mesajEkle(18); else hataKontrol[18] = false; M_Pres_1_Kalıp_Arıza_Bitir = false;

            if (M_Pres_1_Parça_Basılması_Bekleniyor == true)
            { simpleButton2.Visible = true; }
            else
            { simpleButton2.Visible = false; }
            if (M_Pres_1_Kalite_Onay_Bekleniyor == true)
            { simpleButton3.Visible = true; }
            else
            { simpleButton3.Visible = false; }
            //   M_Pres_1_Makina_Performansı = M_Pres_1_iş_toplam_zaman-M_Pres_1_Kalite_Onay_Toplam_Zaman-M_Pres_1_WC_Toplam_Zaman-M_Pres_1_Setup_Toplam_Zaman-M_Pres_1_Parça_Bekleme_Toplam_Zaman-M_Pres_1_Kalite_Onay_Toplam_Zaman;



            //  arcScaleComponent2.MaxValue = M_Pres_1_iş_toplam_zaman;
            if (M_Pres_1_Makina_Performansı<=100)
            {
                arcScaleComponent2.Value = M_Pres_1_Makina_Performansı;
                labelComponent2.Text = M_Pres_1_Makina_Performansı.ToString();
            }
            else             
            {
                arcScaleComponent2.Value = 100;
                labelComponent2.Text = "100";
            }

            if (M_Pres_1_Operatör_Performansı <= 100)
            {
                arcScaleComponent3.Value = M_Pres_1_Operatör_Performansı;
                labelComponent4.Text = M_Pres_1_Operatör_Performansı.ToString();
            }
            else
            {
                arcScaleComponent3.Value =100;
                labelComponent4.Text = "100";
            }


            if (Anasayfa.actPage == "u_anasayfa")
            {
                if  ( txt_Null_3=="txt_Null_3")
                {
                    try
                    {
                        listView1.Clear();
                        StreamReader sr = new System.IO.StreamReader(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "AktifKullanıcı" + ".txt");
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            listView1.Items.Add(line.Split(';')[0]);
                        }
                        int sira = listView1.Items.Count;
                        // listView1.Items[sira].SubItems.Add(line.Split(';')[1]);
                        sr.Close();
                        txt_Null_3 = "";
                      //  barkodtext.Focus();
                    }
                    catch
                    {
                    }
                }
             else
                {
                    txt_Null_3 = "txt_Null_3";
                }


                try
                {
                    if (u_anasayfa.M_Pres_1_iş_başlat == true & (txt_Null_5 == ""))
                    {                       
                        txt_Null_5 = "txt_Null_5";
                    }


                    if (listView1.Items.Count>0 )
                    {
                        if (u_anasayfa.M_Pres_1_iş_başlat == false & (txt_Null_5 == "txt_Null_5"))
                        {                            
                            StreamWriter writerr = new StreamWriter(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "AktifKullanıcı" + ".txt");
                            writerr.WriteLine("");
                            writerr.Close();
                            txt_Null_5 = "";
                        }
                    }                 
                }
                catch
                {
                    MessageBox.Show("OPERATÖR LİSTESİ SİLİNEMİYOR");
                }
            }
            

            if (sorguAdet == 10)
            {
                if (Anasayfa.actPage == "u_anasayfa")
                {
                    excelDataSource1.Fill();
                }
                sorguAdet = 0;
            }
            else
            {
                sorguAdet++;
            }

        }

        private void M_Pres1_is_bitir_btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (M_Pres_1_iş_başlat == true)
            {
              //  M_Pres_1_iş_bitirme_zamanı = DateTime.Now;
                M_Pres_1_iş_bitir = true;
                //TimeSpan sonuc = Math.Round((Convert.ToDecimal(M_Pres_1_iş_bitirme_zamanı)),2) - M_Pres_1_iş_başlama_zamanı;
                //  TimeSpan sonuc = M_Pres_1_iş_bitirme_zamanı - M_Pres_1_iş_başlama_zamanı;
                //   M_Pres_1_iş_toplam_zaman= (Math.Round(sonuc.TotalMinutes, 2).ToString() + " DK" + " ; " + Math.Round(sonuc.TotalHours, 2).ToString() + " S");                                           
                barkodtext.Text = "0";
                barkodtext.Enabled = Enabled;
                Anasayfa.writeBit(1, 0, 1, 0);

                listView3.Clear();
                listView3.Items.Add("0");
                listView2.Clear();
                listView2.Items.Add(barkodtext.Text);


            }
            barkodtext.Focus();
            barkodtext.SelectAll();
        }

        private void M_Pres1_is_bitir_btn_MouseUp(object sender, MouseEventArgs e)
        {
            if (M_Pres_1_iş_başlat == true)
            {          
                m_ayarlar.kayıt_dosyasına_ekle();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

            frmKlavye frm = new frmKlavye((sender as TextBox).Text, (sender as TextBox).Tag.ToString());
            frm.Show();

        }

        private void M_Pres1_is_bitir_btn_Click(object sender, EventArgs e)
        {

        }

        // public string[] dAdres;
        // private void OtoAdımSıfırla_Click(object sender, EventArgs e)
        // {
        //      dAdres = (sender as DevExpress.XtraEditors.SimpleButton).Tag.ToString().Split('.');
        //  
        //     float[] VALUESReal = new float[1];
        //     int[] VALUESDint = new int[1];
        //     int[] VALUESint = new int[1];
        //
        //     VALUESReal[0] = 0;
        //     VALUESDint[0] = 0;
        //     VALUESint[0] = 0;
        //
        //     if (u_manuel.Hmı_Manuel_Aktif == true)
        //     {
        //         if (dAdres[0] == "R")
        //         {
        //             Anasayfa.writeReal(Convert.ToUInt16(dAdres[1]), VALUESReal);
        //         }
        //         if (dAdres[0] == "D")
        //         {
        //             Anasayfa.writedint(Convert.ToUInt16(dAdres[1]), (VALUESDint));
        //         }
        //         if (dAdres[0] == "i")
        //         {
        //             Anasayfa.writeint(Convert.ToUInt16(dAdres[1]), VALUESint);
        //         }              
        //     }
        //     else
        //     {
        //         MessageBox.Show("Otomatik Adımı Sıfırlama için Manuel Moda Alınız");
        //     }             
        // }


        //   private void simpleButton24_MouseDown(object sender, MouseEventArgs e)
        //   {
        //       
        //       if (u_manuel.Hmı_Otomatik_Aktif == true)
        //       {
        //        
        //               Anasayfa.writeBit(3, 26, 5, 1); //vulkanizasyon devreye alma                
        //       }
        //       else
        //       {
        //           MessageBox.Show("Sıyırma Sogutmayı Devreye Almak için Otomatik modu aktif ediniz.", "OTOMATİK MOD KONTROLÜ", MessageBoxButtons.OK);
        //       }
        //
        //   }


    }
} 
