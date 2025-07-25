using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Microsoft.CSharp;



namespace Yaris_Online_izleme_Programı
{
    public partial class u_manuel : UserControl
    {

        public string textstring1;
        public string textstring2;

        public static bool Hmı_Ust_Tabla_Serbest_Düsme_Valfi;
        public static bool Hmı_Sıyırma_Su_Giris_Vanası_Ac_Kapat_S;
        public static bool Hmı_Sıyırma_Hava_Giris_Vanası_Ac_Kapat_S;

        public static bool Hmı_Piston_Hareket_Sartı_VP;
        public static bool Hmı_Tutucu_Ac_Kapat_Sartları_VP;
        public static bool Hmı_Ust_Tabla_Giris_Hareket_Sartı_VP;
        public static bool Hmı_Ust_Tabla_Hareket_Sartı_VP;
        public static bool Hmı_Servo_Eksen_Hareket_Sartı_VP;
        public static bool Hmı_Servo_Eksen_Homing_Sartı_VP;
        public static bool Hmı_Servo_Eksen_Halt_VP;
        public static bool Hmı_Vulkanizasyon_Oto_Adım_Şartı;
        public static bool Hmı_Vulkanizasyon_Otomatik_Modda_Hareket_Şartı;
        public static bool Hmı_Servo_Eksen_Hareket_Sartı_Home_Degil_VP;
        public static bool Hmı_Ust_Tabla_Orta_Konum_Vakum_Sartı_VP;


        public static bool Hmı_Hata_Reset;
        public static bool Hmı_Otomatik_Proses_Adımları_Aktif_VP;
        public static bool Hmı_Proses_Adımlarını_Resetle_VP;
        public static bool Hmı_Boşaltma_Yap_VP;
        public static bool Hmı_Başlangıc_Sartları_Ok_VB;

        public static bool Hmı_Otomatik_Proses_Adımları_Aktif_S;
        public static bool Hmı_Başlangıc_Sartları_Ok_S;
        public static bool Hmı_Proses_Adımlarını_Resetle_S;
        public static bool Hmı_Kort_Bezi_Koparma_Adımlarını_Resetle_KBK;
        public static bool Hmı_Otomatik_Proses_Adımları_Aktif_KBK;
        public static bool Hmı_Başlangıc_Sartları_Ok_ABB;
        public static bool Hmı_Proses_Adımlarını_Resetle_Robot;


        public static bool Hmı_i_Orta_Piston_Geri_Sensör_VP;
        public static bool Hmı_i_Orta_Basınc_Salteri_Geri_VP;
        public static bool Hmı_i_Orta_Basınc_Salteri_ileri_VP;
        public static bool Hmı_i_Orta_Piston_ileri_Sensör;
        public static bool Hmı_i_Cıkıs_Basınc_Salteri_Geri_VP;
        public static bool Hmı_i_Cıkıs_Basınc_Salteri_ileri_VP;
        public static bool Hmı_i_Cıkıs_Alt_Piston_ileri_Sensör_VP;
        public static bool Hmı_i_Cıkıs_Alt_Piston_Geri_Sensör_VP;
        public static bool Hmı_i_Giris_Alt_Piston_ileri_Sensör_VP;
        public static bool Hmı_i_Giris_Alt_Piston_Geri_Sensör_VP;        
        public static bool Hmı_i_Giris_Basınc_Salteri_Geri_VP;
        public static bool Hmı_i_Giris_Basınc_Salteri_ileri_VP;
        public static bool Hmı_i_Tutucular_Basınc_Salteri_Acik_VP;
        public static bool Hmı_i_Tutucular_Basınc_Salteri_Kapalı_VP;
        public static bool Hmı_Servo_Home_Yapıldı_VP;

        public static bool Hmı_i_Balata_Piston_Acık_Sensör_KBK;
        public static bool Hmı_i_Balata_Piston_Kapalı_Sensör_KBK;
        public static bool Hmı_i_Tambur_Tutucu_Silindir_1_Geri_Sensör_KBK;
        public static bool Hmı_i_Tambur_Tutucu_Silindir_2_Geri_Sensör_KBK;
        public static bool Hmı_Ust_Baskı_Silindir_1_Geri_Sensör_KBK;
        public static bool Hmı_Ust_Baskı_Silindir_2_Geri_Sensör_KBK;

        public static bool Hmı_i_Kesme_ileri_Sensör_KK;
        public static bool Hmı_i_Kesme_Geri_Sensör_KK;

        public static bool Hmı_i_Tutucu_1_Kapalı_Sensör_S;
        public static bool Hmı_i_Tutucu_2_Kapalı_Sensör_S;
        public static bool Hmı_i_Tutucu_3_Kapalı_Sensör_S;
        public static bool Hmı_i_Tutucu_4_Kapalı_Sensör_S;
        public static bool Hmı_i_Ust_Limit_Sivic_S;
        public static bool Hmı_i_Sıyırma_Orta_Konum_Sivic_S;
        public static bool Hmı_i_Alt_Limit_Sivic_S;
        public static bool Hmı_i_Sıyırıcı_Kapak_ic_Yukarı_Limit_S;
        public static bool Hmı_i_Sıyırıcı_Kapak_ic_Asagı_Limit_S;
        public static bool Hmı_i_Sıyırıcı_Kapak_Dıs_Yukarı_Limit_S;        
        public static bool Hmı_i_Sıyırıcı_Kapak_Dıs_Asagı_Limit_S;
        public static bool Hmı_i_Sıyırma_Üst_Tabla_Basınc_Salteri_S;
        public static bool Hmı_i_Malafa_Var_Yok_Sensör_1_S;
        public static bool Hmı_i_Malafa_Var_Yok_Sensör_2_S;
        public static bool Hmı_i_Malafa_Var_Yok_Sensör_3_S;
        public static bool Hmı_i_Malafa_Var_Yok_Sensör_4_S;

        public static bool Hmı_i_Robot_Tutucu_Açık_Sensör_ABB;
        public static bool Hmı_i_Robot_Tutucu_Kapalı_Sensör_ABB;
        public static bool Hmı_i_Robot_Tutucu_Basınc_Acık_ABB;
        public static bool Hmı_i_Robot_Tutucu_Basınc_Kapalı_ABB;     

        public static bool Hmı_Otomatik_Aktif;
        public static bool Hmı_Manuel_Aktif;
        public static bool Hmı_Haberleşme_Ok;

        public static bool Hmı_Tüm_İstasyonları_Devreye_Al;
        public static bool Hmı_Vulkanizasyon_Devreye_Al;
        public static bool Hmı_Kaucuk_Kesme_Devreye_Al;
        public static bool Hmı_Kort_Bezi_Koparma_Devreye_Al;
        public static bool Hmı_Sıyırma_Sogutma_Devreye_Al;
        public static bool Hmı_Standart_Parametreleri_Yükle;
        public static bool Hmı_Tüm_İstasyonları_Devreden_Cıkar;
        public static bool Hmı_Vulkanizasyon_Devreden_Cıkar;
        public static bool Hmı_Kaucuk_Kesme_Devreden_Cıkar;
        public static bool Hmı_Kort_Bezi_Koparma_Devreden_Cıkar;
        public static bool Hmı_Sıyırma_Sogutma_Devreden_Cıkar;
        public static bool Hmı_Robot_Devreye_Al;
        public static bool Hmı_Robot_Devreden_Cıkar;
        public static bool Hmı_Sarma_Devreye_Al;
        public static bool Hmı_Sarma_Devreden_Cıkar;

        public static bool Hmı_Robot_Tutucu_Ac_ABB;
        public static bool Hmı_Robot_Tutucu_Kapat_ABB;

        public static bool Hmı_Giris_Piston_ileri_VP;
        public static bool Hmı_Giris_Piston_Geri_VP;
        public static bool Hmı_Orta_Piston_ileri_VP;
        public static bool Hmı_Orta_Piston_Geri_VP;
        public static bool Hmı_Cıkıs_Piston_ileri_VP;
        public static bool Hmı_Cıkıs_Piston_Geri_VP;
        public static bool Hmı_Tutucu_Ac_VP;
        public static bool Hmı_Tutucu_Kapat_VP;
        public static bool Hmı_Ust_Tabla_Asagı_VP;
        public static bool Hmı_Ust_Tabla_Yukarı_VP;
        public static bool Hmı_Servo_Eksen_Jog_ileri_VP;
        public static bool Hmı_Servo_Eksen_Jog_Geri_VP;
        public static bool Hmı_Servo_Homing1_Pos_Git_VP;
        public static bool Hmı_Servo_Homing2_Pos_Git_VP;
        public static bool Hmı_Servo_Man_Abs_Git_VP;
        public static bool Hmı_Servo_Man_Abs_Giriş_Pozisyonuna_Git_VP;
        public static bool Hmı_Servo_Man_Abs_Orta_Pozisyonuna_Git_VP;
        public static bool Hmı_Servo_Man_Abs_Cikis_Pozisyonuna_Git_VP;

        public static float Hmı_ÜstTablaAnlıkYükseklik_VP;
        public static float Hmı_ServoAnlıkPozisyon_VP;
        public static float Hmı_Oransal_Ana_Basınc_Aktüel_VP;
        public static float Analog_Cap_Sensör_Aktüel_Deger;
        public static int Hmı_StepNo_Oto_Program_VP;
        public static int Hmı_StepNo_Oto_Program_KK;
        public static int Hmı_StepNo_Oto_Program_KBK;
        public static int Hmı_StepNo_Oto_Program_S;
        public static int Hmı_Vulkanizasyonda_Malafa_Var_Yok_Referans;
        public static Int32 Hmı_Step_No_Tüm_İstasyonlar;
        public static Int32 Hmı_Step_No_Robot;
        public static int Hmı_Malafa_Boşaltma_Yapılmalı_VP;


       public static bool MAN_MALAFA_TUTUCU_ILERI                ;
       public static bool  MAN_MALAFA_TUTUCU_GERI                 ;
       public static bool MAN_PUNTA_SABITLEME_PISTON_ILERI       ;
       public static bool MAN_PUNTA_SABITLEME_PISTON_GERI        ;
       public static bool HATA_RESET                             ;
       public static bool S1_TASIYICI_MANUEL_ILERI               ;
       public static bool S1_TASIYICI_MANUEL_GERI                ;
       public static bool S2_DONDURME_MANUEL_ILERI               ;
       public static bool S2_DONDURME_MANUEL_GERI                ;
       public static bool S3_YUKSELTME_IC_MANUEL_ILERI           ;
       public static bool S3_YUKSELTME_IC_MANUEL_GERI            ;
       public static bool S4_YUKSELTME_DIS_MANUEL_ILERI          ;
       public static bool S4_YUKSELTME_DIS_MANUEL_GERI           ;
       public static bool S5_LAZER_MANUEL_ILERI                  ;
       public static bool S5_LAZER_MANUEL_GERI                   ;
       public static bool SARMA_OTOMATİK_MOD                     ;
       public static bool SARMA_DEVREYE_AL                       ;
       public static bool S7_Blink                               ;
       public static bool SARMA_BASLANGIC_OK                    ;
       public static bool SARMA_DEVREDE;


