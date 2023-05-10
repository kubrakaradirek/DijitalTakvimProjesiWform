namespace RoniHocaProje
{
    partial class UserControlGunler
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGunler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGunler
            // 
            this.lblGunler.AutoSize = true;
            this.lblGunler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGunler.Location = new System.Drawing.Point(5, 8);
            this.lblGunler.Name = "lblGunler";
            this.lblGunler.Size = new System.Drawing.Size(28, 21);
            this.lblGunler.TabIndex = 0;
            this.lblGunler.Text = "00";
            // 
            // UserControlGunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblGunler);
            this.Name = "UserControlGunler";
            this.Size = new System.Drawing.Size(112, 92);
            this.Load += new System.EventHandler(this.UserControlGunler_Load);
            this.Click += new System.EventHandler(this.UserControlGunler_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGunler;
    }
}
