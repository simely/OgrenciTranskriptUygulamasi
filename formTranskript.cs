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
    public partial class formTranskript : Form
    {
        public formTranskript()
        {
            InitializeComponent();
        }

        NpgsqlConnection erisim = new NpgsqlConnection("Server=localhost;Port=5432;Database=Odev;User Id=postgres;Password=1234");

        public void alinanDersGoster()
        {
            erisim.Open();
            NpgsqlCommand transkript = new NpgsqlCommand();
            transkript.Connection = erisim;
            transkript.CommandType = CommandType.Text;
            transkript.CommandText = "select * from dersislem where harfnotu is not null";
            NpgsqlDataReader dr = transkript.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridViewAlinanDersler.DataSource = dt;
            }
            transkript.Dispose();
            erisim.Close();
        }

        private void btnAlinanDers_Click(object sender, EventArgs e)
        {
            alinanDersGoster();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            erisim.Open();
            NpgsqlCommand gano = new NpgsqlCommand();
            gano.Connection = erisim;
            gano.CommandType = CommandType.Text;
            gano.CommandText = "select harfnotu from dersislem where harfnotu is not null";
            NpgsqlDataReader harf = gano.ExecuteReader();

            string[] notlar = new string[25];
            for (int i = 0; i < notlar.Length; i++)
            {
               
            }
        }
    }
}
