using Görsel_Programlama_Oyunu;
using Smash_The_Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skor_tablo
{
    public partial class kullanici_profil : Form
    {
        public kullanici_profil()
        {
            InitializeComponent();
        }

        private void cıkis_Click(object sender, EventArgs e)
        {
            signin signin = new signin();
            signin.Show();
            this.Hide();
        }

        private void bilgilerim_Click(object sender, EventArgs e)
        {
            bilgi_panel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start_basla start = new start_basla();
            start.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Profil Fotoğrafını Seç";
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Seçilen dosyayı PictureBox'a yükle
                pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }


}
