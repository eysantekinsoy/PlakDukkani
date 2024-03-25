namespace Uygulama.UI
{
	partial class Anasafa
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
			btnEkle = new Button();
			btnSil = new Button();
			btngnclle = new Button();
			dgvAlbümler = new DataGridView();
			btnListele = new Button();
			((System.ComponentModel.ISupportInitialize)dgvAlbümler).BeginInit();
			SuspendLayout();
			// 
			// btnEkle
			// 
			btnEkle.Location = new Point(222, 289);
			btnEkle.Name = "btnEkle";
			btnEkle.Size = new Size(111, 65);
			btnEkle.TabIndex = 1;
			btnEkle.Text = "Ekle";
			btnEkle.UseVisualStyleBackColor = true;
			// 
			// btnSil
			// 
			btnSil.Location = new Point(379, 289);
			btnSil.Name = "btnSil";
			btnSil.Size = new Size(111, 65);
			btnSil.TabIndex = 2;
			btnSil.Text = "Sil";
			btnSil.UseVisualStyleBackColor = true;
			// 
			// btngnclle
			// 
			btngnclle.Location = new Point(513, 289);
			btngnclle.Name = "btngnclle";
			btngnclle.Size = new Size(111, 65);
			btngnclle.TabIndex = 3;
			btngnclle.Text = "Güncelle";
			btngnclle.UseVisualStyleBackColor = true;
			// 
			// dgvAlbümler
			// 
			dgvAlbümler.BackgroundColor = Color.Beige;
			dgvAlbümler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvAlbümler.Location = new Point(222, 73);
			dgvAlbümler.Name = "dgvAlbümler";
			dgvAlbümler.Size = new Size(402, 150);
			dgvAlbümler.TabIndex = 4;
			// 
			// btnListele
			// 
			btnListele.Location = new Point(329, 373);
			btnListele.Name = "btnListele";
			btnListele.Size = new Size(202, 33);
			btnListele.TabIndex = 5;
			btnListele.Text = "Albümleri Listele";
			btnListele.UseVisualStyleBackColor = true;
			// 
			// Anasafa
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.pexels_ylanite_koppens_934067;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(800, 450);
			Controls.Add(btnListele);
			Controls.Add(dgvAlbümler);
			Controls.Add(btngnclle);
			Controls.Add(btnSil);
			Controls.Add(btnEkle);
			Name = "Anasafa";
			Text = "Anasafa";
			((System.ComponentModel.ISupportInitialize)dgvAlbümler).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Button btnEkle;
		private Button btnSil;
		private Button btngnclle;
		private DataGridView dgvAlbümler;
		private Button btnListele;
	}
}