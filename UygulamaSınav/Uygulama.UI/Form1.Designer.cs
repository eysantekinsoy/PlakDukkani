namespace Uygulama.UI
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btngiris = new Button();
			btnkayitol = new Button();
			txtbxKullaniciAdi = new TextBox();
			txtbxKullaniciSifre = new TextBox();
			SuspendLayout();
			// 
			// btngiris
			// 
			btngiris.Location = new Point(292, 288);
			btngiris.Name = "btngiris";
			btngiris.Size = new Size(75, 23);
			btngiris.TabIndex = 0;
			btngiris.Text = "Gİriş Yap";
			btngiris.UseVisualStyleBackColor = true;
			btngiris.Click += btngiris_Click;
			// 
			// btnkayitol
			// 
			btnkayitol.Location = new Point(411, 288);
			btnkayitol.Name = "btnkayitol";
			btnkayitol.Size = new Size(75, 23);
			btnkayitol.TabIndex = 1;
			btnkayitol.Text = "Kayıt Ol";
			btnkayitol.UseVisualStyleBackColor = true;
			// 
			// txtbxKullaniciAdi
			// 
			txtbxKullaniciAdi.Location = new Point(292, 172);
			txtbxKullaniciAdi.Name = "txtbxKullaniciAdi";
			txtbxKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
			txtbxKullaniciAdi.Size = new Size(194, 23);
			txtbxKullaniciAdi.TabIndex = 2;
			// 
			// txtbxKullaniciSifre
			// 
			txtbxKullaniciSifre.Location = new Point(292, 232);
			txtbxKullaniciSifre.Name = "txtbxKullaniciSifre";
			txtbxKullaniciSifre.PlaceholderText = "Şifre";
			txtbxKullaniciSifre.Size = new Size(194, 23);
			txtbxKullaniciSifre.TabIndex = 3;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.pexels_elviss_railijs_bitāns_1389429;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(800, 450);
			Controls.Add(txtbxKullaniciSifre);
			Controls.Add(txtbxKullaniciAdi);
			Controls.Add(btnkayitol);
			Controls.Add(btngiris);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btngiris;
		private Button btnkayitol;
		private TextBox txtbxKullaniciAdi;
		private TextBox txtbxKullaniciSifre;
	}
}
