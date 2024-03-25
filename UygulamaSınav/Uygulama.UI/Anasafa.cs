using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uygulama.BL.Manager.Concrete;
using Uygulama.BL.Models;

namespace Uygulama.UI
{
    public partial class Anasafa : Form
    {
        KullaniciManager kullaniciManager = new KullaniciManager();
        AlbumManager albumManager = new AlbumManager();
        SanatciManager sanatciManager = new SanatciManager();
        KullaniciModel kullaniciModel;
        SanatciModel sanatciModel;
        AlbumModel albumModel;
        AlbumModel selectedAlbum;
        SanatciModel selectedSanatci;

        public Anasafa()
        {
            dgvAlbümler.DataSource = albumManager.GetAll();
            cmbSanatci.DataSource = sanatciManager.GetAll();
            InitializeComponent();
        }

        private void txtİndirim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                txtİndirim.Text = "";
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!albumManager.GetAll().Where(m => m.AlbumAdi.ToLower() == txtAdi.Text.ToLower()).Any())
            {
                if (txtAdi.Text == "" || txtFiyat.Text == "" || cmbDurum.SelectedItem == null)
                {
                    msgBosAlanDoldur();
                    selectedAlbum = null;
                }
                else
                {
                    AlbumModel album = new AlbumModel();

                    album.Fiyati = int.Parse(txtFiyat.Text);
                    album.indirim = decimal.Parse(txtİndirim.Text);
                    album.AlbumAdi = txtAdi.Text;


                    KeyValuePair<int, string> selectedSanatci = (KeyValuePair<int, string>)cmbSanatci.SelectedItem;
                    album.SanatciId = selectedSanatci.Key;
                    albumManager.Add(album);
                    msgAddedSuccess("Album");
                    AlbumTextReset();
                    dgvAlbümler.DataSource = albumManager.GetAll();
                    selectedAlbum = null;
                }
            }
            else
            {
                msgAlreadyUsed("YEMEK");
                selectedAlbum = null;
            }
        }
        private void msgBosAlanDoldur()
        {
            MessageBox.Show("LÜTFEN BOŞ ALANLARI DOLDURUNUZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void AlbumTextReset()
        {
            txtAdi.Text = "";
            txtFiyat.Text = "";
            txtİndirim.Text = "";
        }
        private void msgAddedSuccess(string model)
        {
            MessageBox.Show($"{model} Eklenmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void msgAlreadyUsed(string model)
        {
            MessageBox.Show($"ZATEN BÖYLE BİR {model} VAR", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvAlbümler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedAlbum = (AlbumModel)dgvAlbümler.SelectedRows[0].DataBoundItem;
            txtAdi.Text = selectedAlbum.AlbumAdi;
            txtFiyat.Text = selectedAlbum.Fiyati.ToString();
            txtİndirim.Text = selectedAlbum.indirim.ToString();
        }

        private void btngnclle_Click(object sender, EventArgs e)
        {
            if (!albumManager.GetAll().Where(m => m.AlbumAdi.ToLower() == txtAdi.Text.ToLower()).Any())
            {
                if (selectedAlbum == null)
                {
                    msgUpdateForModel("Album");
                    AlbumTextReset();
                }
                else
                {
                    selectedAlbum.Fiyati = int.Parse(txtFiyat.Text);
                    selectedAlbum.AlbumAdi = txtAdi.Text;
                    selectedAlbum.indirim = decimal.Parse(txtİndirim.Text);
                    albumManager.Update(selectedAlbum);
                    msgUpdateSuccessed("Album");
                    AlbumTextReset();
                    dgvAlbümler.DataSource = albumManager.GetAll();
                    selectedAlbum = null;
                }
            }
            else
            {
                msgAlreadyUsed("YEMEK");
                selectedAlbum = null;
            }
        }


        private void msgForRemove(string model)
        {
            MessageBox.Show($"SİLMEK İÇİN BİR {model} SEÇİNİZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void msgRemoveSuccessed(string model)
        {
            MessageBox.Show($"{model} Silinmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void msgUpdateSuccessed(string model)
        {
            MessageBox.Show($"{model} Güncellenmiştir", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void msgUpdateForModel(string model)
        {
            MessageBox.Show($"GUNCELLEMEK İÇİN BİR {model} SEÇİNİZ", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (selectedAlbum == null)
            {
                msgForRemove("YEMEK");
                return;
            }
            else
            {
                albumManager.Remove(selectedAlbum);
                msgRemoveSuccessed("Yemek");
                AlbumTextReset();
                dgvAlbümler.DataSource = albumManager.GetAll();
                selectedAlbum = null;
            }
        }
    }

}
