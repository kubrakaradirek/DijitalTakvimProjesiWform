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
    public partial class frmLogin : Form
    {


        frmTakvim frmTakvim = new frmTakvim();
        frmYeniKayitOlustur frmYeniKayitOlustur = new frmYeniKayitOlustur();
        public frmLogin()
        {
            InitializeComponent();
            lblKullaniciAdi.BackColor = Color.Transparent;
            lblSifre.BackColor = Color.Transparent;
            lblDurum.BackColor = Color.Transparent;
           
        }

        string _kullaniciAdi= String.Empty;
        string _sifre= String.Empty;


        int _sayac = 0;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string dosyaKayit = Directory.GetCurrentDirectory();
            string yeniKullaniciAdiKayit=Path.Combine(dosyaKayit, "yeniKullaniciAdi.txt");
            string kullaniciAdiİcin = txtKullaniciAdi.Text;
            string yeniSifreKayit = Path.Combine(dosyaKayit, "yeniSifreKayit.txt");
            string kaydedilenKullaniciAdi = File.ReadAllText(yeniKullaniciAdiKayit);
            string kaydedilenSifreAdi = File.ReadAllText(yeniSifreKayit);
            string girilenKullaniciAdi = txtKullaniciAdi.Text;
            string girilenSifreAdi = txtSifre.Text;
            if(girilenKullaniciAdi==kaydedilenKullaniciAdi && girilenSifreAdi==kaydedilenSifreAdi)
            {
                FormGetir(frmTakvim);
            }
            else
            {
                MessageBox.Show("Yanlış.");
            }

            string sifreİcin = txtSifre.Text;
            _sayac++;
            
            if(_sayac==3)
            {
                lblDurum.Text = "Tüm giriş haklarınız dolmuştur.";
                lblDurum.ForeColor = Color.Red;
                txtKullaniciAdi.Enabled = false;
                txtSifre.Enabled = false;
                btnGirisYap.Enabled = false;
            }
            if(_kullaniciAdi== kullaniciAdiİcin && _sifre==sifreİcin)
                FormGetir(frmTakvim);  
            
        }


        private void FormGetir(Form frm)
        {           
            frmTakvim.MdiParent = this.MdiParent;
            frmTakvim.Dock= DockStyle.Fill;
            frmTakvim.FormBorderStyle= FormBorderStyle.None;
            frmTakvim.Show();
            this.Close();
        }
       
        private void btnGizle_MouseDown(object sender, MouseEventArgs e)
        {
            txtSifre.UseSystemPasswordChar = false;
        }

        private void btnGizle_MouseUp(object sender, MouseEventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
        }

        private void btnYeniKayitOlustur_Click(object sender, EventArgs e)
        {
            frmYeniKayitOlustur.MdiParent = this.MdiParent;
            frmYeniKayitOlustur.Dock = DockStyle.Fill;
            frmYeniKayitOlustur.FormBorderStyle = FormBorderStyle.None;
            frmYeniKayitOlustur.Show();
            this.Close();

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
        }
    }
}
