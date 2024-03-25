namespace Uygulama.UI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSifreTekrar = new TextBox();
            txtPass = new TextBox();
            txtKullaniciAdi = new TextBox();
            btnKayitOl = new Button();
            SuspendLayout();
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(140, 219);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.PasswordChar = '*';
            txtSifreTekrar.PlaceholderText = "Sifre Tekrar";
            txtSifreTekrar.Size = new Size(100, 23);
            txtSifreTekrar.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(140, 169);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Şifre";
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(140, 112);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.PlaceholderText = "Kullanici Adi";
            txtKullaniciAdi.Size = new Size(100, 23);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(139, 282);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(75, 23);
            btnKayitOl.TabIndex = 3;
            btnKayitOl.Text = "Kayıt OL";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKayitOl);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtPass);
            Controls.Add(txtSifreTekrar);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSifreTekrar;
        private TextBox txtPass;
        private TextBox txtKullaniciAdi;
        private Button btnKayitOl;
    }
}