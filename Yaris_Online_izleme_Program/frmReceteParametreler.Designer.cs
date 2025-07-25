namespace Pega_Pc_Programı
{
    partial class frmRecete
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
            this.lstRecipes = new DevExpress.XtraEditors.ListBoxControl();
            this.btnAc = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.txtRecete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstRecipes)).BeginInit();
            this.SuspendLayout();
            // 
            // lstRecipes
            // 
            this.lstRecipes.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lstRecipes.Appearance.Options.UseFont = true;
            this.lstRecipes.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstRecipes.Location = new System.Drawing.Point(5, 4);
            this.lstRecipes.Name = "lstRecipes";
            this.lstRecipes.Size = new System.Drawing.Size(600, 365);
            this.lstRecipes.TabIndex = 1;
            this.lstRecipes.SelectedIndexChanged += new System.EventHandler(this.lstRecipes_SelectedIndexChanged);
            // 
            // btnAc
            // 
            this.btnAc.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAc.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnAc.Appearance.Options.UseBackColor = true;
            this.btnAc.Appearance.Options.UseFont = true;
            this.btnAc.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnAc.Location = new System.Drawing.Point(5, 414);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(150, 96);
            this.btnAc.TabIndex = 2;
            this.btnAc.Text = "Reçete\r\nAç";
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnKaydet.Location = new System.Drawing.Point(155, 414);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 96);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Reçete\r\nKaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSil.Location = new System.Drawing.Point(305, 414);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(150, 96);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Reçete\r\nSil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKapat.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnKapat.Appearance.Options.UseBackColor = true;
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnKapat.Location = new System.Drawing.Point(455, 414);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(150, 96);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // txtRecete
            // 
            this.txtRecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRecete.Location = new System.Drawing.Point(185, 375);
            this.txtRecete.Name = "txtRecete";
            this.txtRecete.Size = new System.Drawing.Size(350, 35);
            this.txtRecete.TabIndex = 3;
            this.txtRecete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(51, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reçete İsmi : ";
            // 
            // frmRecete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(610, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRecete);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.lstRecipes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reçete";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmRecete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstRecipes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.ListBoxControl lstRecipes;
        private DevExpress.XtraEditors.SimpleButton btnAc;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.TextBox txtRecete;
        private System.Windows.Forms.Label label1;
    }
}