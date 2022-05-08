
namespace UIMenu
{
    partial class KrediKartiTanimla
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
            this.numBakiye = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKrediKartiTanimAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.dateTimeSonKullanma = new System.Windows.Forms.DateTimePicker();
            this.txtKrediKartNumara = new System.Windows.Forms.TextBox();
            this.btnTanimla = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBakiye)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numBakiye);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKrediKartiTanimAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCVC);
            this.groupBox1.Controls.Add(this.dateTimeSonKullanma);
            this.groupBox1.Controls.Add(this.txtKrediKartNumara);
            this.groupBox1.Controls.Add(this.btnTanimla);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 389);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kredi Kartı Bilgileri";
            // 
            // numBakiye
            // 
            this.numBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numBakiye.Location = new System.Drawing.Point(33, 296);
            this.numBakiye.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numBakiye.Name = "numBakiye";
            this.numBakiye.Size = new System.Drawing.Size(120, 26);
            this.numBakiye.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(29, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bakiye";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kredi Kartı Tanım Adı";
            // 
            // txtKrediKartiTanimAdi
            // 
            this.txtKrediKartiTanimAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKrediKartiTanimAdi.Location = new System.Drawing.Point(33, 55);
            this.txtKrediKartiTanimAdi.Name = "txtKrediKartiTanimAdi";
            this.txtKrediKartiTanimAdi.Size = new System.Drawing.Size(274, 29);
            this.txtKrediKartiTanimAdi.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(265, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "CVC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Son Kullanma Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kredi Kartı Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "İsim Soyisim";
            // 
            // txtCVC
            // 
            this.txtCVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCVC.Location = new System.Drawing.Point(269, 241);
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(120, 29);
            this.txtCVC.TabIndex = 4;
            // 
            // dateTimeSonKullanma
            // 
            this.dateTimeSonKullanma.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeSonKullanma.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeSonKullanma.Location = new System.Drawing.Point(33, 240);
            this.dateTimeSonKullanma.MinimumSize = new System.Drawing.Size(4, 30);
            this.dateTimeSonKullanma.Name = "dateTimeSonKullanma";
            this.dateTimeSonKullanma.Size = new System.Drawing.Size(200, 30);
            this.dateTimeSonKullanma.TabIndex = 3;
            // 
            // txtKrediKartNumara
            // 
            this.txtKrediKartNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKrediKartNumara.Location = new System.Drawing.Point(33, 175);
            this.txtKrediKartNumara.Name = "txtKrediKartNumara";
            this.txtKrediKartNumara.Size = new System.Drawing.Size(356, 29);
            this.txtKrediKartNumara.TabIndex = 2;
            // 
            // btnTanimla
            // 
            this.btnTanimla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTanimla.Location = new System.Drawing.Point(18, 335);
            this.btnTanimla.Name = "btnTanimla";
            this.btnTanimla.Size = new System.Drawing.Size(224, 37);
            this.btnTanimla.TabIndex = 1;
            this.btnTanimla.Text = "Kredi Kartı Tanımla";
            this.btnTanimla.UseVisualStyleBackColor = true;
            this.btnTanimla.Click += new System.EventHandler(this.btnTanimla_Click);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(33, 113);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(274, 29);
            this.txtAd.TabIndex = 0;
            // 
            // KrediKartiTanimla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 522);
            this.Controls.Add(this.groupBox1);
            this.Name = "KrediKartiTanimla";
            this.Text = "Kredi Kartı Tanımla";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBakiye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTanimla;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.DateTimePicker dateTimeSonKullanma;
        private System.Windows.Forms.TextBox txtKrediKartNumara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKrediKartiTanimAdi;
        private System.Windows.Forms.NumericUpDown numBakiye;
        private System.Windows.Forms.Label label6;
    }
}