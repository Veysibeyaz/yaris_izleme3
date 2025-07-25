using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Yaris_Online_izleme_Programı
{  
    public partial class frmKlavye : Form
    {
        string dbAdres, value;

        public frmKlavye(string val, string db)
        {
            InitializeComponent();
            dbAdres = db;
            value = val;
        }
        private void btnNu(object sender, EventArgs e)
        {
            txtYazi.Text += (sender as Button).Text;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button13_Click(object sender, EventArgs e)
        {        
            try
            {
                float[] VALUESReal = new float[1];
                int[] VALUESDint = new int[1];
                int[] VALUESint = new int[1];                             
                                                      
                   
                                   
                //Anasayfa.writeReal(Convert.ToUInt16(dbAdres.Split('.')[1]), VALUESReal);
              //  if (dbAdres.Split('.')[0] == "R")
              //    {
              //      VALUESReal[0] = Convert.ToSingle(txtYazi.Text);
              //      Anasayfa.writeReal(Convert.ToUInt16(dbAdres.Split('.')[1]), VALUESReal);
              //    this.Close();
              //   }
                if (dbAdres.Split('.')[0] == "D")
                {
                    VALUESDint[0] = Convert.ToUInt16(txtYazi.Text);
                    Anasayfa.writedint(Convert.ToUInt16(dbAdres.Split('.')[1]), (VALUESDint));
               this.Close();
                 }
             //  if (dbAdres.Split('.')[0] == "i")
             //  {
             //       VALUESint[0] = Convert.ToInt16(txtYazi.Text);
             //       Anasayfa.writeint(Convert.ToUInt16(dbAdres.Split('.')[1]), VALUESint);
             // this.Close();
             //  }
            }
            catch
            {
                txtYazi.BackColor = Color.Tomato;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {               
                if (txtYazi.Text.Length != 0)
                {
                    txtYazi.Text = txtYazi.Text.Substring(0, txtYazi.Text.Length - 1);
                }               
            }
            catch
            {
                txtYazi.Text = string.Empty;
            }
        }

        private void frmKlavye_Load(object sender, EventArgs e)
        {
           txtYazi.Text = value;
        }
    }
}
