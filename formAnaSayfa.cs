using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace BİL203_Odev2
{
    public partial class formAnaSayfa : Form
    {
        public formAnaSayfa()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        NpgsqlConnection erisim = new NpgsqlConnection("Server=localhost;Port=5432;Database=Odev;User Id=postgres;Password=1234");


        public void tabloGoster()
        {
            erisim.Open();
            NpgsqlCommand goster = new NpgsqlCommand();
            goster.Connection = erisim;
            goster.CommandType = CommandType.Text;
            goster.CommandText = "select * from dersislem";
            NpgsqlDataReader dr = goster.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridViewTablo.DataSource = dt;
            }
            goster.Dispose();
            erisim.Close();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            tabloGoster();
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            formDersEkle ekle = new formDersEkle();
            ekle.Show();
        }

        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            formDersGuncelle guncelle = new formDersGuncelle();
            guncelle.Show();
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            formDersSil sil = new formDersSil();
            sil.Show();
        }

        private void btnTranskript_Click(object sender, EventArgs e)
        {
            formTranskript gano = new formTranskript();
            gano.Show();
        }
    }
}