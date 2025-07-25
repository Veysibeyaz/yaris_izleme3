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
    public partial class Referans_Sartlar : Form
    {
        public Referans_Sartlar()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //  Vulkanizasyon presi referans sartları
            if (u_manuel.Hmı_i_Tutucular_Basınc_Salteri_Acik_VP == true)
            { if (checktutucuacık_vb.BackColor != Color.Green) {checktutucuacık_vb.BackColor = Color.Green;}}
            else
            { if (checktutucuacık_vb.BackColor != Color.Red){checktutucuacık_vb.BackColor = Color.Red;}}

            if (u_manuel.Hmı_i_Giris_Alt_Piston_Geri_Sensör_VP == true && u_manuel.Hmı_i_Giris_Basınc_Salteri_Geri_VP == true)
            { if (checkgirisaltpiston_vb.BackColor != Color.Green) { checkgirisaltpiston_vb.BackColor = Color.Green; } }
            else
            { if (checkgirisaltpiston_vb.BackColor != Color.Red) { checkgirisaltpiston_vb.BackColor = Color.Red; } }

            if (u_manuel.Hmı_i_Orta_Piston_Geri_Sensör_VP == true && u_manuel.Hmı_i_Orta_Basınc_Salteri_Geri_VP == true)
            { if (checkortaaltpiston_vb.BackColor != Color.Green) { checkortaaltpiston_vb.BackColor = Color.Green; } }
            else
            { if (checkortaaltpiston_vb.BackColor != Color.Red) { checkortaaltpiston_vb.BackColor = Color.Red; } }

            if (u_manuel.Hmı_i_Cıkıs_Alt_Piston_ileri_Sensör_VP == true && u_manuel.Hmı_i_Cıkıs_Basınc_Salteri_ileri_VP == true)
            { if (checkcikisaltpiston_vb.BackColor != Color.Green) { checkcikisaltpiston_vb.BackColor = Color.Green; } }
            else
            { if (checkcikisaltpiston_vb.BackColor != Color.Red) { checkcikisaltpiston_vb.BackColor = Color.Red; } }

            if (u_manuel.Hmı_Servo_Oto_Abs_Giris_Poz_Set_VP - 0.1 < u_manuel.Hmı_ServoAnlıkPozisyon_VP && u_manuel.Hmı_ServoAnlıkPozisyon_VP < u_manuel.Hmı_Servo_Oto_Abs_Giris_Poz_Set_VP + 0.1)
            { if (checküsttablagiris_vb.BackColor != Color.Green) { checküsttablagiris_vb.BackColor = Color.Green; } }
            else
            { if (checküsttablagiris_vb.BackColor != Color.Red) { checküsttablagiris_vb.BackColor = Color.Red; } }

            if (u_manuel.Hmı_Ust_Tabla_Yukarı_Set_Pozisyon_VP <= u_manuel.Hmı_ÜstTablaAnlıkYükseklik_VP)
            { if (checküsttablayukarıda_vb.BackColor != Color.Green) { checküsttablayukarıda_vb.BackColor = Color.Green; } }
            else
            { if (checküsttablayukarıda_vb.BackColor != Color.Red) { checküsttablayukarıda_vb.BackColor = Color.Red; } }

            //Sıyırma Referans sartları
            if (u_manuel.Hmı_i_Sıyırıcı_Kapak_ic_Yukarı_Limit_S == true)
            { if (checksıyırıcıiçkapakacık_s.BackColor != Color.Green) { checksıyırıcıiçkapakacık_s.BackColor = Color.Green; } }
            else
            { if (checksıyırıcıiçkapakacık_s.BackColor != Color.Red) { checksıyırıcıiçkapakacık_s.BackColor = Color.Red; } }       

            if (u_manuel.Hmı_i_Sıyırıcı_Kapak_Dıs_Asagı_Limit_S == true)
            { if (checksıyırıcıdıskapakkapalı_s.BackColor != Color.Green) { checksıyırıcıdıskapakkapalı_s.BackColor = Color.Green; } }
            else
            { if (checksıyırıcıdıskapakkapalı_s.BackColor != Color.Red) { checksıyırıcıdıskapakkapalı_s.BackColor = Color.Red; } }

            if (u_manuel.Hmı_i_Ust_Limit_Sivic_S == true)
            { if (checküsttablayukarıda_s.BackColor != Color.Green) { checküsttablayukarıda_s.BackColor = Color.Green; } }
            else
            { if (checküsttablayukarıda_s.BackColor != Color.Red) { checküsttablayukarıda_s.BackColor = Color.Red; } }

            if (u_manuel.Hmı_i_Tutucu_1_Kapalı_Sensör_S != true)
            { if (checktutucu1acık_s.BackColor != Color.Green) { checktutucu1acık_s.BackColor = Color.Green; } }
            else
            { if (checktutucu1acık_s.BackColor != Color.Red) { checktutucu1acık_s.BackColor = Color.Red; } }

            if (u_manuel.Hmı_i_Tutucu_2_Kapalı_Sensör_S != true)
            { if (checktutucu2acık_s.BackColor != Color.Green) { checktutucu2acık_s.BackColor = Color.Green; } }
            else
            { if (checktutucu2acık_s.BackColor != Color.Red) { checktutucu2acık_s.BackColor = Color.Red; } }

            if (u_manuel.Hmı_i_Tutucu_3_Kapalı_Sensör_S != true)
            { if (checktutucu3acık_s.BackColor != Color.Green) { checktutucu3acık_s.BackColor = Color.Green; } }
            else
            { if (checktutucu3acık_s.BackColor != Color.Red) { checktutucu3acık_s.BackColor = Color.Red; } }

            if (u_manuel.Hmı_i_Tutucu_4_Kapalı_Sensör_S != true)
            { if (checktutucu4acık_s.BackColor != Color.Green) { checktutucu4acık_s.BackColor = Color.Green; } }
            else
            { if (checktutucu4acık_s.BackColor != Color.Red) { checktutucu4acık_s.BackColor = Color.Red; } }
        }
     
    }
}
