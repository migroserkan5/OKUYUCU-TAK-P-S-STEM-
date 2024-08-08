using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OKUYUCU_TAKİP_SİSTEMİ
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H0GVCUT;Initial Catalog=RftakipSistemi;Integrated Security=True;Encrypt=False");
     

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from personel", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Sicil"].ToString());
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("id", 30);
            listView1.Columns.Add("SİCİL", 100);
            listView1.Columns.Add("AD", 100);
            listView1.Columns.Add("SOYAD", 100);
            verilerigoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into personel(Sicil,Ad,Soyad)  values ('" + txtsicilno.Text + "','" + txtad.Text + "','" + txtsoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Kaydi Yapıldı.");
            verilerigoster();
            txtsicilno.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From personel where id=("+id+ ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
            verilerigoster();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Hide();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtsicilno.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtsoyad.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtsicilno.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
        }
    }
}
