
namespace UIHastane
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.randevuOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bransEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorgularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuOlusturToolStripMenuItem,
            this.doktorEkleToolStripMenuItem,
            this.sorgularToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // randevuOlusturToolStripMenuItem
            // 
            this.randevuOlusturToolStripMenuItem.Name = "randevuOlusturToolStripMenuItem";
            this.randevuOlusturToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.randevuOlusturToolStripMenuItem.Text = "Randevu Olustur";
            this.randevuOlusturToolStripMenuItem.Click += new System.EventHandler(this.randevuOlusturToolStripMenuItem_Click);
            // 
            // doktorEkleToolStripMenuItem
            // 
            this.doktorEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bransEkleToolStripMenuItem,
            this.doktorEkleToolStripMenuItem1,
            this.hastaEkleToolStripMenuItem});
            this.doktorEkleToolStripMenuItem.Name = "doktorEkleToolStripMenuItem";
            this.doktorEkleToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.doktorEkleToolStripMenuItem.Text = "Yönetim Paneli";
            this.doktorEkleToolStripMenuItem.Click += new System.EventHandler(this.doktorEkleToolStripMenuItem_Click);
            // 
            // bransEkleToolStripMenuItem
            // 
            this.bransEkleToolStripMenuItem.Name = "bransEkleToolStripMenuItem";
            this.bransEkleToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.bransEkleToolStripMenuItem.Text = "Brans Ekle";
            this.bransEkleToolStripMenuItem.Click += new System.EventHandler(this.bransEkleToolStripMenuItem_Click);
            // 
            // doktorEkleToolStripMenuItem1
            // 
            this.doktorEkleToolStripMenuItem1.Name = "doktorEkleToolStripMenuItem1";
            this.doktorEkleToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.doktorEkleToolStripMenuItem1.Text = "Doktor Ekle";
            this.doktorEkleToolStripMenuItem1.Click += new System.EventHandler(this.doktorEkleToolStripMenuItem1_Click);
            // 
            // hastaEkleToolStripMenuItem
            // 
            this.hastaEkleToolStripMenuItem.Name = "hastaEkleToolStripMenuItem";
            this.hastaEkleToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.hastaEkleToolStripMenuItem.Text = "Hasta Ekle";
            this.hastaEkleToolStripMenuItem.Click += new System.EventHandler(this.hastaEkleToolStripMenuItem_Click);
            // 
            // sorgularToolStripMenuItem
            // 
            this.sorgularToolStripMenuItem.Name = "sorgularToolStripMenuItem";
            this.sorgularToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.sorgularToolStripMenuItem.Text = "Sorgular";
            this.sorgularToolStripMenuItem.Click += new System.EventHandler(this.sorgularToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 502);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem doktorEkleToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem randevuOlusturToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem bransEkleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem doktorEkleToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem hastaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorgularToolStripMenuItem;
    }
}

