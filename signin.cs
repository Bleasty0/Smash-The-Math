using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister kayitFormu = new frmRegister(); // Kayıt ekranını açıyoruz
            kayitFormu.Show(); // Kayıt ekranını gösteriyoruz
            this.Hide(); // Giriş ekranını gizliyoruz (kapatmadan)
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
