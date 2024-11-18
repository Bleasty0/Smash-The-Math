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
            // Şifrenin gizlenmesini sağlamak için PasswordChar özelliğini ayarlıyoruz.
            txtsifre.PasswordChar = '•';
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

            try
            {
                // SQL bağlantısını aç
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Mete\Desktop\Görsel Ve Mat Proje\Smash The Math\Smash The Math\Database1.mdf"";Integrated Security=True"))
                {
                    con.Open();

                    // Kullanıcı adı ve şifreyi kontrol etmek için SQL komutu
                    string query = "SELECT COUNT(1) FROM [Table] WHERE kullanici_adi = @kullanici_adi AND sifre = @sifre";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@kullanici_adi", txtkullaniciadi.Text);
                        cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1)
                        {
                            // Giriş başarılı, ana formu aç
                            MessageBox.Show("Giriş başarılı!");

                            // Kullanıcı giriş yaptı, kullanıcı adını global değişkene at
                            GlobalVariables.KullaniciAdi = txtkullaniciadi.Text;

                            // Ana formu aç
                            start_basla startBasla = new start_basla();
                            startBasla.Show();
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
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısında bir hata oluştu: " + ex.Message);
            }
        }

        private void chkSifreGoster_CheckedChanged_1(object sender, EventArgs e)
        {
            // Şifreyi göster kutusu işaretli ise şifreyi düz metin olarak gösterir, değilse gizler
            txtsifre.PasswordChar = chkSifreGoster.Checked ? '\0' : '•';
        }

        private void temizle_butonu_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifre alanlarını temizliyoruz.
            txtkullaniciadi.Text = "";
            txtsifre.Text = "";

            // İmleci kullanıcı adı alanına odaklıyoruz.
            txtkullaniciadi.Focus();
        }

        private void signin_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter tuşuna basıldığında "Giriş Yap" butonuna tıkla
            if (e.KeyCode == Keys.Enter)
            {
                giris_yap.PerformClick(); // Giriş Yap butonuna tıklar
            }
        }
    }
}