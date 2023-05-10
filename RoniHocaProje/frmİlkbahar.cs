using Microsoft.VisualBasic;
using RoniHocaProje.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RoniHocaProje
{   

    public partial class frmİlkbahar : Form
    {
        frmSifrele frmsifrele = new frmSifrele();
        frmTakvim frmTakvim = new frmTakvim();

        private DateTime _tarih;

        public frmİlkbahar(DateTime tarih)
        {
            InitializeComponent();
            _tarih = tarih;
            int month = tarih.Month;
            if (9 <= month && month <= 11)
            {
                BackgroundImage = (Image)Resources.Sonbahar;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (3 <= month && month <= 5)
            {
                BackgroundImage = (Image)Resources.İlkbahar;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (6 <= month && month <= 8)
            {
                BackgroundImage = (Image)Resources.Yaz;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                BackgroundImage = (Image)Resources.Kis;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void frmİlkbahar_Load(object sender, EventArgs e)
        {
            rtbMetinYaz.Text = String.Empty;
            menuStrip1.BackColor = Color.Transparent;
            lblTarih.Text = _tarih.ToString("dd.MM.yyyy");
            string date = _tarih.ToString("yyyyMMdd");
            string imageFileName = string.Format("{0}-{1}.{2}", date, "img", "jpg");
            string textFileName = string.Format("{0}-{1}.{2}", date, "txt", "txt");

            string applicationFolder = Directory.GetCurrentDirectory();
            string dataFolder = applicationFolder + "\\data";

            string imagePath = Path.Combine(dataFolder, imageFileName);
            string textPath = Path.Combine(dataFolder, textFileName);

            if(File.Exists(imagePath) || File.Exists(textPath))
            {
                if (File.Exists(textPath))
                {
                    rtbMetinYaz.Text = File.ReadAllText(textPath);
                }
                if (File.Exists(imagePath))
                {
                    picResim.Image = Image.FromFile(imagePath);
                    picResim.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                btnKaydet.Enabled = false;
                btnResimEkle.Enabled = false;
            }


        }


        /// <summary>
        /// Bu metot kullanıcı tarafından istenilen uzantıdaki fotoğrafın seçilmesini sağlar
        /// </summary>
        public void ResmiAc()
        {
            try
            {
                openFileDialog1.DefaultExt = ".jpg";
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                String ResminYolu = openFileDialog1.FileName;
                picResim.Image = Image.FromFile(ResminYolu);
            }
            catch { }
        }
        /// <summary>
        /// Bu metot kullanıcı tarafından seçilen fotoğrafın pixtureBoxta görüntülenmesine yarar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            ResmiAc();
            picResim.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        /// <summary>
        /// Bu metot Günlük sayfasındaki bilgilerin kaydedilmesini sağlar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string date = _tarih.ToString("yyyyMMdd");
                string imageFileName = string.Format("{0}-{1}.{2}", date, "img", "jpg");
                string textFileName = string.Format("{0}-{1}.{2}", date, "txt", "txt");

                string applicationFolder = Directory.GetCurrentDirectory();
                string dataFolder = applicationFolder + "\\data";

                string imagePath = Path.Combine(dataFolder, imageFileName);
                string textPath = Path.Combine(dataFolder, textFileName);

                Directory.CreateDirectory(dataFolder);
                picResim.Image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                File.WriteAllText(textPath, rtbMetinYaz.Text);
            }
            catch
            {
                MessageBox.Show("Boş dosyayı kaydedemezsiniz.Lütfen tüm bilgileri doldurarak tekrar deneyiniz.");
            }       
        }

        private void btnTakvimeDon_Click(object sender, EventArgs e)
        {
            frmTakvim.MdiParent=this.MdiParent;
            frmTakvim.Dock = DockStyle.Fill;
            frmTakvim.FormBorderStyle = FormBorderStyle.None;
            this.Close();                   
            
        }

        private void button1_Click(object sender, EventArgs e)
        {                     
            frmMdi frmMdi = new frmMdi();
            frmSifrele frmSifrele = new frmSifrele();
            frmSifrele.MdiParent = this.MdiParent;
            frmTakvim.Hide();
            this.Close();
            frmSifrele.Show();

        }
    }
}
