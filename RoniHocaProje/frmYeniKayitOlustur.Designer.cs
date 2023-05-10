namespace RoniHocaProje
{
    partial class frmYeniKayitOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYeniKayitOlustur));
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.lblYeniKullanici = new System.Windows.Forms.Label();
            this.txtKYeniKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtYeniSifre.Location = new System.Drawing.Point(285, 185);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(200, 29);
            this.txtYeniSifre.TabIndex = 12;
            // 
            // lblYeniKullanici
            // 
            this.lblYeniKullanici.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYeniKullanici.ForeColor = System.Drawing.Color.Black;
            this.lblYeniKullanici.Location = new System.Drawing.Point(74, 105);
            this.lblYeniKullanici.Name = "lblYeniKullanici";
            this.lblYeniKullanici.Size = new System.Drawing.Size(187, 45);
            this.lblYeniKullanici.TabIndex = 9;
            this.lblYeniKullanici.Text = "Yeni Kullanıcı Adı :";
            // 
            // txtKYeniKullaniciAdi
            // 
            this.txtKYeniKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKYeniKullaniciAdi.Location = new System.Drawing.Point(285, 121);
            this.txtKYeniKullaniciAdi.Name = "txtKYeniKullaniciAdi";
            this.txtKYeniKullaniciAdi.Size = new System.Drawing.Size(237, 29);
            this.txtKYeniKullaniciAdi.TabIndex = 11;
            // 
            // lblSifre
            // 
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSifre.Location = new System.Drawing.Point(152, 181);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(109, 43);
            this.lblSifre.TabIndex = 10;
            this.lblSifre.Text = "Yeni Şifre : ";
            // 
            // b
            // 
            this.b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b.BackgroundImage")));
            this.b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b.Location = new System.Drawing.Point(285, 235);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(200, 46);
            this.b.TabIndex = 16;
            this.b.Text = "Yeni Kayıt Oluştur";
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(395, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "Giriş Sayfasına Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmYeniKayitOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.lblYeniKullanici);
            this.Controls.Add(this.txtKYeniKullaniciAdi);
            this.Controls.Add(this.lblSifre);
            this.Name = "frmYeniKayitOlustur";
            this.Text = "Yeni Kayıt Oluştur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtYeniSifre;
        private Label lblYeniKullanici;
        private TextBox txtKYeniKullaniciAdi;
        private Label lblSifre;
        private Button b;
        private Button button1;
    }
}