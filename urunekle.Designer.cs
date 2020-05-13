namespace E_Ticaret
{
    partial class urunekle
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
            this.urunadi = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.Label();
            this.detaybilgi = new System.Windows.Forms.Label();
            this.tburunadi = new System.Windows.Forms.TextBox();
            this.tbfiyat = new System.Windows.Forms.TextBox();
            this.tbdetaybilgi = new System.Windows.Forms.TextBox();
            this.btnsprofil = new System.Windows.Forms.Button();
            this.btnsmesaj = new System.Windows.Forms.Button();
            this.btnurunekle = new System.Windows.Forms.Button();
            this.btnsiparis = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.kategoriadi = new System.Windows.Forms.Label();
            this.fotoekle = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoekle)).BeginInit();
            this.SuspendLayout();
            // 
            // urunadi
            // 
            this.urunadi.AutoSize = true;
            this.urunadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunadi.Location = new System.Drawing.Point(49, 188);
            this.urunadi.Name = "urunadi";
            this.urunadi.Size = new System.Drawing.Size(75, 20);
            this.urunadi.TabIndex = 2;
            this.urunadi.Text = "Ürün Adı:";
            // 
            // fiyat
            // 
            this.fiyat.AutoSize = true;
            this.fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyat.Location = new System.Drawing.Point(49, 260);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(47, 20);
            this.fiyat.TabIndex = 4;
            this.fiyat.Text = "Fiyat:";
            // 
            // detaybilgi
            // 
            this.detaybilgi.AutoSize = true;
            this.detaybilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.detaybilgi.Location = new System.Drawing.Point(49, 297);
            this.detaybilgi.Name = "detaybilgi";
            this.detaybilgi.Size = new System.Drawing.Size(94, 20);
            this.detaybilgi.TabIndex = 5;
            this.detaybilgi.Text = "Detaylı Bilgi:";
            // 
            // tburunadi
            // 
            this.tburunadi.Location = new System.Drawing.Point(159, 190);
            this.tburunadi.Name = "tburunadi";
            this.tburunadi.Size = new System.Drawing.Size(263, 20);
            this.tburunadi.TabIndex = 6;
            // 
            // tbfiyat
            // 
            this.tbfiyat.Location = new System.Drawing.Point(159, 262);
            this.tbfiyat.Name = "tbfiyat";
            this.tbfiyat.Size = new System.Drawing.Size(263, 20);
            this.tbfiyat.TabIndex = 8;
            // 
            // tbdetaybilgi
            // 
            this.tbdetaybilgi.Location = new System.Drawing.Point(159, 299);
            this.tbdetaybilgi.Name = "tbdetaybilgi";
            this.tbdetaybilgi.Size = new System.Drawing.Size(263, 20);
            this.tbdetaybilgi.TabIndex = 9;
            // 
            // btnsprofil
            // 
            this.btnsprofil.Location = new System.Drawing.Point(420, 360);
            this.btnsprofil.Name = "btnsprofil";
            this.btnsprofil.Size = new System.Drawing.Size(72, 45);
            this.btnsprofil.TabIndex = 49;
            this.btnsprofil.Text = "profil";
            this.btnsprofil.UseVisualStyleBackColor = true;
            this.btnsprofil.Click += new System.EventHandler(this.btnsprofil_Click);
            // 
            // btnsmesaj
            // 
            this.btnsmesaj.Location = new System.Drawing.Point(356, 360);
            this.btnsmesaj.Name = "btnsmesaj";
            this.btnsmesaj.Size = new System.Drawing.Size(72, 45);
            this.btnsmesaj.TabIndex = 48;
            this.btnsmesaj.Text = "mesajlar";
            this.btnsmesaj.UseVisualStyleBackColor = true;
            this.btnsmesaj.Click += new System.EventHandler(this.btnsmesaj_Click);
            // 
            // btnurunekle
            // 
            this.btnurunekle.Location = new System.Drawing.Point(288, 360);
            this.btnurunekle.Name = "btnurunekle";
            this.btnurunekle.Size = new System.Drawing.Size(72, 45);
            this.btnurunekle.TabIndex = 47;
            this.btnurunekle.Text = "ürün ekle";
            this.btnurunekle.UseVisualStyleBackColor = true;
            // 
            // btnsiparis
            // 
            this.btnsiparis.Location = new System.Drawing.Point(220, 360);
            this.btnsiparis.Name = "btnsiparis";
            this.btnsiparis.Size = new System.Drawing.Size(72, 45);
            this.btnsiparis.TabIndex = 46;
            this.btnsiparis.Text = "siparişlerim";
            this.btnsiparis.UseVisualStyleBackColor = true;
            this.btnsiparis.Click += new System.EventHandler(this.btnsiparis_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(591, 308);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 50;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(604, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "HOMEMADE.";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(2, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(750, 59);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // cbkategori
            // 
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Location = new System.Drawing.Point(159, 226);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(263, 21);
            this.cbkategori.TabIndex = 53;
            // 
            // kategoriadi
            // 
            this.kategoriadi.AutoSize = true;
            this.kategoriadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kategoriadi.Location = new System.Drawing.Point(49, 224);
            this.kategoriadi.Name = "kategoriadi";
            this.kategoriadi.Size = new System.Drawing.Size(72, 20);
            this.kategoriadi.TabIndex = 54;
            this.kategoriadi.Text = "Kategori:";
            // 
            // fotoekle
            // 
            this.fotoekle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fotoekle.Location = new System.Drawing.Point(21, 94);
            this.fotoekle.Name = "fotoekle";
            this.fotoekle.Size = new System.Drawing.Size(122, 80);
            this.fotoekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoekle.TabIndex = 55;
            this.fotoekle.TabStop = false;
            this.fotoekle.Click += new System.EventHandler(this.fotoekle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "fotograf seç...";
            // 
            // urunekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(753, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fotoekle);
            this.Controls.Add(this.kategoriadi);
            this.Controls.Add(this.cbkategori);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnsprofil);
            this.Controls.Add(this.btnsmesaj);
            this.Controls.Add(this.btnurunekle);
            this.Controls.Add(this.btnsiparis);
            this.Controls.Add(this.tbdetaybilgi);
            this.Controls.Add(this.tbfiyat);
            this.Controls.Add(this.tburunadi);
            this.Controls.Add(this.detaybilgi);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.urunadi);
            this.Name = "urunekle";
            this.Text = "urunekle";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoekle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label urunadi;
        private System.Windows.Forms.Label fiyat;
        private System.Windows.Forms.Label detaybilgi;
        private System.Windows.Forms.TextBox tburunadi;
        private System.Windows.Forms.TextBox tbfiyat;
        private System.Windows.Forms.TextBox tbdetaybilgi;
        private System.Windows.Forms.Button btnsprofil;
        private System.Windows.Forms.Button btnsmesaj;
        private System.Windows.Forms.Button btnurunekle;
        private System.Windows.Forms.Button btnsiparis;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbkategori;
        private System.Windows.Forms.Label kategoriadi;
        private System.Windows.Forms.PictureBox fotoekle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}