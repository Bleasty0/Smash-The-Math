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
    public partial class scoreboard : Form
    {
        public scoreboard()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
                new object[]
                {
                    "Mert Kapar",
                    1,
                    59

                }
                );

            dataGridView1.Rows.Add(
                new object[]
                {
                    "Mete Yusuf Gündoğdu",
                    2,
                    42

                }
                );

            dataGridView1.Rows.Add(
                new object[]
                {
                    "Tuğbanur Dualı",
                    3,
                    35

                }
                );
        }

        private void skor_anasyf_don_Click(object sender, EventArgs e)
        {
            start_basla start = new start_basla();
            start.Show();
            this.Hide();
        }
    }
}
