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
    public partial class GirisEkrani : Form
    {
        Color[] renkler = new Color[6];

        public GirisEkrani()
        {
            InitializeComponent();
            renkler[0] = Color.Gainsboro;
            renkler[1] = Color.FromArgb(92, 182, 195);
            renkler[2] = Color.FromArgb(50, 197, 15);
            renkler[3] = Color.FromArgb(234, 0, 127);
            renkler[4] = Color.FromArgb(255, 156, 0);
            renkler[5] = Color.FromArgb(171, 27, 212);
        }

        int sayi, kapat = 1;
        int xKonum, yKonum;
        string standartSifre = "Şifre", standartKullanici = "e-Posta";
        KayitEkrani kayitOl = new KayitEkrani();
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=netflix.accdb");
        OleDbCommand cmd;
        OleDbDataReader dr;

        private void kAdi_Click(object sender, EventArgs e)
        {
            if (kAdi.Text == standartKullanici)
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

            pictureBox3.Image = Properties.Resources.pass1;
            panel2.BackColor = Color.Gainsboro;
            sifre.ForeColor = Color.Gainsboro;
        }

        private void cik_Click(object sender, EventArgs e)
        {
            kapat = 1;
            timer4.Start();
        }

        private void kayit_Click(object sender, EventArgs e)
        {
            this.TopMost = true;

            kayit.Enabled = false;
            giris.Enabled = false;
            cik.Enabled = false;

            kayitOl.sayi = sayi;
            kayitOl.Height = 420;
            kayitOl.Show();

            timer1.Start();
        }

        private void sifre_Click(object sender, EventArgs e)
        {
            if (sifre.Text == standartSifre)
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
            pictureBox2.Image = Properties.Resources.user1;
            panel1.BackColor = Color.Gainsboro;
            kAdi.ForeColor = Color.Gainsboro;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            kayitOl.Left -= 10;
            if (kayitOl.Left <= xKonum)
            {
                timer2.Stop();
                this.Hide();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Height > 470)
                timer3.Stop();
            else
                Height += 10;
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

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (Height < 10)
            {
                timer4.Stop();
                if (kapat == 1)
                    Application.Exit();
                else
                    this.Hide();
            }
            else
            {
                Height -= 10;
                Width -= 8;
            }
        }

        private void giris_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT *FROM kullanici WHERE mail = '" + kAdi.Text + "' AND sifre = '" + sifre.Text + "'";
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                AnaMenu anaMenu = new AnaMenu();
                anaMenu.mail = kAdi.Text;
                this.Hide();
                anaMenu.Show();
            }
            else
            {
                label1.Text = "Kullanıcı adı / şifre hatalıdır.";
            }
            con.Close();
        }

        private void kAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                giris_Click(null, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kayitOl.Left += 10;
            if (kayitOl.Left >= xKonum+Width)
            {
                timer1.Stop();
                this.TopMost = false;
                kayitOl.TopMost = true;
                timer2.Start();
            }
        }

        private void Temizleme(object sender, EventArgs e)
        {
            TextBox alinan = (TextBox)sender;
            alinan.Clear();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            kayit.Enabled = true;
            giris.Enabled = true;
            cik.Enabled = true;

            xKonum = Left;
            yKonum = Top;

            if (Height != 480)
            {
                this.DesktopLocation = new Point(this.Location.X, this.Location.Y - 205);
                timer3.Start();
            }
            else
                this.DesktopLocation = new Point(this.Location.X, this.Location.Y +30);

            Random rastgele = new Random();
            sayi = rastgele.Next(2, 7);

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

            giris.BackColor = renkler[sayi - 1];
            cik.ForeColor = renkler[sayi - 1];
        }
    }
}
