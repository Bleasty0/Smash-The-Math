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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signin girisFormu = new signin(); // Giriş ekranını açıyoruz
            girisFormu.Show(); // Giriş ekranını gösteriyoruz
            this.Hide(); // Kayıt ekranını gizliyoruz (kapatmadan)
        }
    }
}
