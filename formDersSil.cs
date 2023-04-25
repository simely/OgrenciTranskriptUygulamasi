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
    public partial class formDersSil : Form
    {
        public formDersSil()
        {
            InitializeComponent();
        }

        NpgsqlConnection erisim = new NpgsqlConnection("Server=localhost;Port=5432;Database=Odev;User Id=postgres;Password=1234");
        formAnaSayfa anaSayfa = new formAnaSayfa();

        private void btnSil_Click(object sender, EventArgs e)
        {
            erisim.Open();
            NpgsqlCommand sil = new NpgsqlCommand();
            sil.Connection = erisim;
            sil.Parameters.AddWithValue("@kod", mskdtxtSil.Text);

            sil.CommandType = CommandType.Text;
            sil.CommandText = "delete from dersislem where DersKodu = @kod";

            NpgsqlDataReader dr = sil.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                anaSayfa.dataGridViewTablo.DataSource = dt;
            }

            sil.Dispose();
            erisim.Close();

            MessageBox.Show("Ders silme başarılı.");
        }
    }
}
