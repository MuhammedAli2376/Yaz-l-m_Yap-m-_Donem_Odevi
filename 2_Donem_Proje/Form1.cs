using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _2_Donem_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KelimeORM korm = new KelimeORM();
        private void button1_Click(object sender, EventArgs e)
        { 
            Kelime k = new Kelime();
            k.Ingilizce = textingilizce.Text;
            k.Turkce = textturkce.Text;
            k.OrnekCumle = textörnek.Text;
            k.Soru = textsoru.Text;
            k.Turu = (int)cmbtur.SelectedValue;
            k.Tekrar = DateTime.Now;
            k.Seviye = 0;
            if (korm.Ekle<Kelime>(k))
            {
                MessageBox.Show("Kelime Başarılı Bir Şekilde Eklenmiştir");
               dataGridView1.DataSource= korm.Listele<Kelime>();
                foreach(Control kontrol in Controls)
                {
                    if (kontrol is TextBox)
                        kontrol.Text = "";
                }
            }
                
            else
                MessageBox.Show("Hata");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = korm.Listele<Kelime>();
            TurORM orm = new TurORM();
            cmbtur.DataSource = orm.Listele<Turler>();
            cmbtur.DisplayMember = "Adi";
            cmbtur.ValueMember = "id";
            Aktar();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void sİlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(dataGridView1.CurrentRow.Cells["ID"].Value);
            if (korm.Sil<Kelime>(id))
            {
                MessageBox.Show("Silme İşlemi Başarılı");
                dataGridView1.DataSource = korm.Listele<Kelime>();
                
            }
            else
                MessageBox.Show("Hata");
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
            textturkce.Tag = Convert.ToInt16(dataGridView1.CurrentRow.Cells["ID"].Value);
            textingilizce.Text = dataGridView1.CurrentRow.Cells["Ingilizcesi"].Value.ToString();
            textturkce.Text = dataGridView1.CurrentRow.Cells["Turkcesi"].Value.ToString();
            textsoru.Text = dataGridView1.CurrentRow.Cells["Soru"].Value.ToString();
            textörnek.Text= dataGridView1.CurrentRow.Cells["OrnekCumle"].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kelime k = new Kelime();
            k.Ingilizce = textingilizce.Text;
            k.Turkce = textturkce.Text;
            k.OrnekCumle = textörnek.Text;
            k.Turu = (int)cmbtur.SelectedValue;
            k.Soru = textsoru.Text;
            k.Tekrar = DateTime.Now;
            k.Seviye = 0;
            if (korm.Guncelle<Kelime>(k, (Convert.ToInt16(textturkce.Tag))))
            {
                MessageBox.Show("Kelime Başarılı Bir Şekilde Güncellenmiştir");
                foreach (Control kontrol in Controls)
                {
                    if (kontrol is TextBox)
                        kontrol.Text = "";
                }
                button1.Visible = true;
                button2.Visible = false;
                dataGridView1.DataSource = korm.Listele<Kelime>();
            }
            else
                MessageBox.Show("Hata");
        }
        void Aktar()
        {
            int satır = dataGridView1.Rows.Count;
            Kelimeler kl = new Kelimeler();
            Kelime k = new Kelime();
            for (int i = 0; i < satır - 1; i++)
            {
                string Ingilizce = dataGridView1.Rows[i].Cells["Ingilizcesi"].Value.ToString();
                string Turkce = dataGridView1.Rows[i].Cells["Turkcesi"].Value.ToString();
                string ornek= dataGridView1.Rows[i].Cells["OrnekCumle"].Value.ToString();
                string Soru = dataGridView1.Rows[i].Cells["Soru"].Value.ToString();
                DateTime tekrar = Convert.ToDateTime(dataGridView1.Rows[i].Cells["Tekrar"].Value);
                int id = Convert.ToInt16(dataGridView1.Rows[i].Cells["ID"].Value);
                int seviye = Convert.ToInt16(dataGridView1.Rows[i].Cells["Seviyesi"].Value);
                int id2 = Convert.ToInt16(dataGridView1.Rows[i].Cells["id1"].Value);
                if (i == 0)
                {
                    k.Ingilizce = Ingilizce;
                    k.Turkce = Turkce;
                    k.Turu = id2;
                    k.OrnekCumle = ornek;
                    k.Soru = Soru;
                    k.Tekrar = tekrar;
                    k.Seviye = seviye;
                    k.ID = id;
                }
                else
                   kl.Ekle(k, Ingilizce, Turkce,id2,ornek, Soru, tekrar,seviye,id);
            }
            kl.Tamamlanmamis(k);
            kl.Tamamlanmis(k);
        }
        private void tESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test_Form test = new Test_Form();
            test.ShowDialog();
        }

        private void egitimiBaşlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Egitim_Form ef = new Egitim_Form();
            ef.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void istatisliklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            İstatislikForm frm = new İstatislikForm();
            frm.ShowDialog();
        }

        private void yENİLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kelimeler.Dizi = new Kelime[0];
            Kelimeler.Dizi2 = new Kelime[0];
            Aktar();
            dataGridView1.DataSource = korm.Listele<Kelime>();
        }
    }
}
