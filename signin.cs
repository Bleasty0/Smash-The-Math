using Smash_The_Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görsel_Programlama_Oyunu
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
            // Şifrenin gizlenmesini sağlamak için PasswordChar özelliğini ayarlıyoruz. Değişti.
            txtsifre.PasswordChar = '•';
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister kayitFormu = new frmRegister(); // Kayıt ekranını açıyoruz
            kayitFormu.Show(); // Kayıt ekranını gösteriyoruz
            this.Hide(); // Giriş ekranını gizliyoruz (kapatmadan)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı veya şifre boşsa uyarı ver
            if (txtkullaniciadi.Text == "" || txtsifre.Text == "")
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifreyi girin.");
                return;
            }

            // SQL bağlantısını aç
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-PR7BV4J\\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True"))
            {
                con.Open();

                // Kullanıcı adı ve şifreyi kontrol etmek için SQL komutu
                string query = "SELECT COUNT(1) FROM kullanici_tablosu WHERE kullanici_adi=@kullanici_adi AND sifre=@sifre";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@kullanici_adi", txtkullaniciadi.Text);
                    cmd.Parameters.AddWithValue("@sifre", txtsifre.Text); // Şifre hashlenmiş ise burada da hashlenmiş haliyle kontrol edin.

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        // Giriş başarılı, ana formu aç
                        MessageBox.Show("Giriş başarılı!");
                        start_basla start_basla = new start_basla(); // Ana formunuzu burada tanımlayın
                        start_basla.Show();
                        this.Hide(); // Giriş formunu gizle
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                    }
                }

                con.Close();
            }
        }
        private void chkSifreGoster_CheckedChanged_1(object sender, EventArgs e)
        {
            // Şifreyi göster kutusu işaretli ise şifreyi düz metin olarak gösterir, değilse gizler
            txtsifre.PasswordChar = chkSifreGoster.Checked ? '\0' : '•';
        }
    }
}
