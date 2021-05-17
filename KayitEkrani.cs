using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLab2_3
{
    public partial class KayitEkrani : Form
    {
        Color[] renkler = new Color[6];

        public KayitEkrani()
        {
            InitializeComponent();
            renkler[0] = Color.Gainsboro;
            renkler[1] = Color.FromArgb(92, 182, 195);
            renkler[2] = Color.FromArgb(50, 197, 15);
            renkler[3] = Color.FromArgb(234, 0, 127);
            renkler[4] = Color.FromArgb(255, 156, 0);
            renkler[5] = Color.FromArgb(171, 27, 212);
        }

        public int sayi;
        FavoriProgram favori = new FavoriProgram();

        private void cik_Click(object sender, EventArgs e)
        {
            DialogResult sorgu = MessageBox.Show("Kaydolmadan çıkmak istediğinizden emin misiniz?", "Çıkış Kontrolü", MessageBoxButtons.YesNo);
            if (sorgu == DialogResult.Yes)
            {
                this.TopMost = false;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Height < 10)
            {
                timer1.Stop();
                this.Hide();
                GirisEkrani giris = new GirisEkrani();
                giris.Height = 10;
                giris.Show();
            }
            else
                Height -= 10;
        }

        private void Temizleme(object sender, EventArgs e)
        {
            TextBox alinan = (TextBox)sender;
            alinan.Clear();
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {
            this.Height = 480;
            Karart();
            
            if (sayi == 2)
                goster.Image = Properties.Resources.info2;
            else if (sayi == 3)
                goster.Image = Properties.Resources.info3;
            else if (sayi == 4)
                goster.Image = Properties.Resources.info4;
            else if (sayi == 5)
                goster.Image = Properties.Resources.info5;
            else if (sayi == 6)
                goster.Image = Properties.Resources.info6;

            cik.ForeColor = renkler[sayi - 1];
            kaydol.BackColor = renkler[sayi - 1];
        }

        void Karart()
        {
            pictureBox5.Image = Properties.Resources.name1;
            pictureBox3.Image = Properties.Resources.pass1;
            pictureBox2.Image = Properties.Resources.user1;
            pictureBox4.Image = Properties.Resources.date1;

            panel1.BackColor = Color.Gainsboro;
            panel2.BackColor = Color.Gainsboro;
            panel3.BackColor = Color.Gainsboro;
            panel4.BackColor = Color.Gainsboro;

            sifre.ForeColor = Color.Gainsboro;
            kAdi.ForeColor = Color.Gainsboro;
            textBox2.ForeColor = Color.Gainsboro;
            textBox1.ForeColor = Color.Gainsboro;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            Karart();
            if (textBox2.Text == "Ad - Soyad")
                textBox2.Clear();

            if (sayi == 2)
                pictureBox5.Image = Properties.Resources.name2;
            else if (sayi == 3)
                pictureBox5.Image = Properties.Resources.name3;
            else if (sayi == 4)
                pictureBox5.Image = Properties.Resources.name4;
            else if (sayi == 5)
                pictureBox5.Image = Properties.Resources.name5;
            else if (sayi == 6)
                pictureBox5.Image = Properties.Resources.name6;
            
            panel4.BackColor = renkler[sayi - 1];
            textBox2.ForeColor = renkler[sayi - 1];
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            Karart();
            if (textBox1.Text == "Doğum Tarihi")
                textBox1.Clear();

            if (sayi == 2)
                pictureBox4.Image = Properties.Resources.date2;
            else if (sayi == 3)
                pictureBox4.Image = Properties.Resources.date3;
            else if (sayi == 4)
                pictureBox4.Image = Properties.Resources.date4;
            else if (sayi == 5)
                pictureBox4.Image = Properties.Resources.date5;
            else if (sayi == 6)
                pictureBox4.Image = Properties.Resources.date6;

            panel3.BackColor = renkler[sayi - 1];
            textBox1.ForeColor = renkler[sayi - 1];
        }

        private void kAdi_Click(object sender, EventArgs e)
        {
            Karart();
            if (kAdi.Text == "e-Posta")
                kAdi.Clear();

            if (sayi == 2)
                pictureBox2.Image = Properties.Resources.user2;
            else if (sayi == 3)
                pictureBox2.Image = Properties.Resources.user3;
            else if (sayi == 4)
                pictureBox2.Image = Properties.Resources.user4;
            else if (sayi == 5)
                pictureBox2.Image = Properties.Resources.user5;
            else if (sayi == 6)
                pictureBox2.Image = Properties.Resources.user6;

            panel1.BackColor = renkler[sayi - 1];
            kAdi.ForeColor = renkler[sayi - 1];
        }

        private void sifre_Click(object sender, EventArgs e)
        {
            Karart();
            if (sifre.Text == "Şifre")
            {
                sifre.Clear();
                sifre.PasswordChar = '•';
                goster.Image = Properties.Resources.info1;
            }

            if (sayi == 2)
                pictureBox3.Image = Properties.Resources.pass2;
            else if (sayi == 3)
                pictureBox3.Image = Properties.Resources.pass3;
            else if (sayi == 4)
                pictureBox3.Image = Properties.Resources.pass4;
            else if (sayi == 5)
                pictureBox3.Image = Properties.Resources.pass5;
            else if (sayi == 6)
                pictureBox3.Image = Properties.Resources.pass6;

            panel2.BackColor = renkler[sayi - 1];
            sifre.ForeColor = renkler[sayi - 1];
        }

        private void goster_Click(object sender, EventArgs e)
        {
            if (sifre.PasswordChar == '•')
            {
                sifre.PasswordChar = '\0';
                if (sayi == 2)
                    goster.Image = Properties.Resources.info2;
                else if (sayi == 3)
                    goster.Image = Properties.Resources.info3;
                else if (sayi == 4)
                    goster.Image = Properties.Resources.info4;
                else if (sayi == 5)
                    goster.Image = Properties.Resources.info5;
                else if (sayi == 6)
                    goster.Image = Properties.Resources.info6;
            }
            else
            {
                sifre.PasswordChar = '•';
                goster.Image = Properties.Resources.info1;
            }
        }

        private void kaydol_Click(object sender, EventArgs e)
        {
            string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=netflix.accdb";
            OleDbConnection baglanti = new OleDbConnection(vtyolu);
            baglanti.Open();
            string kontrol = "SELECT * FROM kullanici WHERE mail = '" + kAdi.Text + "'"; ;
            OleDbCommand komut = new OleDbCommand(kontrol, baglanti);
            OleDbDataReader dr;
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Aynı mail adresine sahip bir kayıt zaten var.", "Hata");
            }
            else
            {
                if (kAdi.Text == "" || kAdi.Text == "e-Posta")
                    MessageBox.Show("Lütfen bir e-posta yazarak kaydolmayı deneyin.", "Hata");
                //else if() //veritabanında o email var mı kontrolü
                else if (textBox2.Text == "" || textBox2.Text == "Ad - Soyad")
                    MessageBox.Show("Lütfen adınızı yazarak kaydolmayı deneyin.", "Hata");
                else if (textBox1.Text == "" || textBox1.Text == "Doğum Tarihi")
                    MessageBox.Show("Lütfen doğum tarihinizi ekleyin.", "Hata");
                else
                {
                    this.TopMost = true;

                    kaydol.Enabled = false;
                    cik.Enabled = false;

                    favori.sayi = sayi;
                    favori.Owner = this;
                    favori.ad = textBox2.Text;
                    favori.dogumTarihi = textBox1.Text;
                    favori.email = kAdi.Text;
                    favori.sifre = sifre.Text;
                    favori.Show();
                    favori.Top = Top + 25;
                    timer2.Start();
                }
            }
            baglanti.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            favori.Left += 10;
            if (favori.Left >= Left + Width)
            {
                timer2.Stop();
                this.TopMost = false;
                favori.TopMost = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != '/';
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
