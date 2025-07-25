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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;

namespace Yaris_Online_izleme_Programı
{
    public partial class u_grafik : UserControl
    {
        public string[] Kullanıcı = new string[100];
       
        public u_grafik()
             
        {
            InitializeComponent(); 
          //  excelDataSource1.Fill();
        }
        string txtkullanıcı;
        Şifre şifreformm = new Şifre();
        private void button1_Click(object sender, EventArgs e)
        {
         //  if (chartControl1.Series[Convert.ToInt32( (sender as Button).Tag.ToString())].Visible == true)
         //  {
         //      chartControl1.Series[Convert.ToInt32((sender as Button).Tag.ToString())].Visible = false;
         //      (sender as Button).BackColor = SystemColors.Control;
         //  }
         //  else
         //  {
         //      chartControl1.Series[Convert.ToInt32((sender as Button).Tag.ToString())].Visible = true;
         //      (sender as Button).BackColor = Color.Lime;
         //  }
        }
        string txtkullanıcıchange;
        private void tmrKayit_Tick(object sender, EventArgs e)
        {
          
            if (Anasayfa.actPage == "u_grafik")
            {
            
                if (textBox1.Text != txtkullanıcıchange)
                {
                    txtkullanıcıchange = textBox1.Text;
                    textBox1.SelectAll();
                }


                if (txtkullanıcı == "txtkullanıcı")
                {
                    txtkullanıcı = "";
                    textBox1.Enabled = false;
                   
                    try
                    {
                        ToplamCalisanOperatör.Clear();
                        StreamReader sr = new System.IO.StreamReader(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "Kullanıcı" + ".txt");
                        string line;                     
                            while ((line = sr.ReadLine()) != null)
                          {                               
                            ToplamCalisanOperatör.Items.Add(line.Split(';')[0]);
                           }                          
                            int sira = ToplamCalisanOperatör.Items.Count;
                            // listView1.Items[sira].SubItems.Add(line.Split(';')[1]);
                                         
                        sr.Close();
                    }
                    catch
                    {
                        MessageBox.Show("OPERATÖR LİSTESİ GÖSTERİLEMİYOR");
                    }

                    try
                    {                        
                        listView1.Clear();
                        StreamReader ST = new System.IO.StreamReader(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "AktifKullanıcı" + ".txt");
                        string[] linest = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "AktifKullanıcı" + ".txt");
                        int countrz = linest.Count();
                        string lineR;
                        while ((lineR = ST.ReadLine()) != null)
                        {
                            listView1.Items.Add(lineR.Split(';')[0]);
                        }
                        int sira = listView1.Items.Count;
                        // listView1.Items[sira].SubItems.Add(line.Split(';')[1]);
                        for (int t =  countrz; t < 6; t++)
                        {
                            u_anasayfa.operatör_adı[t] = "";
                        }
                        ST.Close();

                     
                    }
                    catch
                    {
                        MessageBox.Show("AKTİF OPERATÖR LİSTESİ GÖSTERİLEMİYOR");
                    }
                }
                try
                {
                    if (u_anasayfa.M_Pres_1_iş_başlat == false)
                    {
                        listView1.Clear();
                        StreamWriter writerr = new StreamWriter(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "AktifKullanıcı" + ".txt");
                        for (int z = 0; z < listView1.Items.Count; z++)
                        {
                            writerr.WriteLine(listView1.Items[z].SubItems[0].Text);
                        }
                        writerr.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("OPERATÖR LİSTESİ SİLİNEMİYOR");
                }
              
            }
            else
            {
                txtkullanıcı = "txtkullanıcı";
                textBox1.Enabled = false;                
                textBox1.BackColor = Color.White;
                textBox1.Text = "";
                // simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                simpleButton2.Appearance.BackColor = Color.Red;
                simpleButton2.Text = "OPERATÖR TANITMA AKTİF ET";
            }



            // string yazi = DateTime.Now.ToShortDateString() + ";" + DateTime.Now.ToLongTimeString() + ";" + Anasayfa.readFloat[0].ToString("0.00").Replace(',','.') + ";" + Anasayfa.readFloat[1].ToString("0.00").Replace(',', '.') + ";" + Anasayfa.readFloat[2].ToString("0.00").Replace(',', '.') + ";" + Anasayfa.readFloat[3].ToString("0.00").Replace(',', '.') + ";" + Anasayfa.readFloat[4].ToString("0.00").Replace(',', '.') + ";" + Anasayfa.readFloat[5].ToString("0.00").Replace(',', '.') + ";" + Anasayfa.readFloat[6].ToString("0.00").Replace(',', '.') + ";" + Anasayfa.readFloat[7].ToString("0.00").Replace(',', '.') + Environment.NewLine;
            //  File.AppendAllText(Directory.GetCurrentDirectory() + "\\Graphics\\" + "Datas" + ".csv", yazi);
            // excelDataSource1.Fill();
        }

