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
using System.Data.Sql;

namespace Not_Kayit_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string numara;

        SqlConnection baglanti  = new SqlConnection(@"Data Source=THINKPAD-E470;Initial Catalog=DBNotKayıt;
        Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            lblOgrenciNo.Text = numara;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLDERS WHERE OGR_NUMARA=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[2].ToString()+" "+dr[3].ToString();
                lblS1.Text = dr[4].ToString();
                lblS2.Text = dr[5].ToString();
                lblS3.Text = dr[6].ToString();
                lblOrtalama.Text = dr[7].ToString();
                lblDurum.Text = dr[8].ToString();
            }
            baglanti.Close();
        }
    }
}
