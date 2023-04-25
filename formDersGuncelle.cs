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
    public partial class formDersGuncelle : Form
    {
        public formDersGuncelle()
        {
            InitializeComponent();
        }

        NpgsqlConnection erisim = new NpgsqlConnection("Server=localhost;Port=5432;Database=Odev;User Id=postgres;Password=1234");
        formAnaSayfa anaSayfa = new formAnaSayfa();

        public string bilgi { get; set; }

        public void eskiDersiGoster()
        {
            erisim.Open();
            NpgsqlCommand goster = new NpgsqlCommand();
            goster.Connection = erisim;
            goster.Parameters.AddWithValue("@eskibilgi", mskdtxtDersBilgi.Text);
            goster.CommandType = CommandType.Text;
            goster.CommandText = "select * from dersislem where DersKodu = @eskibilgi";
            NpgsqlDataReader dr = goster.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridViewDersBilgiEski.DataSource = dt;
            }
            goster.Dispose();
            erisim.Close();
        }

        public void yeniDersiGoster()
        {
            erisim.Open();
            NpgsqlCommand goster = new NpgsqlCommand();
            goster.Connection = erisim;
            goster.Parameters.AddWithValue("@yenibilgi", mskdtxtDersKodu.Text);
            goster.CommandType = CommandType.Text;
            goster.CommandText = "select * from dersislem where DersKodu = @yenibilgi";
            NpgsqlDataReader dr = goster.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridViewDersBilgiYeni.DataSource = dt;
            }
            goster.Dispose();
            erisim.Close();
        }

        private void btnDersBilgi_Click(object sender, EventArgs e)
        {
            eskiDersiGoster();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            erisim.Open();
            NpgsqlCommand guncelle = new NpgsqlCommand();
            guncelle.Connection = erisim;

            guncelle.Parameters.AddWithValue("@kod", mskdtxtDersKodu.Text);
            guncelle.Parameters.AddWithValue("@ad", txtDersAdi.Text);
            guncelle.Parameters.AddWithValue("@kredi", Convert.ToInt32(mskdtxtKredi.Text));
            guncelle.Parameters.AddWithValue("@akts", Convert.ToInt32(mskdtxtAkts.Text));
            guncelle.Parameters.AddWithValue("@ogruye", txtOgrUye.Text);
            guncelle.Parameters.AddWithValue("@donem", txtDonem.Text);
            guncelle.Parameters.AddWithValue("@harfnotu", mskdtxtHarfNotu.Text);
            guncelle.Parameters.AddWithValue("@bilgi", mskdtxtDersBilgi.Text);

            guncelle.CommandType = CommandType.Text;
            guncelle.CommandText = "update dersislem set DersKodu=@kod, DersAdi=@ad, Kredi=@kredi, AKTS= @akts, OgrUyeAdSoyad=@ogruye, Donem=@donem, HarfNotu=@harfnotu " +
                                   "where DersKodu = @bilgi";

            NpgsqlDataReader dr = guncelle.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                anaSayfa.dataGridViewTablo.DataSource = dt;
            }
            guncelle.Dispose();
            erisim.Close();

            MessageBox.Show("Ders güncelleme başarılı.");

            yeniDersiGoster();
        }
    }
}
