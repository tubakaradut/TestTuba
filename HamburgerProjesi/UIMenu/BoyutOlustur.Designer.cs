
namespace UIMenu
{
    partial class BoyutOlustur
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
            this.nudBoyutFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnBoyutEkle = new System.Windows.Forms.Button();
            this.txtBoyut = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoyutFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudBoyutFiyat);
            this.groupBox1.Controls.Add(this.btnBoyutEkle);
            this.groupBox1.Controls.Add(this.txtBoyut);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boyut Bilgiler";
            // 
            // nudBoyutFiyat
            // 
            this.nudBoyutFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudBoyutFiyat.Location = new System.Drawing.Point(17, 69);
            this.nudBoyutFiyat.Name = "nudBoyutFiyat";
            this.nudBoyutFiyat.Size = new System.Drawing.Size(224, 29);
            this.nudBoyutFiyat.TabIndex = 2;
            // 
            // btnBoyutEkle
            // 
            this.btnBoyutEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBoyutEkle.Location = new System.Drawing.Point(17, 104);
            this.btnBoyutEkle.Name = "btnBoyutEkle";
            this.btnBoyutEkle.Size = new System.Drawing.Size(224, 37);
            this.btnBoyutEkle.TabIndex = 1;
            this.btnBoyutEkle.Text = "Ekle";
            this.btnBoyutEkle.UseVisualStyleBackColor = true;
            this.btnBoyutEkle.Click += new System.EventHandler(this.btnBoyutEkle_Click);
            // 
            // txtBoyut
            // 
            this.txtBoyut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoyut.Location = new System.Drawing.Point(17, 34);
            this.txtBoyut.Name = "txtBoyut";
            this.txtBoyut.Size = new System.Drawing.Size(224, 29);
            this.txtBoyut.TabIndex = 0;
            // 
            // BoyutOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 264);
            this.Controls.Add(this.groupBox1);
            this.Name = "BoyutOlustur";
            this.Text = "Boyut";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoyutFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudBoyutFiyat;
        private System.Windows.Forms.Button btnBoyutEkle;
        private System.Windows.Forms.TextBox txtBoyut;
    }
}