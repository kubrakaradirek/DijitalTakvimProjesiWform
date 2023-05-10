namespace RoniHocaProje
{
    partial class frmİlkbahar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmİlkbahar));
            this.rtbMetinYaz = new System.Windows.Forms.RichTextBox();
            this.picResim = new System.Windows.Forms.PictureBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmYazmayaBasla = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.btnTakvimeDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picResim)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbMetinYaz
            // 
            this.rtbMetinYaz.Location = new System.Drawing.Point(12, 66);
            this.rtbMetinYaz.Name = "rtbMetinYaz";
            this.rtbMetinYaz.Size = new System.Drawing.Size(512, 388);
            this.rtbMetinYaz.TabIndex = 0;
            this.rtbMetinYaz.Text = "";
            // 
            // picResim
            // 
            this.picResim.Location = new System.Drawing.Point(13, 460);
            this.picResim.Name = "picResim";
            this.picResim.Size = new System.Drawing.Size(224, 216);
            this.picResim.TabIndex = 1;
            this.picResim.TabStop = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.BackgroundImage")));
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKaydet.Location = new System.Drawing.Point(437, 460);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(145, 36);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Bilgileri Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmYazmayaBasla});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 37);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmYazmayaBasla
            // 
            this.tsmYazmayaBasla.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsmYazmayaBasla.Name = "tsmYazmayaBasla";
            this.tsmYazmayaBasla.Size = new System.Drawing.Size(112, 33);
            this.tsmYazmayaBasla.Text = "Yazmaya Başla";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResimEkle.BackgroundImage")));
            this.btnResimEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResimEkle.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResimEkle.Location = new System.Drawing.Point(243, 460);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(115, 36);
            this.btnResimEkle.TabIndex = 4;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // btnTakvimeDon
            // 
            this.btnTakvimeDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTakvimeDon.BackgroundImage")));
            this.btnTakvimeDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTakvimeDon.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTakvimeDon.Location = new System.Drawing.Point(253, 662);
            this.btnTakvimeDon.Name = "btnTakvimeDon";
            this.btnTakvimeDon.Size = new System.Drawing.Size(144, 47);
            this.btnTakvimeDon.TabIndex = 5;
            this.btnTakvimeDon.Text = "Takvime Dön";
            this.btnTakvimeDon.UseVisualStyleBackColor = true;
            this.btnTakvimeDon.Click += new System.EventHandler(this.btnTakvimeDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(253, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 6;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(13, 48);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(0, 15);
            this.lblTarih.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(483, 662);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Çıkış Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmİlkbahar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 731);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTakvimeDon);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.picResim);
            this.Controls.Add(this.rtbMetinYaz);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmİlkbahar";
            this.Text = "frmİlkbahar";
            this.Load += new System.EventHandler(this.frmİlkbahar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picResim)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtbMetinYaz;
        private PictureBox picResim;
        private Button btnKaydet;
        private MenuStrip menuStrip1;
        private OpenFileDialog openFileDialog1;
        private Button btnResimEkle;
        private Button btnTakvimeDon;
        private ToolStripMenuItem tsmYazmayaBasla;
        private Label label1;
        private Label lblTarih;
        private Button button1;
    }
}