using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Not_Kayit_Sistemi
{
    public partial class OgretmenPaneli : Form
    {
        public OgretmenPaneli()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=THINKPAD-E470;Initial Catalog=DBNotKayıt;
        Integrated Security=True");
        private void OgretmenPaneli_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBNotKayıtDataSet.TBLDERS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLDERSTableAdapter.Fill(this.dBNotKayıtDataSet.TBLDERS);

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERS(OGR_NUMARA,OGR_AD,OGR_SOYAD) values (@P1,@P2,@P3)",baglanti );
            komut.Parameters.AddWithValue("@P1",txtNumara.Text);
            komut.Parameters.AddWithValue("@P2",txtAd.Text);
            komut.Parameters.AddWithValue("@P3", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi.:)");
            this.tBLDERSTableAdapter.Fill(this.dBNotKayıtDataSet.TBLDERS);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilmis = dataGridView1.SelectedCells[0].RowIndex; // seçilen satıra göre 0'ncı indeksi al 
            txtNumara.Text = dataGridView1.Rows[secilmis].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilmis].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilmis].Cells[3].Value.ToString();
            txtS1.Text = dataGridView1.Rows[secilmis].Cells[4].Value.ToString();
            txtS2.Text = dataGridView1.Rows[secilmis].Cells[5].Value.ToString();
            txtS3.Text = dataGridView1.Rows[secilmis].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(txtS1.Text);
            s2 = Convert.ToDouble(txtS2.Text);
            s3 = Convert.ToDouble(txtS3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            lblSınıfOrtalama.Text =ortalama.ToString();

            if (ortalama >=50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLDERS set OGR_S1=@P1,OGR_S2=@P2,OGR_S3=@P3,ORTALAM=@P4,DURUM=@P5 WHERE OGR_NUMARA=@P6",baglanti);
            komut.Parameters.AddWithValue("@P1", txtS1.Text);
            komut.Parameters.AddWithValue("@P2", txtS2.Text);
            komut.Parameters.AddWithValue("@P3", txtS3.Text);
            komut.Parameters.AddWithValue("@P4", decimal.Parse(lblSınıfOrtalama.Text));
            komut.Parameters.AddWithValue("@P5",durum);
            komut.Parameters.AddWithValue("@P6", txtNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi :)");
            this.tBLDERSTableAdapter.Fill(this.dBNotKayıtDataSet.TBLDERS);
        }

    }
}
