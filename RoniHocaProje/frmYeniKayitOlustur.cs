using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoniHocaProje
{
    public partial class frmYeniKayitOlustur : Form
    { 
        public frmYeniKayitOlustur()
        {
            InitializeComponent();
            lblYeniKullanici.BackColor = Color.Transparent;
            lblSifre.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            string yeniKullaniciAdi=txtKYeniKullaniciAdi.Text;
            string yeniSifre=txtYeniSifre.Text;
            string dosyaKayit=Directory.GetCurrentDirectory();
            string kullaniciAdiKayit = Path.Combine(dosyaKayit, "yeniKullaniciAdi.txt");
            string yeniSifreKayit = Path.Combine(dosyaKayit, "yeniSifreKayit.txt");
            File.WriteAllText(kullaniciAdiKayit, yeniKullaniciAdi);
            File.WriteAllText(yeniSifreKayit, yeniSifre);
            MessageBox.Show("Kaydınız oluşturuldu.");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