       public static float S1_TASIYICI_MANUEL_HIZ;
       public static float S2_DONDURME_MANUEL_HIZ;
       public static   float S3_YUKSELTME_IC_MANUEL_HIZ;
       public static   float S4_YUKSELTME_DIS_MANUEL_HIZ;
       public static   float S5_LAZER_MANUEL_HIZ;


        public static float S1_TASIYICI_BASLANGIC_POZISYONU_ACTUEL;
        public static float S2_DONDURME_BASLANGIC_POZISYONU_ACTUEL;
        public static float S3_YUKSELTME_IC_BASLANGIC_POZISYONU_ACTUEL;
        public static float S4_YUKSELTME_DIS_BASLANGIC_POZISYONU_ACTUEL;
        public static float S5_LAZER_BASLANGIC_POZISYONU_ACTUEL;
       




        public static Int32 Hmı_1_Tahliye_Süresi_Aktüel_VP;
        public static Int32 Hmı_Buhar_Süresi_Aktüel_VP;
        public static Int32 Hmı_2_Tahliye_Süresi_Aktüel_VP;
        public static Int32 Hmı_Vakum_Süresi_Aktüel_VP;
        public static Int32 Hmı_Sıyırma_Sogutma_Suyu_Süresi_Aktüel_S;
        public static Int32 Hmı_Sıyırma_Sogutma_Hava_Süresi_Aktüel_S;


        //parametreler float  
        public static float Hmı_Ust_Tabla_Giriş_Asagı_Set_Pozisyon_VP;
        public static float Hmı_Ust_Tabla_Orta_Asagı_Set_Pozisyon_VP;
        public static float Hmı_Ust_Tabla_Cikis_Asagı_Set_Pozisyon_VP;
        public static float Hmı_Ust_Tabla_Yukarı_Set_Pozisyon_VP;
        public static float Hmı_Ust_Tabla_Oto_Kalkıs_Rampası_VP;
        public static float Hmı_Ust_Tabla_Oto_Durus_Rampası_VP;
        public static float Hmı_Ust_Tabla_Orta_Asagı_Basınc_Set_Degeri_Gir_VP;
        public static float Hmı_Ust_Tabla_Giris_Asagı_Basınc_Set_Degeri_Gir_VP;
        public static float Hmı_Ust_Tabla_Cikis_Asagı_Basınc_Set_Degeri_Gir_VP;
        public static float Hmı_Servo_Oto_Abs_Giris_Poz_Set_VP;
        public static float Hmı_Servo_Oto_Abs_Orta_Poz_Set_VP;
        public static float Hmı_Servo_Oto_Abs_Cikis_Poz_Set_VP;
        public static float Hmı_Servo_Oto_Hiz_Degeri_Gir_VP;
        public static float Hmı_Ust_Tabla_Oto_Max_Hız_Gir;
        public static float Hmı_Ust_Tabla_Oto_Min_Durus_Hız_Gir;
        public static float Hmı_Ust_Tabla_Oto_Min_Kalkıs_Hız_Gir;
        public static float Hmı_Giris_Tutucu_Malafa_Alamadı_Mesafesi;
        public static float Hmı_Cikis_Tutucu_Malafa_Bırakamadı_Mesafesi;

        public static float Hmı_Giris_Alt_Piston_Set_Hiz_VP;   
        public static float Hmı_Orta_Alt_Piston_Set_Hiz_VP;
        public static float Hmı_Cikis_Alt_Piston_Set_Hiz_VP;
        public static float Hmı_Tutucu_Set_Hiz_VP;
        public static float Hmı_Alt_Piston_Giris_Geri_Oransal_Hız;
        public static float Hmı_Alt_Piston_Orta_Geri_Oransal_Hız;
        public static float Hmı_Alt_Piston_Cikis_Geri_Oransal_Hız;
        public static float Hmı_Tutucu_Ac_Oransal_Hız;
        //dint parametre
        public static Int32 Hmı_1_Tahliye_Süresi_VP;
        public static Int32 Hmı_2_Tahliye_Süresi_VP;
        public static Int32 Hmı_Buhar_Süresi_VP;
        public static Int32 Hmı_Buhar_Azot_Süresi_VP;
        public static Int32 Hmı_Vakum_Süresi_VP;
        public static Int32 Hmı_Sıyırma_Sogutma_Suyu_Süresi_S;
        public static Int32 Hmı_Sıyırma_Sogutma_Hava_Süresi_S;
        //int parametre
        public static int Hmı_Kaucuk_Kesme_Pozisyon_Motoru_Hız_Gir_KK;
        public static int Hmı_Kaucuk_Kesme_Toplama_Motoru_Hız_Gir_KK;
        public static int Hmı_Kort_Bezi_Koparma_Pozisyon_Motoru_Hız_Gir_KBK;
        public static int Hmı_Kort_Bezi_Koparma_Toplama_Motoru_Hız_Gir_KBK;

        public static int Hmı_Tüm_istasyonları_Devrede;
        public static int Hmı_Vulkanizasyon_Devrede;
        public static int Hmı_Kaucuk_Kesme_Devrede;
        public static int Hmı_Kort_Bezi_Koparma_Devrede;
        public static int Hmı_Sıyırma_Sogutma_Devrede;
        public static int Hmı_Robot_Devrede;
        public static int Hmı_Sarma_Alarm_int;


        public static int Hmı_Pistonlar_Palete_Yüklendi_Start_VP;
        public static int Hmı_Pistonlar_Paletten_Alındı_VP;



        public u_manuel()
        {
            InitializeComponent();          
        }

        private void BtnSartClick(object sender, EventArgs e)
        {   
            if (Hmı_Vulkanizasyon_Oto_Adım_Şartı == true)
            { MessageBox.Show("Manuel Hareketler için otomatik adımları resetleyiniz");}
            if (Hmı_Vulkanizasyon_Otomatik_Modda_Hareket_Şartı == true)
            { MessageBox.Show("Manuel Hareketler için Sistem Manuel Modda Olmalıdır");}     
        }
        private void timerkontrol_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Anasayfa.actPage == "u_manuel")
                {
                    if (tabControl1.SelectedIndex == 0)
                    {
                        digitalGauge7.Text = Math.Round(Anasayfa.readFloat[0], 3).ToString(); //data block 5 byte 0.0 Malafa_Buhar_1_Göz
                        digitalGauge26.Text = Math.Round(Anasayfa.readFloat[1], 3).ToString();        //data block 5 byte 4.0 Torba_Buhar_1_Göz_VP
                        digitalGauge27.Text = Math.Round(Anasayfa.readFloat[2], 3).ToString();       //data block 5 byte 8.0 Malafa_Buhar_2_Göz_VP
                        digitalGauge28.Text = Math.Round(Anasayfa.readFloat[3], 3).ToString();        //data block 5 byte 12.0 Torba_Buhar_2_Göz_VP
                        digitalGauge30.Text = Math.Round(Anasayfa.readFloat[4], 3).ToString();       //data block 5 byte 16.0 Malafa_Buhar_3_Göz_VP
                        digitalGauge29.Text = Math.Round(Anasayfa.readFloat[5], 3).ToString();        //data block 5 byte 20.0 Torba_Buhar_3_Göz_VP
                        digitalGauge32.Text = Math.Round(Anasayfa.readFloat[6], 3).ToString();       //data block 5 byte 24.0 Malafa_Buhar_4_Göz_VP
                        digitalGauge31.Text = Math.Round(Anasayfa.readFloat[7], 3).ToString();        //data block 5 byte 28.0 Torba_Buhar_4_Göz_VP
                        Hmı_ÜstTablaAnlıkYükseklik_VP = Anasayfa.readFloat[8];               //data block 5 byte 32.0 ÜstTablaAnlıkYükseklik_VP
                        digitalGauge14.Text = Math.Round(Hmı_ÜstTablaAnlıkYükseklik_VP, 3).ToString();
                        digitalGauge18.Text = Math.Round(Anasayfa.readFloat[9], 3).ToString();     //data block 5 byte 36.0   ÜstTablaAnlıkBasınıc_VP
                        digitalGauge37.Text = Math.Round(Anasayfa.readFloat[10], 3).ToString();             //data block 5 byte 40.0 Ortak_Vakum_VP
                        digitalGauge36.Text = Math.Round(Anasayfa.readFloat[11], 3).ToString();      //data block 5 byte 44.0 Torba_Basınc_1_Göz_VP
                        digitalGauge35.Text = Math.Round(Anasayfa.readFloat[12], 3).ToString();      //data block 5 byte 48.0 Torba_Basınc_2_Göz_VP
                        digitalGauge9.Text = Math.Round(Anasayfa.readFloat[13], 3).ToString();      //data block 5 byte 52.0 Torba_Basınc_3_Göz_VP
                        digitalGauge33.Text = Math.Round(Anasayfa.readFloat[14], 3).ToString();      //data block 5 byte 56.0 Torba_Basınc_4_Göz_VP 

                    }
                }
                Analog_Cap_Sensör_Aktüel_Deger = Anasayfa.readFloat[15];       //data block 5 byte 60.0 analog cap sensör              
                digitalGauge13.Text = Math.Round(Analog_Cap_Sensör_Aktüel_Deger, 3).ToString();
                digitalGauge40.Text = Math.Round(Anasayfa.readFloat[16], 3).ToString();//data block 5 byte 64.0 Sıyırma_Üst_Piston_Anlık_Basınc_SS
                                                                                       // Rezerve_AI_1_Aktüel_Deger          = Anasayfa.readFloat[17].ToString();      //data block 5 byte 68.0
                                                                                       // Rezerve_AI_2_Aktüel_Deger          = Anasayfa.readFloat[18].ToString();      //data block 5 byte 72.0
                                                                                       //  Rezerve_AI_3_Aktüel_Deger          = Anasayfa.readFloat[19].ToString();     //data block 5 byte 76.0
                                                                                       //  Rezerve_AO_Set_Deger              = Anasayfa.readFloat[20].ToString();      //data block 5 byte 80.0
                                                                                       //  Debi_Oransal_Set_Deger_VP          = Anasayfa.readFloat[21].ToString();     //data block 5 byte 84.0
                if (Anasayfa.actPage == "u_manuel")
                {
                    if (tabControl1.SelectedIndex == 0)
                    {
                        Hmı_Ust_Tabla_Giriş_Asagı_Set_Pozisyon_VP = Anasayfa.readFloat[22];     //data block 5 byte 88.0
                        Hmı_Ust_Tabla_Orta_Asagı_Set_Pozisyon_VP = Anasayfa.readFloat[23];      //data block 5 byte 92.0
                        Hmı_Ust_Tabla_Cikis_Asagı_Set_Pozisyon_VP = Anasayfa.readFloat[24];     //data block 5 byte 96.0
                        Hmı_Ust_Tabla_Yukarı_Set_Pozisyon_VP = Anasayfa.readFloat[25];          //data block 5 byte 100.0
                        float Hmı_Ust_Tabla_Man_Kalkıs_Süresi_VP = Anasayfa.readFloat[26];      //data block 5 byte 104.0
                        float Hmı_Ust_Tabla_Man_Durus_Süresi_VP = Anasayfa.readFloat[27];       //data block 5 byte 108.0
                        Hmı_Ust_Tabla_Oto_Kalkıs_Rampası_VP = Anasayfa.readFloat[28];           //data block 5 byte 112.0
                        Hmı_Ust_Tabla_Oto_Durus_Rampası_VP = Anasayfa.readFloat[29];            //data block 5 byte 116.0
                        Hmı_Ust_Tabla_Orta_Asagı_Basınc_Set_Degeri_Gir_VP = Anasayfa.readFloat[30];      //data block 5 byte 120.0
                        Hmı_Ust_Tabla_Giris_Asagı_Basınc_Set_Degeri_Gir_VP = Anasayfa.readFloat[31];     //data block 5 byte 124.0
                        Hmı_Ust_Tabla_Cikis_Asagı_Basınc_Set_Degeri_Gir_VP = Anasayfa.readFloat[32];     //data block 5 byte 128.0
                        float Hmı_Ust_Tabla_Yukarı_Basınc_Set_Degeri_Gir_VP = Anasayfa.readFloat[33];    //data block 5 byte 132.0
                        txt_Servo_Man_Abs_Poz_Degeri_Gir_VP.Text = Anasayfa.readFloat[34].ToString();//data block 5 byte 136.0
                        Hmı_Servo_Oto_Abs_Giris_Poz_Set_VP = Anasayfa.readFloat[35];     //data block 5 byte 140.0
                        Hmı_Servo_Oto_Abs_Orta_Poz_Set_VP = Anasayfa.readFloat[36];      //data block 5 byte 144.0
                        Hmı_Servo_Oto_Abs_Cikis_Poz_Set_VP = Anasayfa.readFloat[37];     //data block 5 byte 148.0
                        float Hmı_Servo_Relative_Poz_Degeri_Gir_VP = Anasayfa.readFloat[38];       //data block 5 byte 152.0
                        txt_Servo_Man_Hiz_Degeri_Gir_VP.Text = Anasayfa.readFloat[39].ToString();  //data block 5 byte 156.0
                        Hmı_Servo_Oto_Hiz_Degeri_Gir_VP = Anasayfa.readFloat[40];                  //data block 5 byte 160.0
                        Hmı_ServoAnlıkPozisyon_VP = Anasayfa.readFloat[41];     //data block 5 byte 164.0   ServoAnlıkPozisyon_VP
                        digitalGauge6.Text = Math.Round(Hmı_ServoAnlıkPozisyon_VP, 3).ToString();
                        float Hmı_Servo_Anlik_Devir_VP = Anasayfa.readFloat[42];                //data block 5 byte 168.0
                        float Hmı_Alt_Silindir_ileri_Basınç_Gir_VP = Anasayfa.readFloat[43];                //data block 5 byte 172.0
                        float Hmı_Alt_Silindir_Geri_Basınç_Gir_VP = Anasayfa.readFloat[44];                //data block 5 byte 176.0
                        Hmı_Oransal_Ana_Basınc_Aktüel_VP = Anasayfa.readFloat[45];                //data block 5 byte 180.0
                        digitalGauge1.Text = Math.Round(Hmı_Oransal_Ana_Basınc_Aktüel_VP, 3).ToString();
                        digitalGauge8.Text = Math.Round(Hmı_Oransal_Ana_Basınc_Aktüel_VP, 3).ToString();
                        digitalGauge10.Text = Math.Round(Hmı_Oransal_Ana_Basınc_Aktüel_VP, 3).ToString();
                        digitalGauge12.Text = Math.Round(Hmı_Oransal_Ana_Basınc_Aktüel_VP, 3).ToString();
                    }

                }

