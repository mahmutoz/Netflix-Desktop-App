namespace ProLab2_3
{
    partial class GirisEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.cik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.goster = new System.Windows.Forms.PictureBox();
            this.kayit = new System.Windows.Forms.Button();
            this.giris = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sifre = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kAdi = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cik
            // 
            this.cik.AutoSize = true;
            this.cik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cik.ForeColor = System.Drawing.Color.Gainsboro;
            this.cik.Location = new System.Drawing.Point(331, 8);
            this.cik.Name = "cik";
            this.cik.Size = new System.Drawing.Size(27, 25);
            this.cik.TabIndex = 1;
            this.cik.Text = "X";
            this.cik.Click += new System.EventHandler(this.cik_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProLab2_3.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(92, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(31, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 24;
            // 
            // goster
            // 
            this.goster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goster.Image = global::ProLab2_3.Properties.Resources.info1;
            this.goster.Location = new System.Drawing.Point(287, 294);
            this.goster.Name = "goster";
            this.goster.Size = new System.Drawing.Size(24, 24);
            this.goster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goster.TabIndex = 23;
            this.goster.TabStop = false;
            this.goster.Click += new System.EventHandler(this.goster_Click);
            // 
            // kayit
            // 
            this.kayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayit.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayit.ForeColor = System.Drawing.Color.Gainsboro;
            this.kayit.Location = new System.Drawing.Point(45, 399);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(266, 43);
            this.kayit.TabIndex = 5;
            this.kayit.Text = "Kayıt Ol";
            this.kayit.UseVisualStyleBackColor = false;
            this.kayit.Click += new System.EventHandler(this.kayit_Click);
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giris.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.giris.Location = new System.Drawing.Point(45, 346);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(266, 43);
            this.giris.TabIndex = 4;
            this.giris.Text = "Giriş Yap";
            this.giris.UseVisualStyleBackColor = false;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(45, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 1);
            this.panel2.TabIndex = 20;
            // 
            // sifre
            // 
            this.sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.sifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sifre.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.ForeColor = System.Drawing.Color.Gainsboro;
            this.sifre.Location = new System.Drawing.Point(86, 299);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(222, 29);
            this.sifre.TabIndex = 3;
            this.sifre.Text = "Şifre";
            this.sifre.Click += new System.EventHandler(this.sifre_Click);
            this.sifre.DoubleClick += new System.EventHandler(this.Temizleme);
            this.sifre.Enter += new System.EventHandler(this.sifre_Click);
            this.sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kAdi_KeyPress);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::ProLab2_3.Properties.Resources.pass1;
            this.pictureBox3.Location = new System.Drawing.Point(45, 290);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(45, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 1);
            this.panel1.TabIndex = 17;
            // 
            // kAdi
            // 
            this.kAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.kAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kAdi.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kAdi.ForeColor = System.Drawing.Color.Gainsboro;
            this.kAdi.Location = new System.Drawing.Point(86, 249);
            this.kAdi.Name = "kAdi";
            this.kAdi.Size = new System.Drawing.Size(222, 29);
            this.kAdi.TabIndex = 2;
            this.kAdi.Text = "e-Posta";
            this.kAdi.Click += new System.EventHandler(this.kAdi_Click);
            this.kAdi.DoubleClick += new System.EventHandler(this.Temizleme);
            this.kAdi.Enter += new System.EventHandler(this.kAdi_Click);
            this.kAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kAdi_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::ProLab2_3.Properties.Resources.user1;
            this.pictureBox2.Location = new System.Drawing.Point(45, 240);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // timer4
            // 
            this.timer4.Interval = 10;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(390, 450);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 29);
            this.textBox1.TabIndex = 1;
            // 
            // GirisEkrani
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(360, 480);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goster);
            this.Controls.Add(this.kayit);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kAdi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cik);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cik;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox goster;
        private System.Windows.Forms.Button kayit;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox kAdi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}