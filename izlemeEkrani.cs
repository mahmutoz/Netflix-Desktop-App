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
    public partial class izlemeEkrani : Form
    {
        public string mailAdresi;
        public int sure = 0;
        int verilenPuan = 0;
        public int bolum = 1;
        public int p_id;
        int tiktak = 0;
        public izlemeEkrani()
        {
            InitializeComponent();
        }

        private void izlemeEkrani_Load(object sender, EventArgs e)
        {
            int saat, dakika, saniye;
            saat = sure / 60;
            dakika = sure % 60;
            string toplamSure = saat.ToString() + " : ";
            if (dakika < 10)
                toplamSure += "0";
            toplamSure += dakika.ToString();
            toplamSure += " : 00";
            max.Text = toplamSure;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Image = Properties.Resources.dolu;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Image = Properties.Resources.dolu;
            p2.Image = Properties.Resources.dolu;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Image = Properties.Resources.dolu;
            p2.Image = Properties.Resources.dolu;
            p3.Image = Properties.Resources.dolu;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Image = Properties.Resources.dolu;
            p2.Image = Properties.Resources.dolu;
            p3.Image = Properties.Resources.dolu;
            p4.Image = Properties.Resources.dolu;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Image = Properties.Resources.dolu;
            p2.Image = Properties.Resources.dolu;
            p3.Image = Properties.Resources.dolu;
            p4.Image = Properties.Resources.dolu;
            p5.Image = Properties.Resources.dolu;
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Image = Properties.Resources.dolu;
            p2.Image = Properties.Resources.dolu;
            p3.Image = Properties.Resources.dolu;
            p4.Image = Properties.Resources.dolu;
            p5.Image = Properties.Resources.dolu;
            p6.Image = Properties.Resources.dolu;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Image = Properties.Resources.dolu;
            p2.Image = Properties.Resources.dolu;
            p3.Image = Properties.Resources.dolu;
            p4.Image = Properties.Resources.dolu;
            p5.Image = Properties.Resources.dolu;
            p6.Image = Properties.Resources.dolu;
            p7.Image = Properties.Resources.dolu;
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Image = Properties.Resources.dolu;
            p2.Image = Properties.Resources.dolu;
            p3.Image = Properties.Resources.dolu;
            p4.Image = Properties.Resources.dolu;
            p5.Image = Properties.Resources.dolu;
            p6.Image = Properties.Resources.dolu;
            p7.Image = Properties.Resources.dolu;
            p8.Image = Properties.Resources.dolu;
        }

        private void p9_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Image = Properties.Resources.dolu;
            p2.Image = Properties.Resources.dolu;
            p3.Image = Properties.Resources.dolu;
            p4.Image = Properties.Resources.dolu;
            p5.Image = Properties.Resources.dolu;
            p6.Image = Properties.Resources.dolu;
            p7.Image = Properties.Resources.dolu;
            p8.Image = Properties.Resources.dolu;
            p9.Image = Properties.Resources.dolu;
        }

        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Image = Properties.Resources.dolu;
            p2.Image = Properties.Resources.dolu;
            p3.Image = Properties.Resources.dolu;
            p4.Image = Properties.Resources.dolu;
            p5.Image = Properties.Resources.dolu;
            p6.Image = Properties.Resources.dolu;
            p7.Image = Properties.Resources.dolu;
            p8.Image = Properties.Resources.dolu;
            p9.Image = Properties.Resources.dolu;
            p10.Image = Properties.Resources.dolu;
        }

        private void tik(object sender, EventArgs e)
        {
            PictureBox resim = (PictureBox)sender;
            verilenPuan = Convert.ToInt32(resim.Name.Substring(1));
        }

        private void ayrilik(object sender, EventArgs e)
        {
            p10.Image = verilenPuan >= 10 ? Properties.Resources.dolu : Properties.Resources.bos;
            p9.Image = verilenPuan >= 9 ? Properties.Resources.dolu : Properties.Resources.bos;
            p8.Image = verilenPuan >= 8 ? Properties.Resources.dolu : Properties.Resources.bos;
            p7.Image = verilenPuan >= 7 ? Properties.Resources.dolu : Properties.Resources.bos;
            p6.Image = verilenPuan >= 6 ? Properties.Resources.dolu : Properties.Resources.bos;
            p5.Image = verilenPuan >= 5 ? Properties.Resources.dolu : Properties.Resources.bos;
            p4.Image = verilenPuan >= 4 ? Properties.Resources.dolu : Properties.Resources.bos;
            p3.Image = verilenPuan >= 3 ? Properties.Resources.dolu : Properties.Resources.bos;
            p2.Image = verilenPuan >= 2 ? Properties.Resources.dolu : Properties.Resources.bos;
            p1.Image = verilenPuan >= 1 ? Properties.Resources.dolu : Properties.Resources.bos;
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            if (verilenPuan == 0)
                MessageBox.Show("Lütfen filmi puanlayın.");
            else
            {
                string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=netflix.accdb";
                OleDbConnection baglanti = new OleDbConnection(vtyolu);
                baglanti.Open();
                string kontrol = "SELECT * FROM kullanici WHERE mail = @mail";
                OleDbCommand komut = new OleDbCommand(kontrol, baglanti);
                komut.Parameters.AddWithValue("@mail", mailAdresi);
                OleDbDataReader dr;
                dr = komut.ExecuteReader();
                int durum = dr.Read() ? 1 : 0;

                if (durum==1)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "UPDATE kullaniciProgram SET tarih = '" + DateTime.Today + "' , sure= " + tiktak + ", kalinan = "+ bolum +" , puan = " + verilenPuan + " WHERE k_email = '" + mailAdresi + "' AND p_id = "+ p_id+"";
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string ekle = "insert into kullaniciProgram(k_email,p_id,tarih,sure,kalinan,puan) values (@mail,@id,@tarih,@sure,@kalinan,@puan)";
                    OleDbCommand komut2 = new OleDbCommand(ekle, baglanti);
                    komut2.Parameters.AddWithValue("@mail", mailAdresi);
                    komut2.Parameters.AddWithValue("@id", p_id);
                    komut2.Parameters.AddWithValue("@tarih", DateTime.Today);
                    komut2.Parameters.AddWithValue("@sure", tiktak);
                    komut2.Parameters.AddWithValue("@kalinan", bolum);
                    komut2.Parameters.AddWithValue("@puan", verilenPuan);
                    komut2.ExecuteNonQuery();
                }
                baglanti.Close();
                this.Close();
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiktak++;
            int saat, dakika, saniye;
            saat = tiktak / 3600;
            dakika = tiktak / 60;
            saniye = tiktak % 60;
            string toplamSure = saat.ToString() + " : ";
            if (dakika < 10)
                toplamSure += "0";
            toplamSure += dakika.ToString() + " : ";

            if (saniye < 10)
                toplamSure += "0";
            toplamSure += saniye.ToString();
            label1.Text = toplamSure;

            trackBar1.Value = Convert.ToInt32( tiktak / (sure * 60) * 10000 );
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Stop();
            tiktak = trackBar1.Value * (sure * 60) / 10000;
            timer1.Start();
        }
    }
}
