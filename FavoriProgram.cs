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
    public partial class FavoriProgram : Form
    {
        Color[] renkler = new Color[6];
        int[] secim = new int[10];
        public string ad, dogumTarihi, email, sifre;

        public FavoriProgram()
        {
            InitializeComponent();
            renkler[0] = Color.Gainsboro;
            renkler[1] = Color.FromArgb(92, 182, 195);
            renkler[2] = Color.FromArgb(50, 197, 15);
            renkler[3] = Color.FromArgb(234, 0, 127);
            renkler[4] = Color.FromArgb(255, 156, 0);
            renkler[5] = Color.FromArgb(171, 27, 212);

            for (int i = 0; i < 10; i++)
                secim[i] = 0;
        }

        public int sayi;

        private void FavoriProgram_Load(object sender, EventArgs e)
        {
            if (sayi == 2)
            {
                pictureBox0.Image = Properties.Resources.tik2;
                pictureBox1.Image = Properties.Resources.tik2;
                pictureBox2.Image = Properties.Resources.tik2;
                pictureBox3.Image = Properties.Resources.tik2;
                pictureBox4.Image = Properties.Resources.tik2;
                pictureBox5.Image = Properties.Resources.tik2;
                pictureBox6.Image = Properties.Resources.tik2;
                pictureBox7.Image = Properties.Resources.tik2;
                pictureBox8.Image = Properties.Resources.tik2;
                pictureBox9.Image = Properties.Resources.tik2;
            }
            else if (sayi == 3)
            {
                pictureBox0.Image = Properties.Resources.tik3;
                pictureBox1.Image = Properties.Resources.tik3;
                pictureBox2.Image = Properties.Resources.tik3;
                pictureBox3.Image = Properties.Resources.tik3;
                pictureBox4.Image = Properties.Resources.tik3;
                pictureBox5.Image = Properties.Resources.tik3;
                pictureBox6.Image = Properties.Resources.tik3;
                pictureBox7.Image = Properties.Resources.tik3;
                pictureBox8.Image = Properties.Resources.tik3;
                pictureBox9.Image = Properties.Resources.tik3;
            }
            else if (sayi == 4)
            {
                pictureBox0.Image = Properties.Resources.tik4;
                pictureBox1.Image = Properties.Resources.tik4;
                pictureBox2.Image = Properties.Resources.tik4;
                pictureBox3.Image = Properties.Resources.tik4;
                pictureBox4.Image = Properties.Resources.tik4;
                pictureBox5.Image = Properties.Resources.tik4;
                pictureBox6.Image = Properties.Resources.tik4;
                pictureBox7.Image = Properties.Resources.tik4;
                pictureBox8.Image = Properties.Resources.tik4;
                pictureBox9.Image = Properties.Resources.tik4;
            }
            else if (sayi == 5)
            {
                pictureBox0.Image = Properties.Resources.tik5;
                pictureBox1.Image = Properties.Resources.tik5;
                pictureBox2.Image = Properties.Resources.tik5;
                pictureBox3.Image = Properties.Resources.tik5;
                pictureBox4.Image = Properties.Resources.tik5;
                pictureBox5.Image = Properties.Resources.tik5;
                pictureBox6.Image = Properties.Resources.tik5;
                pictureBox7.Image = Properties.Resources.tik5;
                pictureBox8.Image = Properties.Resources.tik5;
                pictureBox9.Image = Properties.Resources.tik5;
            }
            else if (sayi == 6)
            {
                pictureBox0.Image = Properties.Resources.tik6;
                pictureBox1.Image = Properties.Resources.tik6;
                pictureBox2.Image = Properties.Resources.tik6;
                pictureBox3.Image = Properties.Resources.tik6;
                pictureBox4.Image = Properties.Resources.tik6;
                pictureBox5.Image = Properties.Resources.tik6;
                pictureBox6.Image = Properties.Resources.tik6;
                pictureBox7.Image = Properties.Resources.tik6;
                pictureBox8.Image = Properties.Resources.tik6;
                pictureBox9.Image = Properties.Resources.tik6;
            }

            label1.ForeColor = renkler[sayi - 1];
            label2.BackColor = renkler[sayi - 1];
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=netflix.accdb";
            OleDbConnection baglanti = new OleDbConnection(vtyolu);
            baglanti.Open();
            string ekle = "insert into kullanici(adSoyad,mail,sifre,dogumTarihi) values (@ismi,@maili,@sifresi,@dtarihi)";
            OleDbCommand komut = new OleDbCommand(ekle, baglanti);
            komut.Parameters.AddWithValue("@ismi", ad);
            komut.Parameters.AddWithValue("@maili", email);
            komut.Parameters.AddWithValue("@sifresi", sifre);
            komut.Parameters.AddWithValue("@dtarihi", dogumTarihi);
            komut.ExecuteNonQuery();
            baglanti.Close();

            var form1 = Owner;
            form1.RemoveOwnedForm(this);
            form1.Close();
            this.Close();
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.mail = email;
            anaMenu.Show();
        }

        private void secimYap(object sender, EventArgs e)
        {
            Label alinan = (Label)sender;
            int degisecek = Convert.ToInt32(alinan.Name.Substring(1));
            secim[degisecek] = secim[degisecek] == 1 ? 0 : 1;
            Goruntuleme();
        }

        void Goruntuleme()
        {
            pictureBox0.Visible = secim[0] != 0;
            pictureBox1.Visible = secim[1] != 0;
            pictureBox2.Visible = secim[2] != 0;
            pictureBox3.Visible = secim[3] != 0;
            pictureBox4.Visible = secim[4] != 0;
            pictureBox5.Visible = secim[5] != 0;
            pictureBox6.Visible = secim[6] != 0;
            pictureBox7.Visible = secim[7] != 0;
            pictureBox8.Visible = secim[8] != 0;
            pictureBox9.Visible = secim[9] != 0;
        }
    }
}
