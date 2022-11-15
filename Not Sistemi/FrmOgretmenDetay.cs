using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Not_Sistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2CVA09C;Initial Catalog=DbNotKayit;Integrated Security=True");
        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.TBL_DERS' table. You can move, or remove it, as needed.
            this.tBL_DERSTableAdapter.Fill(this.dbNotKayitDataSet.TBL_DERS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBL_DERS (OGR_NUM,OGR_ADI,OGR_SOYADI) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@P1", mskNumara.Text);
            komut.Parameters.AddWithValue("@P2", txtAd.Text);
            komut.Parameters.AddWithValue("@P3", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi");
            this.tBL_DERSTableAdapter.Fill(this.dbNotKayitDataSet.TBL_DERS);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            mskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(txtSinav1.Text);
            s2 = Convert.ToDouble(txtSinav2.Text);

            ortalama = (s1 + s2) / 2;
            txtORT.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";

            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBL_DERS set OGR_SNV1=@P1,OGR_SNV2=@P2,OGR_ORT=@P4,OGR_DURUM=@P5 WHERE OGR_NUM=@P6", baglanti);
            komut.Parameters.AddWithValue("@P1", txtSinav1.Text);
            komut.Parameters.AddWithValue("@P2", txtSinav2.Text);
            komut.Parameters.AddWithValue("@P4", decimal.Parse(txtORT.Text));
            komut.Parameters.AddWithValue("@P5", durum);
            komut.Parameters.AddWithValue("@P6", mskNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğreni Notları Güncellendi");
            this.tBL_DERSTableAdapter.Fill(this.dbNotKayitDataSet.TBL_DERS);

        }
    }
}
