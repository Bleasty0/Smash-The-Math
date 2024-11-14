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
        public ingame()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeGame()
        {
            // Timer ayarları
            timer = new Timer();
            timer.Interval = 1000; // Her 1 saniyede bir tetiklenecek
            timer.Tick += Timer_Tick;
            timer.Start();

            // Süre başlangıç değeri
            label4.Text = $"00:{timeLeft:D2}";
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
                timeLeft--; // Süreden 1 saniye düş
                label4.Text = "00:" + timeLeft.ToString("D2"); // Süreyi güncelle
            }
            else
            {
                timer.Stop(); // Süre bittiğinde timer durdur
                MessageBox.Show("Süre doldu!"); // İsteğe bağlı: süre dolduğunda bir uyarı göster
                // Burada süre bittiğinde yapılacak diğer işlemleri ekleyebilirsiniz.
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

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
