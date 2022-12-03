using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ara_raporla.bilgiler1DataSetTableAdapters;
using System.Data.OleDb;

namespace ara_raporla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("PROVIDER = MICROSOFT.JET.OLEDB.4.0; DATA SOURCE = bilgiler1.mdb");
        void guncelle()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM TABLO1", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guncelle();

        }
        ara_raporla.bilgiler1DataSet.Tablo1DataTable dt = new bilgiler1DataSet.Tablo1DataTable();
        private void button2_Click(object sender, EventArgs e)
        {
            bilgi.durum1 = true;
            bilgi.isim = textBox1.Text;
            bilgi.soyadi = textBox2.Text;
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM TABLO1 where ADI=@p1 and SOYADI=@p2", baglanti);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            OleDbDataReader oku = cmd.ExecuteReader();
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("LÜTFEN ADI-SOYADI ALANINI BOŞ BIRAKMAYINIZ");
            }
            if (oku.Read())
            {

                DialogResult soru = MessageBox.Show("KAYIT BULUNDU RAPORLANSIN MI ?", "ARAMA", MessageBoxButtons.YesNoCancel);
                if (soru == DialogResult.Yes)
                {
                    frmReport ac = new frmReport();
                    ac.ShowDialog();
                    baglanti.Close();
                }
                else if (soru == DialogResult.No)
                {
                    MessageBox.Show("İŞLEM İPTAL EDİLDİ");
                }
                else
                {
                    MessageBox.Show("ARANILAN KAYIT BULUNAMADI... LÜTFEN KONTROL EDİNİZ...");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bilgi.durum1 = false;
            DialogResult sorgu = MessageBox.Show("TÜM BİLGİLER RAPORLANSIN MI ?", "RAPORLA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
            if (sorgu == DialogResult.Yes)
            {
                frmReport ac = new frmReport();
                ac.ShowDialog();
            }
            else { MessageBox.Show("İŞLEM İPTAL EDİLDİ"); } baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            OleDbDataAdapter ara = new OleDbDataAdapter("SELECT * FROM TABLO1 where ADI like '" + textBox1.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            ara.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.CurrentCell.RowIndex;
            bilgi.isim = dataGridView1.Rows[secilen].Cells["adi1"].Value.ToString();
            bilgi.soyadi = dataGridView1.Rows[secilen].Cells["sadi1"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bilgi.durum1 = true;
            frmReport frm = new frmReport();
            frm.ShowDialog();
        }
    }
}
