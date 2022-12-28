namespace obenimdeoyuncagim
{
    partial class AnaSayfafrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfafrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOyuncakListele = new System.Windows.Forms.Button();
            this.btnOyuncakEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEmanetİade = new System.Windows.Forms.Button();
            this.OyuncakListele = new System.Windows.Forms.Button();
            this.btnEmanetVer = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnTrafik = new System.Windows.Forms.Button();
            this.btnSiralama = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(36, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye işlemleri";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.ImageIndex = 4;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(6, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Üye Ekleme İşlemleri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "growth.png");
            this.ımageList1.Images.SetKeyName(1, "to-do-list.png");
            this.ımageList1.Images.SetKeyName(2, "toys (1).png");
            this.ımageList1.Images.SetKeyName(3, "customer.png");
            this.ımageList1.Images.SetKeyName(4, "add-friend.png");
            this.ımageList1.Images.SetKeyName(5, "children.png");
            this.ımageList1.Images.SetKeyName(6, "baby-boy.png");
            this.ımageList1.Images.SetKeyName(7, "baby-girl.png");
            this.ımageList1.Images.SetKeyName(8, "toys.png");
            this.ımageList1.Images.SetKeyName(9, "teddy-bear.png");
            this.ımageList1.Images.SetKeyName(10, "donation (1).png");
            this.ımageList1.Images.SetKeyName(11, "donation.png");
            this.ımageList1.Images.SetKeyName(12, "toy-shop.png");
            this.ımageList1.Images.SetKeyName(13, "storage-box (1).png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 3;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(6, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(322, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Üye Listeleme işlemleri";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnOyuncakListele);
            this.groupBox2.Controls.Add(this.btnOyuncakEkle);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(420, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 142);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oyuncak İşlemleri";
            // 
            // btnOyuncakListele
            // 
            this.btnOyuncakListele.BackColor = System.Drawing.Color.White;
            this.btnOyuncakListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOyuncakListele.ImageIndex = 2;
            this.btnOyuncakListele.ImageList = this.ımageList1;
            this.btnOyuncakListele.Location = new System.Drawing.Point(33, 74);
            this.btnOyuncakListele.Name = "btnOyuncakListele";
            this.btnOyuncakListele.Size = new System.Drawing.Size(314, 39);
            this.btnOyuncakListele.TabIndex = 3;
            this.btnOyuncakListele.Text = "Oyuncak Listeleme İşlemleri";
            this.btnOyuncakListele.UseVisualStyleBackColor = false;
            this.btnOyuncakListele.Click += new System.EventHandler(this.btnOyuncakListele_Click);
            // 
            // btnOyuncakEkle
            // 
            this.btnOyuncakEkle.BackColor = System.Drawing.Color.White;
            this.btnOyuncakEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOyuncakEkle.ImageIndex = 8;
            this.btnOyuncakEkle.ImageList = this.ımageList1;
            this.btnOyuncakEkle.Location = new System.Drawing.Point(33, 31);
            this.btnOyuncakEkle.Name = "btnOyuncakEkle";
            this.btnOyuncakEkle.Size = new System.Drawing.Size(314, 37);
            this.btnOyuncakEkle.TabIndex = 2;
            this.btnOyuncakEkle.Text = "Oyuncak Ekleme İşlemleri";
            this.btnOyuncakEkle.UseVisualStyleBackColor = false;
            this.btnOyuncakEkle.Click += new System.EventHandler(this.btnOyuncakEkle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.btnEmanetİade);
            this.groupBox3.Controls.Add(this.OyuncakListele);
            this.groupBox3.Controls.Add(this.btnEmanetVer);
            this.groupBox3.Location = new System.Drawing.Point(36, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 200);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet Oyuncak İşlemleri";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(298, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "Mail Gönderme İşlemleri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEmanetİade
            // 
            this.btnEmanetİade.BackColor = System.Drawing.Color.White;
            this.btnEmanetİade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetİade.ImageIndex = 12;
            this.btnEmanetİade.ImageList = this.ımageList1;
            this.btnEmanetİade.Location = new System.Drawing.Point(17, 92);
            this.btnEmanetİade.Name = "btnEmanetİade";
            this.btnEmanetİade.Size = new System.Drawing.Size(311, 35);
            this.btnEmanetİade.TabIndex = 6;
            this.btnEmanetİade.Text = "Oyuncak Emanet İade İşlemleri";
            this.btnEmanetİade.UseVisualStyleBackColor = false;
            this.btnEmanetİade.Click += new System.EventHandler(this.btnEmanetİade_Click);
            // 
            // OyuncakListele
            // 
            this.OyuncakListele.BackColor = System.Drawing.Color.White;
            this.OyuncakListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OyuncakListele.ImageIndex = 13;
            this.OyuncakListele.ImageList = this.ımageList1;
            this.OyuncakListele.Location = new System.Drawing.Point(17, 55);
            this.OyuncakListele.Name = "OyuncakListele";
            this.OyuncakListele.Size = new System.Drawing.Size(311, 31);
            this.OyuncakListele.TabIndex = 5;
            this.OyuncakListele.Text = "Oyuncak Listeleme İşlemleri";
            this.OyuncakListele.UseVisualStyleBackColor = false;
            this.OyuncakListele.Click += new System.EventHandler(this.OyuncakListele_Click);
            // 
            // btnEmanetVer
            // 
            this.btnEmanetVer.BackColor = System.Drawing.Color.White;
            this.btnEmanetVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetVer.ImageIndex = 9;
            this.btnEmanetVer.ImageList = this.ımageList1;
            this.btnEmanetVer.Location = new System.Drawing.Point(17, 14);
            this.btnEmanetVer.Name = "btnEmanetVer";
            this.btnEmanetVer.Size = new System.Drawing.Size(311, 35);
            this.btnEmanetVer.TabIndex = 4;
            this.btnEmanetVer.Text = "Emanet Oyuncak Verme İşlemleri";
            this.btnEmanetVer.UseVisualStyleBackColor = false;
            this.btnEmanetVer.Click += new System.EventHandler(this.btnEmanetVer_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.BtnTrafik);
            this.groupBox4.Controls.Add(this.btnSiralama);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(420, 227);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 144);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sıralama ve Grafikler";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // BtnTrafik
            // 
            this.BtnTrafik.BackColor = System.Drawing.Color.White;
            this.BtnTrafik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTrafik.ImageIndex = 0;
            this.BtnTrafik.ImageList = this.ımageList1;
            this.BtnTrafik.Location = new System.Drawing.Point(33, 81);
            this.BtnTrafik.Name = "BtnTrafik";
            this.BtnTrafik.Size = new System.Drawing.Size(314, 36);
            this.BtnTrafik.TabIndex = 10;
            this.BtnTrafik.Text = "Grafikler";
            this.BtnTrafik.UseVisualStyleBackColor = false;
            this.BtnTrafik.Click += new System.EventHandler(this.BtnTrafik_Click);
            // 
            // btnSiralama
            // 
            this.btnSiralama.BackColor = System.Drawing.Color.White;
            this.btnSiralama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiralama.ImageIndex = 1;
            this.btnSiralama.ImageList = this.ımageList1;
            this.btnSiralama.Location = new System.Drawing.Point(33, 21);
            this.btnSiralama.Name = "btnSiralama";
            this.btnSiralama.Size = new System.Drawing.Size(314, 39);
            this.btnSiralama.TabIndex = 7;
            this.btnSiralama.Text = "Sıralama";
            this.btnSiralama.UseVisualStyleBackColor = false;
            this.btnSiralama.Click += new System.EventHandler(this.btnSiralama_Click);
            // 
            // AnaSayfafrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "AnaSayfafrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaSayfafrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnTrafik;
        private System.Windows.Forms.Button btnSiralama;
        private System.Windows.Forms.Button btnEmanetİade;
        private System.Windows.Forms.Button OyuncakListele;
        private System.Windows.Forms.Button btnEmanetVer;
        private System.Windows.Forms.Button btnOyuncakListele;
        private System.Windows.Forms.Button btnOyuncakEkle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button3;
    }
}

