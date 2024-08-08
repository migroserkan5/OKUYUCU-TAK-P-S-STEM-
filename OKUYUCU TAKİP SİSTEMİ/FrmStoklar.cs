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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OKUYUCU_TAKİP_SİSTEMİ
{
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H0GVCUT;Initial Catalog=RftakipSistemi;Integrated Security=True;Encrypt=False");



        private void verilerigoster()
        {
            listView1.Items.Clear();    
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["RFNumarası"].ToString());
                ekle.SubItems.Add(oku["SeriNo"].ToString());
                ekle.SubItems.Add(oku["MacNo"].ToString());
                ekle.SubItems.Add(oku["Bolum"].ToString());
                ekle.SubItems.Add(oku["Depo"].ToString());
                listView1.Items.Add(ekle); 

            }
            baglanti.Close();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Stoklar(RFNumarası,SeriNo,MacNo,Bolum,Depo) values('" + Txtrfno.Text + "','" + Txtserino.Text + "','" + txtmacadresi.Text + "','" + txtbolum.Text + "','" + txtdepo.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi");
                baglanti.Close();
                verilerigoster();
                Txtrfno.Clear();
                Txtserino.Clear();
                txtmacadresi.Clear();
                txtbolum.Clear();
                txtdepo.Clear();
               




        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("id", 30);
            listView1.Columns.Add("RF Numarası", 100);
            listView1.Columns.Add("Seri Nunarası", 100);
            listView1.Columns.Add("MAC Adresi", 150);
            listView1.Columns.Add("Bölüm", 100);
            listView1.Width = 650;
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) Stoklar",baglanti);
            SqlDataReader dr= komut2.ExecuteReader();
            while(dr.Read())
            {
                label6.Text = dr[0].ToString();
            }
            baglanti.Close();
            verilerigoster();
            kayitsayisiyaz();


        }
        private void kayitsayisiyaz()
        {
            int kayitsayisi = listView1.Items.Count;
            label6.Text = Convert.ToString(kayitsayisi);
        }
        int id = 0;
        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Stoklar where id=("+id+")",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
            verilerigoster();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
          
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar where SeriNo like '%" + textBox1.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["RFNumarası"].ToString());
                ekle.SubItems.Add(oku["SeriNo"].ToString());
                ekle.SubItems.Add(oku["MacNo"].ToString());
                ekle.SubItems.Add(oku["Bolum"].ToString());
                ekle.SubItems.Add(oku["Depo"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar where SeriNo like '%" + textBox1.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["RFNumarası"].ToString());
                ekle.SubItems.Add(oku["SeriNo"].ToString());
                ekle.SubItems.Add(oku["MacNo"].ToString());
                ekle.SubItems.Add(oku["Bolum"].ToString());
                ekle.SubItems.Add(oku["Depo"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Txtrfno.Clear();
            Txtserino.Clear();
            txtmacadresi.Clear();
            txtbolum.Clear();
            txtdepo.Clear();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtid.Text = listView1.SelectedItems[0].SubItems[0].Text;
            Txtrfno.Text = listView1.SelectedItems[0].SubItems[1].Text;
            Txtserino.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtmacadresi.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtbolum.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtdepo.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Stoklar set RFNumarası='"+Txtrfno.Text.ToString()+"',SeriNo='"+Txtserino.Text.ToString()+"',MacNo='"+txtmacadresi.Text.ToString()+"',Bolum='"+txtbolum.Text.ToString()+"',Depo='"+txtdepo.Text.ToString()+"' where id=" + id + "",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi");
            verilerigoster();

        }
    }
}
