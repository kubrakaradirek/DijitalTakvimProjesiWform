using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RoniHocaProje
{
    public partial class frmTakvim : Form
    {
        

        public int _ay, _yil;
        private string[] _kayitliGunler;

        public frmTakvim()
        {
            InitializeComponent();
            string applicationFolder = Directory.GetCurrentDirectory();
            string dataFolder = applicationFolder + "\\data";
            string[] dosyalar = Directory.GetFiles(dataFolder);
            for (int i = 0; i < dosyalar.Length; i++)
            {
                dosyalar[i] = Path.GetFileName(dosyalar[i]).Split("-")[0];
            }
            _kayitliGunler = dosyalar.Distinct().ToArray();

        }

        private void frmTakvim_Load(object sender, EventArgs e)
        {
            GunleriGoster();
            lblTarih.BackColor = Color.Transparent;
        }

        private void GunleriGoster()
        {
            DateTime now = DateTime.Now;
            _ay = now.Month;
            _yil = now.Year;

            TakvimiYazdir();
        }

        private void TakvimiYazdir()
        {
            string ayİsmi = DateTimeFormatInfo.CurrentInfo.GetMonthName(_ay);
            lblTarih.Text = ayİsmi + " " + _yil;

            //Ayın ilk gününü alalım.
            DateTime ayBaslangici = new DateTime(_yil, _ay, 1);

            //Aydaki gün sayılarını alalım.
            int gunler = DateTime.DaysInMonth(_yil, _ay);
            int haftaninGunleri = Convert.ToInt32(ayBaslangici.DayOfWeek.ToString("d"));
            //boş bir usercontrol oluşturalım (project kısmından add user control)
            for (int i = 1; i < haftaninGunleri; i++)
            {
                UserControlBos ucBos = new UserControlBos();
                gunPaneli.Controls.Add(ucBos);
            }

            //şimdi günler için usercontrol oluşturalım.
            for (int i = 1; i <= gunler; i++)
            {
                UserControlGunler ucGunler = new UserControlGunler();
                ucGunler.Gunler(i);
                gunPaneli.Controls.Add(ucGunler);
                DateTime gun = new DateTime(_yil, _ay, i);
                string gunTarih = gun.ToString("yyyyMMdd");
                bool kayitliDosyaVar = _kayitliGunler.Contains(gunTarih);
                if (kayitliDosyaVar)
                {
                    ucGunler.BackColor = Color.Red;
                }
                if (gun > DateTime.Now.Date)
                {
                    ucGunler.BackColor = Color.LightGray;
                    ucGunler.Enabled = false;
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            gunPaneli.Controls.Clear();

            //Önceki aya geçmek için ayı azalttık.
            _ay--;
            try
            {
                TakvimiYazdir();
            }
            catch 
            {
                MessageBox.Show("Sınır Dışı!");
            }
        }

        private void btnİleri_Click(object sender, EventArgs e)
        {
            //gün panelini temizle
            gunPaneli.Controls.Clear();

            //sonraki aya geçmek için ayı arttırdık.
            _ay++;

            try
            {
                TakvimiYazdir();
            }
            catch 
            {
                MessageBox.Show("Sınır Dışı");
            }
        }
     
    }
}
