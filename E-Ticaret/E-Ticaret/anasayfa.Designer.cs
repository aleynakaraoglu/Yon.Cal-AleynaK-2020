namespace E_Ticaret
{
    partial class anasayfa
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
            this.btnanasayfa = new System.Windows.Forms.Button();
            this.btnkategori = new System.Windows.Forms.Button();
            this.btnmesaj = new System.Windows.Forms.Button();
            this.btnprofil = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnanasayfa
            // 
            this.btnanasayfa.Location = new System.Drawing.Point(245, 371);
            this.btnanasayfa.Name = "btnanasayfa";
            this.btnanasayfa.Size = new System.Drawing.Size(72, 45);
            this.btnanasayfa.TabIndex = 0;
            this.btnanasayfa.Text = "anasyfa";
            this.btnanasayfa.UseVisualStyleBackColor = true;
            // 
            // btnkategori
            // 
            this.btnkategori.Location = new System.Drawing.Point(313, 371);
            this.btnkategori.Name = "btnkategori";
            this.btnkategori.Size = new System.Drawing.Size(72, 45);
            this.btnkategori.TabIndex = 1;
            this.btnkategori.Text = "kategoriler";
            this.btnkategori.UseVisualStyleBackColor = true;
            // 
            // btnmesaj
            // 
            this.btnmesaj.Location = new System.Drawing.Point(381, 371);
            this.btnmesaj.Name = "btnmesaj";
            this.btnmesaj.Size = new System.Drawing.Size(72, 45);
            this.btnmesaj.TabIndex = 2;
            this.btnmesaj.Text = "mesajlar";
            this.btnmesaj.UseVisualStyleBackColor = true;
            // 
            // btnprofil
            // 
            this.btnprofil.Location = new System.Drawing.Point(445, 371);
            this.btnprofil.Name = "btnprofil";
            this.btnprofil.Size = new System.Drawing.Size(72, 45);
            this.btnprofil.TabIndex = 3;
            this.btnprofil.Text = "profil";
            this.btnprofil.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 20);
            this.textBox1.TabIndex = 4;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Location = new System.Drawing.Point(1, 2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(749, 55);
            this.groupBox9.TabIndex = 20;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "groupBox9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(601, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "HOMEMADE.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(57, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 72);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(752, 420);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnprofil);
            this.Controls.Add(this.btnmesaj);
            this.Controls.Add(this.btnkategori);
            this.Controls.Add(this.btnanasayfa);
            this.Name = "anasayfa";
            this.Text = "anasayfa";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnanasayfa;
        private System.Windows.Forms.Button btnkategori;
        private System.Windows.Forms.Button btnmesaj;
        private System.Windows.Forms.Button btnprofil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}