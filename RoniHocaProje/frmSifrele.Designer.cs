namespace RoniHocaProje
{
    partial class frmSifrele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSifrele));
            this.tnDosyaSec = new System.Windows.Forms.Button();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.btnSifreyiCoz = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tnDosyaSec
            // 
            this.tnDosyaSec.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tnDosyaSec.Location = new System.Drawing.Point(12, 23);
            this.tnDosyaSec.Name = "tnDosyaSec";
            this.tnDosyaSec.Size = new System.Drawing.Size(106, 42);
            this.tnDosyaSec.TabIndex = 0;
            this.tnDosyaSec.Text = "Dosya Seç";
            this.tnDosyaSec.UseVisualStyleBackColor = true;
            this.tnDosyaSec.Click += new System.EventHandler(this.tnDosyaSec_Click);
            // 
            // btnSifrele
            // 
            this.btnSifrele.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSifrele.Location = new System.Drawing.Point(12, 170);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(106, 42);
            this.btnSifrele.TabIndex = 1;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // btnSifreyiCoz
            // 
            this.btnSifreyiCoz.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSifreyiCoz.Location = new System.Drawing.Point(12, 218);
            this.btnSifreyiCoz.Name = "btnSifreyiCoz";
            this.btnSifreyiCoz.Size = new System.Drawing.Size(106, 42);
            this.btnSifreyiCoz.TabIndex = 2;
            this.btnSifreyiCoz.Text = "Şifreyi Çöz";
            this.btnSifreyiCoz.UseVisualStyleBackColor = true;
            this.btnSifreyiCoz.Click += new System.EventHandler(this.btnSifreyiCoz_Click);
            // 
            // lblPath
            // 
            this.lblPath.Location = new System.Drawing.Point(12, 79);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(369, 23);
            this.lblPath.TabIndex = 3;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(18, 120);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(363, 23);
            this.txtPath.TabIndex = 4;
            // 
            // frmSifrele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 293);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnSifreyiCoz);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.tnDosyaSec);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSifrele";
            this.Text = "Dosyaları Gizle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button tnDosyaSec;
        private Button btnSifrele;
        private Button btnSifreyiCoz;
        private Label lblPath;
        private TextBox txtPath;
    }
}