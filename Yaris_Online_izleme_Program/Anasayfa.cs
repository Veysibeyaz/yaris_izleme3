using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MHJSW.ComDrvS7V6_Net;
using Microsoft.VisualBasic;


namespace Yaris_Online_izleme_Programı
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        static GANI_S7COM PLC = new GANI_S7COM();
        Panel pnl = new Panel();
        u_anasayfa p_anasayfa = new u_anasayfa();
        public u_ayarlar p_ayarlar = new u_ayarlar();
        u_manuel p_manuel = new u_manuel();
        u_grafik p_grafik = new u_grafik();
        u_servis p_servis = new u_servis();
        u_Otomatik_Prog p_Otomatik_Prog = new u_Otomatik_Prog();

        public static string actPage = string.Empty;
        public static string lastPage = string.Empty;
        public static bool actPageRefresh = false;

        Şifre şifreform = new Şifre();

        private void Anasayfa_Load(object sender, EventArgs e)
        {
           
            Form1 frmForm1 = new Form1();
            frmForm1.ShowDialog();
            tarihGuncelle();

            //  pnl.Size = new System.Drawing.Size(1366, 712);
            pnl.Size = new System.Drawing.Size(1900, 1060);
            pnl.Location = new System.Drawing.Point(0, 56);
            pnl.Name = "pnl";

            pnl.Controls.Add(p_anasayfa);
            pnl.Controls.Add(p_ayarlar);
            pnl.Controls.Add(p_grafik);
            pnl.Controls.Add(p_manuel);
            pnl.Controls.Add(p_servis);
            pnl.Controls.Add(p_Otomatik_Prog);
            Controls.Add(pnl);

            lastPage = "u_anasayfa";
            actPage = "u_anasayfa";
            actPageRefresh = true;
          //  tmrPLC.Enabled = true;
            Şifre.Şifre_ok = false;
            //  degerlerOku();
            u_ayarlar.m_iş_başlat_gecici = "m_iş_başlat_gecici";
            u_ayarlar.m_iş_bitir_gecici = "m_iş_bitir_gecici";
            u_ayarlar.m_barkod_okutma_gecici = "m_iş_bitir_gecici";

        }
        //Sistem ayarları yükleme Bölümü
        #region Sistem Ayarları
        void tarihGuncelle()
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
            lblTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void tmrSystem_Tick(object sender, EventArgs e)
        {
            tarihGuncelle();
        }
        #endregion
     
        private void btnPages(object sender, EventArgs e)
        {
           
            btnHome.BackColor = Color.WhiteSmoke;
            btnSetting.BackColor = Color.WhiteSmoke;
            btnMan.BackColor = Color.WhiteSmoke;
            btnGraph.BackColor = Color.WhiteSmoke;
            btnService.BackColor = Color.WhiteSmoke;
            button1.BackColor = Color.WhiteSmoke;
            (sender as Button).BackColor = Color.Goldenrod;

            if ((sender as Button).Tag.ToString() == "1")
            {
                lastPage = actPage;
                actPage = "u_anasayfa";
                pnl.Controls[actPage].BringToFront();
            }
            else if ((sender as Button).Tag.ToString() == "2")
            {               
                if (Şifre.Şifre_ok == false)
                {
                   şifreform.Show();                                     
                }                   
                if (Şifre.Şifre_ok == true)
                {
                    lastPage = actPage;
                    actPage = "u_ayarlar";
                    pnl.Controls[actPage].BringToFront();
                    şifreform.Hide();
                }             

                // string şifre = Interaction.InputBox("","Sayfayı Açmak için Şifre Giriniz","", 200,200);
                // if (şifre=="100")
                // {
                //     lastPage = actPage;
                //     actPage = "u_ayarlar";
                //     pnl.Controls[actPage].BringToFront();
                // }
                // else if (şifre!="" && şifre != "100")
                // {
                //     MessageBox.Show("HATALI ŞİFRE");
                // }

            }
            else if ((sender as Button).Tag.ToString() == "3")
            {
                lastPage = actPage;
                actPage = "u_manuel";
                pnl.Controls[actPage].BringToFront();
            }
            else if ((sender as Button).Tag.ToString() == "4")
            {
                lastPage = actPage;
                actPage = "u_grafik";
                pnl.Controls[actPage].BringToFront();
            }
            else if ((sender as Button).Tag.ToString() == "5")
            {
                lastPage = actPage;
                actPage = "u_servis";
                pnl.Controls[actPage].BringToFront();
            }
            else if ((sender as Button).Tag.ToString() == "6")
            {
                lastPage = actPage;
                actPage = "u_Otomatik_Prog";
                pnl.Controls[actPage].BringToFront();
            }
        }
        public static byte[] readBool = new byte[100];
        public static int[] readInt = new int[100];
        public static int[] readDInt = new int[100];
        public static float[] readFloat = new float[190];
        void degerlerOku()
        {           
            readBool = PLC.readByte("DB", 1, 0, 4);//30
            // readBool = PLC.readByte("DB", 3, 0, 26);
            //  readBool = PLC.readByte("DB", 3, 0, 6);
         ////   readInt = PLC.readInt("DB", 27, 0, 51);//39
            readDInt = PLC.readDInt("DB", 2, 0, 46);//39
          ////  readFloat = PLC.readReal("DB", 5, 0, 173);//105 540
           //  MessageBox.Show(getBitStateByte(readBool[0], 5).ToString());
        }
        private void tmrPLC_Tick(object sender, EventArgs e)
        {
       //  tmrPLC.Stop();         
       //  degerlerOku();
      //   tmrPLC.Start();
            if (u_anasayfa.Programclose)
            {
                Close();
            }
           
        }
        public static bool getBitStateByte(Byte value, int tag)
        {
            return (value & (1 << tag)) != 0;
        }
        public static void writeBit(ushort db, ushort adrss, byte Bit, byte val)
        {
            PLC.writeBool("DB", db, adrss, Bit, val);
        }
        public static void writedint(ushort addr, int[] valuedint)
        {
            PLC.writeDInt("DB", 2, addr, Convert.ToUInt16(valuedint.Length), valuedint);
            //Convert.ToUInt16(valueint.Length)
        }
        public static void writeReal(ushort adrs, float[] valuereal)
        {
            PLC.writeReal("DB", 5, adrs, Convert.ToUInt16(valuereal.Length), valuereal);
        }     
        public static void writeint(ushort addrs, int[] valueint)
        {
            PLC.writeInt("DB", 27, addrs, Convert.ToUInt16(valueint.Length), valueint);
        }     
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (Şifre.Şifre_ok == true)
            {
                simpleButton1.Text = "ŞİFRE GİRİŞ AKTİF";
                simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                simpleButton1.Appearance.BackColor = Color.LimeGreen;
            }
            else
            {
                simpleButton1.Text = "ŞİFRE GİRİŞ PASİF";
                simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                simpleButton1.Appearance.BackColor = Color.Red;
            }

                if (u_anasayfa.Plc_Haberleşme_Ok == true)
            {
                if (HaberleşmeDurumu.Text != "HABERLEŞME OK")
                {
                    HaberleşmeDurumu.Text = "HABERLEŞME OK";
                    HaberleşmeDurumu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                    HaberleşmeDurumu.Appearance.BackColor = Color.LimeGreen;
                }

          //     if (u_manuel.Hmı_Haberleşme_Ok == true)
          // {
          //     if (HaberleşmeDurumu.Text != "HABERLEŞME OK")
          //     {
          //         HaberleşmeDurumu.Text = "HABERLEŞME OK";
          //         HaberleşmeDurumu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
          //         HaberleşmeDurumu.Appearance.BackColor = Color.Green;
          //     }                
               // HaberleşmeDurumu.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
              //  HaberleşmeDurumu.AppearancePressed.Options.UseFont = true;
            }
            else
            {              
                if (HaberleşmeDurumu.Text != "HABERLEŞME NOK")
                {
                    HaberleşmeDurumu.Text = "HABERLEŞME NOK";
                    HaberleşmeDurumu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                    HaberleşmeDurumu.Appearance.BackColor = Color.Red;
                }             
            }        
            if (u_anasayfa.M_Pres_1_Barkod_Okuma_Yapıldı == true)
            {
 
                    ModDurumu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                    ModDurumu.Appearance.BackColor = Color.LimeGreen;
                             
                // HaberleşmeDurumu.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
                //  HaberleşmeDurumu.AppearancePressed.Options.UseFont = true;
            }
            else 
            {
                ModDurumu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                ModDurumu.Appearance.BackColor = Color.Red;
            }
         
        }  
        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            if (Şifre.Şifre_ok == false)
            {
                şifreform.Show();
            }
            if (Şifre.Şifre_ok == true)
            {
               dialog= MessageBox.Show("PROGRAMDAN ÇIKMAK İSTİYOR MUSUNUZ","PROGRAMDAN ÇIKMA", MessageBoxButtons.YesNo);
            }  
           if (dialog == DialogResult.Yes)
           {
            Close();
            şifreform.Hide();
           }
            else if (dialog == DialogResult.No)
           {
            Şifre.Şifre_ok = false;
           }
        }
        private void simpleButton3_MouseUp(object sender, MouseEventArgs e)
        {
            Anasayfa.writeBit(3, 3, 0, 0);          
        }
        private void simpleButton3_MouseDown(object sender, MouseEventArgs e)
        {
            Anasayfa.writeBit(3, 3, 0, 1);         
        } 








        
    }
}