        private void button9_Click(object sender, EventArgs e)
        {
             
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new System.IO.StreamReader(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "Kullanıcı" + ".txt");
                string line;
               
                while ((line = sr.ReadLine()) != null)
                {

                  Kullanıcı[0] = line.Split(';')[0];
                  Kullanıcı[1] = line.Split(';')[1].ToString();

                    if (line == textBox1.Text)
                    {
                        listView1.Items.Add(line.Split(';')[0]);
                    }                
                                          
                    else
                    {
                      
                        MessageBox.Show("TANIMSIZ KULLANICI", "REFERANSA GÖNDERME SEÇİMİ", MessageBoxButtons.OK);
                       
                    }

                                    
                    int sira = listView1.Items.Count;
                 
                   // listView1.Items[sira].SubItems.Add(line.Split(';')[1]);
                }
            

            }
            catch
            {
            }
        }
        bool Kullanıcıeklemeyapıldı;
        private void button2_Click(object sender, EventArgs e)
        {
           string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "Kullanıcı" + ".txt");
            int countr=lines.Count();
            string[] lineac = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "AktifKullanıcı" + ".txt");
            int countac = lineac.Count();
            int sira = ToplamCalisanOperatör.Items.Count;
            Kullanıcıeklemeyapıldı = false;
            Operatör_var = false;
            // listView1.Items.Add(lines[0]);
            //  listView1.Items.Add(lines[1]);
