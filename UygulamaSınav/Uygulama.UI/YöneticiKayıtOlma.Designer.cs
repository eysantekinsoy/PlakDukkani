namespace Uygulama.UI
{
    partial class YöneticiKayıtOlma
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
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            txtSifreTekrari = new TextBox();
            label1 = new Label();
            lblKullaniciAdi = new Label();
            label3 = new Label();
            label4 = new Label();
            btnKayitOl = new Button();
            btnİptal = new Button();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(197, 89);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(187, 27);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(197, 162);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(187, 27);
            txtSifre.TabIndex = 1;
            // 
            // txtSifreTekrari
            // 
            txtSifreTekrari.Location = new Point(197, 248);
            txtSifreTekrari.Name = "txtSifreTekrari";
            txtSifreTekrari.Size = new Size(187, 27);
            txtSifreTekrari.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(443, 20);
            label1.TabIndex = 3;
            label1.Text = "Hoşgeldiniz, lütfen kayıt olmak için aşağıdaki alanları doldurunuz ";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(85, 92);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(95, 20);
            lblKullaniciAdi.TabIndex = 4;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 165);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 5;
            label3.Text = "Şifre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 251);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 6;
            label4.Text = "Şifre Tekrarı:";
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(162, 341);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(196, 42);
            btnKayitOl.TabIndex = 7;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // btnİptal
            // 
            btnİptal.Location = new Point(163, 389);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(195, 49);
            btnİptal.TabIndex = 8;
            btnİptal.Text = "İptal";
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click;
            // 
            // YöneticiKayıtOlma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 450);
            Controls.Add(btnİptal);
            Controls.Add(btnKayitOl);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(label1);
            Controls.Add(txtSifreTekrari);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Name = "YöneticiKayıtOlma";
            Text = "YöneticiKayıtOlma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private TextBox txtSifreTekrari;
        private Label label1;
        private Label lblKullaniciAdi;
        private Label label3;
        private Label label4;
        private Button btnKayitOl;
        private Button btnİptal;
    }
}