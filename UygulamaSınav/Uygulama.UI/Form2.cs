using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uygulama.BL.Manager.Concrete;
using Uygulama.BL.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Uygulama.UI
{
    public partial class Form2 : Form
    {
        KullaniciModel kullaniciModel = new KullaniciModel();
        KullaniciManager kullaniciManager = new KullaniciManager();
        string _errorMessage = string.Empty;
        public Form2()
        {

            InitializeComponent();

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            UserInfoFromTexts();


            if (SifreKontrol(txtPass.Text))
            {
                TextBoslukKontrol(); 
               
                    KullaniciKayitliMi("Kullanıcı");
            }
            else
            {
                MessageBox.Show(_errorMessage, "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _errorMessage = string.Empty;
            }

        }
        private void KullaniciKayitliMi(string UserOrAdmin)
        {
            var tempUser = kullaniciManager.FindUser(txtKullaniciAdi.Text);
            if (tempUser != null)
            {
                MessageBox.Show($"{UserOrAdmin} Zaten Kayıtlı", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKullaniciAdi.Text = "";
            }
            else
            {
                kullaniciModel.Sifre = Program.sha256_hash(kullaniciModel.Sifre);
                kullaniciManager.Add(kullaniciModel);
                MessageBox.Show($"{UserOrAdmin} Kayıdı Başarılı", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.Dispose();
            }
        }
        private void UserInfoFromTexts()
        {
            kullaniciModel.KullaniciAdi = txtKullaniciAdi.Text;
            kullaniciModel.Sifre = txtPass.Text;
        }
        public bool SifreKontrol(string sifre)
        {
            bool result = true;
            if ((txtPass.Text.Length < 7) || (txtPass.Text.Length > 20))
            {
                txtPass.Text = "";
                ErrorMessageForPass("8 en fazla 20 hane");
                result = false;
            }
            if (!Regex.IsMatch(sifre, "[A-Z]"))
            {
                ErrorMessageForPass("bir büyük harf");
                result = false;
            }
            if (!Regex.IsMatch(sifre, "[a-z]"))
            {
                ErrorMessageForPass("bir küçük harf");
                result = false;
            }
            if (!Regex.IsMatch(sifre, "[0-9]"))
            {
                ErrorMessageForPass("bir rakam");
                result = false;
            }
            return result;
        }
        private void ErrorMessageForPass(string HataTürü)
        {
            _errorMessage += $"Şifre En az {HataTürü} içermeli\n";

        }

        private void TextBoslukKontrol()
        {
            if (txtKullaniciAdi.Text == "" || txtPass.Text == "" || txtSifreTekrar.Text == "" )
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }

}
