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
    public partial class AnaMenu : Form
    {
        public string mail;
        int sayi;
        public int yeniKayit;
        Color[] renkler = new Color[6];
        DataSet dataSet = new DataSet();
        string isim, ePosta, mSifre, dogum;
        int mainDegeri = 0, aramaDegeri = 0;

        public AnaMenu()
        {
            InitializeComponent();
            renkler[0] = Color.Gainsboro;
            renkler[1] = Color.FromArgb(92, 182, 195);
            renkler[2] = Color.FromArgb(50, 197, 15);
            renkler[3] = Color.FromArgb(234, 0, 127);
            renkler[4] = Color.FromArgb(255, 156, 0);
            renkler[5] = Color.FromArgb(171, 27, 212);
        }

        private void cik_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void Karart()
        {
            panel1.BackColor = renkler[sayi - 1];
            panel3.BackColor = renkler[sayi - 1];
            isimSoyisim.ForeColor = renkler[sayi - 1];

            hakkindaPanel.Visible = false;
            cikisPanel.Visible = false;
            ayarPanel.Visible = false;
            aramaPaneli.Visible = false;
            menuPanel.Visible = false;

            hakkindaPanel.Location = new Point(118, 92);
            cikisPanel.Location = new Point(118, 92);
            ayarPanel.Location = new Point(118, 92);
            aramaPaneli.Location = new Point(118, 92);
            menuPanel.Location = new Point(118, 92);

            menu.Image = Properties.Resources.ev1;
            ara.Image = Properties.Resources.ara1;
            cikis.Image = Properties.Resources.cikis1;
            bilgi.Image = Properties.Resources.hakkinda1;
            ayar.Image = Properties.Resources.ayar1;
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=netflix.accdb";
            OleDbConnection baglanti = new OleDbConnection(vtyolu);
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From program", baglanti);
            adtr.Fill(dataSet, "program");
            dataGridView1.DataSource = dataSet.Tables["program"];
            adtr.Dispose();
            string komutMetni = "SELECT *FROM kullanici WHERE mail = @maili";
            OleDbDataReader okuyucu;
            OleDbCommand komut = new OleDbCommand(komutMetni, baglanti);
            komut.Parameters.AddWithValue("@maili", mail);
            okuyucu = komut.ExecuteReader();
            if (okuyucu.Read())
            {
                isim = okuyucu[0].ToString();
                ePosta = okuyucu[1].ToString();
                mSifre = okuyucu[2].ToString();
                dogum = okuyucu[3].ToString();
            }
            baglanti.Close();

            lbl_isim.Text = isim;
            lbl_mail.Text = ePosta;
            lbl_sifre.Text = mSifre;
            lbl_dt.Text = dogum;

            Random rastgele = new Random();
            sayi = rastgele.Next(2, 7);

            isimSoyisim.Text = "Hoşgeldin " + isim + ",";
            mailAdresi.Text = mail;

            comboBox1.SelectedIndex = 0;

            mainDegeri = 0;
            f1.Image = Image.FromFile(@"poster\" + 1.ToString() + ".jpg");
            i1.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            f2.Image = Image.FromFile(@"poster\" + 2.ToString() + ".jpg");
            i2.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();
            f3.Image = Image.FromFile(@"poster\" + 3.ToString() + ".jpg");
            i3.Text = dataGridView1.Rows[2].Cells[1].Value.ToString();
            f4.Image = Image.FromFile(@"poster\" + 4.ToString() + ".jpg");
            i4.Text = dataGridView1.Rows[3].Cells[1].Value.ToString();
            f5.Image = Image.FromFile(@"poster\" + 5.ToString() + ".jpg");
            i5.Text = dataGridView1.Rows[4].Cells[1].Value.ToString();
            f6.Image = Image.FromFile(@"poster\" + 6.ToString() + ".jpg");
            i6.Text = dataGridView1.Rows[5].Cells[1].Value.ToString();
            f7.Image = Image.FromFile(@"poster\" + 7.ToString() + ".jpg");
            i7.Text = dataGridView1.Rows[6].Cells[1].Value.ToString();
            f8.Image = Image.FromFile(@"poster\" + 8.ToString() + ".jpg");
            i8.Text = dataGridView1.Rows[7].Cells[1].Value.ToString();
            menu_Click(null,null);
        }

        private void kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Karart();
            if (sayi == 2) cikis.Image = Properties.Resources.cikis2;
            else if (sayi == 3) cikis.Image = Properties.Resources.cikis3;
            else if (sayi == 4) cikis.Image = Properties.Resources.cikis4;
            else if (sayi == 5) cikis.Image = Properties.Resources.cikis5;
            else if (sayi == 6) cikis.Image = Properties.Resources.cikis6;

            cikisPanel.Visible = true;
        }

        private void ara_Click(object sender, EventArgs e)
        {
            Karart();
            if (sayi == 2) ara.Image = Properties.Resources.ara2;
            else if (sayi == 3) ara.Image = Properties.Resources.ara3;
            else if (sayi == 4) ara.Image = Properties.Resources.ara4;
            else if (sayi == 5) ara.Image = Properties.Resources.ara5;
            else if (sayi == 6) ara.Image = Properties.Resources.ara6;

            aramaPaneli.Visible = true;
        }

        private void ayar_Click(object sender, EventArgs e)
        {
            Karart();
            if (sayi == 2) ayar.Image = Properties.Resources.ayar2;
            else if (sayi == 3) ayar.Image = Properties.Resources.ayar3;
            else if (sayi == 4) ayar.Image = Properties.Resources.ayar4;
            else if (sayi == 5) ayar.Image = Properties.Resources.ayar5;
            else if (sayi == 6) ayar.Image = Properties.Resources.ayar6;

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

            ayarPanel.Visible = true;
            comboBox1.SelectedIndex = 0;
        }

        private void bilgi_Click(object sender, EventArgs e)
        {
            Karart();
            if (sayi == 2) bilgi.Image = Properties.Resources.hakkinda2;
            else if (sayi == 3) bilgi.Image = Properties.Resources.hakkinda3;
            else if (sayi == 4) bilgi.Image = Properties.Resources.hakkinda4;
            else if (sayi == 5) bilgi.Image = Properties.Resources.hakkinda5;
            else if (sayi == 6) bilgi.Image = Properties.Resources.hakkinda6;

            hakkindaPanel.Visible = true;
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Karart();
            if (sayi == 2) menu.Image = Properties.Resources.ev2;
            else if (sayi == 3) menu.Image = Properties.Resources.ev3;
            else if (sayi == 4) menu.Image = Properties.Resources.ev4;
            else if (sayi == 5) menu.Image = Properties.Resources.ev5;
            else if (sayi == 6) menu.Image = Properties.Resources.ev6;

            menuPanel.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            this.Close();
            girisEkrani.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            menu_Click(null,null);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            sayi = rastgele.Next(2, 7);

            Karart();
            if (sayi == 2) ayar.Image = Properties.Resources.ayar2;
            else if (sayi == 3) ayar.Image = Properties.Resources.ayar3;
            else if (sayi == 4) ayar.Image = Properties.Resources.ayar4;
            else if (sayi == 5) ayar.Image = Properties.Resources.ayar5;
            else if (sayi == 6) ayar.Image = Properties.Resources.ayar6;

            if (sifre.PasswordChar != '•')
            {
                if (sayi == 2) goster.Image = Properties.Resources.info2;
                else if (sayi == 3) goster.Image = Properties.Resources.info3;
                else if (sayi == 4) goster.Image = Properties.Resources.info4;
                else if (sayi == 5) goster.Image = Properties.Resources.info5;
                else if (sayi == 6) goster.Image = Properties.Resources.info6;
            }
            

            ayarPanel.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            sifre.Text = "Yeni Şifre";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=netflix.accdb";
            OleDbConnection baglanti = new OleDbConnection(vtyolu);
            baglanti.Open();
            string sil = "UPDATE kullanici SET sifre = @sifre WHERE mail = @maili";
            OleDbCommand komut = new OleDbCommand(sil, baglanti);
            komut.Parameters.AddWithValue("@maili", ePosta);
            komut.Parameters.AddWithValue("@sifre", sifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            sifre.PasswordChar = '\0';
            mSifre = sifre.Text;
            lbl_sifre.Text = mSifre;
            sifre.Text = "Yeni Şifre";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (mainDegeri < 52)
            {
                mainDegeri += 4;
                f1.Image = f5.Image;
                f2.Image = f6.Image;
                f3.Image = f7.Image;
                f4.Image = f8.Image;
                i1.Text = i5.Text;
                i2.Text = i6.Text;
                i3.Text = i7.Text;
                i4.Text = i8.Text;
                f5.Image = Image.FromFile(@"poster\" + (mainDegeri + 5).ToString() + ".jpg");
                i5.Text = dataGridView1.Rows[mainDegeri + 4].Cells[1].Value.ToString();
                f6.Image = Image.FromFile(@"poster\" + (mainDegeri + 6).ToString() + ".jpg");
                i6.Text = dataGridView1.Rows[mainDegeri + 5].Cells[1].Value.ToString();
                f7.Image = Image.FromFile(@"poster\" + (mainDegeri + 7).ToString() + ".jpg");
                i7.Text = dataGridView1.Rows[mainDegeri + 6].Cells[1].Value.ToString();
                f8.Image = Image.FromFile(@"poster\" + (mainDegeri + 8).ToString() + ".jpg");
                i8.Text = dataGridView1.Rows[mainDegeri + 7].Cells[1].Value.ToString();
            }
            else if (mainDegeri == 52)
            {
                mainDegeri += 4;
                f1.Image = f5.Image;
                f2.Image = f6.Image;
                f3.Image = f7.Image;
                f4.Image = f8.Image;
                i1.Text = i5.Text;
                i2.Text = i6.Text;
                i3.Text = i7.Text;
                i4.Text = i8.Text;
                f5.Image = Image.FromFile(@"poster\" + (mainDegeri + 5).ToString() + ".jpg");
                i5.Text = dataGridView1.Rows[mainDegeri + 4].Cells[1].Value.ToString();
                f6.Visible = false;
                f7.Visible = false;
                f8.Visible = false;
                i6.Visible = false;
                i7.Visible = false;
                i8.Visible = false;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            f6.Visible = true;
            f7.Visible = true;
            f8.Visible = true;
            i6.Visible = true;
            i7.Visible = true;
            i8.Visible = true;

            if (mainDegeri > 0)
            {
                mainDegeri -= 4;
                f5.Image = f1.Image;
                f6.Image = f2.Image;
                f7.Image = f3.Image;
                f8.Image = f4.Image;
                i5.Text = i1.Text;
                i6.Text = i2.Text;
                i7.Text = i3.Text;
                i8.Text = i4.Text;
                f1.Image = Image.FromFile(@"poster\" + (mainDegeri + 1).ToString() + ".jpg");
                i1.Text = dataGridView1.Rows[mainDegeri + 0].Cells[1].Value.ToString();
                f2.Image = Image.FromFile(@"poster\" + (mainDegeri + 2).ToString() + ".jpg");
                i2.Text = dataGridView1.Rows[mainDegeri + 1].Cells[1].Value.ToString();
                f3.Image = Image.FromFile(@"poster\" + (mainDegeri + 3).ToString() + ".jpg");
                i3.Text = dataGridView1.Rows[mainDegeri + 2].Cells[1].Value.ToString();
                f4.Image = Image.FromFile(@"poster\" + (mainDegeri + 4).ToString() + ".jpg");
                i4.Text = dataGridView1.Rows[mainDegeri + 3].Cells[1].Value.ToString();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Film/Dizi Adı")
                textBox1.Text = "";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            aramaDegeri = 0;
            DataSet dataSet2 = new DataSet();
            string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=netflix.accdb";
            OleDbConnection baglanti = new OleDbConnection(vtyolu);
            baglanti.Open();
            OleDbDataAdapter adapter;
            adapter = comboBox1.SelectedIndex == 0
                ? new OleDbDataAdapter("select * From program where p_ad like '%" + textBox1.Text +"%'", baglanti)
                : new OleDbDataAdapter("select * From program,programTur where program.p_id = programtur.p_id AND t_id = " + comboBox1.SelectedIndex.ToString() + " AND program.p_ad like '%" + textBox1.Text + "%'", baglanti);
            adapter.Fill(dataSet2, "program");
            dataGridView2.DataSource = dataSet2.Tables["program"];
            adapter.Dispose();
            baglanti.Close();

            if (dataGridView2.RowCount-1 <= 4)
            {
                pictureBox26.Enabled = false;
                pictureBox27.Enabled = false;
                ai1.Visible = false;
                ai2.Visible = false;
                ai3.Visible = false;
                ai4.Visible = false;
                af1.Visible = false;
                af2.Visible = false;
                af3.Visible = false;
                af4.Visible = false;

                switch (dataGridView2.RowCount-1)
                {
                    case 1:
                        ai1.Visible = true;
                        af1.Visible = true;
                        af1.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[0].Cells[0].Value.ToString() + ".jpg");
                        ai1.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                        break;
                    case 2:
                        ai1.Visible = true;
                        af1.Visible = true;
                        af1.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[0].Cells[0].Value.ToString() + ".jpg");
                        ai1.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                        ai2.Visible = true;
                        af2.Visible = true;
                        af2.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[1].Cells[0].Value.ToString() + ".jpg");
                        ai2.Text = dataGridView2.Rows[1].Cells[1].Value.ToString();
                        break;
                    case 3:
                        ai1.Visible = true;
                        af1.Visible = true;
                        af1.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[0].Cells[0].Value.ToString() + ".jpg");
                        ai1.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                        ai2.Visible = true;
                        af2.Visible = true;
                        af2.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[1].Cells[0].Value.ToString() + ".jpg");
                        ai2.Text = dataGridView2.Rows[1].Cells[1].Value.ToString();
                        ai3.Visible = true;
                        af3.Visible = true;
                        af3.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[2].Cells[0].Value.ToString() + ".jpg");
                        ai3.Text = dataGridView2.Rows[2].Cells[1].Value.ToString();
                        break;
                    case 4:
                        ai1.Visible = true;
                        af1.Visible = true;
                        af1.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[0].Cells[0].Value.ToString() + ".jpg");
                        ai1.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                        ai2.Visible = true;
                        af2.Visible = true;
                        af2.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[1].Cells[0].Value.ToString() + ".jpg");
                        ai2.Text = dataGridView2.Rows[1].Cells[1].Value.ToString();
                        ai3.Visible = true;
                        af3.Visible = true;
                        af3.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[2].Cells[0].Value.ToString() + ".jpg");
                        ai3.Text = dataGridView2.Rows[2].Cells[1].Value.ToString();
                        ai4.Visible = true;
                        af4.Visible = true;
                        af4.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[3].Cells[0].Value.ToString() + ".jpg");
                        ai4.Text = dataGridView2.Rows[3].Cells[1].Value.ToString();
                        break;
                }

            }
            else
            {
                ai1.Visible = true;
                af1.Visible = true;
                af1.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[0].Cells[0].Value.ToString() + ".jpg");
                ai1.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
                ai2.Visible = true;
                af2.Visible = true;
                af2.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[1].Cells[0].Value.ToString() + ".jpg");
                ai2.Text = dataGridView2.Rows[1].Cells[1].Value.ToString();
                ai3.Visible = true;
                af3.Visible = true;
                af3.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[2].Cells[0].Value.ToString() + ".jpg");
                ai3.Text = dataGridView2.Rows[2].Cells[1].Value.ToString();
                ai4.Visible = true;
                af4.Visible = true;
                af4.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[3].Cells[0].Value.ToString() + ".jpg");
                ai4.Text = dataGridView2.Rows[3].Cells[1].Value.ToString();

                pictureBox26.Enabled = true;
                pictureBox27.Enabled = true;
            }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                pictureBox11_Click(null, null);
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(aramaDegeri.ToString() + "\n" + (dataGridView2.RowCount - (dataGridView2.RowCount % 4) - 4).ToString());
            if (aramaDegeri < dataGridView2.RowCount - (dataGridView2.RowCount % 4) - 4)
            {
                aramaDegeri += 4;
                af1.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[aramaDegeri].Cells[0].Value.ToString() + ".jpg");
                ai1.Text = dataGridView2.Rows[aramaDegeri].Cells[1].Value.ToString();
                af2.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[aramaDegeri + 1].Cells[0].Value.ToString() + ".jpg");
                ai2.Text = dataGridView2.Rows[aramaDegeri+1].Cells[1].Value.ToString();
                af3.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[aramaDegeri + 2].Cells[0].Value.ToString() + ".jpg");
                ai3.Text = dataGridView2.Rows[aramaDegeri+2].Cells[1].Value.ToString();
                af4.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[aramaDegeri + 3].Cells[0].Value.ToString() + ".jpg");
                ai4.Text = dataGridView2.Rows[aramaDegeri+3].Cells[1].Value.ToString();
            }
            else if(aramaDegeri == dataGridView2.RowCount - (dataGridView2.RowCount % 4) - 4 && dataGridView2.RowCount - aramaDegeri - 5 > 0)
            {
                    ai1.Visible = false;
                    ai2.Visible = false;
                    ai3.Visible = false;
                    ai4.Visible = false;
                    af1.Visible = false;
                    af2.Visible = false;
                    af3.Visible = false;
                    af4.Visible = false;
                
                switch (dataGridView2.RowCount - aramaDegeri - 5)
                {
                    case 1:
                        ai1.Visible = true;
                        af1.Visible = true;
                        af1.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[aramaDegeri + 4].Cells[0].Value.ToString() + ".jpg");
                        ai1.Text = dataGridView2.Rows[aramaDegeri + 4].Cells[1].Value.ToString();
                        break;
                    case 2:
                        ai1.Visible = true;
                        af1.Visible = true;
                        af1.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[aramaDegeri + 4].Cells[0].Value.ToString() + ".jpg");
                        ai1.Text = dataGridView2.Rows[aramaDegeri + 4].Cells[1].Value.ToString();
                        ai2.Visible = true;
                        af2.Visible = true;
                        af2.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[aramaDegeri + 5].Cells[0].Value.ToString() + ".jpg");
                        ai2.Text = dataGridView2.Rows[aramaDegeri + 5].Cells[1].Value.ToString();
                        break;
                    case 3:
                        ai1.Visible = true;
                        af1.Visible = true;
                        af1.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[aramaDegeri + 4].Cells[0].Value.ToString() + ".jpg");
                        ai1.Text = dataGridView2.Rows[aramaDegeri + 4].Cells[1].Value.ToString();
                        ai2.Visible = true;
                        af2.Visible = true;
                        af2.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[aramaDegeri + 5].Cells[0].Value.ToString() + ".jpg");
                        ai2.Text = dataGridView2.Rows[aramaDegeri + 5].Cells[1].Value.ToString();
                        ai3.Visible = true;
                        af3.Visible = true;
                        af3.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[aramaDegeri + 6].Cells[0].Value.ToString() + ".jpg");
                        ai3.Text = dataGridView2.Rows[aramaDegeri + 6].Cells[1].Value.ToString();
                        break;
                    case 4:
                        ai1.Visible = true;
                        af1.Visible = true;
                        af1.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[aramaDegeri + 4].Cells[0].Value.ToString() + ".jpg");
                        ai1.Text = dataGridView2.Rows[aramaDegeri + 4].Cells[1].Value.ToString();
                        ai2.Visible = true;
                        af2.Visible = true;
                        af2.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[aramaDegeri + 5].Cells[0].Value.ToString() + ".jpg");
                        ai2.Text = dataGridView2.Rows[aramaDegeri + 5].Cells[1].Value.ToString();
                        ai3.Visible = true;
                        af3.Visible = true;
                        af3.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[aramaDegeri + 6].Cells[0].Value.ToString() + ".jpg");
                        ai3.Text = dataGridView2.Rows[aramaDegeri + 6].Cells[1].Value.ToString();
                        ai4.Visible = true;
                        af4.Visible = true;
                        af4.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[aramaDegeri + 7].Cells[0].Value.ToString() + ".jpg");
                        ai4.Text = dataGridView2.Rows[aramaDegeri + 7].Cells[1].Value.ToString();
                        break;
                }
                aramaDegeri += 4;
            }
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            af2.Visible = true;
            af3.Visible = true;
            af4.Visible = true;
            ai2.Visible = true;
            ai3.Visible = true;
            ai4.Visible = true;

            if (aramaDegeri > 0)
            {
                aramaDegeri -= 4;
                af1.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[aramaDegeri].Cells[0].Value.ToString() + ".jpg");
                ai1.Text = dataGridView2.Rows[aramaDegeri + 0].Cells[1].Value.ToString();
                af2.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[aramaDegeri + 1].Cells[0].Value.ToString() + ".jpg");
                ai2.Text = dataGridView2.Rows[aramaDegeri + 1].Cells[1].Value.ToString();
                af3.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[aramaDegeri + 2].Cells[0].Value.ToString() + ".jpg");
                ai3.Text = dataGridView2.Rows[aramaDegeri + 2].Cells[1].Value.ToString();
                af4.Image = Image.FromFile(@"poster\" + dataGridView2.Rows[aramaDegeri + 3].Cells[0].Value.ToString() + ".jpg");
                ai4.Text = dataGridView2.Rows[aramaDegeri + 3].Cells[1].Value.ToString();
            }
        }

        private void aFilmTiklama(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            int degeri = Convert.ToInt32(pictureBox.Name.Substring(2))-1;
            FilmDetay filmDetay = new FilmDetay();
            filmDetay.id = Convert.ToInt32(dataGridView2.Rows[aramaDegeri + degeri].Cells[0].Value);
            filmDetay.mailAdresi = ePosta;
            filmDetay.Show();
        }

        private void filmTiklama(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            int degeri = Convert.ToInt32(pictureBox.Name.Substring(1));
            FilmDetay filmDetay = new FilmDetay();
            filmDetay.id = mainDegeri + degeri;
            filmDetay.mailAdresi = ePosta;
            filmDetay.Show();
        }

        private void sifre_DoubleClick(object sender, EventArgs e)
        {
            sifre.Text = "";
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

        private void sifre_Click(object sender, EventArgs e)
        {
            if (sifre.Text == "Yeni Şifre")
            {
                sifre.Clear();
                sifre.PasswordChar = '•';
                goster.Image = Properties.Resources.info1;
            }

            panel2.BackColor = renkler[sayi - 1];
            sifre.ForeColor = renkler[sayi - 1];
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=netflix.accdb";
            OleDbConnection baglanti = new OleDbConnection(vtyolu);
            baglanti.Open();
            string sil = "DELETE FROM kullanici WHERE mail = @maili";
            OleDbCommand komut = new OleDbCommand(sil, baglanti);
            komut.Parameters.AddWithValue("@maili", ePosta);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kaydınız silinmiştir.");

            GirisEkrani girisEkrani = new GirisEkrani();
            this.Close();
            girisEkrani.Show();
        }
    }
}