try
            {
                if (u_anasayfa.M_Pres_1_iş_başlat==true)
                {
                    if (listView1.Items.Count <= 5)

                    {
                        if (textBox1.Text != "")
                        {
                         if  (listView1.Items.Count != 0)
                                {
                                if (listView1.Items[0].SubItems[0].Text == "")
                                {
                                    listView1.Clear();
                                }
                            }
                   
                                for (int i = 0; i < listView1.Items.Count; i++)
                            {
                                if (listView1.Items[i].SubItems[0].Text == textBox1.Text)
                                {
                                    Operatör_var = true;
                                }
                            }

                            //  sira == listView1.Items.Count
                            if (listView1.Items.Count != 0 && Operatör_var == false && listView1.Items.Count != 0)
                            {
                                for (int i = 0; i < countr; i++)
                                {
                                    if (textBox1.Text == lines[i])
                                    {
                                        listView1.Items.Add(lines[i]);
                                        Kullanıcıeklemeyapıldı = true;
                                        Operatör_var = false;
                                    }
                                }
                                if (Kullanıcıeklemeyapıldı == false)
                                {
                                    MessageBox.Show("KULLANICI EŞLEŞMİYOR");
                                }
                            }
                            else if (listView1.Items.Count == 0 && Operatör_var == false)
                            {
                                for (int i = 0; i < countr; i++)
                                {
                                    if (textBox1.Text == lines[i])
                                    {
                                        listView1.Items.Add(lines[i]);
                                        Kullanıcıeklemeyapıldı = true;
                                        Operatör_var = false;
                                    }
                                }
                                
                                if (Kullanıcıeklemeyapıldı == false)
                                {
                                    MessageBox.Show("KULLANICI EŞLEŞMİYOR");
                                }
                            }
                            else
                            {
                                MessageBox.Show("OPERATÖR LİSTESİNDE MEVCUTTUR");
                            }

                        }
                        else
                        {
                            MessageBox.Show("OPERATÖR KARTI OKUTARAK EKLEME YAPINIZ");
                        }


                        StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "AktifKullanıcı" + ".txt");
                        for (int y = 0; y < listView1.Items.Count; y++)
                        {
                            u_anasayfa.operatör_adı[y] = ((listView1.Items[y].Text).ToString());
                            // listView1.Items.Add(u_anasayfa.operatör_adı[y]);
                            writer.WriteLine(listView1.Items[y].SubItems[0].Text);
                        }

                    //  for (int i = 0; i < countac; i++)
                    //  {
                    //      u_anasayfa.operatör_adı[i] = lineac[i];
                    //  }
                        writer.Close();

                    }
                    else
                    {
                        MessageBox.Show("6 operatörden fazla eklenemez ekleme yapmak için operatör siliniz.");
                    }
                    textBox1.Enabled = false;
                    textBox1.BackColor = Color.White;
                    textBox1.Text = "";
                    // simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                    simpleButton2.Appearance.BackColor = Color.Red;
                    simpleButton2.Text = "OPERATÖR TANITMA AKTİF ET";


                }
                else
                {
                    MessageBox.Show("OPERATÖR EKLEMEK İÇİN İŞ BAŞLATILMIŞ OLMALIDIR.");
                }
            

            }
           catch
            {
                MessageBox.Show("Kullanıcı eklenemiyor");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text!="")
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].SubItems[0].Text == textBox1.Text)
                        {
                            listView1.Items.RemoveAt(i);
                        }                   
                    }

                    StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "AktifKullanıcı" + ".txt");
                    for (int yt = 0; yt < listView1.Items.Count; yt++)
                    {
                        u_anasayfa.operatör_adı[yt] = ((listView1.Items[yt].Text).ToString());
                        writer.WriteLine(listView1.Items[yt].SubItems[0].Text);
                    }
                    writer.Close();
                    //   listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
                    textBox1.Enabled = false;
                    textBox1.BackColor = Color.White;
                    textBox1.Text = "";
                    // simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                    simpleButton2.Appearance.BackColor = Color.Red;
                    simpleButton2.Text = "OPERATÖR TANITMA AKTİF ET";
                }
                else
                {
                    MessageBox.Show("AKTİF KULLANICI SİLMEK İÇİN KARTINIZI OKUTUNUZ");
                }
            }
            catch
            {
                MessageBox.Show("AKTİF KULLANICI SİLMEK İÇİN KARTINIZI OKUTUNUZ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ToplamCalisanOperatör.Clear();
                StreamReader sr = new System.IO.StreamReader(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "Kullanıcı" + ".txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    ToplamCalisanOperatör.Items.Add(line.Split(';')[0]);
                }
                int sira = ToplamCalisanOperatör.Items.Count;
                // listView1.Items[sira].SubItems.Add(line.Split(';')[1]);

                sr.Close();
            }
            catch
            {
                MessageBox.Show("OPERATÖR LİSTESİ GÖSTERİLEMİYOR");
            }
            // try
            // {
            //     ToplamCalisanOperatör.Clear();
            //     StreamReader sr = new System.IO.StreamReader(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "Kullanıcı" + ".txt");
            //     string line;
            //
            //     while ((line = sr.ReadLine()) != null)
            //     {
            //         for (int i = 0; i < ToplamCalisanOperatör.Items.Count; i++)
            //         {
            //
            //            if (ToplamCalisanOperatör.Items[i].SubItems[0].Text!=line.ToString())
            //             {
            //                 ToplamCalisanOperatör.Items.Add(line.Split(';')[0]);
            //             }
            //           
            //         }
            //         if (ToplamCalisanOperatör.Items.Count == 0)
            //         {
            //             ToplamCalisanOperatör.Items.Add(line.Split(';')[0]);
            //         }
            //         int sira = ToplamCalisanOperatör.Items.Count;
            //         // listView1.Items[sira].SubItems.Add(line.Split(';')[1]);
            //     }
            //
            //     sr.Close();
            // }
            // catch
            // {
            //     MessageBox.Show("OPERATÖR LİSTESİ GÖSTERİLEMİYOR");
            // }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Şifre.Şifre_ok == false)
            {
                şifreformm.Show();
            }

            if (Şifre.Şifre_ok == true)

            {
           //     string şifre = Interaction.InputBox("", "Operatör Silmek için Şifre Giriniz", "", 200, 200);
           // if (şifre == "100")
           // {

                try
                {
                    if (textBox1.Text != "")
                    {
                        for (int i = 0; i < ToplamCalisanOperatör.Items.Count; i++)
                        {
                            if (ToplamCalisanOperatör.Items[i].SubItems[0].Text == textBox1.Text)
                            {
                                ToplamCalisanOperatör.Items.RemoveAt(i);
                            }
                        }

                        StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "Kullanıcı" + ".txt");
                        for (int y = 0; y < ToplamCalisanOperatör.Items.Count; y++)
                        {
                            writer.WriteLine(ToplamCalisanOperatör.Items[y].SubItems[0].Text);
                        }
                        writer.Close();
                        //   listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
                        textBox1.Enabled = false;
                        textBox1.BackColor = Color.White;
                        textBox1.Text = "";
                        // simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                        simpleButton2.Appearance.BackColor = Color.Red;
                        simpleButton2.Text = "OPERATÖR TANITMA AKTİF ET";
                        şifreformm.Hide();
                        Şifre.Şifre_ok = false;
                    }
                    else
                    {
                        MessageBox.Show("AKTİF KULLANICI SİLMEK İÇİN KARTINIZI OKUTUNUZ");
                    }
                }
                catch
                {
                    MessageBox.Show("AKTİF KULLANICI SİLMEK İÇİN KARTINIZI OKUTUNUZ");
                }
              
            }
           // else if (şifre != "" && şifre != "100")
           // {
           //     MessageBox.Show("HATALI ŞİFRE");
           // }
                    
        }

        private void button6_Click(object sender, EventArgs e)
        {        
            StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "Kullanıcı" + ".txt");
            for (int i = 0; i < ToplamCalisanOperatör.Items.Count; i++)
            {              
                writer.WriteLine(ToplamCalisanOperatör.Items[i].SubItems[0].Text);                
            }                  
            writer.Close();
            MessageBox.Show("OPERATÖR LİSTESİ KAYIT EDİLDİ");
        }
        bool Operatör_var;
        private void button7_Click(object sender, EventArgs e)
        {
            if (Şifre.Şifre_ok == false)
            {
                şifreformm.Show();
            }

            if (Şifre.Şifre_ok == true)

            {



           //     string şifre = Interaction.InputBox("", "Operatör Eklemek için Şifre Giriniz", "", 200, 200);
           // if (şifre == "100")
           // {

                int sira = ToplamCalisanOperatör.Items.Count;
                Operatör_var = false;
                if (textBox1.Text != "")
                {

                    for (int i = 0; i < ToplamCalisanOperatör.Items.Count; i++)
                    {
                        if (ToplamCalisanOperatör.Items[i].SubItems[0].Text == textBox1.Text)
                        {
                            Operatör_var = true;
                        }
                    }


                    if (sira == ToplamCalisanOperatör.Items.Count && Operatör_var == false && ToplamCalisanOperatör.Items.Count != 0)
                    {
                        ToplamCalisanOperatör.Items.Add(textBox1.Text);
                    }
                    else
                    {
                        MessageBox.Show("OPERATÖR LİSTESİNDE MEVCUTTUR");
                    }

                    if (ToplamCalisanOperatör.Items.Count == 0)
                    {
                        ToplamCalisanOperatör.Items.Add(textBox1.Text);
                    }

                    StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "Kullanıcı" + ".txt");
                    for (int y = 0; y < ToplamCalisanOperatör.Items.Count; y++)
                    {
                        writer.WriteLine(ToplamCalisanOperatör.Items[y].SubItems[0].Text);
                    }
                    writer.Close();
                    şifreformm.Hide();
                    Şifre.Şifre_ok = false;
                    textBox1.Enabled = false;
                    textBox1.BackColor = Color.White;
                    textBox1.Text = "";
                    // simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                    simpleButton2.Appearance.BackColor = Color.Red;
                    simpleButton2.Text = "OPERATÖR TANITMA AKTİF ET";
                }
                else
                {
                    MessageBox.Show("OPERATÖR KARTI OKUTARAK EKLEME YAPINIZ");
                }


            }
            // else if (şifre != "" && şifre != "100")
            // {
            //     MessageBox.Show("HATALI ŞİFRE");
            // }

        //    şifreformm.Hide();



        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Focus();
            textBox1.SelectAll();
            textBox1.BackColor = Color.Brown;
            // simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            simpleButton2.Appearance.BackColor = Color.LimeGreen;        
            simpleButton2.Text = "OPERATÖR TANITMA AKTİF";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
               if (Şifre.Şifre_ok == false)
               {
                  şifreformm.Show();
               }
                
               if (Şifre.Şifre_ok == true)

                {
                  //  string şifre = Interaction.InputBox("", "Operatör Eklemek için Şifre Giriniz", "", 200, 200);
                  //  if (şifre == "100")
                  //  {
                        listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
                        StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "AktifKullanıcı" + ".txt");
                        for (int y = 0; y < listView1.Items.Count; y++)
                        {
                            u_anasayfa.operatör_adı[y] = ((listView1.Items[y].Text).ToString());
                            writer.WriteLine(listView1.Items[y].SubItems[0].Text);
                        }
                        writer.Close();
                        //   listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
                        textBox1.Enabled = false;
                        textBox1.BackColor = Color.White;
                        textBox1.Text = "";
                        // simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                        simpleButton2.Appearance.BackColor = Color.Red;
                        simpleButton2.Text = "OPERATÖR TANITMA AKTİF ET";
                    // }
                    // else if (şifre != "" && şifre != "100")
                    // {
                    //     MessageBox.Show("HATALI ŞİFRE");
                    // }
                    şifreformm.Hide();
                    Şifre.Şifre_ok = false;
                }
               
            }
            catch
            {
                MessageBox.Show("AKTİF KULLANICI SİLMEK İÇİN KARTINIZI OKUTUNUZ");
            }
        }

        private void u_grafik_Load(object sender, EventArgs e)
        {
            for (int yz = 0; yz < listView1.Items.Count; yz++)
            {
                u_anasayfa.operatör_adı[yz] = ((listView1.Items[yz].Text).ToString());
                // listView1.Items.Add(u_anasayfa.operatör_adı[y]);
            }
        }

        private void sag_btn_MouseUp(object sender, MouseEventArgs e)
        {
            Anasayfa.writeBit(1, 2, 5, 1);  //sag
        }

        private void sag_btn_MouseDown(object sender, MouseEventArgs e)
        {
            Anasayfa.writeBit(1, 2, 5, 0);  //sag
        }

        private void simpleButton1_MouseUp(object sender, MouseEventArgs e)
        {
            Anasayfa.writeBit(1, 2, 6, 1);  //sol
        }

        private void simpleButton1_MouseDown(object sender, MouseEventArgs e)
        {
            Anasayfa.writeBit(1, 2, 6, 0);  //sol
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Anasayfa.writeBit(1, 2, 7, 1);  //enable sset
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Anasayfa.writeBit(1, 2, 7, 0);  //enable reset
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Anasayfa.writeBit(1, 3, 0, 1);  //trick baslat
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Anasayfa.writeBit(1, 3, 0, 0);  //trick bitir
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            Anasayfa.writeBit(1, 3, 1, 1);  //set
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            Anasayfa.writeBit(1, 3, 1, 0);  //reset
        }
    }
}
