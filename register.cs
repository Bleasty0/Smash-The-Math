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



        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            // Şifreyi göster kutusu işaretli ise şifreyi düz metin olarak gösterir, değilse gizler
            txtsifre.PasswordChar = chkSifreGoster.Checked ? '\0' : '•';
            txtsifreonayla.PasswordChar = chkSifreGoster.Checked ? '\0' : '•';
        }

        private void kayit_ol_Click(object sender, EventArgs e)
        {
            // Gerekli alanların doldurulup doldurulmadığını kontrol ediyoruz.
            if (txtkullaniciadi.Text == "" || txteposta.Text == "" || txtsifre.Text == "" || txtsifreonayla.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // Şifre ve şifre onayı aynı mı kontrol ediyoruz.
            if (txtsifre.Text != txtsifreonayla.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor.");
                return;
            }

            try
            {
                // SQL bağlantısı kuruyoruz.
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mete\Desktop\Görsel Ve Mat Proje\Smash The Math\Smash The Math\Database1.mdf"";Integrated Security=True"))
                {
                    con.Open();

                    // Kullanıcıyı veritabanına eklemek için SQL komutunu yazıyoruz.
                    string query = "INSERT INTO [Table] (kullanici_adi, [e-posta], sifre) VALUES (@kullanici_adi, @e_posta, @sifre)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Parametreleri tanımlıyoruz.
                        cmd.Parameters.AddWithValue("@kullanici_adi", txtkullaniciadi.Text);
                        cmd.Parameters.AddWithValue("@e_posta", txteposta.Text);
                        cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);

                        // SQL komutunu çalıştırıyoruz.
                        cmd.ExecuteNonQuery();
                    }

                    con.Close();
                }

                MessageBox.Show("Kayıt başarılı. Giriş yapabilirsiniz.");
                signin signin = new signin();
                signin.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısında bir hata oluştu: " + ex.Message);
            }
        }

        private void temizle_butonu_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre alanlarını temizliyoruz.
            txtkullaniciadi.Text = "";
            txteposta.Text = "";
            txtsifre.Text = "";
            txtsifreonayla.Text = "";

            // İmleci kullanıcı adı alanına odaklıyoruz.
            txtkullaniciadi.Focus();
        }

        private void frmRegister_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter tuşuna basıldığında "Giriş Yap" butonuna tıkla
            if (e.KeyCode == Keys.Enter)
            {
                kayit_ol.PerformClick(); // Giriş Yap butonuna tıklar
            }
        }
    }
}