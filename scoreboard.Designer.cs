﻿namespace skor_tablo
{
    partial class scoreboard
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullanici_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siralama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplam_puan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.skor_anasyf_don = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullanici_adi,
            this.siralama,
            this.toplam_puan});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(65, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(672, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.FillWeight = 94.96875F;
            this.kullanici_adi.HeaderText = "Kullanıcı Adı";
            this.kullanici_adi.MinimumWidth = 6;
            this.kullanici_adi.Name = "kullanici_adi";
            // 
            // siralama
            // 
            this.siralama.FillWeight = 105.1415F;
            this.siralama.HeaderText = "Sıralama";
            this.siralama.MinimumWidth = 6;
            this.siralama.Name = "siralama";
            // 
            // toplam_puan
            // 
            this.toplam_puan.FillWeight = 99.88974F;
            this.toplam_puan.HeaderText = "Toplam Puan";
            this.toplam_puan.MinimumWidth = 6;
            this.toplam_puan.Name = "toplam_puan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(315, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skor Tablosu";
            // 
            // skor_anasyf_don
            // 
            this.skor_anasyf_don.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skor_anasyf_don.BackColor = System.Drawing.Color.Gold;
            this.skor_anasyf_don.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skor_anasyf_don.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.skor_anasyf_don.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skor_anasyf_don.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skor_anasyf_don.ForeColor = System.Drawing.Color.Black;
            this.skor_anasyf_don.Location = new System.Drawing.Point(653, 10);
            this.skor_anasyf_don.Margin = new System.Windows.Forms.Padding(4);
            this.skor_anasyf_don.Name = "skor_anasyf_don";
            this.skor_anasyf_don.Size = new System.Drawing.Size(141, 47);
            this.skor_anasyf_don.TabIndex = 6;
            this.skor_anasyf_don.Text = "Ana Sayfaya Dön";
            this.skor_anasyf_don.UseVisualStyleBackColor = false;
            this.skor_anasyf_don.Click += new System.EventHandler(this.skor_anasyf_don_Click);
            // 
            // scoreboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.skor_anasyf_don);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "scoreboard";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanici_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn siralama;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplam_puan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button skor_anasyf_don;
    }
}

