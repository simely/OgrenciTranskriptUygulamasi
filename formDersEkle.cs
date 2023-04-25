using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BİL203_Odev2
{
    public partial class formDersEkle : Form
    {
        public formDersEkle()
        {
            InitializeComponent();
        }

        NpgsqlConnection erisim = new NpgsqlConnection("Server=localhost;Port=5432;Database=Odev;User Id=postgres;Password=1234");
        formAnaSayfa anaSayfa = new formAnaSayfa();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            erisim.Open();
            NpgsqlCommand ekle = new NpgsqlCommand();
            ekle.Connection = erisim;

            ekle.Parameters.AddWithValue("@kod", mskdtxtDersKodu.Text);
            ekle.Parameters.AddWithValue("@ad", txtDersAdi.Text);
            ekle.Parameters.AddWithValue("@kredi", Convert.ToInt32(mskdtxtKredi.Text));
            ekle.Parameters.AddWithValue("@akts", Convert.ToInt32(mskdtxtAkts.Text));
            ekle.Parameters.AddWithValue("@ogruye", txtOgrUye.Text);
            ekle.Parameters.AddWithValue("@donem", txtDonem.Text);
            ekle.Parameters.AddWithValue("@harfnotu", mskdtxtHarfNotu.Text);

            ekle.CommandType = CommandType.Text;
            ekle.CommandText = "insert into dersislem (DersKodu, DersAdi, Kredi, AKTS, OgrUyeAdSoyad, Donem, HarfNotu)" +
                               "values (@kod, @ad, @kredi, @akts, @ogruye, @donem, @harfnotu)";

            NpgsqlDataReader dr = ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                anaSayfa.dataGridViewTablo.DataSource = dt;
            }

            ekle.Dispose();
            erisim.Close();

            MessageBox.Show("Ders ekleme başarılı.");

        }
    }
}
