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
    public partial class FilmDetay : Form
    {
        public int id,sayi;
        public string mailAdresi;
        Color[] renkler = new Color[6];
        int bolumSayisi = 1;
        int uzunluk = 0;
        public FilmDetay()
        {
            InitializeComponent();
            renkler[0] = Color.Gainsboro;
            renkler[1] = Color.FromArgb(92, 182, 195);
            renkler[2] = Color.FromArgb(50, 197, 15);
            renkler[3] = Color.FromArgb(234, 0, 127);
            renkler[4] = Color.FromArgb(255, 156, 0);
            renkler[5] = Color.FromArgb(171, 27, 212);
        }

        private void FilmDetay_Load(object sender, EventArgs e)
        {
            double puanOrt = -1;
            string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=netflix.accdb";
            OleDbConnection baglanti = new OleDbConnection(vtyolu);
            baglanti.Open();
            string komutMetni = "SELECT *FROM program WHERE p_id = @gelen_id";
            OleDbDataReader okuyucu;
            OleDbCommand komut = new OleDbCommand(komutMetni, baglanti);
            komut.Parameters.AddWithValue("@gelen_id", id);
            okuyucu = komut.ExecuteReader();
            if (okuyucu.Read())
            {
                filmPoster.Image = Image.FromFile(@"poster\" + (id).ToString() + ".jpg");
                filmAdi.Text = okuyucu[1].ToString();
                bolumSayisi = Convert.ToInt32(okuyucu[3]);
                uzunluk = Convert.ToInt32(okuyucu[4]);
                filmUzunlugu.Text = okuyucu[4].ToString() + " dk";
            }
            komutMetni = "SELECT AVG(puan) FROM kullaniciProgram WHERE p_id = @gelen_id GROUP BY p_id";
            komut = new OleDbCommand(komutMetni, baglanti);
            komut.Parameters.AddWithValue("@gelen_id", id);
            okuyucu = komut.ExecuteReader();
            if (okuyucu.Read())
                 puanOrt = Convert.ToDouble(okuyucu[0].ToString());
            baglanti.Close();

            if (puanOrt == -1)
                ort.Text = "Henüz puanlanmamış";
            else
                ort.Text = puanOrt.ToString();

            if (bolumSayisi == 1)
                comboBox1.Visible = false;
            else
            {
                for (int i = 1; i <= bolumSayisi; i++)
                    comboBox1.Items.Add(i + ". Bölüm");
            }

            Random rastgele = new Random();
            sayi = rastgele.Next(2, 7);

            lbl1.ForeColor = renkler[sayi - 1];
            lbl2.ForeColor = renkler[sayi - 1];
            lbl3.ForeColor = renkler[sayi - 1];
            cik.ForeColor = renkler[sayi - 1];
            izle.BackColor = renkler[sayi - 1];
        }

        private void cik_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void izle_Click(object sender, EventArgs e)
        {
            izlemeEkrani izle = new izlemeEkrani();
            izle.filmAdi.Text = filmAdi.Text;
            izle.mailAdresi = mailAdresi;
            if (bolumSayisi == 1)
                izle.bolum = 1;
            else
                izle.bolum = comboBox1.SelectedIndex + 1;
            izle.sure = uzunluk;
            izle.p_id = id;
            izle.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
