﻿using System;
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
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }
        public string numara;

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-2CVA09C;Initial Catalog=DbNotKayit;Integrated Security=True");
        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBL_DERS where OGR_NUM=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LBL_AdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                LBL_SNV1.Text = dr[4].ToString();
                LBL_SNV2.Text = dr[5].ToString();
                LBL_ORT.Text = dr[6].ToString();
                LBL_DURUM.Text = dr[7].ToString();
            }
            baglanti.Close();
        }

        private void LblNumara_Click(object sender, EventArgs e)
        {

        }
    }
}
