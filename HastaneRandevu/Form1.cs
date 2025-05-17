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

namespace HastaneRandevu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=.;Database=HastaneDB;Trusted_Connection=True;";
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Branslar", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbBrans.Items.Add(new
                    {
                        Text = reader["BransAdi"].ToString(),
                        Value = reader["Id"]
                    });
                }
            }

            // Saatleri ekle
            cmbSaat.Items.AddRange(new string[] { "09:00", "10:00", "11:00", "13:00", "14:00", "15:00" });
        
    }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            if (cmbBrans.SelectedItem == null || cmbDoktor.SelectedItem == null ||
       string.IsNullOrWhiteSpace(txtHastaAd.Text) || string.IsNullOrWhiteSpace(txtHastaSoyad.Text) ||
       cmbSaat.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            var tarihSaat = dtpTarih.Value.Date + TimeSpan.Parse(cmbSaat.SelectedItem.ToString());
            var doktorId = ((dynamic)cmbDoktor.SelectedItem).Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Çakışma kontrolü
                SqlCommand kontrolCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Randevular WHERE DoktorID = @doktorId AND Tarih = @tarih", conn);
                kontrolCmd.Parameters.AddWithValue("@doktorId", doktorId);
                kontrolCmd.Parameters.AddWithValue("@tarih", tarihSaat);

                int sayi = (int)kontrolCmd.ExecuteScalar();
                if (sayi > 0)
                {
                    MessageBox.Show("Bu doktor bu tarihte zaten bir randevuya sahip.");
                    return;
                }

                // Kayıt
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO Randevular (HastaAdi, HastaSoyadi, BransID, DoktorID, Tarih) VALUES (@ad, @soyad, @bransId, @doktorId, @tarih)", conn);
                insertCmd.Parameters.AddWithValue("@ad", txtHastaAd.Text);
                insertCmd.Parameters.AddWithValue("@soyad", txtHastaSoyad.Text);
                insertCmd.Parameters.AddWithValue("@bransId", ((dynamic)cmbBrans.SelectedItem).Value);
                insertCmd.Parameters.AddWithValue("@doktorId", doktorId);
                insertCmd.Parameters.AddWithValue("@tarih", tarihSaat);

                insertCmd.ExecuteNonQuery();
                MessageBox.Show("Randevu başarıyla oluşturuldu.");
            }
        }

        private void cmbBranslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            var bransId = ((dynamic)cmbBrans.SelectedItem).Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Doktorlar WHERE BransID = @bransId", conn);
                cmd.Parameters.AddWithValue("@bransId", bransId);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbDoktor.Items.Add(new
                    {
                        Text = reader["DoktorAdi"] + " " + reader["DoktorSoyadi"],
                        Value = reader["Id"]
                    });
                }
            }
        }
    }
}
