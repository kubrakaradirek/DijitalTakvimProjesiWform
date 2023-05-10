using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoniHocaProje
{
    public partial class frmSifrele : Form
    {
        public frmSifrele()
        {
            InitializeComponent();
        }

        private void tnDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                lblPath.Text = dlg.FileName;
                txtPath.Text = dlg.FileName;
            }
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            Byte[] dosya = File.ReadAllBytes(lblPath.Text);
            for(int i=0; i<dosya.Length; i++)
            {
                dosya[i] = (Byte)((int)dosya[i] + 1);
                if (dosya[i]> 255)
                {
                    dosya[i] = 0;
                }
            }

            File.WriteAllBytes(lblPath.Text, dosya);

        }

        private void btnSifreyiCoz_Click(object sender, EventArgs e)
        {
            Byte[] dosya = File.ReadAllBytes(lblPath.Text);
            for (int i = 0; i < dosya.Length; i++)
            {
                if ((Byte)((int)dosya[i] - 1) < 0)
                {
                    dosya[i] = 255;
                }
                else 
                dosya[i] = (Byte)((int)dosya[i] - 1);
               
            }

            File.WriteAllBytes(lblPath.Text, dosya);
        }
    }
}
