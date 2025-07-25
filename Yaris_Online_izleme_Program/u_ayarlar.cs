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
    public partial class u_ayarlar : UserControl
    {
        public u_ayarlar()
        {
            InitializeComponent(); 
        }
        string txtayar;
        public string gecici_şifre;
        public static string m_iş_başlat_gecici;
        public static string m_iş_bitir_gecici;
        public static string m_barkod_okutma_gecici;
        public void kayıt_dosyasına_ekle()
        {

         //   try
         //   {
                if (lstRecipe.Items.Count < 10000)
                {
                    ListViewItem lstItem = new ListViewItem();


                    //   Convert.ToSingle(textBox1.Text);
                    //   Convert.ToSingle(textBox2.Text);
                    //   Convert.ToSingle(textBox3.Text);
                    //   Convert.ToSingle(textBox4.Text);
                    //   Convert.ToSingle(textBox5.Text);
                    //   Convert.ToSingle(textBox6.Text);
                    //   Convert.ToSingle(textBox7.Text);
                    //   Convert.ToSingle(textBox8.Text);
                    //   Convert.ToSingle(textBox9.Text);
                    //   Convert.ToSingle(textBox10.Text);
                    //   Convert.ToSingle(textBox11.Text);
                    //   Convert.ToSingle(textBox12.Text);
                    //   Convert.ToSingle(textBox13.Text);

                    lstItem.Text = (lstRecipe.Items.Count + 1).ToString();
                    lstItem.SubItems.Add(textBox1.Text);
                    lstItem.SubItems.Add(textBox2.Text);
                    lstItem.SubItems.Add(textBox3.Text);
                    lstItem.SubItems.Add((u_anasayfa.M_Pres_1_iş_bitirme_zamanı_Gün + "." + u_anasayfa.M_Pres_1_iş_bitirme_zamanı_Ay + "." + u_anasayfa.M_Pres_1_iş_bitirme_zamanı_Yıl + " " + u_anasayfa.M_Pres_1_iş_bitirme_zamanı_saat + ":" + u_anasayfa.M_Pres_1_iş_bitirme_zamanı_DK).ToString());
                    lstItem.SubItems.Add(textBox5.Text);
                    lstItem.SubItems.Add(textBox6.Text);
                    lstItem.SubItems.Add(textBox7.Text);
                    lstItem.SubItems.Add(textBox8.Text);
                    lstItem.SubItems.Add(textBox9.Text);
                    lstItem.SubItems.Add(textBox10.Text);
                    lstItem.SubItems.Add(textBox11.Text);
                    lstItem.SubItems.Add(textBox12.Text);
                    lstItem.SubItems.Add(textBox13.Text);
                    lstItem.SubItems.Add(textBox27.Text);
                    lstItem.SubItems.Add(textBox28.Text);
                    lstItem.SubItems.Add(textBox30.Text);
                    lstItem.SubItems.Add(textBox31.Text);
                    lstItem.SubItems.Add(textBox35.Text);
                    lstItem.SubItems.Add(textBox37.Text);
                    lstItem.SubItems.Add(textBox38.Text);
                    lstItem.SubItems.Add(textBox39.Text);
                    lstItem.SubItems.Add(textBox40.Text);
                    lstItem.SubItems.Add(textBox41.Text);
                    lstItem.SubItems.Add(textBox42.Text);
                    lstRecipe.Items.Add(lstItem);


               
                recipeKaydet(Properties.Settings.Default.SON_SECILEN_RECETE);
                //recipeKaydet("Yarış Kayıt Dosyası");
                //    recipeOku("Yarış Kayıt Dosyası");
                m_iş_başlat_gecici = "m_iş_başlat_gecici";
                m_iş_bitir_gecici = "m_iş_bitir_gecici";
                m_barkod_okutma_gecici = "m_iş_bitir_gecici";

            }
                else
                {
                    MessageBox.Show("Maksimum 10000 adımlık kayıt yapılabilir!");
                }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Değerleri kontrol ediniz!");
        //    }




        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstRecipe.Items.Count < 10000)
                {
                    ListViewItem lstItem1 = new ListViewItem();


                    //   Convert.ToSingle(textBox1.Text);
                    //   Convert.ToSingle(textBox2.Text);
                    //   Convert.ToSingle(textBox3.Text);
                    //   Convert.ToSingle(textBox4.Text);
                    //   Convert.ToSingle(textBox5.Text);
                    //   Convert.ToSingle(textBox6.Text);
                    //   Convert.ToSingle(textBox7.Text);
                    //   Convert.ToSingle(textBox8.Text);
                    //   Convert.ToSingle(textBox9.Text);
                    //   Convert.ToSingle(textBox10.Text);
                    //   Convert.ToSingle(textBox11.Text);
                    //   Convert.ToSingle(textBox12.Text);
                    //   Convert.ToSingle(textBox13.Text);
                    lstItem1.Text = (lstRecipe.Items.Count + 1).ToString();
                    lstItem1.SubItems.Add(textBox1.Text);
                    lstItem1.SubItems.Add(textBox2.Text);
                    lstItem1.SubItems.Add(textBox3.Text);
                    lstItem1.SubItems.Add(textBox4.Text);
                    lstItem1.SubItems.Add(textBox5.Text);
                    lstItem1.SubItems.Add(textBox6.Text);
                    lstItem1.SubItems.Add(textBox7.Text);
                    lstItem1.SubItems.Add(textBox8.Text);
                    lstItem1.SubItems.Add(textBox9.Text);
                    lstItem1.SubItems.Add(textBox10.Text);
                    lstItem1.SubItems.Add(textBox11.Text);
                    lstItem1.SubItems.Add(textBox12.Text);
                    lstItem1.SubItems.Add(textBox13.Text);
                    lstItem1.SubItems.Add(textBox27.Text);
                    lstItem1.SubItems.Add(textBox28.Text);
                    lstItem1.SubItems.Add(textBox30.Text);
                    lstItem1.SubItems.Add(textBox31.Text);
                    lstItem1.SubItems.Add(textBox35.Text);
                    lstItem1.SubItems.Add(textBox37.Text);
                    lstItem1.SubItems.Add(textBox38.Text);
                    lstItem1.SubItems.Add(textBox39.Text);
                    lstItem1.SubItems.Add(textBox40.Text);
                    lstItem1.SubItems.Add(textBox41.Text);
                    lstItem1.SubItems.Add(textBox42.Text);

                    lstRecipe.Items.Add(lstItem1);




                }
                else
                {
                    MessageBox.Show("Maksimum 10000 adımlık kayıt yapılabilir!");
                }                
            }
            catch 
            {
                MessageBox.Show("Değerleri kontrol ediniz!");
            }            
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
        private void lstRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = lstRecipe.SelectedItems[0].SubItems[0].Text;                
                textBox14.Text = lstRecipe.SelectedItems[0].SubItems[1].Text;
                textBox15.Text = lstRecipe.SelectedItems[0].SubItems[2].Text;
                textBox16.Text = lstRecipe.SelectedItems[0].SubItems[3].Text;
                textBox17.Text = lstRecipe.SelectedItems[0].SubItems[4].Text;
                textBox18.Text = lstRecipe.SelectedItems[0].SubItems[5].Text;
                textBox19.Text = lstRecipe.SelectedItems[0].SubItems[6].Text;
                textBox20.Text = lstRecipe.SelectedItems[0].SubItems[7].Text;
                textBox21.Text = lstRecipe.SelectedItems[0].SubItems[8].Text;
                textBox22.Text = lstRecipe.SelectedItems[0].SubItems[9].Text;
                textBox23.Text=  lstRecipe.SelectedItems[0].SubItems[10].Text;
                textBox24.Text=  lstRecipe.SelectedItems[0].SubItems[11].Text;
                textBox25.Text=  lstRecipe.SelectedItems[0].SubItems[12].Text;
                textBox26.Text=  lstRecipe.SelectedItems[0].SubItems[13].Text;
                textBox29.Text = lstRecipe.SelectedItems[0].SubItems[14].Text;
                textBox32.Text = lstRecipe.SelectedItems[0].SubItems[15].Text;
                textBox33.Text = lstRecipe.SelectedItems[0].SubItems[16].Text;
                textBox34.Text = lstRecipe.SelectedItems[0].SubItems[17].Text;
                textBox36.Text = lstRecipe.SelectedItems[0].SubItems[18].Text;
                textBox43.Text = lstRecipe.SelectedItems[0].SubItems[19].Text;
                textBox44.Text = lstRecipe.SelectedItems[0].SubItems[20].Text;
                textBox45.Text = lstRecipe.SelectedItems[0].SubItems[21].Text;
                textBox46.Text = lstRecipe.SelectedItems[0].SubItems[22].Text;
                textBox47.Text = lstRecipe.SelectedItems[0].SubItems[23].Text;
                textBox48.Text = lstRecipe.SelectedItems[0].SubItems[24].Text;

            }
            catch 
            { 
            }           
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {              
        
             //  Convert.ToSingle(textBox14.Text);
             //  Convert.ToSingle(textBox15.Text);
             //  Convert.ToSingle(textBox16.Text);
             //  Convert.ToSingle(textBox17.Text);
             //  Convert.ToSingle(textBox18.Text);
             //  Convert.ToSingle(textBox19.Text);
             //  Convert.ToSingle(textBox20.Text);
             //  Convert.ToSingle(textBox21.Text);
             //  Convert.ToSingle(textBox22.Text);
             //  Convert.ToSingle(textBox23.Text);
             //  Convert.ToSingle(textBox24.Text);
             //  Convert.ToSingle(textBox25.Text);
             //  Convert.ToSingle(textBox26.Text);
             //  Convert.ToSingle(textBox29.Text);
             //  Convert.ToSingle(textBox32.Text);
             //  Convert.ToSingle(textBox33.Text);
             //  Convert.ToSingle(textBox34.Text);
                try
                {


                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[1].Text =  textBox14.Text;    // db5 544
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[2].Text =  textBox15.Text;    // db5 552
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[3].Text =  textBox16.Text;    // db5 560
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[4].Text =  textBox17.Text;    // db5 568
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[5].Text =  textBox18.Text;    // db5 576
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[6].Text =  textBox19.Text;    // db5 584
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[7].Text =  textBox20.Text;    // db5 588
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[8].Text =  textBox21.Text;    // db5 592
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[9].Text = textBox22.Text;    // db5 596
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[10].Text = textBox23.Text;    // db5 600
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[11].Text = textBox24.Text;    // db5 608
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[12].Text = textBox25.Text;    // db5 612
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[13].Text = textBox26.Text;    // db5 612
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[14].Text = textBox29.Text;    // db5 612
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[15].Text = textBox32.Text;    // db5 612
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[16].Text = textBox33.Text;    // db5 612
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[17].Text = textBox34.Text;    // db5 612
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[18].Text = textBox36.Text;
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[19].Text = textBox43.Text;
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[20].Text = textBox44.Text;
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[21].Text = textBox45.Text;
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[22].Text = textBox46.Text;
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[23].Text = textBox47.Text;
                    lstRecipe.Items[Convert.ToInt32(txtID.Text) - 1].SubItems[24].Text = textBox48.Text;

                    // recipeKaydet("Yarış Kayıt Dosyası");
                    recipeKaydet(txtRecipeName.Text);
                    MessageBox.Show("KAYIT GÜNCELLENDİ");

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
         private void u_ayarlar_Click(object sender, EventArgs e)
         {
             //lstReceteler.Strings.Clear();
             string[] paths = Directory.GetFiles(Directory.GetCurrentDirectory() + "//Recipe");
             for (int i = 0; i < paths.Length; i++)
             {
                 paths[i] = paths[i].Replace(Directory.GetCurrentDirectory() + "//Recipe", "").Replace(".skt", "").Replace("\\", "");
             }
            // lstReceteler.Strings.AddRange(paths);
            // popupMenu1.ShowPopup(Cursor.Position);
         }
         private void btnRecete_Click(object sender, EventArgs e)
         {
             frmRecete frm = new frmRecete();
             frm.Show();
         }
         public void recipeKaydet(string recipeName)
         {
                 string[,] receteDegerler = new string[10000,25];
                 string yazi = "";
                 for (int i = 0; i < lstRecipe.Items.Count; i++)
                 {
                     for (int j = 0; j < 25; j++)
                     {
                         receteDegerler[i,j] = lstRecipe.Items[i].SubItems[j].Text;
                     }
                 }
                 for (int i = 0; i < lstRecipe.Items.Count; i++)
                 {
                     for (int j = 0; j < 25; j++)
                     {
                         if (j < 25)
                         {
                             yazi += receteDegerler[i, j] + "$";
                         }
                         else
                         {
                             yazi += receteDegerler[i, j];
                         }
                     }
                     if (i < lstRecipe.Items.Count - 1)
                     {
                         yazi += Environment.NewLine;
                     }
                     else
                     { 

                     }
                 }

           // File.WriteAllText(Directory.GetCurrentDirectory() + "\\Recipe\\" + recipeName + ".skt", yazi);
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\Recipe\\" + recipeName + ".skt", yazi);

            
         }
         public void recipeOku(string recipeName)
         {
             lstRecipe.Items.Clear();
             string[,] receteDegerler = new string[10000, 30];
             string[] yazi = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Recipe\\" + recipeName + ".skt");
             string[] vals = new string[30];
             for (int i = 0; i < yazi.Length; i++)
             {
                 vals = yazi[i].Split('$');
                 for (int j = 0; j < 25; j++)
                 {
                     receteDegerler[i,j] = vals[j];
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

                lstRecipe.Items.Add(lstItem);
                            }
                            txtRecipeName.Text = recipeName;
                            Properties.Settings.Default.SON_SECILEN_RECETE = recipeName;
                            Properties.Settings.Default.Save();

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
                                for (int j = 0; j < 62; j++)
                                {
                                    if (j == 62)
                                    {
                                        //     vals[(i * 10) + (j)] = 0;                      
                                    }                                     
                                    else
                                    {
                                        //string[] adres = (sender as DevExpress.XtraEditors.SimpleButton).Tag.ToString().Split('.');
                                        //VALUESReal[j]= Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text);

                                        //string[] str = (lstRecipe.Items[i].SubItems[j].Text.Split('.'));

                                        if (j == 1) { VALUESReal[0] =Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(88, VALUESReal); }              //22 db5 88
                                        else if (j == 2) { VALUESReal[0] =Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(92, VALUESReal); }         //23 db5 92
                                        else if (j == 3) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(96, VALUESReal); }         //24 db5 96
                                        else if (j == 4) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(100, VALUESReal); }         //25 db5 100
                                        else if (j == 5) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(112, VALUESReal); }         //28 db5 112
                                        else if (j == 6) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(116, VALUESReal); }         //29 db5 116
                                        else if (j == 7) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(124, VALUESReal); }         //31 db5 124
                                        else if (j == 8) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(120, VALUESReal); }         //30 db5 120
                                        else if (j == 9) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(128, VALUESReal); }         //32 db5 128
                                        else if (j == 10) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(176, VALUESReal); }        //44 db5 176
                                        else if (j == 11) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(180, VALUESReal); }        //45 db5 180
                                                                                                                                                                                                    
                                    //    else if (j == 23) { VALUESDint[0] = Convert.ToInt32(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writedint(8, VALUESDint); }          //2 db28 8
                                    //    else if (j == 24) { VALUESDint[0] = Convert.ToInt32(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writedint(16, VALUESDint); }          //4 db28 16
                                    //    else if (j == 25) { VALUESDint[0] = Convert.ToInt32(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writedint(12, VALUESDint); }          //3 db28 12
                                    //    else if (j == 26) { VALUESDint[0] = Convert.ToInt32(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writedint(0, VALUESDint); }          //0 db28 0
                                    //    else if (j == 27) { VALUESDint[0] = Convert.ToInt32(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writedint(4, VALUESDint); }          //1 db28 4
                                    //    else if (j == 28) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(208, VALUESReal); }        //52 db5  208 
                                    //    else if (j == 29) { VALUESint[0] = Convert.ToInt16(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeint(20, VALUESint); }            //10 db27 20
                                    //    else if (j == 30) { VALUESint[0] = Convert.ToInt16(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeint(28, VALUESint); }            //14 db27 28
                                    //    else if (j == 31) { VALUESReal[0] = Convert.ToSingle(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeReal(212, VALUESReal); }        //53 db5  212 
                                    //    else if (j == 32) { VALUESint[0] = Convert.ToInt16(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeint(42, VALUESint); }            //21 db27 42
                                    //    else if (j == 33) { VALUESint[0] = Convert.ToInt16(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writeint(50, VALUESint); }            //25 db27 50
                                    //    else if (j == 34) { VALUESDint[0] = Convert.ToInt32(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writedint(36, VALUESDint); }          //9 db28 36
                                    //    else if (j == 35) { VALUESDint[0] = Convert.ToInt32(lstRecipe.Items[i].SubItems[j].Text); Anasayfa.writedint(40, VALUESDint); }
                                        
                                                    // db5 668
                
            }
        }                      
                                    }
                                   // Anasayfa.receteYukle(vals);
                                    Properties.Settings.Default.SON_YUKLENEN_RECETE = txtRecipeName.Text;
                                    txtSonYuklenenRecete.Text = txtRecipeName.Text;
                                    Properties.Settings.Default.Save();
                                }
                    private void btnTumunuSil_Click(object sender, EventArgs e)
                                {
                                    lstRecipe.Items.Clear();
                                }
                    private void u_ayarlar_Load(object sender, EventArgs e)
                       {
           
                    txtRecipeName.Text = Properties.Settings.Default.SON_SECILEN_RECETE;
                    //  txtRecipeName.Text = "Yarış Kayıt Dosyası";
                   //  txtSonYuklenenRecete.Text = Properties.Settings.Default.SON_YUKLENEN_RECETE;
                   //  recipeOku();
            try
                    {
                      lstRecipe.Items.Clear();
                      string[,] receteDegerler = new string[10000, 25];
                      string[] yazi = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Recipe\\" + txtRecipeName.Text + ".skt");
                      string[] vals = new string[15];
                      for (int i = 0; i < yazi.Length; i++)
                      {
                          vals = yazi[i].Split('$');
                          for (int j = 0; j < 25; j++)
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
                          lstRecipe.Items.Add(lstItem);
                 }

            }
            catch 
           {
                MessageBox.Show("Kayıt dosyası açılmadı");
           }
            
           }

        private void plckontrol_Tick(object sender, EventArgs e)
        {
            if (Anasayfa.actPage == "u_ayarlar")
            {
                if (u_anasayfa.M_Pres_1_Pres_izin_Aktif_Pasif ==true)
                    {

                    M_Pres_1_izin_aktif_pasif_Btn.Text = "PRES İZİN AKTİF";
                   // M_Pres_1_izin_aktif_pasif_Btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                    M_Pres_1_izin_aktif_pasif_Btn.Appearance.BackColor = Color.DarkGreen;
                    M_Pres_1_izin_aktif_pasif_Btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
                    M_Pres_1_izin_aktif_pasif_Btn.AppearancePressed.Options.UseFont = true;
                }
                else
                {
                    M_Pres_1_izin_aktif_pasif_Btn.Text = "PRES İZİN PASİF";
                    // M_Pres_1_izin_aktif_pasif_Btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                    M_Pres_1_izin_aktif_pasif_Btn.Appearance.BackColor = Color.Red;
                    M_Pres_1_izin_aktif_pasif_Btn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
                    M_Pres_1_izin_aktif_pasif_Btn.AppearancePressed.Options.UseFont = true;
                }


               string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "AktifKullanıcı" + ".txt");
               int countrz = lines.Count();
              
               int i;
               for (i = 0; i < countrz; i++)
               {
                   u_anasayfa.operatör_adı[i] = lines[i];
               }
             

                for (int t = countrz; t < 6; t++)
                {
                    u_anasayfa.operatör_adı[t] = "";
                }

            //    try
            //    {
            //        if (u_anasayfa.<M_Pres_1_iş_başlat == false)
            //        {                       
            //            StreamWriter writerr = new StreamWriter(Directory.GetCurrentDirectory() + "\\Kullanıcılar\\" + "AktifKullanıcı" + ".txt");
            //            writerr.WriteLine("");                        
            //            writerr.Close();
            //        }
            //    }
            //    catch
            //    {
            //        MessageBox.Show("OPERATÖR LİSTESİ SİLİNEMİYOR");
            //    }

                gecici_şifre = "gecici_şifre";
            }
            else
            {
                if (gecici_şifre == "gecici_şifre")
                {
                    Şifre.Şifre_ok = false;
                   
                    gecici_şifre = "";
                }
               
            }
         
            
            if (u_anasayfa.M_Pres_1_iş_bitir == true & m_iş_bitir_gecici == "m_iş_bitir_gecici")
            {
                m_iş_bitir_gecici = "";
                textBox4.Text = (u_anasayfa.M_Pres_1_iş_bitirme_zamanı_Gün + "." + u_anasayfa.M_Pres_1_iş_bitirme_zamanı_Ay + "." + u_anasayfa.M_Pres_1_iş_bitirme_zamanı_Yıl + " " + u_anasayfa.M_Pres_1_iş_bitirme_zamanı_saat + ":" + u_anasayfa.M_Pres_1_iş_bitirme_zamanı_DK).ToString();
            }

                        
            textBox2.Text = (u_anasayfa.M_Pres_1_Barkod_Okutma_Gün + "." + u_anasayfa.M_Pres_1_Barkod_Okutma_Ay + "." + u_anasayfa.M_Pres_1_Barkod_Okutma_Yıl + " " + u_anasayfa.M_Pres_1_Barkod_Okutma_Saat + ":" + u_anasayfa.M_Pres_1_Barkod_Okutma_Dk).ToString();
            textBox3.Text = (u_anasayfa.M_Pres_1_iş_başlama_zamanı_Gün + "." + u_anasayfa.M_Pres_1_iş_başlama_zamanı_Ay + "." + u_anasayfa.M_Pres_1_iş_başlama_zamanı_Yıl + " " + u_anasayfa.M_Pres_1_iş_başlama_zamanı_saat + ":" + u_anasayfa.M_Pres_1_iş_başlama_zamanı_Dk).ToString();
            textBox1.Text = u_anasayfa.M_Pres_1_Barkod_Okuma_Sipariş_Kayıt_String;
            textBox5.Text = (u_anasayfa.M_Pres_1_iş_toplam_zaman / 3600) + " S " + ((u_anasayfa.M_Pres_1_iş_toplam_zaman) - (3600 * (u_anasayfa.M_Pres_1_iş_toplam_zaman / 3600))) / 60 + " dk " + (u_anasayfa.M_Pres_1_iş_toplam_zaman - (60 * (u_anasayfa.M_Pres_1_iş_toplam_zaman / 60))) + " sn";
            //  textBox6.Text = u_anasayfa.M_Pres_1_Forklift_Bekleme_Toplam_Zaman.ToString();   
            textBox6.Text = (u_anasayfa.M_Pres_1_Forklift_Bekleme_Toplam_Zaman / 3600) + " S " + ((u_anasayfa.M_Pres_1_Forklift_Bekleme_Toplam_Zaman) - (3600 * (u_anasayfa.M_Pres_1_Forklift_Bekleme_Toplam_Zaman / 3600))) / 60 + " dk " + (u_anasayfa.M_Pres_1_Forklift_Bekleme_Toplam_Zaman - (60 * (u_anasayfa.M_Pres_1_Forklift_Bekleme_Toplam_Zaman / 60))) + " sn";
            textBox7.Text = (u_anasayfa.M_Pres_1_Parça_Bekleme_Toplam_Zaman / 3600) + " S " + ((u_anasayfa.M_Pres_1_Parça_Bekleme_Toplam_Zaman) - (3600 * (u_anasayfa.M_Pres_1_Parça_Bekleme_Toplam_Zaman / 3600))) / 60 + " dk " + (u_anasayfa.M_Pres_1_Parça_Bekleme_Toplam_Zaman - (60 * (u_anasayfa.M_Pres_1_Parça_Bekleme_Toplam_Zaman / 60))) + " sn";           
            textBox8.Text = (u_anasayfa.M_Pres_1_Kalite_Onay_Toplam_Zaman / 3600) + " S " + ((u_anasayfa.M_Pres_1_Kalite_Onay_Toplam_Zaman) - (3600 * (u_anasayfa.M_Pres_1_Kalite_Onay_Toplam_Zaman / 3600))) / 60 + " dk " + (u_anasayfa.M_Pres_1_Kalite_Onay_Toplam_Zaman - (60 * (u_anasayfa.M_Pres_1_Kalite_Onay_Toplam_Zaman / 60))) + " sn";           
            textBox9.Text = (u_anasayfa.M_Pres_1_Setup_Toplam_Zaman / 3600) + " S " + ((u_anasayfa.M_Pres_1_Setup_Toplam_Zaman) - (3600 * (u_anasayfa.M_Pres_1_Setup_Toplam_Zaman / 3600))) / 60 + " dk " + (u_anasayfa.M_Pres_1_Setup_Toplam_Zaman - (60 * (u_anasayfa.M_Pres_1_Setup_Toplam_Zaman / 60))) + " sn";
            textBox10.Text = (u_anasayfa.M_Pres_1_Arıza_Toplam_Zaman / 3600) + " S " + ((u_anasayfa.M_Pres_1_Arıza_Toplam_Zaman) - (3600 * (u_anasayfa.M_Pres_1_Arıza_Toplam_Zaman / 3600))) / 60 + " dk " + (u_anasayfa.M_Pres_1_Arıza_Toplam_Zaman - (60 * (u_anasayfa.M_Pres_1_Arıza_Toplam_Zaman / 60))) + " sn";
            textBox11.Text = (u_anasayfa.M_Pres_1_Mola_Yemek_Toplam_Zaman / 3600) + " S " + ((u_anasayfa.M_Pres_1_Mola_Yemek_Toplam_Zaman) - (3600 * (u_anasayfa.M_Pres_1_Mola_Yemek_Toplam_Zaman / 3600))) / 60 + " dk " + (u_anasayfa.M_Pres_1_Mola_Yemek_Toplam_Zaman - (60 * (u_anasayfa.M_Pres_1_Mola_Yemek_Toplam_Zaman / 60))) + " sn";
            textBox12.Text = (u_anasayfa.M_Pres_1_WC_Toplam_Zaman / 3600) + " S " + ((u_anasayfa.M_Pres_1_WC_Toplam_Zaman) - (3600 * (u_anasayfa.M_Pres_1_WC_Toplam_Zaman / 3600))) / 60 + " dk " + (u_anasayfa.M_Pres_1_WC_Toplam_Zaman - (60 * (u_anasayfa.M_Pres_1_WC_Toplam_Zaman / 60))) + " sn";
            textBox13.Text = (u_anasayfa.M_Pres_1_Kalıp_Arıza_Toplam_Zaman / 3600) + " S " + ((u_anasayfa.M_Pres_1_Kalıp_Arıza_Toplam_Zaman) - (3600 * (u_anasayfa.M_Pres_1_Kalıp_Arıza_Toplam_Zaman / 3600))) / 60 + " dk " + (u_anasayfa.M_Pres_1_Kalıp_Arıza_Toplam_Zaman - (60 * (u_anasayfa.M_Pres_1_Kalıp_Arıza_Toplam_Zaman / 60))) + " sn";
            textBox27.Text = u_anasayfa.M_Pres_1_Basılan_Parça_Adedi.ToString();
            textBox28.Text = u_anasayfa.M_Pres_1_Parça_Üretim_Süresi.ToString();
            textBox30.Text = u_anasayfa.M_Pres_1_Makina_Performansı.ToString();
            textBox31.Text = u_anasayfa.M_Pres_1_Operatör_Performansı.ToString();
            textBox35.Text = u_anasayfa.M_Pres_1_Hurda_Adeti.ToString();
            
            textBox37.Text = u_anasayfa.operatör_adı[0];
            textBox38.Text = u_anasayfa.operatör_adı[1];
            textBox39.Text = u_anasayfa.operatör_adı[2];
            textBox40.Text = u_anasayfa.operatör_adı[3];
            textBox41.Text = u_anasayfa.operatör_adı[4];
            textBox42.Text = u_anasayfa.operatör_adı[5];

            if (u_anasayfa.M_Pres_1_Barkod_Okuma_Yapıldı)
            { textBox1.BackColor = Color.LimeGreen;}
            else
            {textBox1.BackColor = Color.White;}
            if (u_anasayfa.M_Pres_1_iş_başlat)
            { textBox3.BackColor = Color.LimeGreen; }
            else
            { textBox3.BackColor = Color.White; }
            if (u_anasayfa.M_Pres_1_Forklift_Bekleme_Başlat)
            { textBox6.BackColor = Color.LimeGreen; }
            else
            { textBox6.BackColor = Color.White; }
            if (u_anasayfa.M_Pres_1_Parça_Bekleme_Başlat)
            { textBox7.BackColor = Color.LimeGreen; }
            else
            { textBox7.BackColor = Color.White; }
            if (u_anasayfa.M_Pres_1_Kalite_Onay_Başlat)
            { textBox8.BackColor = Color.LimeGreen; }
            else
            { textBox8.BackColor = Color.White; }
            if (u_anasayfa.M_Pres_1_Setup_Başlat)
            { textBox9.BackColor = Color.LimeGreen; }
            else
            { textBox9.BackColor = Color.White; }
            if (u_anasayfa.M_Pres_1_Arıza_Başlat)
            { textBox10.BackColor = Color.LimeGreen; }
            else
            { textBox10.BackColor = Color.White; }
            if (u_anasayfa.M_Pres_1_Mola_Yemek_Başlat)
            { textBox11.BackColor = Color.LimeGreen; }
            else
            { textBox11.BackColor = Color.White; }
            if (u_anasayfa.M_Pres_1_WC_Başlat)
            { textBox12.BackColor = Color.LimeGreen; }
            else
            { textBox12.BackColor = Color.White; }
            if (u_anasayfa.M_Pres_1_Kalıp_Arıza_Başlat)
            { textBox13.BackColor = Color.LimeGreen; }
            else
            { textBox13.BackColor = Color.White; }









            //   TimeSpan is_Sonuc = u_anasayfa.M_Pres_1_iş_bitirme_zamanı - u_anasayfa.M_Pres_1_iş_başlama_zamanı;
            //   u_anasayfa.M_Pres_1_iş_toplam_zaman = (Math.Round(is_Sonuc.TotalHours,2).ToString()) + " ;" + (Math.Round(is_Sonuc.TotalMinutes,2).ToString());


            //  digitalGauge37.Text = Math.Round(Anasayfa.readFloat[10], 3).ToString();      //data block 5 byte 40.0 Ortak_Vakum_VP
            //  digitalGauge36.Text = Math.Round(Anasayfa.readFloat[11], 3).ToString();      //data block 5 byte 44.0 Torba_Basınc_1_Göz_VP
            //  digitalGauge35.Text = Math.Round(Anasayfa.readFloat[12], 3).ToString();      //data block 5 byte 48.0 Torba_Basınc_2_Göz_VP
            //  digitalGauge9.Text = Math.Round(Anasayfa.readFloat[13], 3).ToString();       //data block 5 byte 52.0 Torba_Basınc_3_Göz_VP
            //  digitalGauge33.Text = Math.Round(Anasayfa.readFloat[14], 3).ToString();      //data block 5 byte 56.0 Torba_Basınc_4_Göz_VP 
            //
            //  digitalGauge43.Text = Hmı_Malafa_Rezerv_1_Cap_Degeri_Gir.ToString();
            //  digitalGauge44.Text = Hmı_Malafa_Rezerv_2_Cap_Degeri_Gir.ToString();
            //  digitalGauge45.Text = Hmı_Malafa_Rezerv_3_Cap_Degeri_Gir.ToString();
            //  digitalGauge46.Text = Hmı_Malafa_Rezerv_4_Cap_Degeri_Gir.ToString();
            //  digitalGauge47.Text = Hmı_Malafa_Rezerv_5_Cap_Degeri_Gir.ToString();
            //
            //  digitalGauge15.Text = Hmı_Sıyırma_1_Göz_Aktif_Cap_Ölcüsü.ToString();
            //  digitalGauge16.Text = Hmı_Sıyırma_2_Göz_Aktif_Cap_Ölcüsü.ToString();
            //  digitalGauge17.Text = Hmı_Sıyırma_3_Göz_Aktif_Cap_Ölcüsü.ToString();
            //  digitalGauge18.Text = Hmı_Sıyırma_4_Göz_Aktif_Cap_Ölcüsü.ToString();
            //
            //  digitalGauge42.Text = Math.Round(Hmı_Vulkanizasyon_Presi_1_Göz_Cap_Degeri_Gir, 5).ToString();
            //  digitalGauge52.Text = Math.Round(Hmı_Vulkanizasyon_Presi_2_Göz_Cap_Degeri_Gir, 5).ToString();
            //  digitalGauge54.Text = Math.Round(Hmı_Vulkanizasyon_Presi_3_Göz_Cap_Degeri_Gir, 5).ToString();
            //  digitalGauge53.Text = Math.Round(Hmı_Vulkanizasyon_Presi_4_Göz_Cap_Degeri_Gir, 5).ToString();
            //
            //  { digitalGauge21.Text = Hmı_1_Tahliye_Süresi_Aktüel_VP / 60 + " dk " + (Hmı_1_Tahliye_Süresi_Aktüel_VP - (60 * (Hmı_1_Tahliye_Süresi_Aktüel_VP / 60))) + " sn"; }
            //  { digitalGauge22.Text = Hmı_Buhar_Süresi_Aktüel_VP / 60 + " dk " + (Hmı_Buhar_Süresi_Aktüel_VP - (60 * (Hmı_Buhar_Süresi_Aktüel_VP / 60))) + " sn"; }
            //  { digitalGauge23.Text = Hmı_2_Tahliye_Süresi_Aktüel_VP / 60 + " dk " + (Hmı_2_Tahliye_Süresi_Aktüel_VP - (60 * (Hmı_2_Tahliye_Süresi_Aktüel_VP / 60))) + " sn"; }
            //  { digitalGauge24.Text = Hmı_Vakum_Süresi_Aktüel_VP / 60 + " dk " + (Hmı_Vakum_Süresi_Aktüel_VP - (60 * (Hmı_Vakum_Süresi_Aktüel_VP / 60))) + " sn"; }
            if (Anasayfa.actPage == "u_ayarlar")         
            {
                if (txtayar== "txtayar")
                {txtayar = "";
                 recipeOku(txtRecipeName.Text);}
            }
            else
            {
                txtayar = "txtayar";
            }

            if (Anasayfa.actPage == "u_ayarlar")
            {

                digitalGauge7.Text = (u_anasayfa.M_Pres_1_Forklift_Bekleme_Başlama_Zamanı.ToString());
                digitalGauge1.Text = (u_anasayfa.M_Pres_1_Forklift_Bekleme_Bitirme_zamanı.ToString());
                digitalGauge2.Text = (u_anasayfa.M_Pres_1_Parça_Bekleme_Başlama_Zamanı.ToString());
                digitalGauge3.Text = (u_anasayfa.M_Pres_1_Parça_Bekleme_Bitirme_zamanı.ToString());
                digitalGauge4.Text = (u_anasayfa.M_Pres_1_Kalite_Onay_Başlama_Zamanı.ToString());
                digitalGauge5.Text = (u_anasayfa.M_Pres_1_Kalite_Onay_Bitirme_zamanı.ToString());
                digitalGauge6.Text = (u_anasayfa.M_Pres_1_Setup_Başlama_Zamanı.ToString());
                digitalGauge8.Text = (u_anasayfa.M_Pres_1_Setup_Bitirme_zamanı.ToString());
                digitalGauge9.Text = (u_anasayfa.M_Pres_1_Arıza_Başlama_Zamanı.ToString());
                digitalGauge10.Text = (u_anasayfa.M_Pres_1_Arıza_Bitirme_zamanı.ToString());
                digitalGauge11.Text = (u_anasayfa.M_Pres_1_Mola_Yemek_Başlama_Zamanı.ToString());
                digitalGauge12.Text = (u_anasayfa.M_Pres_1_Mola_Yemek_Bitirme_zamanı.ToString());
                digitalGauge13.Text = (u_anasayfa.M_Pres_1_WC_Başlama_Zamanı.ToString());
                digitalGauge14.Text = (u_anasayfa.M_Pres_1_WC_Bitirme_zamanı.ToString());
                digitalGauge15.Text = (u_anasayfa.M_Pres_1_Kalıp_Arıza_Başlama_Zamanı.ToString());
                digitalGauge16.Text = (u_anasayfa.M_Pres_1_Kalıp_Arıza_Bitirme_zamanı.ToString());

                if (u_anasayfa.M_Pres_1_Makina_Performansı <= 100)
                {
                    arcScaleComponent2.Value = u_anasayfa.M_Pres_1_Makina_Performansı;
                    labelComponent2.Text = u_anasayfa.M_Pres_1_Makina_Performansı.ToString();
                }
                else
                {
                    arcScaleComponent2.Value = 100;
                    labelComponent2.Text = "100";
                }

                if (u_anasayfa.M_Pres_1_Operatör_Performansı <= 100)
                {
                    arcScaleComponent3.Value = u_anasayfa.M_Pres_1_Operatör_Performansı;
                    labelComponent4.Text = u_anasayfa.M_Pres_1_Operatör_Performansı.ToString();
                }
                else
                {
                    arcScaleComponent3.Value = 100;
                    labelComponent4.Text = "100";
                }
            }

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_Click(object sender, EventArgs e)
        {
            frmKlavye frm = new frmKlavye((sender as TextBox).Text, (sender as TextBox).Tag.ToString());
            frm.Show();
        }

       

        private void M_Pres_1_izin_aktif_pasif_Btn_Click(object sender, EventArgs e)
        {
            if (u_anasayfa.M_Pres_1_Pres_izin_Aktif_Pasif == true)
            {
                Anasayfa.writeBit(1, 2, 5, 0);  //pres 1 kalite onay başlat 
               
                //textBox5.Text= DateTime.Now.ToLongTimeString();
            }
            else
            {
                Anasayfa.writeBit(1, 2, 5, 1);  //pres 1 kalite onay başlat             
               
            }
        }
    }
}
