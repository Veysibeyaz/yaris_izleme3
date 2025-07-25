namespace Yaris_Online_izleme_Programı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressConn = new DevExpress.XtraWaitForm.ProgressPanel();
            this.menuIP = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtIPAdres = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrGecikme = new System.Windows.Forms.Timer(this.components);
            this.btnTekrarBaglan = new DevExpress.XtraEditors.SimpleButton();
            this.tmrAcilisGecikme = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(494, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // progressConn
            // 
            this.progressConn.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressConn.Appearance.ForeColor = System.Drawing.Color.White;
            this.progressConn.Appearance.Options.UseBackColor = true;
            this.progressConn.Appearance.Options.UseForeColor = true;
            this.progressConn.AppearanceCaption.BackColor = System.Drawing.Color.White;
            this.progressConn.AppearanceCaption.Options.UseBackColor = true;
            this.progressConn.AppearanceDescription.BackColor = System.Drawing.Color.White;
            this.progressConn.AppearanceDescription.Options.UseBackColor = true;
            this.progressConn.BarAnimationElementThickness = 2;
            this.progressConn.Caption = "Lütfen Bekleyiniz";
            this.progressConn.ContextMenuStrip = this.menuIP;
            this.progressConn.Description = "Haberleşme Kontrol Edililiyor...";
            this.progressConn.Location = new System.Drawing.Point(569, 481);
            this.progressConn.Name = "progressConn";
            this.progressConn.Size = new System.Drawing.Size(246, 66);
            this.progressConn.TabIndex = 5;
            this.progressConn.Text = "progressPanel1";
            // 
            // menuIP
            // 
            this.menuIP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuIP.Name = "contextMenuStrip1";
            this.menuIP.Size = new System.Drawing.Size(118, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtIPAdres,
            this.toolStripSeparator1,
            this.kaydetToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem1.Text = "IP Adres";
            this.toolStripMenuItem1.MouseEnter += new System.EventHandler(this.toolStripMenuItem1_MouseEnter);
            // 
            // txtIPAdres
            // 
            this.txtIPAdres.Name = "txtIPAdres";
            this.txtIPAdres.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // tmrGecikme
            // 
            this.tmrGecikme.Enabled = true;
            this.tmrGecikme.Interval = 1000;
            this.tmrGecikme.Tick += new System.EventHandler(this.tmrGecikme_Tick);
            // 
            // btnTekrarBaglan
            // 
            this.btnTekrarBaglan.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnTekrarBaglan.Appearance.Options.UseFont = true;
            this.btnTekrarBaglan.Location = new System.Drawing.Point(545, 354);
            this.btnTekrarBaglan.Name = "btnTekrarBaglan";
            this.btnTekrarBaglan.Size = new System.Drawing.Size(246, 77);
            this.btnTekrarBaglan.TabIndex = 10;
            this.btnTekrarBaglan.Text = "Tekrar Deneyiniz";
            this.btnTekrarBaglan.Visible = false;
            this.btnTekrarBaglan.Click += new System.EventHandler(this.btnTekrarBaglan_Click);
            // 
            // tmrAcilisGecikme
            // 
            this.tmrAcilisGecikme.Enabled = true;
            this.tmrAcilisGecikme.Interval = 500;
            this.tmrAcilisGecikme.Tick += new System.EventHandler(this.tmrAcilisGecikme_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1920, 1020);
            this.Controls.Add(this.btnTekrarBaglan);
            this.Controls.Add(this.progressConn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuIP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraWaitForm.ProgressPanel progressConn;
        private System.Windows.Forms.Timer tmrGecikme;
        private DevExpress.XtraEditors.SimpleButton btnTekrarBaglan;
        private System.Windows.Forms.ContextMenuStrip menuIP;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox txtIPAdres;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.Timer tmrAcilisGecikme;
    }
}

