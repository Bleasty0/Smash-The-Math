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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
           
                Button btn = sender as Button;
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, btn.Width, btn.Height);
                btn.Region = new Region(path);
        }
    }
}
