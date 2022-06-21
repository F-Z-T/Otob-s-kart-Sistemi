
namespace IzmirimKart
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.btnTam = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnOgretmen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKalanBakiye = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(49, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bakiye gir : ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(190, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 35);
            this.textBox1.TabIndex = 1;
            // 
            // btnYukle
            // 
            this.btnYukle.BackColor = System.Drawing.Color.Navy;
            this.btnYukle.ForeColor = System.Drawing.Color.White;
            this.btnYukle.Location = new System.Drawing.Point(457, 60);
            this.btnYukle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(221, 42);
            this.btnYukle.TabIndex = 2;
            this.btnYukle.Text = "Bakiye Yükle";
            this.btnYukle.UseVisualStyleBackColor = false;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // btnTam
            // 
            this.btnTam.BackColor = System.Drawing.Color.Navy;
            this.btnTam.ForeColor = System.Drawing.Color.White;
            this.btnTam.Location = new System.Drawing.Point(34, 158);
            this.btnTam.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnTam.Name = "btnTam";
            this.btnTam.Size = new System.Drawing.Size(198, 79);
            this.btnTam.TabIndex = 3;
            this.btnTam.Text = "TAM";
            this.btnTam.UseVisualStyleBackColor = false;
            this.btnTam.Click += new System.EventHandler(this.btnTam_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.BackColor = System.Drawing.Color.Navy;
            this.btnOgrenci.ForeColor = System.Drawing.Color.White;
            this.btnOgrenci.Location = new System.Drawing.Point(34, 247);
            this.btnOgrenci.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(198, 79);
            this.btnOgrenci.TabIndex = 4;
            this.btnOgrenci.Text = "Ogrenci";
            this.btnOgrenci.UseVisualStyleBackColor = false;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnOgretmen
            // 
            this.btnOgretmen.BackColor = System.Drawing.Color.Navy;
            this.btnOgretmen.ForeColor = System.Drawing.Color.White;
            this.btnOgretmen.Location = new System.Drawing.Point(34, 336);
            this.btnOgretmen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnOgretmen.Name = "btnOgretmen";
            this.btnOgretmen.Size = new System.Drawing.Size(197, 79);
            this.btnOgretmen.TabIndex = 5;
            this.btnOgretmen.Text = "Ogretmen";
            this.btnOgretmen.UseVisualStyleBackColor = false;
            this.btnOgretmen.Click += new System.EventHandler(this.btnOgretmen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(351, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 49);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kalan Bakiye: ";
            // 
            // lblKalanBakiye
            // 
            this.lblKalanBakiye.AutoSize = true;
            this.lblKalanBakiye.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKalanBakiye.ForeColor = System.Drawing.Color.Navy;
            this.lblKalanBakiye.Location = new System.Drawing.Point(515, 232);
            this.lblKalanBakiye.Name = "lblKalanBakiye";
            this.lblKalanBakiye.Size = new System.Drawing.Size(60, 49);
            this.lblKalanBakiye.TabIndex = 7;
            this.lblKalanBakiye.Text = "0.0";
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZaman.ForeColor = System.Drawing.Color.Navy;
            this.lblZaman.Location = new System.Drawing.Point(441, 309);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(70, 33);
            this.lblZaman.TabIndex = 8;
            this.lblZaman.Text = "zaman";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(778, 500);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.lblKalanBakiye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOgretmen);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnTam);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Button btnTam;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnOgretmen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKalanBakiye;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

