using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smash_The_Math
{
    public partial class ingame : Form
    {

        private Timer timer;
        private int timeLeft = 15;
        private int moveStep = 7;
        private int lives = 3; // Can sayısı

        public ingame()
        {
            InitializeComponent();
            InitializeTimer();
            label1.Text = lives.ToString(); // Can sayısını başlangıçta göster
        }

        private void InitializeTimer()
        {
            // Timer ayarları
            timer = new Timer();
            timer.Interval = 1000; // Her 1 saniyede bir tetiklenecek
            timer.Tick += Timer_Tick;
            timer.Start();

            // Süre başlangıç değeri
            label4.Text = $"00:{timeLeft:D2}";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Süreyi güncelle
                timeLeft--;
                label4.Text = $"00:{timeLeft:D2}";

                // Pres makinesini her saniye moveStep kadar aşağıya hareket ettir
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + moveStep);
            }
            else
            {
                // Süre dolduğunda can kaybı işlemi
                LoseLife();
            }
        }

        private void LoseLife()
        {
            // Can sayısını azalt
            lives--;
            label1.Text = lives.ToString(); // Güncellenen can sayısını göster

            // Can sayısı 0 olduğunda oyunu bitir
            if (lives <= 0)
            {
                timer.Stop();
                MessageBox.Show("Tüm canlar tükendi, oyun bitti!");

                // Ana ekrana geri dönme
                start_basla start = new start_basla(); // Ana ekran formunu tanımlayın
                start.Show(); // Ana ekran formunu göster
                this.Hide(); // Şu anki formu kapat
            }
            else
            {
                // Süreyi ve pres makinesinin konumunu sıfırla
                timeLeft = 15;
                label4.Text = $"00:{timeLeft:D2}";
                pictureBox2.Location = new Point(pictureBox2.Location.X, -585); // Başlangıç konumuna geri taşı
                timer.Start(); // Tekrar başlat
                MessageBox.Show("Can kaybettiniz! Bir sonraki denemeye geçiliyor.");
            }
        }

        private void ana_syf_Click(object sender, EventArgs e)
        {
            start_basla start = new start_basla();
            start.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "√";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }
    }
}
