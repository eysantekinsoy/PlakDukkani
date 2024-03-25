using Uygulama.BL.Manager.Concrete;
using Uygulama.BL.Models;

namespace Uygulama.UI
{
    public partial class Form1 : Form
    {
        //KullaniciManager kullaniciManager = new KullaniciManager();
        private readonly Form _mainform;
        
        public KullaniciModel LoginUser;
        public Form1()
        {
            InitializeComponent();
            _mainform = Program.MainForm;
            Program.ActiveForm = this;

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            

            string kullaniciAdi = txtbxKullaniciAdi.Text;
            string pass = txtbxKullaniciSifre.Text;

            if (kullaniciAdi == "" || pass == "")
            {
                MessageBox.Show("Lütfen boþ alan býrakmayýnýz", "BAÞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                KullaniciAdPassReset();
            }
            else
            {
                
               
                    KullaniciManager kullaniciManager = new KullaniciManager();
                    LoginUser = kullaniciManager.FindUser(kullaniciAdi, Program.sha256_hash(pass));


                    if (LoginUser != null)
                    {
                        Program.LoginUser = LoginUser;
                        Program.LoginUser.Id = LoginUser.Id;
                    // Kullanýcý bulundu login oldu 
                        Anasafa form3 = new Anasafa();
                        form3.ShowDialog();
                        

                    }
                    else
                    {
                        MessageBox.Show("Kullanýcý Adý veya Þifre Yanlýþ", "BAÞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    KullaniciAdPassReset();
                    }
                


            }
        }

        private void btnkayitol_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.MainForm = this;
        }
        private void KullaniciAdPassReset()
        {
            txtbxKullaniciAdi.Text = "";
            txtbxKullaniciSifre.Text = "";
        }
    }
}
