namespace _2_Donem_Proje
{
    partial class İstatislikForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.istatislikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yılaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haftayaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 36);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(726, 433);
            this.chart1.SuppressExceptions = true;
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.istatislikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // istatislikToolStripMenuItem
            // 
            this.istatislikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yılaGöreToolStripMenuItem,
            this.ayaGöreToolStripMenuItem,
            this.haftayaGöreToolStripMenuItem});
            this.istatislikToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.istatislikToolStripMenuItem.Name = "istatislikToolStripMenuItem";
            this.istatislikToolStripMenuItem.Size = new System.Drawing.Size(94, 32);
            this.istatislikToolStripMenuItem.Text = "İstatislik";
            // 
            // yılaGöreToolStripMenuItem
            // 
            this.yılaGöreToolStripMenuItem.Name = "yılaGöreToolStripMenuItem";
            this.yılaGöreToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.yılaGöreToolStripMenuItem.Text = "Yıla Göre";
            this.yılaGöreToolStripMenuItem.Click += new System.EventHandler(this.yılaGöreToolStripMenuItem_Click);
            // 
            // ayaGöreToolStripMenuItem
            // 
            this.ayaGöreToolStripMenuItem.Name = "ayaGöreToolStripMenuItem";
            this.ayaGöreToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.ayaGöreToolStripMenuItem.Text = "Ay\'a Göre";
            this.ayaGöreToolStripMenuItem.Click += new System.EventHandler(this.ayaGöreToolStripMenuItem_Click);
            // 
            // haftayaGöreToolStripMenuItem
            // 
            this.haftayaGöreToolStripMenuItem.Name = "haftayaGöreToolStripMenuItem";
            this.haftayaGöreToolStripMenuItem.Size = new System.Drawing.Size(216, 32);
            this.haftayaGöreToolStripMenuItem.Text = "Haftaya Göre";
            this.haftayaGöreToolStripMenuItem.Click += new System.EventHandler(this.haftayaGöreToolStripMenuItem_Click);
            // 
            // İstatislikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 469);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "İstatislikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstatislikForm";
            this.Load += new System.EventHandler(this.İstatislikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem istatislikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yılaGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayaGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haftayaGöreToolStripMenuItem;
    }
}