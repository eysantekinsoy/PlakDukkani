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
            txtAdi = new TextBox();
            txtFiyat = new TextBox();
            cmbDurum = new ComboBox();
            txtİndirim = new TextBox();
            cmbSanatci = new ComboBox();
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
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(379, 289);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(111, 65);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btngnclle
            // 
            btngnclle.Location = new Point(513, 289);
            btngnclle.Name = "btngnclle";
            btngnclle.Size = new Size(111, 65);
            btngnclle.TabIndex = 3;
            btngnclle.Text = "Güncelle";
            btngnclle.UseVisualStyleBackColor = true;
            btngnclle.Click += btngnclle_Click;
            // 
            // dgvAlbümler
            // 
            dgvAlbümler.BackgroundColor = Color.Beige;
            dgvAlbümler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbümler.Location = new Point(222, 73);
            dgvAlbümler.Name = "dgvAlbümler";
            dgvAlbümler.ReadOnly = true;
            dgvAlbümler.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dgvAlbümler.Size = new Size(402, 150);
            dgvAlbümler.TabIndex = 4;
            dgvAlbümler.CellMouseClick += dgvAlbümler_CellMouseClick;
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
            // txtAdi
            // 
            txtAdi.Location = new Point(92, 272);
            txtAdi.Name = "txtAdi";
            txtAdi.PlaceholderText = "Albüm Adi";
            txtAdi.Size = new Size(100, 23);
            txtAdi.TabIndex = 6;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(113, 212);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.PlaceholderText = "Fiyat";
            txtFiyat.Size = new Size(100, 23);
            txtFiyat.TabIndex = 8;
            // 
            // cmbDurum
            // 
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(82, 171);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(121, 23);
            cmbDurum.TabIndex = 9;
            // 
            // txtİndirim
            // 
            txtİndirim.Location = new Point(92, 311);
            txtİndirim.Name = "txtİndirim";
            txtİndirim.PlaceholderText = "İndirim Oranı";
            txtİndirim.Size = new Size(100, 23);
            txtİndirim.TabIndex = 10;
            txtİndirim.KeyPress += txtİndirim_KeyPress;
            // 
            // cmbSanatci
            // 
            cmbSanatci.FormattingEnabled = true;
            cmbSanatci.Location = new Point(23, 241);
            cmbSanatci.Name = "cmbSanatci";
            cmbSanatci.Size = new Size(121, 23);
            cmbSanatci.TabIndex = 11;
            // 
            // Anasafa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pexels_ylanite_koppens_934067;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbSanatci);
            Controls.Add(txtİndirim);
            Controls.Add(cmbDurum);
            Controls.Add(txtFiyat);
            Controls.Add(txtAdi);
            Controls.Add(btnListele);
            Controls.Add(dgvAlbümler);
            Controls.Add(btngnclle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Name = "Anasafa";
            Text = "Anasafa";
            ((System.ComponentModel.ISupportInitialize)dgvAlbümler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEkle;
		private Button btnSil;
		private Button btngnclle;
		private DataGridView dgvAlbümler;
		private Button btnListele;
        private TextBox txtAdi;
        private TextBox txtFiyat;
        private ComboBox cmbDurum;
        private TextBox txtİndirim;
        private ComboBox cmbSanatci;
    }
}