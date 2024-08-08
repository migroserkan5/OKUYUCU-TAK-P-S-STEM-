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

namespace OKUYUCU_TAKİP_SİSTEMİ
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-H0GVCUT;Initial Catalog=RftakipSistemi;Integrated Security=True;Encrypt=False");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriID"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["barkod"].ToString());
                ekle.SubItems.Add(oku["sicil"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = (listView1.SelectedItems[0].SubItems[1].Text);
            TxtSoyadi.Text = (listView1.SelectedItems[0].SubItems[2].Text);
            TxtOdaNo.Text = (listView1.SelectedItems[0].SubItems[3].Text);
            TxtUcret.Text = (listView1.SelectedItems[0].SubItems[4].Text);
            DtpGirisTaihi.Text = (listView1.SelectedItems[0].SubItems[5].Text);
            DtpCikisTarihi.Text = (listView1.SelectedItems[0].SubItems[6].Text);
            TxtBarkod.Text = (listView1.SelectedItems[0].SubItems[7].Text);
            TxtSicil.Text = (listView1.SelectedItems[0].SubItems[8].Text);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='"+TxtAdi.Text+"',Soyadi='"+TxtSoyadi.Text+"','"+TxtOdaNo.Text+"',Ucret='"+TxtUcret.Text+"',GirisTarihi='"+DtpGirisTaihi.Value.ToString("yyyy-MM-dd")+"','"+DtpCikisTarihi.Value.ToString("dddd-MM-yy")+"'  where Musteriid="+id+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TxtOdaNo.Text == "7000")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();

            }
            if (TxtOdaNo.Text == "7001")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7002")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7003")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7004")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda105", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7005")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda106", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7006")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda107", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7007")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda108", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7008")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda109", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7010")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda110", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7011")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda111", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Sillindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7012")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda112", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7013")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda113", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7014")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda114", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7015")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda115", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7016")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda116", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7017")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda117", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7018")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda118", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7019")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda119", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7020")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda120", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7021")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda121", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7022")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda122", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7023")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda123", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7024")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda124", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7025")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda123", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7026")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda123", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7027")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda124", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7028")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda125", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7029")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda126", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7030")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda127", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7031")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda128", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7032")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda129", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7033")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda129", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7034")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda130", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7035")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda131", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7036")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda132", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7037")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda133", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7038")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda134", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7038")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda135", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7039")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda136", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7040")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda137", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7041")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda137", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7042")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda137", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7043")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda137", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7044")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda137", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7045")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda137", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7046")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda137", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7047")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda137", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7048")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda137", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7049")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda137", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7050")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda137", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7051")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda137", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7052")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda137", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7053")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda137", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }
            if (TxtOdaNo.Text == "7054")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda137", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi");
                verilerigoster();
            }

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            TxtUcret.Clear();
            DtpCikisTarihi.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where TC like '%"+textBox1.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriID"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["barkod"].ToString());
                ekle.SubItems.Add(oku["sicil"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

            listView1.Columns.Add("NO", 30);
            listView1.Columns.Add("ADI", 50);
            listView1.Columns.Add("SOYADI", 70);
            listView1.Columns.Add("RFNO", 50);
            listView1.Columns.Add("ÜCRET", 50);
            listView1.Columns.Add("GİRİS TARİHİ", 100);
            listView1.Columns.Add("CIKIS TARİHİ", 100);
            listView1.Columns.Add("BARKOD", 100);
            listView1.Columns.Add("Sicil", 100);
            verilerigoster();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where barkod like '%" + textBox1.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriID"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["barkod"].ToString());
                ekle.SubItems.Add(oku["sicil"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
