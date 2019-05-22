namespace _2_Donem_Proje
{
    partial class Egitim_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelingilizce = new System.Windows.Forms.Label();
            this.labelturkce = new System.Windows.Forms.Label();
            this.labelcumle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(80, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingilizcesi-->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Türkçesi---->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(80, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Örnek Cümle";
            // 
            // labelingilizce
            // 
            this.labelingilizce.AutoSize = true;
            this.labelingilizce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelingilizce.Location = new System.Drawing.Point(235, 97);
            this.labelingilizce.Name = "labelingilizce";
            this.labelingilizce.Size = new System.Drawing.Size(0, 25);
            this.labelingilizce.TabIndex = 0;
            // 
            // labelturkce
            // 
            this.labelturkce.AutoSize = true;
            this.labelturkce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelturkce.Location = new System.Drawing.Point(235, 141);
            this.labelturkce.Name = "labelturkce";
            this.labelturkce.Size = new System.Drawing.Size(0, 25);
            this.labelturkce.TabIndex = 0;
            // 
            // labelcumle
            // 
            this.labelcumle.AutoSize = true;
            this.labelcumle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelcumle.Location = new System.Drawing.Point(80, 229);
            this.labelcumle.Name = "labelcumle";
            this.labelcumle.Size = new System.Drawing.Size(0, 25);
            this.labelcumle.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(354, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Egitim_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 329);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelcumle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelturkce);
            this.Controls.Add(this.labelingilizce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Egitim_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egitim_Form";
            this.Load += new System.EventHandler(this.Egitim_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelingilizce;
        public System.Windows.Forms.Label labelturkce;
        public System.Windows.Forms.Label labelcumle;
    }
}