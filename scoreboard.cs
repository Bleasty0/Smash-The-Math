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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void button1_Click(object sender, EventArgs e)
        {
            /*  Form3 form3 = new Form3();

            
            form3.Show();   */
        }
    }
}
