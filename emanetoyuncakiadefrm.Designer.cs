﻿namespace obenimdeoyuncagim
{
    partial class emanetoyuncakiadefrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emanetoyuncakiadefrm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.barkodnoara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(200, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(531, 313);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(491, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Teslim Al";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(655, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "İptal";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cancel.png");
            this.ımageList1.Images.SetKeyName(1, "product-return.png");
            // 
            // barkodnoara
            // 
            this.barkodnoara.Location = new System.Drawing.Point(462, 40);
            this.barkodnoara.Name = "barkodnoara";
            this.barkodnoara.Size = new System.Drawing.Size(161, 22);
            this.barkodnoara.TabIndex = 5;
            this.barkodnoara.TextChanged += new System.EventHandler(this.barkodnoara_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Barkod No\'ya Göre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tc\'ye Göre:";
            // 
            // tcara
            // 
            this.tcara.Location = new System.Drawing.Point(200, 40);
            this.tcara.Name = "tcara";
            this.tcara.Size = new System.Drawing.Size(100, 22);
            this.tcara.TabIndex = 9;
            this.tcara.TextChanged += new System.EventHandler(this.tcara_TextChanged);
            // 
            // emanetoyuncakiadefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(887, 497);
            this.Controls.Add(this.tcara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barkodnoara);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "emanetoyuncakiadefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Oyuncak İade Sayfası";
            this.Load += new System.EventHandler(this.emanetoyuncakiadefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox barkodnoara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tcara;
    }
}