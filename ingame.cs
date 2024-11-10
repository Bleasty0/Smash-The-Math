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
        public ingame()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Yeni bir Form2 nesnesi oluşturuyoruz
            start_basla form2 = new start_basla();

            // Form2'yi gösteriyoruz
            form2.Show(); 
        }

        private void ana_syf_Click(object sender, EventArgs e)
        {
            start_basla start = new start_basla();
            start.Show();
            this.Close();
        }
    }
}
