    using skor_tablo;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Smash_The_Math
    {
        public partial class start_basla : Form
        {
            public start_basla()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                ingame ingame = new ingame();
                ingame.Show();
                this.Hide();
            }

            private void skor_tablo_buton_Click(object sender, EventArgs e)
            {
                scoreboard scoreboard = new scoreboard();
                scoreboard.Show();
                this.Hide();

            }

            private void button3_Click(object sender, EventArgs e)
            {
                kullanici_profil kullanici_Profil = new kullanici_profil();
                kullanici_Profil.Show();
                this.Hide();
            }

            private void profile_buton_Click(object sender, EventArgs e)
            {
                kullanici_profil kullanici_Profil = new kullanici_profil();
                kullanici_Profil.Show();
                this.Hide();
            }

            private void profile_buton_Paint(object sender, PaintEventArgs e)
            {
                Button btn = sender as Button;
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, btn.Width, btn.Height);
                btn.Region = new Region(path);
            }
        }
    }    

