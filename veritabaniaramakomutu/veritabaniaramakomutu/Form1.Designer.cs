namespace veritabaniaramakomutu
{
    partial class Form1
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
            this.btn_verilerigoster = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_bul = new System.Windows.Forms.Button();
            this.lbl_aranacakkisi = new System.Windows.Forms.Label();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_yas = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_ilce = new System.Windows.Forms.Label();
            this.lbl_meslek = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_yaş = new System.Windows.Forms.TextBox();
            this.txt_ilce = new System.Windows.Forms.TextBox();
            this.txt_meslek = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_verilerigoster
            // 
            this.btn_verilerigoster.Location = new System.Drawing.Point(12, 12);
            this.btn_verilerigoster.Name = "btn_verilerigoster";
            this.btn_verilerigoster.Size = new System.Drawing.Size(112, 32);
            this.btn_verilerigoster.TabIndex = 0;
            this.btn_verilerigoster.Text = "verileri göster";
            this.btn_verilerigoster.UseVisualStyleBackColor = true;
            this.btn_verilerigoster.Click += new System.EventHandler(this.btn_verilerigoster_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Yellow;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 311);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(539, 133);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yaş";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İlçe";
            this.columnHeader4.Width = 123;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Meslek";
            this.columnHeader5.Width = 131;
            // 
            // btn_bul
            // 
            this.btn_bul.Location = new System.Drawing.Point(12, 50);
            this.btn_bul.Name = "btn_bul";
            this.btn_bul.Size = new System.Drawing.Size(112, 32);
            this.btn_bul.TabIndex = 2;
            this.btn_bul.Text = "bul";
            this.btn_bul.UseVisualStyleBackColor = true;
            this.btn_bul.Click += new System.EventHandler(this.btn_bul_Click);
            // 
            // lbl_aranacakkisi
            // 
            this.lbl_aranacakkisi.AutoSize = true;
            this.lbl_aranacakkisi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_aranacakkisi.Location = new System.Drawing.Point(362, 292);
            this.lbl_aranacakkisi.Name = "lbl_aranacakkisi";
            this.lbl_aranacakkisi.Size = new System.Drawing.Size(72, 13);
            this.lbl_aranacakkisi.TabIndex = 3;
            this.lbl_aranacakkisi.Text = "Aranacak Kişi";
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(451, 285);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(100, 20);
            this.txt_ara.TabIndex = 4;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(131, 134);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 5;
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ad.Location = new System.Drawing.Point(38, 137);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(20, 13);
            this.lbl_ad.TabIndex = 6;
            this.lbl_ad.Text = "Ad";
            // 
            // lbl_yas
            // 
            this.lbl_yas.AutoSize = true;
            this.lbl_yas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_yas.Location = new System.Drawing.Point(38, 200);
            this.lbl_yas.Name = "lbl_yas";
            this.lbl_yas.Size = new System.Drawing.Size(25, 13);
            this.lbl_yas.TabIndex = 7;
            this.lbl_yas.Text = "Yaş";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_soyad.Location = new System.Drawing.Point(38, 170);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(37, 13);
            this.lbl_soyad.TabIndex = 8;
            this.lbl_soyad.Text = "Soyad";
            // 
            // lbl_ilce
            // 
            this.lbl_ilce.AutoSize = true;
            this.lbl_ilce.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ilce.Location = new System.Drawing.Point(38, 229);
            this.lbl_ilce.Name = "lbl_ilce";
            this.lbl_ilce.Size = new System.Drawing.Size(24, 13);
            this.lbl_ilce.TabIndex = 9;
            this.lbl_ilce.Text = "İlçe";
            // 
            // lbl_meslek
            // 
            this.lbl_meslek.AutoSize = true;
            this.lbl_meslek.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_meslek.Location = new System.Drawing.Point(38, 258);
            this.lbl_meslek.Name = "lbl_meslek";
            this.lbl_meslek.Size = new System.Drawing.Size(41, 13);
            this.lbl_meslek.TabIndex = 10;
            this.lbl_meslek.Text = "Meslek";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(131, 167);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 11;
            // 
            // txt_yaş
            // 
            this.txt_yaş.Location = new System.Drawing.Point(131, 200);
            this.txt_yaş.Name = "txt_yaş";
            this.txt_yaş.Size = new System.Drawing.Size(100, 20);
            this.txt_yaş.TabIndex = 12;
            // 
            // txt_ilce
            // 
            this.txt_ilce.Location = new System.Drawing.Point(131, 229);
            this.txt_ilce.Name = "txt_ilce";
            this.txt_ilce.Size = new System.Drawing.Size(100, 20);
            this.txt_ilce.TabIndex = 13;
            // 
            // txt_meslek
            // 
            this.txt_meslek.Location = new System.Drawing.Point(131, 258);
            this.txt_meslek.Name = "txt_meslek";
            this.txt_meslek.Size = new System.Drawing.Size(100, 20);
            this.txt_meslek.TabIndex = 14;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(144, 12);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(112, 70);
            this.btn_ekle.TabIndex = 15;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(570, 468);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_meslek);
            this.Controls.Add(this.txt_ilce);
            this.Controls.Add(this.txt_yaş);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.lbl_meslek);
            this.Controls.Add(this.lbl_ilce);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_yas);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.lbl_aranacakkisi);
            this.Controls.Add(this.btn_bul);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_verilerigoster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_verilerigoster;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_bul;
        private System.Windows.Forms.Label lbl_aranacakkisi;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_yas;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_ilce;
        private System.Windows.Forms.Label lbl_meslek;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_yaş;
        private System.Windows.Forms.TextBox txt_ilce;
        private System.Windows.Forms.TextBox txt_meslek;
        private System.Windows.Forms.Button btn_ekle;
    }
}

