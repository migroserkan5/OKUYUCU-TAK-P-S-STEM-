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

namespace OKUYUCU_TAKİP_SİSTEMİ
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H0GVCUT;Initial Catalog=RftakipSistemi;Integrated Security=True;Encrypt=False");

        private void button14_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "114";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda114(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "7000";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda101(Adi,Soyadi) values ('"+TxtAdi.Text+"','"+TxtSoyadi.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "7001";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda102(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "7002";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda103(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "7003";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda104(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "7004";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda105(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "7005";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda106(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "7006";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda107(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "7007";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda108(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "7008";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda109(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "115";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda115(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "116";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda116(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "117";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda117(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "118";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda118(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "119";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda119(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "120";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda120(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "121";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda121(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "122";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda122(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "127";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda127(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "128";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda128(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "129";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda129(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "130";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda130(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "131";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda131(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "132";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda132(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "133";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda133(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "134";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda134(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "135";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda135(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "140";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda140(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "141";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda141(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "142";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda142(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "143";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda143(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "144";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda144(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "145";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda145(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "146";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda146(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "147";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda147(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "148";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda148(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void button43_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "153";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda153(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "154";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda154(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "155";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda155(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "156";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda156(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "157";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda157(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "158";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda158(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "159";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda159(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "160";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda160(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "161";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda161(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "166";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda166(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "167";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda167(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "168";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda168(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "169";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda169(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "170";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda170(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "171";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda171(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "172";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda172(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "173";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda173(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "174";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda174(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir.");
        }

        private void button59_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar dolu odaları gosterir.");
        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih=Convert.ToDateTime(DtpGirisTaihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc=BuyukTarih - KucukTarih;

            label12.Text = Sonuc.TotalDays.ToString();
            Ucret = Convert.ToInt32(label12.Text) * 50;
            TxtUcret.Text = Ucret.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle(Adi,Soyadi,OdaNo,Ücret,GirisTarihi,Cikistarihi,barkod,sicil)  values ('"+TxtAdi.Text+"','"+TxtSoyadi.Text+"','"+TxtOdaNo.Text+"','"+TxtUcret.Text+"','"+DtpGirisTaihi.Value.ToString("yyyy-MM-dd")+"','"+DtpCikisTarihi.Value.ToString("yyyy-MM-dd")+"','"+TxtBarkod.Text+"','"+txtsicil.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Kaydi Yapıldı.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAnaForm fr = new FrmAnaForm();
            fr.Show();
            this.Hide();
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            timer1.Start();
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                BtnOda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString() + " " + oku1["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda101.Text != "7000")
            {
                BtnOda101.BackColor = Color.Red;
                BtnOda101.Enabled = false;
            }

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BtnOda102.Text = oku2["Adi"].ToString() + " " + oku2["soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda102.Text != "7001")
            {
                BtnOda102.BackColor = Color.Red;
                BtnOda102.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BtnOda103.Text = oku3["Adi"].ToString() + " " + oku3["soyadi"].ToString();
            }
            baglanti.Close();
            if (BtnOda103.Text != "7002")
            {
                BtnOda103.BackColor = Color.Red;
                BtnOda103.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BtnOda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString() + " " + oku4["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda104.Text != "7003")
            {
                BtnOda104.BackColor = Color.Red;
                BtnOda104.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BtnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString() + " " + oku5["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda105.Text != "7004")
            {
                BtnOda105.BackColor = Color.Red;
                BtnOda105.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BtnOda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString() + " " + oku6["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda106.Text != "7005")
            {
                BtnOda106.BackColor = Color.Red;
                BtnOda106.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BtnOda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString() + " " + oku7["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda107.Text != "7006")
            {
                BtnOda107.BackColor = Color.Red;
                BtnOda107.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                BtnOda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString() + " " + oku8["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda108.Text != "7007")
            {
                BtnOda108.BackColor = Color.Red;
                BtnOda108.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                BtnOda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString() + " " + oku9["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda109.Text != "7008")
            {
                BtnOda109.BackColor = Color.Red;
                BtnOda109.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut10 = new SqlCommand("select * from Oda110", baglanti);
            SqlDataReader oku10 = komut10.ExecuteReader();

            while (oku10.Read())
            {
                BtnOda110.Text = oku10["Adi"].ToString() + " " + oku10["Soyadi"].ToString() + " " + oku10["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda110.Text != "7010")
            {
                BtnOda110.BackColor = Color.Red;
                BtnOda110.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut11 = new SqlCommand("select * from Oda111", baglanti);
            SqlDataReader oku11 = komut11.ExecuteReader();

            while (oku11.Read())
            {
                BtnOda111.Text = oku11["Adi"].ToString() + " " + oku11["Soyadi"].ToString() + " " + oku11["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda111.Text != "7011")
            {
                BtnOda111.BackColor = Color.Red;
                BtnOda111.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut12 = new SqlCommand("select * from Oda112", baglanti);
            SqlDataReader oku12 = komut12.ExecuteReader();

            while (oku12.Read())
            {
                BtnOda112.Text = oku12["Adi"].ToString() + " " + oku12["Soyadi"].ToString() + " " + oku12["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda112.Text != "7012")
            {
                BtnOda112.BackColor = Color.Red;
                BtnOda112.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut13 = new SqlCommand("select * from Oda113", baglanti);
            SqlDataReader oku13 = komut13.ExecuteReader();

            while (oku13.Read())
            {
                BtnOda113.Text = oku13["Adi"].ToString() + " " + oku13["Soyadi"].ToString() + " " + oku13["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda113.Text != "7013")
            {
                BtnOda113.BackColor = Color.Red;
                BtnOda113.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut14 = new SqlCommand("select * from Oda114", baglanti);
            SqlDataReader oku14 = komut14.ExecuteReader();

            while (oku14.Read())
            {
                BtnOda114.Text = oku14["Adi"].ToString() + " " + oku14["Soyadi"].ToString() + " " + oku14["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda114.Text != "7014")
            {
                BtnOda114.BackColor = Color.Red;
                BtnOda114.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut15 = new SqlCommand("select * from Oda115", baglanti);
            SqlDataReader oku15 = komut15.ExecuteReader();

            while (oku15.Read())
            {
                BtnOda115.Text = oku15["Adi"].ToString() + " " + oku15["Soyadi"].ToString() + " " + oku15["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda115.Text != "7015")
            {
                BtnOda115.BackColor = Color.Red;
                BtnOda115.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut16 = new SqlCommand("select * from Oda116", baglanti);
            SqlDataReader oku16 = komut16.ExecuteReader();

            while (oku16.Read())
            {
                BtnOda116.Text = oku16["Adi"].ToString() + " " + oku16["Soyadi"].ToString() + " " + oku16["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda116.Text != "7016")
            {
                BtnOda116.BackColor = Color.Red;
                BtnOda116.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut17 = new SqlCommand("select * from Oda117", baglanti);
            SqlDataReader oku17 = komut17.ExecuteReader();

            while (oku17.Read())
            {
                BtnOda117.Text = oku17["Adi"].ToString() + " " + oku17["Soyadi"].ToString() + " " + oku17["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda117.Text != "7017")
            {
                BtnOda117.BackColor = Color.Red;
                BtnOda117.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut18 = new SqlCommand("select * from Oda118", baglanti);
            SqlDataReader oku18 = komut18.ExecuteReader();

            while (oku18.Read())
            {
                BtnOda118.Text = oku18["Adi"].ToString() + " " + oku18["Soyadi"].ToString() + " " + oku18["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda118.Text != "7018")
            {
                BtnOda118.BackColor = Color.Red;
                BtnOda118.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut19 = new SqlCommand("select * from Oda119", baglanti);
            SqlDataReader oku19 = komut19.ExecuteReader();

            while (oku19.Read())
            {
                BtnOda119.Text = oku19["Adi"].ToString() + " " + oku19["Soyadi"].ToString() + " " + oku19["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda119.Text != "7019")
            {
                BtnOda119.BackColor = Color.Red;
                BtnOda119.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut20 = new SqlCommand("select * from Oda120", baglanti);
            SqlDataReader oku20 = komut20.ExecuteReader();

            while (oku20.Read())
            {
                BtnOda120.Text = oku20["Adi"].ToString() + " " + oku20["Soyadi"].ToString() + " " + oku20["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda120.Text != "7020")
            {
                BtnOda120.BackColor = Color.Red;
                BtnOda120.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut21 = new SqlCommand("select * from Oda121", baglanti);
            SqlDataReader oku21 = komut21.ExecuteReader();

            while (oku21.Read())
            {
                BtnOda121.Text = oku21["Adi"].ToString() + " " + oku21["Soyadi"].ToString() + " " + oku21["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda121.Text != "7021")
            {
                BtnOda121.BackColor = Color.Red;
                BtnOda121.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut22 = new SqlCommand("select * from Oda122", baglanti);
            SqlDataReader oku22 = komut22.ExecuteReader();

            while (oku22.Read())
            {
                BtnOda122.Text = oku22["Adi"].ToString() + " " + oku22["Soyadi"].ToString() + " " + oku22["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda122.Text != "7022")
            {
                BtnOda122.BackColor = Color.Red;
                BtnOda122.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut23 = new SqlCommand("select * from Oda123", baglanti);
            SqlDataReader oku23 = komut23.ExecuteReader();

            while (oku23.Read())
            {
                BtnOda123.Text = oku23["Adi"].ToString() + " " + oku23["Soyadi"].ToString() + " " + oku23["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda123.Text != "7023")
            {
                BtnOda123.BackColor = Color.Red;
                BtnOda123.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut24 = new SqlCommand("select * from Oda124", baglanti);
            SqlDataReader oku24 = komut24.ExecuteReader();

            while (oku24.Read())
            {
                BtnOda124.Text = oku24["Adi"].ToString() + " " + oku24["Soyadi"].ToString() + " " + oku24["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda124.Text != "7024")
            {
                BtnOda124.BackColor = Color.Red;
                BtnOda124.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut25 = new SqlCommand("select * from Oda125", baglanti);
            SqlDataReader oku25 = komut25.ExecuteReader();

            while (oku25.Read())
            {
                BtnOda125.Text = oku25["Adi"].ToString() + " " + oku25["Soyadi"].ToString() + " " + oku25["Oda"].ToString();
            }
            baglanti.Close();
            if (BtnOda125.Text != "7025")
            {
                BtnOda125.BackColor = Color.Red;
                BtnOda125.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut26 = new SqlCommand("select * from Oda126", baglanti);
            SqlDataReader oku26 = komut26.ExecuteReader();

            while (oku26.Read())
            {
                BtnOda126.Text = oku26["Adi"].ToString() + " " + oku26["Soyadi"].ToString() + " " + oku26["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda126.Text != "7026")
            {
                BtnOda126.BackColor = Color.Red;
                BtnOda126.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut27 = new SqlCommand("select * from Oda127", baglanti);
            SqlDataReader oku27 = komut27.ExecuteReader();

            while (oku27.Read())
            {
                BtnOda127.Text = oku27["Adi"].ToString() + " " + oku27["Soyadi"].ToString() + " " + oku27["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda127.Text != "7027")
            {
                BtnOda127.BackColor = Color.Red;
                BtnOda127.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut28 = new SqlCommand("select * from Oda128", baglanti);
            SqlDataReader oku28 = komut28.ExecuteReader();

            while (oku28.Read())
            {
                BtnOda128.Text = oku28["Adi"].ToString() + " " + oku28["Soyadi"].ToString() + " " + oku28["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda128.Text != "7028")
            {
                BtnOda128.BackColor = Color.Red;
                BtnOda128.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut29 = new SqlCommand("select * from Oda129", baglanti);
            SqlDataReader oku29 = komut29.ExecuteReader();

            while (oku29.Read())
            {
                BtnOda129.Text = oku29["Adi"].ToString() + " " + oku29["Soyadi"].ToString() + " " + oku29["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda129.Text != "7029")
            {
                BtnOda129.BackColor = Color.Red;
                BtnOda129.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut30 = new SqlCommand("select * from Oda130", baglanti);
            SqlDataReader oku30 = komut30.ExecuteReader();

            while (oku30.Read())
            {
                BtnOda130.Text = oku30["Adi"].ToString() + " " + oku30["Soyadi"].ToString() + " " + oku30["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda130.Text != "7030")
            {
                BtnOda130.BackColor = Color.Red;
                BtnOda130.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut31 = new SqlCommand("select * from Oda131", baglanti);
            SqlDataReader oku31 = komut31.ExecuteReader();

            while (oku31.Read())
            {
                BtnOda131.Text = oku31["Adi"].ToString() + " " + oku31["Soyadi"].ToString() + " " + oku31["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda131.Text != "7031")
            {
                BtnOda131.BackColor = Color.Red;
                BtnOda131.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut32 = new SqlCommand("select * from Oda132", baglanti);
            SqlDataReader oku32 = komut32.ExecuteReader();

            while (oku32.Read())
            {
                BtnOda132.Text = oku32["Adi"].ToString() + " " + oku32["Soyadi"].ToString() + " " + oku32["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda132.Text != "7032")
            {
                BtnOda132.BackColor = Color.Red;
                BtnOda132.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut33 = new SqlCommand("select * from Oda133", baglanti);
            SqlDataReader oku33 = komut33.ExecuteReader();

            while (oku33.Read())
            {
                BtnOda133.Text = oku33["Adi"].ToString() + " " + oku33["Soyadi"].ToString() + " " + oku33["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda133.Text != "7033")
            {
                BtnOda133.BackColor = Color.Red;
                BtnOda133.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut34 = new SqlCommand("select * from Oda134", baglanti);
            SqlDataReader oku34 = komut34.ExecuteReader();

            while (oku34.Read())
            {
                BtnOda134.Text = oku34["Adi"].ToString() + " " + oku34["Soyadi"].ToString() + " " + oku34["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda134.Text != "7034")
            {
                BtnOda134.BackColor = Color.Red;
                BtnOda134.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut35 = new SqlCommand("select * from Oda135", baglanti);
            SqlDataReader oku35 = komut35.ExecuteReader();

            while (oku35.Read())
            {
                BtnOda135.Text = oku35["Adi"].ToString() + " " + oku35["Soyadi"].ToString() + " " + oku35["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda135.Text != "7035")
            {
                BtnOda135.BackColor = Color.Red;
                BtnOda135.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut36 = new SqlCommand("select * from Oda136", baglanti);
            SqlDataReader oku36 = komut35.ExecuteReader();

            while (oku36.Read())
            {
                BtnOda136.Text = oku36["Adi"].ToString() + " " + oku36["Soyadi"].ToString() + " " + oku36["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda136.Text != "7036")
            {
                BtnOda136.BackColor = Color.Red;
                BtnOda136.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut37 = new SqlCommand("select * from Oda137", baglanti);
            SqlDataReader oku37 = komut37.ExecuteReader();

            while (oku37.Read())
            {
                BtnOda137.Text = oku37["Adi"].ToString() + " " + oku37["Soyadi"].ToString() + " " + oku37["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda137.Text != "7037")
            {
                BtnOda137.BackColor = Color.Red;
                BtnOda137.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut38 = new SqlCommand("select * from Oda138", baglanti);
            SqlDataReader oku38 = komut38.ExecuteReader();

            while (oku38.Read())
            {
                BtnOda138.Text = oku38["Adi"].ToString() + " " + oku38["Soyadi"].ToString() + " " + oku38["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda138.Text != "7038")
            {
                BtnOda138.BackColor = Color.Red;
                BtnOda138.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut39 = new SqlCommand("select * from Oda139", baglanti);
            SqlDataReader oku39 = komut39.ExecuteReader();

            while (oku39.Read())
            {
                BtnOda139.Text = oku39["Adi"].ToString() + " " + oku39["Soyadi"].ToString() + " " + oku39["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda139.Text != "7039")
            {
                BtnOda139.BackColor = Color.Red;
                BtnOda139.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut40 = new SqlCommand("select * from Oda140", baglanti);
            SqlDataReader oku40 = komut40.ExecuteReader();

            while (oku40.Read())
            {
                BtnOda140.Text = oku40["Adi"].ToString() + " " + oku40["Soyadi"].ToString() + " " + oku40["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda140.Text != "7040")
            {
                BtnOda140.BackColor = Color.Red;
                BtnOda140.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut41 = new SqlCommand("select * from Oda141", baglanti);
            SqlDataReader oku41 = komut41.ExecuteReader();

            while (oku41.Read())
            {
                BtnOda141.Text = oku41["Adi"].ToString() + " " + oku41["Soyadi"].ToString() + " " + oku41["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda141.Text != "7041")
            {
                BtnOda141.BackColor = Color.Red;
                BtnOda141.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut42 = new SqlCommand("select * from Oda142", baglanti);
            SqlDataReader oku42 = komut42.ExecuteReader();

            while (oku42.Read())
            {
                BtnOda142.Text = oku42["Adi"].ToString() + " " + oku42["Soyadi"].ToString() + " " + oku42["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda142.Text != "7042")
            {
                BtnOda142.BackColor = Color.Red;
                BtnOda142.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut43 = new SqlCommand("select * from Oda143", baglanti);
            SqlDataReader oku43 = komut43.ExecuteReader();

            while (oku43.Read())
            {
                BtnOda143.Text = oku43["Adi"].ToString() + " " + oku43["Soyadi"].ToString() + " " + oku43["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda143.Text != "7043")
            {
                BtnOda143.BackColor = Color.Red;
                BtnOda143.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut44 = new SqlCommand("select * from Oda144", baglanti);
            SqlDataReader oku44 = komut44.ExecuteReader();

            while (oku44.Read())
            {
                BtnOda144.Text = oku44["Adi"].ToString() + " " + oku44["Soyadi"].ToString() + " " + oku44["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda144.Text != "7044")
            {
                BtnOda144.BackColor = Color.Red;
                BtnOda144.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut45 = new SqlCommand("select * from Oda145", baglanti);
            SqlDataReader oku45 = komut45.ExecuteReader();

            while (oku45.Read())
            {
                BtnOda145.Text = oku45["Adi"].ToString() + " " + oku45["Soyadi"].ToString() + " " + oku45["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda145.Text != "7045")
            {
                BtnOda145.BackColor = Color.Red;
                BtnOda145.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut46 = new SqlCommand("select * from Oda146", baglanti);
            SqlDataReader oku46 = komut46.ExecuteReader();

            while (oku46.Read())
            {
                BtnOda146.Text = oku46["Adi"].ToString() + " " + oku46["Soyadi"].ToString() + " " + oku46["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda146.Text != "7046")
            {
                BtnOda146.BackColor = Color.Red;
                BtnOda146.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut47 = new SqlCommand("select * from Oda147", baglanti);
            SqlDataReader oku47 = komut46.ExecuteReader();

            while (oku47.Read())
            {
                BtnOda147.Text = oku47["Adi"].ToString() + " " + oku47["Soyadi"].ToString() + " " + oku47["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda147.Text != "7047")
            {
                BtnOda147.BackColor = Color.Red;
                BtnOda147.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut48 = new SqlCommand("select * from Oda148", baglanti);
            SqlDataReader oku48 = komut48.ExecuteReader();

            while (oku48.Read())
            {
                BtnOda148.Text = oku48["Adi"].ToString() + " " + oku48["Soyadi"].ToString() + " " + oku48["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda148.Text != "7048")
            {
                BtnOda148.BackColor = Color.Red;
                BtnOda148.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut49 = new SqlCommand("select * from Oda149", baglanti);
            SqlDataReader oku49 = komut49.ExecuteReader();

            while (oku49.Read())
            {
                BtnOda149.Text = oku49["Adi"].ToString() + " " + oku49["Soyadi"].ToString() + " " + oku49["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda149.Text != "7049")
            {
                BtnOda149.BackColor = Color.Red;
                BtnOda149.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut50 = new SqlCommand("select * from Oda150", baglanti);
            SqlDataReader oku50 = komut50.ExecuteReader();

            while (oku50.Read())
            {
                BtnOda150.Text = oku50["Adi"].ToString() + " " + oku50["Soyadi"].ToString() + " " + oku50["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda150.Text != "7050")
            {
                BtnOda150.BackColor = Color.Red;
                BtnOda150.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut51 = new SqlCommand("select * from Oda151", baglanti);
            SqlDataReader oku51 = komut51.ExecuteReader();

            while (oku51.Read())
            {
                BtnOda151.Text = oku51["Adi"].ToString() + " " + oku51["Soyadi"].ToString() + " " + oku51["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda151.Text != "7051")
            {
                BtnOda151.BackColor = Color.Red;
                BtnOda151.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut52 = new SqlCommand("select * from Oda152", baglanti);
            SqlDataReader oku52 = komut52.ExecuteReader();

            while (oku52.Read())
            {
                BtnOda152.Text = oku52["Adi"].ToString() + " " + oku52["Soyadi"].ToString() + " " + oku52["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda152.Text != "7052")
            {
                BtnOda152.BackColor = Color.Red;
                BtnOda152.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut53 = new SqlCommand("select * from Oda153", baglanti);
            SqlDataReader oku53 = komut53.ExecuteReader();

            while (oku53.Read())
            {
                BtnOda153.Text = oku53["Adi"].ToString() + " " + oku53["Soyadi"].ToString() + " " + oku53["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda153.Text != "7053")
            {
                BtnOda153.BackColor = Color.Red;
                BtnOda153.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut54 = new SqlCommand("select * from Oda154", baglanti);
            SqlDataReader oku54 = komut54.ExecuteReader();

            while (oku54.Read())
            {
                BtnOda154.Text = oku54["Adi"].ToString() + " " + oku54["Soyadi"].ToString() + " " + oku54["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda154.Text != "7054")
            {
                BtnOda154.BackColor = Color.Red;
                BtnOda154.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut55 = new SqlCommand("select * from Oda155", baglanti);
            SqlDataReader oku55 = komut55.ExecuteReader();

            while (oku55.Read())
            {
                BtnOda155.Text = oku55["Adi"].ToString() + " " + oku55["Soyadi"].ToString() + " " + oku55["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda155.Text != "7055")
            {
                BtnOda155.BackColor = Color.Red;
                BtnOda155.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut56 = new SqlCommand("select * from Oda156", baglanti);
            SqlDataReader oku56 = komut56.ExecuteReader();

            while (oku56.Read())
            {
                BtnOda156.Text = oku56["Adi"].ToString() + " " + oku56["Soyadi"].ToString() + " " + oku56["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda156.Text != "7056")
            {
                BtnOda156.BackColor = Color.Red;
                BtnOda156.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut57 = new SqlCommand("select * from Oda157", baglanti);
            SqlDataReader oku57 = komut56.ExecuteReader();

            while (oku57.Read())
            {
                BtnOda157.Text = oku57["Adi"].ToString() + " " + oku57["Soyadi"].ToString() + " " + oku57["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda157.Text != "7057")
            {
                BtnOda157.BackColor = Color.Red;
                BtnOda157.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut58 = new SqlCommand("select * from Oda158", baglanti);
            SqlDataReader oku58 = komut58.ExecuteReader();

            while (oku58.Read())
            {
                BtnOda158.Text = oku58["Adi"].ToString() + " " + oku58["Soyadi"].ToString() + " " + oku58["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda158.Text != "7058")
            {
                BtnOda158.BackColor = Color.Red;
                BtnOda158.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut59 = new SqlCommand("select * from Oda159", baglanti);
            SqlDataReader oku59 = komut59.ExecuteReader();

            while (oku59.Read())
            {
                BtnOda159.Text = oku59["Adi"].ToString() + " " + oku59["Soyadi"].ToString() + " " + oku59["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda159.Text != "7059")
            {
                BtnOda159.BackColor = Color.Red;
                BtnOda159.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut60 = new SqlCommand("select * from Oda160", baglanti);
            SqlDataReader oku60 = komut60.ExecuteReader();

            while (oku60.Read())
            {
                BtnOda160.Text = oku60["Adi"].ToString() + " " + oku60["Soyadi"].ToString() + " " + oku60["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda160.Text != "7060")
            {
                BtnOda160.BackColor = Color.Red;
                BtnOda160.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut61 = new SqlCommand("select * from Oda161", baglanti);
            SqlDataReader oku61 = komut61.ExecuteReader();

            while (oku61.Read())
            {
                BtnOda161.Text = oku61["Adi"].ToString() + " " + oku61["Soyadi"].ToString() + " " + oku61["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda161.Text != "7061")
            {
                BtnOda161.BackColor = Color.Red;
                BtnOda161.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut62 = new SqlCommand("select * from Oda162", baglanti);
            SqlDataReader oku62 = komut62.ExecuteReader();

            while (oku62.Read())
            {
                BtnOda162.Text = oku62["Adi"].ToString() + " " + oku62["Soyadi"].ToString() + " " + oku62["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda162.Text != "7062")
            {
                BtnOda162.BackColor = Color.Red;
                BtnOda162.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut63 = new SqlCommand("select * from Oda163", baglanti);
            SqlDataReader oku63 = komut63.ExecuteReader();

            while (oku63.Read())
            {
                BtnOda163.Text = oku63["Adi"].ToString() + " " + oku63["Soyadi"].ToString() + " " + oku63["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda163.Text != "7063")
            {
                BtnOda163.BackColor = Color.Red;
                BtnOda163.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut64 = new SqlCommand("select * from Oda164", baglanti);
            SqlDataReader oku64 = komut64.ExecuteReader();

            while (oku64.Read())
            {
                BtnOda164.Text = oku64["Adi"].ToString() + " " + oku64["Soyadi"].ToString() + " " + oku64["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda164.Text != "7064")
            {
                BtnOda164.BackColor = Color.Red;
                BtnOda164.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut65 = new SqlCommand("select * from Oda165", baglanti);
            SqlDataReader oku65 = komut65.ExecuteReader();

            while (oku65.Read())
            {
                BtnOda165.Text = oku65["Adi"].ToString() + " " + oku65["Soyadi"].ToString() + " " + oku65["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda165.Text != "7065")
            {
                BtnOda165.BackColor = Color.Red;
                BtnOda165.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut66 = new SqlCommand("select * from Oda166", baglanti);
            SqlDataReader oku66 = komut66.ExecuteReader();

            while (oku66.Read())
            {
                BtnOda166.Text = oku66["Adi"].ToString() + " " + oku66["Soyadi"].ToString() + " " + oku66["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda166.Text != "7066")
            {
                BtnOda166.BackColor = Color.Red;
                BtnOda166.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut67 = new SqlCommand("select * from Oda167", baglanti);
            SqlDataReader oku67 = komut67.ExecuteReader();

            while (oku67.Read())
            {
                BtnOda167.Text = oku67["Adi"].ToString() + " " + oku67["Soyadi"].ToString() + " " + oku67["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda167.Text != "7067")
            {
                BtnOda167.BackColor = Color.Red;
                BtnOda167.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut68 = new SqlCommand("select * from Oda168", baglanti);
            SqlDataReader oku68 = komut68.ExecuteReader();

            while (oku68.Read())
            {
                BtnOda168.Text = oku68["Adi"].ToString() + " " + oku68["Soyadi"].ToString() + " " + oku68["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda168.Text != "7068")
            {
                BtnOda168.BackColor = Color.Red;
                BtnOda168.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut69 = new SqlCommand("select * from Oda169", baglanti);
            SqlDataReader oku69 = komut69.ExecuteReader();

            while (oku69.Read())
            {
                BtnOda169.Text = oku69["Adi"].ToString() + " " + oku69["Soyadi"].ToString() + " " + oku69["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda169.Text != "7069")
            {
                BtnOda169.BackColor = Color.Red;
                BtnOda169.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut70 = new SqlCommand("select * from Oda170", baglanti);
            SqlDataReader oku70 = komut70.ExecuteReader();

            while (oku70.Read())
            {
                BtnOda170.Text = oku70["Adi"].ToString() + " " + oku70["Soyadi"].ToString() + " " + oku70["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda170.Text != "7070")
            {
                BtnOda170.BackColor = Color.Red;
                BtnOda170.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut71 = new SqlCommand("select * from Oda171", baglanti);
            SqlDataReader oku71 = komut71.ExecuteReader();

            while (oku71.Read())
            {
                BtnOda171.Text = oku71["Adi"].ToString() + " " + oku71["Soyadi"].ToString() + " " + oku71["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda171.Text != "7071")
            {
                BtnOda171.BackColor = Color.Red;
                BtnOda171.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut72 = new SqlCommand("select * from Oda172", baglanti);
            SqlDataReader oku72 = komut70.ExecuteReader();

            while (oku72.Read())
            {
                BtnOda172.Text = oku72["Adi"].ToString() + " " + oku72["Soyadi"].ToString() + " " + oku72["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda172.Text != "7072")
            {
                BtnOda172.BackColor = Color.Red;
                BtnOda172.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut73 = new SqlCommand("select * from Oda173", baglanti);
            SqlDataReader oku73 = komut73.ExecuteReader();

            while (oku73.Read())
            {
                BtnOda173.Text = oku73["Adi"].ToString() + " " + oku73["Soyadi"].ToString() + " " + oku73["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda173.Text != "7073")
            {
                BtnOda173.BackColor = Color.Red;
                BtnOda173.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut74 = new SqlCommand("select * from Oda174", baglanti);
            SqlDataReader oku74 = komut74.ExecuteReader();

            while (oku74.Read())
            {
                BtnOda174.Text = oku74["Adi"].ToString() + " " + oku74["Soyadi"].ToString() + " " + oku74["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda174.Text != "7074")
            {
                BtnOda174.BackColor = Color.Red;
                BtnOda174.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut75 = new SqlCommand("select * from Oda175", baglanti);
            SqlDataReader oku75 = komut75.ExecuteReader();

            while (oku75.Read())
            {
                BtnOda175.Text = oku75["Adi"].ToString() + " " + oku75["Soyadi"].ToString() + " " + oku75["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda175.Text != "7075")
            {
                BtnOda175.BackColor = Color.Red;
                BtnOda175.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut76 = new SqlCommand("select * from Oda176", baglanti);
            SqlDataReader oku76 = komut76.ExecuteReader();

            while (oku76.Read())
            {
                BtnOda176.Text = oku76["Adi"].ToString() + " " + oku76["Soyadi"].ToString() + " " + oku76["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda176.Text != "7076")
            {
                BtnOda176.BackColor = Color.Red;
                BtnOda176.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut77 = new SqlCommand("select * from Oda177", baglanti);
            SqlDataReader oku77 = komut77.ExecuteReader();

            while (oku77.Read())
            {
                BtnOda177.Text = oku77["Adi"].ToString() + " " + oku77["Soyadi"].ToString() + " " + oku77["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda177.Text != "7077")
            {
                BtnOda177.BackColor = Color.Red;
                BtnOda177.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut78 = new SqlCommand("select * from Oda178", baglanti);
            SqlDataReader oku78 = komut78.ExecuteReader();

            while (oku78.Read())
            {
                BtnOda178.Text = oku78["Adi"].ToString() + " " + oku78["Soyadi"].ToString() + " " + oku78["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda178.Text != "7078")
            {
                BtnOda178.BackColor = Color.Red;
                BtnOda178.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut79 = new SqlCommand("select * from Oda179", baglanti);
            SqlDataReader oku79 = komut79.ExecuteReader();

            while (oku79.Read())
            {
                BtnOda179.Text = oku79["Adi"].ToString() + " " + oku79["Soyadi"].ToString() + " " + oku79["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda179.Text != "7079")
            {
                BtnOda179.BackColor = Color.Red;
                BtnOda179.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut80 = new SqlCommand("select * from Oda180", baglanti);
            SqlDataReader oku80 = komut80.ExecuteReader();

            while (oku80.Read())
            {
                BtnOda180.Text = oku80["Adi"].ToString() + " " + oku80["Soyadi"].ToString() + " " + oku80["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda180.Text != "7080")
            {
                BtnOda180.BackColor = Color.Red;
                BtnOda180.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut81 = new SqlCommand("select * from Oda181", baglanti);
            SqlDataReader oku81 = komut81.ExecuteReader();

            while (oku81.Read())
            {
                BtnOda181.Text = oku81["Adi"].ToString() + " " + oku81["Soyadi"].ToString() + " " + oku81["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda181.Text != "7081")
            {
                BtnOda181.BackColor = Color.Red;
                BtnOda181.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut82 = new SqlCommand("select * from Oda182", baglanti);
            SqlDataReader oku82 = komut82.ExecuteReader();

            while (oku82.Read())
            {
                BtnOda182.Text = oku82["Adi"].ToString() + " " + oku82["Soyadi"].ToString() + " " + oku82["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda182.Text != "7082")
            {
                BtnOda182.BackColor = Color.Red;
                BtnOda182.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut83 = new SqlCommand("select * from Oda183", baglanti);
            SqlDataReader oku83 = komut83.ExecuteReader();

            while (oku83.Read())
            {
                BtnOda183.Text = oku83["Adi"].ToString() + " " + oku83["Soyadi"].ToString() + " " + oku83["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda183.Text != "7083")
            {
                BtnOda183.BackColor = Color.Red;
                BtnOda183.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut84 = new SqlCommand("select * from Oda184", baglanti);
            SqlDataReader oku84 = komut84.ExecuteReader();

            while (oku84.Read())
            {
                BtnOda184.Text = oku84["Adi"].ToString() + " " + oku84["Soyadi"].ToString() + " " + oku84["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda184.Text != "7084")
            {
                BtnOda184.BackColor = Color.Red;
                BtnOda184.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut85 = new SqlCommand("select * from Oda185", baglanti);
            SqlDataReader oku85 = komut85.ExecuteReader();

            while (oku85.Read())
            {
                BtnOda185.Text = oku85["Adi"].ToString() + " " + oku85["Soyadi"].ToString() + " " + oku85["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda185.Text != "7085")
            {
                BtnOda185.BackColor = Color.Red;
                BtnOda185.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut86 = new SqlCommand("select * from Oda186", baglanti);
            SqlDataReader oku86 = komut86.ExecuteReader();

            while (oku86.Read())
            {
                BtnOda186.Text = oku86["Adi"].ToString() + " " + oku86["Soyadi"].ToString() + " " + oku86["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda186.Text != "7086")
            {
                BtnOda186.BackColor = Color.Red;
                BtnOda186.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut87 = new SqlCommand("select * from Oda187", baglanti);
            SqlDataReader oku87 = komut87.ExecuteReader();

            while (oku87.Read())
            {
                BtnOda187.Text = oku87["Adi"].ToString() + " " + oku87["Soyadi"].ToString() + " " + oku87["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda187.Text != "7087")
            {
                BtnOda187.BackColor = Color.Red;
                BtnOda187.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut88 = new SqlCommand("select * from Oda188", baglanti);
            SqlDataReader oku88 = komut88.ExecuteReader();

            while (oku88.Read())
            {
                BtnOda188.Text = oku88["Adi"].ToString() + " " + oku88["Soyadi"].ToString() + " " + oku88["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda188.Text != "7088")
            {
                BtnOda188.BackColor = Color.Red;
                BtnOda188.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut89 = new SqlCommand("select * from Oda189", baglanti);
            SqlDataReader oku89 = komut89.ExecuteReader();

            while (oku89.Read())
            {
                BtnOda189.Text = oku89["Adi"].ToString() + " " + oku89["Soyadi"].ToString() + " " + oku89["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda189.Text != "7089")
            {
                BtnOda189.BackColor = Color.Red;
                BtnOda189.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut90 = new SqlCommand("select * from Oda190", baglanti);
            SqlDataReader oku90 = komut90.ExecuteReader();

            while (oku90.Read())
            {
                BtnOda190.Text = oku90["Adi"].ToString() + " " + oku90["Soyadi"].ToString() + " " + oku90["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda190.Text != "7090")
            {
                BtnOda190.BackColor = Color.Red;
                BtnOda190.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut91 = new SqlCommand("select * from Oda191", baglanti);
            SqlDataReader oku91 = komut91.ExecuteReader();

            while (oku91.Read())
            {
                BtnOda191.Text = oku91["Adi"].ToString() + " " + oku91["Soyadi"].ToString() + " " + oku91["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda191.Text != "7091")
            {
                BtnOda191.BackColor = Color.Red;
                BtnOda191.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut92 = new SqlCommand("select * from Oda192", baglanti);
            SqlDataReader oku92 = komut92.ExecuteReader();

            while (oku92.Read())
            {
                BtnOda192.Text = oku91["Adi"].ToString() + " " + oku91["Soyadi"].ToString() + " " + oku91["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda192.Text != "7092")
            {
                BtnOda192.BackColor = Color.Red;
                BtnOda192.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut93 = new SqlCommand("select * from Oda193", baglanti);
            SqlDataReader oku93 = komut93.ExecuteReader();

            while (oku93.Read())
            {
                BtnOda193.Text = oku93["Adi"].ToString() + " " + oku93["Soyadi"].ToString() + " " + oku93["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda193.Text != "7093")
            {
                BtnOda193.BackColor = Color.Red;
                BtnOda193.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut94 = new SqlCommand("select * from Oda194", baglanti);
            SqlDataReader oku94 = komut94.ExecuteReader();

            while (oku94.Read())
            {
                BtnOda194.Text = oku94["Adi"].ToString() + " " + oku94["Soyadi"].ToString() + " " + oku94["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda194.Text != "7094")
            {
                BtnOda194.BackColor = Color.Red;
                BtnOda194.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut95 = new SqlCommand("select * from Oda195", baglanti);
            SqlDataReader oku95 = komut95.ExecuteReader();

            while (oku95.Read())
            {
                BtnOda195.Text = oku95["Adi"].ToString() + " " + oku95["Soyadi"].ToString() + " " + oku95["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda195.Text != "7095")
            {
                BtnOda195.BackColor = Color.Red;
                BtnOda195.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut96 = new SqlCommand("select * from Oda196", baglanti);
            SqlDataReader oku96 = komut96.ExecuteReader();

            while (oku96.Read())
            {
                BtnOda196.Text = oku96["Adi"].ToString() + " " + oku96["Soyadi"].ToString() + " " + oku96["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda196.Text != "7096")
            {
                BtnOda196.BackColor = Color.Red;
                BtnOda196.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut97 = new SqlCommand("select * from Oda197", baglanti);
            SqlDataReader oku97 = komut97.ExecuteReader();

            while (oku97.Read())
            {
                BtnOda197.Text = oku97["Adi"].ToString() + " " + oku97["Soyadi"].ToString() + " " + oku97["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda197.Text != "7097")
            {
                BtnOda197.BackColor = Color.Red;
                BtnOda197.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut98 = new SqlCommand("select * from Oda198", baglanti);
            SqlDataReader oku98 = komut98.ExecuteReader();

            while (oku98.Read())
            {
                BtnOda198.Text = oku98["Adi"].ToString() + " " + oku98["Soyadi"].ToString() + " " + oku98["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda198.Text != "7098")
            {
                BtnOda198.BackColor = Color.Red;
                BtnOda198.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut99 = new SqlCommand("select * from Oda199", baglanti);
            SqlDataReader oku99 = komut99.ExecuteReader();

            while (oku99.Read())
            {
                BtnOda199.Text = oku99["Adi"].ToString() + " " + oku99["Soyadi"].ToString() + " " + oku99["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda199.Text != "7099")
            {
                BtnOda199.BackColor = Color.Red;
                BtnOda199.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut100 = new SqlCommand("select * from Oda200", baglanti);
            SqlDataReader oku100 = komut99.ExecuteReader();

            while (oku100.Read())
            {
                BtnOda200.Text = oku100["Adi"].ToString() + " " + oku100["Soyadi"].ToString() + " " + oku100["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda200.Text != "7100")
            {
                BtnOda200.BackColor = Color.Red;
                BtnOda200.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut101 = new SqlCommand("select * from Oda201", baglanti);
            SqlDataReader oku101 = komut101.ExecuteReader();

            while (oku101.Read())
            {
                BtnOda201.Text = oku101["Adi"].ToString() + " " + oku101["Soyadi"].ToString() + " " + oku101["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda201.Text != "7101")
            {
                BtnOda201.BackColor = Color.Red;
                BtnOda201.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut102 = new SqlCommand("select * from Oda202", baglanti);
            SqlDataReader oku102 = komut102.ExecuteReader();

            while (oku102.Read())
            {
                BtnOda202.Text = oku102["Adi"].ToString() + " " + oku102["Soyadi"].ToString() + " " + oku102["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda202.Text != "7102")
            {
                BtnOda202.BackColor = Color.Red;
                BtnOda202.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut103 = new SqlCommand("select * from Oda203", baglanti);
            SqlDataReader oku103 = komut103.ExecuteReader();

            while (oku103.Read())
            {
                BtnOda203.Text = oku103["Adi"].ToString() + " " + oku103["Soyadi"].ToString() + " " + oku103["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda203.Text != "7103")
            {
                BtnOda203.BackColor = Color.Red;
                BtnOda203.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut104 = new SqlCommand("select * from Oda204", baglanti);
            SqlDataReader oku104 = komut104.ExecuteReader();

            while (oku104.Read())
            {
                BtnOda204.Text = oku104["Adi"].ToString() + " " + oku104["Soyadi"].ToString() + " " + oku104["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda204.Text != "7104")
            {
                BtnOda204.BackColor = Color.Red;
                BtnOda204.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut105 = new SqlCommand("select * from Oda205", baglanti);
            SqlDataReader oku105 = komut105.ExecuteReader();

            while (oku105.Read())
            {
                BtnOda205.Text = oku105["Adi"].ToString() + " " + oku105["Soyadi"].ToString() + " " + oku105["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda205.Text != "7105")
            {
                BtnOda205.BackColor = Color.Red;
                BtnOda205.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut106 = new SqlCommand("select * from Oda206", baglanti);
            SqlDataReader oku106 = komut106.ExecuteReader();

            while (oku106.Read())
            {
                BtnOda206.Text = oku106["Adi"].ToString() + " " + oku106["Soyadi"].ToString() + " " + oku106["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda206.Text != "7106")
            {
                BtnOda206.BackColor = Color.Red;
                BtnOda206.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut107 = new SqlCommand("select * from Oda207", baglanti);
            SqlDataReader oku107 = komut107.ExecuteReader();

            while (oku107.Read())
            {
                BtnOda207.Text = oku107["Adi"].ToString() + " " + oku107["Soyadi"].ToString() + " " + oku107["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda207.Text != "7107")
            {
                BtnOda207.BackColor = Color.Red;
                BtnOda207.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut108 = new SqlCommand("select * from Oda208", baglanti);
            SqlDataReader oku108 = komut108.ExecuteReader();

            while (oku108.Read())
            {
                BtnOda208.Text = oku108["Adi"].ToString() + " " + oku108["Soyadi"].ToString() + " " + oku108["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda208.Text != "7108")
            {
                BtnOda208.BackColor = Color.Red;
                BtnOda208.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut109 = new SqlCommand("select * from Oda209", baglanti);
            SqlDataReader oku109 = komut109.ExecuteReader();

            while (oku109.Read())
            {
                BtnOda209.Text = oku109["Adi"].ToString() + " " + oku109["Soyadi"].ToString() + " " + oku109["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda209.Text != "7109")
            {
                BtnOda209.BackColor = Color.Red;
                BtnOda209.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut110 = new SqlCommand("select * from Oda210", baglanti);
            SqlDataReader oku110 = komut110.ExecuteReader();

            while (oku110.Read())
            {
                BtnOda210.Text = oku110["Adi"].ToString() + " " + oku110["Soyadi"].ToString() + " " + oku110["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda210.Text != "7110")
            {
                BtnOda210.BackColor = Color.Red;
                BtnOda210.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut111 = new SqlCommand("select * from Oda211", baglanti);
            SqlDataReader oku111 = komut111.ExecuteReader();

            while (oku111.Read())
            {
                BtnOda211.Text = oku111["Adi"].ToString() + " " + oku111["Soyadi"].ToString() + " " + oku111["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda211.Text != "7111")
            {
                BtnOda211.BackColor = Color.Red;
                BtnOda211.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut112 = new SqlCommand("select * from Oda212", baglanti);
            SqlDataReader oku112 = komut112.ExecuteReader();

            while (oku112.Read())
            {
                BtnOda212.Text = oku112["Adi"].ToString() + " " + oku112["Soyadi"].ToString() + " " + oku112["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda212.Text != "7112")
            {
                BtnOda212.BackColor = Color.Red;
                BtnOda212.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut113 = new SqlCommand("select * from Oda213", baglanti);
            SqlDataReader oku113 = komut113.ExecuteReader();

            while (oku113.Read())
            {
                BtnOda213.Text = oku113["Adi"].ToString() + " " + oku113["Soyadi"].ToString() + " " + oku113["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda213.Text != "7113")
            {
                BtnOda213.BackColor = Color.Red;
                BtnOda213.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut114 = new SqlCommand("select * from Oda214", baglanti);
            SqlDataReader oku114 = komut114.ExecuteReader();

            while (oku114.Read())
            {
                BtnOda214.Text = oku114["Adi"].ToString() + " " + oku114["Soyadi"].ToString() + " " + oku114["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda214.Text != "7114")
            {
                BtnOda214.BackColor = Color.Red;
                BtnOda214.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut115 = new SqlCommand("select * from Oda215", baglanti);
            SqlDataReader oku115 = komut115.ExecuteReader();

            while (oku115.Read())
            {
                BtnOda215.Text = oku115["Adi"].ToString() + " " + oku115["Soyadi"].ToString() + " " + oku115["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda215.Text != "7115")
            {
                BtnOda215.BackColor = Color.Red;
                BtnOda215.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut116 = new SqlCommand("select * from Oda216", baglanti);
            SqlDataReader oku116 = komut116.ExecuteReader();

            while (oku116.Read())
            {
                BtnOda216.Text = oku116["Adi"].ToString() + " " + oku116["Soyadi"].ToString() + " " + oku116["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda216.Text != "7116")
            {
                BtnOda216.BackColor = Color.Red;
                BtnOda216.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut117 = new SqlCommand("select * from Oda217", baglanti);
            SqlDataReader oku117 = komut117.ExecuteReader();

            while (oku117.Read())
            {
                BtnOda217.Text = oku117["Adi"].ToString() + " " + oku117["Soyadi"].ToString() + " " + oku117["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda217.Text != "7117")
            {
                BtnOda217.BackColor = Color.Red;
                BtnOda217.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut118 = new SqlCommand("select * from Oda218", baglanti);
            SqlDataReader oku118 = komut118.ExecuteReader();

            while (oku118.Read())
            {
                BtnOda218.Text = oku118["Adi"].ToString() + " " + oku118["Soyadi"].ToString() + " " + oku118["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda218.Text != "7118")
            {
                BtnOda218.BackColor = Color.Red;
                BtnOda218.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut119 = new SqlCommand("select * from Oda219", baglanti);
            SqlDataReader oku119 = komut119.ExecuteReader();

            while (oku119.Read())
            {
                BtnOda219.Text = oku119["Adi"].ToString() + " " + oku119["Soyadi"].ToString() + " " + oku119["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda219.Text != "7119")
            {
                BtnOda219.BackColor = Color.Red;
                BtnOda219.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut120 = new SqlCommand("select * from Oda220", baglanti);
            SqlDataReader oku120 = komut120.ExecuteReader();

            while (oku120.Read())
            {
                BtnOda220.Text = oku120["Adi"].ToString() + " " + oku120["Soyadi"].ToString() + " " + oku120["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda220.Text != "7120")
            {
                BtnOda220.BackColor = Color.Red;
                BtnOda220.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut121 = new SqlCommand("select * from Oda221", baglanti);
            SqlDataReader oku121 = komut121.ExecuteReader();

            while (oku121.Read())
            {
                BtnOda221.Text = oku121["Adi"].ToString() + " " + oku121["Soyadi"].ToString() + " " + oku121["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda221.Text != "7121")
            {
                BtnOda221.BackColor = Color.Red;
                BtnOda221.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut122 = new SqlCommand("select * from Oda222", baglanti);
            SqlDataReader oku122 = komut122.ExecuteReader();

            while (oku122.Read())
            {
                BtnOda222.Text = oku122["Adi"].ToString() + " " + oku122["Soyadi"].ToString() + " " + oku122["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda222.Text != "7122")
            {
                BtnOda222.BackColor = Color.Red;
                BtnOda222.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut123 = new SqlCommand("select * from Oda223", baglanti);
            SqlDataReader oku123 = komut123.ExecuteReader();

            while (oku123.Read())
            {
                BtnOda223.Text = oku123["Adi"].ToString() + " " + oku123["Soyadi"].ToString() + " " + oku123["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda223.Text != "7123")
            {
                BtnOda223.BackColor = Color.Red;
                BtnOda223.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut124 = new SqlCommand("select * from Oda224", baglanti);
            SqlDataReader oku124 = komut124.ExecuteReader();

            while (oku124.Read())
            {
                BtnOda224.Text = oku124["Adi"].ToString() + " " + oku124["Soyadi"].ToString() + " " + oku124["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda224.Text != "7124")
            {
                BtnOda224.BackColor = Color.Red;
                BtnOda224.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut125 = new SqlCommand("select * from Oda225", baglanti);
            SqlDataReader oku125 = komut125.ExecuteReader();

            while (oku125.Read())
            {
                BtnOda225.Text = oku125["Adi"].ToString() + " " + oku125["Soyadi"].ToString() + " " + oku125["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda225.Text != "7125")
            {
                BtnOda225.BackColor = Color.Red;
                BtnOda225.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut126 = new SqlCommand("select * from Oda226", baglanti);
            SqlDataReader oku126 = komut126.ExecuteReader();

            while (oku126.Read())
            {
                BtnOda226.Text = oku126["Adi"].ToString() + " " + oku126["Soyadi"].ToString() + " " + oku126["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda226.Text != "7126")
            {
                BtnOda226.BackColor = Color.Red;
                BtnOda226.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut127 = new SqlCommand("select * from Oda227", baglanti);
            SqlDataReader oku127 = komut127.ExecuteReader();

            while (oku127.Read())
            {
                BtnOda227.Text = oku127["Adi"].ToString() + " " + oku127["Soyadi"].ToString() + " " + oku127["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda227.Text != "7127")
            {
                BtnOda227.BackColor = Color.Red;
                BtnOda227.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut128 = new SqlCommand("select * from Oda228", baglanti);
            SqlDataReader oku128 = komut128.ExecuteReader();

            while (oku128.Read())
            {
                BtnOda228.Text = oku128["Adi"].ToString() + " " + oku128["Soyadi"].ToString() + " " + oku128["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda228.Text != "7128")
            {
                BtnOda228.BackColor = Color.Red;
                BtnOda228.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut129 = new SqlCommand("select * from Oda229", baglanti);
            SqlDataReader oku129 = komut129.ExecuteReader();

            while (oku129.Read())
            {
                BtnOda229.Text = oku129["Adi"].ToString() + " " + oku129["Soyadi"].ToString() + " " + oku129["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda229.Text != "7129")
            {
                BtnOda229.BackColor = Color.Red;
                BtnOda229.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut130 = new SqlCommand("select * from Oda230", baglanti);
            SqlDataReader oku130 = komut130.ExecuteReader();

            while (oku130.Read())
            {
                BtnOda230.Text = oku130["Adi"].ToString() + " " + oku130["Soyadi"].ToString() + " " + oku130["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda230.Text != "7130")
            {
                BtnOda230.BackColor = Color.Red;
                BtnOda230.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut131 = new SqlCommand("select * from Oda230", baglanti);
            SqlDataReader oku131 = komut131.ExecuteReader();

            while (oku131.Read())
            {
                BtnOda231.Text = oku131["Adi"].ToString() + " " + oku131["Soyadi"].ToString() + " " + oku131["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda231.Text != "7131")
            {
                BtnOda231.BackColor = Color.Red;
                BtnOda231.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut132 = new SqlCommand("select * from Oda232", baglanti);
            SqlDataReader oku132 = komut132.ExecuteReader();

            while (oku132.Read())
            {
                BtnOda232.Text = oku132["Adi"].ToString() + " " + oku132["Soyadi"].ToString() + " " + oku132["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda232.Text != "7132")
            {
                BtnOda232.BackColor = Color.Red;
                BtnOda232.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut133 = new SqlCommand("select * from Oda233", baglanti);
            SqlDataReader oku133 = komut132.ExecuteReader();

            while (oku133.Read())
            {
                BtnOda233.Text = oku133["Adi"].ToString() + " " + oku133["Soyadi"].ToString() + " " + oku133["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda233.Text != "7133")
            {
                BtnOda233.BackColor = Color.Red;
                BtnOda233.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut134 = new SqlCommand("select * from Oda234", baglanti);
            SqlDataReader oku134 = komut132.ExecuteReader();

            while (oku134.Read())
            {
                BtnOda234.Text = oku134["Adi"].ToString() + " " + oku134["Soyadi"].ToString() + " " + oku134["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda234.Text != "7134")
            {
                BtnOda234.BackColor = Color.Red;
                BtnOda234.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut135 = new SqlCommand("select * from Oda235", baglanti);
            SqlDataReader oku135 = komut135.ExecuteReader();

            while (oku135.Read())
            {
                BtnOda235.Text = oku135["Adi"].ToString() + " " + oku135["Soyadi"].ToString() + " " + oku135["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda235.Text != "7135")
            {
                BtnOda235.BackColor = Color.Red;
                BtnOda235.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut136 = new SqlCommand("select * from Oda236", baglanti);
            SqlDataReader oku136 = komut136.ExecuteReader();

            while (oku136.Read())
            {
                BtnOda236.Text = oku136["Adi"].ToString() + " " + oku136["Soyadi"].ToString() + " " + oku136["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda236.Text != "7136")
            {
                BtnOda236.BackColor = Color.Red;
                BtnOda236.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut137 = new SqlCommand("select * from Oda237", baglanti);
            SqlDataReader oku137 = komut136.ExecuteReader();

            while (oku137.Read())
            {
                BtnOda237.Text = oku137["Adi"].ToString() + " " + oku137["Soyadi"].ToString() + " " + oku137["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda237.Text != "7137")
            {
                BtnOda237.BackColor = Color.Red;
                BtnOda237.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut138 = new SqlCommand("select * from Oda238", baglanti);
            SqlDataReader oku138 = komut136.ExecuteReader();

            while (oku138.Read())
            {
                BtnOda238.Text = oku138["Adi"].ToString() + " " + oku138["Soyadi"].ToString() + " " + oku138["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda238.Text != "7138")
            {
                BtnOda238.BackColor = Color.Red;
                BtnOda238.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut139 = new SqlCommand("select * from Oda239", baglanti);
            SqlDataReader oku139 = komut136.ExecuteReader();

            while (oku139.Read())
            {
                BtnOda239.Text = oku139["Adi"].ToString() + " " + oku139["Soyadi"].ToString() + " " + oku139["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda239.Text != "7139")
            {
                BtnOda239.BackColor = Color.Red;
                BtnOda239.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut140 = new SqlCommand("select * from Oda240", baglanti);
            SqlDataReader oku140 = komut140.ExecuteReader();

            while (oku140.Read())
            {
                BtnOda240.Text = oku140["Adi"].ToString() + " " + oku140["Soyadi"].ToString() + " " + oku140["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda240.Text != "7140")
            {
                BtnOda240.BackColor = Color.Red;
                BtnOda240.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut141 = new SqlCommand("select * from Oda241", baglanti);
            SqlDataReader oku141 = komut140.ExecuteReader();

            while (oku141.Read())
            {
                BtnOda241.Text = oku141["Adi"].ToString() + " " + oku141["Soyadi"].ToString() + " " + oku141["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda241.Text != "7141")
            {
                BtnOda241.BackColor = Color.Red;
                BtnOda241.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut142 = new SqlCommand("select * from Oda242", baglanti);
            SqlDataReader oku142 = komut140.ExecuteReader();

            while (oku142.Read())
            {
                BtnOda242.Text = oku142["Adi"].ToString() + " " + oku142["Soyadi"].ToString() + " " + oku142["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda242.Text != "7142")
            {
                BtnOda242.BackColor = Color.Red;
                BtnOda242.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut143 = new SqlCommand("select * from Oda243", baglanti);
            SqlDataReader oku143 = komut140.ExecuteReader();

            while (oku143.Read())
            {
                BtnOda243.Text = oku143["Adi"].ToString() + " " + oku143["Soyadi"].ToString() + " " + oku143["OdaNo"].ToString();
            }
            baglanti.Close();
            if (BtnOda243.Text != "7143")
            {
                BtnOda243.BackColor = Color.Red;
                BtnOda243.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label13.Text = DateTime.Now.ToLongDateString();
            label14.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label13.Text = DateTime.Now.ToLongDateString();
            label14.Text = DateTime.Now.ToLongTimeString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button99_Click(object sender, EventArgs e)
        {

        }

        private void button89_Click(object sender, EventArgs e)
        {

        }

        private void button79_Click(object sender, EventArgs e)
        {

        }

        private void button69_Click(object sender, EventArgs e)
        {

        }

        private void button52_Click(object sender, EventArgs e)
        {

        }

        private void button53_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "179";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda180(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            TxtOdaNo.Text = "184";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda184(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            label13.Text = DateTime.Now.ToLongDateString();
            label14.Text = DateTime.Now.ToLongTimeString();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "123";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda123(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda120_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "124";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda124(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda122_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "126";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda126(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda121_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "125";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda125(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button69_Click_1(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "7010";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda110(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button77_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "7011";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda111(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button93_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "7013";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda113(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button85_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "7012";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda112(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda136_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "136";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda136(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda137_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "137";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda137(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda138_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "138";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda138(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda139_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "139";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda139(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda149_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "149";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda149(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda150_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "150";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda150(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda151_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "151";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda151(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda152_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "152";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda152(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda162_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "162";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda152(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda163_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "163";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda163(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda164_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "164";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda164(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda165_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "165";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda165(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda175_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "175";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda175(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda176_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "176";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda176(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda177_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "177";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda177(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda178_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "178";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda178(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda179_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "179";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda179(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda181_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "180";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda180(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda182_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "181";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda181(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda183_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "182";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda182(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda184_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "183";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda183(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda186_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "185";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda185(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda187_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "186";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda186(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda188_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "187";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda187(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda189_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "188";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda188(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda190_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "189";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda189(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda191_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "190";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda190(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button87_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "191";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda191(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda194_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "192";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda192(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda194_Click_1(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "193";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda193(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda195_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "194";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda194(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda196_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "195";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda195(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda197_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "196";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda196(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda199_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "198";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda198(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda198_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "197";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda197(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda200_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "199";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda199(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda201_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "200";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda200(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "201";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda201(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda204_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "203";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda203(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "202";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda202(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button86_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "204";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda204(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda206_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "205";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda205(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "206";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda206(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "207";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda207(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda209_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "208";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda208(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "209";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda209(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda212_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "211";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda211(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda211_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "210";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda210(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda213_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "212";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda212(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda214_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "213";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda213(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda215_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "214";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda214(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda216_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "215";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda215(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "216";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda216(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda217_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "217";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda217(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda218_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "218";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda218(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda219_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "219";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda219(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda220_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "220";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda220(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda221_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "221";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda221(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "222";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda222(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "223";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda223(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda224_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "224";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda224(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda225_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "225";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda225(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda226_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "226";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda226(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda227_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "227";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda227(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "228";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda228(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda229_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "229";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda229(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda230_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "230";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda230(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda231_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "231";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda231(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button55_Click_1(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "232";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda232(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button35_Click_1(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "233";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda233(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "234";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda234(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "236";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda236(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda235_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "235";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda235(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda237_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "237";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda237(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "238";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda238(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda239_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "239";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda239(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "240";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda240(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "241";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda241(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda242_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "242";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda242(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda243_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "243";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  Oda243(Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
