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
    public partial class Şifre : Form
    {
        public Şifre()
        {
            InitializeComponent();
        }
        public static bool Şifre_ok;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            textBox1.Text = "";
        }

        private void Şifre_giriş_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text== DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString())
            {
                Şifre_ok = true;
                this.Hide();
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("HATALI ŞİFRE");
            }

        }
    }
}