                float Hmı_Kaucuk_Kesme_Yavaslama_Mesafesi_Gir_KK = Anasayfa.readFloat[46];                //data block 5 byte 184.0
                textBox1.Text = Hmı_Kaucuk_Kesme_Yavaslama_Mesafesi_Gir_KK.ToString();

                float Hmı_Kort_Bezi_Koparma_Yavaslama_Mesafesi_Gir_KBK = Anasayfa.readFloat[47];                //data block 5 byte 188.0
                textBox2.Text = Hmı_Kort_Bezi_Koparma_Yavaslama_Mesafesi_Gir_KBK.ToString();

                if (Anasayfa.actPage == "u_manuel")
                {
                    if (tabControl1.SelectedIndex == 0)
                    {

                        txt_Ust_Tabla_Man_Max_Hiz_Degeri_Gir_VP.Text = Anasayfa.readFloat[48].ToString();     //data block 5 byte 192.0
                        Hmı_Ust_Tabla_Oto_Max_Hız_Gir = Anasayfa.readFloat[49];                //data block 5 byte 196.0
                        Hmı_Ust_Tabla_Oto_Min_Durus_Hız_Gir = Anasayfa.readFloat[50];                //data block 5 byte 200.0
                        Hmı_Ust_Tabla_Oto_Min_Kalkıs_Hız_Gir = Anasayfa.readFloat[51];                //data block 5 byte 204.0
                        Hmı_Giris_Tutucu_Malafa_Alamadı_Mesafesi = Anasayfa.readFloat[52];                //data block 5 byte 208.0
                        Hmı_Cikis_Tutucu_Malafa_Bırakamadı_Mesafesi = Anasayfa.readFloat[53];                //data block 5 byte 212.0           
                        Hmı_Giris_Alt_Piston_Set_Hiz_VP = Anasayfa.readFloat[82];  //data block 5 byte 328.0
                        txt_Giris_Alt_Piston_Set_Hiz_VP.Text = Hmı_Giris_Alt_Piston_Set_Hiz_VP.ToString();
                        Hmı_Alt_Piston_Giris_Geri_Oransal_Hız = Anasayfa.readFloat[83]; //data block 5 byte 332.0
                        txt_Giris_Alt_Piston_Geri_Set_Hiz_VP.Text = Hmı_Alt_Piston_Giris_Geri_Oransal_Hız.ToString();
                        Hmı_Orta_Alt_Piston_Set_Hiz_VP = Anasayfa.readFloat[84];  //data block 5 byte 336.0
                        txt_Orta_Alt_Piston_Set_Hiz_VP.Text = Hmı_Orta_Alt_Piston_Set_Hiz_VP.ToString();
                        Hmı_Alt_Piston_Orta_Geri_Oransal_Hız = Anasayfa.readFloat[85];//data block 5 byte 340.0
                        txt_Orta_Alt_Piston_Geri_Set_Hiz_VP.Text = Hmı_Alt_Piston_Orta_Geri_Oransal_Hız.ToString();
                        Hmı_Cikis_Alt_Piston_Set_Hiz_VP = Anasayfa.readFloat[86];  //data block 5 byte 344.0
                        txt_CiKis_Alt_Piston_Set_Hiz_VP.Text = Hmı_Cikis_Alt_Piston_Set_Hiz_VP.ToString();
                        Hmı_Alt_Piston_Cikis_Geri_Oransal_Hız = Anasayfa.readFloat[87];//data block 5 byte 348.0
                        txt_CiKis_Alt_Piston_Geri_Set_Hiz_VP.Text = Hmı_Alt_Piston_Cikis_Geri_Oransal_Hız.ToString();
                        Hmı_Tutucu_Set_Hiz_VP = Anasayfa.readFloat[88]; //data block 5 byte 352.0
                        txt_Tutucu_Set_Hiz_VP.Text = Hmı_Tutucu_Set_Hiz_VP.ToString();
                        Hmı_Tutucu_Ac_Oransal_Hız = Anasayfa.readFloat[89];//data block 5 byte 356.0
                        txt_Tutucu_Ac_Set_Hiz_VP.Text = Hmı_Tutucu_Ac_Oransal_Hız.ToString();
                    }
                }
                //
                //    if (tabControl1.SelectedIndex == 1)
                //    {
                digitalGauge71.Text = Math.Round(Anasayfa.readFloat[168], 3).ToString();      //data block 5 byte 672.0 S1_TASIYICI_BASLANGIC_POZISYONU_ACTUEL      
                digitalGauge66.Text = Math.Round(Anasayfa.readFloat[169], 3).ToString();      //data block 5 byte 676.0 S2_DONDURME_BASLANGIC_POZISYONU_ACTUEL      
                digitalGauge69.Text = Math.Round(Anasayfa.readFloat[170], 3).ToString();      //data block 5 byte 680.0 S3_YUKSELTME_IC_BASLANGIC_POZISYONU_ACTUEL  
                digitalGauge78.Text = Math.Round(Anasayfa.readFloat[171], 3).ToString();      //data block 5 byte 684.0 S4_YUKSELTME_DIS_BASLANGIC_POZISYONU_ACTUEL 
                digitalGauge74.Text = Math.Round(Anasayfa.readFloat[172], 3).ToString();      //data block 5 byte 688.0 S5_LAZER_BASLANGIC_POZISYONU_ACTUEL         

