﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OKUYUCU_TAKİP_SİSTEMİ
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-H0GVCUT;Initial Catalog=RftakipSistemi;Integrated Security=True;Encrypt=False");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where KullaniciAdi=@KullaniciAdi AND Sifre=@Sifresi";
                SqlParameter prm1 = new SqlParameter("KullaniciAdi", TxtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifresi", TxtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql,baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
