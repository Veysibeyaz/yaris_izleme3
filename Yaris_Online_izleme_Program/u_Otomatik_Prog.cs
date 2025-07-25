using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Yaris_Online_izleme_Programı
{
    public partial class u_Otomatik_Prog : UserControl
    {
        public u_Otomatik_Prog()
        {
            InitializeComponent();
        }


        public int Hmı_StepNo_Oto_Program_VP_change;
        public int Hmı_StepNo_Oto_Program_KK_change;
        public int Hmı_StepNo_Oto_Program_KBK_change;
        public int Hmı_StepNo_Oto_Program_S_change;
        public int Hmı_StepNo_Oto_Program_SR_change;
        public int Hmı_StepNo_Oto_Program_R_change;

        public static int Hmı_Kauçuk_Kesme_Sırası;
        public static int Hmı_Kort_Bezi_Koparma_Sırası;
        public static Int32 Hmı_Siparis_No;

        public static float[] Hmı_Ürün_Çapı_Giriniz = new float[25];
        public static int[] Hmı_Ürün_Miktarı_Giriniz = new int[25];
        public static float[] Hmı_Cap_Ölcüm_Sensörü_Degerleri = new float[11];
        public static float Hmı_Cap_Ölcüm_Sensörü_Tölerans;
        public static float[] OTO_MALAFA_ACISI = new float[5];
        public static float[] OTO_LAZER_ACISI = new float[5];
        public static float[] OTO_SARIM_BOYU = new float[5];

        public static float Hmı_Kaucuk_Bezi_1_Kesme_Boyu_Gir;
        public static float Hmı_Kaucuk_Bezi_2_Kesme_Boyu_Gir;
        public static float Hmı_Kaucuk_Bezi_3_Kesme_Boyu_Gir;
        public static float Hmı_Kaucuk_Bezi_4_Kesme_Boyu_Gir;
        public static float Hmı_Kaucuk_Bezi_5_Kesme_Boyu_Gir;
        public static float Hmı_Kaucuk_Bezi_6_Kesme_Boyu_Gir;
        public static float Hmı_Kaucuk_Bezi_7_Kesme_Boyu_Gir;
        public static float Hmı_Kaucuk_Bezi_8_Kesme_Boyu_Gir;

        public static float Hmı_Kort_Bezi_1_Koparma_Boyu_Gir;
        public static float Hmı_Kort_Bezi_2_Koparma_Boyu_Gir;
        public static float Hmı_Kort_Bezi_3_Koparma_Boyu_Gir;
        public static float Hmı_Kort_Bezi_4_Koparma_Boyu_Gir;
        public static float Hmı_Kort_Bezi_5_Koparma_Boyu_Gir;
        public static float Hmı_Kort_Bezi_6_Koparma_Boyu_Gir;
        public static float Hmı_Kort_Bezi_7_Koparma_Boyu_Gir;
        public static float Hmı_Kort_Bezi_8_Koparma_Boyu_Gir;

        public static float Hmı_Sıyırma_1_Göz_Aktif_Cap_Ölcüsü;
        public static float Hmı_Sıyırma_2_Göz_Aktif_Cap_Ölcüsü;
        public static float Hmı_Sıyırma_3_Göz_Aktif_Cap_Ölcüsü;
        public static float Hmı_Sıyırma_4_Göz_Aktif_Cap_Ölcüsü;
        public static float Hmı_Malafa_Rezerv_1_Cap_Degeri_Gir;
        public static float Hmı_Malafa_Rezerv_2_Cap_Degeri_Gir;
        public static float Hmı_Malafa_Rezerv_3_Cap_Degeri_Gir;
        public static float Hmı_Malafa_Rezerv_4_Cap_Degeri_Gir;
        public static float Hmı_Malafa_Rezerv_5_Cap_Degeri_Gir;
        public static float Hmı_Vulkanizasyon_Presi_1_Göz_Cap_Degeri_Gir;
        public static float Hmı_Vulkanizasyon_Presi_2_Göz_Cap_Degeri_Gir;
        public static float Hmı_Vulkanizasyon_Presi_3_Göz_Cap_Degeri_Gir;
        public static float Hmı_Vulkanizasyon_Presi_4_Göz_Cap_Degeri_Gir;


        public static float Hmı_Vulkanizasyon_Giris_1_Göz_Aktif_Cap_Degeri;
        public static float Hmı_Vulkanizasyon_Giris_2_Göz_Aktif_Cap_Degeri;
        public static float Hmı_Vulkanizasyon_Giris_3_Göz_Aktif_Cap_Degeri;
        public static float Hmı_Vulkanizasyon_Giris_4_Göz_Aktif_Cap_Degeri;
        public static float Hmı_Vulkanizasyon_Tutucu_1_Göz_Aktif_Cap_Degeri;
        public static float Hmı_Vulkanizasyon_Tutucu_2_Göz_Aktif_Cap_Degeri;
        public static float Hmı_Vulkanizasyon_Tutucu_3_Göz_Aktif_Cap_Degeri;
        public static float Hmı_Vulkanizasyon_Tutucu_4_Göz_Aktif_Cap_Degeri;
        public static float Hmı_Vulkanizasyon_Cıkıs_1_Göz_Aktif_Cap_Degeri;
        public static float Hmı_Vulkanizasyon_Cıkıs_2_Göz_Aktif_Cap_Degeri;
        public static float Hmı_Vulkanizasyon_Cıkıs_3_Göz_Aktif_Cap_Degeri;
        public static float Hmı_Vulkanizasyon_Cıkıs_4_Göz_Aktif_Cap_Degeri;

        public static float Hmı_Malafa_Buhar_Deger_Set_VP;
        public static float Hmı_Torba_Buhar_Deger_Set_VP;

        public static int Hmı_Ürün_Cap_1_Vulkanizasyon_Eslesme_Mikarı;
        public static int Hmı_Ürün_Cap_2_Vulkanizasyon_Eslesme_Mikarı;
        public static int Hmı_Ürün_Cap_3_Vulkanizasyon_Eslesme_Mikarı;
        public static int Hmı_Ürün_Cap_4_Vulkanizasyon_Eslesme_Mikarı;
        public static int Hmı_Ürün_Cap_5_Vulkanizasyon_Eslesme_Mikarı;
        public static int Hmı_Reçete_Yüklendi;
        public static int Hmı_Proses_Bitti;
        public static int SARMA_OTOMATIK_ADIM;



        private void u_Otomatik_Prog_Load(object sender, EventArgs e)
        {

            TabOto.SelectedIndex = u_anasayfa.Alarm_Sayfa_index;
        //   txtRecipeName.Text = Properties.Settings.Default.SON_SECILEN_RECETE;
        //   txtSonYuklenenRecete.Text = Properties.Settings.Default.SON_YUKLENEN_RECETE;
        //   try
        //   {
        //       lstRecipe.Items.Clear();
        //       string[,] receteDegerler = new string[30, 39];
        //       string[] yazi = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Recipe\\" + Properties.Settings.Default.SON_SECILEN_RECETE + ".sktp");
        //       string[] vals = new string[9];
        //       for (int i = 0; i < yazi.Length; i++)
        //       {
        //           vals = yazi[i].Split('$');
        //           for (int j = 0; j < 39; j++)
        //           {
        //               receteDegerler[i, j] = vals[j];
        //           }
        //       }
        //       for (int i = 0; i < yazi.Length; i++)
        //       {
        //           ListViewItem lstItem = new ListViewItem();
        //           lstItem.Text = (receteDegerler[i, 0]).ToString();
        //           lstItem.SubItems.Add(receteDegerler[i, 1]);
        //           lstItem.SubItems.Add(receteDegerler[i, 2]);
        //           lstItem.SubItems.Add(receteDegerler[i, 3]);
        //           lstItem.SubItems.Add(receteDegerler[i, 4]);
        //           lstItem.SubItems.Add(receteDegerler[i, 5]);
        //           lstItem.SubItems.Add(receteDegerler[i, 6]);
        //           lstItem.SubItems.Add(receteDegerler[i, 7]);
        //           lstItem.SubItems.Add(receteDegerler[i, 8]);
        //           lstItem.SubItems.Add(receteDegerler[i, 9]);
        //           lstItem.SubItems.Add(receteDegerler[i, 10]);
        //           lstItem.SubItems.Add(receteDegerler[i, 11]);
        //           lstItem.SubItems.Add(receteDegerler[i, 12]);
        //           lstItem.SubItems.Add(receteDegerler[i, 13]);
        //           lstItem.SubItems.Add(receteDegerler[i, 14]);
        //           lstItem.SubItems.Add(receteDegerler[i, 15]);
        //           lstItem.SubItems.Add(receteDegerler[i, 16]);
        //           lstItem.SubItems.Add(receteDegerler[i, 17]);
        //           lstItem.SubItems.Add(receteDegerler[i, 18]);
        //           lstItem.SubItems.Add(receteDegerler[i, 19]);
        //           lstItem.SubItems.Add(receteDegerler[i, 20]);
        //           lstItem.SubItems.Add(receteDegerler[i, 21]);
        //           lstItem.SubItems.Add(receteDegerler[i, 22]);
        //           lstItem.SubItems.Add(receteDegerler[i, 23]);
        //           lstItem.SubItems.Add(receteDegerler[i, 24]);
        //           lstItem.SubItems.Add(receteDegerler[i, 25]);
        //           lstItem.SubItems.Add(receteDegerler[i, 26]);
        //           lstItem.SubItems.Add(receteDegerler[i, 27]);
        //           lstItem.SubItems.Add(receteDegerler[i, 28]);
        //           lstItem.SubItems.Add(receteDegerler[i, 29]);
        //           lstItem.SubItems.Add(receteDegerler[i, 30]);
        //           lstItem.SubItems.Add(receteDegerler[i, 31]);
        //           lstItem.SubItems.Add(receteDegerler[i, 32]);
        //           lstItem.SubItems.Add(receteDegerler[i, 33]);
        //           lstItem.SubItems.Add(receteDegerler[i, 34]);
        //           lstItem.SubItems.Add(receteDegerler[i, 35]);
        //
        //           lstItem.SubItems.Add(receteDegerler[i, 36]);
        //           lstItem.SubItems.Add(receteDegerler[i, 37]);
        //           lstItem.SubItems.Add(receteDegerler[i, 38]);
        //           lstItem.SubItems.Add(receteDegerler[i, 39]);
        //
        //
        //           lstRecipe.Items.Add(lstItem);
        //       }
        //   }
        //   catch
        //   {
        //   }
        }

        private void otoadımlartimer_Tick(object sender, EventArgs e)
        {
            { textBox1.Text = u_manuel.Hmı_1_Tahliye_Süresi_Aktüel_VP / 60 + " dk " + (u_manuel.Hmı_1_Tahliye_Süresi_Aktüel_VP - (60 * (u_manuel.Hmı_1_Tahliye_Süresi_Aktüel_VP / 60))) + " sn "; }
            { textBox2.Text = u_manuel.Hmı_Buhar_Süresi_Aktüel_VP / 60 + " dk " + (u_manuel.Hmı_Buhar_Süresi_Aktüel_VP - (60 * (u_manuel.Hmı_Buhar_Süresi_Aktüel_VP / 60))) + " sn "; }
            { textBox3.Text = u_manuel.Hmı_2_Tahliye_Süresi_Aktüel_VP / 60 + " dk " + (u_manuel.Hmı_2_Tahliye_Süresi_Aktüel_VP - (60 * (u_manuel.Hmı_2_Tahliye_Süresi_Aktüel_VP / 60))) + " sn "; }
            { textBox4.Text = u_manuel.Hmı_Vakum_Süresi_Aktüel_VP / 60 + " dk " + (u_manuel.Hmı_Vakum_Süresi_Aktüel_VP - (60 * (u_manuel.Hmı_Vakum_Süresi_Aktüel_VP / 60))) + " sn "; }

            textBox60.Text = Hmı_Kauçuk_Kesme_Sırası.ToString();
            textBox61.Text = Hmı_Kort_Bezi_Koparma_Sırası.ToString();



            //   if (u_manuel.Hmı_StepNo_Oto_Program_VP != Hmı_StepNo_Oto_Program_VP_change )
            //    {                
            if (u_manuel.Hmı_StepNo_Oto_Program_VP == 0) { textGenelOtoAdımlar.Text = "Vulkanizasyon Presini Otomatik Çalışma için Otomatik Modda Devreye Alınız"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 1) { textGenelOtoAdımlar.Text = "Vulkanizasyon Başlangıç Şartlarına Gelmesi Bekleniyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 10) { textGenelOtoAdımlar.Text = "Robotun Malafaları Yüklemesi Bekleniyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 20) { textGenelOtoAdımlar.Text = "Torbaya Vakum Veriliyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 30) { textGenelOtoAdımlar.Text = "Giriş Pistonu ileriye Gidiyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 40) { textGenelOtoAdımlar.Text = "Giriş Üst Tabla Malafa Alma Alt Pozisyona Geliyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 50) { textGenelOtoAdımlar.Text = "Tutucular Malafaları Alıyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 60) { textGenelOtoAdımlar.Text = "Giriş Üst Tabla Yukarı Pozisyona Gidiyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 70) { textGenelOtoAdımlar.Text = "Üst Tabla Servo Orta Pozisyona, Giriş Alt Piston Malafa Yüklenme Pozisyonuna Gidiyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 80) { textGenelOtoAdımlar.Text = "Orta Kısım Üst Tabla Aşagı Torba içi Pişirme Pozisyonuna Geliyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 90) { textGenelOtoAdımlar.Text = "Torba Vakum Tahliye Yapılıyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 100) { textGenelOtoAdımlar.Text = "Torba ve Malafaya Buhar Veriliyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 110) { textGenelOtoAdımlar.Text = "Torbaya Buhar Malafaya Azot veriliyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 120) { textGenelOtoAdımlar.Text = "Tahliye Yapılıyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 130) { textGenelOtoAdımlar.Text = "Torba ve Malafaya Vakum Veriliyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 140) { textGenelOtoAdımlar.Text = "Orta Kısım Torbadan Yukarıya Çıkıyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 150) { textGenelOtoAdımlar.Text = "Tahliye Yapılıyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 160) { textGenelOtoAdımlar.Text = "Üst Tabla Servo Çıkış Pozisyonuna Gidiyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 170) { textGenelOtoAdımlar.Text = "Çıkış Alt Piston İleri Malafaları Alma Pozisyonuna Gidiyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 180) { textGenelOtoAdımlar.Text = "Çıkış Üst Tabla Aşagı Malafa Bırakma Pozisyonuna Gidiyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 190) { textGenelOtoAdımlar.Text = "Tutucular Malafaları Tablaya Bırakıyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 200) { textGenelOtoAdımlar.Text = "Çıkış Kısmı Üst Tabla Yukarı Çıkıyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 210) { textGenelOtoAdımlar.Text = "Çıkış Pistonu Geri Malafa Boşaltma Pozisyonuna Gidiyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_VP == 220) { textGenelOtoAdımlar.Text = "Üst Tabla Servo Giriş Pozisyonuna Gidiyor"; }
            Hmı_StepNo_Oto_Program_VP_change = u_manuel.Hmı_StepNo_Oto_Program_VP;
            //   } 

            //   if (u_manuel.Hmı_StepNo_Oto_Program_KK != Hmı_StepNo_Oto_Program_KK_change)
            //    {
            if (u_manuel.Hmı_StepNo_Oto_Program_KK == 0) { textKaucukKesmeOtoAdımlar.Text = "Kauçuk Kesme Otomatik Çalışma için Otomatik Modda Devreye Alınız"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_KK == 1) { textKaucukKesmeOtoAdımlar.Text = "Kauçuk Kesme Başlangıç Şartlarına Gelmesi Bekleniyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_KK == 10) { textKaucukKesmeOtoAdımlar.Text = "Kesme Pistonu Konum Değiştiriyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_KK == 15) { textKaucukKesmeOtoAdımlar.Text = "Pedala Basılmamalıdır"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_KK == 20) { textKaucukKesmeOtoAdımlar.Text = "Kauçuk Kesme Boyu Alınıyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_KK == 25) { textKaucukKesmeOtoAdımlar.Text = "Enkoder Pozizyonu Sıfırlanıyor ve Pedal Basılmamalıdır"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_KK == 30) { textKaucukKesmeOtoAdımlar.Text = "Operatör Pedal ile Kauçuk Kesmesi Bekleniyor"; }
            Hmı_StepNo_Oto_Program_KK_change = u_manuel.Hmı_StepNo_Oto_Program_KK;
            //      }          
            //  if (u_manuel.Hmı_StepNo_Oto_Program_KBK != Hmı_StepNo_Oto_Program_KBK_change)
            //   {
            if (u_manuel.Hmı_StepNo_Oto_Program_KBK == 0) { textKortBeziKoparmaOtoAdımlar.Text = "Kort Bezi Koparma Otomatik Çalışma için Otomatik Modda Devreye Alınız"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_KBK == 1) { textKortBeziKoparmaOtoAdımlar.Text = "Kort Bezi Koparma Başlangıç Şartlarına Gelmesi Bekleniyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_KBK == 10) { textKortBeziKoparmaOtoAdımlar.Text = "Tambur Tutucu Geri Açılıyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_KBK == 20) { textKortBeziKoparmaOtoAdımlar.Text = "Kort Bezi Boy Alınıyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_KBK == 30) { textKortBeziKoparmaOtoAdımlar.Text = "Kort Bezi Koparılıp Pedal ile Devam Edilmesi Bekleniyor "; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_KBK == 40) { textKortBeziKoparmaOtoAdımlar.Text = "Tambur Tutucu Geri Açılıyor"; }
            Hmı_StepNo_Oto_Program_KBK_change = u_manuel.Hmı_StepNo_Oto_Program_KBK;
            //   }
            //   if (u_manuel.Hmı_StepNo_Oto_Program_KBK != Hmı_StepNo_Oto_Program_KBK_change )

            //   {
            if (u_manuel.Hmı_StepNo_Oto_Program_S == 0) { textSıyırmaSogutmaOtoAdımlar.Text = "Sıyırma Sogutma Otomatik Çalışma için Otomatik Modda Devreye Alınız"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_S == 1) { textSıyırmaSogutmaOtoAdımlar.Text = "Sıyırma Sogutma Başlangıç Şartlarına Gelmesi Bekleniyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_S == 10) { textSıyırmaSogutmaOtoAdımlar.Text = "Robotun Malafaları Yüklemesi Bekleniyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_S == 15) { textSıyırmaSogutmaOtoAdımlar.Text = "Malafalar Sıyırma Sogutmaya Yüklendimi Sensörler Kontrol Ediliyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_S == 20) { textSıyırmaSogutmaOtoAdımlar.Text = "Sıyırma Sogutma iç Kapak Aşagı(Robot Tarafı), Dış Kapak Yukarı(Operatör Tarafı) Geliyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_S == 30) { textSıyırmaSogutmaOtoAdımlar.Text = "Üst Tabla Alt Pozisyonuna Geliyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_S == 40) { textSıyırmaSogutmaOtoAdımlar.Text = "Tutucular Malafaları Alıyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_S == 50) { textSıyırmaSogutmaOtoAdımlar.Text = "Sıyırma Üst Tabla Ara Sıyırma Pozisyonuna Gidiyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_S == 60) { textSıyırmaSogutmaOtoAdımlar.Text = "Operatör Sıyırma İşlemi Bitince Sıyırma İşlem Tamam Butonuna Basması Bekleniyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_S == 70) { textSıyırmaSogutmaOtoAdımlar.Text = "Sıyırma Sogutma iç Kapak Yukarı(Robot Tarafı), Dış Kapak Aşagı(Operatör Tarafı) Geliyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_S == 80) { textSıyırmaSogutmaOtoAdımlar.Text = "Üst Tabla Alt Pozisyonuna Geliyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_S == 90) { textSıyırmaSogutmaOtoAdımlar.Text = "Sisteme Sogutma Suyu Veriliyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_S == 100) { textSıyırmaSogutmaOtoAdımlar.Text = "Tahliye"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_S == 110) { textSıyırmaSogutmaOtoAdımlar.Text = "Sisteme Hava Veriliyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_S == 115) { textSıyırmaSogutmaOtoAdımlar.Text = "Üst Tabla Yukarı Malafaları Bırakma Pozisyonuna Gidiyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_S == 120) { textSıyırmaSogutmaOtoAdımlar.Text = "Tutucular Malafaları Bırakıyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_S == 130) { textSıyırmaSogutmaOtoAdımlar.Text = "Üst Tabla Yukarı Pozisyona Gidiyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_S == 140) { textSıyırmaSogutmaOtoAdımlar.Text = "Robot Malafaları Alması Bekleniyor"; }
            else if (u_manuel.Hmı_StepNo_Oto_Program_S == 150)
            {
                textSıyırmaSogutmaOtoAdımlar.Text = "Robot Malafaları Aldımı Sensör Kontrol ediliyor";
                Hmı_StepNo_Oto_Program_S_change = u_manuel.Hmı_StepNo_Oto_Program_S;
            }
            //    }
            Hmı_Ürün_Çapı_Giriniz[1] = Anasayfa.readFloat[54];         //data block 5 byte 216.0
            textürüncap1.Text = Hmı_Ürün_Çapı_Giriniz[1].ToString();
            Hmı_Ürün_Çapı_Giriniz[2] = Anasayfa.readFloat[55];         //data block 5 byte 220.0
            textürüncap2.Text = Hmı_Ürün_Çapı_Giriniz[2].ToString();
            Hmı_Ürün_Çapı_Giriniz[3] = Anasayfa.readFloat[56];         //data block 5 byte 224.0
            textürüncap3.Text = Hmı_Ürün_Çapı_Giriniz[3].ToString();
            Hmı_Ürün_Çapı_Giriniz[4] = Anasayfa.readFloat[57];         //data block 5 byte 228.0
            textürüncap4.Text = Hmı_Ürün_Çapı_Giriniz[4].ToString();
            Hmı_Ürün_Çapı_Giriniz[5] = Anasayfa.readFloat[58];         //data block 5 byte 232.0
            textürüncap5.Text = Hmı_Ürün_Çapı_Giriniz[5].ToString();
            Hmı_Ürün_Çapı_Giriniz[6] = Anasayfa.readFloat[59];         //data block 5 byte 236.0
            Hmı_Ürün_Çapı_Giriniz[7] = Anasayfa.readFloat[60];         //data block 5 byte 240.0
            Hmı_Ürün_Çapı_Giriniz[8] = Anasayfa.readFloat[61];         //data block 5 byte 244.0
            Hmı_Ürün_Çapı_Giriniz[9] = Anasayfa.readFloat[62];         //data block 5 byte 248.0
            Hmı_Ürün_Çapı_Giriniz[10] = Anasayfa.readFloat[63];         //data block 5 byte 252.0
            Hmı_Ürün_Çapı_Giriniz[11] = Anasayfa.readFloat[64];         //data block 5 byte 256.0
            Hmı_Ürün_Çapı_Giriniz[12] = Anasayfa.readFloat[65];         //data block 5 byte 260.0
            Hmı_Ürün_Çapı_Giriniz[13] = Anasayfa.readFloat[66];         //data block 5 byte 264.0
            Hmı_Ürün_Çapı_Giriniz[14] = Anasayfa.readFloat[67];         //data block 5 byte 268.0
            Hmı_Ürün_Çapı_Giriniz[15] = Anasayfa.readFloat[68];         //data block 5 byte 272.0
            Hmı_Ürün_Çapı_Giriniz[16] = Anasayfa.readFloat[69];         //data block 5 byte 276.0
            Hmı_Ürün_Çapı_Giriniz[17] = Anasayfa.readFloat[70];         //data block 5 byte 280.0
            Hmı_Ürün_Çapı_Giriniz[18] = Anasayfa.readFloat[71];         //data block 5 byte 284.0
            Hmı_Ürün_Çapı_Giriniz[19] = Anasayfa.readFloat[72];         //data block 5 byte 288.0
            Hmı_Ürün_Çapı_Giriniz[20] = Anasayfa.readFloat[73];         //data block 5 byte 292.0

            Hmı_Kaucuk_Bezi_1_Kesme_Boyu_Gir = Anasayfa.readFloat[74];  //data block 5 byte 296.0
            textkaucukkesme1.Text = Hmı_Kaucuk_Bezi_1_Kesme_Boyu_Gir.ToString();
            Hmı_Kaucuk_Bezi_2_Kesme_Boyu_Gir = Anasayfa.readFloat[75];  //data block 5 byte 300.0 
            textkaucukkesme2.Text = Hmı_Kaucuk_Bezi_2_Kesme_Boyu_Gir.ToString();
            Hmı_Kaucuk_Bezi_3_Kesme_Boyu_Gir = Anasayfa.readFloat[99];//data block 5 byte 396.0
            textkaucukkesme3.Text = Hmı_Kaucuk_Bezi_3_Kesme_Boyu_Gir.ToString();
            Hmı_Kaucuk_Bezi_4_Kesme_Boyu_Gir = Anasayfa.readFloat[100];//data block 5 byte 400.0
            textkaucukkesme4.Text = Hmı_Kaucuk_Bezi_4_Kesme_Boyu_Gir.ToString();
            Hmı_Kaucuk_Bezi_5_Kesme_Boyu_Gir = Anasayfa.readFloat[101];//data block 5 byte 404.0
            textkaucukkesme5.Text = Hmı_Kaucuk_Bezi_5_Kesme_Boyu_Gir.ToString();
            Hmı_Kaucuk_Bezi_6_Kesme_Boyu_Gir = Anasayfa.readFloat[130];//data block 5 byte 520.0
            Hmı_Kaucuk_Bezi_7_Kesme_Boyu_Gir = Anasayfa.readFloat[131];//data block 5 byte 524.0
            Hmı_Kaucuk_Bezi_8_Kesme_Boyu_Gir = Anasayfa.readFloat[132];//data block 5 byte 528.0


            Hmı_Kort_Bezi_1_Koparma_Boyu_Gir = Anasayfa.readFloat[76];  //data block 5 byte 304.0   
            textkortbezikoparma1.Text = Hmı_Kort_Bezi_1_Koparma_Boyu_Gir.ToString();
            Hmı_Kort_Bezi_2_Koparma_Boyu_Gir = Anasayfa.readFloat[77];  //data block 5 byte 308.0  
            textkortbezikoparma2.Text = Hmı_Kort_Bezi_2_Koparma_Boyu_Gir.ToString();
            Hmı_Kort_Bezi_3_Koparma_Boyu_Gir = Anasayfa.readFloat[102];//data block 5 byte 408.0
            textkortbezikoparma3.Text = Hmı_Kort_Bezi_3_Koparma_Boyu_Gir.ToString();
            Hmı_Kort_Bezi_4_Koparma_Boyu_Gir = Anasayfa.readFloat[103];//data block 5 byte 421.0
            textkortbezikoparma4.Text = Hmı_Kort_Bezi_4_Koparma_Boyu_Gir.ToString();
            Hmı_Kort_Bezi_5_Koparma_Boyu_Gir = Anasayfa.readFloat[104];//data block 5 byte 416.0
            textkortbezikoparma5.Text = Hmı_Kort_Bezi_5_Koparma_Boyu_Gir.ToString();
            Hmı_Kort_Bezi_6_Koparma_Boyu_Gir = Anasayfa.readFloat[133];//data block 5 byte 532.0
            Hmı_Kort_Bezi_7_Koparma_Boyu_Gir = Anasayfa.readFloat[134];//data block 5 byte 536.0
            Hmı_Kort_Bezi_8_Koparma_Boyu_Gir = Anasayfa.readFloat[135];//data block 5 byte 540.0

            float S1_TASIYICI_OTOMATIK_HIZ = Anasayfa.readFloat[136];//data block 5 byte 544.0   
            textBox46.Text = S1_TASIYICI_OTOMATIK_HIZ.ToString();
            float S2_DONDURME_OTOMATIK_HIZ = Anasayfa.readFloat[138];//data block 5 byte 552.0   
            textBox45.Text = S2_DONDURME_OTOMATIK_HIZ.ToString();
            float S3_YUKSELTME_IC_OTOMATIK_HIZ = Anasayfa.readFloat[140];//data block 5 byte 560.0
            textBox44.Text = S3_YUKSELTME_IC_OTOMATIK_HIZ.ToString();
            float S4_YUKSELTME_DIS_OTOMATIK_HIZ = Anasayfa.readFloat[142];//data block 5 byte 568.0   
            textBox43.Text = S4_YUKSELTME_DIS_OTOMATIK_HIZ.ToString();
            float S5_LAZER_OTOMATIK_HIZ = Anasayfa.readFloat[144];//data block 5 byte 576.0
            textBox42.Text = S5_LAZER_OTOMATIK_HIZ.ToString();
            float S1_TASIYICI_BASLANGIC_POZISYONU = Anasayfa.readFloat[146];//data block 5 byte 584.0
            textBox41.Text = S1_TASIYICI_BASLANGIC_POZISYONU.ToString();
            float S2_DONDURME_BASLANGIC_POZISYONU = Anasayfa.readFloat[147];//data block 5 byte 588.0
            textBox40.Text = S2_DONDURME_BASLANGIC_POZISYONU.ToString();
            float S3_YUKSELTME_IC_BASLANGIC_POZISYONU = Anasayfa.readFloat[148];//data block 5 byte 592.0
            textBox38.Text = S3_YUKSELTME_IC_BASLANGIC_POZISYONU.ToString();
            float S4_YUKSELTME_DIS_BASLANGIC_POZISYONU = Anasayfa.readFloat[149];//data block 5 byte 596.0
            textBox36.Text = S4_YUKSELTME_DIS_BASLANGIC_POZISYONU.ToString();
            float S5_LAZER_BASLANGIC_POZISYONU = Anasayfa.readFloat[150];//data block 5 byte 600.0
            textBox34.Text = S5_LAZER_BASLANGIC_POZISYONU.ToString();
            float OTO_MALAFA_CAPI = Anasayfa.readFloat[151];//data block 5 byte 604.0



            float OTO_BEZ_KALINLIGI = Anasayfa.readFloat[152];//data block 5 byte 608.0
            textBox39.Text = OTO_BEZ_KALINLIGI.ToString();
            float OTO_SARIM_BASLANGIC_POZISYONU = Anasayfa.readFloat[153];//data block 5 byte 612.0
            textBox37.Text = OTO_SARIM_BASLANGIC_POZISYONU.ToString();
            float OTO_ROBOT_MALAFA_ISLEM_POZISYONU = Anasayfa.readFloat[154];//data block 5 byte 616.0
            textBox35.Text = OTO_ROBOT_MALAFA_ISLEM_POZISYONU.ToString();

            OTO_MALAFA_ACISI[1] = Anasayfa.readFloat[155];//data block 5 byte 620.0  
            textBox51.Text = OTO_MALAFA_ACISI[1].ToString();
            OTO_MALAFA_ACISI[2] = Anasayfa.readFloat[156];//data block 5 byte 624.0 
            textBox50.Text = OTO_MALAFA_ACISI[2].ToString();
            OTO_MALAFA_ACISI[3] = Anasayfa.readFloat[157];//data block 5 byte 628.0 
            textBox49.Text = OTO_MALAFA_ACISI[3].ToString();
            OTO_MALAFA_ACISI[4] = Anasayfa.readFloat[158];//data block 5 byte 632.0 
            textBox48.Text = OTO_MALAFA_ACISI[4].ToString();
            OTO_LAZER_ACISI[1] = Anasayfa.readFloat[159];//data block 5 byte 636.0
            textBox55.Text = OTO_LAZER_ACISI[1].ToString();
            OTO_LAZER_ACISI[2] = Anasayfa.readFloat[160];//data block 5 byte 640.0
            textBox54.Text = OTO_LAZER_ACISI[2].ToString();
            OTO_LAZER_ACISI[3] = Anasayfa.readFloat[161];//data block 5 byte 644.0
            textBox53.Text = OTO_LAZER_ACISI[3].ToString();
            OTO_LAZER_ACISI[4] = Anasayfa.readFloat[162];//data block 5 byte 648.0
            textBox52.Text = OTO_LAZER_ACISI[4].ToString();
            OTO_SARIM_BOYU[1] = Anasayfa.readFloat[163];//data block 5 byte 652.0
            textBox57.Text = OTO_SARIM_BOYU[1].ToString();
            OTO_SARIM_BOYU[2] = Anasayfa.readFloat[164];//data block 5 byte 656.0
            textBox56.Text = OTO_SARIM_BOYU[2].ToString();
            OTO_SARIM_BOYU[3] = Anasayfa.readFloat[165];//data block 5 byte 660.0
            textBox58.Text = OTO_SARIM_BOYU[3].ToString();
            OTO_SARIM_BOYU[4] = Anasayfa.readFloat[166];//data block 5 byte 664.0
            textBox59.Text = OTO_SARIM_BOYU[4].ToString();
            float CLC_H = Anasayfa.readFloat[167];//data block 5 byte 668.0
            textBox47.Text = CLC_H.ToString();



            Hmı_Ürün_Miktarı_Giriniz[1] = Anasayfa.readDInt[11]; //db28 44.0
            textürünadet1.Text = Hmı_Ürün_Miktarı_Giriniz[1].ToString();
            Hmı_Ürün_Miktarı_Giriniz[2] = Anasayfa.readDInt[12]; //db28 48.0 
            textürünadet2.Text = Hmı_Ürün_Miktarı_Giriniz[2].ToString();
            Hmı_Ürün_Miktarı_Giriniz[3] = Anasayfa.readDInt[13]; //db28 52.0
            textürünadet3.Text = Hmı_Ürün_Miktarı_Giriniz[3].ToString();
            Hmı_Ürün_Miktarı_Giriniz[4] = Anasayfa.readDInt[14]; //db28 56.0
            textürünadet4.Text = Hmı_Ürün_Miktarı_Giriniz[4].ToString();
            Hmı_Ürün_Miktarı_Giriniz[5] = Anasayfa.readDInt[15]; //db28 60.0
            textürünadet5.Text = Hmı_Ürün_Miktarı_Giriniz[5].ToString();
            Hmı_Ürün_Miktarı_Giriniz[6] = Anasayfa.readDInt[16]; //db28 64.0
            Hmı_Ürün_Miktarı_Giriniz[7] = Anasayfa.readDInt[17]; //db28 68.0
            Hmı_Ürün_Miktarı_Giriniz[8] = Anasayfa.readDInt[18]; //db28 72.0
            Hmı_Ürün_Miktarı_Giriniz[9] = Anasayfa.readDInt[19]; //db28 76.0
            Hmı_Ürün_Miktarı_Giriniz[10] = Anasayfa.readDInt[20]; //db28 80.0
            Hmı_Ürün_Miktarı_Giriniz[11] = Anasayfa.readDInt[21]; //db28 84.0
            Hmı_Ürün_Miktarı_Giriniz[12] = Anasayfa.readDInt[22]; //db28 88.0
            Hmı_Ürün_Miktarı_Giriniz[13] = Anasayfa.readDInt[23]; //db28 92.0
            Hmı_Ürün_Miktarı_Giriniz[14] = Anasayfa.readDInt[24]; //db28 96.0
            Hmı_Ürün_Miktarı_Giriniz[15] = Anasayfa.readDInt[25]; //db28 100.0
            Hmı_Ürün_Miktarı_Giriniz[16] = Anasayfa.readDInt[26]; //db28 104.0
            Hmı_Ürün_Miktarı_Giriniz[17] = Anasayfa.readDInt[27]; //db28 108.0
            Hmı_Ürün_Miktarı_Giriniz[18] = Anasayfa.readDInt[28]; //db28 112.0
            Hmı_Ürün_Miktarı_Giriniz[19] = Anasayfa.readDInt[29]; //db28 116.0
            Hmı_Ürün_Miktarı_Giriniz[20] = Anasayfa.readDInt[30]; //db28 120.0   

            Hmı_Sıyırma_1_Göz_Aktif_Cap_Ölcüsü = Anasayfa.readFloat[78];  //data block 5 byte 312.0
            Hmı_Sıyırma_2_Göz_Aktif_Cap_Ölcüsü = Anasayfa.readFloat[79];  //data block 5 byte 316.0
            Hmı_Sıyırma_3_Göz_Aktif_Cap_Ölcüsü = Anasayfa.readFloat[80];  //data block 5 byte 320.0
            Hmı_Sıyırma_4_Göz_Aktif_Cap_Ölcüsü = Anasayfa.readFloat[81];  //data block 5 byte 324.0               
            Hmı_Malafa_Rezerv_1_Cap_Degeri_Gir = Anasayfa.readFloat[90];//data block 5 byte 360.0 
            textRezervCap1.Text = Hmı_Malafa_Rezerv_1_Cap_Degeri_Gir.ToString();
            Hmı_Malafa_Rezerv_2_Cap_Degeri_Gir = Anasayfa.readFloat[91];//data block 5 byte 364.0 
            textRezervCap2.Text = Hmı_Malafa_Rezerv_2_Cap_Degeri_Gir.ToString();
            Hmı_Malafa_Rezerv_3_Cap_Degeri_Gir = Anasayfa.readFloat[92];//data block 5 byte 368.0 
            textRezervCap3.Text = Hmı_Malafa_Rezerv_3_Cap_Degeri_Gir.ToString();
            Hmı_Malafa_Rezerv_4_Cap_Degeri_Gir = Anasayfa.readFloat[93];//data block 5 byte 372.0 
            textRezervCap4.Text = Hmı_Malafa_Rezerv_4_Cap_Degeri_Gir.ToString();
            Hmı_Malafa_Rezerv_5_Cap_Degeri_Gir = Anasayfa.readFloat[94];//data block 5 byte 376.0
            textRezervCap5.Text = Hmı_Malafa_Rezerv_5_Cap_Degeri_Gir.ToString();
            Hmı_Vulkanizasyon_Presi_1_Göz_Cap_Degeri_Gir = Anasayfa.readFloat[95];//data block 5 byte 380.0
            textVulkanizasyonCap1.Text = Hmı_Vulkanizasyon_Presi_1_Göz_Cap_Degeri_Gir.ToString();
            Hmı_Vulkanizasyon_Presi_2_Göz_Cap_Degeri_Gir = Anasayfa.readFloat[96];//data block 5 byte 384.0
            textVulkanizasyonCap2.Text = Hmı_Vulkanizasyon_Presi_2_Göz_Cap_Degeri_Gir.ToString();
            Hmı_Vulkanizasyon_Presi_3_Göz_Cap_Degeri_Gir = Anasayfa.readFloat[97];//data block 5 byte 388.0
            textVulkanizasyonCap3.Text = Hmı_Vulkanizasyon_Presi_3_Göz_Cap_Degeri_Gir.ToString();
            Hmı_Vulkanizasyon_Presi_4_Göz_Cap_Degeri_Gir = Anasayfa.readFloat[98];//data block 5 byte 392.0
            textVulkanizasyonCap4.Text = Hmı_Vulkanizasyon_Presi_4_Göz_Cap_Degeri_Gir.ToString();

            Hmı_Vulkanizasyon_Giris_1_Göz_Aktif_Cap_Degeri = Anasayfa.readFloat[105];//data block 5 byte 420.0
            Hmı_Vulkanizasyon_Giris_2_Göz_Aktif_Cap_Degeri = Anasayfa.readFloat[106];//data block 5 byte 424.0
            Hmı_Vulkanizasyon_Giris_3_Göz_Aktif_Cap_Degeri = Anasayfa.readFloat[107];//data block 5 byte 428.0
            Hmı_Vulkanizasyon_Giris_4_Göz_Aktif_Cap_Degeri = Anasayfa.readFloat[108];//data block 5 byte 432.0
            Hmı_Vulkanizasyon_Tutucu_1_Göz_Aktif_Cap_Degeri = Anasayfa.readFloat[109];//data block 5 byte 436.0
            Hmı_Vulkanizasyon_Tutucu_2_Göz_Aktif_Cap_Degeri = Anasayfa.readFloat[110];//data block 5 byte 440.0
            Hmı_Vulkanizasyon_Tutucu_3_Göz_Aktif_Cap_Degeri = Anasayfa.readFloat[111];//data block 5 byte 444.0
            Hmı_Vulkanizasyon_Tutucu_4_Göz_Aktif_Cap_Degeri = Anasayfa.readFloat[112];//data block 5 byte 448.0
            Hmı_Vulkanizasyon_Cıkıs_1_Göz_Aktif_Cap_Degeri = Anasayfa.readFloat[113];//data block 5 byte 452.0
            Hmı_Vulkanizasyon_Cıkıs_2_Göz_Aktif_Cap_Degeri = Anasayfa.readFloat[114];//data block 5 byte 456.0
            Hmı_Vulkanizasyon_Cıkıs_3_Göz_Aktif_Cap_Degeri = Anasayfa.readFloat[115];//data block 5 byte 460.0
            Hmı_Vulkanizasyon_Cıkıs_4_Göz_Aktif_Cap_Degeri = Anasayfa.readFloat[116];//data block 5 byte 464.0

            Hmı_Cap_Ölcüm_Sensörü_Degerleri[1] = Anasayfa.readFloat[117];//data block 5 byte 468.0
            Hmı_Cap_Ölcüm_Sensörü_Degerleri[2] = Anasayfa.readFloat[118];//data block 5 byte 472.0
            Hmı_Cap_Ölcüm_Sensörü_Degerleri[3] = Anasayfa.readFloat[119];//data block 5 byte 476.0
            Hmı_Cap_Ölcüm_Sensörü_Degerleri[4] = Anasayfa.readFloat[120];//data block 5 byte 480.0
            Hmı_Cap_Ölcüm_Sensörü_Degerleri[5] = Anasayfa.readFloat[121];//data block 5 byte 484.0
            Hmı_Cap_Ölcüm_Sensörü_Degerleri[6] = Anasayfa.readFloat[122];//data block 5 byte 488.0
            Hmı_Cap_Ölcüm_Sensörü_Degerleri[7] = Anasayfa.readFloat[123];//data block 5 byte 492.0
            Hmı_Cap_Ölcüm_Sensörü_Degerleri[8] = Anasayfa.readFloat[124];//data block 5 byte 496.0
            Hmı_Cap_Ölcüm_Sensörü_Degerleri[9] = Anasayfa.readFloat[125];//data block 5 byte 500.0
            Hmı_Cap_Ölcüm_Sensörü_Degerleri[10] = Anasayfa.readFloat[126];//data block 5 byte 504.0
            Hmı_Cap_Ölcüm_Sensörü_Tölerans = Anasayfa.readFloat[127];//data block 5 byte 508.0

            Hmı_Malafa_Buhar_Deger_Set_VP = Anasayfa.readFloat[128];//data block 5 byte 512.0
            Hmı_Torba_Buhar_Deger_Set_VP = Anasayfa.readFloat[129];//data block 5 byte 516.0

            Hmı_Ürün_Cap_1_Vulkanizasyon_Eslesme_Mikarı = Anasayfa.readInt[41];  //db27 82
            Hmı_Ürün_Cap_2_Vulkanizasyon_Eslesme_Mikarı = Anasayfa.readInt[42];  //db27 84
            Hmı_Ürün_Cap_3_Vulkanizasyon_Eslesme_Mikarı = Anasayfa.readInt[43];  //db27 86
            Hmı_Ürün_Cap_4_Vulkanizasyon_Eslesme_Mikarı = Anasayfa.readInt[44];  //db27 88
            Hmı_Ürün_Cap_5_Vulkanizasyon_Eslesme_Mikarı = Anasayfa.readInt[45];  //db27 90
            Hmı_Reçete_Yüklendi = Anasayfa.readInt[46];  //db27 92
            Hmı_Proses_Bitti = Anasayfa.readInt[47];  //db27 94
            SARMA_OTOMATIK_ADIM = Anasayfa.readInt[48];  //db27 96
            Hmı_Kauçuk_Kesme_Sırası = Anasayfa.readInt[49];  //db27 98
            Hmı_Kort_Bezi_Koparma_Sırası = Anasayfa.readInt[50];  //db27 100

            textürün1oran.Text = Hmı_Ürün_Cap_1_Vulkanizasyon_Eslesme_Mikarı.ToString();
            textürün2oran.Text = Hmı_Ürün_Cap_2_Vulkanizasyon_Eslesme_Mikarı.ToString();
            textürün3oran.Text = Hmı_Ürün_Cap_3_Vulkanizasyon_Eslesme_Mikarı.ToString();
            textürün4oran.Text = Hmı_Ürün_Cap_4_Vulkanizasyon_Eslesme_Mikarı.ToString();
            textürün5oran.Text = Hmı_Ürün_Cap_5_Vulkanizasyon_Eslesme_Mikarı.ToString();

            textGerekliMalafa1.Text = ((Convert.ToInt16(textürün1oran.Text)) * 4).ToString(); // yada herbir vulkanizasyon gözü için 4 malafa ile carpılabilir.
            textGerekliMalafa2.Text = ((Convert.ToInt16(textürün2oran.Text)) * 4).ToString();
            textGerekliMalafa3.Text = ((Convert.ToInt16(textürün3oran.Text)) * 4).ToString();
            textGerekliMalafa4.Text = ((Convert.ToInt16(textürün4oran.Text)) * 4).ToString();

        }
        private void clkText(object sender, EventArgs e)
        {
            frmKlavye frm = new frmKlavye((sender as TextBox).Text, (sender as TextBox).Tag.ToString());
            frm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {          
            int i = 0;
            Hmı_Ürün_Cap_1_Vulkanizasyon_Eslesme_Mikarı = 0;
            Hmı_Ürün_Cap_2_Vulkanizasyon_Eslesme_Mikarı = 0;
            Hmı_Ürün_Cap_3_Vulkanizasyon_Eslesme_Mikarı = 0;
            Hmı_Ürün_Cap_4_Vulkanizasyon_Eslesme_Mikarı = 0;
            Hmı_Ürün_Cap_5_Vulkanizasyon_Eslesme_Mikarı = 0;
            CheckCapKontrol1.BackColor = Color.White;
            CheckCapKontrol2.BackColor = Color.White;
            CheckCapKontrol3.BackColor = Color.White;
            CheckCapKontrol4.BackColor = Color.White;
            checkVulCapKontrol1.BackColor = Color.White;
            checkVulCapKontrol2.BackColor = Color.White;
            checkVulCapKontrol3.BackColor = Color.White;
            checkVulCapKontrol4.BackColor = Color.White;
            CheckRezervVulÇapKontrol1.BackColor = Color.White;
            CheckRezervVulÇapKontrol2.BackColor = Color.White;
            CheckRezervVulÇapKontrol3.BackColor = Color.White;
            CheckRezervVulÇapKontrol4.BackColor = Color.White;

            for (i = 0; i < 6; i++)
            {
                if (Hmı_Ürün_Miktarı_Giriniz[i] != 0)
                {
                    if ((Hmı_Ürün_Çapı_Giriniz[i] != 0))
                    {
                        if (Hmı_Ürün_Çapı_Giriniz[i] == Hmı_Malafa_Rezerv_1_Cap_Degeri_Gir)
                        {
                            if (i == 1)
                            { CheckCapKontrol1.BackColor = Color.Green; }
                            if (i == 2)
                            { CheckCapKontrol2.BackColor = Color.Green; }
                            if (i == 3)
                            { CheckCapKontrol3.BackColor = Color.Green; }
                            if (i == 4)
                            { CheckCapKontrol4.BackColor = Color.Green; }
                            if (i == 5)
                            { CheckCapKontrol5.BackColor = Color.Green; }
                        }
                        else if (Hmı_Ürün_Çapı_Giriniz[i] == Hmı_Malafa_Rezerv_2_Cap_Degeri_Gir)
                        {
                            if (i == 1)
                            { CheckCapKontrol1.BackColor = Color.Green; }
                            if (i == 2)
                            { CheckCapKontrol2.BackColor = Color.Green; }
                            if (i == 3)
                            { CheckCapKontrol3.BackColor = Color.Green; }
                            if (i == 4)
                            { CheckCapKontrol4.BackColor = Color.Green; }
                            if (i == 5)
                            { CheckCapKontrol5.BackColor = Color.Green; }

                        }
                        else if (Hmı_Ürün_Çapı_Giriniz[i] == Hmı_Malafa_Rezerv_3_Cap_Degeri_Gir)
                        {
                            if (i == 1)
                            { CheckCapKontrol1.BackColor = Color.Green; }
                            if (i == 2)
                            { CheckCapKontrol2.BackColor = Color.Green; }
                            if (i == 3)
                            { CheckCapKontrol3.BackColor = Color.Green; }
                            if (i == 4)
                            { CheckCapKontrol4.BackColor = Color.Green; }
                            if (i == 5)
                            { CheckCapKontrol5.BackColor = Color.Green; }
                        }
                        else if (Hmı_Ürün_Çapı_Giriniz[i] == Hmı_Malafa_Rezerv_4_Cap_Degeri_Gir)
                        {
                            if (i == 1)
                            { CheckCapKontrol1.BackColor = Color.Green; }
                            if (i == 2)
                            { CheckCapKontrol2.BackColor = Color.Green; }
                            if (i == 3)
                            { CheckCapKontrol3.BackColor = Color.Green; }
                            if (i == 4)
                            { CheckCapKontrol4.BackColor = Color.Green; }
                            if (i == 5)
                            { CheckCapKontrol5.BackColor = Color.Green; }
                        }
                        else if (Hmı_Ürün_Çapı_Giriniz[i] == Hmı_Malafa_Rezerv_5_Cap_Degeri_Gir)
                        {
                            if (i == 1)
                            { CheckCapKontrol1.BackColor = Color.Green; }
                            if (i == 2)
                            { CheckCapKontrol2.BackColor = Color.Green; }
                            if (i == 3)
                            { CheckCapKontrol3.BackColor = Color.Green; }
                            if (i == 4)
                            { CheckCapKontrol4.BackColor = Color.Green; }
                            if (i == 5)
                            { CheckCapKontrol5.BackColor = Color.Green; }
                        }
                        else
                        {
                            if (i == 1)
                            { CheckCapKontrol1.BackColor = Color.Red; }
                            if (i == 2)
                            { CheckCapKontrol2.BackColor = Color.Red; }
                            if (i == 3)
                            { CheckCapKontrol3.BackColor = Color.Red; }
                            if (i == 4)
                            { CheckCapKontrol4.BackColor = Color.Red; }
                            if (i == 5)
                            { CheckCapKontrol5.BackColor = Color.Red; }
                        }
                        if (Hmı_Ürün_Çapı_Giriniz[i] == Hmı_Vulkanizasyon_Presi_1_Göz_Cap_Degeri_Gir )
                        {           
                            if (i == 1)
                            { checkVulCapKontrol1.BackColor = Color.Green; }
                            if (i == 2)
                            { checkVulCapKontrol2.BackColor = Color.Green; }
                            if (i == 3)
                            { checkVulCapKontrol3.BackColor = Color.Green; }
                            if (i == 4)
                            { checkVulCapKontrol4.BackColor = Color.Green; }
                            if (i == 5)
                            { checkVulCapKontrol5.BackColor = Color.Green; }
                        }
                        else if (Hmı_Ürün_Çapı_Giriniz[i] == Hmı_Vulkanizasyon_Presi_2_Göz_Cap_Degeri_Gir )
                        {                           
                            if (i == 1)
                            { checkVulCapKontrol1.BackColor = Color.Green; }
                            if (i == 2)
                            { checkVulCapKontrol2.BackColor = Color.Green; }
                            if (i == 3)
                            { checkVulCapKontrol3.BackColor = Color.Green; }
                            if (i == 4)
                            { checkVulCapKontrol4.BackColor = Color.Green; }
                            if (i == 5)
                            { checkVulCapKontrol5.BackColor = Color.Green; }
                        }
                        else if (Hmı_Ürün_Çapı_Giriniz[i] == Hmı_Vulkanizasyon_Presi_3_Göz_Cap_Degeri_Gir)
                        {                          
                            if (i == 1)
                            { checkVulCapKontrol1.BackColor = Color.Green; }
                            if (i == 2)
                            { checkVulCapKontrol2.BackColor = Color.Green; }
                            if (i == 3)
                            { checkVulCapKontrol3.BackColor = Color.Green; }
                            if (i == 4)
                            { checkVulCapKontrol4.BackColor = Color.Green; }
                            if (i == 5)
                            { checkVulCapKontrol5.BackColor = Color.Green; }
                        }
                        else if (Hmı_Ürün_Çapı_Giriniz[i] == Hmı_Vulkanizasyon_Presi_4_Göz_Cap_Degeri_Gir & Hmı_Ürün_Çapı_Giriniz[i]!=0)
                        {                        
                            if (i == 1)
                            { checkVulCapKontrol1.BackColor = Color.Green; }
                            if (i == 2)
                            { checkVulCapKontrol2.BackColor = Color.Green; }
                            if (i == 3)
                            { checkVulCapKontrol3.BackColor = Color.Green; }
                            if (i == 4)
                            { checkVulCapKontrol4.BackColor = Color.Green; }
                            if (i == 5)
                            { checkVulCapKontrol5.BackColor = Color.Green; }
                        }                 
                        else
                        {
                            if (i == 1)
                            { checkVulCapKontrol1.BackColor = Color.Red; }
                            if (i == 2)
                            { checkVulCapKontrol2.BackColor = Color.Red; }
                            if (i == 3)
                            { checkVulCapKontrol3.BackColor = Color.Red; }
                            if (i == 4)
                            { checkVulCapKontrol4.BackColor = Color.Red; }
                            if (i == 5)
                            { checkVulCapKontrol5.BackColor = Color.Red; }
                        }                      
                        if (Hmı_Ürün_Çapı_Giriniz[i] == Hmı_Vulkanizasyon_Presi_1_Göz_Cap_Degeri_Gir)
                        {
                            if (i == 1)
                            { Hmı_Ürün_Cap_1_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_1_Vulkanizasyon_Eslesme_Mikarı + 1; }
                            if (i == 2)
                            { Hmı_Ürün_Cap_2_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_2_Vulkanizasyon_Eslesme_Mikarı + 1; }
                            if (i == 3)
                            { Hmı_Ürün_Cap_3_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_3_Vulkanizasyon_Eslesme_Mikarı + 1; }
                            if (i == 4)
                            { Hmı_Ürün_Cap_4_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_4_Vulkanizasyon_Eslesme_Mikarı + 1; }
                            if (i == 5)
                            { Hmı_Ürün_Cap_5_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_5_Vulkanizasyon_Eslesme_Mikarı + 1; }                          
                        }
                        if (Hmı_Ürün_Çapı_Giriniz[i] == Hmı_Vulkanizasyon_Presi_2_Göz_Cap_Degeri_Gir)
                        {
                            if (i == 1)
                            { Hmı_Ürün_Cap_1_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_1_Vulkanizasyon_Eslesme_Mikarı + 1; }
                            if (i == 2)
                            { Hmı_Ürün_Cap_2_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_2_Vulkanizasyon_Eslesme_Mikarı + 1; }
                            if (i == 3)
                            { Hmı_Ürün_Cap_3_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_3_Vulkanizasyon_Eslesme_Mikarı + 1; }
                            if (i == 4)
                            { Hmı_Ürün_Cap_4_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_4_Vulkanizasyon_Eslesme_Mikarı + 1; }
                            if (i == 5)
                            { Hmı_Ürün_Cap_5_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_5_Vulkanizasyon_Eslesme_Mikarı + 1; }
                        }
                        if (Hmı_Ürün_Çapı_Giriniz[i] == Hmı_Vulkanizasyon_Presi_3_Göz_Cap_Degeri_Gir)
                        {
                            if (i == 1)
                            { Hmı_Ürün_Cap_1_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_1_Vulkanizasyon_Eslesme_Mikarı + 1; }
                            if (i == 2)
                            { Hmı_Ürün_Cap_2_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_2_Vulkanizasyon_Eslesme_Mikarı + 1; }
                            if (i == 3)
                            { Hmı_Ürün_Cap_3_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_3_Vulkanizasyon_Eslesme_Mikarı + 1; }
                            if (i == 4)
                            { Hmı_Ürün_Cap_4_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_4_Vulkanizasyon_Eslesme_Mikarı + 1; }
                            if (i == 5)
                            { Hmı_Ürün_Cap_5_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_5_Vulkanizasyon_Eslesme_Mikarı + 1; }
                        }
                        if (Hmı_Ürün_Çapı_Giriniz[i] == Hmı_Vulkanizasyon_Presi_4_Göz_Cap_Degeri_Gir)
                        {
                            if (i == 1)
                            { Hmı_Ürün_Cap_1_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_1_Vulkanizasyon_Eslesme_Mikarı + 1; }
                            if (i == 2)
                            { Hmı_Ürün_Cap_2_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_2_Vulkanizasyon_Eslesme_Mikarı + 1; }
                            if (i == 3)
                            { Hmı_Ürün_Cap_3_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_3_Vulkanizasyon_Eslesme_Mikarı + 1; }
                            if (i == 4)
                            { Hmı_Ürün_Cap_4_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_4_Vulkanizasyon_Eslesme_Mikarı + 1; }
                            if (i == 5)
                            { Hmı_Ürün_Cap_5_Vulkanizasyon_Eslesme_Mikarı = Hmı_Ürün_Cap_5_Vulkanizasyon_Eslesme_Mikarı + 1; }
                        }                 
                    }                 
                }               
            }
            int[] VALUESint1 = new int[1];          
            for (int A = 0; A < 6; A++)
            {
                if (A== 1)
                {  VALUESint1[0] = Hmı_Ürün_Cap_1_Vulkanizasyon_Eslesme_Mikarı;
                   Anasayfa.writeint(82, VALUESint1);}//db27 82   
                if (A == 2)
                {  VALUESint1[0] = Hmı_Ürün_Cap_2_Vulkanizasyon_Eslesme_Mikarı;
                   Anasayfa.writeint(84, VALUESint1);} //db27 84
                if (A == 3)
                {  VALUESint1[0] = Hmı_Ürün_Cap_3_Vulkanizasyon_Eslesme_Mikarı;
                   Anasayfa.writeint(86, VALUESint1);}//db27 86
                if (A == 4)
                { VALUESint1[0] = Hmı_Ürün_Cap_4_Vulkanizasyon_Eslesme_Mikarı;
                   Anasayfa.writeint(88, VALUESint1);} //db27 88
                if (A == 5)
                {VALUESint1[0] = Hmı_Ürün_Cap_5_Vulkanizasyon_Eslesme_Mikarı;
                   Anasayfa.writeint(90, VALUESint1);}//db27 90
            }

            textürüncap1.BackColor = Color.White;
            textürüncap2.BackColor = Color.White;
            textürüncap3.BackColor = Color.White;
            textürüncap4.BackColor = Color.White;

   
            if (textürüncap1.Text != "0" && textürünadet1.Text!="0")
            {
                if (textürüncap1.Text != textürüncap2.Text && textürüncap1.Text != textürüncap3.Text && textürüncap1.Text != textürüncap4.Text)
                    textürüncap1.BackColor = Color.Green;
                else
                    textürüncap1.BackColor = Color.Red;
            }
            if (textürüncap2.Text != "0")
            {
                if (textürüncap2.Text != textürüncap1.Text && textürüncap2.Text != textürüncap3.Text && textürüncap2.Text != textürüncap4.Text)
                    textürüncap2.BackColor = Color.Green;
                else
                    textürüncap2.BackColor = Color.Red;
            }
            if (textürüncap3.Text != "0")
            {
                if (textürüncap3.Text != textürüncap2.Text && textürüncap3.Text != textürüncap1.Text && textürüncap3.Text != textürüncap4.Text)
                    textürüncap3.BackColor = Color.Green;
                else
                    textürüncap3.BackColor = Color.Red;
            }
            if (textürüncap4.Text != "0")
            {
                if (textürüncap4.Text != textürüncap2.Text && textürüncap4.Text != textürüncap3.Text && textürüncap4.Text != textürüncap1.Text)
                    textürüncap4.BackColor = Color.Green;
                else
                    textürüncap4.BackColor = Color.Red;
            }
                    
            if (textVulkanizasyonCap1.Text != "0" )
            {   if (textVulkanizasyonCap1.Text == textRezervCap1.Text)
                    CheckRezervVulÇapKontrol1.BackColor = Color.Green;
                else if (textVulkanizasyonCap1.Text == textRezervCap2.Text)
                    CheckRezervVulÇapKontrol1.BackColor = Color.Green;
                else if (textVulkanizasyonCap1.Text == textRezervCap3.Text)
                    CheckRezervVulÇapKontrol1.BackColor = Color.Green;
                else if (textVulkanizasyonCap1.Text == textRezervCap4.Text)
                    CheckRezervVulÇapKontrol1.BackColor = Color.Green;
                else if (textVulkanizasyonCap1.Text == textRezervCap5.Text)
                    CheckRezervVulÇapKontrol1.BackColor = Color.Green;
                else
                    CheckRezervVulÇapKontrol1.BackColor = Color.Red; }
            else
            { CheckRezervVulÇapKontrol1.BackColor = Color.Red;}
            if (textVulkanizasyonCap2.Text != "0")
            {
                if (textVulkanizasyonCap2.Text == textRezervCap1.Text)
                    CheckRezervVulÇapKontrol2.BackColor = Color.Green;
                else if (textVulkanizasyonCap2.Text == textRezervCap2.Text)
                    CheckRezervVulÇapKontrol2.BackColor = Color.Green;
                else if (textVulkanizasyonCap2.Text == textRezervCap3.Text)
                    CheckRezervVulÇapKontrol2.BackColor = Color.Green;
                else if (textVulkanizasyonCap2.Text == textRezervCap4.Text)
                    CheckRezervVulÇapKontrol2.BackColor = Color.Green;
                else if (textVulkanizasyonCap2.Text == textRezervCap5.Text)
                    CheckRezervVulÇapKontrol2.BackColor = Color.Green;
                else
                    CheckRezervVulÇapKontrol2.BackColor = Color.Red;
            }
            else
            { CheckRezervVulÇapKontrol2.BackColor = Color.Red; }
            if (textVulkanizasyonCap3.Text != "0")
            {
                if (textVulkanizasyonCap3.Text == textRezervCap1.Text)
                    CheckRezervVulÇapKontrol3.BackColor = Color.Green;
                else if (textVulkanizasyonCap3.Text == textRezervCap2.Text)
                    CheckRezervVulÇapKontrol3.BackColor = Color.Green;
                else if (textVulkanizasyonCap3.Text == textRezervCap3.Text)
                    CheckRezervVulÇapKontrol3.BackColor = Color.Green;
                else if (textVulkanizasyonCap3.Text == textRezervCap4.Text)
                    CheckRezervVulÇapKontrol3.BackColor = Color.Green;
                else if (textVulkanizasyonCap3.Text == textRezervCap5.Text)
                    CheckRezervVulÇapKontrol3.BackColor = Color.Green;
                else
                    CheckRezervVulÇapKontrol3.BackColor = Color.Red;
            }
            else
            { CheckRezervVulÇapKontrol3.BackColor = Color.Red; }

            if (textVulkanizasyonCap4.Text != "0")
            {
                if (textVulkanizasyonCap4.Text == textRezervCap1.Text)
                    CheckRezervVulÇapKontrol4.BackColor = Color.Green;
                else if (textVulkanizasyonCap4.Text == textRezervCap2.Text)
                    CheckRezervVulÇapKontrol4.BackColor = Color.Green;
                else if (textVulkanizasyonCap4.Text == textRezervCap3.Text)
                    CheckRezervVulÇapKontrol4.BackColor = Color.Green;
                else if (textVulkanizasyonCap4.Text == textRezervCap4.Text)
                    CheckRezervVulÇapKontrol4.BackColor = Color.Green;
                else if (textVulkanizasyonCap4.Text == textRezervCap5.Text)
                    CheckRezervVulÇapKontrol4.BackColor = Color.Green;
                else
                    CheckRezervVulÇapKontrol4.BackColor = Color.Red;
            }
            else
            { CheckRezervVulÇapKontrol4.BackColor = Color.Red; }
        }
        private void btnRecete_Click(object sender, EventArgs e)
        {
            OtoRecete frm = new OtoRecete();
            frm.Show();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            int[] VALUESDint = new int[1];
            int[] VALUESint = new int[1];
            float[] VALUESReal = new float[1];

            // VALUESReal[1] =88;
            // VALUESReal[2] = 92;
            // int[] vals = new int[300];
            for (int i = 0; i < lstRecipe.Items.Count; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    if (j == 39)
                    {
                        //     vals[(i * 10) + (j)] = 0;                      
                    }
                    else
                    {
                        //string[] adres = (sender as DevExpress.XtraEditors.SimpleButton).Tag.ToString().Split('.');
                        //VALUESReal[j]= Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text);

                        //string[] str = (lstRecipe.Items[i].SubItems[j].Text.Split('.'));
                  
                         if (j == 2) { VALUESDint[0] = Convert.ToInt32(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writedint(44, VALUESDint); }         //28 db5 92
                        else if (j == 3) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(216, VALUESReal); }         //24 db5 96
                        else if (j == 4) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(296, VALUESReal); }         //25 db5 100
                        else if (j == 5) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(300, VALUESReal); }         //28 db5 112
                        else if (j == 6) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(304, VALUESReal); }         //29 db5 116
                        else if (j == 7) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(308, VALUESReal); }         //31 db5 124

                        else if (j == 8) { VALUESDint[0] = Convert.ToInt32(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writedint(48, VALUESDint); }         //30 db5 120
                        else if (j == 9) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(220, VALUESReal); }         //32 db5 128
                        else if (j == 10) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(396, VALUESReal); }        //44 db5 176
                        else if (j == 11) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(400, VALUESReal); }        //45 db5 180
                        else if (j == 12) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(408, VALUESReal); }        //46 db5 184
                        else if (j == 13) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(410, VALUESReal); }        //35 db5 140

                        else if (j == 14) { VALUESDint[0] = Convert.ToInt32(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writedint(52, VALUESDint); }        //36 db5 144
                        else if (j == 15) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(224, VALUESReal); }        //37 db5 148
                        else if (j == 16) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(404, VALUESReal); }        //40 db5 160
                        else if (j == 17) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(520, VALUESReal); }        //52 db5 208
                        else if (j == 18) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(416, VALUESReal); }        //53 db5 212
                        else if (j == 19) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(532, VALUESReal); }        //82 db5 328

                        else if (j == 20) { VALUESDint[0] = Convert.ToInt32(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writedint(56, VALUESDint); }        //84 db5 336
                        else if (j == 21) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(228, VALUESReal); }        //86 db5 344
                        else if (j == 22) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(524, VALUESReal); }        //88 db5 352                                                                                                                                                              
                        else if (j == 23) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(528, VALUESReal); }          //2 db28 8
                        else if (j == 24) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(536, VALUESReal); }          //4 db28 16
                        else if (j == 25) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(540, VALUESReal); }          //3 db28 12

                        else if (j == 26) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(380, VALUESReal); }          //0 db28 0
                        else if (j == 27) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(384, VALUESReal); }          //1 db28 4
                        else if (j == 28) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(388, VALUESReal);}        //52 db5  208 
                        else if (j == 29) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(342, VALUESReal); }            //10 db27 20
                        else if (j == 30) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(360, VALUESReal); }            //14 db27 28
                        else if (j == 31) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text);Anasayfa.writeReal(364, VALUESReal);}        //53 db5  212 
                        else if (j == 32) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(368, VALUESReal); }            //21 db27 42
                        else if (j == 33) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(372, VALUESReal); }            //25 db27 50
                        else if (j == 34) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(376, VALUESReal); }          //9 db28 36


                        else if (j == 35) { VALUESint[0] = Convert.ToInt16(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeint(82, VALUESint); }        // db5 544
                        else if (j == 36) { VALUESint[0] = Convert.ToInt16(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeint(84, VALUESint); }        // db5 544
                        else if (j == 37) { VALUESint[0] = Convert.ToInt16(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeint(86, VALUESint); }        // db5 552
                        else if (j == 38) { VALUESint[0] = Convert.ToInt16(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeint(88, VALUESint); }        // db5 560
                          
                       
                    }
                }
                    }
                }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstRecipe.Items.Count < 39)
                {
                    ListViewItem lstItem = new ListViewItem();
                    Convert.ToSingle(textsiparis.Text);
                    Convert.ToSingle(text1.Text);
                    Convert.ToSingle(text2.Text);
                    Convert.ToSingle(text3.Text);
                    Convert.ToSingle(text4.Text);
                    Convert.ToSingle(text5.Text);
                    Convert.ToSingle(text6.Text);
                    Convert.ToSingle(text7.Text);
                    Convert.ToSingle(text8.Text);
                    Convert.ToSingle(text9.Text);
                    Convert.ToSingle(text10.Text);
                    Convert.ToSingle(text11.Text);
                    Convert.ToSingle(text12.Text);
                    Convert.ToSingle(text13.Text);
                    Convert.ToSingle(text14.Text);
                    Convert.ToSingle(text15.Text);
                    Convert.ToSingle(text16.Text);
                    Convert.ToSingle(text17.Text);
                    Convert.ToSingle(text18.Text);
                    Convert.ToSingle(text19.Text);
                    Convert.ToSingle(text20.Text);
                    Convert.ToSingle(text21.Text);
                    Convert.ToSingle(text22.Text);
                    Convert.ToSingle(text23.Text);
                    Convert.ToSingle(text24.Text);
                    Convert.ToSingle(text25.Text);
                    Convert.ToSingle(text26.Text);
                    Convert.ToSingle(text27.Text);
                    Convert.ToSingle(text28.Text);
                    Convert.ToSingle(text29.Text);                          
                    Convert.ToSingle(text30.Text);                          
                    Convert.ToSingle(text31.Text);                          
                    Convert.ToSingle(text32.Text);                          
                    Convert.ToSingle(text33.Text);                          
                    Convert.ToSingle(text34.Text);                          
                    Convert.ToSingle(text35.Text);                          
                    Convert.ToSingle(text36.Text);                          
                    Convert.ToSingle(text37.Text);                          
                                                                                                                                                                                                                                                  

                    lstItem.Text = (lstRecipe.Items.Count + 1).ToString();
                    lstItem.SubItems.Add(textsiparis.Text);
                    lstItem.SubItems.Add(text1.Text);
                    lstItem.SubItems.Add(text2.Text);
                    lstItem.SubItems.Add(text3.Text);
                    lstItem.SubItems.Add(text4.Text);
                    lstItem.SubItems.Add(text5.Text);
                    lstItem.SubItems.Add(text6.Text);
                    lstItem.SubItems.Add(text7.Text);
                    lstItem.SubItems.Add(text8.Text);        
                    lstItem.SubItems.Add(text9.Text);
                    lstItem.SubItems.Add(text10.Text);
                    lstItem.SubItems.Add(text11.Text);
                    lstItem.SubItems.Add(text12.Text);
                    lstItem.SubItems.Add(text13.Text);
                    lstItem.SubItems.Add(text14.Text);
                    lstItem.SubItems.Add(text15.Text);
                    lstItem.SubItems.Add(text16.Text);
                    lstItem.SubItems.Add(text17.Text);
                    lstItem.SubItems.Add(text18.Text);
                    lstItem.SubItems.Add(text19.Text);
                    lstItem.SubItems.Add(text20.Text);
                    lstItem.SubItems.Add(text21.Text);
                    lstItem.SubItems.Add(text22.Text);
                    lstItem.SubItems.Add(text23.Text);
                    lstItem.SubItems.Add(text24.Text);
                    lstItem.SubItems.Add(text25.Text);
                    lstItem.SubItems.Add(text26.Text);
                    lstItem.SubItems.Add(text27.Text);
                    lstItem.SubItems.Add(text28.Text);
                    lstItem.SubItems.Add(text29.Text);
                    lstItem.SubItems.Add(text30.Text);
                    lstItem.SubItems.Add(text31.Text);
                    lstItem.SubItems.Add(text32.Text);
                    lstItem.SubItems.Add(text33.Text);
                    lstItem.SubItems.Add(text34.Text);
                    lstItem.SubItems.Add(text35.Text);
                    lstItem.SubItems.Add(text36.Text);
                    lstItem.SubItems.Add(text37.Text);      

                    lstRecipe.Items.Add(lstItem);
                }
                else
                {
                    MessageBox.Show("Maksimum 37 adımlık program yazılabilir!");
                }
            }
            catch
            {
                MessageBox.Show("Değerleri kontrol ediniz!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {             
                Convert.ToSingle(textsiparis.Text);
                Convert.ToSingle(text1.Text);
                Convert.ToSingle(text2.Text);
                Convert.ToSingle(text3.Text);
                Convert.ToSingle(text4.Text);
                Convert.ToSingle(text5.Text);
                Convert.ToSingle(text6.Text);
                Convert.ToSingle(text7.Text);
                Convert.ToSingle(text8.Text);
                Convert.ToSingle(text9.Text);
                Convert.ToSingle(text10.Text);
                Convert.ToSingle(text11.Text);
                Convert.ToSingle(text12.Text);
                Convert.ToSingle(text13.Text);
                Convert.ToSingle(text14.Text);
                Convert.ToSingle(text15.Text);
                Convert.ToSingle(text16.Text);
                Convert.ToSingle(text17.Text);
                Convert.ToSingle(text18.Text);
                Convert.ToSingle(text19.Text);
                Convert.ToSingle(text20.Text);
                Convert.ToSingle(text21.Text);
                Convert.ToSingle(text22.Text);
                Convert.ToSingle(text23.Text);
                Convert.ToSingle(text24.Text);
                Convert.ToSingle(text25.Text);
                Convert.ToSingle(text26.Text);
                Convert.ToSingle(text27.Text);
                Convert.ToSingle(text28.Text);
                Convert.ToSingle(text29.Text);
                Convert.ToSingle(text30.Text);
                Convert.ToSingle(text31.Text);
                Convert.ToSingle(text32.Text);
                Convert.ToSingle(text33.Text);
                Convert.ToSingle(text34.Text);
                Convert.ToSingle(text35.Text);
                Convert.ToSingle(text36.Text);
                Convert.ToSingle(text37.Text);


                try
                {
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[1].Text =  textsiparis.Text;       // db5 88
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[2].Text =  text1.Text;            // db5 92
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[3].Text =  text2.Text;           // db5 96
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[4].Text =  text3.Text;               // db5 100
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[5].Text =  text4.Text;        // db5 112
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[6].Text =  text5.Text;         // db5 116
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[7].Text =  text6.Text;       // db5 124
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[8].Text =  text7.Text;         // db5 120
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[9].Text =  text8.Text;        // db5 128
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[10].Text = text9.Text; // db5 176
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[11].Text = text10.Text;  // db5 180
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[12].Text = text11.Text;  // db5 184
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[13].Text = text12.Text;  // db5 140
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[14].Text = text13.Text;  // db5 144
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[15].Text = text14.Text;  // db5 148
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[16].Text = text15.Text;  // db5 160
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[17].Text = text16.Text;  // db5 208
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[18].Text = text17.Text;  // db5 212
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[19].Text = text18.Text;  // db5 328
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[20].Text = text19.Text;  // db5 336
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[21].Text = text20.Text;  // db5 344
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[22].Text = text21.Text;  // db5 352
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[23].Text = text22.Text;  // db28 8
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[24].Text = text23.Text;  // db28 16
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[25].Text = text24.Text;  // db28 12
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[26].Text = text25.Text;  // db28 0
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[27].Text = text26.Text;  // db28 4
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[28].Text = text27.Text;  // db5  184                     
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[29].Text = text28.Text;  // db27 20
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[30].Text = text29.Text;  // db27 28
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[31].Text = text30.Text;  // db5  184                      
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[32].Text = text31.Text;  // db27 42
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[33].Text = text32.Text;  // db27 50
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[34].Text = text33.Text;  // db28 36
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[35].Text = text34.Text;  // db28 40
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[36].Text = text35.Text;   // db5 544
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[37].Text = text36.Text;   // db5 552
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[38].Text = text37.Text;   // db5 560
  

                }
                catch
                {
                    MessageBox.Show("Bu ID ile çalışma bulunamadı!");
                }
            }
            catch
            {
                MessageBox.Show("Değerleri kontrol ediniz!");
            }
        }
        public void recipeOku(string recipeName)
        {
            lstRecipe.Items.Clear();
            string[,] receteDegerler = new string[30, 39];
            string[] yazi = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Recipe\\" + recipeName + ".sktp");
            string[] vals = new string[38];
            for (int i = 0; i < yazi.Length; i++)
            {
                vals = yazi[i].Split('$');
                for (int j = 0; j < 14; j++)
                {
                    receteDegerler[i, j] = vals[j];
                }
            }
            for (int i = 0; i < yazi.Length; i++)
            {
                ListViewItem lstItem = new ListViewItem();
                lstItem.Text = (receteDegerler[i, 0]).ToString();
                lstItem.SubItems.Add(receteDegerler[i, 1]);
                lstItem.SubItems.Add(receteDegerler[i, 2]);
                lstItem.SubItems.Add(receteDegerler[i, 3]);
                lstItem.SubItems.Add(receteDegerler[i, 4]);
                lstItem.SubItems.Add(receteDegerler[i, 5]);
                lstItem.SubItems.Add(receteDegerler[i, 6]);
                lstItem.SubItems.Add(receteDegerler[i, 7]);
                lstItem.SubItems.Add(receteDegerler[i, 8]);
                lstItem.SubItems.Add(receteDegerler[i, 9]);
                lstItem.SubItems.Add(receteDegerler[i, 10]);
                lstItem.SubItems.Add(receteDegerler[i, 11]);
                lstItem.SubItems.Add(receteDegerler[i, 12]);
                lstItem.SubItems.Add(receteDegerler[i, 13]);
                lstItem.SubItems.Add(receteDegerler[i, 14]);
                lstItem.SubItems.Add(receteDegerler[i, 15]);
                lstItem.SubItems.Add(receteDegerler[i, 16]);
                lstItem.SubItems.Add(receteDegerler[i, 17]);
                lstItem.SubItems.Add(receteDegerler[i, 18]);
                lstItem.SubItems.Add(receteDegerler[i, 19]);
                lstItem.SubItems.Add(receteDegerler[i, 20]);
                lstItem.SubItems.Add(receteDegerler[i, 21]);
                lstItem.SubItems.Add(receteDegerler[i, 22]);
                lstItem.SubItems.Add(receteDegerler[i, 23]);
                lstItem.SubItems.Add(receteDegerler[i, 24]);
                lstItem.SubItems.Add(receteDegerler[i, 25]);
                lstItem.SubItems.Add(receteDegerler[i, 26]);
                lstItem.SubItems.Add(receteDegerler[i, 27]);
                lstItem.SubItems.Add(receteDegerler[i, 28]);
                lstItem.SubItems.Add(receteDegerler[i, 29]);
                lstItem.SubItems.Add(receteDegerler[i, 30]);
                lstItem.SubItems.Add(receteDegerler[i, 31]);
                lstItem.SubItems.Add(receteDegerler[i, 32]);
                lstItem.SubItems.Add(receteDegerler[i, 33]);
                lstItem.SubItems.Add(receteDegerler[i, 34]);
                lstItem.SubItems.Add(receteDegerler[i, 35]);

                lstItem.SubItems.Add(receteDegerler[i, 36]);
                lstItem.SubItems.Add(receteDegerler[i, 37]);
                lstItem.SubItems.Add(receteDegerler[i, 38]);
     

                lstRecipe.Items.Add(lstItem);
            }
            txtRecipeName.Text = recipeName;
            Properties.Settings.Default.SON_SECILEN_RECETE = recipeName;
            Properties.Settings.Default.Save();

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                lstRecipe.SelectedItems[0].Remove();
                for (int i = 0; i < lstRecipe.Items.Count; i++)
                {
                    lstRecipe.Items[i].Text = (i + 1).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!");
            }
        }

        private void btnTumunuSil_Click(object sender, EventArgs e)
        {
            lstRecipe.Items.Clear();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] VALUESint1 = new int[1];
            VALUESint1[0] = 1;
            Anasayfa.writeint(8, VALUESint1); //db27 8  pistonlar hazır paletten al
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] VALUESint1 = new int[1];
            VALUESint1[0] = 1;
            Anasayfa.writeint(2, VALUESint1); //db27 2  pistonlar palete yüklendi
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}