                S1_TASIYICI_MANUEL_HIZ = Anasayfa.readFloat[137];//data block 5 byte 548.0
                S2_DONDURME_MANUEL_HIZ = Anasayfa.readFloat[139];//data block 5 byte 556.0
                S3_YUKSELTME_IC_MANUEL_HIZ = Anasayfa.readFloat[141];//data block 5 byte 564.0
                S4_YUKSELTME_DIS_MANUEL_HIZ = Anasayfa.readFloat[143];//data block 5 byte 572.0
                S5_LAZER_MANUEL_HIZ = Anasayfa.readFloat[145];//data block 5 byte 580.0
                                                              //    }
                if (Anasayfa.actPage == "u_manuel")
                {
                    if (tabControl1.SelectedIndex == 0)
                    {
                        bool Hmı_Hidrolik_Motor_Stop_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[0], 0); //data block 3 bit 0.0  1
                        Hmı_Giris_Piston_ileri_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[0], 1); //data block 3 bit 0.1  2
                        Hmı_Giris_Piston_Geri_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[0], 2); //data block 3 bit 0.2  3
                        Hmı_Orta_Piston_ileri_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[0], 3); //data block 3 bit 0.3  4
                        Hmı_Orta_Piston_Geri_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[0], 4); //data block 3 bit 0.4  5
                        Hmı_Cıkıs_Piston_ileri_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[0], 5); //data block 3 bit 0.5  6
                        Hmı_Cıkıs_Piston_Geri_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[0], 6); //data block 3 bit 0.6  7
                        Hmı_Tutucu_Ac_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[0], 7); //data block 3 bit 0.7  8
                        Hmı_Tutucu_Kapat_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[1], 0); //data block 3 bit 1.0  9
                        Hmı_Ust_Tabla_Asagı_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[1], 1); //data block 3 bit 1.1  10
                        Hmı_Ust_Tabla_Yukarı_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[1], 2); //data block 3 bit 1.2  11
                        bool Hmı_Ust_Tabla_Pozisyon_Ok_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[1], 3); //data block 3 bit 1.3  12
                        bool Hmı_Servo_Eksen_Enable_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[1], 4); //data block 3 bit 1.4  13
                        Hmı_Servo_Eksen_Jog_ileri_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[1], 5); //data block 3 bit 1.5  14
                        Hmı_Servo_Eksen_Jog_Geri_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[1], 6); //data block 3 bit 1.6  15
                        Hmı_Servo_Homing1_Pos_Git_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[1], 7); //data block 3 bit 1.7  16
                        Hmı_Servo_Homing2_Pos_Git_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[2], 0); //data block 3 bit 2.0  17
                        Hmı_Servo_Man_Abs_Git_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[2], 1); //data block 3 bit 2.1  18
                        bool Hmı_Servo_Relative_Pos_Git_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[2], 2); //data block 3 bit 2.2  19
                        Hmı_Servo_Eksen_Halt_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[2], 3); //data block 3 bit 2.3  20
                        bool Hmı_Servo_Hedef_Pozisyona_Ulasti_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[2], 4); //data block 3 bit 2.4  21
                    }
                }

                Hmı_Servo_Home_Yapıldı_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[2], 5); //data block 3 bit 2.5  22
                bool Hmı_Man_Oto_Mod = Anasayfa.getBitStateByte(Anasayfa.readBool[2], 6); //data block 3 bit 2.6  23           
                Hmı_Hata_Reset = Anasayfa.getBitStateByte(Anasayfa.readBool[3], 0);        //data block 3 bit 3.0   25
                Hmı_Otomatik_Proses_Adımları_Aktif_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[3], 1);        //data block 3 bit 3.1   26
                Hmı_Proses_Adımlarını_Resetle_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[3], 2);        //data block 3 bit 3.2   27
                Hmı_Boşaltma_Yap_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[3], 3);        //data block 3 bit 3.3   28
                bool Hmı_Torba_Buhar_On_Off_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[3], 4);        //data block 3 bit 3.4   29                                                                                       
                Hmı_Piston_Hareket_Sartı_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[3], 5);        //data block 3 bit 3.5   30
                Hmı_Tutucu_Ac_Kapat_Sartları_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[3], 6);        //data block 3 bit 3.6   31
                Hmı_Ust_Tabla_Giris_Hareket_Sartı_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[3], 7);        //data block 3 bit 3.7   32
                Hmı_Ust_Tabla_Hareket_Sartı_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[4], 0);        //data block 3 bit 4.0   33
                Hmı_Servo_Eksen_Hareket_Sartı_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[4], 1);        //data block 3 bit 4.1   34
                Hmı_Servo_Eksen_Homing_Sartı_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[4], 2);        //data block 3 bit 4.2   35
                bool Hmı_Kesme_Piston_ileri_KK = Anasayfa.getBitStateByte(Anasayfa.readBool[9], 4);           //db3  9.4   77
                bool Hmı_Kesme_Piston_Geri_KK = Anasayfa.getBitStateByte(Anasayfa.readBool[9], 5);           //db3  9.5   78
                bool Hmı_Kaucuk_Kesme_Adımlarını_Resetle_KK = Anasayfa.getBitStateByte(Anasayfa.readBool[9], 6);          ///db3  9.6   79
                bool Hmı_Otomatik_Proses_Adımları_Aktif_KK = Anasayfa.getBitStateByte(Anasayfa.readBool[9], 7);           //db3  9.7   80
                bool Hmı_Pozisyon_Motor_Manuel_ileri_KK = Anasayfa.getBitStateByte(Anasayfa.readBool[10], 7);           //db3  10.0  81
                bool Hmı_Pozisyon_Motor_Manuel_Geri_KK = Anasayfa.getBitStateByte(Anasayfa.readBool[10], 0);           //db3  10.1  82
                bool Hmı_Toplama_Motor_Manuel_ileri_KK = Anasayfa.getBitStateByte(Anasayfa.readBool[10], 1);           //db3  10.2  83
                bool Hmı_Toplama_Motor_Manuel_Geri_KK = Anasayfa.getBitStateByte(Anasayfa.readBool[10], 2);           //db3  10.3  84
                bool Hmı_Balata_Piston_ileri_KBK = Anasayfa.getBitStateByte(Anasayfa.readBool[12], 4); //db3  12.4    101
                bool Hmı_Balata_Piston_Geri_KBK = Anasayfa.getBitStateByte(Anasayfa.readBool[12], 5); //db3  12.5    102
                bool Hmı_Ust_Baskı_Piston_ileri_KBK = Anasayfa.getBitStateByte(Anasayfa.readBool[12], 6); //db3  12.6    103
                bool Hmı_Ust_Baskı_Piston_Geri_KBK = Anasayfa.getBitStateByte(Anasayfa.readBool[12], 7); //db3  12.7    104
                bool Hmı_Tutucu_Piston_ileri_Geri_KBK = Anasayfa.getBitStateByte(Anasayfa.readBool[13], 0);  //db3  13.0    105
                Hmı_Kort_Bezi_Koparma_Adımlarını_Resetle_KBK = Anasayfa.getBitStateByte(Anasayfa.readBool[13], 1);  //db3  13.1    106
                Hmı_Otomatik_Proses_Adımları_Aktif_KBK = Anasayfa.getBitStateByte(Anasayfa.readBool[13], 2);  //db3  13.2    107
                bool Hmı_Pozisyon_Motor_Manuel_ileri_KBK = Anasayfa.getBitStateByte(Anasayfa.readBool[13], 3);  //db3  13.3    108
                bool Hmı_Pozisyon_Motor_Manuel_Geri_KBK = Anasayfa.getBitStateByte(Anasayfa.readBool[13], 4); //db3  13.4    109
                bool Hmı_Toplama_Motor_Manuel_ileri_KBK = Anasayfa.getBitStateByte(Anasayfa.readBool[13], 5); //db3  13.5    110
                bool Hmı_Toplama_Motor_Manuel_Geri_KBK = Anasayfa.getBitStateByte(Anasayfa.readBool[13], 6); //db3  13.6    111
                bool Hmı_Sıyırma_Ust_Tabla_Asagı_S = Anasayfa.getBitStateByte(Anasayfa.readBool[15], 7);   //db3  15.7 128
                bool Hmı_Sıyırma_Ust_Tabla_Yukarı_S = Anasayfa.getBitStateByte(Anasayfa.readBool[16], 0);   //db3  16.0 129
                bool Hmı_Sıyırıcı_Tutucu_ileri_S = Anasayfa.getBitStateByte(Anasayfa.readBool[16], 1);   //db3  16.1 130
                bool Hmı_Sıyırıcı_Tutucu_Geri_S = Anasayfa.getBitStateByte(Anasayfa.readBool[16], 2);   //db3  16.2 131
                Hmı_Sıyırma_Su_Giris_Vanası_Ac_Kapat_S = Anasayfa.getBitStateByte(Anasayfa.readBool[16], 3);   //db3  16.3 132
                Hmı_Sıyırma_Hava_Giris_Vanası_Ac_Kapat_S = Anasayfa.getBitStateByte(Anasayfa.readBool[16], 4);   //db3  16.4 133
                bool Hmı_Sıyırma_Su_Devir_Daim_Vanası_Ac_Kapat_S = Anasayfa.getBitStateByte(Anasayfa.readBool[16], 5);   //db3  16.5 134
                bool Hmı_Sıyırma_Hava_Tahliye_Vanası_Ac_Kapat_S = Anasayfa.getBitStateByte(Anasayfa.readBool[16], 6);   //db3  16.6 135
                Hmı_Otomatik_Proses_Adımları_Aktif_S = Anasayfa.getBitStateByte(Anasayfa.readBool[16], 7);   //db3  16.7 136
                Hmı_Proses_Adımlarını_Resetle_S = Anasayfa.getBitStateByte(Anasayfa.readBool[17], 0);   //db3  17.0 137
                bool Hmı_Sıyırıcı_Kapak_ic_Motoru_ileri_Kapat_S = Anasayfa.getBitStateByte(Anasayfa.readBool[17], 1);   //db3  17.1 138
                bool Hmı_Sıyırıcı_Kapak_ic_Motoru_Geri_Ac_S = Anasayfa.getBitStateByte(Anasayfa.readBool[17], 2);   //db3  17.2 139
                bool Hmı_Sıyırıcı_Kapak_Dıs_Motoru_ileri_Kapat_S = Anasayfa.getBitStateByte(Anasayfa.readBool[17], 3);   //db3  17.3 140
                bool Hmı_Sıyırıcı_Kapak_Dıs_Motoru_Geri_Ac_S = Anasayfa.getBitStateByte(Anasayfa.readBool[17], 4);   //db3  17.4 141
                Hmı_Ust_Tabla_Serbest_Düsme_Valfi = Anasayfa.getBitStateByte(Anasayfa.readBool[19], 5);      //db3  19.5 158
                Hmı_Servo_Man_Abs_Giriş_Pozisyonuna_Git_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[19], 6);      //db3  19.6 159
                Hmı_Servo_Man_Abs_Orta_Pozisyonuna_Git_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[19], 7);      //db3  19.7 160
                Hmı_Servo_Man_Abs_Cikis_Pozisyonuna_Git_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[20], 0);      //db3  20.0 161
                bool Hmı_Otomatik_Proses_Adımları_Aktif_Şartı_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[20], 1);      //db3  20.1 162
                Hmı_Robot_Tutucu_Ac_ABB = Anasayfa.getBitStateByte(Anasayfa.readBool[20], 2);      //db3  20.2 163
                Hmı_Robot_Tutucu_Kapat_ABB = Anasayfa.getBitStateByte(Anasayfa.readBool[20], 3);      //db3  20.3 164
                bool Hmı_i_Manuel_Kapı_Switch_2_Pano_Arkası = Anasayfa.getBitStateByte(Anasayfa.readBool[20], 4);  //db3  20.4 165
                Hmı_i_Orta_Piston_ileri_Sensör = Anasayfa.getBitStateByte(Anasayfa.readBool[20], 5);  //db3  20.5 166
                bool Hmı_i_Servo_Home_Sensör_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[20], 6);  //db3  20.6 167
                Hmı_i_Orta_Piston_Geri_Sensör_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[20], 7);  //db3  20.7 168
                Hmı_i_Giris_Basınc_Salteri_ileri_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[21], 0);  //db3  21.0 169
                Hmı_i_Giris_Basınc_Salteri_Geri_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[21], 1);  //db3  21.1 170
                Hmı_i_Orta_Basınc_Salteri_ileri_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[21], 2);  //db3  21.2 171
                Hmı_i_Orta_Basınc_Salteri_Geri_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[11], 3);  //db3  21.3 172
                Hmı_i_Cıkıs_Basınc_Salteri_ileri_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[11], 4);  //db3  21.4 173
                Hmı_i_Cıkıs_Basınc_Salteri_Geri_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[11], 5);  //db3  21.5 174
                Hmı_i_Tutucular_Basınc_Salteri_Acik_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[21], 6);  //db3  21.6 175
                Hmı_i_Tutucular_Basınc_Salteri_Kapalı_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[21], 7);  //db3  21.7 176
                Hmı_i_Robot_Tutucu_Basınc_Acık_ABB = Anasayfa.getBitStateByte(Anasayfa.readBool[22], 0);  //db3  22.0 177
                Hmı_i_Robot_Tutucu_Basınc_Kapalı_ABB = Anasayfa.getBitStateByte(Anasayfa.readBool[22], 1);  //db3  22.1 178
                Hmı_i_Sıyırma_Üst_Tabla_Basınc_Salteri_S = Anasayfa.getBitStateByte(Anasayfa.readBool[22], 2);  //db3  22.2 179
                Hmı_i_Tutucu_1_Kapalı_Sensör_S = Anasayfa.getBitStateByte(Anasayfa.readBool[22], 3);  //db3  22.3 180
                Hmı_i_Tutucu_2_Kapalı_Sensör_S = Anasayfa.getBitStateByte(Anasayfa.readBool[22], 4);  //db3  22.4 181
                Hmı_i_Tutucu_3_Kapalı_Sensör_S = Anasayfa.getBitStateByte(Anasayfa.readBool[22], 5);  //db3  22.5 182
                Hmı_i_Tutucu_4_Kapalı_Sensör_S = Anasayfa.getBitStateByte(Anasayfa.readBool[22], 6);  //db3  22.6 183
                Hmı_i_Ust_Limit_Sivic_S = Anasayfa.getBitStateByte(Anasayfa.readBool[22], 7);  //db3  22.7 184
                Hmı_i_Alt_Limit_Sivic_S = Anasayfa.getBitStateByte(Anasayfa.readBool[23], 0);  //db3  23.0 185
                Hmı_i_Malafa_Var_Yok_Sensör_1_S = Anasayfa.getBitStateByte(Anasayfa.readBool[23], 1);  //db3  23.1 186
                Hmı_i_Malafa_Var_Yok_Sensör_2_S = Anasayfa.getBitStateByte(Anasayfa.readBool[23], 2);  //db3  23.2 187
                Hmı_i_Malafa_Var_Yok_Sensör_3_S = Anasayfa.getBitStateByte(Anasayfa.readBool[23], 3);  //db3  23.3 188
                Hmı_i_Malafa_Var_Yok_Sensör_4_S = Anasayfa.getBitStateByte(Anasayfa.readBool[23], 4);  //db3  23.4 189
                Hmı_i_Sıyırıcı_Kapak_ic_Yukarı_Limit_S = Anasayfa.getBitStateByte(Anasayfa.readBool[23], 5);  //db3  23.5 190
                Hmı_i_Sıyırıcı_Kapak_ic_Asagı_Limit_S = Anasayfa.getBitStateByte(Anasayfa.readBool[23], 6);  //db3  23.6 191
                Hmı_i_Balata_Piston_Acık_Sensör_KBK = Anasayfa.getBitStateByte(Anasayfa.readBool[23], 7);  //db3  23.7 192
                Hmı_i_Balata_Piston_Kapalı_Sensör_KBK = Anasayfa.getBitStateByte(Anasayfa.readBool[24], 0);  //db3  24.0 193
                Hmı_i_Kesme_ileri_Sensör_KK = Anasayfa.getBitStateByte(Anasayfa.readBool[24], 1);  //db3  24.1 194
                Hmı_i_Kesme_Geri_Sensör_KK = Anasayfa.getBitStateByte(Anasayfa.readBool[24], 2);  //db3  24.2 195
                Hmı_i_Sıyırıcı_Kapak_Dıs_Yukarı_Limit_S = Anasayfa.getBitStateByte(Anasayfa.readBool[24], 3);  //db3  24.3 196
                Hmı_i_Sıyırıcı_Kapak_Dıs_Asagı_Limit_S = Anasayfa.getBitStateByte(Anasayfa.readBool[24], 4);  //db3  24.4 197
                Hmı_i_Giris_Alt_Piston_ileri_Sensör_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[24], 5);  //db3  24.5 198
                Hmı_i_Giris_Alt_Piston_Geri_Sensör_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[24], 6);  //db3  24.6 199
                Hmı_i_Cıkıs_Alt_Piston_ileri_Sensör_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[24], 7);  //db3  24.7 200
                Hmı_i_Cıkıs_Alt_Piston_Geri_Sensör_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[25], 0);  //db3  25.0 201
                bool Hmı_i_Sıyırma_Orta_Konum_Sivic_S = Anasayfa.getBitStateByte(Anasayfa.readBool[25], 1);  //db3  25.1 202
                Hmı_i_Robot_Tutucu_Açık_Sensör_ABB = Anasayfa.getBitStateByte(Anasayfa.readBool[25], 2);  //db3  25.2 203
                Hmı_i_Robot_Tutucu_Kapalı_Sensör_ABB = Anasayfa.getBitStateByte(Anasayfa.readBool[25], 3);  //db3  25.3 204
                Hmı_Başlangıc_Sartları_Ok_VB = Anasayfa.getBitStateByte(Anasayfa.readBool[25], 4);  //db3  25.4 205
                Hmı_Başlangıc_Sartları_Ok_S = Anasayfa.getBitStateByte(Anasayfa.readBool[25], 5);  //db3  25.5 206
                Hmı_Otomatik_Aktif = Anasayfa.getBitStateByte(Anasayfa.readBool[25], 6);  //db3  25.6 207
                Hmı_Manuel_Aktif = Anasayfa.getBitStateByte(Anasayfa.readBool[25], 7);  //db3  25.7 208
                Hmı_Haberleşme_Ok = Anasayfa.getBitStateByte(Anasayfa.readBool[26], 0);  //db3  26.0 209
                Hmı_Tüm_İstasyonları_Devreye_Al = Anasayfa.getBitStateByte(Anasayfa.readBool[26], 1);  //db3  26.1 210
                Hmı_Vulkanizasyon_Devreye_Al = Anasayfa.getBitStateByte(Anasayfa.readBool[26], 2);  //db3  26.2 211
                Hmı_Kaucuk_Kesme_Devreye_Al = Anasayfa.getBitStateByte(Anasayfa.readBool[26], 3);  //db3  26.3 212
                Hmı_Kort_Bezi_Koparma_Devreye_Al = Anasayfa.getBitStateByte(Anasayfa.readBool[26], 4);  //db3  26.4 213
                Hmı_Sıyırma_Sogutma_Devreye_Al = Anasayfa.getBitStateByte(Anasayfa.readBool[26], 5);  //db3  26.5 214
                Hmı_Standart_Parametreleri_Yükle = Anasayfa.getBitStateByte(Anasayfa.readBool[26], 6);  //db3  26.6 215

                Hmı_Tüm_İstasyonları_Devreden_Cıkar = Anasayfa.getBitStateByte(Anasayfa.readBool[26], 7);  //db3  26.7 216
                Hmı_Vulkanizasyon_Devreden_Cıkar = Anasayfa.getBitStateByte(Anasayfa.readBool[27], 0);  //db3  27.0 217
                Hmı_Kaucuk_Kesme_Devreden_Cıkar = Anasayfa.getBitStateByte(Anasayfa.readBool[27], 1);  //db3  27.1 218
                Hmı_Kort_Bezi_Koparma_Devreden_Cıkar = Anasayfa.getBitStateByte(Anasayfa.readBool[27], 2);  //db3  27.2 219
                Hmı_Sıyırma_Sogutma_Devreden_Cıkar = Anasayfa.getBitStateByte(Anasayfa.readBool[27], 3);  //db3  27.3 220
                Hmı_Robot_Devreye_Al = Anasayfa.getBitStateByte(Anasayfa.readBool[27], 4);  //db3  27.4 216
                Hmı_Robot_Devreden_Cıkar = Anasayfa.getBitStateByte(Anasayfa.readBool[27], 5);  //db3  27.5 217
                Hmı_Sarma_Devreye_Al = Anasayfa.getBitStateByte(Anasayfa.readBool[27], 6);  //db3  27.6 218
                Hmı_Sarma_Devreden_Cıkar = Anasayfa.getBitStateByte(Anasayfa.readBool[27], 7);  //db3  27.7 219              
                Hmı_Vulkanizasyon_Oto_Adım_Şartı = Anasayfa.getBitStateByte(Anasayfa.readBool[30], 0);  //db3  30.0 337 
                Hmı_Vulkanizasyon_Otomatik_Modda_Hareket_Şartı = Anasayfa.getBitStateByte(Anasayfa.readBool[30], 1);  //db3  30.1 338
                Hmı_Başlangıc_Sartları_Ok_ABB = Anasayfa.getBitStateByte(Anasayfa.readBool[30], 2);  //db3  30.2 339
                Hmı_Proses_Adımlarını_Resetle_Robot = Anasayfa.getBitStateByte(Anasayfa.readBool[30], 3);  //db3  30.3 340
                Hmı_Servo_Eksen_Hareket_Sartı_Home_Degil_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[30], 4);  //db3  30.4 341

                Hmı_Ust_Tabla_Orta_Konum_Vakum_Sartı_VP = Anasayfa.getBitStateByte(Anasayfa.readBool[30], 5);  //db3  30.5 342

                Hmı_i_Tambur_Tutucu_Silindir_1_Geri_Sensör_KBK = Anasayfa.getBitStateByte(Anasayfa.readBool[30], 6);  //db3  30.6 343;
                Hmı_i_Tambur_Tutucu_Silindir_2_Geri_Sensör_KBK = Anasayfa.getBitStateByte(Anasayfa.readBool[30], 7);  //db3  30.7 344;
                Hmı_Ust_Baskı_Silindir_1_Geri_Sensör_KBK = Anasayfa.getBitStateByte(Anasayfa.readBool[31], 0);  //db3  31.0 345;
                Hmı_Ust_Baskı_Silindir_2_Geri_Sensör_KBK = Anasayfa.getBitStateByte(Anasayfa.readBool[31], 1);  //db3  31.1 346;

                if (Anasayfa.actPage == "u_manuel")
                {
                    if (tabControl1.SelectedIndex == 1)
                {
                    MAN_MALAFA_TUTUCU_ILERI = Anasayfa.getBitStateByte(Anasayfa.readBool[31], 2);  //db3  30.6 343;
                    MAN_MALAFA_TUTUCU_GERI = Anasayfa.getBitStateByte(Anasayfa.readBool[31], 3);  //db3  30.6 343;
                    MAN_PUNTA_SABITLEME_PISTON_ILERI = Anasayfa.getBitStateByte(Anasayfa.readBool[31], 4);  //db3  30.6 343;
                    MAN_PUNTA_SABITLEME_PISTON_GERI = Anasayfa.getBitStateByte(Anasayfa.readBool[31], 5);  //db3  30.6 343;
                    HATA_RESET = Anasayfa.getBitStateByte(Anasayfa.readBool[31], 6);  //db3  30.6 343;
                    S1_TASIYICI_MANUEL_ILERI = Anasayfa.getBitStateByte(Anasayfa.readBool[31], 7);  //db3  30.6 343;
                    S1_TASIYICI_MANUEL_GERI = Anasayfa.getBitStateByte(Anasayfa.readBool[32], 0);  //db3  30.6 343;
                    S2_DONDURME_MANUEL_ILERI = Anasayfa.getBitStateByte(Anasayfa.readBool[32], 1);  //db3  30.6 343;
                    S2_DONDURME_MANUEL_GERI = Anasayfa.getBitStateByte(Anasayfa.readBool[32], 2);  //db3  30.6 343;
                    S3_YUKSELTME_IC_MANUEL_ILERI = Anasayfa.getBitStateByte(Anasayfa.readBool[32], 3);  //db3  30.6 343;
                    S3_YUKSELTME_IC_MANUEL_GERI = Anasayfa.getBitStateByte(Anasayfa.readBool[32], 4);  //db3  30.6 343;
                    S4_YUKSELTME_DIS_MANUEL_ILERI = Anasayfa.getBitStateByte(Anasayfa.readBool[32], 5);  //db3  30.6 343;
                    S4_YUKSELTME_DIS_MANUEL_GERI = Anasayfa.getBitStateByte(Anasayfa.readBool[32], 6);  //db3  30.6 343;
                    S5_LAZER_MANUEL_ILERI = Anasayfa.getBitStateByte(Anasayfa.readBool[32], 7);  //db3  30.6 343;
                    S5_LAZER_MANUEL_GERI = Anasayfa.getBitStateByte(Anasayfa.readBool[33], 0);  //db3  30.6 343;
                }
            }
                SARMA_OTOMATİK_MOD                       = Anasayfa.getBitStateByte(Anasayfa.readBool[33], 1);  //db3  30.6 343;
                SARMA_DEVREYE_AL                         = Anasayfa.getBitStateByte(Anasayfa.readBool[33], 2);  //db3  30.6 343;
                S7_Blink                                 = Anasayfa.getBitStateByte(Anasayfa.readBool[33], 3);  //db3  30.6 343;
                SARMA_BASLANGIC_OK                       = Anasayfa.getBitStateByte(Anasayfa.readBool[33], 4);  //db3  30.6 343;
                SARMA_DEVREDE                            = Anasayfa.getBitStateByte(Anasayfa.readBool[33], 5);  //db3  30.6 343;


                Hmı_1_Tahliye_Süresi_VP = Anasayfa.readDInt[0];  //db28  0.0
                Hmı_2_Tahliye_Süresi_VP = Anasayfa.readDInt[1];  //db28  4.0
                Hmı_Buhar_Süresi_VP = Anasayfa.readDInt[2];  //db28  8.0
                Hmı_Buhar_Azot_Süresi_VP = Anasayfa.readDInt[3];  //db28 12.0
                Hmı_Vakum_Süresi_VP = Anasayfa.readDInt[4];  //db28 16.0       
                digitalGauge45.Text = Anasayfa.readDInt[5].ToString();//db28 20.0 Hmı_Kaucuk_Kesme_enkoder_Aktüel_Degeri_KK
                int Hmı_Kaucuk_Kesme_Boyu_Gir_KK = Anasayfa.readDInt[6];  //db28 24.0
                digitalGauge11.Text = Anasayfa.readDInt[7].ToString();//db28 28.0 Hmı_Kort_Bezi_Koparma_Enkoder_Aktüel_Degeri_KBK
                int Hmı_Kort_Bezi_Koparma_Boyu_Gir_KBK = Anasayfa.readDInt[8];  //db28 32.0
                Hmı_Sıyırma_Sogutma_Suyu_Süresi_S = Anasayfa.readDInt[9];  //db28 36.0
                Hmı_Sıyırma_Sogutma_Hava_Süresi_S = Anasayfa.readDInt[10]; //db28  40.0
                Hmı_Step_No_Tüm_İstasyonlar = Anasayfa.readDInt[31]; //db28 124.0
                Hmı_Step_No_Robot = Anasayfa.readDInt[32]; //db28 128.0
                Hmı_1_Tahliye_Süresi_Aktüel_VP = Anasayfa.readDInt[33]; //db28 132.0
                Hmı_Buhar_Süresi_Aktüel_VP = Anasayfa.readDInt[34]; //db28 136.0
                Hmı_2_Tahliye_Süresi_Aktüel_VP = Anasayfa.readDInt[35]; //db28 140.0
                Hmı_Vakum_Süresi_Aktüel_VP = Anasayfa.readDInt[36]; //db28 144.0
                Hmı_Sıyırma_Sogutma_Suyu_Süresi_Aktüel_S = Anasayfa.readDInt[37]; //db28 148.0
                Hmı_Sıyırma_Sogutma_Hava_Süresi_Aktüel_S = Anasayfa.readDInt[38]; //db28 152.0


                Hmı_StepNo_Oto_Program_VP = Anasayfa.readInt[0];   //db27 0 
                Hmı_Pistonlar_Palete_Yüklendi_Start_VP = Anasayfa.readInt[1];   //db27 2 
                int Hmı_Piston_Yükleme_Bekleniyor_VP = Anasayfa.readInt[2];   //db27 4 
                int Hmı_Pistonlar_Hazır_Paletten_Al_VP = Anasayfa.readInt[3];   //db27 6 
                Hmı_Pistonlar_Paletten_Alındı_VP = Anasayfa.readInt[4];    //db27 8 
                Hmı_Malafa_Boşaltma_Yapılmalı_VP = Anasayfa.readInt[5];   //db27 10
                Hmı_StepNo_Oto_Program_KK = Anasayfa.readInt[6];   //db27 12
                int Hmı_Kaucuk_Kesme_Start_KK = Anasayfa.readInt[7];   //db27 14
                int Hmı_Kaucuk_Kesme_Start_Bekleniyor_KK = Anasayfa.readInt[8];   //db27 16
                int Hmı_Kaucuk_Kesme_Pozisyon_Motoru_Aktüel_Hiz_KK = Anasayfa.readInt[9];  //db27 18
                Hmı_Kaucuk_Kesme_Pozisyon_Motoru_Hız_Gir_KK = Anasayfa.readInt[10];   //db27 20
                txt_Kaucuk_Kesme_Pozisyon_Motoru_Hız_Gir_KK.Text = Hmı_Kaucuk_Kesme_Pozisyon_Motoru_Hız_Gir_KK.ToString();
                int Hmı_Kaucuk_Kesme_Pozisyon_Motoru_Kalkıs_ivme_KK = Anasayfa.readInt[11];  //db27 22
                int Hmı_Kaucuk_Kesme_Pozisyon_Motoru_Durus_ivme_KK = Anasayfa.readInt[12];  //db27 24
                int Hmı_Kaucuk_Kesme_Toplama_Motoru_Aktüel_Hiz_KK = Anasayfa.readInt[13];  //db27 26
                Hmı_Kaucuk_Kesme_Toplama_Motoru_Hız_Gir_KK = Anasayfa.readInt[14];  //db27 28
                txt_Kaucuk_Kesme_Toplama_Motoru_Hız_Gir_KK.Text = Hmı_Kaucuk_Kesme_Toplama_Motoru_Hız_Gir_KK.ToString();
                int Hmı_Kaucuk_Kesme_Toplama_Motoru_Kalkıs_ivme_KK = Anasayfa.readInt[15];  //db27 30
                int Hmı_Kaucuk_Kesme_Toplama_Motoru_Durus_ivme_KK = Anasayfa.readInt[16];  //db27 32
                Hmı_StepNo_Oto_Program_KBK = Anasayfa.readInt[17];  //db27 34
                int Hmı_Kort_Bezi_Koparma_Start_KBK = Anasayfa.readInt[18];  //db27 36
                int Hmı_Kort_Bezi_Koparma_Start_Bekleniyor_KBK = Anasayfa.readInt[19];  //db27 38
                int Hmı_Kort_Bezi_Koparma_Pozisyon_Motoru_Aktüel_Hiz_KBK = Anasayfa.readInt[20];  //db27 40
                Hmı_Kort_Bezi_Koparma_Pozisyon_Motoru_Hız_Gir_KBK = Anasayfa.readInt[21];  //db27 42
                txt_Kort_Bezi_Koparma_Pozisyon_Motoru_Hız_Gir_KBK.Text = Hmı_Kort_Bezi_Koparma_Pozisyon_Motoru_Hız_Gir_KBK.ToString();
                int Hmı_Kort_Bezi_Koparma_Pozisyon_Motoru_Kalkıs_ivme_KBK = Anasayfa.readInt[22];  //db27 44
                int Hmı_Kort_Bezi_Koparma_Pozisyon_Motoru_Durus_ivme_KBK = Anasayfa.readInt[23];  //db27 46
                int Hmı_Kort_Bezi_Koparma_Toplama_Motoru_Aktüel_Hiz_KBK = Anasayfa.readInt[24];  //db27 48
                Hmı_Kort_Bezi_Koparma_Toplama_Motoru_Hız_Gir_KBK = Anasayfa.readInt[25];  //db27 50
                txt_Hmı_Kort_Bezi_Koparma_Toplama_Motoru_Hız_Gir_KBK.Text = Hmı_Kort_Bezi_Koparma_Toplama_Motoru_Hız_Gir_KBK.ToString();
                int Hmı_Kort_Bezi_Koparma_Toplama_Motoru_Kalkıs_ivme_KBK = Anasayfa.readInt[26];  //db27 52
                int Hmı_Kort_Bezi_Koparma_Toplama_Motoru_Durus_ivme_KBK = Anasayfa.readInt[27];  //db27 54
                Hmı_StepNo_Oto_Program_S = Anasayfa.readInt[28];  //db27 56
                int Hmı_Sıyırma_Malafalar_Hazır_Start_S = Anasayfa.readInt[29];  //db27 58
                int Hmı_Sıyırmaya_Robottan_Malafa_Bekleniyor_S = Anasayfa.readInt[30];  //db27 60
                int Hmı_Sıyırma_Malafalar_Hazır_Robot_Alması_Bekleniyor_S = Anasayfa.readInt[31];  //db27 62
                int Hmı_Sıyırma_Malafalar_Robot_Aldım_S = Anasayfa.readInt[32];  //db27 64
                Hmı_Vulkanizasyonda_Malafa_Var_Yok_Referans = Anasayfa.readInt[33];  //db27 66
                Hmı_Tüm_istasyonları_Devrede = Anasayfa.readInt[34];   //db27 68
                Hmı_Vulkanizasyon_Devrede = Anasayfa.readInt[35];  //db27 70
                Hmı_Kaucuk_Kesme_Devrede = Anasayfa.readInt[36];  //db27 72
                Hmı_Kort_Bezi_Koparma_Devrede = Anasayfa.readInt[37];  //db27 74
                Hmı_Sıyırma_Sogutma_Devrede = Anasayfa.readInt[38];  //db27 76
                Hmı_Robot_Devrede = Anasayfa.readInt[39];  //db27 78
                Hmı_Sarma_Alarm_int = Anasayfa.readInt[40];  //db27 80  
                

            }
            catch
            {               
                MessageBox.Show("Plc Değişken Veri Okuma Yazma Error");
            }
         //   if (tabControl1.SelectedIndex == 0)
         //   {
                //Toogle Buton tekrar okuyup kontol etme aktif pasif durumu
                if (Hmı_Ust_Tabla_Serbest_Düsme_Valfi == true)
                {
                    Serbest_Düsme_Valf_Ac_Kapat.Text = "Serbest Düsme Valf Kapat";
                    Serbest_Düsme_Valf_Ac_Kapat.BackColor = Color.Green;
                }
                else { Serbest_Düsme_Valf_Ac_Kapat.Text = "Serbest Düşme Valf Aç"; }
         //   }
        //    if (tabControl1.SelectedIndex == 4)
       //     {
                if (Hmı_Sıyırma_Su_Giris_Vanası_Ac_Kapat_S == true)
                {
                    Su_Vanası_Ac_Kapat_Btn_SS.Text = "Su Vanası Kapat";
                    Su_Vanası_Ac_Kapat_Btn_SS.BackColor = Color.Green;
                }
                else { Su_Vanası_Ac_Kapat_Btn_SS.Text = "Su Vanası Aç"; }

                if (Hmı_Sıyırma_Hava_Giris_Vanası_Ac_Kapat_S == true)
                {
                    Hava_Vanası_Ac_Kapat_Btn_SS.Text = "Hava Vanası Kapat";
                    Hava_Vanası_Ac_Kapat_Btn_SS.BackColor = Color.Green;
                }
                else { Hava_Vanası_Ac_Kapat_Btn_SS.Text = "Hava Vanası Aç"; }
            //    }
            if (Anasayfa.actPage == "u_manuel")
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    //  Vulkanizasyon presi sensör durumları
                    if (Hmı_i_Tutucular_Basınc_Salteri_Acik_VP == true)
                    { if (checktutucuacık_vb.BackColor != Color.Green) { checktutucuacık_vb.BackColor = Color.Green; } }
                    else
                    { if (checktutucuacık_vb.BackColor != Color.Red) { checktutucuacık_vb.BackColor = Color.Red; } }

                    if (Hmı_i_Tutucular_Basınc_Salteri_Kapalı_VP == true)
                    { if (checktutucukapalı_vb.BackColor != Color.Green) { checktutucukapalı_vb.BackColor = Color.Green; } }
                    else
                    { if (checktutucukapalı_vb.BackColor != Color.Red) { checktutucukapalı_vb.BackColor = Color.Red; } }

                    if (Hmı_i_Giris_Basınc_Salteri_Geri_VP == true)
                    { if (checkgirisaltpistongeride_B_vb.BackColor != Color.Green) { checkgirisaltpistongeride_B_vb.BackColor = Color.Green; } }
                    else
                    { if (checkgirisaltpistongeride_B_vb.BackColor != Color.Red) { checkgirisaltpistongeride_B_vb.BackColor = Color.Red; } }

                    if (Hmı_i_Giris_Basınc_Salteri_ileri_VP == true)
                    { if (checkgirisaltpistonileride_B_vb.BackColor != Color.Green) { checkgirisaltpistonileride_B_vb.BackColor = Color.Green; } }
                    else
                    { if (checkgirisaltpistonileride_B_vb.BackColor != Color.Red) { checkgirisaltpistonileride_B_vb.BackColor = Color.Red; } }
                    if (Hmı_i_Giris_Alt_Piston_ileri_Sensör_VP == true)
                    { if (checkgirisaltpistonileride_S_vb.BackColor != Color.Green) { checkgirisaltpistonileride_S_vb.BackColor = Color.Green; } }
                    else
                    { if (checkgirisaltpistonileride_S_vb.BackColor != Color.Red) { checkgirisaltpistonileride_S_vb.BackColor = Color.Red; } }

                    if (Hmı_i_Giris_Alt_Piston_Geri_Sensör_VP == true)
                    { if (checkgirisaltpistongeride_S_vb.BackColor != Color.Green) { checkgirisaltpistongeride_S_vb.BackColor = Color.Green; } }
                    else
                    { if (checkgirisaltpistongeride_S_vb.BackColor != Color.Red) { checkgirisaltpistongeride_S_vb.BackColor = Color.Red; } }
                    if (Hmı_i_Giris_Basınc_Salteri_Geri_VP == true)
                    { if (checkgirisaltpistongeride_B_vb.BackColor != Color.Green) { checkgirisaltpistongeride_B_vb.BackColor = Color.Green; } }
                    else
                    { if (checkgirisaltpistongeride_B_vb.BackColor != Color.Red) { checkgirisaltpistongeride_B_vb.BackColor = Color.Red; } }

                    if (Hmı_i_Orta_Basınc_Salteri_Geri_VP == true)
                    { if (checkortaaltpistongeride_B_vb.BackColor != Color.Green) { checkortaaltpistongeride_B_vb.BackColor = Color.Green; } }
                    else
                    { if (checkortaaltpistongeride_B_vb.BackColor != Color.Red) { checkortaaltpistongeride_B_vb.BackColor = Color.Red; } }
                    if (Hmı_i_Orta_Piston_Geri_Sensör_VP == true)
                    { if (checkortaaltpistongeride_S_vb.BackColor != Color.Green) { checkortaaltpistongeride_S_vb.BackColor = Color.Green; } }
                    else
                    { if (checkortaaltpistongeride_S_vb.BackColor != Color.Red) { checkortaaltpistongeride_S_vb.BackColor = Color.Red; } }

                    if (Hmı_i_Orta_Basınc_Salteri_ileri_VP == true)
                    { if (checkortaaltpistonileride_B_vb.BackColor != Color.Green) { checkortaaltpistonileride_B_vb.BackColor = Color.Green; } }
                    else
                    { if (checkortaaltpistonileride_B_vb.BackColor != Color.Red) { checkortaaltpistonileride_B_vb.BackColor = Color.Red; } }
                    if (Hmı_i_Orta_Piston_ileri_Sensör == true)
                    { if (checkortaaltpistonileride_S_vb.BackColor != Color.Green) { checkortaaltpistonileride_S_vb.BackColor = Color.Green; } }
                    else
                    { if (checkortaaltpistonileride_S_vb.BackColor != Color.Red) { checkortaaltpistonileride_S_vb.BackColor = Color.Red; } }

                    if (Hmı_i_Cıkıs_Basınc_Salteri_Geri_VP == true)
                    { if (checkcikisaltpistongeride_B_vb.BackColor != Color.Green) { checkcikisaltpistongeride_B_vb.BackColor = Color.Green; } }
                    else
                    { if (checkcikisaltpistongeride_B_vb.BackColor != Color.Red) { checkcikisaltpistongeride_B_vb.BackColor = Color.Red; } }
                    if (Hmı_i_Cıkıs_Alt_Piston_Geri_Sensör_VP == true)
                    { if (checkcikisaltpistongeride_S_vb.BackColor != Color.Green) { checkcikisaltpistongeride_S_vb.BackColor = Color.Green; } }
                    else
                    { if (checkcikisaltpistongeride_S_vb.BackColor != Color.Red) { checkcikisaltpistongeride_S_vb.BackColor = Color.Red; } }

                    if (Hmı_i_Cıkıs_Basınc_Salteri_ileri_VP == true)
                    { if (checkcikisaltpistonileride_B_vb.BackColor != Color.Green) { checkcikisaltpistonileride_B_vb.BackColor = Color.Green; } }
                    else
                    { if (checkcikisaltpistonileride_B_vb.BackColor != Color.Red) { checkcikisaltpistonileride_B_vb.BackColor = Color.Red; } }
                    if (Hmı_i_Cıkıs_Alt_Piston_ileri_Sensör_VP == true)
                    { if (checkcikisaltpistonileride_S_vb.BackColor != Color.Green) { checkcikisaltpistonileride_S_vb.BackColor = Color.Green; } }
                    else
                    { if (checkcikisaltpistonileride_S_vb.BackColor != Color.Red) { checkcikisaltpistonileride_S_vb.BackColor = Color.Red; } }

                    if (Hmı_Servo_Oto_Abs_Giris_Poz_Set_VP - 1 < Hmı_ServoAnlıkPozisyon_VP && Hmı_ServoAnlıkPozisyon_VP < Hmı_Servo_Oto_Abs_Giris_Poz_Set_VP + 1)
                    { if (checküsttablagirisde_vb.BackColor != Color.Green) { checküsttablagirisde_vb.BackColor = Color.Green; } }
                    else
                    { if (checküsttablagirisde_vb.BackColor != Color.Red) { checküsttablagirisde_vb.BackColor = Color.Red; } }
                    if (Hmı_Servo_Oto_Abs_Orta_Poz_Set_VP - 1 < Hmı_ServoAnlıkPozisyon_VP && Hmı_ServoAnlıkPozisyon_VP < Hmı_Servo_Oto_Abs_Orta_Poz_Set_VP + 1)
                    { if (checküsttablaortada_vb.BackColor != Color.Green) { checküsttablaortada_vb.BackColor = Color.Green; } }
                    else
                    { if (checküsttablaortada_vb.BackColor != Color.Red) { checküsttablaortada_vb.BackColor = Color.Red; } }
                    if (Hmı_Servo_Oto_Abs_Cikis_Poz_Set_VP - 1 < Hmı_ServoAnlıkPozisyon_VP && Hmı_ServoAnlıkPozisyon_VP < Hmı_Servo_Oto_Abs_Cikis_Poz_Set_VP + 1)
                    { if (checküsttablacikista_vb.BackColor != Color.Green) { checküsttablacikista_vb.BackColor = Color.Green; } }
                    else
                    { if (checküsttablacikista_vb.BackColor != Color.Red) { checküsttablacikista_vb.BackColor = Color.Red; } }

                    if (Hmı_Ust_Tabla_Yukarı_Set_Pozisyon_VP <= Hmı_ÜstTablaAnlıkYükseklik_VP)
                    { if (checküsttablayukarıda_vb.BackColor != Color.Green) { checküsttablayukarıda_vb.BackColor = Color.Green; } }
                    else
                    { if (checküsttablayukarıda_vb.BackColor != Color.Red) { checküsttablayukarıda_vb.BackColor = Color.Red; } }
                }
            }
            if (Anasayfa.actPage == "u_manuel")
            {
                if (tabControl1.SelectedIndex == 4)
                {
                    //sıyırma sogutma sensör durumları
                    if (Hmı_i_Sıyırıcı_Kapak_ic_Yukarı_Limit_S == true)
                    { if (checksıyırıcıiçkapakacık_s.BackColor != Color.Green) { checksıyırıcıiçkapakacık_s.BackColor = Color.Green; } }
                    else
                    { if (checksıyırıcıiçkapakacık_s.BackColor != Color.Red) { checksıyırıcıiçkapakacık_s.BackColor = Color.Red; } }
                    if (Hmı_i_Sıyırıcı_Kapak_ic_Asagı_Limit_S == false)
                    { if (checksıyırıcıiçkapakkapalı_s.BackColor != Color.Green) { checksıyırıcıiçkapakkapalı_s.BackColor = Color.Green; } }
                    else
                    { if (checksıyırıcıiçkapakkapalı_s.BackColor != Color.Red) { checksıyırıcıiçkapakkapalı_s.BackColor = Color.Red; } }

                    if (Hmı_i_Sıyırıcı_Kapak_Dıs_Asagı_Limit_S == false)
                    { if (checksıyırıcıdıskapakkapalı_s.BackColor != Color.Green) { checksıyırıcıdıskapakkapalı_s.BackColor = Color.Green; } }
                    else
                    { if (checksıyırıcıdıskapakkapalı_s.BackColor != Color.Red) { checksıyırıcıdıskapakkapalı_s.BackColor = Color.Red; } }
                    if (Hmı_i_Sıyırıcı_Kapak_Dıs_Yukarı_Limit_S == true)
                    { if (checksıyırıcıdıskapakacık_s.BackColor != Color.Green) { checksıyırıcıdıskapakacık_s.BackColor = Color.Green; } }
                    else
                    { if (checksıyırıcıdıskapakacık_s.BackColor != Color.Red) { checksıyırıcıdıskapakacık_s.BackColor = Color.Red; } }

                    if (Hmı_i_Ust_Limit_Sivic_S == true)
                    { if (checküsttablayukarıda_s.BackColor != Color.Green) { checküsttablayukarıda_s.BackColor = Color.Green; } }
                    else
                    { if (checküsttablayukarıda_s.BackColor != Color.Red) { checküsttablayukarıda_s.BackColor = Color.Red; } }
                    if (Hmı_i_Alt_Limit_Sivic_S == true)
                    { if (checküsttablaasagıda_s.BackColor != Color.Green) { checküsttablaasagıda_s.BackColor = Color.Green; } }
                    else
                    { if (checküsttablaasagıda_s.BackColor != Color.Red) { checküsttablaasagıda_s.BackColor = Color.Red; } }

                    if (Hmı_i_Tutucu_1_Kapalı_Sensör_S != true)
                    { if (checktutucu1acık_s.BackColor != Color.Green) { checktutucu1acık_s.BackColor = Color.Green; } }
                    else
                    { if (checktutucu1acık_s.BackColor != Color.Red) { checktutucu1acık_s.BackColor = Color.Red; } }

                    if (Hmı_i_Tutucu_2_Kapalı_Sensör_S != true)
                    { if (checktutucu2acık_s.BackColor != Color.Green) { checktutucu2acık_s.BackColor = Color.Green; } }
                    else
                    { if (checktutucu2acık_s.BackColor != Color.Red) { checktutucu2acık_s.BackColor = Color.Red; } }

                    if (Hmı_i_Tutucu_3_Kapalı_Sensör_S != true)
                    { if (checktutucu3acık_s.BackColor != Color.Green) { checktutucu3acık_s.BackColor = Color.Green; } }
                    else
                    { if (checktutucu3acık_s.BackColor != Color.Red) { checktutucu3acık_s.BackColor = Color.Red; } }

                    if (Hmı_i_Tutucu_4_Kapalı_Sensör_S != true)
                    { if (checktutucu4acık_s.BackColor != Color.Green) { checktutucu4acık_s.BackColor = Color.Green; } }
                    else
                    { if (checktutucu4acık_s.BackColor != Color.Red) { checktutucu4acık_s.BackColor = Color.Red; } }
                }
            
           if (tabControl1.SelectedIndex == 2)
           {
        //Kaucuk kesme sensör durumları
                if (Hmı_i_Kesme_ileri_Sensör_KK == true)
                { if (checkkesmeileride_VB.BackColor != Color.Green) { checkkesmeileride_VB.BackColor = Color.Green; } }
                else
                { if (checkkesmeileride_VB.BackColor != Color.Red) { checkkesmeileride_VB.BackColor = Color.Red; } }
                if (Hmı_i_Kesme_Geri_Sensör_KK == true)
                { if (checkkesmegeride_VB.BackColor != Color.Green) { checkkesmegeride_VB.BackColor = Color.Green; } }
                else
                { if (checkkesmegeride_VB.BackColor != Color.Red) { checkkesmegeride_VB.BackColor = Color.Red; } }
           }
          if (tabControl1.SelectedIndex == 3)
           {
                // Kortbezi Koparma sensör durumları
                if (Hmı_i_Tambur_Tutucu_Silindir_1_Geri_Sensör_KBK == true && Hmı_i_Tambur_Tutucu_Silindir_2_Geri_Sensör_KBK == true)
                { if (checktutucuacıkkapalı_KBK.BackColor != Color.Green) { checktutucuacıkkapalı_KBK.BackColor = Color.Green; } }
                else
                { if (checktutucuacıkkapalı_KBK.BackColor != Color.Red) { checktutucuacıkkapalı_KBK.BackColor = Color.Red; } }

                if (Hmı_i_Balata_Piston_Acık_Sensör_KBK == true)
                { if (checkbalataacık_KBK.BackColor != Color.Green) { checkbalataacık_KBK.BackColor = Color.Green; } }
                else
                { if (checkbalataacık_KBK.BackColor != Color.Red) { checkbalataacık_KBK.BackColor = Color.Red; } }
                if (Hmı_i_Balata_Piston_Kapalı_Sensör_KBK == true)
                { if (checkbalatakapalı_KBK.BackColor != Color.Green) { checkbalatakapalı_KBK.BackColor = Color.Green; } }
                else
                { if (checkbalatakapalı_KBK.BackColor != Color.Red) { checkbalatakapalı_KBK.BackColor = Color.Red; } }

                if (Hmı_Ust_Baskı_Silindir_1_Geri_Sensör_KBK == false && Hmı_Ust_Baskı_Silindir_2_Geri_Sensör_KBK == false)
                { if (checkbaskıacık_KBK.BackColor != Color.Green) { checkbalataacık_KBK.BackColor = Color.Green; } }
                else
                { if (checkbaskıacık_KBK.BackColor != Color.Red) { checkbalataacık_KBK.BackColor = Color.Red; } }
                if (Hmı_Ust_Baskı_Silindir_1_Geri_Sensör_KBK == true && Hmı_Ust_Baskı_Silindir_2_Geri_Sensör_KBK == true)
                { if (checkbaskıkapalı_KBK.BackColor != Color.Green) { checkbaskıkapalı_KBK.BackColor = Color.Green; } }
                else
                { if (checkbaskıkapalı_KBK.BackColor != Color.Red) { checkbaskıkapalı_KBK.BackColor = Color.Red; } }
            }
            if (tabControl1.SelectedIndex == 5)
            {
                //Robot sensör durumu
               
                if (Hmı_i_Robot_Tutucu_Açık_Sensör_ABB == true)
                { if (checkrobottutucuacık_S_ABB.BackColor != Color.Green) { checkrobottutucuacık_S_ABB.BackColor = Color.Green; } }
                else
                { if (checkrobottutucuacık_S_ABB.BackColor != Color.Red) { checkrobottutucuacık_S_ABB.BackColor = Color.Red; } }     
                
                if (Hmı_i_Robot_Tutucu_Kapalı_Sensör_ABB == true)
                { if (checkrobottutucukapalı_S_ABB.BackColor != Color.Green) { checkrobottutucukapalı_S_ABB.BackColor = Color.Green; } }
                else
                { if (checkrobottutucukapalı_S_ABB.BackColor != Color.Red) { checkrobottutucukapalı_S_ABB.BackColor = Color.Red; } }
            }
                if (tabControl1.SelectedIndex == 0)
                {
                    if (Hmı_Piston_Hareket_Sartı_VP == true)
                    { textManSartlar.Text = "Alt Pistonların Hareketi için Üst Tabla Yukarı Pozisyonda Olmalıdır"; }
                    else if (Hmı_Tutucu_Ac_Kapat_Sartları_VP == true)
                    { textManSartlar.Text = "Tutucuları Aç Kapat Yapmak için Girişte ve Çıkışta Üst Tabla Alt Pozisyonda Olmalıdır"; }
                    else if (Hmı_Ust_Tabla_Giris_Hareket_Sartı_VP == true)
                    { textManSartlar.Text = "Ust tabla girişte ise asagı hareket için tutucu açık olmalıdır"; }
                    else if (Hmı_Ust_Tabla_Hareket_Sartı_VP == true)
                    { textManSartlar.Text = "Üst Tabla Aşagı Hareketi için Servo Giriş, Orta ve Çıkış Pozisyonlarında Olmalıdır"; }
                    else if (Hmı_Servo_Eksen_Hareket_Sartı_VP == true)
                    { textManSartlar.Text = "Servo Eksen Hareketi için Üst Tabla Yukarı Pozisyonda Olmalıdır ve Home Hatası olmamalıdır."; }
                    else if (Hmı_Servo_Eksen_Homing_Sartı_VP == true)
                    { textManSartlar.Text = "Servo Eksen Home Pozisyonu için Üst Tabla Yukarı Pozisyonda Olmadır"; }
                    else if (Hmı_Servo_Eksen_Hareket_Sartı_Home_Degil_VP == true)
                    { textManSartlar.Text = "Servo Eksen Hareketi için Servo Home Yapılmalıdır"; }
                    else if (Hmı_Ust_Tabla_Orta_Konum_Vakum_Sartı_VP == true)
                    { textManSartlar.Text = "ÜSt Tabla Orta Konum Aşagı Hareket için Torba Vakumlanmalıdır"; }
                    else
                    {
                        if (textManSartlar.Text != "")
                        { textManSartlar.Text = ""; }
                    }
                }
            }
        }  
        private void btnDown(object sender, MouseEventArgs e)
        {
           
            string[] adres = (sender as DevExpress.XtraEditors.SimpleButton).Tag.ToString().Split('.');
            if (adres[0] == "S")
            {             
                Anasayfa.writeBit(Convert.ToUInt16(adres[1]), Convert.ToUInt16(adres[2]),Convert.ToByte(adres[3]), 1);
            }
            if (adres[0] == "R")
            {
                Anasayfa.writeBit(Convert.ToUInt16(adres[1]), Convert.ToUInt16(adres[2]), Convert.ToByte(adres[3]), 0);
            }
            if (adres[0] == "T")
            {
                if (Hmı_Ust_Tabla_Serbest_Düsme_Valfi == true)
                {
                    Anasayfa.writeBit(Convert.ToUInt16(adres[1]), Convert.ToUInt16(adres[2]), Convert.ToByte(adres[3]), 0);
                }
                else
                {
                    Anasayfa.writeBit(Convert.ToUInt16(adres[1]), Convert.ToUInt16(adres[2]), Convert.ToByte(adres[3]), 1);
                }          
            }
            if (adres[0] == "C")
            {
                Anasayfa.writeBit(Convert.ToUInt16(adres[1]), Convert.ToUInt16(adres[2]), Convert.ToByte(adres[3]), 1);
            }
            if (adres[0] == "WC")
            {
                
            }


        }
        private void btnUp(object sender, MouseEventArgs e)
        {
            string[] adres = (sender as DevExpress.XtraEditors.SimpleButton).Tag.ToString().Split('.');

            if (adres[0] == "C")
            {
                Anasayfa.writeBit(Convert.ToUInt16(adres[1]), Convert.ToUInt16(adres[2]), Convert.ToByte(adres[3]), 0);
            }

            if (adres[0] == "WC")
            {

            }

        }
        private void clkText(object sender, EventArgs e)
        {
            frmKlavye frm = new frmKlavye((sender as TextBox).Text , (sender as TextBox).Tag.ToString());
            frm.Show();
        }

        private void groupBox32_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void gaugeControl6_Click(object sender, EventArgs e)
        {

        }

        private void u_manuel_Load(object sender, EventArgs e)
        {

        }

        private void txt_Servo_Man_Hiz_Degeri_Gir_VP_TextChanged(object sender, EventArgs e)
        {

        }
    }      
}  
    
