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
    public partial class Klavye_2 : Form
    {
        string dbAdres, value;
        TextBox txtBox;
        public Klavye_2(TextBox txtVal)
        {
            InitializeComponent();
            txtBox = txtVal;
        }

            private void button13_Click(object sender, EventArgs e)
        {

            txtBox.Text = txtYazi.Text;
            this.Close();

        }
        private void btnNu(object sender, EventArgs e)
        {
            txtYazi.Text += (sender as Button).Text;
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

        private void Klavye_2_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
