namespace _2_Donem_Proje
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sİlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textingilizce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textturkce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textsoru = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egitimiBaşlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatisliklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yENİLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.textörnek = new System.Windows.Forms.TextBox();
            this.cmbtur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(713, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sİlToolStripMenuItem,
            this.guncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 52);
            // 
            // sİlToolStripMenuItem
            // 
            this.sİlToolStripMenuItem.Name = "sİlToolStripMenuItem";
            this.sİlToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.sİlToolStripMenuItem.Text = "Sil";
            this.sİlToolStripMenuItem.Click += new System.EventHandler(this.sİlToolStripMenuItem_Click);
            // 
            // guncelleToolStripMenuItem
            // 
            this.guncelleToolStripMenuItem.Name = "guncelleToolStripMenuItem";
            this.guncelleToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.guncelleToolStripMenuItem.Text = "Guncelle";
            this.guncelleToolStripMenuItem.Click += new System.EventHandler(this.guncelleToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(731, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingilizcesi:";
            // 
            // textingilizce
            // 
            this.textingilizce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textingilizce.Location = new System.Drawing.Point(877, 53);
            this.textingilizce.Name = "textingilizce";
            this.textingilizce.Size = new System.Drawing.Size(100, 26);
            this.textingilizce.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(731, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turkcesi:";
            // 
            // textturkce
            // 
            this.textturkce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textturkce.Location = new System.Drawing.Point(877, 101);
            this.textturkce.Name = "textturkce";
            this.textturkce.Size = new System.Drawing.Size(100, 26);
            this.textturkce.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(731, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sorusu:";
            // 
            // textsoru
            // 
            this.textsoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textsoru.Location = new System.Drawing.Point(877, 204);
            this.textsoru.Multiline = true;
            this.textsoru.Name = "textsoru";
            this.textsoru.Size = new System.Drawing.Size(155, 41);
            this.textsoru.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(763, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(763, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "KAYDET";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tESTToolStripMenuItem,
            this.egitimiBaşlatToolStripMenuItem,
            this.istatisliklerToolStripMenuItem,
            this.yENİLEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 40);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tESTToolStripMenuItem
            // 
            this.tESTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tESTToolStripMenuItem.Name = "tESTToolStripMenuItem";
            this.tESTToolStripMenuItem.Size = new System.Drawing.Size(78, 36);
            this.tESTToolStripMenuItem.Text = "TEST";
            this.tESTToolStripMenuItem.Click += new System.EventHandler(this.tESTToolStripMenuItem_Click);
            // 
            // egitimiBaşlatToolStripMenuItem
            // 
            this.egitimiBaşlatToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.egitimiBaşlatToolStripMenuItem.Name = "egitimiBaşlatToolStripMenuItem";
            this.egitimiBaşlatToolStripMenuItem.Size = new System.Drawing.Size(141, 36);
            this.egitimiBaşlatToolStripMenuItem.Text = "Egitimi Başlat";
            this.egitimiBaşlatToolStripMenuItem.Click += new System.EventHandler(this.egitimiBaşlatToolStripMenuItem_Click);
            // 
            // istatisliklerToolStripMenuItem
            // 
            this.istatisliklerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.istatisliklerToolStripMenuItem.Name = "istatisliklerToolStripMenuItem";
            this.istatisliklerToolStripMenuItem.Size = new System.Drawing.Size(116, 36);
            this.istatisliklerToolStripMenuItem.Text = "İstatislikler";
            this.istatisliklerToolStripMenuItem.Click += new System.EventHandler(this.istatisliklerToolStripMenuItem_Click);
            // 
            // yENİLEToolStripMenuItem
            // 
            this.yENİLEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.yENİLEToolStripMenuItem.Name = "yENİLEToolStripMenuItem";
            this.yENİLEToolStripMenuItem.Size = new System.Drawing.Size(99, 36);
            this.yENİLEToolStripMenuItem.Text = "YENİLE";
            this.yENİLEToolStripMenuItem.Click += new System.EventHandler(this.yENİLEToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(731, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Örnek Cümle:";
            // 
            // textörnek
            // 
            this.textörnek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textörnek.Location = new System.Drawing.Point(877, 143);
            this.textörnek.Multiline = true;
            this.textörnek.Name = "textörnek";
            this.textörnek.Size = new System.Drawing.Size(155, 41);
            this.textörnek.TabIndex = 2;
            // 
            // cmbtur
            // 
            this.cmbtur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbtur.FormattingEnabled = true;
            this.cmbtur.Location = new System.Drawing.Point(877, 281);
            this.cmbtur.Name = "cmbtur";
            this.cmbtur.Size = new System.Drawing.Size(155, 33);
            this.cmbtur.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(731, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Türü:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 538);
            this.Controls.Add(this.cmbtur);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textörnek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textsoru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textturkce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textingilizce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textingilizce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textturkce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textsoru;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sİlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guncelleToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tESTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egitimiBaşlatToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textörnek;
        private System.Windows.Forms.ToolStripMenuItem istatisliklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yENİLEToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbtur;
        private System.Windows.Forms.Label label5;
    }
}

