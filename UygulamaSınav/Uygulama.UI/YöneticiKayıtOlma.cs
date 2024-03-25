using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Uygulama.UI
{
    public partial class YöneticiKayıtOlma : Form
    {
        public YöneticiKayıtOlma()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = txtAd.Text;
            if (isim.Any(char.IsDigit) && isim.Length < 3 && isim.IsNullOrEmpty())
                MessageBox.Show("Lütfen adınızı uygun şekilde giriniz.");
            else
                kullaniciModel.Adi = isim;





            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (sifre.IsNullOrEmpty() && !(sifre.Any(char.IsDigit)) && !(sifre.Any(char.IsLower)) && !(sifre.Any(char.IsUpper)) && sifre.Length <= 8 && !(sifre.Any(char.IsLetter)))
                MessageBox.Show("Şifreniz en az 8 karakter içermelidir, en az bir büyük harf,bir küçük harf, bir sayı kullanmalısınız.");
            else
                


        }

        private void btnİptal_Click(object sender, EventArgs e)
        {

        }
    }
}
