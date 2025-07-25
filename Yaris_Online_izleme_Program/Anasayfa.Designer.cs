namespace Yaris_Online_izleme_Programı
{
    partial class Anasayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.tmrSystem = new System.Windows.Forms.Timer(this.components);
            this.tmrPLC = new System.Windows.Forms.Timer(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.button3 = new System.Windows.Forms.Button();
            this.ModDurumu = new DevExpress.XtraEditors.SimpleButton();
            this.lblTarih = new System.Windows.Forms.Label();
            this.HaberleşmeDurumu = new DevExpress.XtraEditors.SimpleButton();
            this.lblSaat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnMan = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "034-settings.png");
            this.imgList.Images.SetKeyName(1, "037-search.png");
            this.imgList.Images.SetKeyName(2, "HOME.png");
            this.imgList.Images.SetKeyName(3, "MANUEL.png");
            this.imgList.Images.SetKeyName(4, "039-padlock.png");
            this.imgList.Images.SetKeyName(5, "030-inbox.png");
            this.imgList.Images.SetKeyName(6, "newclose.png");
            // 
            // tmrSystem
            // 
            this.tmrSystem.Enabled = true;
            this.tmrSystem.Interval = 500;
            this.tmrSystem.Tick += new System.EventHandler(this.tmrSystem_Tick);
            // 
            // tmrPLC
            // 
            this.tmrPLC.Enabled = true;
            this.tmrPLC.Tick += new System.EventHandler(this.tmrPLC_Tick);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.Blue;
            this.panelControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.button3);
            this.panelControl1.Controls.Add(this.ModDurumu);
            this.panelControl1.Controls.Add(this.lblTarih);
            this.panelControl1.Controls.Add(this.HaberleşmeDurumu);
            this.panelControl1.Controls.Add(this.lblSaat);
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.btnService);
            this.panelControl1.Controls.Add(this.btnGraph);
            this.panelControl1.Controls.Add(this.btnMan);
            this.panelControl1.Controls.Add(this.btnSetting);
            this.panelControl1.Controls.Add(this.btnHome);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1920, 56);
            this.panelControl1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton1.Enabled = false;
            this.simpleButton1.Location = new System.Drawing.Point(1239, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(139, 56);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.Tag = "";
            this.simpleButton1.Text = "ŞİFRE AKTİF";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ImageIndex = 6;
            this.button3.ImageList = this.imgList;
            this.button3.Location = new System.Drawing.Point(372, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 49);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // ModDurumu
            // 
            this.ModDurumu.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ModDurumu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ModDurumu.Appearance.ForeColor = System.Drawing.Color.White;
            this.ModDurumu.Appearance.Options.UseBackColor = true;
            this.ModDurumu.Appearance.Options.UseFont = true;
            this.ModDurumu.Appearance.Options.UseForeColor = true;
            this.ModDurumu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.ModDurumu.Enabled = false;
            this.ModDurumu.Location = new System.Drawing.Point(1080, 0);
            this.ModDurumu.Name = "ModDurumu";
            this.ModDurumu.Size = new System.Drawing.Size(139, 56);
            this.ModDurumu.TabIndex = 2;
            this.ModDurumu.Tag = "";
            this.ModDurumu.Text = "SİPARİŞ AKTİF";
            // 
            // lblTarih
            // 
            this.lblTarih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTarih.Location = new System.Drawing.Point(1771, 31);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(146, 23);
            this.lblTarih.TabIndex = 17;
            this.lblTarih.Text = "Tarih";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HaberleşmeDurumu
            // 
            this.HaberleşmeDurumu.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.HaberleşmeDurumu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HaberleşmeDurumu.Appearance.ForeColor = System.Drawing.Color.White;
            this.HaberleşmeDurumu.Appearance.Options.UseBackColor = true;
            this.HaberleşmeDurumu.Appearance.Options.UseFont = true;
            this.HaberleşmeDurumu.Appearance.Options.UseForeColor = true;
            this.HaberleşmeDurumu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.HaberleşmeDurumu.Enabled = false;
            this.HaberleşmeDurumu.Location = new System.Drawing.Point(922, 0);
            this.HaberleşmeDurumu.Name = "HaberleşmeDurumu";
            this.HaberleşmeDurumu.Size = new System.Drawing.Size(139, 56);
            this.HaberleşmeDurumu.TabIndex = 3;
            this.HaberleşmeDurumu.Tag = "";
            this.HaberleşmeDurumu.Text = "HABERLEŞME OK";
            // 
            // lblSaat
            // 
            this.lblSaat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaat.BackColor = System.Drawing.Color.Transparent;
            this.lblSaat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSaat.Location = new System.Drawing.Point(1771, 3);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(146, 23);
            this.lblSaat.TabIndex = 18;
            this.lblSaat.Text = "Saat";
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imgList;
            this.button1.Location = new System.Drawing.Point(639, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 49);
            this.button1.TabIndex = 16;
            this.button1.Tag = "";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.btnPages);
            // 
            // btnService
            // 
            this.btnService.AllowDrop = true;
            this.btnService.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.ImageIndex = 4;
            this.btnService.ImageList = this.imgList;
            this.btnService.Location = new System.Drawing.Point(552, 4);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(81, 49);
            this.btnService.TabIndex = 15;
            this.btnService.Tag = "";
            this.btnService.UseVisualStyleBackColor = false;
            this.btnService.Visible = false;
            this.btnService.Click += new System.EventHandler(this.btnPages);
            // 
            // btnGraph
            // 
            this.btnGraph.AllowDrop = true;
            this.btnGraph.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraph.ImageIndex = 1;
            this.btnGraph.ImageList = this.imgList;
            this.btnGraph.Location = new System.Drawing.Point(286, 3);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(81, 50);
            this.btnGraph.TabIndex = 14;
            this.btnGraph.Tag = "4";
            this.btnGraph.UseVisualStyleBackColor = false;
            this.btnGraph.Click += new System.EventHandler(this.btnPages);
            // 
            // btnMan
            // 
            this.btnMan.AllowDrop = true;
            this.btnMan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMan.ImageIndex = 3;
            this.btnMan.ImageList = this.imgList;
            this.btnMan.Location = new System.Drawing.Point(465, 3);
            this.btnMan.Name = "btnMan";
            this.btnMan.Size = new System.Drawing.Size(81, 50);
            this.btnMan.TabIndex = 13;
            this.btnMan.Tag = "";
            this.btnMan.UseVisualStyleBackColor = false;
            this.btnMan.Visible = false;
            this.btnMan.Click += new System.EventHandler(this.btnPages);
            // 
            // btnSetting
            // 
            this.btnSetting.AllowDrop = true;
            this.btnSetting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ImageIndex = 5;
            this.btnSetting.ImageList = this.imgList;
            this.btnSetting.Location = new System.Drawing.Point(199, 3);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(81, 50);
            this.btnSetting.TabIndex = 12;
            this.btnSetting.Tag = "2";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnPages);
            // 
            // btnHome
            // 
            this.btnHome.AllowDrop = true;
            this.btnHome.BackColor = System.Drawing.Color.Goldenrod;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ImageIndex = 2;
            this.btnHome.ImageList = this.imgList;
            this.btnHome.Location = new System.Drawing.Point(112, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(81, 50);
            this.btnHome.TabIndex = 11;
            this.btnHome.Tag = "1";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnPages);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1920, 1020);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrSystem;
        private System.Windows.Forms.ImageList imgList;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnMan;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton HaberleşmeDurumu;
        private DevExpress.XtraEditors.SimpleButton ModDurumu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmrPLC;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}