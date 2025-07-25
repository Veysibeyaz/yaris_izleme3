namespace Yaris_Online_izleme_Programı
{
    partial class Şifre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Şifre_giriş_btn = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(97, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label5.ForeColor = System.Drawing.Color.Yellow;
            this.Label5.Location = new System.Drawing.Point(107, 23);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(136, 20);
            this.Label5.TabIndex = 262;
            this.Label5.Text = "ŞİFRE GİRİNİZ";
            // 
            // Şifre_giriş_btn
            // 
            this.Şifre_giriş_btn.Appearance.BackColor = System.Drawing.Color.Red;
            this.Şifre_giriş_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Şifre_giriş_btn.Appearance.ForeColor = System.Drawing.Color.White;
            this.Şifre_giriş_btn.Appearance.Options.UseBackColor = true;
            this.Şifre_giriş_btn.Appearance.Options.UseFont = true;
            this.Şifre_giriş_btn.Appearance.Options.UseForeColor = true;
            this.Şifre_giriş_btn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Şifre_giriş_btn.AppearanceHovered.Options.UseBackColor = true;
            this.Şifre_giriş_btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.Şifre_giriş_btn.Location = new System.Drawing.Point(36, 116);
            this.Şifre_giriş_btn.Name = "Şifre_giriş_btn";
            this.Şifre_giriş_btn.Size = new System.Drawing.Size(106, 64);
            this.Şifre_giriş_btn.TabIndex = 263;
            this.Şifre_giriş_btn.Text = "GİRİŞ";
            this.Şifre_giriş_btn.Click += new System.EventHandler(this.Şifre_giriş_btn_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Red;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton1.Location = new System.Drawing.Point(205, 116);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(106, 64);
            this.simpleButton1.TabIndex = 263;
            this.simpleButton1.Text = "ÇIKIŞ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Şifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(347, 208);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.Şifre_giriş_btn);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Şifre";
            this.Text = "Şifre";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label Label5;
        private DevExpress.XtraEditors.SimpleButton Şifre_giriş_btn;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}