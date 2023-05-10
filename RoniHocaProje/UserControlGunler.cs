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
    public partial class UserControlGunler : UserControl
    {
        public string _staticDay;
        public UserControlGunler()
        {
            InitializeComponent();
        }

        private void UserControlGunler_Load(object sender, EventArgs e)
        {

        }
        public void Gunler(int gunlerinNumarasi)
        {
            lblGunler.Text = gunlerinNumarasi+ " ";
        }

        private void UserControlGunler_Click(object sender, EventArgs e)
        {
            var userControl = (UserControl)sender;
            frmTakvim frm = (frmTakvim)userControl.ParentForm;
            int ay = frm._ay;
            int yil = frm._yil;
            int gun = int.Parse(lblGunler.Text);
            DateTime tarih = new DateTime(yil, ay, gun);
            frmİlkbahar frmİlkbahar = new frmİlkbahar(tarih);
            frmİlkbahar.Show();
        }
    }
}
