namespace RoniHocaProje
{
    public partial class frmMdi : Form
    {
        public frmMdi()
        {
            InitializeComponent();
        }
      
        private void tsmLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.MdiParent = this;
            frmLogin.Show(); 
            
            frmSifrele frmSifrele = new frmSifrele();
            frmSifrele.MdiParent = this;

        }
    }
}