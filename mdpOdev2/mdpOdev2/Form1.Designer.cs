namespace mdpOdev2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çarpışmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noktaDörtgenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noktaÇemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikdörtgenDikdörtgenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikdörtgenÇemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çemberÇemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noktaKüreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noktaDikdörtgenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noktaSilindirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silindirSilindirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.küreKüreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.küreSilindirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yüzeyKüreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yüzeyDikdörtgenPrizmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yüzeySilindirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikdörtgenPrizmaDikdörtgenPrizmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çarpışmalarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çarpışmalarToolStripMenuItem
            // 
            this.çarpışmalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noktaDörtgenToolStripMenuItem,
            this.noktaÇemberToolStripMenuItem,
            this.dikdörtgenDikdörtgenToolStripMenuItem,
            this.dikdörtgenÇemberToolStripMenuItem,
            this.çemberÇemberToolStripMenuItem,
            this.noktaKüreToolStripMenuItem,
            this.noktaDikdörtgenToolStripMenuItem,
            this.noktaSilindirToolStripMenuItem,
            this.silindirSilindirToolStripMenuItem,
            this.küreKüreToolStripMenuItem,
            this.küreSilindirToolStripMenuItem,
            this.yüzeyKüreToolStripMenuItem,
            this.yüzeyDikdörtgenPrizmaToolStripMenuItem,
            this.yüzeySilindirToolStripMenuItem,
            this.dikdörtgenPrizmaDikdörtgenPrizmaToolStripMenuItem});
            this.çarpışmalarToolStripMenuItem.Name = "çarpışmalarToolStripMenuItem";
            this.çarpışmalarToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.çarpışmalarToolStripMenuItem.Text = "Çarpışmalar";
            // 
            // noktaDörtgenToolStripMenuItem
            // 
            this.noktaDörtgenToolStripMenuItem.Name = "noktaDörtgenToolStripMenuItem";
            this.noktaDörtgenToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.noktaDörtgenToolStripMenuItem.Text = "Nokta-Dörtgen";
            this.noktaDörtgenToolStripMenuItem.Click += new System.EventHandler(this.noktaDörtgenToolStripMenuItem_Click);
            // 
            // noktaÇemberToolStripMenuItem
            // 
            this.noktaÇemberToolStripMenuItem.Name = "noktaÇemberToolStripMenuItem";
            this.noktaÇemberToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.noktaÇemberToolStripMenuItem.Text = "Nokta-Çember";
            this.noktaÇemberToolStripMenuItem.Click += new System.EventHandler(this.noktaÇemberToolStripMenuItem_Click);
            // 
            // dikdörtgenDikdörtgenToolStripMenuItem
            // 
            this.dikdörtgenDikdörtgenToolStripMenuItem.Name = "dikdörtgenDikdörtgenToolStripMenuItem";
            this.dikdörtgenDikdörtgenToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.dikdörtgenDikdörtgenToolStripMenuItem.Text = "Dikdörtgen-Dikdörtgen";
            this.dikdörtgenDikdörtgenToolStripMenuItem.Click += new System.EventHandler(this.dikdörtgenDikdörtgenToolStripMenuItem_Click);
            // 
            // dikdörtgenÇemberToolStripMenuItem
            // 
            this.dikdörtgenÇemberToolStripMenuItem.Name = "dikdörtgenÇemberToolStripMenuItem";
            this.dikdörtgenÇemberToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.dikdörtgenÇemberToolStripMenuItem.Text = "Dikdörtgen-Çember";
            this.dikdörtgenÇemberToolStripMenuItem.Click += new System.EventHandler(this.dikdörtgenÇemberToolStripMenuItem_Click);
            // 
            // çemberÇemberToolStripMenuItem
            // 
            this.çemberÇemberToolStripMenuItem.Name = "çemberÇemberToolStripMenuItem";
            this.çemberÇemberToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.çemberÇemberToolStripMenuItem.Text = "Çember-Çember";
            this.çemberÇemberToolStripMenuItem.Click += new System.EventHandler(this.çemberÇemberToolStripMenuItem_Click);
            // 
            // noktaKüreToolStripMenuItem
            // 
            this.noktaKüreToolStripMenuItem.Name = "noktaKüreToolStripMenuItem";
            this.noktaKüreToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.noktaKüreToolStripMenuItem.Text = "Nokta-Küre";
            this.noktaKüreToolStripMenuItem.Click += new System.EventHandler(this.noktaKüreToolStripMenuItem_Click);
            // 
            // noktaDikdörtgenToolStripMenuItem
            // 
            this.noktaDikdörtgenToolStripMenuItem.Name = "noktaDikdörtgenToolStripMenuItem";
            this.noktaDikdörtgenToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.noktaDikdörtgenToolStripMenuItem.Text = "Nokta-Dikdörtgen";
            this.noktaDikdörtgenToolStripMenuItem.Click += new System.EventHandler(this.noktaDikdörtgenToolStripMenuItem_Click);
            // 
            // noktaSilindirToolStripMenuItem
            // 
            this.noktaSilindirToolStripMenuItem.Name = "noktaSilindirToolStripMenuItem";
            this.noktaSilindirToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.noktaSilindirToolStripMenuItem.Text = "Nokta-Silindir";
            this.noktaSilindirToolStripMenuItem.Click += new System.EventHandler(this.noktaSilindirToolStripMenuItem_Click);
            // 
            // silindirSilindirToolStripMenuItem
            // 
            this.silindirSilindirToolStripMenuItem.Name = "silindirSilindirToolStripMenuItem";
            this.silindirSilindirToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.silindirSilindirToolStripMenuItem.Text = "Silindir-Silindir";
            this.silindirSilindirToolStripMenuItem.Click += new System.EventHandler(this.silindirSilindirToolStripMenuItem_Click);
            // 
            // küreKüreToolStripMenuItem
            // 
            this.küreKüreToolStripMenuItem.Name = "küreKüreToolStripMenuItem";
            this.küreKüreToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.küreKüreToolStripMenuItem.Text = "Küre-Küre";
            this.küreKüreToolStripMenuItem.Click += new System.EventHandler(this.küreKüreToolStripMenuItem_Click);
            // 
            // küreSilindirToolStripMenuItem
            // 
            this.küreSilindirToolStripMenuItem.Name = "küreSilindirToolStripMenuItem";
            this.küreSilindirToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.küreSilindirToolStripMenuItem.Text = "Küre-Silindir";
            this.küreSilindirToolStripMenuItem.Click += new System.EventHandler(this.küreSilindirToolStripMenuItem_Click);
            // 
            // yüzeyKüreToolStripMenuItem
            // 
            this.yüzeyKüreToolStripMenuItem.Name = "yüzeyKüreToolStripMenuItem";
            this.yüzeyKüreToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.yüzeyKüreToolStripMenuItem.Text = "Yüzey-Küre";
            this.yüzeyKüreToolStripMenuItem.Click += new System.EventHandler(this.yüzeyKüreToolStripMenuItem_Click);
            // 
            // yüzeyDikdörtgenPrizmaToolStripMenuItem
            // 
            this.yüzeyDikdörtgenPrizmaToolStripMenuItem.Name = "yüzeyDikdörtgenPrizmaToolStripMenuItem";
            this.yüzeyDikdörtgenPrizmaToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.yüzeyDikdörtgenPrizmaToolStripMenuItem.Text = "Yüzey-Dikdörtgen Prizma";
            this.yüzeyDikdörtgenPrizmaToolStripMenuItem.Click += new System.EventHandler(this.yüzeyDikdörtgenPrizmaToolStripMenuItem_Click);
            // 
            // yüzeySilindirToolStripMenuItem
            // 
            this.yüzeySilindirToolStripMenuItem.Name = "yüzeySilindirToolStripMenuItem";
            this.yüzeySilindirToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.yüzeySilindirToolStripMenuItem.Text = "Yüzey-Silindir";
            this.yüzeySilindirToolStripMenuItem.Click += new System.EventHandler(this.yüzeySilindirToolStripMenuItem_Click);
            // 
            // dikdörtgenPrizmaDikdörtgenPrizmaToolStripMenuItem
            // 
            this.dikdörtgenPrizmaDikdörtgenPrizmaToolStripMenuItem.Name = "dikdörtgenPrizmaDikdörtgenPrizmaToolStripMenuItem";
            this.dikdörtgenPrizmaDikdörtgenPrizmaToolStripMenuItem.Size = new System.Drawing.Size(349, 26);
            this.dikdörtgenPrizmaDikdörtgenPrizmaToolStripMenuItem.Text = "Dikdörtgen Prizma- Dikdörtgen Prizma";
            this.dikdörtgenPrizmaDikdörtgenPrizmaToolStripMenuItem.Click += new System.EventHandler(this.dikdörtgenPrizmaDikdörtgenPrizmaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(53, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 500);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(326, 565);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(157, 29);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 632);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çarpışmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noktaDörtgenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noktaÇemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dikdörtgenDikdörtgenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dikdörtgenÇemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çemberÇemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noktaKüreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noktaDikdörtgenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noktaSilindirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silindirSilindirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem küreKüreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem küreSilindirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yüzeyKüreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yüzeyDikdörtgenPrizmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yüzeySilindirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dikdörtgenPrizmaDikdörtgenPrizmaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

