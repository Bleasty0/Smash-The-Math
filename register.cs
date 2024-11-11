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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            txtsifre.PasswordChar = '•';
            txtsifreonayla.PasswordChar = '•';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signin girisFormu = new signin(); // Giriş ekranını açıyoruz
            girisFormu.Show(); // Giriş ekranını gösteriyoruz
            this.Hide(); // Kayıt ekranını gizliyoruz (kapatmadan)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcı bilgilerinin girildiğinden emin olun
            if (txtkullaniciadi.Text == "" || txteposta.Text == "" || txtsifre.Text == "" || txtsifreonayla.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // Şifre ve şifre onayı aynı mı kontrol et
            if (txtsifre.Text != txtsifreonayla.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor.");
                return;
            }

            // SQL bağlantısını aç
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-PR7BV4J\\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True"))
            {
                con.Open();

                // Kullanıcıyı eklemek için SQL komutu
                string query = "INSERT INTO Kullanici_tablosu (kullanici_adi, e_mail, sifre) VALUES (@kullanici_adi, @e_mail, @sifre)";



                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Parametreleri ekleyin
                    cmd.Parameters.AddWithValue("@kullanici_adi", txtkullaniciadi.Text);
                    cmd.Parameters.AddWithValue("@e_mail", txteposta.Text);
                    cmd.Parameters.AddWithValue("@sifre", txtsifre.Text); // Şifreyi hashleyerek kaydetmek daha güvenlidir.

                    // Komutu çalıştır
                    cmd.ExecuteNonQuery();
                }

                con.Close();
            }

            MessageBox.Show("Kayıt başarılı. Giriş yapabilirsiniz.");
        }

        private void txtsifreonayla_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            // Şifreyi göster kutusu işaretli ise şifreyi düz metin olarak gösterir, değilse gizler
            txtsifre.PasswordChar = chkSifreGoster.Checked ? '\0' : '•';
            txtsifreonayla.PasswordChar = chkSifreGoster.Checked ? '\0' : '•';
        }
    }
}
