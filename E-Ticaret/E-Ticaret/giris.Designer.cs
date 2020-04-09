namespace E_Ticaret
{
    partial class giris
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sifreunuttum = new System.Windows.Forms.Label();
            this.benihatirla = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kayıtol = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbsifre = new System.Windows.Forms.TextBox();
            this.tbkadi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.Label();
            this.kadi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbgiris = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.sifreunuttum);
            this.groupBox1.Controls.Add(this.benihatirla);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.kayıtol);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(204, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 335);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // sifreunuttum
            // 
            this.sifreunuttum.AutoSize = true;
            this.sifreunuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sifreunuttum.Location = new System.Drawing.Point(43, 264);
            this.sifreunuttum.Name = "sifreunuttum";
            this.sifreunuttum.Size = new System.Drawing.Size(108, 17);
            this.sifreunuttum.TabIndex = 13;
            this.sifreunuttum.Text = "Şifremi Unuttum";
            // 
            // benihatirla
            // 
            this.benihatirla.AutoSize = true;
            this.benihatirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.benihatirla.Location = new System.Drawing.Point(43, 240);
            this.benihatirla.Name = "benihatirla";
            this.benihatirla.Size = new System.Drawing.Size(100, 21);
            this.benihatirla.TabIndex = 12;
            this.benihatirla.Text = "Beni Hatırla";
            this.benihatirla.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // kayıtol
            // 
            this.kayıtol.Location = new System.Drawing.Point(83, 31);
            this.kayıtol.Name = "kayıtol";
            this.kayıtol.Size = new System.Drawing.Size(86, 23);
            this.kayıtol.TabIndex = 10;
            this.kayıtol.Text = "Kayıt Ol";
            this.kayıtol.UseVisualStyleBackColor = true;
            this.kayıtol.Click += new System.EventHandler(this.kayıtol_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.tbgiris);
            this.groupBox2.Controls.Add(this.tbsifre);
            this.groupBox2.Controls.Add(this.tbkadi);
            this.groupBox2.Controls.Add(this.sifre);
            this.groupBox2.Controls.Add(this.kadi);
            this.groupBox2.Location = new System.Drawing.Point(35, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 177);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tbsifre
            // 
            this.tbsifre.Location = new System.Drawing.Point(124, 94);
            this.tbsifre.Name = "tbsifre";
            this.tbsifre.Size = new System.Drawing.Size(100, 20);
            this.tbsifre.TabIndex = 9;
            // 
            // tbkadi
            // 
            this.tbkadi.Location = new System.Drawing.Point(124, 58);
            this.tbkadi.Name = "tbkadi";
            this.tbkadi.Size = new System.Drawing.Size(100, 20);
            this.tbkadi.TabIndex = 8;
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sifre.Location = new System.Drawing.Point(20, 94);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(41, 17);
            this.sifre.TabIndex = 3;
            this.sifre.Text = "Şifre:";
            // 
            // kadi
            // 
            this.kadi.AutoSize = true;
            this.kadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kadi.Location = new System.Drawing.Point(20, 58);
            this.kadi.Name = "kadi";
            this.kadi.Size = new System.Drawing.Size(88, 17);
            this.kadi.TabIndex = 2;
            this.kadi.Text = "Kullanıcı Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(583, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "HOMEMADE.";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(724, 59);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // tbgiris
            // 
            this.tbgiris.Location = new System.Drawing.Point(170, 148);
            this.tbgiris.Name = "tbgiris";
            this.tbgiris.Size = new System.Drawing.Size(75, 23);
            this.tbgiris.TabIndex = 10;
            this.tbgiris.Text = "Giriş";
            this.tbgiris.UseVisualStyleBackColor = true;
            this.tbgiris.Click += new System.EventHandler(this.tbgiris_Click);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "giris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.giris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbsifre;
        private System.Windows.Forms.TextBox tbkadi;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.Label kadi;
        private System.Windows.Forms.Label sifreunuttum;
        private System.Windows.Forms.CheckBox benihatirla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button kayıtol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button tbgiris;
    }
}